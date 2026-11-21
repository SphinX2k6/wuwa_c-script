using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200120A RID: 4618
	public class IRecallConditionByTemplate : IRecallConditionBase
	{
		// Token: 0x06006797 RID: 26519 RVA: 0x000F8AC8 File Offset: 0x000F6CC8
		private IRecallConditionByTemplate_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRecallConditionByTemplate 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRecallConditionByTemplate_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRecallConditionByTemplate_SetValue());
			}
			return result;
		}

		// Token: 0x06006798 RID: 26520 RVA: 0x000F8B00 File Offset: 0x000F6D00
		public static IRecallConditionByTemplate Create([Nullable(2)] IRecallConditionByTemplate instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallConditionByTemplate
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006799 RID: 26521 RVA: 0x000F8B13 File Offset: 0x000F6D13
		public static IRecallConditionByTemplate CreateFromSetValue([Nullable(2)] IRecallConditionByTemplate_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRecallConditionByTemplate
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600679A RID: 26522 RVA: 0x000F8B26 File Offset: 0x000F6D26
		public new IRecallConditionByTemplate_SetValue ToSetValue()
		{
			return new IRecallConditionByTemplate_SetValue
			{
				Type = this.Type,
				Operation = this.Operation,
				Templates = this.Templates,
				AreaIds = this.AreaIds
			};
		}

		// Token: 0x170021BB RID: 8635
		// (get) Token: 0x0600679B RID: 26523 RVA: 0x000F8B5D File Offset: 0x000F6D5D
		// (set) Token: 0x0600679C RID: 26524 RVA: 0x000F8B88 File Offset: 0x000F6D88
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

		// Token: 0x170021BC RID: 8636
		// (get) Token: 0x0600679D RID: 26525 RVA: 0x000F8B96 File Offset: 0x000F6D96
		// (set) Token: 0x0600679E RID: 26526 RVA: 0x000F8BC1 File Offset: 0x000F6DC1
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

		// Token: 0x170021BD RID: 8637
		// (get) Token: 0x0600679F RID: 26527 RVA: 0x000F8BCF File Offset: 0x000F6DCF
		// (set) Token: 0x060067A0 RID: 26528 RVA: 0x000F8BF6 File Offset: 0x000F6DF6
		public virtual List<string> Templates
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Templates;
				}
				IRecallConditionByTemplate_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Templates;
			}
			set
			{
				this.GetOrCreatePoco().Templates = value;
			}
		}

		// Token: 0x170021BE RID: 8638
		// (get) Token: 0x060067A1 RID: 26529 RVA: 0x000F8C04 File Offset: 0x000F6E04
		// (set) Token: 0x060067A2 RID: 26530 RVA: 0x000F8C2B File Offset: 0x000F6E2B
		public virtual List<int> AreaIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AreaIds;
				}
				IRecallConditionByTemplate_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04003E09 RID: 15881
		[Nullable(2)]
		protected new IRecallConditionByTemplate FbInstance;

		// Token: 0x04003E0A RID: 15882
		[Nullable(2)]
		protected new IRecallConditionByTemplate_SetValue PocoInterface;
	}
}
