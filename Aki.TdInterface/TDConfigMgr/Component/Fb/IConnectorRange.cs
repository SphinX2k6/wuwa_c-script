using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E12 RID: 3602
	public class IConnectorRange : IConnectorLogicType
	{
		// Token: 0x06005196 RID: 20886 RVA: 0x000C9F50 File Offset: 0x000C8150
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

		// Token: 0x1700196D RID: 6509
		// (get) Token: 0x06005197 RID: 20887 RVA: 0x000C9F6F File Offset: 0x000C816F
		public override EConnectorLogicType Type
		{
			get
			{
				return (EConnectorLogicType)this.Instance.Type;
			}
		}

		// Token: 0x1700196E RID: 6510
		// (get) Token: 0x06005198 RID: 20888 RVA: 0x000C9F7C File Offset: 0x000C817C
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

		// Token: 0x1700196F RID: 6511
		// (get) Token: 0x06005199 RID: 20889 RVA: 0x000C9FB0 File Offset: 0x000C81B0
		public virtual string ActiveState
		{
			get
			{
				return this.Instance.ActiveState;
			}
		}

		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x0600519A RID: 20890 RVA: 0x000C9FBD File Offset: 0x000C81BD
		public virtual int EnterRange
		{
			get
			{
				return this.Instance.EnterRange;
			}
		}

		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x0600519B RID: 20891 RVA: 0x000C9FCA File Offset: 0x000C81CA
		public virtual int LeaveRange
		{
			get
			{
				return this.Instance.LeaveRange;
			}
		}

		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x0600519C RID: 20892 RVA: 0x000C9FD8 File Offset: 0x000C81D8
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IDynamicEntityMatch> MatchConditions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x0600519D RID: 20893 RVA: 0x000CA054 File Offset: 0x000C8254
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IDynamicEntityMatch> KeepConditions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x17001974 RID: 6516
		// (get) Token: 0x0600519E RID: 20894 RVA: 0x000CA0CE File Offset: 0x000C82CE
		public virtual string ConnectedState
		{
			get
			{
				return this.Instance.ConnectedState;
			}
		}

		// Token: 0x17001975 RID: 6517
		// (get) Token: 0x0600519F RID: 20895 RVA: 0x000CA0DB File Offset: 0x000C82DB
		public virtual string DisconnectedState
		{
			get
			{
				return this.Instance.DisconnectedState;
			}
		}

		// Token: 0x04002E87 RID: 11911
		private IConnectorRange Instance;

		// Token: 0x04002E88 RID: 11912
		[Nullable(2)]
		private IConnectorEffectConfig _EffectConfigCache;

		// Token: 0x04002E89 RID: 11913
		private bool _EffectConfigInited;

		// Token: 0x04002E8A RID: 11914
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IDynamicEntityMatch> _MatchConditionsCache;

		// Token: 0x04002E8B RID: 11915
		private bool _MatchConditionsInited;

		// Token: 0x04002E8C RID: 11916
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IDynamicEntityMatch> _KeepConditionsCache;

		// Token: 0x04002E8D RID: 11917
		private bool _KeepConditionsInited;
	}
}
