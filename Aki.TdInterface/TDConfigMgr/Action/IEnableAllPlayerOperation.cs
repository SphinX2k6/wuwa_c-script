using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019E0 RID: 6624
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IEnableAllPlayerOperationConverter))]
	public class IEnableAllPlayerOperation : SetPlayerOperationRestriction
	{
		// Token: 0x06008DDD RID: 36317 RVA: 0x0014C1E8 File Offset: 0x0014A3E8
		private IEnableAllPlayerOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnableAllPlayerOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnableAllPlayerOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnableAllPlayerOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06008DDE RID: 36318 RVA: 0x0014C220 File Offset: 0x0014A420
		public static IEnableAllPlayerOperation Create([Nullable(2)] IEnableAllPlayerOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableAllPlayerOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008DDF RID: 36319 RVA: 0x0014C233 File Offset: 0x0014A433
		public static IEnableAllPlayerOperation CreateFromSetValue([Nullable(2)] IEnableAllPlayerOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnableAllPlayerOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008DE0 RID: 36320 RVA: 0x0014C246 File Offset: 0x0014A446
		public new IEnableAllPlayerOperation_SetValue ToSetValue()
		{
			return new IEnableAllPlayerOperation_SetValue
			{
				Type = this.Type,
				IsUiFadeEffect = this.IsUiFadeEffect
			};
		}

		// Token: 0x17002D73 RID: 11635
		// (get) Token: 0x06008DE1 RID: 36321 RVA: 0x0014C265 File Offset: 0x0014A465
		// (set) Token: 0x06008DE2 RID: 36322 RVA: 0x0014C290 File Offset: 0x0014A490
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

		// Token: 0x17002D74 RID: 11636
		// (get) Token: 0x06008DE3 RID: 36323 RVA: 0x0014C2A0 File Offset: 0x0014A4A0
		// (set) Token: 0x06008DE4 RID: 36324 RVA: 0x0014C2DA File Offset: 0x0014A4DA
		public virtual bool? IsUiFadeEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsUiFadeEffect;
				}
				IEnableAllPlayerOperation_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400580E RID: 22542
		[Nullable(2)]
		protected new IEnableAllPlayerOperation FbInstance;

		// Token: 0x0400580F RID: 22543
		[Nullable(2)]
		protected new IEnableAllPlayerOperation_SetValue PocoInterface;
	}
}
