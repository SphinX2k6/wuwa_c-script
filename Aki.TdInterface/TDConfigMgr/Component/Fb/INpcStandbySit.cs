using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C81 RID: 3201
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcStandbySit : INpcStandbyShowMode
	{
		// Token: 0x0600490C RID: 18700 RVA: 0x000B87F2 File Offset: 0x000B69F2
		[NullableContext(0)]
		public static INpcStandbySit Create(INpcStandbySit? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcStandbySit
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x0600490D RID: 18701 RVA: 0x000B8811 File Offset: 0x000B6A11
		public override ENpcStandbyShowMode Type
		{
			get
			{
				return (ENpcStandbyShowMode)this.Instance.Type;
			}
		}

		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x0600490E RID: 18702 RVA: 0x000B8820 File Offset: 0x000B6A20
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<INpcLookAtConfig> LookAtConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._LookAtConfigsInited)
				{
					return this._LookAtConfigsCache;
				}
				this._LookAtConfigsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int lookAtConfigsLength = this.Instance.LookAtConfigsLength;
				this._LookAtConfigsCache = new List<INpcLookAtConfig>(lookAtConfigsLength);
				for (int i = 0; i < lookAtConfigsLength; i++)
				{
					this._LookAtConfigsCache.Add(INpcLookAtConfig.Create(this.Instance.LookAtConfigs(i)));
				}
				return this._LookAtConfigsCache;
			}
		}

		// Token: 0x17001407 RID: 5127
		// (get) Token: 0x0600490F RID: 18703 RVA: 0x000B889A File Offset: 0x000B6A9A
		public virtual string Montage
		{
			get
			{
				return this.Instance.Montage;
			}
		}

		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x06004910 RID: 18704 RVA: 0x000B88A7 File Offset: 0x000B6AA7
		public virtual IMontageId RegisteredMontageId
		{
			get
			{
				if (this._RegisteredMontageIdInited)
				{
					return this._RegisteredMontageIdCache;
				}
				this._RegisteredMontageIdInited = true;
				this._RegisteredMontageIdCache = IMontageId.Create(this.Instance.RegisteredMontageId);
				return this._RegisteredMontageIdCache;
			}
		}

		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x06004911 RID: 18705 RVA: 0x000B88DC File Offset: 0x000B6ADC
		public virtual int? FaceExpressionId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.FaceExpressionId);
			}
		}

		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x06004912 RID: 18706 RVA: 0x000B8912 File Offset: 0x000B6B12
		public virtual int PosEntityId
		{
			get
			{
				return this.Instance.PosEntityId;
			}
		}

		// Token: 0x04002922 RID: 10530
		private INpcStandbySit Instance;

		// Token: 0x04002923 RID: 10531
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<INpcLookAtConfig> _LookAtConfigsCache;

		// Token: 0x04002924 RID: 10532
		private bool _LookAtConfigsInited;

		// Token: 0x04002925 RID: 10533
		private IMontageId _RegisteredMontageIdCache;

		// Token: 0x04002926 RID: 10534
		private bool _RegisteredMontageIdInited;
	}
}
