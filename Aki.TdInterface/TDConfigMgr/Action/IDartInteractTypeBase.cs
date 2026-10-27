using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200196A RID: 6506
	[NullableContext(1)]
	[Nullable(0)]
	public class IDartInteractTypeBase
	{
		// Token: 0x06008B5F RID: 35679 RVA: 0x00147BC0 File Offset: 0x00145DC0
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

		// Token: 0x06008B60 RID: 35680 RVA: 0x00147BF8 File Offset: 0x00145DF8
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

		// Token: 0x06008B61 RID: 35681 RVA: 0x00147C0B File Offset: 0x00145E0B
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

		// Token: 0x06008B62 RID: 35682 RVA: 0x00147C1E File Offset: 0x00145E1E
		public IDartInteractTypeBase_SetValue ToSetValue()
		{
			return new IDartInteractTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002CE5 RID: 11493
		// (get) Token: 0x06008B63 RID: 35683 RVA: 0x00147C31 File Offset: 0x00145E31
		// (set) Token: 0x06008B64 RID: 35684 RVA: 0x00147C5C File Offset: 0x00145E5C
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

		// Token: 0x040056F6 RID: 22262
		[Nullable(2)]
		protected IDartInteractTypeBase FbInstance;

		// Token: 0x040056F7 RID: 22263
		[Nullable(2)]
		protected IDartInteractTypeBase_SetValue PocoInterface;
	}
}
