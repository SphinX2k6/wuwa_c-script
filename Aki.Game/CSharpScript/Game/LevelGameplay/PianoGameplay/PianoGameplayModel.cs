using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.PianoGameplay;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.Common;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.PianoGameplay
{
	// Token: 0x02005C1F RID: 23583
	[NullableContext(2)]
	[Nullable(0)]
	[Model(0)]
	public class PianoGameplayModel : ModelBase
	{
		// Token: 0x17006E50 RID: 28240
		// (get) Token: 0x06039E9D RID: 237213 RVA: 0x0104913B File Offset: 0x0104733B
		public BP_PianoGameplaySetting_C PianoGameplaySetting
		{
			get
			{
				return this.PianoGameplaySettingInternal;
			}
		}

		// Token: 0x17006E51 RID: 28241
		// (get) Token: 0x06039E9E RID: 237214 RVA: 0x01049143 File Offset: 0x01047343
		public UClass SplitScreenBpClass
		{
			get
			{
				return this.SplitScreenBpClassInternal;
			}
		}

		// Token: 0x17006E52 RID: 28242
		// (get) Token: 0x06039E9F RID: 237215 RVA: 0x0104914B File Offset: 0x0104734B
		public UMaterial SplitScreenMaterial
		{
			get
			{
				return this.SplitScreenMaterialInternal;
			}
		}

		// Token: 0x17006E53 RID: 28243
		// (get) Token: 0x06039EA0 RID: 237216 RVA: 0x01049153 File Offset: 0x01047353
		public USplineComponent SplineComponent
		{
			get
			{
				return this.SplineComponentInternal;
			}
		}

		// Token: 0x17006E54 RID: 28244
		// (get) Token: 0x06039EA1 RID: 237217 RVA: 0x0104915B File Offset: 0x0104735B
		public float? SplineLength
		{
			get
			{
				return this.SplineLengthInternal;
			}
		}

		// Token: 0x17006E55 RID: 28245
		// (get) Token: 0x06039EA2 RID: 237218 RVA: 0x01049163 File Offset: 0x01047363
		public UCurveFloat PianoGameplayAlphaPositionCurve
		{
			get
			{
				return this.PianoGameplayAlphaPositionCurveInternal;
			}
		}

		// Token: 0x17006E56 RID: 28246
		// (get) Token: 0x06039EA3 RID: 237219 RVA: 0x0104916B File Offset: 0x0104736B
		public float? UiTextDebugFixedDuration
		{
			get
			{
				return this.UiTextDebugFixedDurationInternal;
			}
		}

		// Token: 0x17006E57 RID: 28247
		// (get) Token: 0x06039EA4 RID: 237220 RVA: 0x01049173 File Offset: 0x01047373
		public bool UiTextDebugEnable
		{
			get
			{
				return this.UiTextDebugEnableInternal;
			}
		}

		// Token: 0x17006E58 RID: 28248
		// (get) Token: 0x06039EA5 RID: 237221 RVA: 0x0104917B File Offset: 0x0104737B
		public bool UiTextDebugShowWidthHeightRatio
		{
			get
			{
				return this.UiTextDebugShowWidthHeightRatioInternal;
			}
		}

		// Token: 0x17006E59 RID: 28249
		// (get) Token: 0x06039EA7 RID: 237223 RVA: 0x0104919D File Offset: 0x0104739D
		// (set) Token: 0x06039EA6 RID: 237222 RVA: 0x01049183 File Offset: 0x01047383
		public EPianoGameplayStage GameplayStage
		{
			get
			{
				return this.GameplayStageInternal;
			}
			set
			{
				this.GameplayStageInternal = value;
				EventSystem.Instance.Emit<EPianoGameplayStage>(EEventName.OnPianoGameplayStageChanged, value);
			}
		}

		// Token: 0x17006E5A RID: 28250
		// (get) Token: 0x06039EA8 RID: 237224 RVA: 0x010491A5 File Offset: 0x010473A5
		public bool IsInPianoGameplay
		{
			get
			{
				return this.IsInPianoGameplayInternal;
			}
		}

		// Token: 0x06039EA9 RID: 237225 RVA: 0x010491B0 File Offset: 0x010473B0
		public void LoadPianoGameplaySetting()
		{
			if (this.PianoGameplaySettingInternal != null || this.IsPianoGameplaySettingLoading)
			{
				return;
			}
			this.IsPianoGameplaySettingLoading = true;
			int generation = this.PianoGameplaySettingLoadGeneration;
			ResourceSystem.Instance.LoadTypeAsync(EBpTypeName.BP_PianoGameplaySetting_C.ToEnumString(), delegate
			{
				if (generation != this.PianoGameplaySettingLoadGeneration)
				{
					return;
				}
				bool hasCallback = false;
				int num = ResourceSystem.Instance.LoadAsync<BP_PianoGameplaySetting_C>("/Game/Aki/Data/Gameplay/PianoGameplay/DA_PianoGameplaySetting.DA_PianoGameplaySetting", delegate([Nullable(2)] BP_PianoGameplaySetting_C setting, string _)
				{
					hasCallback = true;
					if (generation != this.PianoGameplaySettingLoadGeneration)
					{
						return;
					}
					this.PianoGameplaySettingLoadHandle = -1;
					this.IsPianoGameplaySettingLoading = false;
					this.PianoGameplaySettingInternal = setting;
					PianoGameplayModel <>4__this = this;
					BP_PianoGameplaySetting_C pianoGameplaySetting = this.PianoGameplaySetting;
					<>4__this.PianoGameplayAlphaPositionCurveInternal = ((pianoGameplaySetting != null) ? pianoGameplaySetting.FlowMaskAlphaPositionCurve : null);
				}, 100, "js_undefined");
				if (!hasCallback && num != -1)
				{
					this.PianoGameplaySettingLoadHandle = num;
				}
			}, "js_undefined");
		}

		// Token: 0x06039EAA RID: 237226 RVA: 0x01049210 File Offset: 0x01047410
		private UniTask LoadSplitScreenSource()
		{
			PianoGameplayModel.<LoadSplitScreenSource>d__46 <LoadSplitScreenSource>d__;
			<LoadSplitScreenSource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadSplitScreenSource>d__.<>4__this = this;
			<LoadSplitScreenSource>d__.<>1__state = -1;
			<LoadSplitScreenSource>d__.<>t__builder.Start<PianoGameplayModel.<LoadSplitScreenSource>d__46>(ref <LoadSplitScreenSource>d__);
			return <LoadSplitScreenSource>d__.<>t__builder.Task;
		}

		// Token: 0x06039EAB RID: 237227 RVA: 0x01049254 File Offset: 0x01047454
		private UniTask LoadSplitScreenMaterial()
		{
			PianoGameplayModel.<LoadSplitScreenMaterial>d__47 <LoadSplitScreenMaterial>d__;
			<LoadSplitScreenMaterial>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadSplitScreenMaterial>d__.<>4__this = this;
			<LoadSplitScreenMaterial>d__.<>1__state = -1;
			<LoadSplitScreenMaterial>d__.<>t__builder.Start<PianoGameplayModel.<LoadSplitScreenMaterial>d__47>(ref <LoadSplitScreenMaterial>d__);
			return <LoadSplitScreenMaterial>d__.<>t__builder.Task;
		}

		// Token: 0x06039EAC RID: 237228 RVA: 0x01049297 File Offset: 0x01047497
		[NullableContext(1)]
		public UniTask[] EnterGameplay()
		{
			UniTask[] result = new UniTask[]
			{
				this.LoadSplitScreenSource(),
				this.LoadSplitScreenMaterial()
			};
			this.IsInPianoGameplayInternal = true;
			return result;
		}

		// Token: 0x06039EAD RID: 237229 RVA: 0x010492C0 File Offset: 0x010474C0
		public void ExitGameplay()
		{
			this.SplitScreenLoadGeneration++;
			if (this.SplitScreenBpClassLoadHandle != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.SplitScreenBpClassLoadHandle);
				this.SplitScreenBpClassLoadHandle = -1;
			}
			if (this.SplitScreenMaterialLoadHandle != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.SplitScreenMaterialLoadHandle);
				this.SplitScreenMaterialLoadHandle = -1;
			}
			CustomPromise splitScreenBpClassLoadPromise = this.SplitScreenBpClassLoadPromise;
			if (splitScreenBpClassLoadPromise != null)
			{
				splitScreenBpClassLoadPromise.SetResult();
			}
			CustomPromise splitScreenMaterialLoadPromise = this.SplitScreenMaterialLoadPromise;
			if (splitScreenMaterialLoadPromise != null)
			{
				splitScreenMaterialLoadPromise.SetResult();
			}
			this.SplitScreenBpClassLoadPromise = null;
			this.SplitScreenMaterialLoadPromise = null;
			this.SplitScreenBpClassInternal = null;
			this.SplitScreenMaterialInternal = null;
			if (this.SplineIdInternal != null)
			{
				GameSplineModel.Instance.ReleaseSpline(this.SplineIdInternal.Value, (long)this.GameplayEntityIdInternal.Value, EIdType.PbDataId);
			}
			this.SplineIdInternal = null;
			this.GameplayEntityIdInternal = null;
			this.SplineComponentInternal = null;
			this.SplineLengthInternal = new float?(0f);
			this.IsInPianoGameplayInternal = false;
		}

		// Token: 0x06039EAE RID: 237230 RVA: 0x010493BE File Offset: 0x010475BE
		[NullableContext(1)]
		public void AddPianoQteBtnItem(PianoQteBtnItem item)
		{
			this.BtnPianoItemList.Add(item);
		}

		// Token: 0x06039EAF RID: 237231 RVA: 0x010493CC File Offset: 0x010475CC
		public void ClearPianoQteBtnItemList()
		{
			if (this.BtnPianoItemList.Count > 0)
			{
				this.BtnPianoItemList.RemoveRange(0, this.BtnPianoItemList.Count);
			}
		}

		// Token: 0x06039EB0 RID: 237232 RVA: 0x010493F4 File Offset: 0x010475F4
		protected override bool OnClear()
		{
			this.PianoGameplaySettingLoadGeneration++;
			if (this.PianoGameplaySettingLoadHandle != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.PianoGameplaySettingLoadHandle);
				this.PianoGameplaySettingLoadHandle = -1;
			}
			this.IsPianoGameplaySettingLoading = false;
			this.ExitGameplay();
			this.PianoGameplaySettingInternal = null;
			if (this.SplineIdInternal != null)
			{
				GameSplineModel.Instance.ReleaseSpline(this.SplineIdInternal.Value, (long)this.GameplayEntityIdInternal.Value, EIdType.PbDataId);
			}
			this.SplineIdInternal = null;
			this.GameplayEntityIdInternal = null;
			this.SplineComponentInternal = null;
			this.SplineLengthInternal = new float?(0f);
			this.UiTextDebugShowWidthHeightRatioInternal = false;
			return true;
		}

		// Token: 0x06039EB1 RID: 237233 RVA: 0x010494AC File Offset: 0x010476AC
		public unsafe void SetSplineComponent(int splineId, int id)
		{
			USplineComponent usplineComponent = GameSplineModel.Instance.LoadAndGetSplineComponent(splineId, id, EIdType.PbDataId);
			if (usplineComponent == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PianoGameplay;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "[SetSplineComponent] 获取样条组件失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("splineId", splineId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.SplineComponentInternal = usplineComponent;
			this.SplineIdInternal = new int?(splineId);
			this.GameplayEntityIdInternal = new int?(id);
			this.SplineLengthInternal = new float?(usplineComponent.GetSplineLength());
		}

		// Token: 0x06039EB2 RID: 237234 RVA: 0x01049558 File Offset: 0x01047758
		public void SetUiTextDebugEnable(bool enable, float duration)
		{
			this.UiTextDebugEnableInternal = enable;
			this.UiTextDebugFixedDurationInternal = new float?(duration * 1000f);
			EventSystem.Instance.Emit<bool, float>(EEventName.OnUiTextEnableUseDebugFixedDuration, enable, this.UiTextDebugFixedDurationInternal.Value);
		}

		// Token: 0x06039EB3 RID: 237235 RVA: 0x0104958F File Offset: 0x0104778F
		public void SetUiTextDebugShowWidthHeightRatio(bool enable)
		{
			this.UiTextDebugShowWidthHeightRatioInternal = enable;
		}

		// Token: 0x17006E5B RID: 28251
		// (get) Token: 0x06039EB4 RID: 237236 RVA: 0x01049598 File Offset: 0x01047798
		[Nullable(1)]
		public static PianoGameplayModel Instance
		{
			[NullableContext(1)]
			get
			{
				return PianoGameplayModel._Instance;
			}
		}

		// Token: 0x06039EB5 RID: 237237 RVA: 0x0104959F File Offset: 0x0104779F
		[NullableContext(1)]
		public static PianoGameplayModel GetOrCreateInstance()
		{
			if (PianoGameplayModel._Instance == null)
			{
				PianoGameplayModel.CreateInstance();
			}
			return PianoGameplayModel._Instance;
		}

		// Token: 0x06039EB6 RID: 237238 RVA: 0x010495B3 File Offset: 0x010477B3
		public static bool CreateInstance()
		{
			if (PianoGameplayModel._Instance != null)
			{
				return true;
			}
			PianoGameplayModel._Instance = new PianoGameplayModel();
			return true;
		}

		// Token: 0x06039EB7 RID: 237239 RVA: 0x010495C9 File Offset: 0x010477C9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039EB8 RID: 237240 RVA: 0x010495CB File Offset: 0x010477CB
		public static void ResetStaticDefaultValue()
		{
			PianoGameplayModel._Instance = null;
		}

		// Token: 0x06039EB9 RID: 237241 RVA: 0x010495D3 File Offset: 0x010477D3
		static PianoGameplayModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PianoGameplayModel.CreateStaticDefaultValue), new Action(PianoGameplayModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401E9D2 RID: 125394
		private BP_PianoGameplaySetting_C PianoGameplaySettingInternal;

		// Token: 0x0401E9D3 RID: 125395
		private UCurveFloat PianoGameplayAlphaPositionCurveInternal;

		// Token: 0x0401E9D4 RID: 125396
		private UClass SplitScreenBpClassInternal;

		// Token: 0x0401E9D5 RID: 125397
		private UMaterial SplitScreenMaterialInternal;

		// Token: 0x0401E9D6 RID: 125398
		private int PianoGameplaySettingLoadHandle = -1;

		// Token: 0x0401E9D7 RID: 125399
		private int SplitScreenBpClassLoadHandle = -1;

		// Token: 0x0401E9D8 RID: 125400
		private int SplitScreenMaterialLoadHandle = -1;

		// Token: 0x0401E9D9 RID: 125401
		private int PianoGameplaySettingLoadGeneration;

		// Token: 0x0401E9DA RID: 125402
		private int SplitScreenLoadGeneration;

		// Token: 0x0401E9DB RID: 125403
		private bool IsPianoGameplaySettingLoading;

		// Token: 0x0401E9DC RID: 125404
		private CustomPromise SplitScreenBpClassLoadPromise;

		// Token: 0x0401E9DD RID: 125405
		private CustomPromise SplitScreenMaterialLoadPromise;

		// Token: 0x0401E9DE RID: 125406
		private USplineComponent SplineComponentInternal;

		// Token: 0x0401E9DF RID: 125407
		private float? SplineLengthInternal;

		// Token: 0x0401E9E0 RID: 125408
		private int? SplineIdInternal;

		// Token: 0x0401E9E1 RID: 125409
		private int? GameplayEntityIdInternal;

		// Token: 0x0401E9E2 RID: 125410
		private bool IsInPianoGameplayInternal;

		// Token: 0x0401E9E3 RID: 125411
		[Nullable(1)]
		public readonly List<PianoQteBtnItem> BtnPianoItemList = new List<PianoQteBtnItem>();

		// Token: 0x0401E9E4 RID: 125412
		private EPianoGameplayStage GameplayStageInternal;

		// Token: 0x0401E9E5 RID: 125413
		private bool UiTextDebugEnableInternal;

		// Token: 0x0401E9E6 RID: 125414
		private float? UiTextDebugFixedDurationInternal;

		// Token: 0x0401E9E7 RID: 125415
		private bool UiTextDebugShowWidthHeightRatioInternal;

		// Token: 0x0401E9E8 RID: 125416
		private static PianoGameplayModel _Instance;
	}
}
