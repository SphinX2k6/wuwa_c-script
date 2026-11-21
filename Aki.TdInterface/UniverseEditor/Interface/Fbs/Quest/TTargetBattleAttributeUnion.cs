using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004783 RID: 18307
	public class TTargetBattleAttributeUnion
	{
		// Token: 0x17007FAD RID: 32685
		// (get) Token: 0x0601AF53 RID: 110419 RVA: 0x003D2646 File Offset: 0x003D0846
		// (set) Token: 0x0601AF54 RID: 110420 RVA: 0x003D264E File Offset: 0x003D084E
		public TTargetBattleAttribute Type { get; set; }

		// Token: 0x17007FAE RID: 32686
		// (get) Token: 0x0601AF55 RID: 110421 RVA: 0x003D2657 File Offset: 0x003D0857
		// (set) Token: 0x0601AF56 RID: 110422 RVA: 0x003D265F File Offset: 0x003D085F
		public object Value { get; set; }

		// Token: 0x0601AF57 RID: 110423 RVA: 0x003D2668 File Offset: 0x003D0868
		public TTargetBattleAttributeUnion()
		{
			this.Type = TTargetBattleAttribute.NONE;
			this.Value = null;
		}

		// Token: 0x0601AF58 RID: 110424 RVA: 0x003D267E File Offset: 0x003D087E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AF59 RID: 110425 RVA: 0x003D2690 File Offset: 0x003D0890
		public ICheckMonsterBattleAttributeT AsICheckMonsterBattleAttribute()
		{
			return this.As<ICheckMonsterBattleAttributeT>();
		}

		// Token: 0x0601AF5A RID: 110426 RVA: 0x003D2698 File Offset: 0x003D0898
		public static TTargetBattleAttributeUnion FromICheckMonsterBattleAttribute(ICheckMonsterBattleAttributeT _icheckmonsterbattleattribute)
		{
			return new TTargetBattleAttributeUnion
			{
				Type = TTargetBattleAttribute.ICheckMonsterBattleAttribute,
				Value = _icheckmonsterbattleattribute
			};
		}

		// Token: 0x0601AF5B RID: 110427 RVA: 0x003D26AD File Offset: 0x003D08AD
		public ICheckPlayerBattleAttributeT AsICheckPlayerBattleAttribute()
		{
			return this.As<ICheckPlayerBattleAttributeT>();
		}

		// Token: 0x0601AF5C RID: 110428 RVA: 0x003D26B5 File Offset: 0x003D08B5
		public static TTargetBattleAttributeUnion FromICheckPlayerBattleAttribute(ICheckPlayerBattleAttributeT _icheckplayerbattleattribute)
		{
			return new TTargetBattleAttributeUnion
			{
				Type = TTargetBattleAttribute.ICheckPlayerBattleAttribute,
				Value = _icheckplayerbattleattribute
			};
		}

		// Token: 0x0601AF5D RID: 110429 RVA: 0x003D26CC File Offset: 0x003D08CC
		public static int Pack(FlatBufferBuilder builder, TTargetBattleAttributeUnion _o)
		{
			TTargetBattleAttribute type = _o.Type;
			if (type == TTargetBattleAttribute.ICheckMonsterBattleAttribute)
			{
				return ICheckMonsterBattleAttribute.Pack(builder, _o.AsICheckMonsterBattleAttribute()).Value;
			}
			if (type != TTargetBattleAttribute.ICheckPlayerBattleAttribute)
			{
				return 0;
			}
			return ICheckPlayerBattleAttribute.Pack(builder, _o.AsICheckPlayerBattleAttribute()).Value;
		}
	}
}
