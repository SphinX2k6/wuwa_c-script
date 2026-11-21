using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A2B RID: 6699
	public class IClientDisableAllPlayerOperation : ClientSetPlayerOperationRestriction
	{
		// Token: 0x06008E7D RID: 36477 RVA: 0x00150678 File Offset: 0x0014E878
		private IClientDisableAllPlayerOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientDisableAllPlayerOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientDisableAllPlayerOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientDisableAllPlayerOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06008E7E RID: 36478 RVA: 0x001506B0 File Offset: 0x0014E8B0
		public static IClientDisableAllPlayerOperation Create([Nullable(2)] IClientDisableAllPlayerOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientDisableAllPlayerOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008E7F RID: 36479 RVA: 0x001506C3 File Offset: 0x0014E8C3
		public static IClientDisableAllPlayerOperation CreateFromSetValue([Nullable(2)] IClientDisableAllPlayerOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientDisableAllPlayerOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008E80 RID: 36480 RVA: 0x001506D6 File Offset: 0x0014E8D6
		public new IClientDisableAllPlayerOperation_SetValue ToSetValue()
		{
			return new IClientDisableAllPlayerOperation_SetValue
			{
				Type = this.Type,
				DisplayMode = this.DisplayMode
			};
		}

		// Token: 0x17002E0A RID: 11786
		// (get) Token: 0x06008E81 RID: 36481 RVA: 0x001506F5 File Offset: 0x0014E8F5
		// (set) Token: 0x06008E82 RID: 36482 RVA: 0x00150720 File Offset: 0x0014E920
		public override EPlayerOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPlayerOperationType.EnableAll;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E0B RID: 11787
		// (get) Token: 0x06008E83 RID: 36483 RVA: 0x00150730 File Offset: 0x0014E930
		// (set) Token: 0x06008E84 RID: 36484 RVA: 0x0015076A File Offset: 0x0014E96A
		public virtual EDisplayModeInPlayerOp? DisplayMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisplayMode;
				}
				IClientDisableAllPlayerOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisplayMode;
			}
			set
			{
				this.GetOrCreatePoco().DisplayMode = value;
			}
		}

		// Token: 0x0400597F RID: 22911
		[Nullable(2)]
		protected new IClientDisableAllPlayerOperation FbInstance;

		// Token: 0x04005980 RID: 22912
		[Nullable(2)]
		protected new IClientDisableAllPlayerOperation_SetValue PocoInterface;
	}
}
