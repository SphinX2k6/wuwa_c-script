using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ActivityAction
{
	// Token: 0x02005A92 RID: 23186
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ActivityActionBase : IStaticVariableResetter
	{
		// Token: 0x06039248 RID: 234056 RVA: 0x01000E1A File Offset: 0x00FFF01A
		static ActivityActionBase()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityActionBase.CreateStaticDefaultValue), new Action(ActivityActionBase.ResetStaticDefaultValue));
		}

		// Token: 0x06039249 RID: 234057 RVA: 0x01000E39 File Offset: 0x00FFF039
		public static void CreateStaticDefaultValue()
		{
			ActivityActionBase.SelfIncrementId = 0;
		}

		// Token: 0x0603924A RID: 234058 RVA: 0x01000E41 File Offset: 0x00FFF041
		public static void ResetStaticDefaultValue()
		{
			ActivityActionBase.SelfIncrementId = 0;
		}

		// Token: 0x17006CCE RID: 27854
		// (get) Token: 0x0603924B RID: 234059 RVA: 0x01000E49 File Offset: 0x00FFF049
		// (set) Token: 0x0603924C RID: 234060 RVA: 0x01000E51 File Offset: 0x00FFF051
		public int ActionId { get; internal set; }

		// Token: 0x0603924D RID: 234061 RVA: 0x01000E5A File Offset: 0x00FFF05A
		protected ActivityActionBase()
		{
			this.Uid = ActivityActionBase.SelfIncrementId++;
		}

		// Token: 0x17006CCF RID: 27855
		// (get) Token: 0x0603924E RID: 234062 RVA: 0x01000E75 File Offset: 0x00FFF075
		// (set) Token: 0x0603924F RID: 234063 RVA: 0x01000E7D File Offset: 0x00FFF07D
		public EActivityActionState State { get; private set; }

		// Token: 0x06039250 RID: 234064 RVA: 0x01000E86 File Offset: 0x00FFF086
		public bool IsDone()
		{
			return this.State == EActivityActionState.Done || this.State == EActivityActionState.Cancelled || this.State == EActivityActionState.Failed;
		}

		// Token: 0x06039251 RID: 234065 RVA: 0x01000EA5 File Offset: 0x00FFF0A5
		public bool IsFailed()
		{
			return this.State == EActivityActionState.Failed;
		}

		// Token: 0x06039252 RID: 234066 RVA: 0x01000EB0 File Offset: 0x00FFF0B0
		public bool IsRunning()
		{
			return this.State == EActivityActionState.Running;
		}

		// Token: 0x06039253 RID: 234067 RVA: 0x01000EBB File Offset: 0x00FFF0BB
		public void Start()
		{
			if (this.State != EActivityActionState.Idle)
			{
				return;
			}
			this.State = EActivityActionState.Running;
			this.OnStart();
		}

		// Token: 0x06039254 RID: 234068 RVA: 0x01000ED3 File Offset: 0x00FFF0D3
		public void Tick(float delta)
		{
			if (this.State != EActivityActionState.Running)
			{
				return;
			}
			this.OnTick(delta);
		}

		// Token: 0x06039255 RID: 234069 RVA: 0x01000EE6 File Offset: 0x00FFF0E6
		protected void MarkDone()
		{
			if (this.State == EActivityActionState.Running || this.State == EActivityActionState.Paused)
			{
				this.State = EActivityActionState.Done;
			}
		}

		// Token: 0x06039256 RID: 234070 RVA: 0x01000F04 File Offset: 0x00FFF104
		protected unsafe void MarkFailed()
		{
			if (this.State == EActivityActionState.Running || this.State == EActivityActionState.Paused)
			{
				this.State = EActivityActionState.Failed;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "ActivityAction 执行失败(MarkFailed)";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Uid", this.Uid);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionId", this.ActionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Type", base.GetType().Name);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
		}

		// Token: 0x06039257 RID: 234071 RVA: 0x01000FB9 File Offset: 0x00FFF1B9
		public void Finish()
		{
			this.Clean();
		}

		// Token: 0x06039258 RID: 234072 RVA: 0x01000FC1 File Offset: 0x00FFF1C1
		public void Delete()
		{
			if (this.IsDone())
			{
				this.Clean();
				return;
			}
			this.State = EActivityActionState.Cancelled;
			this.OnDelete();
			this.Clean();
		}

		// Token: 0x06039259 RID: 234073 RVA: 0x01000FE5 File Offset: 0x00FFF1E5
		public void Pause()
		{
			if (this.State != EActivityActionState.Running)
			{
				return;
			}
			this.State = EActivityActionState.Paused;
			this.OnPause();
		}

		// Token: 0x0603925A RID: 234074 RVA: 0x01000FFE File Offset: 0x00FFF1FE
		public void Resume()
		{
			if (this.State != EActivityActionState.Paused)
			{
				return;
			}
			this.State = EActivityActionState.Running;
			this.OnResume();
		}

		// Token: 0x0603925B RID: 234075 RVA: 0x01001017 File Offset: 0x00FFF217
		public void ParseParams(IReadOnlyDictionary<string, string> parameters)
		{
			this.OnParse(parameters);
		}

		// Token: 0x0603925C RID: 234076 RVA: 0x01001020 File Offset: 0x00FFF220
		[NullableContext(2)]
		public unsafe void SetFinishCallback(Action onDone, Action onAbort)
		{
			if (this.Cleaned)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "ActivityAction 已收口后再挂 FinishCallback，回调不会触发";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Uid", this.Uid);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionId", this.ActionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Type", base.GetType().Name);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			this.DoneCallback = onDone;
			this.AbortCallback = onAbort;
		}

		// Token: 0x0603925D RID: 234077 RVA: 0x010010D4 File Offset: 0x00FFF2D4
		private void Clean()
		{
			if (this.Cleaned)
			{
				return;
			}
			this.Cleaned = true;
			this.OnFinish();
			if (this.State == EActivityActionState.Done)
			{
				Action doneCallback = this.DoneCallback;
				if (doneCallback == null)
				{
					return;
				}
				doneCallback();
				return;
			}
			else
			{
				Action abortCallback = this.AbortCallback;
				if (abortCallback == null)
				{
					return;
				}
				abortCallback();
				return;
			}
		}

		// Token: 0x0603925E RID: 234078 RVA: 0x01001121 File Offset: 0x00FFF321
		protected virtual void OnStart()
		{
		}

		// Token: 0x0603925F RID: 234079 RVA: 0x01001123 File Offset: 0x00FFF323
		protected virtual void OnTick(float delta)
		{
		}

		// Token: 0x06039260 RID: 234080 RVA: 0x01001125 File Offset: 0x00FFF325
		protected virtual void OnFinish()
		{
		}

		// Token: 0x06039261 RID: 234081 RVA: 0x01001127 File Offset: 0x00FFF327
		protected virtual void OnDelete()
		{
		}

		// Token: 0x06039262 RID: 234082 RVA: 0x01001129 File Offset: 0x00FFF329
		protected virtual void OnPause()
		{
		}

		// Token: 0x06039263 RID: 234083 RVA: 0x0100112B File Offset: 0x00FFF32B
		protected virtual void OnResume()
		{
		}

		// Token: 0x06039264 RID: 234084 RVA: 0x0100112D File Offset: 0x00FFF32D
		protected virtual void OnParse(IReadOnlyDictionary<string, string> parameters)
		{
		}

		// Token: 0x06039265 RID: 234085 RVA: 0x01001130 File Offset: 0x00FFF330
		protected static int GetParamInt(IReadOnlyDictionary<string, string> parameters, string key, int defaultValue = 0)
		{
			string s;
			int result;
			if (!parameters.TryGetValue(key, out s) || !int.TryParse(s, out result))
			{
				return defaultValue;
			}
			return result;
		}

		// Token: 0x06039266 RID: 234086 RVA: 0x01001158 File Offset: 0x00FFF358
		protected static string GetParamString(IReadOnlyDictionary<string, string> parameters, string key, string defaultValue = "")
		{
			string result;
			if (!parameters.TryGetValue(key, out result))
			{
				return defaultValue;
			}
			return result;
		}

		// Token: 0x0401E10C RID: 123148
		private static int SelfIncrementId;

		// Token: 0x0401E10D RID: 123149
		public readonly int Uid;

		// Token: 0x0401E110 RID: 123152
		private bool Cleaned;

		// Token: 0x0401E111 RID: 123153
		[Nullable(2)]
		private Action DoneCallback;

		// Token: 0x0401E112 RID: 123154
		[Nullable(2)]
		private Action AbortCallback;
	}
}
