using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SignalDeviceControl.SiganalDeviceUIItem
{
	// Token: 0x02006A56 RID: 27222
	[NullableContext(2)]
	[Nullable(0)]
	public class LinkingLineItem : UiPanelBase
	{
		// Token: 0x06043B23 RID: 277283 RVA: 0x010909D6 File Offset: 0x0108EBD6
		protected LinkingLineItem(ELineType lineType)
		{
			this.LineType = lineType;
		}

		// Token: 0x06043B24 RID: 277284 RVA: 0x010909EC File Offset: 0x0108EBEC
		[NullableContext(1)]
		public static LinkingLineItem Create(ELineType lineType)
		{
			return new LinkingLineItem(lineType);
		}

		// Token: 0x06043B25 RID: 277285 RVA: 0x010909F4 File Offset: 0x0108EBF4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUISprite))
			};
		}

		// Token: 0x06043B26 RID: 277286 RVA: 0x01090A90 File Offset: 0x0108EC90
		protected override void OnStart()
		{
			this.SprBg = base.GetSprite(0);
			this.SprLine = base.GetSprite(1);
			this.SprLineHalf = base.GetSprite(2);
			this.SprSpot = base.GetSprite(3);
			this.SprRay = base.GetSprite(4);
			this.SprRayHalf = base.GetSprite(5);
			this.SprBg.SetUIActive(false);
			this.SprLine.SetUIActive(false);
			this.SprLineHalf.SetUIActive(false);
			this.SprSpot.SetUIActive(false);
			this.SprRay.SetUIActive(false);
			this.SprRayHalf.SetUIActive(false);
		}

		// Token: 0x06043B27 RID: 277287 RVA: 0x01090B34 File Offset: 0x0108ED34
		public void InitIcon(ENeighborType neighborType, bool isHalf = false)
		{
			bool flag = SignalDeviceModel.Instance.ViewType == EViewType.ChasingMoon;
			EPieceColorType currentColor = SignalDeviceModel.Instance.CurrentColor;
			string text;
			LinkingLineItem.ColorSpotIconMap.TryGetValue(currentColor, out text);
			if (flag)
			{
				text += "CM";
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(text);
			this.SetSpriteByPath(resourcePath, this.SprSpot, false, null, null);
			string text2;
			LinkingLineItem.ColorRayIconMap.TryGetValue(currentColor, out text2);
			if (flag)
			{
				text2 += "CM";
			}
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath(text2);
			this.SetSpriteByPath(resourcePath2, this.SprRay, false, null, null);
			this.SetSpriteByPath(resourcePath2, this.SprRayHalf, false, null, null);
			string hexStr;
			LinkingLineItem.ColorMap.TryGetValue(currentColor, out hexStr);
			if (SignalDeviceModel.Instance.ViewType == EViewType.ChasingMoon)
			{
				string resourceId;
				LinkingLineItem.ColorSprBgMap.TryGetValue(currentColor, out resourceId);
				string resourcePath3 = UiResourceConfig.Instance.GetResourcePath(resourceId);
				this.SetSpriteByPath(resourcePath3, this.SprBg, false, null, null);
			}
			else
			{
				this.SprBg.SetColor(FColor.FromHex(hexStr));
			}
			this.SprLine.SetColor(FColor.FromHex(hexStr));
			this.SprLineHalf.SetColor(FColor.FromHex(hexStr));
			this.RotateLine(neighborType);
			bool flag2 = this.LineType == ELineType.LinkingLineStraight || this.LineType == ELineType.LinkingLineWithDotStraight;
			this.SprBg.SetUIActive(true);
			this.SprLine.SetUIActive(!isHalf);
			this.SprLineHalf.SetUIActive(isHalf);
			this.SprRay.SetUIActive(!isHalf);
			this.SprRayHalf.SetUIActive(isHalf || !flag2);
			this.SprSpot.SetUIActive(true);
		}

		// Token: 0x06043B28 RID: 277288 RVA: 0x01090CF8 File Offset: 0x0108EEF8
		protected void RotateLine(ENeighborType neighborType)
		{
			int num;
			SignalDeviceModel.Instance.RotateMap.TryGetValue(neighborType, out num);
			Rotator cacheRotator = SignalDeviceModel.Instance.CacheRotator;
			cacheRotator.Yaw = (float)num;
			UUIItem rootItem = base.GetRootItem();
			FRotator frotator = cacheRotator.ToUeRotator();
			rootItem.SetUIRelativeRotation(frotator);
		}

		// Token: 0x06043B29 RID: 277289 RVA: 0x01090D40 File Offset: 0x0108EF40
		public void SetLineHalf(ENeighborType neighborType)
		{
			this.SprLine.SetUIActive(false);
			this.SprLineHalf.SetUIActive(true);
			this.SprRay.SetUIActive(false);
			this.SprRayHalf.SetUIActive(true);
			Rotator cacheRotator = SignalDeviceModel.Instance.CacheRotator;
			int num;
			SignalDeviceModel.Instance.RotateMap.TryGetValue(neighborType, out num);
			cacheRotator.Yaw = (float)num;
			UUIItem rootItem = base.GetRootItem();
			FRotator frotator = cacheRotator.ToUeRotator();
			rootItem.SetUIRelativeRotation(frotator);
		}

		// Token: 0x0402359D RID: 144797
		public ELineType LineType = ELineType.LinkingLineStraight;

		// Token: 0x0402359E RID: 144798
		protected UUISprite SprBg;

		// Token: 0x0402359F RID: 144799
		protected UUISprite SprLine;

		// Token: 0x040235A0 RID: 144800
		protected UUISprite SprLineHalf;

		// Token: 0x040235A1 RID: 144801
		protected UUISprite SprSpot;

		// Token: 0x040235A2 RID: 144802
		protected UUISprite SprRay;

		// Token: 0x040235A3 RID: 144803
		protected UUISprite SprRayHalf;

		// Token: 0x040235A4 RID: 144804
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		protected static readonly Dictionary<EPieceColorType, string> ColorSpotIconMap = new Dictionary<EPieceColorType, string>
		{
			{
				EPieceColorType.Blue,
				"SP_SpotBlue"
			},
			{
				EPieceColorType.Green,
				"SP_SpotGreen"
			},
			{
				EPieceColorType.Red,
				"SP_SpotRed"
			},
			{
				EPieceColorType.Yellow,
				"SP_SpotYellow"
			}
		};

		// Token: 0x040235A5 RID: 144805
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

		// Token: 0x040235A6 RID: 144806
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		protected static readonly Dictionary<EPieceColorType, string> ColorSprBgMap = new Dictionary<EPieceColorType, string>
		{
			{
				EPieceColorType.Blue,
				"SP_GridBgCMBlue"
			},
			{
				EPieceColorType.Green,
				"SP_GridBgCMGreen"
			},
			{
				EPieceColorType.Red,
				"SP_GridBgCMRed"
			},
			{
				EPieceColorType.Yellow,
				"SP_GridBgCMYellow"
			}
		};

		// Token: 0x040235A7 RID: 144807
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
	}
}
