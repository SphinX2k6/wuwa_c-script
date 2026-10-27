using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200088B RID: 2187
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemAiComponent : IComponentBase
	{
		// Token: 0x060030C1 RID: 12481 RVA: 0x0007D758 File Offset: 0x0007B958
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

		// Token: 0x060030C2 RID: 12482 RVA: 0x0007D790 File Offset: 0x0007B990
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

		// Token: 0x060030C3 RID: 12483 RVA: 0x0007D7A3 File Offset: 0x0007B9A3
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

		// Token: 0x060030C4 RID: 12484 RVA: 0x0007D7B6 File Offset: 0x0007B9B6
		public new SceneItemAiComponent_SetValue ToSetValue()
		{
			return new SceneItemAiComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				AiConfig = this.AiConfig
			};
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x060030C5 RID: 12485 RVA: 0x0007D7E4 File Offset: 0x0007B9E4
		// (set) Token: 0x060030C6 RID: 12486 RVA: 0x0007D81E File Offset: 0x0007BA1E
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

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x060030C7 RID: 12487 RVA: 0x0007D82C File Offset: 0x0007BA2C
		// (set) Token: 0x060030C8 RID: 12488 RVA: 0x0007D856 File Offset: 0x0007BA56
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

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x060030C9 RID: 12489 RVA: 0x0007D864 File Offset: 0x0007BA64
		// (set) Token: 0x060030CA RID: 12490 RVA: 0x0007D8C5 File Offset: 0x0007BAC5
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

		// Token: 0x04002015 RID: 8213
		[Nullable(2)]
		protected new SceneItemAiComponent FbInstance;

		// Token: 0x04002016 RID: 8214
		[Nullable(2)]
		protected new SceneItemAiComponent_SetValue PocoInterface;

		// Token: 0x04002017 RID: 8215
		private ISceneItemPatrol _AiConfigCache;

		// Token: 0x04002018 RID: 8216
		private bool _AiConfigInited;
	}
}
