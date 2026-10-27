using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012CE RID: 4814
	[NullableContext(1)]
	[Nullable(0)]
	public class ILevelPlayInformationView : IInformationViewType
	{
		// Token: 0x06006E21 RID: 28193 RVA: 0x0010A6B8 File Offset: 0x001088B8
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

		// Token: 0x17002258 RID: 8792
		// (get) Token: 0x06006E22 RID: 28194 RVA: 0x0010A6D7 File Offset: 0x001088D7
		public override EInformationViewType Type
		{
			get
			{
				return (EInformationViewType)this.Instance.Type;
			}
		}

		// Token: 0x17002259 RID: 8793
		// (get) Token: 0x06006E23 RID: 28195 RVA: 0x0010A6E4 File Offset: 0x001088E4
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

		// Token: 0x04003F1E RID: 16158
		private ILevelPlayInformationView Instance;

		// Token: 0x04003F1F RID: 16159
		private List<ILevelPlayInformation> _InformationConfigCache;

		// Token: 0x04003F20 RID: 16160
		private bool _InformationConfigInited;
	}
}
