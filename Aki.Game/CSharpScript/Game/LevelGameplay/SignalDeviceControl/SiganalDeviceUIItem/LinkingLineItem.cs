using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SignalDeviceControl.SiganalDeviceUIItem
{
	// Token: 0x02005BB3 RID: 23475
	[NullableContext(2)]
	[Nullable(0)]
	public class LinkingLineItem : UiPanelBase
	{
		// Token: 0x06039B71 RID: 236401 RVA: 0x0103520A File Offset: 0x0103340A
		protected LinkingLineItem(ELineType lineType)
		{
			this.LineType = lineType;
		}

		// Token: 0x06039B72 RID: 236402 RVA: 0x01035220 File Offset: 0x01033420
		[NullableContext(1)]
		public static LinkingLineItem Create(ELineType lineType)
		{
			return new LinkingLineItem(lineType);
		}

		// Token: 0x06039B73 RID: 236403 RVA: 0x01035228 File Offset: 0x01033428
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

		// Token: 0x06039B74 RID: 236404 RVA: 0x010352C4 File Offset: 0x010334C4
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

		// Token: 0x06039B75 RID: 236405 RVA: 0x01035368 File Offset: 0x01033568
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

		// Token: 0x06039B76 RID: 236406 RVA: 0x0103552C File Offset: 0x0103372C
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

		// Token: 0x06039B77 RID: 236407 RVA: 0x01035574 File Offset: 0x01033774
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

		// Token: 0x0401E78F RID: 124815
		public ELineType LineType = ELineType.LinkingLineStraight;

		// Token: 0x0401E790 RID: 124816
		protected UUISprite SprBg;

		// Token: 0x0401E791 RID: 124817
		protected UUISprite SprLine;

		// Token: 0x0401E792 RID: 124818
		protected UUISprite SprLineHalf;

		// Token: 0x0401E793 RID: 124819
		protected UUISprite SprSpot;

		// Token: 0x0401E794 RID: 124820
		protected UUISprite SprRay;

		// Token: 0x0401E795 RID: 124821
		protected UUISprite SprRayHalf;

		// Token: 0x0401E796 RID: 124822
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

		// Token: 0x0401E797 RID: 124823
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

		// Token: 0x0401E798 RID: 124824
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

		// Token: 0x0401E799 RID: 124825
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
