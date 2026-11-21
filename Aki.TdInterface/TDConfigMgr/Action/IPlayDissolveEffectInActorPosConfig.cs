using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F0B RID: 7947
	public class IPlayDissolveEffectInActorPosConfig
	{
		// Token: 0x0600A92F RID: 43311 RVA: 0x00180338 File Offset: 0x0017E538
		private IPlayDissolveEffectInActorPosConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayDissolveEffectInActorPosConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayDissolveEffectInActorPosConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayDissolveEffectInActorPosConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A930 RID: 43312 RVA: 0x00180370 File Offset: 0x0017E570
		public static IPlayDissolveEffectInActorPosConfig Create([Nullable(2)] IPlayDissolveEffectInActorPosConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayDissolveEffectInActorPosConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A931 RID: 43313 RVA: 0x00180383 File Offset: 0x0017E583
		public static IPlayDissolveEffectInActorPosConfig CreateFromSetValue([Nullable(2)] IPlayDissolveEffectInActorPosConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayDissolveEffectInActorPosConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A932 RID: 43314 RVA: 0x00180396 File Offset: 0x0017E596
		public IPlayDissolveEffectInActorPosConfig_SetValue ToSetValue()
		{
			return new IPlayDissolveEffectInActorPosConfig_SetValue
			{
				AspectRatio = this.AspectRatio
			};
		}

		// Token: 0x17003415 RID: 13333
		// (get) Token: 0x0600A933 RID: 43315 RVA: 0x001803A9 File Offset: 0x0017E5A9
		// (set) Token: 0x0600A934 RID: 43316 RVA: 0x001803D4 File Offset: 0x0017E5D4
		public virtual EAspectRatio AspectRatio
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AspectRatio;
				}
				if (this.PocoInterface == null)
				{
					return EAspectRatio.Ratio16x9;
				}
				return this.PocoInterface.AspectRatio;
			}
			set
			{
				this.GetOrCreatePoco().AspectRatio = value;
			}
		}

		// Token: 0x040065A4 RID: 26020
		[Nullable(2)]
		protected IPlayDissolveEffectInActorPosConfig FbInstance;

		// Token: 0x040065A5 RID: 26021
		[Nullable(2)]
		protected IPlayDissolveEffectInActorPosConfig_SetValue PocoInterface;
	}
}
