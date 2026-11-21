using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001414 RID: 5140
	public class ILevelPlayInformationView : IInformationViewType
	{
		// Token: 0x0600749F RID: 29855 RVA: 0x00118948 File Offset: 0x00116B48
		public static ILevelPlayInformationView Create(ILevelPlayInformationView? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelPlayInformationView
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002419 RID: 9241
		// (get) Token: 0x060074A0 RID: 29856 RVA: 0x00118967 File Offset: 0x00116B67
		public override EInformationViewType Type
		{
			get
			{
				return (EInformationViewType)this.Instance.Type;
			}
		}

		// Token: 0x1700241A RID: 9242
		// (get) Token: 0x060074A1 RID: 29857 RVA: 0x00118974 File Offset: 0x00116B74
		public virtual List<ILevelPlayInformation> InformationConfig
		{
			get
			{
				if (this._InformationConfigInited)
				{
					return this._InformationConfigCache;
				}
				this._InformationConfigInited = true;
				int informationConfigLength = this.Instance.InformationConfigLength;
				this._InformationConfigCache = new List<ILevelPlayInformation>(informationConfigLength);
				for (int i = 0; i < informationConfigLength; i++)
				{
					this._InformationConfigCache.Add(ILevelPlayInformation.Create(this.Instance.InformationConfig(i)));
				}
				return this._InformationConfigCache;
			}
		}

		// Token: 0x0400428C RID: 17036
		private ILevelPlayInformationView Instance;

		// Token: 0x0400428D RID: 17037
		private List<ILevelPlayInformation> _InformationConfigCache;

		// Token: 0x0400428E RID: 17038
		private bool _InformationConfigInited;
	}
}
