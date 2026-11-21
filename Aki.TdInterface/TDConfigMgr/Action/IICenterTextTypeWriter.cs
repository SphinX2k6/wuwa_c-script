using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CD4 RID: 7380
	public class IICenterTextTypeWriter : ICenterTextShowType
	{
		// Token: 0x06009CAE RID: 40110 RVA: 0x0016913C File Offset: 0x0016733C
		private IICenterTextTypeWriter_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IICenterTextTypeWriter 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IICenterTextTypeWriter_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IICenterTextTypeWriter_SetValue());
			}
			return result;
		}

		// Token: 0x06009CAF RID: 40111 RVA: 0x00169174 File Offset: 0x00167374
		public static IICenterTextTypeWriter Create([Nullable(2)] IICenterTextTypeWriter instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IICenterTextTypeWriter
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009CB0 RID: 40112 RVA: 0x00169187 File Offset: 0x00167387
		public static IICenterTextTypeWriter CreateFromSetValue([Nullable(2)] IICenterTextTypeWriter_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IICenterTextTypeWriter
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009CB1 RID: 40113 RVA: 0x0016919A File Offset: 0x0016739A
		public new IICenterTextTypeWriter_SetValue ToSetValue()
		{
			return new IICenterTextTypeWriter_SetValue
			{
				Type = this.Type,
				TextCountPerSecond = this.TextCountPerSecond
			};
		}

		// Token: 0x17003126 RID: 12582
		// (get) Token: 0x06009CB2 RID: 40114 RVA: 0x001691B9 File Offset: 0x001673B9
		// (set) Token: 0x06009CB3 RID: 40115 RVA: 0x001691E4 File Offset: 0x001673E4
		public override ECenterTextShowAnim Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECenterTextShowAnim.ShowAll;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003127 RID: 12583
		// (get) Token: 0x06009CB4 RID: 40116 RVA: 0x001691F2 File Offset: 0x001673F2
		// (set) Token: 0x06009CB5 RID: 40117 RVA: 0x0016921D File Offset: 0x0016741D
		public virtual int TextCountPerSecond
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TextCountPerSecond;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TextCountPerSecond;
			}
			set
			{
				this.GetOrCreatePoco().TextCountPerSecond = value;
			}
		}

		// Token: 0x04005FC1 RID: 24513
		[Nullable(2)]
		protected new IICenterTextTypeWriter FbInstance;

		// Token: 0x04005FC2 RID: 24514
		[Nullable(2)]
		protected new IICenterTextTypeWriter_SetValue PocoInterface;
	}
}
