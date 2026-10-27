using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DB2 RID: 23986
	[NullableContext(1)]
	[Nullable(0)]
	public class ScanTrackedMarks : UiPanelBase, IStaticVariableResetter
	{
		// Token: 0x17008E6B RID: 36459
		// (get) Token: 0x0603CECD RID: 249549 RVA: 0x00EA2D84 File Offset: 0x00EA0F84
		private FVectorDouble? TrackingPosition
		{
			get
			{
				AActor trackingActor = this.TrackingActor;
				if (trackingActor != null && trackingActor.IsValid())
				{
					Vector vector = Vector.Create();
					Vector vector2 = Vector.Create();
					TsBaseCharacter tsBaseCharacter = this.TrackingActor as TsBaseCharacter;
					if (tsBaseCharacter != null)
					{
						bool flag = false;
						TArray<FName> allSocketNames = tsBaseCharacter.Mesh.GetAllSocketNames();
						int num = allSocketNames.Num();
						for (int i = 0; i < num; i++)
						{
							if (allSocketNames.Get(i) == ScanTrackedMarks.MARK_CASE_NAME)
							{
								flag = true;
								break;
							}
						}
						if (flag)
						{
							Vector vector3 = vector2;
							FVectorDouble fvectorDouble = tsBaseCharacter.Mesh.D_GetSocketLocation(ScanTrackedMarks.MARK_CASE_NAME);
							vector3.FromUeVector(fvectorDouble);
						}
						else
						{
							Vector vector4 = vector2;
							FVectorDouble fvectorDouble = tsBaseCharacter.Mesh.D_K2_GetComponentLocation();
							vector4.FromUeVector(fvectorDouble);
						}
					}
					else
					{
						Vector vector5 = vector2;
						FVectorDouble fvectorDouble = this.TrackingActor.D_K2_GetActorLocation();
						vector5.FromUeVector(fvectorDouble);
					}
					vector2.Addition(this.Offset, vector);
					return new FVectorDouble?(vector.ToUeVector(false));
				}
				return this.OriginalPosition;
			}
		}

		// Token: 0x0603CECE RID: 249550 RVA: 0x00EA2E74 File Offset: 0x00EA1074
		static ScanTrackedMarks()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ScanTrackedMarks.CreateStaticDefaultValue), new Action(ScanTrackedMarks.ResetStaticDefaultValue));
		}

		// Token: 0x0603CECF RID: 249551 RVA: 0x00EA2F1C File Offset: 0x00EA111C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603CED0 RID: 249552 RVA: 0x00EA2F1E File Offset: 0x00EA111E
		public static void ResetStaticDefaultValue()
		{
			ScanTrackedMarks.LineTrace = null;
		}

		// Token: 0x0603CED1 RID: 249553 RVA: 0x00EA2F26 File Offset: 0x00EA1126
		private static void InitLineTrace()
		{
			UTraceLineElement utraceLineElement = new UTraceLineElement();
			utraceLineElement.WorldContextObject = GlobalData.World;
			utraceLineElement.bIsSingle = true;
			utraceLineElement.SetTraceTypeQuery(KuroTraceTypeQuery.Water);
			ScanTrackedMarks.LineTrace = utraceLineElement;
		}

		// Token: 0x0603CED2 RID: 249554 RVA: 0x00EA2F50 File Offset: 0x00EA1150
		private void OnSequenceFinish(string name)
		{
			if (name == "Start")
			{
				this.LevelSequencePlayer.PlaySequencePurely("Loop", false, false, null, null, false);
				return;
			}
			if (name == "Close")
			{
				base.Destroy(null);
			}
		}

		// Token: 0x0603CED3 RID: 249555 RVA: 0x00EA2F9C File Offset: 0x00EA119C
		[NullableContext(2)]
		public ScanTrackedMarks(UUIItem parent, [Nullable(1)] ULGUISpriteData_BaseObject iconSprite, float markHideDis, [Nullable(1)] string effectPath, FVectorDouble? originPosition = null, AActor trackActor = null, Vector offset = null, int? level = null, bool? showDistance = null, bool? needClampToEllipse = null)
		{
			if (GlobalData.World == null)
			{
				return;
			}
			if (ScanTrackedMarks.LineTrace == null)
			{
				ScanTrackedMarks.InitLineTrace();
			}
			this.IconSprite = iconSprite;
			this.EffectPath = effectPath;
			this.Offset = offset;
			this.MarkHideDis = markHideDis;
			this.Level = level;
			this.ShowDistance = showDistance.GetValueOrDefault();
			this.NeedClampToEllipse = needClampToEllipse.GetValueOrDefault();
			base.CreateThenShowByResourceIdAsync("UiItem_Scanning_Prefab", parent, false).Forget();
			this.OriginalPosition = new FVectorDouble?(originPosition ?? new FVectorDouble());
			this.TrackingActor = trackActor;
			UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
			this.LimitA = Math.Min(1176f, (((uiRootItem != null) ? uiRootItem.GetWidth() : 0f) - 1008f) / 2f);
			this.LimitB = Math.Min(712.5f, (((uiRootItem != null) ? uiRootItem.GetHeight() : 0f) - 495f) / 2f);
		}

		// Token: 0x0603CED4 RID: 249556 RVA: 0x00EA312C File Offset: 0x00EA132C
		private void SetSprite(ULGUISpriteData_BaseObject iconSprite)
		{
			UUIItem sprite = base.GetSprite(0);
			UUISprite sprite2 = base.GetSprite(1);
			UUISprite sprite3 = base.GetSprite(2);
			UUISprite sprite4 = base.GetSprite(4);
			sprite.SetColor(FColor.FromHex(ScanTrackedMarks.SpriteColors[this.Level.Value * 2]));
			sprite2.SetColor(FColor.FromHex(ScanTrackedMarks.SpriteColors[this.Level.Value * 2 + 1]));
			sprite3.SetSprite(iconSprite, true);
			sprite4.SetUIActive(false);
		}

		// Token: 0x0603CED5 RID: 249557 RVA: 0x00EA31A4 File Offset: 0x00EA13A4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CED6 RID: 249558 RVA: 0x00EA3270 File Offset: 0x00EA1470
		protected override void OnStart()
		{
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetUIActive(this.ShowDistance);
			}
			this.SetSprite(this.IconSprite);
			UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
			this.MaxWidth = ((uiRootItem != null) ? new float?(uiRootItem.GetWidth()) : null);
			this.MaxHeight = ((uiRootItem != null) ? new float?(uiRootItem.GetHeight()) : null);
			if (!string.IsNullOrEmpty(this.EffectPath))
			{
				this.TrackedEffect = this.CreateTrackEffect(this.EffectPath);
			}
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceFinish), false);
			this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
			this.RootItem.SetUIActive(false);
			this.SetTrackedEffectHidden(true);
		}

		// Token: 0x0603CED7 RID: 249559 RVA: 0x00EA3360 File Offset: 0x00EA1560
		public void Update()
		{
			if (GlobalData.World == null)
			{
				return;
			}
			if (this.RootItem == null)
			{
				return;
			}
			AActor trackingActor = this.TrackingActor;
			if (trackingActor == null || !trackingActor.IsValid())
			{
				return;
			}
			double num = UKismetMathLibrary.D_Vector_Distance(GeneralLogicTreeUtil.Instance.GetPlayerLocation().ToUeVector(false), this.TrackingPosition.Value) * 0.009999999776482582;
			if (num <= (double)this.MarkHideDis)
			{
				this.RootItem.SetUIActive(false);
				this.SetTrackedEffectHidden(true);
				return;
			}
			TsCharacterController characterController = Global.CharacterController;
			APlayerController player = characterController;
			FVectorDouble value = this.TrackingPosition.Value;
			bool flag = UGameplayStatics.D_ProjectWorldToScreen(player, value, ref this.ScreenPositionRef, false);
			if (!flag)
			{
				if (!this.NeedClampToEllipse)
				{
					this.RootItem.SetUIActive(false);
					this.SetTrackedEffectHidden(true);
					return;
				}
				FTransformDouble value2 = CameraModel.Instance.MainModel.CameraTransform.Value;
				value = this.TrackingPosition.Value;
				FVectorDouble fvectorDouble = value2.InverseTransformPositionNoScale(value);
				fvectorDouble.X = -fvectorDouble.X;
				FVectorDouble fvectorDouble2 = value2.TransformPositionNoScale(fvectorDouble);
				UGameplayStatics.D_ProjectWorldToScreen(characterController, fvectorDouble2, ref this.ScreenPositionRef, false);
			}
			FVector2D fvector2D = this.ScreenPositionRef;
			int num2 = 0;
			int num3 = 0;
			characterController.GetViewportSize(ref num2, ref num3);
			UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
			if (uiRootItem == null)
			{
				return;
			}
			this.ViewportSize.X = (double)uiRootItem.GetWidth();
			this.ViewportSize.Y = (double)uiRootItem.GetHeight();
			FVector2D fvector2D2 = fvector2D * (uiRootItem.GetWidth() / (float)num2);
			FVector2D fvector2D3 = this.ViewportSize.ToUeVector2D(false);
			FVector2D fvector2D4 = fvector2D3 * 0.5f;
			FVector2D fvector2D5 = fvector2D2 - fvector2D4;
			FVector2D fvector2D6 = this.PointTransport.ToUeVector2D(false);
			fvector2D = fvector2D5 * fvector2D6;
			ValueTuple<FVector2D, bool> valueTuple = this.ClampToEllipse(fvector2D, flag, this.NeedClampToEllipse);
			fvector2D = valueTuple.Item1;
			bool item = valueTuple.Item2;
			if (!item && !this.NeedClampToEllipse)
			{
				this.RootItem.SetUIActive(false);
				this.SetTrackedEffectHidden(true);
				return;
			}
			fvector2D2 = TrackDefine.center.ToUeVector2D(false);
			FVector2D anchorOffset = fvector2D + fvector2D2;
			this.RootItem.SetAnchorOffset(anchorOffset);
			if (this.NeedClampToEllipse)
			{
				UUISprite sprite = base.GetSprite(4);
				if (!item)
				{
					Rotator rotator = Rotator.Create(0f, (float)(Math.Atan2((double)fvector2D.Y, (double)fvector2D.X) * 57.29577951308232), 0f);
					UUIItem uuiitem = sprite;
					FRotator frotator = rotator.ToUeRotator();
					uuiitem.SetUIRelativeRotation(frotator);
					sprite.SetUIActive(true);
				}
				else
				{
					sprite.SetUIActive(false);
				}
			}
			if (this.ShowDistance)
			{
				int num4 = (int)Math.Round(num);
				UUIText text = base.GetText(3);
				bool flag2 = !float.IsNaN((float)num4) && !float.IsInfinity((float)num4) && (float)num4 >= 3f;
				if (flag2)
				{
					LguiUtil.Instance.SetLocalText(text, "Meter", new <>z__ReadOnlySingleElementList<object>(num4));
				}
				if (text.IsUIActiveSelf() != flag2)
				{
					text.SetUIActive(flag2);
				}
			}
			this.RootItem.SetUIActive(true);
			this.SetTrackedEffectHidden(false);
		}

		// Token: 0x0603CED8 RID: 249560 RVA: 0x00EA3678 File Offset: 0x00EA1878
		[NullableContext(0)]
		private ValueTuple<FVector2D, bool> ClampToEllipse(FVector2D vector, bool inFront, bool needClamp)
		{
			float x = vector.X;
			float y = vector.Y;
			float limitA = this.LimitA;
			float limitB = this.LimitB;
			if (!needClamp)
			{
				float? num = this.MaxWidth + 10f;
				float? num2 = this.MaxHeight + 10f;
				float num3 = x;
				float? num4 = -num;
				if (!(num3 < num4.GetValueOrDefault() & num4 != null))
				{
					float num5 = x;
					num4 = num;
					if (!(num5 > num4.GetValueOrDefault() & num4 != null))
					{
						float num6 = y;
						num4 = -num2;
						if (!(num6 < num4.GetValueOrDefault() & num4 != null))
						{
							float num7 = y;
							num4 = num2;
							if (!(num7 > num4.GetValueOrDefault() & num4 != null))
							{
								return new ValueTuple<FVector2D, bool>(vector, true);
							}
						}
					}
				}
				return new ValueTuple<FVector2D, bool>(vector, false);
			}
			if (inFront && x * x / (limitA * limitA) + y * y / (limitB * limitB) <= 1f)
			{
				return new ValueTuple<FVector2D, bool>(vector, true);
			}
			float num8 = limitA * limitB / (float)Math.Sqrt((double)(limitB * limitB * x * x + limitA * limitA * y * y));
			return new ValueTuple<FVector2D, bool>(new FVector2D(x * num8, y * num8), false);
		}

		// Token: 0x0603CED9 RID: 249561 RVA: 0x00EA3818 File Offset: 0x00EA1A18
		private int CreateTrackEffect(string effectPath)
		{
			UTraceLineElement lineTrace = ScanTrackedMarks.LineTrace;
			FVectorDouble value = this.OriginalPosition.Value;
			TraceElementCommon.Instance.SetStartLocation(lineTrace, value);
			lineTrace.SetEndLocation(value.X, value.Y, value.Z + 1000.0);
			this.HitLocation.FromUeVector(value);
			bool flag = TraceElementCommon.Instance.LineTrace(lineTrace, "ScanTrackedMarks_CreateTrackEffect");
			UKuroHitResult hitResult = lineTrace.HitResult;
			if (flag && hitResult.bBlockingHit)
			{
				this.HitLocation.Z = (double)hitResult.LocationZ_Array[0];
			}
			this.HitLocation.Z -= 5.0;
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(new FTransformDouble());
			int num = instance.SpawnEffect(world, ftransformDouble, effectPath, "[ScanTrackedMarks.CreateTrackEffect]", null, EEffectType.Scene, null, null, null, false, false);
			if (EffectSystem.Instance.IsValid(num))
			{
				OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(num);
				if (effectActor.IsValid())
				{
					OneOf<KuroEffectActorHandle, AActor> self = effectActor;
					FVectorDouble fvectorDouble = this.HitLocation.ToUeVector(false);
					self.D_K2_SetActorLocationAndRotation(fvectorDouble, FRotator.ZeroRotator, false, ref WorldGlobal.SweepHitResult, false);
				}
			}
			return num;
		}

		// Token: 0x0603CEDA RID: 249562 RVA: 0x00EA393E File Offset: 0x00EA1B3E
		private void SetTrackedEffectHidden(bool bHidden)
		{
			EffectSystem.Instance.SetEffectHidden(this.TrackedEffect, bHidden, null, false);
		}

		// Token: 0x0603CEDB RID: 249563 RVA: 0x00EA3954 File Offset: 0x00EA1B54
		public void ToClose()
		{
			if (this.RootItem == null)
			{
				Log.Instance.Error(ELogModule.LevelPlay, ELogAuthor.CH, "[ScanTrackedMarks.ToClose] RootItem is null", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.Destroy(null);
				return;
			}
			if (!this.RootItem.bIsUIActive)
			{
				return;
			}
			this.LevelSequencePlayer.StopCurrentSequence(false, false);
			this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
		}

		// Token: 0x0603CEDC RID: 249564 RVA: 0x00EA39C4 File Offset: 0x00EA1BC4
		protected override void OnBeforeDestroy()
		{
			if (this.TrackedEffect != 0)
			{
				EffectSystem.Instance.StopEffectById(this.TrackedEffect, "[ScanTrackedMarks.Destroy]", true, null);
				this.TrackedEffect = 0;
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.Clear();
		}

		// Token: 0x0603CEDD RID: 249565 RVA: 0x00EA3A10 File Offset: 0x00EA1C10
		protected override void OnBeforeShow()
		{
			if (this.TrackingActor == null || !this.TrackingActor.IsValid())
			{
				Log.Instance.Error(ELogModule.LevelPlay, ELogAuthor.CH, "[ScanTrackedMarks.OnBeforeShow] TrackingActor is null", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.Destroy(null);
			}
		}

		// Token: 0x0401FBA4 RID: 129956
		private const string PROFILE_KEY = "ScanTrackedMarks_CreateTrackEffect";

		// Token: 0x0401FBA5 RID: 129957
		private const float OFFSET_Z = 1000f;

		// Token: 0x0401FBA6 RID: 129958
		private const float MIN_SHOW_DISTANCE = 3f;

		// Token: 0x0401FBA7 RID: 129959
		[StaticVariableRuleIgnore]
		private static readonly FName MARK_CASE_NAME = new FName("MarkCase");

		// Token: 0x0401FBA8 RID: 129960
		[StaticVariableRuleIgnore]
		private static readonly string[] SpriteColors = new string[]
		{
			"FF5252FF",
			"FF5A5FCC",
			"FFB137FF",
			"FFC954FF",
			"BC6AFEFF",
			"C67FFFFF",
			"85A3FFFF",
			"8AA7FFFF",
			"90B99AFF",
			"AAD3B3FF",
			"A5A5A5FF",
			"D1D1D1FF"
		};

		// Token: 0x0401FBA9 RID: 129961
		private readonly FVectorDouble? OriginalPosition;

		// Token: 0x0401FBAA RID: 129962
		[Nullable(2)]
		private readonly AActor TrackingActor;

		// Token: 0x0401FBAB RID: 129963
		private FVector2D ScreenPositionRef = new FVector2D();

		// Token: 0x0401FBAC RID: 129964
		private readonly Vector2D ViewportSize = new Vector2D(0.0, 0.0);

		// Token: 0x0401FBAD RID: 129965
		private readonly Vector2D PointTransport = new Vector2D(1.0, -1.0);

		// Token: 0x0401FBAE RID: 129966
		private readonly float MarkHideDis;

		// Token: 0x0401FBAF RID: 129967
		private int TrackedEffect;

		// Token: 0x0401FBB0 RID: 129968
		[Nullable(2)]
		private readonly Vector Offset;

		// Token: 0x0401FBB1 RID: 129969
		private readonly int? Level = new int?(0);

		// Token: 0x0401FBB2 RID: 129970
		private readonly bool ShowDistance;

		// Token: 0x0401FBB3 RID: 129971
		private readonly bool NeedClampToEllipse;

		// Token: 0x0401FBB4 RID: 129972
		private float? MaxWidth = new float?(0f);

		// Token: 0x0401FBB5 RID: 129973
		private float? MaxHeight = new float?(0f);

		// Token: 0x0401FBB6 RID: 129974
		[Nullable(2)]
		private readonly ULGUISpriteData_BaseObject IconSprite;

		// Token: 0x0401FBB7 RID: 129975
		private readonly string EffectPath = string.Empty;

		// Token: 0x0401FBB8 RID: 129976
		private readonly Vector HitLocation = Vector.Create();

		// Token: 0x0401FBB9 RID: 129977
		[Nullable(2)]
		private static UTraceLineElement LineTrace;

		// Token: 0x0401FBBA RID: 129978
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401FBBB RID: 129979
		private readonly float LimitA;

		// Token: 0x0401FBBC RID: 129980
		private readonly float LimitB;

		// Token: 0x0200C092 RID: 49298
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403A1CB RID: 238027
			UISpriteActor1,
			// Token: 0x0403A1CC RID: 238028
			UISpriteActor2,
			// Token: 0x0403A1CD RID: 238029
			UISpriteActor3,
			// Token: 0x0403A1CE RID: 238030
			DistanceText,
			// Token: 0x0403A1CF RID: 238031
			ArrowSprite
		}
	}
}
