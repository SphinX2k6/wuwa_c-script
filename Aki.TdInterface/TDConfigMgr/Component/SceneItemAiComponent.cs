using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200092E RID: 2350
	public class SceneItemAiComponent : IComponentBase
	{
		// Token: 0x060033FD RID: 13309 RVA: 0x00084C40 File Offset: 0x00082E40
		private SceneItemAiComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SceneItemAiComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SceneItemAiComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SceneItemAiComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x00084C78 File Offset: 0x00082E78
		public static SceneItemAiComponent Create([Nullable(2)] SceneItemAiComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SceneItemAiComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x00084C8B File Offset: 0x00082E8B
		public static SceneItemAiComponent CreateFromSetValue([Nullable(2)] SceneItemAiComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SceneItemAiComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x00084C9E File Offset: 0x00082E9E
		public new SceneItemAiComponent_SetValue ToSetValue()
		{
			return new SceneItemAiComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				AiConfig = this.AiConfig
			};
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x06003401 RID: 13313 RVA: 0x00084CCC File Offset: 0x00082ECC
		// (set) Token: 0x06003402 RID: 13314 RVA: 0x00084D06 File Offset: 0x00082F06
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				SceneItemAiComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x06003403 RID: 13315 RVA: 0x00084D14 File Offset: 0x00082F14
		// (set) Token: 0x06003404 RID: 13316 RVA: 0x00084D3E File Offset: 0x00082F3E
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x06003405 RID: 13317 RVA: 0x00084D4C File Offset: 0x00082F4C
		// (set) Token: 0x06003406 RID: 13318 RVA: 0x00084DAD File Offset: 0x00082FAD
		public virtual ISceneItemPatrol AiConfig
		{
			get
			{
				if (this._AiConfigInited)
				{
					return this._AiConfigCache;
				}
				this._AiConfigInited = true;
				if (this.FbInstance != null)
				{
					this._AiConfigCache = ISceneItemPatrol.Create(this.FbInstance.AiConfig);
				}
				else
				{
					SceneItemAiComponent_SetValue pocoInterface = this.PocoInterface;
					this._AiConfigCache = ((pocoInterface != null) ? pocoInterface.AiConfig : null);
				}
				return this._AiConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().AiConfig = value;
				this._AiConfigInited = false;
			}
		}

		// Token: 0x04002227 RID: 8743
		[Nullable(2)]
		protected new SceneItemAiComponent FbInstance;

		// Token: 0x04002228 RID: 8744
		[Nullable(2)]
		protected new SceneItemAiComponent_SetValue PocoInterface;

		// Token: 0x04002229 RID: 8745
		private ISceneItemPatrol _AiConfigCache;

		// Token: 0x0400222A RID: 8746
		private bool _AiConfigInited;
	}
}
