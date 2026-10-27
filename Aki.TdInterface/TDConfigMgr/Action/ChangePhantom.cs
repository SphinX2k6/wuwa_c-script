using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014E0 RID: 5344
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangePhantom : ActionParams
	{
		// Token: 0x060079A4 RID: 31140 RVA: 0x00123030 File Offset: 0x00121230
		private ChangePhantom_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangePhantom 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangePhantom_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangePhantom_SetValue());
			}
			return result;
		}

		// Token: 0x060079A5 RID: 31141 RVA: 0x00123068 File Offset: 0x00121268
		public static ChangePhantom Create([Nullable(2)] ChangePhantom instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangePhantom
			{
				FbInstance = instance
			};
		}

		// Token: 0x060079A6 RID: 31142 RVA: 0x0012307B File Offset: 0x0012127B
		public static ChangePhantom CreateFromSetValue([Nullable(2)] ChangePhantom_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangePhantom
			{
				PocoInterface = value
			};
		}

		// Token: 0x060079A7 RID: 31143 RVA: 0x0012308E File Offset: 0x0012128E
		public ChangePhantom_SetValue ToSetValue()
		{
			return new ChangePhantom_SetValue
			{
				Id = this.Id
			};
		}

		// Token: 0x170028B8 RID: 10424
		// (get) Token: 0x060079A8 RID: 31144 RVA: 0x001230A1 File Offset: 0x001212A1
		// (set) Token: 0x060079A9 RID: 31145 RVA: 0x001230CC File Offset: 0x001212CC
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04004691 RID: 18065
		[Nullable(2)]
		protected new ChangePhantom FbInstance;

		// Token: 0x04004692 RID: 18066
		[Nullable(2)]
		protected ChangePhantom_SetValue PocoInterface;
	}
}
