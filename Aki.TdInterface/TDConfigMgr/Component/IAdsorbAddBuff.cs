using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001C0 RID: 448
	public class IAdsorbAddBuff : IAddBuffMode
	{
		// Token: 0x06000696 RID: 1686 RVA: 0x00023D54 File Offset: 0x00021F54
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

		// Token: 0x06000697 RID: 1687 RVA: 0x00023D8C File Offset: 0x00021F8C
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

		// Token: 0x06000698 RID: 1688 RVA: 0x00023D9F File Offset: 0x00021F9F
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

		// Token: 0x06000699 RID: 1689 RVA: 0x00023DB2 File Offset: 0x00021FB2
		public new IAdsorbAddBuff_SetValue ToSetValue()
		{
			return new IAdsorbAddBuff_SetValue
			{
				Type = this.Type,
				Speed = this.Speed
			};
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x00023DD1 File Offset: 0x00021FD1
		// (set) Token: 0x0600069B RID: 1691 RVA: 0x00023DFC File Offset: 0x00021FFC
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

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x00023E0A File Offset: 0x0002200A
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x00023E35 File Offset: 0x00022035
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

		// Token: 0x04000877 RID: 2167
		[Nullable(2)]
		protected new IAdsorbAddBuff FbInstance;

		// Token: 0x04000878 RID: 2168
		[Nullable(2)]
		protected new IAdsorbAddBuff_SetValue PocoInterface;
	}
}
