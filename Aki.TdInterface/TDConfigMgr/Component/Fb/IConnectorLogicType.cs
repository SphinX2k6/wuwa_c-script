using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E11 RID: 3601
	public class IConnectorLogicType
	{
		// Token: 0x06005192 RID: 20882 RVA: 0x000C9EE8 File Offset: 0x000C80E8
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

		// Token: 0x1700196B RID: 6507
		// (get) Token: 0x06005193 RID: 20883 RVA: 0x000C9F07 File Offset: 0x000C8107
		public virtual EConnectorLogicType Type
		{
			get
			{
				return (EConnectorLogicType)this.Instance.Type;
			}
		}

		// Token: 0x1700196C RID: 6508
		// (get) Token: 0x06005194 RID: 20884 RVA: 0x000C9F14 File Offset: 0x000C8114
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

		// Token: 0x04002E84 RID: 11908
		private IConnectorLogicType Instance;

		// Token: 0x04002E85 RID: 11909
		[Nullable(2)]
		private IConnectorEffectConfig _EffectConfigCache;

		// Token: 0x04002E86 RID: 11910
		private bool _EffectConfigInited;
	}
}
