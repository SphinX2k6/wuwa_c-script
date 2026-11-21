using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E23 RID: 3619
	public class ICharacterConnectorLogicType
	{
		// Token: 0x060051FB RID: 20987 RVA: 0x000CABCA File Offset: 0x000C8DCA
		public static ICharacterConnectorLogicType Create(ICharacterConnectorLogicType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICharacterConnectorLogicType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x060051FC RID: 20988 RVA: 0x000CABE9 File Offset: 0x000C8DE9
		public virtual ECharacterConnectorLogicType Type
		{
			get
			{
				return (ECharacterConnectorLogicType)this.Instance.Type;
			}
		}

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x060051FD RID: 20989 RVA: 0x000CABF6 File Offset: 0x000C8DF6
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

		// Token: 0x04002EBE RID: 11966
		private ICharacterConnectorLogicType Instance;

		// Token: 0x04002EBF RID: 11967
		[Nullable(2)]
		private IConnectorEffectConfig _EffectConfigCache;

		// Token: 0x04002EC0 RID: 11968
		private bool _EffectConfigInited;
	}
}
