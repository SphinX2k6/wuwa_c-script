using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SignalDeviceControl.SiganalDeviceUIItem
{
	// Token: 0x02006A52 RID: 27218
	[NullableContext(2)]
	[Nullable(0)]
	public class LinkingDotItem : UiPanelBase
	{
		// Token: 0x06043B04 RID: 277252 RVA: 0x0108F968 File Offset: 0x0108DB68
		protected unsafe override void OnRegisterComponent()
		{
			List<ValueTuple<int, Type>> componentRegisterInfos;
			if (SignalDeviceModel.Instance.ViewType != EViewType.ChasingMoon)
			{
				int num = 8;
				List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
				componentRegisterInfos = list;
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
				int num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			}
			else
			{
				int num2 = 14;
				List<ValueTuple<int, Type>> list2 = new List<ValueTuple<int, Type>>(num2);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list2, num2);
				componentRegisterInfos = list2;
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list2);
				int num = 0;
				*span[num] = new ValueTuple<int, Type>(0, typeof(UUISprite));
				num++;
				*span[num] = new ValueTuple<int, Type>(1, typeof(UUISprite));
				num++;
				*span[num] = new ValueTuple<int, Type>(2, typeof(UUISprite));
				num++;
				*span[num] = new ValueTuple<int, Type>(3, typeof(UUISprite));
				num++;
				*span[num] = new ValueTuple<int, Type>(6, typeof(UUISprite));
				num++;
				*span[num] = new ValueTuple<int, Type>(5, typeof(UUISprite));
				num++;
				*span[num] = new ValueTuple<int, Type>(4, typeof(UUIItem));
				num++;
				*span[num] = new ValueTuple<int, Type>(7, typeof(UUIItem));
				num++;
				*span[num] = new ValueTuple<int, Type>(8, typeof(UUISprite));
				num++;
				*span[num] = new ValueTuple<int, Type>(9, typeof(UUISprite));
				num++;
				*span[num] = new ValueTuple<int, Type>(10, typeof(UUISprite));
				num++;
				*span[num] = new ValueTuple<int, Type>(11, typeof(UUISprite));
				num++;
				*span[num] = new ValueTuple<int, Type>(12, typeof(UUIItem));
				num++;
				*span[num] = new ValueTuple<int, Type>(13, typeof(UUIExtendToggle));
			}
			this.ComponentRegisterInfos = componentRegisterInfos;
		}

		// Token: 0x06043B05 RID: 277253 RVA: 0x0108FC98 File Offset: 0x0108DE98
		protected override void OnStart()
		{
			this.SprDot = base.GetSprite(0);
			this.SprDotLight = base.GetSprite(1);
			this.SprCorner = base.GetSprite(2);
			this.SprCornerLight = base.GetSprite(3);
			this.SprRay = base.GetSprite(6);
			this.SprUpper = base.GetSprite(5);
			this.PnlRota = base.GetItem(4);
			this.FxBoost = base.GetItem(7);
			UUISprite sprDot = this.SprDot;
			if (sprDot != null)
			{
				sprDot.SetUIActive(false);
			}
			UUISprite sprDotLight = this.SprDotLight;
			if (sprDotLight != null)
			{
				sprDotLight.SetUIActive(false);
			}
			UUISprite sprCorner = this.SprCorner;
			if (sprCorner != null)
			{
				sprCorner.SetUIActive(false);
			}
			UUISprite sprCornerLight = this.SprCornerLight;
			if (sprCornerLight != null)
			{
				sprCornerLight.SetUIActive(false);
			}
			UUISprite sprRay = this.SprRay;
			if (sprRay != null)
			{
				sprRay.SetUIActive(false);
			}
			UUISprite sprUpper = this.SprUpper;
			if (sprUpper != null)
			{
				sprUpper.SetUIActive(false);
			}
			UUIItem fxBoost = this.FxBoost;
			if (fxBoost != null)
			{
				fxBoost.SetUIActive(false);
			}
			if (SignalDeviceModel.Instance.ViewType == EViewType.ChasingMoon)
			{
				this.SprAnimLine = base.GetSprite(9);
				this.SprAnimLineWhite = base.GetSprite(8);
				this.SprAnimDot = base.GetSprite(10);
				this.SprAnimLine.SetUIActive(false);
				this.SprAnimLineWhite.SetUIActive(false);
				this.SprAnimDot.SetUIActive(false);
				this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
			}
			EventSystem.Instance.Add<bool, int, bool, int, bool>(EEventName.OnSignalDeviceLinking, new Action<bool, int, bool, int, bool>(this.OnSignalDeviceLinking));
		}

		// Token: 0x06043B06 RID: 277254 RVA: 0x0108FE12 File Offset: 0x0108E012
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnSignalDeviceLinking, new Action<bool, int, bool, int, bool>(this.OnSignalDeviceLinking));
		}

		// Token: 0x06043B07 RID: 277255 RVA: 0x0108FE30 File Offset: 0x0108E030
		public void InitIcon(EPieceColorType color)
		{
			bool flag = SignalDeviceModel.Instance.ViewType == EViewType.ChasingMoon;
			string text;
			LinkingDotItem.ColorDotIconMap.TryGetValue(color, out text);
			string text2 = text + "Light";
			string text3;
			LinkingDotItem.ColorCornerIconMap.TryGetValue(color, out text3);
			string text4;
			LinkingDotItem.ColorRayIconMap.TryGetValue(color, out text4);
			if (flag)
			{
				text += "CM";
				text2 += "CM";
				text3 += "CM";
				text4 += "CM";
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(text);
			this.SetSpriteByPath(resourcePath, this.SprDot, false, null, null);
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath(text2);
			this.SetSpriteByPath(resourcePath2, this.SprDotLight, false, null, null);
			string resourcePath3 = UiResourceConfig.Instance.GetResourcePath(text3);
			this.SetSpriteByPath(resourcePath3, this.SprCornerLight, false, null, null);
			string resourcePath4 = UiResourceConfig.Instance.GetResourcePath(text4);
			this.SetSpriteByPath(resourcePath4, this.SprRay, false, null, null);
			string hexStr;
			LinkingDotItem.ColorMap.TryGetValue(color, out hexStr);
			this.SprUpper.SetColor(FColor.FromHex(hexStr));
			string hexStr2;
			LinkingDotItem.FxColorMap.TryGetValue(color, out hexStr2);
			this.FxBoost.SetColor(FColor.FromHex(hexStr2));
			if (flag)
			{
				string resourceId;
				LinkingDotItem.ColorAnimLineMap.TryGetValue(color, out resourceId);
				string resourcePath5 = UiResourceConfig.Instance.GetResourcePath(resourceId);
				this.SetSpriteByPath(resourcePath5, this.SprAnimLine, false, null, null);
				string resourceId2;
				LinkingDotItem.ColorAnimDotMap.TryGetValue(color, out resourceId2);
				string resourcePath6 = UiResourceConfig.Instance.GetResourcePath(resourceId2);
				this.SetSpriteByPath(resourcePath6, this.SprAnimDot, false, null, null);
				string hexStr3;
				LinkingDotItem.CmColorMap.TryGetValue(color, out hexStr3);
				this.SprAnimLineWhite.SetColor(FColor.FromHex(hexStr3));
				string hexStr4;
				LinkingDotItem.CmAnimColorMap.TryGetValue(color, out hexStr4);
				UUISprite sprite = base.GetSprite(11);
				if (sprite != null)
				{
					sprite.SetColor(FColor.FromHex(hexStr4));
				}
				UUISprite sprite2 = base.GetSprite(11);
				if (sprite2 != null)
				{
					sprite2.SetUIActive(false);
				}
				UUIItem item = base.GetItem(12);
				if (item != null)
				{
					item.SetColor(FColor.FromHex(hexStr4));
				}
			}
			this.SetLight(false);
			this.ResetIcon();
		}

		// Token: 0x06043B08 RID: 277256 RVA: 0x01090084 File Offset: 0x0108E284
		public UniTask ResetIcon()
		{
			LinkingDotItem.<ResetIcon>d__26 <ResetIcon>d__;
			<ResetIcon>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ResetIcon>d__.<>4__this = this;
			<ResetIcon>d__.<>1__state = -1;
			<ResetIcon>d__.<>t__builder.Start<LinkingDotItem.<ResetIcon>d__26>(ref <ResetIcon>d__);
			return <ResetIcon>d__.<>t__builder.Task;
		}

		// Token: 0x06043B09 RID: 277257 RVA: 0x010900C8 File Offset: 0x0108E2C8
		public UniTask OnPressed(bool isDown)
		{
			LinkingDotItem.<OnPressed>d__27 <OnPressed>d__;
			<OnPressed>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPressed>d__.<>4__this = this;
			<OnPressed>d__.isDown = isDown;
			<OnPressed>d__.<>1__state = -1;
			<OnPressed>d__.<>t__builder.Start<LinkingDotItem.<OnPressed>d__27>(ref <OnPressed>d__);
			return <OnPressed>d__.<>t__builder.Task;
		}

		// Token: 0x06043B0A RID: 277258 RVA: 0x01090114 File Offset: 0x0108E314
		public UniTask OnLinked()
		{
			LinkingDotItem.<OnLinked>d__28 <OnLinked>d__;
			<OnLinked>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnLinked>d__.<>4__this = this;
			<OnLinked>d__.<>1__state = -1;
			<OnLinked>d__.<>t__builder.Start<LinkingDotItem.<OnLinked>d__28>(ref <OnLinked>d__);
			return <OnLinked>d__.<>t__builder.Task;
		}

		// Token: 0x06043B0B RID: 277259 RVA: 0x01090158 File Offset: 0x0108E358
		public void SetLight(bool isLight)
		{
			this.SprDot.SetUIActive(!isLight);
			this.SprDotLight.SetUIActive(isLight);
			this.SprCorner.SetUIActive(!isLight);
			this.SprCornerLight.SetUIActive(isLight);
			if (!isLight)
			{
				this.SetFxBoost(false);
			}
		}

		// Token: 0x06043B0C RID: 277260 RVA: 0x010901A5 File Offset: 0x0108E3A5
		public void SetFxBoost(bool isLight)
		{
			if (SignalDeviceModel.Instance.ViewType == EViewType.ChasingMoon)
			{
				return;
			}
			this.FxBoost.SetUIActive(isLight);
		}

		// Token: 0x06043B0D RID: 277261 RVA: 0x010901C4 File Offset: 0x0108E3C4
		public void RotateLine(bool isActive, ENeighborType neighborType = ENeighborType.None)
		{
			this.SprRay.SetUIActive(isActive);
			this.SprUpper.SetUIActive(isActive);
			int num;
			SignalDeviceModel.Instance.RotateMap.TryGetValue(neighborType, out num);
			Rotator cacheRotator = SignalDeviceModel.Instance.CacheRotator;
			cacheRotator.Yaw = (float)(num + 90);
			UUIItem pnlRota = this.PnlRota;
			FRotator frotator = cacheRotator.ToUeRotator();
			pnlRota.SetUIRelativeRotation(frotator);
		}

		// Token: 0x06043B0E RID: 277262 RVA: 0x01090226 File Offset: 0x0108E426
		private void OnSignalDeviceLinking(bool isAdd, int from, bool isFromDot, int to, bool isToDot)
		{
		}

		// Token: 0x04023574 RID: 144756
		private UUISprite SprDot;

		// Token: 0x04023575 RID: 144757
		private UUISprite SprDotLight;

		// Token: 0x04023576 RID: 144758
		private UUISprite SprCorner;

		// Token: 0x04023577 RID: 144759
		private UUISprite SprCornerLight;

		// Token: 0x04023578 RID: 144760
		private UUISprite SprRay;

		// Token: 0x04023579 RID: 144761
		private UUISprite SprUpper;

		// Token: 0x0402357A RID: 144762
		private UUIItem PnlRota;

		// Token: 0x0402357B RID: 144763
		private UUIItem FxBoost;

		// Token: 0x0402357C RID: 144764
		private UUISprite SprAnimLine;

		// Token: 0x0402357D RID: 144765
		private UUISprite SprAnimLineWhite;

		// Token: 0x0402357E RID: 144766
		private UUISprite SprAnimDot;

		// Token: 0x0402357F RID: 144767
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04023580 RID: 144768
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<EPieceColorType, string> ColorDotIconMap = new Dictionary<EPieceColorType, string>
		{
			{
				EPieceColorType.Blue,
				"SP_DotBlue"
			},
			{
				EPieceColorType.Green,
				"SP_DotGreen"
			},
			{
				EPieceColorType.Red,
				"SP_DotRed"
			},
			{
				EPieceColorType.Yellow,
				"SP_DotYellow"
			}
		};

		// Token: 0x04023581 RID: 144769
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<EPieceColorType, string> ColorCornerIconMap = new Dictionary<EPieceColorType, string>
		{
			{
				EPieceColorType.Blue,
				"SP_CornerBlue"
			},
			{
				EPieceColorType.Green,
				"SP_CornerGreen"
			},
			{
				EPieceColorType.Red,
				"SP_CornerRed"
			},
			{
				EPieceColorType.Yellow,
				"SP_CornerYellow"
			}
		};

		// Token: 0x04023582 RID: 144770
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		protected static readonly Dictionary<EPieceColorType, string> ColorRayIconMap = new Dictionary<EPieceColorType, string>
		{
			{
				EPieceColorType.Blue,
				"SP_LineBlue"
			},
			{
				EPieceColorType.Green,
				"SP_LineGreen"
			},
			{
				EPieceColorType.Red,
				"SP_LineRed"
			},
			{
				EPieceColorType.Yellow,
				"SP_LineYellow"
			}
		};

		// Token: 0x04023583 RID: 144771
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<EPieceColorType, string> ColorAnimLineMap = new Dictionary<EPieceColorType, string>
		{
			{
				EPieceColorType.Blue,
				"SP_AnimLineBlue"
			},
			{
				EPieceColorType.Green,
				"SP_AnimLineGreen"
			},
			{
				EPieceColorType.Red,
				"SP_AnimLineRed"
			},
			{
				EPieceColorType.Yellow,
				"SP_AnimLineYellow"
			}
		};

		// Token: 0x04023584 RID: 144772
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<EPieceColorType, string> ColorAnimDotMap = new Dictionary<EPieceColorType, string>
		{
			{
				EPieceColorType.Blue,
				"SP_AnimDotBlue"
			},
			{
				EPieceColorType.Green,
				"SP_AnimDotGreen"
			},
			{
				EPieceColorType.Red,
				"SP_AnimDotRed"
			},
			{
				EPieceColorType.Yellow,
				"SP_AnimDotYellow"
			}
		};

		// Token: 0x04023585 RID: 144773
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		protected static readonly Dictionary<EPieceColorType, string> ColorMap = new Dictionary<EPieceColorType, string>
		{
			{
				EPieceColorType.Blue,
				"3B82B9FF"
			},
			{
				EPieceColorType.Green,
				"64945FFF"
			},
			{
				EPieceColorType.Red,
				"B93B3CFF"
			},
			{
				EPieceColorType.Yellow,
				"B9823BFF"
			}
		};

		// Token: 0x04023586 RID: 144774
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		protected static readonly Dictionary<EPieceColorType, string> CmColorMap = new Dictionary<EPieceColorType, string>
		{
			{
				EPieceColorType.Blue,
				"5CA1FF88"
			},
			{
				EPieceColorType.Green,
				"96FF5C88"
			},
			{
				EPieceColorType.Red,
				"FFA15C88"
			},
			{
				EPieceColorType.Yellow,
				"FFB85C88"
			}
		};

		// Token: 0x04023587 RID: 144775
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		protected static readonly Dictionary<EPieceColorType, string> CmAnimColorMap = new Dictionary<EPieceColorType, string>
		{
			{
				EPieceColorType.Blue,
				"00FBE7FF"
			},
			{
				EPieceColorType.Green,
				"DFFF55FF"
			},
			{
				EPieceColorType.Red,
				"FFA73FFF"
			},
			{
				EPieceColorType.Yellow,
				"FAE56CFF"
			}
		};

		// Token: 0x04023588 RID: 144776
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		protected static readonly Dictionary<EPieceColorType, string> FxColorMap = new Dictionary<EPieceColorType, string>
		{
			{
				EPieceColorType.Blue,
				"41AEFBFF"
			},
			{
				EPieceColorType.Green,
				"4F8040FF"
			},
			{
				EPieceColorType.Red,
				"F0477EFF"
			},
			{
				EPieceColorType.Yellow,
				"F8E56CFF"
			}
		};

		// Token: 0x0200CB79 RID: 52089
		[NullableContext(0)]
		public enum EComponents
		{
			// Token: 0x0403D6D3 RID: 251603
			SprDot,
			// Token: 0x0403D6D4 RID: 251604
			SprDotLight,
			// Token: 0x0403D6D5 RID: 251605
			SprCorner,
			// Token: 0x0403D6D6 RID: 251606
			SprCornerLight,
			// Token: 0x0403D6D7 RID: 251607
			PnlRota,
			// Token: 0x0403D6D8 RID: 251608
			SprUpper,
			// Token: 0x0403D6D9 RID: 251609
			SprRay,
			// Token: 0x0403D6DA RID: 251610
			FxBoost,
			// Token: 0x0403D6DB RID: 251611
			SprAnimLine,
			// Token: 0x0403D6DC RID: 251612
			SprAnimLine1,
			// Token: 0x0403D6DD RID: 251613
			SprAnimDot,
			// Token: 0x0403D6DE RID: 251614
			AniCube,
			// Token: 0x0403D6DF RID: 251615
			UINiagaraActor4,
			// Token: 0x0403D6E0 RID: 251616
			UiItem_LinkingCMDot
		}
	}
}
