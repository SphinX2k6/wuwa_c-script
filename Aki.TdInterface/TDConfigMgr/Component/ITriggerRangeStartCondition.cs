using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200084B RID: 2123
	public class ITriggerRangeStartCondition : ISpawnMonsterStartCondition
	{
		// Token: 0x06002DB6 RID: 11702 RVA: 0x00076BFC File Offset: 0x00074DFC
		private ITriggerRangeStartCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITriggerRangeStartCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITriggerRangeStartCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITriggerRangeStartCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x00076C34 File Offset: 0x00074E34
		public static ITriggerRangeStartCondition Create([Nullable(2)] ITriggerRangeStartCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggerRangeStartCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x00076C47 File Offset: 0x00074E47
		public static ITriggerRangeStartCondition CreateFromSetValue([Nullable(2)] ITriggerRangeStartCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITriggerRangeStartCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x00076C5A File Offset: 0x00074E5A
		public new ITriggerRangeStartCondition_SetValue ToSetValue()
		{
			return new ITriggerRangeStartCondition_SetValue
			{
				Type = this.Type,
				Range = this.Range
			};
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x06002DBA RID: 11706 RVA: 0x00076C79 File Offset: 0x00074E79
		// (set) Token: 0x06002DBB RID: 11707 RVA: 0x00076CA4 File Offset: 0x00074EA4
		public override ESpawnMonsterStartCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpawnMonsterStartCondition.Immediate;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x06002DBC RID: 11708 RVA: 0x00076CB2 File Offset: 0x00074EB2
		// (set) Token: 0x06002DBD RID: 11709 RVA: 0x00076CDD File Offset: 0x00074EDD
		public virtual int Range
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Range;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Range;
			}
			set
			{
				this.GetOrCreatePoco().Range = value;
			}
		}

		// Token: 0x04001E6F RID: 7791
		[Nullable(2)]
		protected new ITriggerRangeStartCondition FbInstance;

		// Token: 0x04001E70 RID: 7792
		[Nullable(2)]
		protected new ITriggerRangeStartCondition_SetValue PocoInterface;
	}
}
