using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A61 RID: 6753
	public class IClientTpToStreamingTargetSuccessEffect
	{
		// Token: 0x06008F87 RID: 36743 RVA: 0x00152278 File Offset: 0x00150478
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

		// Token: 0x06008F88 RID: 36744 RVA: 0x001522B0 File Offset: 0x001504B0
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

		// Token: 0x06008F89 RID: 36745 RVA: 0x001522C3 File Offset: 0x001504C3
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

		// Token: 0x06008F8A RID: 36746 RVA: 0x001522D6 File Offset: 0x001504D6
		public IClientTpToStreamingTargetSuccessEffect_SetValue ToSetValue()
		{
			return new IClientTpToStreamingTargetSuccessEffect_SetValue
			{
				SceneEffectDaPath = this.SceneEffectDaPath
			};
		}

		// Token: 0x17002E3E RID: 11838
		// (get) Token: 0x06008F8B RID: 36747 RVA: 0x001522E9 File Offset: 0x001504E9
		// (set) Token: 0x06008F8C RID: 36748 RVA: 0x00152310 File Offset: 0x00150510
		[Nullable(2)]
		public virtual string SceneEffectDaPath
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().SceneEffectDaPath = value;
			}
		}

		// Token: 0x040059F5 RID: 23029
		[Nullable(2)]
		protected IClientTpToStreamingTargetSuccessEffect FbInstance;

		// Token: 0x040059F6 RID: 23030
		[Nullable(2)]
		protected IClientTpToStreamingTargetSuccessEffect_SetValue PocoInterface;
	}
}
