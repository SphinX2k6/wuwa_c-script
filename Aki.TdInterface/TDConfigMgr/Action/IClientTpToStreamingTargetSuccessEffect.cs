using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018D0 RID: 6352
	[NullableContext(2)]
	[Nullable(0)]
	public class IClientTpToStreamingTargetSuccessEffect
	{
		// Token: 0x0600883F RID: 34879 RVA: 0x00142700 File Offset: 0x00140900
		[NullableContext(1)]
		private IClientTpToStreamingTargetSuccessEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientTpToStreamingTargetSuccessEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientTpToStreamingTargetSuccessEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientTpToStreamingTargetSuccessEffect_SetValue());
			}
			return result;
		}

		// Token: 0x06008840 RID: 34880 RVA: 0x00142738 File Offset: 0x00140938
		[NullableContext(1)]
		public static IClientTpToStreamingTargetSuccessEffect Create([Nullable(2)] IClientTpToStreamingTargetSuccessEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientTpToStreamingTargetSuccessEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008841 RID: 34881 RVA: 0x0014274B File Offset: 0x0014094B
		[NullableContext(1)]
		public static IClientTpToStreamingTargetSuccessEffect CreateFromSetValue([Nullable(2)] IClientTpToStreamingTargetSuccessEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientTpToStreamingTargetSuccessEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008842 RID: 34882 RVA: 0x0014275E File Offset: 0x0014095E
		[NullableContext(1)]
		public IClientTpToStreamingTargetSuccessEffect_SetValue ToSetValue()
		{
			return new IClientTpToStreamingTargetSuccessEffect_SetValue
			{
				SceneEffectDaPath = this.SceneEffectDaPath
			};
		}

		// Token: 0x17002C3C RID: 11324
		// (get) Token: 0x06008843 RID: 34883 RVA: 0x00142771 File Offset: 0x00140971
		// (set) Token: 0x06008844 RID: 34884 RVA: 0x00142798 File Offset: 0x00140998
		public virtual string SceneEffectDaPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SceneEffectDaPath;
				}
				IClientTpToStreamingTargetSuccessEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SceneEffectDaPath;
			}
			set
			{
				this.GetOrCreatePoco().SceneEffectDaPath = value;
			}
		}

		// Token: 0x0400559B RID: 21915
		protected IClientTpToStreamingTargetSuccessEffect FbInstance;

		// Token: 0x0400559C RID: 21916
		protected IClientTpToStreamingTargetSuccessEffect_SetValue PocoInterface;
	}
}
