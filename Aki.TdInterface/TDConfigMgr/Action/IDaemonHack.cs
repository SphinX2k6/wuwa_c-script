using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AED RID: 6893
	public class IDaemonHack : IUiGame
	{
		// Token: 0x0600926B RID: 37483 RVA: 0x001571B0 File Offset: 0x001553B0
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

		// Token: 0x0600926C RID: 37484 RVA: 0x001571E8 File Offset: 0x001553E8
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

		// Token: 0x0600926D RID: 37485 RVA: 0x001571FB File Offset: 0x001553FB
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

		// Token: 0x0600926E RID: 37486 RVA: 0x0015720E File Offset: 0x0015540E
		public new IDaemonHack_SetValue ToSetValue()
		{
			return new IDaemonHack_SetValue
			{
				Type = this.Type,
				Ids = this.Ids,
				FinishOnClose = this.FinishOnClose
			};
		}

		// Token: 0x17002EDE RID: 11998
		// (get) Token: 0x0600926F RID: 37487 RVA: 0x00157239 File Offset: 0x00155439
		// (set) Token: 0x06009270 RID: 37488 RVA: 0x00157264 File Offset: 0x00155464
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

		// Token: 0x17002EDF RID: 11999
		// (get) Token: 0x06009271 RID: 37489 RVA: 0x00157272 File Offset: 0x00155472
		// (set) Token: 0x06009272 RID: 37490 RVA: 0x00157299 File Offset: 0x00155499
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

		// Token: 0x17002EE0 RID: 12000
		// (get) Token: 0x06009273 RID: 37491 RVA: 0x001572A8 File Offset: 0x001554A8
		// (set) Token: 0x06009274 RID: 37492 RVA: 0x001572E2 File Offset: 0x001554E2
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

		// Token: 0x04005B39 RID: 23353
		[Nullable(2)]
		protected new IDaemonHack FbInstance;

		// Token: 0x04005B3A RID: 23354
		[Nullable(2)]
		protected new IDaemonHack_SetValue PocoInterface;
	}
}
