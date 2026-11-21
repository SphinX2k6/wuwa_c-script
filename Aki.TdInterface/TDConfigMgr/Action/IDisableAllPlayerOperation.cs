using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B2B RID: 6955
	[JsonConverter(typeof(IDisableAllPlayerOperationConverter))]
	public class IDisableAllPlayerOperation : SetPlayerOperationRestriction
	{
		// Token: 0x06009397 RID: 37783 RVA: 0x00159028 File Offset: 0x00157228
		private IDisableAllPlayerOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableAllPlayerOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableAllPlayerOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableAllPlayerOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06009398 RID: 37784 RVA: 0x00159060 File Offset: 0x00157260
		public static IDisableAllPlayerOperation Create([Nullable(2)] IDisableAllPlayerOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableAllPlayerOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009399 RID: 37785 RVA: 0x00159073 File Offset: 0x00157273
		public static IDisableAllPlayerOperation CreateFromSetValue([Nullable(2)] IDisableAllPlayerOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableAllPlayerOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600939A RID: 37786 RVA: 0x00159086 File Offset: 0x00157286
		public new IDisableAllPlayerOperation_SetValue ToSetValue()
		{
			return new IDisableAllPlayerOperation_SetValue
			{
				Type = this.Type,
				DisplayMode = this.DisplayMode,
				IsUiFadeEffect = this.IsUiFadeEffect
			};
		}

		// Token: 0x17002F17 RID: 12055
		// (get) Token: 0x0600939B RID: 37787 RVA: 0x001590B1 File Offset: 0x001572B1
		// (set) Token: 0x0600939C RID: 37788 RVA: 0x001590DC File Offset: 0x001572DC
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

		// Token: 0x17002F18 RID: 12056
		// (get) Token: 0x0600939D RID: 37789 RVA: 0x001590EC File Offset: 0x001572EC
		// (set) Token: 0x0600939E RID: 37790 RVA: 0x00159126 File Offset: 0x00157326
		public virtual EDisplayModeInPlayerOp? DisplayMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisplayMode;
				}
				IDisableAllPlayerOperation_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002F19 RID: 12057
		// (get) Token: 0x0600939F RID: 37791 RVA: 0x00159134 File Offset: 0x00157334
		// (set) Token: 0x060093A0 RID: 37792 RVA: 0x0015916E File Offset: 0x0015736E
		public virtual bool? IsUiFadeEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsUiFadeEffect;
				}
				IDisableAllPlayerOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsUiFadeEffect;
			}
			set
			{
				this.GetOrCreatePoco().IsUiFadeEffect = value;
			}
		}

		// Token: 0x04005BB4 RID: 23476
		[Nullable(2)]
		protected new IDisableAllPlayerOperation FbInstance;

		// Token: 0x04005BB5 RID: 23477
		[Nullable(2)]
		protected new IDisableAllPlayerOperation_SetValue PocoInterface;
	}
}
