using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AB1 RID: 6833
	[NullableContext(1)]
	[Nullable(0)]
	public class IFocusOnQuestMapMark : IFocusOnMapMark
	{
		// Token: 0x0600928A RID: 37514 RVA: 0x00154A0C File Offset: 0x00152C0C
		private IFocusOnQuestMapMark_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFocusOnQuestMapMark 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFocusOnQuestMapMark_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFocusOnQuestMapMark_SetValue());
			}
			return result;
		}

		// Token: 0x0600928B RID: 37515 RVA: 0x00154A44 File Offset: 0x00152C44
		public static IFocusOnQuestMapMark Create([Nullable(2)] IFocusOnQuestMapMark instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFocusOnQuestMapMark
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600928C RID: 37516 RVA: 0x00154A57 File Offset: 0x00152C57
		public static IFocusOnQuestMapMark CreateFromSetValue([Nullable(2)] IFocusOnQuestMapMark_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFocusOnQuestMapMark
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600928D RID: 37517 RVA: 0x00154A6A File Offset: 0x00152C6A
		public new IFocusOnQuestMapMark_SetValue ToSetValue()
		{
			return new IFocusOnQuestMapMark_SetValue
			{
				Type = this.Type,
				QuestId = this.QuestId
			};
		}

		// Token: 0x17002E91 RID: 11921
		// (get) Token: 0x0600928E RID: 37518 RVA: 0x00154A89 File Offset: 0x00152C89
		// (set) Token: 0x0600928F RID: 37519 RVA: 0x00154AB4 File Offset: 0x00152CB4
		public override EMapMarkType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMapMarkType.Custom;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E92 RID: 11922
		// (get) Token: 0x06009290 RID: 37520 RVA: 0x00154AC2 File Offset: 0x00152CC2
		// (set) Token: 0x06009291 RID: 37521 RVA: 0x00154AED File Offset: 0x00152CED
		public virtual int QuestId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.QuestId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.QuestId;
			}
			set
			{
				this.GetOrCreatePoco().QuestId = value;
			}
		}

		// Token: 0x04005A38 RID: 23096
		[Nullable(2)]
		protected new IFocusOnQuestMapMark FbInstance;

		// Token: 0x04005A39 RID: 23097
		[Nullable(2)]
		protected new IFocusOnQuestMapMark_SetValue PocoInterface;
	}
}
