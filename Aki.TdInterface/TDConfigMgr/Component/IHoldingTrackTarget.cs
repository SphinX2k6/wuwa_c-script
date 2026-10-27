using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000434 RID: 1076
	[NullableContext(1)]
	[Nullable(0)]
	public class IHoldingTrackTarget
	{
		// Token: 0x060015B9 RID: 5561 RVA: 0x00043CA0 File Offset: 0x00041EA0
		private IHoldingTrackTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHoldingTrackTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHoldingTrackTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHoldingTrackTarget_SetValue());
			}
			return result;
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00043CD8 File Offset: 0x00041ED8
		public static IHoldingTrackTarget Create([Nullable(2)] IHoldingTrackTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHoldingTrackTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x00043CEB File Offset: 0x00041EEB
		public static IHoldingTrackTarget CreateFromSetValue([Nullable(2)] IHoldingTrackTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHoldingTrackTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00043CFE File Offset: 0x00041EFE
		public IHoldingTrackTarget_SetValue ToSetValue()
		{
			return new IHoldingTrackTarget_SetValue
			{
				EffectPath = this.EffectPath,
				EffectLength = this.EffectLength,
				EntityId = this.EntityId
			};
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060015BD RID: 5565 RVA: 0x00043D29 File Offset: 0x00041F29
		// (set) Token: 0x060015BE RID: 5566 RVA: 0x00043D54 File Offset: 0x00041F54
		public virtual string EffectPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EffectPath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EffectPath;
			}
			set
			{
				this.GetOrCreatePoco().EffectPath = value;
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060015BF RID: 5567 RVA: 0x00043D62 File Offset: 0x00041F62
		// (set) Token: 0x060015C0 RID: 5568 RVA: 0x00043D8D File Offset: 0x00041F8D
		public virtual int EffectLength
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EffectLength;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EffectLength;
			}
			set
			{
				this.GetOrCreatePoco().EffectLength = value;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060015C1 RID: 5569 RVA: 0x00043D9B File Offset: 0x00041F9B
		// (set) Token: 0x060015C2 RID: 5570 RVA: 0x00043DC6 File Offset: 0x00041FC6
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x040010BD RID: 4285
		[Nullable(2)]
		protected IHoldingTrackTarget FbInstance;

		// Token: 0x040010BE RID: 4286
		[Nullable(2)]
		protected IHoldingTrackTarget_SetValue PocoInterface;
	}
}
