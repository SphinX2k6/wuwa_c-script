using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C4A RID: 7242
	public class IFocusOnQuestMapMark : IFocusOnMapMark
	{
		// Token: 0x06009A0A RID: 39434 RVA: 0x00164BF8 File Offset: 0x00162DF8
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

		// Token: 0x06009A0B RID: 39435 RVA: 0x00164C30 File Offset: 0x00162E30
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

		// Token: 0x06009A0C RID: 39436 RVA: 0x00164C43 File Offset: 0x00162E43
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

		// Token: 0x06009A0D RID: 39437 RVA: 0x00164C56 File Offset: 0x00162E56
		public new IFocusOnQuestMapMark_SetValue ToSetValue()
		{
			return new IFocusOnQuestMapMark_SetValue
			{
				Type = this.Type,
				QuestId = this.QuestId
			};
		}

		// Token: 0x170030A3 RID: 12451
		// (get) Token: 0x06009A0E RID: 39438 RVA: 0x00164C75 File Offset: 0x00162E75
		// (set) Token: 0x06009A0F RID: 39439 RVA: 0x00164CA0 File Offset: 0x00162EA0
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

		// Token: 0x170030A4 RID: 12452
		// (get) Token: 0x06009A10 RID: 39440 RVA: 0x00164CAE File Offset: 0x00162EAE
		// (set) Token: 0x06009A11 RID: 39441 RVA: 0x00164CD9 File Offset: 0x00162ED9
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

		// Token: 0x04005EA8 RID: 24232
		[Nullable(2)]
		protected new IFocusOnQuestMapMark FbInstance;

		// Token: 0x04005EA9 RID: 24233
		[Nullable(2)]
		protected new IFocusOnQuestMapMark_SetValue PocoInterface;
	}
}
