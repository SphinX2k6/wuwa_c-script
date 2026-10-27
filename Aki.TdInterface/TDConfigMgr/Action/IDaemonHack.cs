using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001962 RID: 6498
	[NullableContext(1)]
	[Nullable(0)]
	public class IDaemonHack : IUiGame
	{
		// Token: 0x06008B35 RID: 35637 RVA: 0x00147774 File Offset: 0x00145974
		private IDaemonHack_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDaemonHack 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDaemonHack_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDaemonHack_SetValue());
			}
			return result;
		}

		// Token: 0x06008B36 RID: 35638 RVA: 0x001477AC File Offset: 0x001459AC
		public static IDaemonHack Create([Nullable(2)] IDaemonHack instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDaemonHack
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008B37 RID: 35639 RVA: 0x001477BF File Offset: 0x001459BF
		public static IDaemonHack CreateFromSetValue([Nullable(2)] IDaemonHack_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDaemonHack
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008B38 RID: 35640 RVA: 0x001477D2 File Offset: 0x001459D2
		public new IDaemonHack_SetValue ToSetValue()
		{
			return new IDaemonHack_SetValue
			{
				Type = this.Type,
				Ids = this.Ids,
				FinishOnClose = this.FinishOnClose
			};
		}

		// Token: 0x17002CDC RID: 11484
		// (get) Token: 0x06008B39 RID: 35641 RVA: 0x001477FD File Offset: 0x001459FD
		// (set) Token: 0x06008B3A RID: 35642 RVA: 0x00147828 File Offset: 0x00145A28
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002CDD RID: 11485
		// (get) Token: 0x06008B3B RID: 35643 RVA: 0x00147836 File Offset: 0x00145A36
		// (set) Token: 0x06008B3C RID: 35644 RVA: 0x0014785D File Offset: 0x00145A5D
		public virtual List<int> Ids
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Ids;
				}
				IDaemonHack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Ids;
			}
			set
			{
				this.GetOrCreatePoco().Ids = value;
			}
		}

		// Token: 0x17002CDE RID: 11486
		// (get) Token: 0x06008B3D RID: 35645 RVA: 0x0014786C File Offset: 0x00145A6C
		// (set) Token: 0x06008B3E RID: 35646 RVA: 0x001478A6 File Offset: 0x00145AA6
		public virtual bool? FinishOnClose
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FinishOnClose;
				}
				IDaemonHack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FinishOnClose;
			}
			set
			{
				this.GetOrCreatePoco().FinishOnClose = value;
			}
		}

		// Token: 0x040056E5 RID: 22245
		[Nullable(2)]
		protected new IDaemonHack FbInstance;

		// Token: 0x040056E6 RID: 22246
		[Nullable(2)]
		protected new IDaemonHack_SetValue PocoInterface;
	}
}
