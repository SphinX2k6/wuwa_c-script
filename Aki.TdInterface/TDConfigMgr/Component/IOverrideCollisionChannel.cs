using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000621 RID: 1569
	public class IOverrideCollisionChannel
	{
		// Token: 0x060020EC RID: 8428 RVA: 0x0005C094 File Offset: 0x0005A294
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

		// Token: 0x060020ED RID: 8429 RVA: 0x0005C0CC File Offset: 0x0005A2CC
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

		// Token: 0x060020EE RID: 8430 RVA: 0x0005C0DF File Offset: 0x0005A2DF
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

		// Token: 0x060020EF RID: 8431 RVA: 0x0005C0F2 File Offset: 0x0005A2F2
		public IOverrideCollisionChannel_SetValue ToSetValue()
		{
			return new IOverrideCollisionChannel_SetValue
			{
				CollisionChannelPreset = this.CollisionChannelPreset,
				BlurResponseRadius = this.BlurResponseRadius
			};
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x060020F0 RID: 8432 RVA: 0x0005C114 File Offset: 0x0005A314
		// (set) Token: 0x060020F1 RID: 8433 RVA: 0x0005C14E File Offset: 0x0005A34E
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

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x060020F2 RID: 8434 RVA: 0x0005C15C File Offset: 0x0005A35C
		// (set) Token: 0x060020F3 RID: 8435 RVA: 0x0005C196 File Offset: 0x0005A396
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

		// Token: 0x0400175C RID: 5980
		[Nullable(2)]
		protected IOverrideCollisionChannel FbInstance;

		// Token: 0x0400175D RID: 5981
		[Nullable(2)]
		protected IOverrideCollisionChannel_SetValue PocoInterface;
	}
}
