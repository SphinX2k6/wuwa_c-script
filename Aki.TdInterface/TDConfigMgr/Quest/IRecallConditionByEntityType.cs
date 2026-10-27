using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010D8 RID: 4312
	[NullableContext(1)]
	[Nullable(0)]
	public class IRecallConditionByEntityType : IRecallConditionBase
	{
		// Token: 0x06006184 RID: 24964 RVA: 0x000EB6E4 File Offset: 0x000E98E4
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

		// Token: 0x06006185 RID: 24965 RVA: 0x000EB71C File Offset: 0x000E991C
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

		// Token: 0x06006186 RID: 24966 RVA: 0x000EB72F File Offset: 0x000E992F
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

		// Token: 0x06006187 RID: 24967 RVA: 0x000EB742 File Offset: 0x000E9942
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

		// Token: 0x17002002 RID: 8194
		// (get) Token: 0x06006188 RID: 24968 RVA: 0x000EB779 File Offset: 0x000E9979
		// (set) Token: 0x06006189 RID: 24969 RVA: 0x000EB7A4 File Offset: 0x000E99A4
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

		// Token: 0x17002003 RID: 8195
		// (get) Token: 0x0600618A RID: 24970 RVA: 0x000EB7B2 File Offset: 0x000E99B2
		// (set) Token: 0x0600618B RID: 24971 RVA: 0x000EB7DD File Offset: 0x000E99DD
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

		// Token: 0x17002004 RID: 8196
		// (get) Token: 0x0600618C RID: 24972 RVA: 0x000EB7EB File Offset: 0x000E99EB
		// (set) Token: 0x0600618D RID: 24973 RVA: 0x000EB812 File Offset: 0x000E9A12
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

		// Token: 0x17002005 RID: 8197
		// (get) Token: 0x0600618E RID: 24974 RVA: 0x000EB820 File Offset: 0x000E9A20
		// (set) Token: 0x0600618F RID: 24975 RVA: 0x000EB847 File Offset: 0x000E9A47
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

		// Token: 0x04003AB1 RID: 15025
		[Nullable(2)]
		protected new IRecallConditionByEntityType FbInstance;

		// Token: 0x04003AB2 RID: 15026
		[Nullable(2)]
		protected new IRecallConditionByEntityType_SetValue PocoInterface;
	}
}
