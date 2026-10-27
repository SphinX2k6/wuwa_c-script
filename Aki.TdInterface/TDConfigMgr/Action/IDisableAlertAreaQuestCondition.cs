using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019A0 RID: 6560
	[NullableContext(1)]
	[Nullable(0)]
	public class IDisableAlertAreaQuestCondition : IDisableAlertAreaCondition
	{
		// Token: 0x06008C61 RID: 35937 RVA: 0x0014965C File Offset: 0x0014785C
		private IDisableAlertAreaQuestCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableAlertAreaQuestCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableAlertAreaQuestCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableAlertAreaQuestCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06008C62 RID: 35938 RVA: 0x00149694 File Offset: 0x00147894
		public static IDisableAlertAreaQuestCondition Create([Nullable(2)] IDisableAlertAreaQuestCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableAlertAreaQuestCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008C63 RID: 35939 RVA: 0x001496A7 File Offset: 0x001478A7
		public static IDisableAlertAreaQuestCondition CreateFromSetValue([Nullable(2)] IDisableAlertAreaQuestCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableAlertAreaQuestCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008C64 RID: 35940 RVA: 0x001496BA File Offset: 0x001478BA
		public new IDisableAlertAreaQuestCondition_SetValue ToSetValue()
		{
			return new IDisableAlertAreaQuestCondition_SetValue
			{
				Type = this.Type,
				RelatedQuestId = this.RelatedQuestId
			};
		}

		// Token: 0x17002D15 RID: 11541
		// (get) Token: 0x06008C65 RID: 35941 RVA: 0x001496D9 File Offset: 0x001478D9
		// (set) Token: 0x06008C66 RID: 35942 RVA: 0x00149704 File Offset: 0x00147904
		public override EDisableAlertAreaCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDisableAlertAreaCondition.DungeonCondition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002D16 RID: 11542
		// (get) Token: 0x06008C67 RID: 35943 RVA: 0x00149712 File Offset: 0x00147912
		// (set) Token: 0x06008C68 RID: 35944 RVA: 0x0014973D File Offset: 0x0014793D
		public virtual int RelatedQuestId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RelatedQuestId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RelatedQuestId;
			}
			set
			{
				this.GetOrCreatePoco().RelatedQuestId = value;
			}
		}

		// Token: 0x04005764 RID: 22372
		[Nullable(2)]
		protected new IDisableAlertAreaQuestCondition FbInstance;

		// Token: 0x04005765 RID: 22373
		[Nullable(2)]
		protected new IDisableAlertAreaQuestCondition_SetValue PocoInterface;
	}
}
