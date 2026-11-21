using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AF5 RID: 6901
	public class IDartInteractTypeBase
	{
		// Token: 0x06009295 RID: 37525 RVA: 0x001575FC File Offset: 0x001557FC
		private IDartInteractTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDartInteractTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDartInteractTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDartInteractTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x06009296 RID: 37526 RVA: 0x00157634 File Offset: 0x00155834
		public static IDartInteractTypeBase Create([Nullable(2)] IDartInteractTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDartInteractTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009297 RID: 37527 RVA: 0x00157647 File Offset: 0x00155847
		public static IDartInteractTypeBase CreateFromSetValue([Nullable(2)] IDartInteractTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDartInteractTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009298 RID: 37528 RVA: 0x0015765A File Offset: 0x0015585A
		public IDartInteractTypeBase_SetValue ToSetValue()
		{
			return new IDartInteractTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EE7 RID: 12007
		// (get) Token: 0x06009299 RID: 37529 RVA: 0x0015766D File Offset: 0x0015586D
		// (set) Token: 0x0600929A RID: 37530 RVA: 0x00157698 File Offset: 0x00155898
		public virtual EDartInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDartInteractType.Machine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005B4A RID: 23370
		[Nullable(2)]
		protected IDartInteractTypeBase FbInstance;

		// Token: 0x04005B4B RID: 23371
		[Nullable(2)]
		protected IDartInteractTypeBase_SetValue PocoInterface;
	}
}
