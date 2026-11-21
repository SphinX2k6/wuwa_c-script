using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200048D RID: 1165
	public class IHoldingTrackTarget
	{
		// Token: 0x06001753 RID: 5971 RVA: 0x000479E8 File Offset: 0x00045BE8
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

		// Token: 0x06001754 RID: 5972 RVA: 0x00047A20 File Offset: 0x00045C20
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

		// Token: 0x06001755 RID: 5973 RVA: 0x00047A33 File Offset: 0x00045C33
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

		// Token: 0x06001756 RID: 5974 RVA: 0x00047A46 File Offset: 0x00045C46
		public IHoldingTrackTarget_SetValue ToSetValue()
		{
			return new IHoldingTrackTarget_SetValue
			{
				EffectPath = this.EffectPath,
				EffectLength = this.EffectLength,
				EntityId = this.EntityId
			};
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001757 RID: 5975 RVA: 0x00047A71 File Offset: 0x00045C71
		// (set) Token: 0x06001758 RID: 5976 RVA: 0x00047A9C File Offset: 0x00045C9C
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

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001759 RID: 5977 RVA: 0x00047AAA File Offset: 0x00045CAA
		// (set) Token: 0x0600175A RID: 5978 RVA: 0x00047AD5 File Offset: 0x00045CD5
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

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x0600175B RID: 5979 RVA: 0x00047AE3 File Offset: 0x00045CE3
		// (set) Token: 0x0600175C RID: 5980 RVA: 0x00047B0E File Offset: 0x00045D0E
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

		// Token: 0x040011DF RID: 4575
		[Nullable(2)]
		protected IHoldingTrackTarget FbInstance;

		// Token: 0x040011E0 RID: 4576
		[Nullable(2)]
		protected IHoldingTrackTarget_SetValue PocoInterface;
	}
}
