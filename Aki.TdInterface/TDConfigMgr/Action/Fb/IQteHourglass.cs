using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B43 RID: 11075
	[NullableContext(2)]
	[Nullable(0)]
	public class IQteHourglass : IUiGame
	{
		// Token: 0x0600F384 RID: 62340 RVA: 0x0023878E File Offset: 0x0023698E
		[NullableContext(0)]
		public static IQteHourglass Create(IQteHourglass? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQteHourglass
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049AC RID: 18860
		// (get) Token: 0x0600F385 RID: 62341 RVA: 0x002387AD File Offset: 0x002369AD
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x170049AD RID: 18861
		// (get) Token: 0x0600F386 RID: 62342 RVA: 0x002387BC File Offset: 0x002369BC
		public virtual List<int> QteIds
		{
			get
			{
				if (this._QteIdsInited)
				{
					return this._QteIdsCache;
				}
				this._QteIdsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int qteIdsLength = this.Instance.QteIdsLength;
				this._QteIdsCache = new List<int>(qteIdsLength);
				for (int i = 0; i < qteIdsLength; i++)
				{
					this._QteIdsCache.Add(this.Instance.QteIds(i));
				}
				return this._QteIdsCache;
			}
		}

		// Token: 0x170049AE RID: 18862
		// (get) Token: 0x0600F387 RID: 62343 RVA: 0x00238834 File Offset: 0x00236A34
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IQteHourglassConfig> QteConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._QteConfigsInited)
				{
					return this._QteConfigsCache;
				}
				this._QteConfigsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int qteConfigsLength = this.Instance.QteConfigsLength;
				this._QteConfigsCache = new List<IQteHourglassConfig>(qteConfigsLength);
				for (int i = 0; i < qteConfigsLength; i++)
				{
					this._QteConfigsCache.Add(IQteHourglassConfig.Create(this.Instance.QteConfigs(i)));
				}
				return this._QteConfigsCache;
			}
		}

		// Token: 0x0400858F RID: 34191
		private IQteHourglass Instance;

		// Token: 0x04008590 RID: 34192
		private List<int> _QteIdsCache;

		// Token: 0x04008591 RID: 34193
		private bool _QteIdsInited;

		// Token: 0x04008592 RID: 34194
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IQteHourglassConfig> _QteConfigsCache;

		// Token: 0x04008593 RID: 34195
		private bool _QteConfigsInited;
	}
}
