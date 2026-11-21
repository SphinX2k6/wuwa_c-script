using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058FF RID: 22783
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class SolarSchoolGameplayBase : SolarSchoolActionBase
	{
		// Token: 0x17006BBF RID: 27583
		// (get) Token: 0x060382AB RID: 230059 RVA: 0x00FB32AB File Offset: 0x00FB14AB
		// (set) Token: 0x060382AC RID: 230060 RVA: 0x00FB32B3 File Offset: 0x00FB14B3
		private protected int GameplayId { protected get; private set; }

		// Token: 0x17006BC0 RID: 27584
		// (get) Token: 0x060382AD RID: 230061 RVA: 0x00FB32BC File Offset: 0x00FB14BC
		private string GameplayName
		{
			get
			{
				return base.GetType().Name;
			}
		}

		// Token: 0x060382AE RID: 230062 RVA: 0x00FB32CC File Offset: 0x00FB14CC
		protected unsafe sealed override void OnParse(IReadOnlyDictionary<string, string> parameters)
		{
			int num = this.OnExParse(parameters);
			if (num != 0)
			{
				this.GameplayId = num;
				return;
			}
			using (IEnumerator<KeyValuePair<string, string>> enumerator = parameters.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					KeyValuePair<string, string> keyValuePair = enumerator.Current;
					int gameplayId;
					if (!int.TryParse(keyValuePair.Value, out gameplayId))
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.SolarSchool;
						ELogAuthor author = ELogAuthor.YYZ;
						string message = "[SolarSchool] 玩法参数首位不是Id";
						<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("type", this.GameplayName);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("key", keyValuePair.Key);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("value", keyValuePair.Value);
						instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
						return;
					}
					this.GameplayId = gameplayId;
					return;
				}
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SolarSchool;
			ELogAuthor author2 = ELogAuthor.YYZ;
			string message2 = "[SolarSchool] 玩法缺少参数Id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", this.GameplayName);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060382AF RID: 230063 RVA: 0x00FB33F4 File Offset: 0x00FB15F4
		protected virtual int OnExParse(IReadOnlyDictionary<string, string> parameters)
		{
			return 0;
		}

		// Token: 0x060382B0 RID: 230064 RVA: 0x00FB33F8 File Offset: 0x00FB15F8
		protected unsafe sealed override void OnStart()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[SolarSchool] 玩法开始";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("type", this.GameplayName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("configId", this.GameplayId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.OnGameplayStart();
			if (base.IsRunning() && this.EntryStateName != string.Empty)
			{
				this.GotoState(this.EntryStateName);
			}
		}

		// Token: 0x060382B1 RID: 230065 RVA: 0x00FB3498 File Offset: 0x00FB1698
		protected unsafe sealed override void OnFinish()
		{
			if (this.GameplayEnded)
			{
				return;
			}
			if (this.Detached)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool] 玩法提前交还 action，继续运行";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("type", this.GameplayName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("configId", this.GameplayId);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (!this.Completed)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.YYZ;
				string message2 = "[SolarSchool] 玩法未标记完成即结束";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("configId", this.GameplayId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("type", this.GameplayName);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			}
			this.EndGameplay();
		}

		// Token: 0x060382B2 RID: 230066 RVA: 0x00FB3590 File Offset: 0x00FB1790
		private unsafe void EndGameplay()
		{
			if (this.GameplayEnded)
			{
				return;
			}
			this.GameplayEnded = true;
			this.Detached = false;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[SolarSchool] 玩法结束";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("type", this.GameplayName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("configId", this.GameplayId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.OnGameplayEnd();
		}

		// Token: 0x17006BC1 RID: 27585
		// (get) Token: 0x060382B3 RID: 230067 RVA: 0x00FB361F File Offset: 0x00FB181F
		// (set) Token: 0x060382B4 RID: 230068 RVA: 0x00FB3627 File Offset: 0x00FB1827
		private protected string CurrentStateName { protected get; private set; } = string.Empty;

		// Token: 0x060382B5 RID: 230069 RVA: 0x00FB3630 File Offset: 0x00FB1830
		protected unsafe void AddState(string name, Action enter)
		{
			if (this.CurrentStateName != string.Empty)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool] 玩法已在运行，禁止注册状态";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("configId", this.GameplayId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("state", name);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (!this.States.TryAdd(name, enter))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.YYZ;
				string message2 = "[SolarSchool] 状态重复注册";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("configId", this.GameplayId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("state", name);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return;
			}
			if (this.EntryStateName == string.Empty)
			{
				this.EntryStateName = name;
			}
		}

		// Token: 0x060382B6 RID: 230070 RVA: 0x00FB373C File Offset: 0x00FB193C
		protected unsafe void GotoState(string name)
		{
			if (this.GameplayEnded || (!base.IsRunning() && !this.Detached))
			{
				return;
			}
			Action action;
			if (!this.States.TryGetValue(name, out action))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool] 切换到未注册状态";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("type", this.GameplayName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("configId", this.GameplayId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("from", this.CurrentStateName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("to", name);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				return;
			}
			this.CurrentStateName = name;
			action();
		}

		// Token: 0x060382B7 RID: 230071 RVA: 0x00FB381D File Offset: 0x00FB1A1D
		protected void FinishGameplay()
		{
			if (this.Detached)
			{
				this.EndGameplay();
				return;
			}
			if (!base.IsRunning())
			{
				return;
			}
			this.Completed = true;
			base.MarkDone();
		}

		// Token: 0x060382B8 RID: 230072 RVA: 0x00FB3844 File Offset: 0x00FB1A44
		protected void FinishActionEarly()
		{
			if (!base.IsRunning())
			{
				return;
			}
			this.Completed = true;
			this.Detached = true;
			base.MarkDone();
		}

		// Token: 0x060382B9 RID: 230073
		protected abstract void OnGameplayStart();

		// Token: 0x060382BA RID: 230074 RVA: 0x00FB3863 File Offset: 0x00FB1A63
		protected virtual void OnGameplayEnd()
		{
		}

		// Token: 0x060382BB RID: 230075 RVA: 0x00FB3868 File Offset: 0x00FB1A68
		protected void CloseOpeningView(EUiViewName viewName)
		{
			UiViewBase viewByName = UiManager.Instance.GetViewByName(viewName);
			if (viewByName == null || viewByName.ClosePromise != null)
			{
				return;
			}
			UiManager.Instance.CloseView(viewName, null);
		}

		// Token: 0x0401D926 RID: 121126
		private bool Completed;

		// Token: 0x0401D927 RID: 121127
		private bool Detached;

		// Token: 0x0401D928 RID: 121128
		private bool GameplayEnded;

		// Token: 0x0401D92A RID: 121130
		private readonly Dictionary<string, Action> States = new Dictionary<string, Action>();

		// Token: 0x0401D92B RID: 121131
		private string EntryStateName = string.Empty;
	}
}
