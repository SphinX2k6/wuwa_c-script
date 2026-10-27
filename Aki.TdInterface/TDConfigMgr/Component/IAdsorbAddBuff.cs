using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001A9 RID: 425
	[NullableContext(1)]
	[Nullable(0)]
	public class IAdsorbAddBuff : IAddBuffMode
	{
		// Token: 0x06000680 RID: 1664 RVA: 0x000230F4 File Offset: 0x000212F4
		private IAdsorbAddBuff_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAdsorbAddBuff 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAdsorbAddBuff_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAdsorbAddBuff_SetValue());
			}
			return result;
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0002312C File Offset: 0x0002132C
		public static IAdsorbAddBuff Create([Nullable(2)] IAdsorbAddBuff instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAdsorbAddBuff
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0002313F File Offset: 0x0002133F
		public static IAdsorbAddBuff CreateFromSetValue([Nullable(2)] IAdsorbAddBuff_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAdsorbAddBuff
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00023152 File Offset: 0x00021352
		public new IAdsorbAddBuff_SetValue ToSetValue()
		{
			return new IAdsorbAddBuff_SetValue
			{
				Type = this.Type,
				Speed = this.Speed
			};
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x00023171 File Offset: 0x00021371
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x0002319C File Offset: 0x0002139C
		public override EBuffProducerMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBuffProducerMode.Immediate;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x000231AA File Offset: 0x000213AA
		// (set) Token: 0x06000687 RID: 1671 RVA: 0x000231D5 File Offset: 0x000213D5
		public virtual int Speed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Speed;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Speed;
			}
			set
			{
				this.GetOrCreatePoco().Speed = value;
			}
		}

		// Token: 0x0400081E RID: 2078
		[Nullable(2)]
		protected new IAdsorbAddBuff FbInstance;

		// Token: 0x0400081F RID: 2079
		[Nullable(2)]
		protected new IAdsorbAddBuff_SetValue PocoInterface;
	}
}
