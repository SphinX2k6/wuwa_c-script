using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D17 RID: 3351
	[NullableContext(1)]
	[Nullable(0)]
	public class IConnectorLogicType
	{
		// Token: 0x06004C78 RID: 19576 RVA: 0x000BE814 File Offset: 0x000BCA14
		public static IConnectorLogicType Create(IConnectorLogicType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConnectorLogicType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x06004C79 RID: 19577 RVA: 0x000BE833 File Offset: 0x000BCA33
		public virtual EConnectorLogicType Type
		{
			get
			{
				return (EConnectorLogicType)this.Instance.Type;
			}
		}

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x06004C7A RID: 19578 RVA: 0x000BE840 File Offset: 0x000BCA40
		public virtual IConnectorEffectConfig EffectConfig
		{
			get
			{
				if (this._EffectConfigInited)
				{
					return this._EffectConfigCache;
				}
				this._EffectConfigInited = true;
				this._EffectConfigCache = IConnectorEffectConfig.Create(this.Instance.EffectConfig);
				return this._EffectConfigCache;
			}
		}

		// Token: 0x04002BC4 RID: 11204
		private IConnectorLogicType Instance;

		// Token: 0x04002BC5 RID: 11205
		[Nullable(2)]
		private IConnectorEffectConfig _EffectConfigCache;

		// Token: 0x04002BC6 RID: 11206
		private bool _EffectConfigInited;
	}
}
