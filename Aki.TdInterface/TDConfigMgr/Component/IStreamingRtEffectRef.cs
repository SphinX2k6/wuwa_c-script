using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007C8 RID: 1992
	public class IStreamingRtEffectRef
	{
		// Token: 0x06002AB3 RID: 10931 RVA: 0x000705F0 File Offset: 0x0006E7F0
		private IStreamingRtEffectRef_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStreamingRtEffectRef 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStreamingRtEffectRef_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStreamingRtEffectRef_SetValue());
			}
			return result;
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x00070628 File Offset: 0x0006E828
		public static IStreamingRtEffectRef Create([Nullable(2)] IStreamingRtEffectRef instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStreamingRtEffectRef
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x0007063B File Offset: 0x0006E83B
		public static IStreamingRtEffectRef CreateFromSetValue([Nullable(2)] IStreamingRtEffectRef_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStreamingRtEffectRef
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x0007064E File Offset: 0x0006E84E
		public IStreamingRtEffectRef_SetValue ToSetValue()
		{
			return new IStreamingRtEffectRef_SetValue
			{
				ActorRefKey = this.ActorRefKey
			};
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06002AB7 RID: 10935 RVA: 0x00070661 File Offset: 0x0006E861
		// (set) Token: 0x06002AB8 RID: 10936 RVA: 0x0007068C File Offset: 0x0006E88C
		public virtual string ActorRefKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActorRefKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ActorRefKey;
			}
			set
			{
				this.GetOrCreatePoco().ActorRefKey = value;
			}
		}

		// Token: 0x04001CBA RID: 7354
		[Nullable(2)]
		protected IStreamingRtEffectRef FbInstance;

		// Token: 0x04001CBB RID: 7355
		[Nullable(2)]
		protected IStreamingRtEffectRef_SetValue PocoInterface;
	}
}
