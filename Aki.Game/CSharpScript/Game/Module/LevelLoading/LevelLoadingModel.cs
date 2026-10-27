using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.LevelLoading
{
	// Token: 0x020056C5 RID: 22213
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class LevelLoadingModel : ModelBase
	{
		// Token: 0x17008796 RID: 34710
		// (get) Token: 0x060387FD RID: 231421 RVA: 0x00D6C11A File Offset: 0x00D6A31A
		public bool IsLoading
		{
			get
			{
				return this.IsLoadingInternal;
			}
		}

		// Token: 0x060387FE RID: 231422 RVA: 0x00D6C122 File Offset: 0x00D6A322
		protected override bool OnClear()
		{
			this.OpenLoadingReason.Clear();
			this.LoadingPerforms.Clear();
			return true;
		}

		// Token: 0x060387FF RID: 231423 RVA: 0x00D6C13C File Offset: 0x00D6A33C
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

		// Token: 0x06038800 RID: 231424 RVA: 0x00D6C1E4 File Offset: 0x00D6A3E4
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

		// Token: 0x06038801 RID: 231425 RVA: 0x00D6C234 File Offset: 0x00D6A434
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

		// Token: 0x06038802 RID: 231426 RVA: 0x00D6C28C File Offset: 0x00D6A48C
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

		// Token: 0x06038803 RID: 231427 RVA: 0x00D6C318 File Offset: 0x00D6A518
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

		// Token: 0x06038804 RID: 231428 RVA: 0x00D6C3A0 File Offset: 0x00D6A5A0
		public ELoadingPerform? GetPerformByReason(ELoadingReason reason)
		{
			ELoadingPerform value;
			if (!this.OpenLoadingReason.TryGetValue(reason, out value))
			{
				return null;
			}
			return new ELoadingPerform?(value);
		}

		// Token: 0x06038805 RID: 231429 RVA: 0x00D6C3D0 File Offset: 0x00D6A5D0
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

		// Token: 0x06038806 RID: 231430 RVA: 0x00D6C440 File Offset: 0x00D6A640
		private void ClearLoadingReason()
		{
			this.OpenLoadingReason.Clear();
			Log.Instance.Info(ELogModule.Loading, ELogAuthor.YSQ, "LevelLoading:ClearLoadingReason", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06038807 RID: 231431 RVA: 0x00D6C474 File Offset: 0x00D6A674
		public void ClearLoadingPerforms()
		{
			this.LoadingPerforms.Clear();
			Log.Instance.Info(ELogModule.Loading, ELogAuthor.YSQ, "LevelLoading:ClearLoadingPerforms", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06038808 RID: 231432 RVA: 0x00D6C4A8 File Offset: 0x00D6A6A8
		public bool CheckLoadingPerformsEmpty()
		{
			return this.LoadingPerforms.Count == 0;
		}

		// Token: 0x06038809 RID: 231433 RVA: 0x00D6C4B8 File Offset: 0x00D6A6B8
		public bool CheckLoadingPerformExist(ELoadingPerform? perform)
		{
			int num;
			return this.IsLoading && perform != null && (this.LoadingPerforms.TryGetValue(perform.Value, out num) && num > 0);
		}

		// Token: 0x0603880A RID: 231434 RVA: 0x00D6C4F7 File Offset: 0x00D6A6F7
		public void FinishCameraShowPromise()
		{
			CustomPromise cameraFadeShowPromise = this.CameraFadeShowPromise;
			if (cameraFadeShowPromise != null)
			{
				cameraFadeShowPromise.SetResult();
			}
			this.CameraFadeShowPromise = null;
		}

		// Token: 0x0603880B RID: 231435 RVA: 0x00D6C511 File Offset: 0x00D6A711
		public void FinishCameraHidePromise()
		{
			CustomPromise cameraFadeHidePromise = this.CameraFadeHidePromise;
			if (cameraFadeHidePromise != null)
			{
				cameraFadeHidePromise.SetResult();
			}
			this.CameraFadeHidePromise = null;
		}

		// Token: 0x17008797 RID: 34711
		// (get) Token: 0x0603880C RID: 231436 RVA: 0x00D6C52B File Offset: 0x00D6A72B
		public static LevelLoadingModel Instance
		{
			get
			{
				return LevelLoadingModel._Instance;
			}
		}

		// Token: 0x0603880D RID: 231437 RVA: 0x00D6C532 File Offset: 0x00D6A732
		public static LevelLoadingModel GetOrCreateInstance()
		{
			if (LevelLoadingModel._Instance == null)
			{
				LevelLoadingModel.CreateInstance();
			}
			return LevelLoadingModel._Instance;
		}

		// Token: 0x0603880E RID: 231438 RVA: 0x00D6C546 File Offset: 0x00D6A746
		public static bool CreateInstance()
		{
			if (LevelLoadingModel._Instance != null)
			{
				return true;
			}
			LevelLoadingModel._Instance = new LevelLoadingModel();
			return true;
		}

		// Token: 0x0603880F RID: 231439 RVA: 0x00D6C55C File Offset: 0x00D6A75C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06038810 RID: 231440 RVA: 0x00D6C55E File Offset: 0x00D6A75E
		public static void ResetStaticDefaultValue()
		{
			LevelLoadingModel._Instance = null;
		}

		// Token: 0x06038811 RID: 231441 RVA: 0x00D6C566 File Offset: 0x00D6A766
		static LevelLoadingModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelLoadingModel.CreateStaticDefaultValue), new Action(LevelLoadingModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401DAE7 RID: 121575
		[Nullable(2)]
		public CustomPromise CameraFadeShowPromise;

		// Token: 0x0401DAE8 RID: 121576
		[Nullable(2)]
		public CustomPromise CameraFadeHidePromise;

		// Token: 0x0401DAE9 RID: 121577
		private readonly Dictionary<ELoadingReason, ELoadingPerform> OpenLoadingReason = new Dictionary<ELoadingReason, ELoadingPerform>();

		// Token: 0x0401DAEA RID: 121578
		private readonly Dictionary<ELoadingPerform, int> LoadingPerforms = new Dictionary<ELoadingPerform, int>();

		// Token: 0x0401DAEB RID: 121579
		private bool IsLoadingInternal;

		// Token: 0x0401DAEC RID: 121580
		[Nullable(2)]
		private static LevelLoadingModel _Instance;
	}
}
