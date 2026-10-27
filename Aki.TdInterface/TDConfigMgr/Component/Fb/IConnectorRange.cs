using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D18 RID: 3352
	[NullableContext(1)]
	[Nullable(0)]
	public class IConnectorRange : IConnectorLogicType
	{
		// Token: 0x06004C7C RID: 19580 RVA: 0x000BE87C File Offset: 0x000BCA7C
		public static IConnectorRange Create(IConnectorRange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConnectorRange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x06004C7D RID: 19581 RVA: 0x000BE89B File Offset: 0x000BCA9B
		public override EConnectorLogicType Type
		{
			get
			{
				return (EConnectorLogicType)this.Instance.Type;
			}
		}

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x06004C7E RID: 19582 RVA: 0x000BE8A8 File Offset: 0x000BCAA8
		public override IConnectorEffectConfig EffectConfig
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

		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x06004C7F RID: 19583 RVA: 0x000BE8DC File Offset: 0x000BCADC
		public virtual string ActiveState
		{
			get
			{
				return this.Instance.ActiveState;
			}
		}

		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x06004C80 RID: 19584 RVA: 0x000BE8E9 File Offset: 0x000BCAE9
		public virtual int EnterRange
		{
			get
			{
				return this.Instance.EnterRange;
			}
		}

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x06004C81 RID: 19585 RVA: 0x000BE8F6 File Offset: 0x000BCAF6
		public virtual int LeaveRange
		{
			get
			{
				return this.Instance.LeaveRange;
			}
		}

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x06004C82 RID: 19586 RVA: 0x000BE904 File Offset: 0x000BCB04
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
				if ((this.Instance.NullMask & 1) == 0)
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

		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x06004C83 RID: 19587 RVA: 0x000BE980 File Offset: 0x000BCB80
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
				if ((this.Instance.NullMask & 2) == 0)
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

		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x06004C84 RID: 19588 RVA: 0x000BE9FA File Offset: 0x000BCBFA
		public virtual string ConnectedState
		{
			get
			{
				return this.Instance.ConnectedState;
			}
		}

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x06004C85 RID: 19589 RVA: 0x000BEA07 File Offset: 0x000BCC07
		public virtual string DisconnectedState
		{
			get
			{
				return this.Instance.DisconnectedState;
			}
		}

		// Token: 0x04002BC7 RID: 11207
		private IConnectorRange Instance;

		// Token: 0x04002BC8 RID: 11208
		[Nullable(2)]
		private IConnectorEffectConfig _EffectConfigCache;

		// Token: 0x04002BC9 RID: 11209
		private bool _EffectConfigInited;

		// Token: 0x04002BCA RID: 11210
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IDynamicEntityMatch> _MatchConditionsCache;

		// Token: 0x04002BCB RID: 11211
		private bool _MatchConditionsInited;

		// Token: 0x04002BCC RID: 11212
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IDynamicEntityMatch> _KeepConditionsCache;

		// Token: 0x04002BCD RID: 11213
		private bool _KeepConditionsInited;
	}
}
