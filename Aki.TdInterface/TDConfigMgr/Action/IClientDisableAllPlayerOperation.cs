using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018A0 RID: 6304
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientDisableAllPlayerOperation : ClientSetPlayerOperationRestriction
	{
		// Token: 0x06008755 RID: 34645 RVA: 0x00140E44 File Offset: 0x0013F044
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

		// Token: 0x06008756 RID: 34646 RVA: 0x00140E7C File Offset: 0x0013F07C
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

		// Token: 0x06008757 RID: 34647 RVA: 0x00140E8F File Offset: 0x0013F08F
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

		// Token: 0x06008758 RID: 34648 RVA: 0x00140EA2 File Offset: 0x0013F0A2
		public new IClientDisableAllPlayerOperation_SetValue ToSetValue()
		{
			return new IClientDisableAllPlayerOperation_SetValue
			{
				Type = this.Type,
				DisplayMode = this.DisplayMode
			};
		}

		// Token: 0x17002C0F RID: 11279
		// (get) Token: 0x06008759 RID: 34649 RVA: 0x00140EC1 File Offset: 0x0013F0C1
		// (set) Token: 0x0600875A RID: 34650 RVA: 0x00140EEC File Offset: 0x0013F0EC
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

		// Token: 0x17002C10 RID: 11280
		// (get) Token: 0x0600875B RID: 34651 RVA: 0x00140EFC File Offset: 0x0013F0FC
		// (set) Token: 0x0600875C RID: 34652 RVA: 0x00140F36 File Offset: 0x0013F136
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

		// Token: 0x04005532 RID: 21810
		[Nullable(2)]
		protected new IClientDisableAllPlayerOperation FbInstance;

		// Token: 0x04005533 RID: 21811
		[Nullable(2)]
		protected new IClientDisableAllPlayerOperation_SetValue PocoInterface;
	}
}
