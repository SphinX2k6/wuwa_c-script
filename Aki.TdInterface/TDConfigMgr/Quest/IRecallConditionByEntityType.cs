using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001206 RID: 4614
	public class IRecallConditionByEntityType : IRecallConditionBase
	{
		// Token: 0x0600677D RID: 26493 RVA: 0x000F8804 File Offset: 0x000F6A04
		private IRecallConditionByEntityType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRecallConditionByEntityType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRecallConditionByEntityType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRecallConditionByEntityType_SetValue());
			}
			return result;
		}

		// Token: 0x0600677E RID: 26494 RVA: 0x000F883C File Offset: 0x000F6A3C
		public static IRecallConditionByEntityType Create([Nullable(2)] IRecallConditionByEntityType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallConditionByEntityType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600677F RID: 26495 RVA: 0x000F884F File Offset: 0x000F6A4F
		public static IRecallConditionByEntityType CreateFromSetValue([Nullable(2)] IRecallConditionByEntityType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRecallConditionByEntityType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006780 RID: 26496 RVA: 0x000F8862 File Offset: 0x000F6A62
		public new IRecallConditionByEntityType_SetValue ToSetValue()
		{
			return new IRecallConditionByEntityType_SetValue
			{
				Type = this.Type,
				Operation = this.Operation,
				EntityTypes = this.EntityTypes,
				AreaIds = this.AreaIds
			};
		}

		// Token: 0x170021B4 RID: 8628
		// (get) Token: 0x06006781 RID: 26497 RVA: 0x000F8899 File Offset: 0x000F6A99
		// (set) Token: 0x06006782 RID: 26498 RVA: 0x000F88C4 File Offset: 0x000F6AC4
		public override ERecallConditionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERecallConditionType.ByEntityType;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170021B5 RID: 8629
		// (get) Token: 0x06006783 RID: 26499 RVA: 0x000F88D2 File Offset: 0x000F6AD2
		// (set) Token: 0x06006784 RID: 26500 RVA: 0x000F88FD File Offset: 0x000F6AFD
		public override ERecallOperation Operation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Operation;
				}
				if (this.PocoInterface == null)
				{
					return ERecallOperation.Include;
				}
				return this.PocoInterface.Operation;
			}
			set
			{
				this.GetOrCreatePoco().Operation = value;
			}
		}

		// Token: 0x170021B6 RID: 8630
		// (get) Token: 0x06006785 RID: 26501 RVA: 0x000F890B File Offset: 0x000F6B0B
		// (set) Token: 0x06006786 RID: 26502 RVA: 0x000F8932 File Offset: 0x000F6B32
		public virtual List<string> EntityTypes
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityTypes;
				}
				IRecallConditionByEntityType_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityTypes;
			}
			set
			{
				this.GetOrCreatePoco().EntityTypes = value;
			}
		}

		// Token: 0x170021B7 RID: 8631
		// (get) Token: 0x06006787 RID: 26503 RVA: 0x000F8940 File Offset: 0x000F6B40
		// (set) Token: 0x06006788 RID: 26504 RVA: 0x000F8967 File Offset: 0x000F6B67
		public virtual List<int> AreaIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AreaIds;
				}
				IRecallConditionByEntityType_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AreaIds;
			}
			set
			{
				this.GetOrCreatePoco().AreaIds = value;
			}
		}

		// Token: 0x04003DFE RID: 15870
		[Nullable(2)]
		protected new IRecallConditionByEntityType FbInstance;

		// Token: 0x04003DFF RID: 15871
		[Nullable(2)]
		protected new IRecallConditionByEntityType_SetValue PocoInterface;
	}
}
