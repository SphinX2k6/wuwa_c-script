using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E24 RID: 3620
	public class ICharacterConnectorRange : ICharacterConnectorLogicType
	{
		// Token: 0x060051FF RID: 20991 RVA: 0x000CAC32 File Offset: 0x000C8E32
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

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x06005200 RID: 20992 RVA: 0x000CAC51 File Offset: 0x000C8E51
		public override ECharacterConnectorLogicType Type
		{
			get
			{
				return (ECharacterConnectorLogicType)this.Instance.Type;
			}
		}

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x06005201 RID: 20993 RVA: 0x000CAC5E File Offset: 0x000C8E5E
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

		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x06005202 RID: 20994 RVA: 0x000CAC92 File Offset: 0x000C8E92
		public virtual int EnterRange
		{
			get
			{
				return this.Instance.EnterRange;
			}
		}

		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x06005203 RID: 20995 RVA: 0x000CAC9F File Offset: 0x000C8E9F
		public virtual int LeaveRange
		{
			get
			{
				return this.Instance.LeaveRange;
			}
		}

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x06005204 RID: 20996 RVA: 0x000CACAC File Offset: 0x000C8EAC
		[Nullable(2)]
		public virtual List<int> TagConditions
		{
			[NullableContext(2)]
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

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x06005205 RID: 20997 RVA: 0x000CAD24 File Offset: 0x000C8F24
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

		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x06005206 RID: 20998 RVA: 0x000CADA0 File Offset: 0x000C8FA0
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

		// Token: 0x04002EC1 RID: 11969
		private ICharacterConnectorRange Instance;

		// Token: 0x04002EC2 RID: 11970
		[Nullable(2)]
		private IConnectorEffectConfig _EffectConfigCache;

		// Token: 0x04002EC3 RID: 11971
		private bool _EffectConfigInited;

		// Token: 0x04002EC4 RID: 11972
		[Nullable(2)]
		private List<int> _TagConditionsCache;

		// Token: 0x04002EC5 RID: 11973
		private bool _TagConditionsInited;

		// Token: 0x04002EC6 RID: 11974
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IDynamicEntityMatch> _MatchConditionsCache;

		// Token: 0x04002EC7 RID: 11975
		private bool _MatchConditionsInited;

		// Token: 0x04002EC8 RID: 11976
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IDynamicEntityMatch> _KeepConditionsCache;

		// Token: 0x04002EC9 RID: 11977
		private bool _KeepConditionsInited;
	}
}
