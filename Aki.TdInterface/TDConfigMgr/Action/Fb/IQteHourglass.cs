using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200286D RID: 10349
	[NullableContext(2)]
	[Nullable(0)]
	public class IQteHourglass : IUiGame
	{
		// Token: 0x0600E554 RID: 58708 RVA: 0x0021B874 File Offset: 0x00219A74
		[NullableContext(1)]
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

		// Token: 0x1700463C RID: 17980
		// (get) Token: 0x0600E555 RID: 58709 RVA: 0x0021B893 File Offset: 0x00219A93
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x1700463D RID: 17981
		// (get) Token: 0x0600E556 RID: 58710 RVA: 0x0021B8A0 File Offset: 0x00219AA0
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

		// Token: 0x1700463E RID: 17982
		// (get) Token: 0x0600E557 RID: 58711 RVA: 0x0021B918 File Offset: 0x00219B18
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IQteHourglassConfig> QteConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x04007ECF RID: 32463
		private IQteHourglass Instance;

		// Token: 0x04007ED0 RID: 32464
		private List<int> _QteIdsCache;

		// Token: 0x04007ED1 RID: 32465
		private bool _QteIdsInited;

		// Token: 0x04007ED2 RID: 32466
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IQteHourglassConfig> _QteConfigsCache;

		// Token: 0x04007ED3 RID: 32467
		private bool _QteConfigsInited;
	}
}
