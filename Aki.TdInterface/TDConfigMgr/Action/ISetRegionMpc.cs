using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E3E RID: 7742
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetRegionMpc : SetRegionConfig
	{
		// Token: 0x0600A5A9 RID: 42409 RVA: 0x001773B8 File Offset: 0x001755B8
		private ISetRegionMpc_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetRegionMpc 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetRegionMpc_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetRegionMpc_SetValue());
			}
			return result;
		}

		// Token: 0x0600A5AA RID: 42410 RVA: 0x001773F0 File Offset: 0x001755F0
		public static ISetRegionMpc Create([Nullable(2)] ISetRegionMpc instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetRegionMpc
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A5AB RID: 42411 RVA: 0x00177403 File Offset: 0x00175603
		public static ISetRegionMpc CreateFromSetValue([Nullable(2)] ISetRegionMpc_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetRegionMpc
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A5AC RID: 42412 RVA: 0x00177416 File Offset: 0x00175616
		public new ISetRegionMpc_SetValue ToSetValue()
		{
			return new ISetRegionMpc_SetValue
			{
				Type = this.Type,
				RegionMpcId = this.RegionMpcId
			};
		}

		// Token: 0x170032CE RID: 13006
		// (get) Token: 0x0600A5AD RID: 42413 RVA: 0x00177435 File Offset: 0x00175635
		// (set) Token: 0x0600A5AE RID: 42414 RVA: 0x00177460 File Offset: 0x00175660
		public override ERegionConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERegionConfigType.Mpc;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170032CF RID: 13007
		// (get) Token: 0x0600A5AF RID: 42415 RVA: 0x0017746E File Offset: 0x0017566E
		// (set) Token: 0x0600A5B0 RID: 42416 RVA: 0x00177499 File Offset: 0x00175699
		public virtual int RegionMpcId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RegionMpcId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RegionMpcId;
			}
			set
			{
				this.GetOrCreatePoco().RegionMpcId = value;
			}
		}

		// Token: 0x0400630D RID: 25357
		[Nullable(2)]
		protected new ISetRegionMpc FbInstance;

		// Token: 0x0400630E RID: 25358
		[Nullable(2)]
		protected new ISetRegionMpc_SetValue PocoInterface;
	}
}
