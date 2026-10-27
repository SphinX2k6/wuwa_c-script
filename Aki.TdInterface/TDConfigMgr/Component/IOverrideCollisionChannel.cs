using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005B6 RID: 1462
	[NullableContext(1)]
	[Nullable(0)]
	public class IOverrideCollisionChannel
	{
		// Token: 0x06001EDC RID: 7900 RVA: 0x00057068 File Offset: 0x00055268
		private IOverrideCollisionChannel_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOverrideCollisionChannel 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOverrideCollisionChannel_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOverrideCollisionChannel_SetValue());
			}
			return result;
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x000570A0 File Offset: 0x000552A0
		public static IOverrideCollisionChannel Create([Nullable(2)] IOverrideCollisionChannel instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOverrideCollisionChannel
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x000570B3 File Offset: 0x000552B3
		public static IOverrideCollisionChannel CreateFromSetValue([Nullable(2)] IOverrideCollisionChannel_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOverrideCollisionChannel
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x000570C6 File Offset: 0x000552C6
		public IOverrideCollisionChannel_SetValue ToSetValue()
		{
			return new IOverrideCollisionChannel_SetValue
			{
				CollisionChannelPreset = this.CollisionChannelPreset,
				BlurResponseRadius = this.BlurResponseRadius
			};
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001EE0 RID: 7904 RVA: 0x000570E8 File Offset: 0x000552E8
		// (set) Token: 0x06001EE1 RID: 7905 RVA: 0x00057122 File Offset: 0x00055322
		public virtual ECollisionChannelPreset? CollisionChannelPreset
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CollisionChannelPreset;
				}
				IOverrideCollisionChannel_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CollisionChannelPreset;
			}
			set
			{
				this.GetOrCreatePoco().CollisionChannelPreset = value;
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001EE2 RID: 7906 RVA: 0x00057130 File Offset: 0x00055330
		// (set) Token: 0x06001EE3 RID: 7907 RVA: 0x0005716A File Offset: 0x0005536A
		public virtual float? BlurResponseRadius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BlurResponseRadius;
				}
				IOverrideCollisionChannel_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BlurResponseRadius;
			}
			set
			{
				this.GetOrCreatePoco().BlurResponseRadius = value;
			}
		}

		// Token: 0x040015E8 RID: 5608
		[Nullable(2)]
		protected IOverrideCollisionChannel FbInstance;

		// Token: 0x040015E9 RID: 5609
		[Nullable(2)]
		protected IOverrideCollisionChannel_SetValue PocoInterface;
	}
}
