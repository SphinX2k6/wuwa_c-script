using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010DC RID: 4316
	[NullableContext(1)]
	[Nullable(0)]
	public class IRecallConditionByTemplate : IRecallConditionBase
	{
		// Token: 0x0600619E RID: 24990 RVA: 0x000EB9A8 File Offset: 0x000E9BA8
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

		// Token: 0x0600619F RID: 24991 RVA: 0x000EB9E0 File Offset: 0x000E9BE0
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

		// Token: 0x060061A0 RID: 24992 RVA: 0x000EB9F3 File Offset: 0x000E9BF3
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

		// Token: 0x060061A1 RID: 24993 RVA: 0x000EBA06 File Offset: 0x000E9C06
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

		// Token: 0x17002009 RID: 8201
		// (get) Token: 0x060061A2 RID: 24994 RVA: 0x000EBA3D File Offset: 0x000E9C3D
		// (set) Token: 0x060061A3 RID: 24995 RVA: 0x000EBA68 File Offset: 0x000E9C68
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

		// Token: 0x1700200A RID: 8202
		// (get) Token: 0x060061A4 RID: 24996 RVA: 0x000EBA76 File Offset: 0x000E9C76
		// (set) Token: 0x060061A5 RID: 24997 RVA: 0x000EBAA1 File Offset: 0x000E9CA1
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

		// Token: 0x1700200B RID: 8203
		// (get) Token: 0x060061A6 RID: 24998 RVA: 0x000EBAAF File Offset: 0x000E9CAF
		// (set) Token: 0x060061A7 RID: 24999 RVA: 0x000EBAD6 File Offset: 0x000E9CD6
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

		// Token: 0x1700200C RID: 8204
		// (get) Token: 0x060061A8 RID: 25000 RVA: 0x000EBAE4 File Offset: 0x000E9CE4
		// (set) Token: 0x060061A9 RID: 25001 RVA: 0x000EBB0B File Offset: 0x000E9D0B
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

		// Token: 0x04003ABC RID: 15036
		[Nullable(2)]
		protected new IRecallConditionByTemplate FbInstance;

		// Token: 0x04003ABD RID: 15037
		[Nullable(2)]
		protected new IRecallConditionByTemplate_SetValue PocoInterface;
	}
}
