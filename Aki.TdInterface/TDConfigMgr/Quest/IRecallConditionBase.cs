using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010D6 RID: 4310
	[NullableContext(1)]
	[Nullable(0)]
	public class IRecallConditionBase
	{
		// Token: 0x0600617A RID: 24954 RVA: 0x000EB5E4 File Offset: 0x000E97E4
		private IRecallConditionBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRecallConditionBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRecallConditionBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRecallConditionBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600617B RID: 24955 RVA: 0x000EB61C File Offset: 0x000E981C
		public static IRecallConditionBase Create([Nullable(2)] IRecallConditionBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallConditionBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600617C RID: 24956 RVA: 0x000EB62F File Offset: 0x000E982F
		public static IRecallConditionBase CreateFromSetValue([Nullable(2)] IRecallConditionBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRecallConditionBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600617D RID: 24957 RVA: 0x000EB642 File Offset: 0x000E9842
		public IRecallConditionBase_SetValue ToSetValue()
		{
			return new IRecallConditionBase_SetValue
			{
				Type = this.Type,
				Operation = this.Operation
			};
		}

		// Token: 0x17002000 RID: 8192
		// (get) Token: 0x0600617E RID: 24958 RVA: 0x000EB661 File Offset: 0x000E9861
		// (set) Token: 0x0600617F RID: 24959 RVA: 0x000EB68C File Offset: 0x000E988C
		public virtual ERecallConditionType Type
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

		// Token: 0x17002001 RID: 8193
		// (get) Token: 0x06006180 RID: 24960 RVA: 0x000EB69A File Offset: 0x000E989A
		// (set) Token: 0x06006181 RID: 24961 RVA: 0x000EB6C5 File Offset: 0x000E98C5
		public virtual ERecallOperation Operation
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

		// Token: 0x04003AAD RID: 15021
		[Nullable(2)]
		protected IRecallConditionBase FbInstance;

		// Token: 0x04003AAE RID: 15022
		[Nullable(2)]
		protected IRecallConditionBase_SetValue PocoInterface;
	}
}
