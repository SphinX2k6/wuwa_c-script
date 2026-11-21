using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.LevelLoading
{
	// Token: 0x0200469C RID: 18076
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class LevelLoadingModel : ModelBase
	{
		// Token: 0x17005B5E RID: 23390
		// (get) Token: 0x0602D70D RID: 186125 RVA: 0x00CBA6D1 File Offset: 0x00CB88D1
		public bool IsLoading
		{
			get
			{
				return this.IsLoadingInternal;
			}
		}

		// Token: 0x0602D70E RID: 186126 RVA: 0x00CBA6D9 File Offset: 0x00CB88D9
		protected override bool OnClear()
		{
			this.OpenLoadingReason.Clear();
			this.LoadingPerforms.Clear();
			return true;
		}

		// Token: 0x0602D70F RID: 186127 RVA: 0x00CBA6F4 File Offset: 0x00CB88F4
		public void SetLoadingState(bool value)
		{
			if (this.IsLoadingInternal == value)
			{
				return;
			}
			this.IsLoadingInternal = value;
			if (!value)
			{
				this.ClearLoadingReason();
				this.ClearLoadingPerforms();
				Log.Instance.Info(ELogModule.Loading, ELogAuthor.YZH, "LevelLoading:LoadingModeDisable", default(ReadOnlySpan<ValueTuple<string, object>>));
				if (LoadModeManager.Instance.IsReasonTargetNotDefault(ELoadModeReason.LevelLoading))
				{
					LoadModeManager.Instance.ResetLoadModeByReason(ELoadModeReason.LevelLoading);
				}
				EventSystem.Instance.Emit(EEventName.RemoveLevelLoadingTimeDilationTag);
				return;
			}
			Log.Instance.Info(ELogModule.Loading, ELogAuthor.YZH, "LevelLoading:LoadingModeEnable", default(ReadOnlySpan<ValueTuple<string, object>>));
			LoadModeManager.Instance.SetLoadModeByReason(ELoadMode.Loading, ELoadModeReason.LevelLoading);
			EventSystem.Instance.Emit(EEventName.AddLevelLoadingTimeDilationTag);
		}

		// Token: 0x0602D710 RID: 186128 RVA: 0x00CBA79C File Offset: 0x00CB899C
		public void AddLoadingReason(ELoadingReason reason, ELoadingPerform perform)
		{
			this.OpenLoadingReason[reason] = perform;
			this.AddLoadingPerform(perform);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Loading;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "LevelLoading:AddLoadingReason";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", reason);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602D711 RID: 186129 RVA: 0x00CBA7EC File Offset: 0x00CB89EC
		public void RemoveLoadingReason(ELoadingReason reason)
		{
			ELoadingPerform? performByReason = this.GetPerformByReason(reason);
			this.OpenLoadingReason.Remove(reason);
			this.RemoveLoadingPerform(performByReason);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Loading;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "LevelLoading:RemoveLoadingReason";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", reason);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602D712 RID: 186130 RVA: 0x00CBA844 File Offset: 0x00CB8A44
		public unsafe void AddLoadingPerform(ELoadingPerform perform)
		{
			int valueOrDefault = this.LoadingPerforms.GetValueOrDefault(perform, 0);
			this.LoadingPerforms[perform] = valueOrDefault + 1;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Loading;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "LevelLoading:AddLoadingPerform";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("perform", perform);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("count", valueOrDefault + 1);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0602D713 RID: 186131 RVA: 0x00CBA8D0 File Offset: 0x00CB8AD0
		public void RemoveLoadingPerform(ELoadingPerform? perform)
		{
			if (perform == null)
			{
				return;
			}
			int num;
			if (!this.LoadingPerforms.TryGetValue(perform.Value, out num))
			{
				return;
			}
			int num2 = num - 1;
			this.LoadingPerforms[perform.Value] = num2;
			if (num2 <= 0)
			{
				this.LoadingPerforms.Remove(perform.Value);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Loading;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "LevelLoading:RemoveLoadingPerform";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("perform", perform);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x0602D714 RID: 186132 RVA: 0x00CBA958 File Offset: 0x00CB8B58
		public ELoadingPerform? GetPerformByReason(ELoadingReason reason)
		{
			ELoadingPerform value;
			if (!this.OpenLoadingReason.TryGetValue(reason, out value))
			{
				return null;
			}
			return new ELoadingPerform?(value);
		}

		// Token: 0x0602D715 RID: 186133 RVA: 0x00CBA988 File Offset: 0x00CB8B88
		public List<ELoadingReason> GetReasonsByPerform(ELoadingPerform targetPerform)
		{
			List<ELoadingReason> list = new List<ELoadingReason>();
			foreach (KeyValuePair<ELoadingReason, ELoadingPerform> keyValuePair in this.OpenLoadingReason)
			{
				ELoadingReason eloadingReason;
				ELoadingPerform eloadingPerform;
				keyValuePair.Deconstruct(out eloadingReason, out eloadingPerform);
				ELoadingReason item = eloadingReason;
				ELoadingPerform eloadingPerform2 = eloadingPerform;
				if (targetPerform == eloadingPerform2)
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x0602D716 RID: 186134 RVA: 0x00CBA9F8 File Offset: 0x00CB8BF8
		private void ClearLoadingReason()
		{
			this.OpenLoadingReason.Clear();
			Log.Instance.Info(ELogModule.Loading, ELogAuthor.YSQ, "LevelLoading:ClearLoadingReason", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602D717 RID: 186135 RVA: 0x00CBAA2C File Offset: 0x00CB8C2C
		public void ClearLoadingPerforms()
		{
			this.LoadingPerforms.Clear();
			Log.Instance.Info(ELogModule.Loading, ELogAuthor.YSQ, "LevelLoading:ClearLoadingPerforms", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602D718 RID: 186136 RVA: 0x00CBAA60 File Offset: 0x00CB8C60
		public bool CheckLoadingPerformsEmpty()
		{
			return this.LoadingPerforms.Count == 0;
		}

		// Token: 0x0602D719 RID: 186137 RVA: 0x00CBAA70 File Offset: 0x00CB8C70
		public bool CheckLoadingPerformExist(ELoadingPerform? perform)
		{
			int num;
			return this.IsLoading && perform != null && (this.LoadingPerforms.TryGetValue(perform.Value, out num) && num > 0);
		}

		// Token: 0x0602D71A RID: 186138 RVA: 0x00CBAAAF File Offset: 0x00CB8CAF
		public void FinishCameraShowPromise()
		{
			CustomPromise cameraFadeShowPromise = this.CameraFadeShowPromise;
			if (cameraFadeShowPromise != null)
			{
				cameraFadeShowPromise.SetResult();
			}
			this.CameraFadeShowPromise = null;
		}

		// Token: 0x0602D71B RID: 186139 RVA: 0x00CBAAC9 File Offset: 0x00CB8CC9
		public void FinishCameraHidePromise()
		{
			CustomPromise cameraFadeHidePromise = this.CameraFadeHidePromise;
			if (cameraFadeHidePromise != null)
			{
				cameraFadeHidePromise.SetResult();
			}
			this.CameraFadeHidePromise = null;
		}

		// Token: 0x17005B5F RID: 23391
		// (get) Token: 0x0602D71C RID: 186140 RVA: 0x00CBAAE3 File Offset: 0x00CB8CE3
		public static LevelLoadingModel Instance
		{
			get
			{
				return LevelLoadingModel._Instance;
			}
		}

		// Token: 0x0602D71D RID: 186141 RVA: 0x00CBAAEA File Offset: 0x00CB8CEA
		public static LevelLoadingModel GetOrCreateInstance()
		{
			if (LevelLoadingModel._Instance == null)
			{
				LevelLoadingModel.CreateInstance();
			}
			return LevelLoadingModel._Instance;
		}

		// Token: 0x0602D71E RID: 186142 RVA: 0x00CBAAFE File Offset: 0x00CB8CFE
		public static bool CreateInstance()
		{
			if (LevelLoadingModel._Instance != null)
			{
				return true;
			}
			LevelLoadingModel._Instance = new LevelLoadingModel();
			return true;
		}

		// Token: 0x0602D71F RID: 186143 RVA: 0x00CBAB14 File Offset: 0x00CB8D14
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602D720 RID: 186144 RVA: 0x00CBAB16 File Offset: 0x00CB8D16
		public static void ResetStaticDefaultValue()
		{
			LevelLoadingModel._Instance = null;
		}

		// Token: 0x0602D721 RID: 186145 RVA: 0x00CBAB1E File Offset: 0x00CB8D1E
		static LevelLoadingModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelLoadingModel.CreateStaticDefaultValue), new Action(LevelLoadingModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401857D RID: 99709
		[Nullable(2)]
		public CustomPromise CameraFadeShowPromise;

		// Token: 0x0401857E RID: 99710
		[Nullable(2)]
		public CustomPromise CameraFadeHidePromise;

		// Token: 0x0401857F RID: 99711
		private readonly Dictionary<ELoadingReason, ELoadingPerform> OpenLoadingReason = new Dictionary<ELoadingReason, ELoadingPerform>();

		// Token: 0x04018580 RID: 99712
		private readonly Dictionary<ELoadingPerform, int> LoadingPerforms = new Dictionary<ELoadingPerform, int>();

		// Token: 0x04018581 RID: 99713
		private bool IsLoadingInternal;

		// Token: 0x04018582 RID: 99714
		[Nullable(2)]
		private static LevelLoadingModel _Instance;
	}
}
