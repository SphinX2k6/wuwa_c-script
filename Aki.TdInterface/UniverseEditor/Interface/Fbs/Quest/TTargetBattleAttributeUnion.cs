using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004321 RID: 17185
	public class TTargetBattleAttributeUnion
	{
		// Token: 0x17007978 RID: 31096
		// (get) Token: 0x060197C5 RID: 104389 RVA: 0x003A6C1E File Offset: 0x003A4E1E
		// (set) Token: 0x060197C6 RID: 104390 RVA: 0x003A6C26 File Offset: 0x003A4E26
		public TTargetBattleAttribute Type { get; set; }

		// Token: 0x17007979 RID: 31097
		// (get) Token: 0x060197C7 RID: 104391 RVA: 0x003A6C2F File Offset: 0x003A4E2F
		// (set) Token: 0x060197C8 RID: 104392 RVA: 0x003A6C37 File Offset: 0x003A4E37
		public object Value { get; set; }

		// Token: 0x060197C9 RID: 104393 RVA: 0x003A6C40 File Offset: 0x003A4E40
		public TTargetBattleAttributeUnion()
		{
			this.Type = TTargetBattleAttribute.NONE;
			this.Value = null;
		}

		// Token: 0x060197CA RID: 104394 RVA: 0x003A6C56 File Offset: 0x003A4E56
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060197CB RID: 104395 RVA: 0x003A6C68 File Offset: 0x003A4E68
		public ICheckMonsterBattleAttributeT AsICheckMonsterBattleAttribute()
		{
			return this.As<ICheckMonsterBattleAttributeT>();
		}

		// Token: 0x060197CC RID: 104396 RVA: 0x003A6C70 File Offset: 0x003A4E70
		public static TTargetBattleAttributeUnion FromICheckMonsterBattleAttribute(ICheckMonsterBattleAttributeT _icheckmonsterbattleattribute)
		{
			return new TTargetBattleAttributeUnion
			{
				Type = TTargetBattleAttribute.ICheckMonsterBattleAttribute,
				Value = _icheckmonsterbattleattribute
			};
		}

		// Token: 0x060197CD RID: 104397 RVA: 0x003A6C85 File Offset: 0x003A4E85
		public ICheckPlayerBattleAttributeT AsICheckPlayerBattleAttribute()
		{
			return this.As<ICheckPlayerBattleAttributeT>();
		}

		// Token: 0x060197CE RID: 104398 RVA: 0x003A6C8D File Offset: 0x003A4E8D
		public static TTargetBattleAttributeUnion FromICheckPlayerBattleAttribute(ICheckPlayerBattleAttributeT _icheckplayerbattleattribute)
		{
			return new TTargetBattleAttributeUnion
			{
				Type = TTargetBattleAttribute.ICheckPlayerBattleAttribute,
				Value = _icheckplayerbattleattribute
			};
		}

		// Token: 0x060197CF RID: 104399 RVA: 0x003A6CA4 File Offset: 0x003A4EA4
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
