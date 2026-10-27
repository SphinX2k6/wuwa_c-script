using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041B5 RID: 16821
	public class ITargetBattleAttribute_UnionUnion
	{
		// Token: 0x17007749 RID: 30537
		// (get) Token: 0x06018C40 RID: 101440 RVA: 0x00390B65 File Offset: 0x0038ED65
		// (set) Token: 0x06018C41 RID: 101441 RVA: 0x00390B6D File Offset: 0x0038ED6D
		public ITargetBattleAttribute_Union Type { get; set; }

		// Token: 0x1700774A RID: 30538
		// (get) Token: 0x06018C42 RID: 101442 RVA: 0x00390B76 File Offset: 0x0038ED76
		// (set) Token: 0x06018C43 RID: 101443 RVA: 0x00390B7E File Offset: 0x0038ED7E
		public object Value { get; set; }

		// Token: 0x06018C44 RID: 101444 RVA: 0x00390B87 File Offset: 0x0038ED87
		public ITargetBattleAttribute_UnionUnion()
		{
			this.Type = ITargetBattleAttribute_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06018C45 RID: 101445 RVA: 0x00390B9D File Offset: 0x0038ED9D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06018C46 RID: 101446 RVA: 0x00390BAF File Offset: 0x0038EDAF
		public ITargetBattleAttributeT AsITargetBattleAttribute()
		{
			return this.As<ITargetBattleAttributeT>();
		}

		// Token: 0x06018C47 RID: 101447 RVA: 0x00390BB7 File Offset: 0x0038EDB7
		public static ITargetBattleAttribute_UnionUnion FromITargetBattleAttribute(ITargetBattleAttributeT _itargetbattleattribute)
		{
			return new ITargetBattleAttribute_UnionUnion
			{
				Type = ITargetBattleAttribute_Union.ITargetBattleAttribute,
				Value = _itargetbattleattribute
			};
		}

		// Token: 0x06018C48 RID: 101448 RVA: 0x00390BCC File Offset: 0x0038EDCC
		public ICheckPlayerBattleAttributeT AsICheckPlayerBattleAttribute()
		{
			return this.As<ICheckPlayerBattleAttributeT>();
		}

		// Token: 0x06018C49 RID: 101449 RVA: 0x00390BD4 File Offset: 0x0038EDD4
		public static ITargetBattleAttribute_UnionUnion FromICheckPlayerBattleAttribute(ICheckPlayerBattleAttributeT _icheckplayerbattleattribute)
		{
			return new ITargetBattleAttribute_UnionUnion
			{
				Type = ITargetBattleAttribute_Union.ICheckPlayerBattleAttribute,
				Value = _icheckplayerbattleattribute
			};
		}

		// Token: 0x06018C4A RID: 101450 RVA: 0x00390BE9 File Offset: 0x0038EDE9
		public ICheckMonsterBattleAttributeT AsICheckMonsterBattleAttribute()
		{
			return this.As<ICheckMonsterBattleAttributeT>();
		}

		// Token: 0x06018C4B RID: 101451 RVA: 0x00390BF1 File Offset: 0x0038EDF1
		public static ITargetBattleAttribute_UnionUnion FromICheckMonsterBattleAttribute(ICheckMonsterBattleAttributeT _icheckmonsterbattleattribute)
		{
			return new ITargetBattleAttribute_UnionUnion
			{
				Type = ITargetBattleAttribute_Union.ICheckMonsterBattleAttribute,
				Value = _icheckmonsterbattleattribute
			};
		}

		// Token: 0x06018C4C RID: 101452 RVA: 0x00390C08 File Offset: 0x0038EE08
		public static int Pack(FlatBufferBuilder builder, ITargetBattleAttribute_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITargetBattleAttribute_Union.ITargetBattleAttribute:
				return ITargetBattleAttribute.Pack(builder, _o.AsITargetBattleAttribute()).Value;
			case ITargetBattleAttribute_Union.ICheckPlayerBattleAttribute:
				return ICheckPlayerBattleAttribute.Pack(builder, _o.AsICheckPlayerBattleAttribute()).Value;
			case ITargetBattleAttribute_Union.ICheckMonsterBattleAttribute:
				return ICheckMonsterBattleAttribute.Pack(builder, _o.AsICheckMonsterBattleAttribute()).Value;
			default:
				return 0;
			}
		}
	}
}
