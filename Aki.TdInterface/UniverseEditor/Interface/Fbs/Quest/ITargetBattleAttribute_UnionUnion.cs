using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200460E RID: 17934
	public class ITargetBattleAttribute_UnionUnion
	{
		// Token: 0x17007D75 RID: 32117
		// (get) Token: 0x0601A396 RID: 107414 RVA: 0x003BBFB9 File Offset: 0x003BA1B9
		// (set) Token: 0x0601A397 RID: 107415 RVA: 0x003BBFC1 File Offset: 0x003BA1C1
		public ITargetBattleAttribute_Union Type { get; set; }

		// Token: 0x17007D76 RID: 32118
		// (get) Token: 0x0601A398 RID: 107416 RVA: 0x003BBFCA File Offset: 0x003BA1CA
		// (set) Token: 0x0601A399 RID: 107417 RVA: 0x003BBFD2 File Offset: 0x003BA1D2
		public object Value { get; set; }

		// Token: 0x0601A39A RID: 107418 RVA: 0x003BBFDB File Offset: 0x003BA1DB
		public ITargetBattleAttribute_UnionUnion()
		{
			this.Type = ITargetBattleAttribute_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601A39B RID: 107419 RVA: 0x003BBFF1 File Offset: 0x003BA1F1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601A39C RID: 107420 RVA: 0x003BC003 File Offset: 0x003BA203
		public ITargetBattleAttributeT AsITargetBattleAttribute()
		{
			return this.As<ITargetBattleAttributeT>();
		}

		// Token: 0x0601A39D RID: 107421 RVA: 0x003BC00B File Offset: 0x003BA20B
		public static ITargetBattleAttribute_UnionUnion FromITargetBattleAttribute(ITargetBattleAttributeT _itargetbattleattribute)
		{
			return new ITargetBattleAttribute_UnionUnion
			{
				Type = ITargetBattleAttribute_Union.ITargetBattleAttribute,
				Value = _itargetbattleattribute
			};
		}

		// Token: 0x0601A39E RID: 107422 RVA: 0x003BC020 File Offset: 0x003BA220
		public ICheckPlayerBattleAttributeT AsICheckPlayerBattleAttribute()
		{
			return this.As<ICheckPlayerBattleAttributeT>();
		}

		// Token: 0x0601A39F RID: 107423 RVA: 0x003BC028 File Offset: 0x003BA228
		public static ITargetBattleAttribute_UnionUnion FromICheckPlayerBattleAttribute(ICheckPlayerBattleAttributeT _icheckplayerbattleattribute)
		{
			return new ITargetBattleAttribute_UnionUnion
			{
				Type = ITargetBattleAttribute_Union.ICheckPlayerBattleAttribute,
				Value = _icheckplayerbattleattribute
			};
		}

		// Token: 0x0601A3A0 RID: 107424 RVA: 0x003BC03D File Offset: 0x003BA23D
		public ICheckMonsterBattleAttributeT AsICheckMonsterBattleAttribute()
		{
			return this.As<ICheckMonsterBattleAttributeT>();
		}

		// Token: 0x0601A3A1 RID: 107425 RVA: 0x003BC045 File Offset: 0x003BA245
		public static ITargetBattleAttribute_UnionUnion FromICheckMonsterBattleAttribute(ICheckMonsterBattleAttributeT _icheckmonsterbattleattribute)
		{
			return new ITargetBattleAttribute_UnionUnion
			{
				Type = ITargetBattleAttribute_Union.ICheckMonsterBattleAttribute,
				Value = _icheckmonsterbattleattribute
			};
		}

		// Token: 0x0601A3A2 RID: 107426 RVA: 0x003BC05C File Offset: 0x003BA25C
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
