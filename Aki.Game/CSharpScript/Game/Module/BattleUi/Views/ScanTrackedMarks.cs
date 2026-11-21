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
	// Token: 0x02004D96 RID: 19862
	[NullableContext(1)]
	[Nullable(0)]
	public class ScanTrackedMarks : UiPanelBase, IStaticVariableResetter
	{
		// Token: 0x1700623D RID: 25149
		// (get) Token: 0x06031E44 RID: 204356 RVA: 0x00DF3C58 File Offset: 0x00DF1E58
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

		// Token: 0x06031E45 RID: 204357 RVA: 0x00DF3D48 File Offset: 0x00DF1F48
		static ScanTrackedMarks()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ScanTrackedMarks.CreateStaticDefaultValue), new Action(ScanTrackedMarks.ResetStaticDefaultValue));
		}

		// Token: 0x06031E46 RID: 204358 RVA: 0x00DF3DF0 File Offset: 0x00DF1FF0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06031E47 RID: 204359 RVA: 0x00DF3DF2 File Offset: 0x00DF1FF2
		public static void ResetStaticDefaultValue()
		{
			ScanTrackedMarks.LineTrace = null;
		}

		// Token: 0x06031E48 RID: 204360 RVA: 0x00DF3DFA File Offset: 0x00DF1FFA
		private static void InitLineTrace()
		{
			UTraceLineElement utraceLineElement = new UTraceLineElement();
			utraceLineElement.WorldContextObject = GlobalData.World;
			utraceLineElement.bIsSingle = true;
			utraceLineElement.SetTraceTypeQuery(KuroTraceTypeQuery.Water);
			ScanTrackedMarks.LineTrace = utraceLineElement;
		}

		// Token: 0x06031E49 RID: 204361 RVA: 0x00DF3E24 File Offset: 0x00DF2024
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

		// Token: 0x06031E4A RID: 204362 RVA: 0x00DF3E70 File Offset: 0x00DF2070
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

		// Token: 0x06031E4B RID: 204363 RVA: 0x00DF4000 File Offset: 0x00DF2200
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

		// Token: 0x06031E4C RID: 204364 RVA: 0x00DF4078 File Offset: 0x00DF2278
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

		// Token: 0x06031E4D RID: 204365 RVA: 0x00DF4144 File Offset: 0x00DF2344
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

		// Token: 0x06031E4E RID: 204366 RVA: 0x00DF4234 File Offset: 0x00DF2434
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

		// Token: 0x06031E4F RID: 204367 RVA: 0x00DF454C File Offset: 0x00DF274C
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

		// Token: 0x06031E50 RID: 204368 RVA: 0x00DF46EC File Offset: 0x00DF28EC
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

		// Token: 0x06031E51 RID: 204369 RVA: 0x00DF4812 File Offset: 0x00DF2A12
		private void SetTrackedEffectHidden(bool bHidden)
		{
			EffectSystem.Instance.SetEffectHidden(this.TrackedEffect, bHidden, null, false);
		}

		// Token: 0x06031E52 RID: 204370 RVA: 0x00DF4828 File Offset: 0x00DF2A28
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

		// Token: 0x06031E53 RID: 204371 RVA: 0x00DF4898 File Offset: 0x00DF2A98
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

		// Token: 0x06031E54 RID: 204372 RVA: 0x00DF48E4 File Offset: 0x00DF2AE4
		protected override void OnBeforeShow()
		{
			if (this.TrackingActor == null || !this.TrackingActor.IsValid())
			{
				Log.Instance.Error(ELogModule.LevelPlay, ELogAuthor.CH, "[ScanTrackedMarks.OnBeforeShow] TrackingActor is null", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.Destroy(null);
			}
		}

		// Token: 0x0401A661 RID: 108129
		private const string PROFILE_KEY = "ScanTrackedMarks_CreateTrackEffect";

		// Token: 0x0401A662 RID: 108130
		private const float OFFSET_Z = 1000f;

		// Token: 0x0401A663 RID: 108131
		private const float MIN_SHOW_DISTANCE = 3f;

		// Token: 0x0401A664 RID: 108132
		[StaticVariableRuleIgnore]
		private static readonly FName MARK_CASE_NAME = new FName("MarkCase");

		// Token: 0x0401A665 RID: 108133
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

		// Token: 0x0401A666 RID: 108134
		private readonly FVectorDouble? OriginalPosition;

		// Token: 0x0401A667 RID: 108135
		[Nullable(2)]
		private readonly AActor TrackingActor;

		// Token: 0x0401A668 RID: 108136
		private FVector2D ScreenPositionRef = new FVector2D();

		// Token: 0x0401A669 RID: 108137
		private readonly Vector2D ViewportSize = new Vector2D(0.0, 0.0);

		// Token: 0x0401A66A RID: 108138
		private readonly Vector2D PointTransport = new Vector2D(1.0, -1.0);

		// Token: 0x0401A66B RID: 108139
		private readonly float MarkHideDis;

		// Token: 0x0401A66C RID: 108140
		private int TrackedEffect;

		// Token: 0x0401A66D RID: 108141
		[Nullable(2)]
		private readonly Vector Offset;

		// Token: 0x0401A66E RID: 108142
		private readonly int? Level = new int?(0);

		// Token: 0x0401A66F RID: 108143
		private readonly bool ShowDistance;

		// Token: 0x0401A670 RID: 108144
		private readonly bool NeedClampToEllipse;

		// Token: 0x0401A671 RID: 108145
		private float? MaxWidth = new float?(0f);

		// Token: 0x0401A672 RID: 108146
		private float? MaxHeight = new float?(0f);

		// Token: 0x0401A673 RID: 108147
		[Nullable(2)]
		private readonly ULGUISpriteData_BaseObject IconSprite;

		// Token: 0x0401A674 RID: 108148
		private readonly string EffectPath = string.Empty;

		// Token: 0x0401A675 RID: 108149
		private readonly Vector HitLocation = Vector.Create();

		// Token: 0x0401A676 RID: 108150
		[Nullable(2)]
		private static UTraceLineElement LineTrace;

		// Token: 0x0401A677 RID: 108151
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A678 RID: 108152
		private readonly float LimitA;

		// Token: 0x0401A679 RID: 108153
		private readonly float LimitB;

		// Token: 0x0200AA9B RID: 43675
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04034B9D RID: 215965
			UISpriteActor1,
			// Token: 0x04034B9E RID: 215966
			UISpriteActor2,
			// Token: 0x04034B9F RID: 215967
			UISpriteActor3,
			// Token: 0x04034BA0 RID: 215968
			DistanceText,
			// Token: 0x04034BA1 RID: 215969
			ArrowSprite
		}
	}
}
