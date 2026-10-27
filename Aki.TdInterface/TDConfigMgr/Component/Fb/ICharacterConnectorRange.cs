using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D2A RID: 3370
	[NullableContext(2)]
	[Nullable(0)]
	public class ICharacterConnectorRange : ICharacterConnectorLogicType
	{
		// Token: 0x06004CE3 RID: 19683 RVA: 0x000BF4EE File Offset: 0x000BD6EE
		[NullableContext(1)]
		public static ICharacterConnectorRange Create(ICharacterConnectorRange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICharacterConnectorRange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700184C RID: 6220
		// (get) Token: 0x06004CE4 RID: 19684 RVA: 0x000BF50D File Offset: 0x000BD70D
		public override ECharacterConnectorLogicType Type
		{
			get
			{
				return (ECharacterConnectorLogicType)this.Instance.Type;
			}
		}

		// Token: 0x1700184D RID: 6221
		// (get) Token: 0x06004CE5 RID: 19685 RVA: 0x000BF51A File Offset: 0x000BD71A
		[Nullable(1)]
		public override IConnectorEffectConfig EffectConfig
		{
			[NullableContext(1)]
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

		// Token: 0x1700184E RID: 6222
		// (get) Token: 0x06004CE6 RID: 19686 RVA: 0x000BF54E File Offset: 0x000BD74E
		public virtual int EnterRange
		{
			get
			{
				return this.Instance.EnterRange;
			}
		}

		// Token: 0x1700184F RID: 6223
		// (get) Token: 0x06004CE7 RID: 19687 RVA: 0x000BF55B File Offset: 0x000BD75B
		public virtual int LeaveRange
		{
			get
			{
				return this.Instance.LeaveRange;
			}
		}

		// Token: 0x17001850 RID: 6224
		// (get) Token: 0x06004CE8 RID: 19688 RVA: 0x000BF568 File Offset: 0x000BD768
		public virtual List<int> TagConditions
		{
			get
			{
				if (this._TagConditionsInited)
				{
					return this._TagConditionsCache;
				}
				this._TagConditionsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int tagConditionsLength = this.Instance.TagConditionsLength;
				this._TagConditionsCache = new List<int>(tagConditionsLength);
				for (int i = 0; i < tagConditionsLength; i++)
				{
					this._TagConditionsCache.Add(this.Instance.TagConditions(i));
				}
				return this._TagConditionsCache;
			}
		}

		// Token: 0x17001851 RID: 6225
		// (get) Token: 0x06004CE9 RID: 19689 RVA: 0x000BF5E0 File Offset: 0x000BD7E0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IDynamicEntityMatch> MatchConditions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._MatchConditionsInited)
				{
					return this._MatchConditionsCache;
				}
				this._MatchConditionsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int matchConditionsLength = this.Instance.MatchConditionsLength;
				this._MatchConditionsCache = new List<IDynamicEntityMatch>(matchConditionsLength);
				for (int i = 0; i < matchConditionsLength; i++)
				{
					this._MatchConditionsCache.Add(IDynamicEntityMatch.Create(this.Instance.MatchConditions(i)));
				}
				return this._MatchConditionsCache;
			}
		}

		// Token: 0x17001852 RID: 6226
		// (get) Token: 0x06004CEA RID: 19690 RVA: 0x000BF65C File Offset: 0x000BD85C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IDynamicEntityMatch> KeepConditions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._KeepConditionsInited)
				{
					return this._KeepConditionsCache;
				}
				this._KeepConditionsInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int keepConditionsLength = this.Instance.KeepConditionsLength;
				this._KeepConditionsCache = new List<IDynamicEntityMatch>(keepConditionsLength);
				for (int i = 0; i < keepConditionsLength; i++)
				{
					this._KeepConditionsCache.Add(IDynamicEntityMatch.Create(this.Instance.KeepConditions(i)));
				}
				return this._KeepConditionsCache;
			}
		}

		// Token: 0x04002C01 RID: 11265
		private ICharacterConnectorRange Instance;

		// Token: 0x04002C02 RID: 11266
		private IConnectorEffectConfig _EffectConfigCache;

		// Token: 0x04002C03 RID: 11267
		private bool _EffectConfigInited;

		// Token: 0x04002C04 RID: 11268
		private List<int> _TagConditionsCache;

		// Token: 0x04002C05 RID: 11269
		private bool _TagConditionsInited;

		// Token: 0x04002C06 RID: 11270
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IDynamicEntityMatch> _MatchConditionsCache;

		// Token: 0x04002C07 RID: 11271
		private bool _MatchConditionsInited;

		// Token: 0x04002C08 RID: 11272
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IDynamicEntityMatch> _KeepConditionsCache;

		// Token: 0x04002C09 RID: 11273
		private bool _KeepConditionsInited;
	}
}
