using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D29 RID: 3369
	[NullableContext(1)]
	[Nullable(0)]
	public class ICharacterConnectorLogicType
	{
		// Token: 0x06004CDF RID: 19679 RVA: 0x000BF486 File Offset: 0x000BD686
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

		// Token: 0x1700184A RID: 6218
		// (get) Token: 0x06004CE0 RID: 19680 RVA: 0x000BF4A5 File Offset: 0x000BD6A5
		public virtual ECharacterConnectorLogicType Type
		{
			get
			{
				return (ECharacterConnectorLogicType)this.Instance.Type;
			}
		}

		// Token: 0x1700184B RID: 6219
		// (get) Token: 0x06004CE1 RID: 19681 RVA: 0x000BF4B2 File Offset: 0x000BD6B2
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

		// Token: 0x04002BFE RID: 11262
		private ICharacterConnectorLogicType Instance;

		// Token: 0x04002BFF RID: 11263
		[Nullable(2)]
		private IConnectorEffectConfig _EffectConfigCache;

		// Token: 0x04002C00 RID: 11264
		private bool _EffectConfigInited;
	}
}
