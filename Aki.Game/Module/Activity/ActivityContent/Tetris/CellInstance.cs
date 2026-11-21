using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;
using Aki.Game.Module.Activity.ActivityContent.Tetris.Activity;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FA5 RID: 12197
	[NullableContext(2)]
	[Nullable(0)]
	public class CellInstance : IEquatable<CellInstance>
	{
		// Token: 0x17002DD7 RID: 11735
		// (get) Token: 0x0601CE9B RID: 118427 RVA: 0x008D5013 File Offset: 0x008D3213
		[Nullable(1)]
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[NullableContext(1)]
			[CompilerGenerated]
			get
			{
				return typeof(CellInstance);
			}
		}

		// Token: 0x17002DD8 RID: 11736
		// (get) Token: 0x0601CE9C RID: 118428 RVA: 0x008D501F File Offset: 0x008D321F
		// (set) Token: 0x0601CE9D RID: 118429 RVA: 0x008D5027 File Offset: 0x008D3227
		public int ColorId { get; set; }

		// Token: 0x17002DD9 RID: 11737
		// (get) Token: 0x0601CE9E RID: 118430 RVA: 0x008D5030 File Offset: 0x008D3230
		// (set) Token: 0x0601CE9F RID: 118431 RVA: 0x008D5038 File Offset: 0x008D3238
		public EGemType GemType { get; set; }

		// Token: 0x17002DDA RID: 11738
		// (get) Token: 0x0601CEA0 RID: 118432 RVA: 0x008D5041 File Offset: 0x008D3241
		// (set) Token: 0x0601CEA1 RID: 118433 RVA: 0x008D5049 File Offset: 0x008D3249
		public EBombType BombType { get; set; }

		// Token: 0x0601CEA2 RID: 118434 RVA: 0x008D5054 File Offset: 0x008D3254
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

		// Token: 0x0601CEA3 RID: 118435 RVA: 0x008D509C File Offset: 0x008D329C
		public string GetSmallIconPath()
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
				text2 = valueOrDefault.BombSmallIconPath;
				break;
			case EBombType.SuperBomb:
				text2 = valueOrDefault.SuperBombSmallIconPath;
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

		// Token: 0x0601CEA4 RID: 118436 RVA: 0x008D5130 File Offset: 0x008D3330
		[NullableContext(1)]
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CellInstance");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x0601CEA5 RID: 118437 RVA: 0x008D517C File Offset: 0x008D337C
		[NullableContext(1)]
		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("ColorId = ");
			builder.Append(this.ColorId.ToString());
			builder.Append(", GemType = ");
			builder.Append(this.GemType.ToString());
			builder.Append(", BombType = ");
			builder.Append(this.BombType.ToString());
			return true;
		}

		// Token: 0x0601CEA6 RID: 118438 RVA: 0x008D5204 File Offset: 0x008D3404
		[CompilerGenerated]
		public static bool operator !=(CellInstance left, CellInstance right)
		{
			return !(left == right);
		}

		// Token: 0x0601CEA7 RID: 118439 RVA: 0x008D5210 File Offset: 0x008D3410
		[CompilerGenerated]
		public static bool operator ==(CellInstance left, CellInstance right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x0601CEA8 RID: 118440 RVA: 0x008D5224 File Offset: 0x008D3424
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<ColorId>k__BackingField)) * -1521134295 + EqualityComparer<EGemType>.Default.GetHashCode(this.<GemType>k__BackingField)) * -1521134295 + EqualityComparer<EBombType>.Default.GetHashCode(this.<BombType>k__BackingField);
		}

		// Token: 0x0601CEA9 RID: 118441 RVA: 0x008D5286 File Offset: 0x008D3486
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as CellInstance);
		}

		// Token: 0x0601CEAA RID: 118442 RVA: 0x008D5294 File Offset: 0x008D3494
		[CompilerGenerated]
		public virtual bool Equals(CellInstance other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(this.<ColorId>k__BackingField, other.<ColorId>k__BackingField) && EqualityComparer<EGemType>.Default.Equals(this.<GemType>k__BackingField, other.<GemType>k__BackingField) && EqualityComparer<EBombType>.Default.Equals(this.<BombType>k__BackingField, other.<BombType>k__BackingField));
		}

		// Token: 0x0601CEAC RID: 118444 RVA: 0x008D530D File Offset: 0x008D350D
		[CompilerGenerated]
		protected CellInstance([Nullable(1)] CellInstance original)
		{
			this.ColorId = original.<ColorId>k__BackingField;
			this.GemType = original.<GemType>k__BackingField;
			this.BombType = original.<BombType>k__BackingField;
		}

		// Token: 0x0601CEAD RID: 118445 RVA: 0x008D5339 File Offset: 0x008D3539
		public CellInstance()
		{
		}
	}
}
