using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000727 RID: 1831
	[NullableContext(1)]
	[Nullable(0)]
	public class IStreamingRtEffectRef
	{
		// Token: 0x0600278F RID: 10127 RVA: 0x00069448 File Offset: 0x00067648
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

		// Token: 0x06002790 RID: 10128 RVA: 0x00069480 File Offset: 0x00067680
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

		// Token: 0x06002791 RID: 10129 RVA: 0x00069493 File Offset: 0x00067693
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

		// Token: 0x06002792 RID: 10130 RVA: 0x000694A6 File Offset: 0x000676A6
		public IStreamingRtEffectRef_SetValue ToSetValue()
		{
			return new IStreamingRtEffectRef_SetValue
			{
				ActorRefKey = this.ActorRefKey
			};
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06002793 RID: 10131 RVA: 0x000694B9 File Offset: 0x000676B9
		// (set) Token: 0x06002794 RID: 10132 RVA: 0x000694E4 File Offset: 0x000676E4
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

		// Token: 0x04001AB5 RID: 6837
		[Nullable(2)]
		protected IStreamingRtEffectRef FbInstance;

		// Token: 0x04001AB6 RID: 6838
		[Nullable(2)]
		protected IStreamingRtEffectRef_SetValue PocoInterface;
	}
}
