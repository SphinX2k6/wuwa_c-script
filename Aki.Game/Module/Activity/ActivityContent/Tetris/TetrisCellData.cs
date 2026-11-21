using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Game.Module.Activity.ActivityContent.Tetris.Activity;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FB3 RID: 12211
	[NullableContext(2)]
	[Nullable(0)]
	public class TetrisCellData
	{
		// Token: 0x17002E0A RID: 11786
		// (get) Token: 0x0601CFB0 RID: 118704 RVA: 0x008DA518 File Offset: 0x008D8718
		// (set) Token: 0x0601CFB1 RID: 118705 RVA: 0x008DA520 File Offset: 0x008D8720
		public ECellType Type { get; set; }

		// Token: 0x17002E0B RID: 11787
		// (get) Token: 0x0601CFB2 RID: 118706 RVA: 0x008DA529 File Offset: 0x008D8729
		// (set) Token: 0x0601CFB3 RID: 118707 RVA: 0x008DA531 File Offset: 0x008D8731
		public int ColorId { get; set; }

		// Token: 0x17002E0C RID: 11788
		// (get) Token: 0x0601CFB4 RID: 118708 RVA: 0x008DA53A File Offset: 0x008D873A
		// (set) Token: 0x0601CFB5 RID: 118709 RVA: 0x008DA542 File Offset: 0x008D8742
		public ESealState SealState { get; set; }

		// Token: 0x17002E0D RID: 11789
		// (get) Token: 0x0601CFB6 RID: 118710 RVA: 0x008DA54B File Offset: 0x008D874B
		// (set) Token: 0x0601CFB7 RID: 118711 RVA: 0x008DA553 File Offset: 0x008D8753
		public EGemType GemType { get; set; }

		// Token: 0x17002E0E RID: 11790
		// (get) Token: 0x0601CFB8 RID: 118712 RVA: 0x008DA55C File Offset: 0x008D875C
		// (set) Token: 0x0601CFB9 RID: 118713 RVA: 0x008DA564 File Offset: 0x008D8764
		public EBombType BombType { get; set; }

		// Token: 0x0601CFBA RID: 118714 RVA: 0x008DA56D File Offset: 0x008D876D
		public void Reset()
		{
			this.Type = ECellType.Empty;
			this.ColorId = 0;
			this.SealState = ESealState.None;
			this.GemType = EGemType.None;
			this.BombType = EBombType.None;
		}

		// Token: 0x17002E0F RID: 11791
		// (get) Token: 0x0601CFBB RID: 118715 RVA: 0x008DA592 File Offset: 0x008D8792
		public bool IsOccupied
		{
			get
			{
				return this.Type > ECellType.Empty;
			}
		}

		// Token: 0x17002E10 RID: 11792
		// (get) Token: 0x0601CFBC RID: 118716 RVA: 0x008DA59D File Offset: 0x008D879D
		public bool CanBeCleared
		{
			get
			{
				return this.Type != ECellType.Fixed;
			}
		}

		// Token: 0x0601CFBD RID: 118717 RVA: 0x008DA5AC File Offset: 0x008D87AC
		[NullableContext(1)]
		public TetrisCellData Clone()
		{
			return new TetrisCellData
			{
				Type = this.Type,
				ColorId = this.ColorId,
				SealState = this.SealState,
				GemType = this.GemType,
				BombType = this.BombType
			};
		}

		// Token: 0x0601CFBE RID: 118718 RVA: 0x008DA5FA File Offset: 0x008D87FA
		[NullableContext(1)]
		public void Assign(TetrisCellData other)
		{
			this.Type = other.Type;
			this.ColorId = other.ColorId;
			this.SealState = other.SealState;
			this.GemType = other.GemType;
			this.BombType = other.BombType;
		}

		// Token: 0x0601CFBF RID: 118719 RVA: 0x008DA638 File Offset: 0x008D8838
		public string GetBgPath()
		{
			TetrisGem? gemConfig = ActivityTetrisConfig.Instance.GetGemConfig(this.ColorId);
			if (gemConfig == null)
			{
				return null;
			}
			TetrisGem valueOrDefault = gemConfig.GetValueOrDefault();
			if (string.IsNullOrWhiteSpace(valueOrDefault.BgPath))
			{
				return null;
			}
			return valueOrDefault.BgPath;
		}

		// Token: 0x0601CFC0 RID: 118720 RVA: 0x008DA680 File Offset: 0x008D8880
		public string GetLargeIconPath()
		{
			TetrisGem? gemConfig = ActivityTetrisConfig.Instance.GetGemConfig(this.ColorId);
			if (gemConfig == null)
			{
				return null;
			}
			TetrisGem valueOrDefault = gemConfig.GetValueOrDefault();
			string text2;
			switch (this.BombType)
			{
			case EBombType.None:
			{
				string text;
				if (this.GemType == EGemType.None)
				{
					text = valueOrDefault.IconPath;
				}
				else
				{
					text = valueOrDefault.GemPath;
				}
				text2 = text;
				break;
			}
			case EBombType.Bomb:
				text2 = valueOrDefault.BombLargeIconPath;
				break;
			case EBombType.SuperBomb:
				text2 = valueOrDefault.SuperBombLargeIconPath;
				break;
			default:
				text2 = null;
				break;
			}
			string text3 = text2;
			if (string.IsNullOrWhiteSpace(text3))
			{
				return null;
			}
			return text3;
		}

		// Token: 0x0601CFC1 RID: 118721 RVA: 0x008DA714 File Offset: 0x008D8914
		public string GetBombBgPath()
		{
			TetrisGem? gemConfig = ActivityTetrisConfig.Instance.GetGemConfig(this.ColorId);
			if (gemConfig == null)
			{
				return null;
			}
			TetrisGem valueOrDefault = gemConfig.GetValueOrDefault();
			EBombType bombType = this.BombType;
			string text;
			if (bombType != EBombType.Bomb)
			{
				if (bombType != EBombType.SuperBomb)
				{
					text = null;
				}
				else
				{
					text = valueOrDefault.SuperBombBgPath;
				}
			}
			else
			{
				text = valueOrDefault.BombBgPath;
			}
			string text2 = text;
			if (string.IsNullOrWhiteSpace(text2))
			{
				return null;
			}
			return text2;
		}

		// Token: 0x0601CFC2 RID: 118722 RVA: 0x008DA77C File Offset: 0x008D897C
		public string GetBombDecorationColor(bool isBombCharging)
		{
			TetrisGem? gemConfig = ActivityTetrisConfig.Instance.GetGemConfig(this.ColorId);
			if (gemConfig == null)
			{
				return null;
			}
			TetrisGem valueOrDefault = gemConfig.GetValueOrDefault();
			EBombType bombType = this.BombType;
			string text;
			if (bombType - EBombType.Bomb <= 1)
			{
				text = (isBombCharging ? valueOrDefault.BombDecorationChargeColorValue : valueOrDefault.BombDecorationColorValue);
			}
			else
			{
				text = null;
			}
			string text2 = text;
			if (string.IsNullOrWhiteSpace(text2))
			{
				return null;
			}
			return text2;
		}
	}
}
