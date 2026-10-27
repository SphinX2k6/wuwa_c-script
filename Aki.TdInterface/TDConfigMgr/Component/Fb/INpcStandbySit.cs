using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BB3 RID: 2995
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcStandbySit : INpcStandbyShowMode
	{
		// Token: 0x060044B3 RID: 17587 RVA: 0x000AE72E File Offset: 0x000AC92E
		[NullableContext(1)]
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

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x060044B4 RID: 17588 RVA: 0x000AE74D File Offset: 0x000AC94D
		public override ENpcStandbyShowMode Type
		{
			get
			{
				return (ENpcStandbyShowMode)this.Instance.Type;
			}
		}

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x060044B5 RID: 17589 RVA: 0x000AE75C File Offset: 0x000AC95C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<INpcLookAtConfig> LookAtConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x060044B6 RID: 17590 RVA: 0x000AE7D6 File Offset: 0x000AC9D6
		public virtual string Montage
		{
			get
			{
				return this.Instance.Montage;
			}
		}

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x060044B7 RID: 17591 RVA: 0x000AE7E3 File Offset: 0x000AC9E3
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

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x060044B8 RID: 17592 RVA: 0x000AE818 File Offset: 0x000ACA18
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

		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x060044B9 RID: 17593 RVA: 0x000AE84E File Offset: 0x000ACA4E
		public virtual int PosEntityId
		{
			get
			{
				return this.Instance.PosEntityId;
			}
		}

		// Token: 0x040026DA RID: 9946
		private INpcStandbySit Instance;

		// Token: 0x040026DB RID: 9947
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<INpcLookAtConfig> _LookAtConfigsCache;

		// Token: 0x040026DC RID: 9948
		private bool _LookAtConfigsInited;

		// Token: 0x040026DD RID: 9949
		private IMontageId _RegisteredMontageIdCache;

		// Token: 0x040026DE RID: 9950
		private bool _RegisteredMontageIdInited;
	}
}
