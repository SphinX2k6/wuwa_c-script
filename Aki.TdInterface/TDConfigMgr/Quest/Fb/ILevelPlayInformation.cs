using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001413 RID: 5139
	public class ILevelPlayInformation
	{
		// Token: 0x0600749A RID: 29850 RVA: 0x001188A5 File Offset: 0x00116AA5
		public static ILevelPlayInformation Create(ILevelPlayInformation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelPlayInformation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002416 RID: 9238
		// (get) Token: 0x0600749B RID: 29851 RVA: 0x001188C4 File Offset: 0x00116AC4
		public virtual string TidMainTitle
		{
			get
			{
				return this.Instance.TidMainTitle;
			}
		}

		// Token: 0x17002417 RID: 9239
		// (get) Token: 0x0600749C RID: 29852 RVA: 0x001188D4 File Offset: 0x00116AD4
		public virtual List<IInformationSubTitle> SubTitles
		{
			get
			{
				if (this._SubTitlesInited)
				{
					return this._SubTitlesCache;
				}
				this._SubTitlesInited = true;
				int subTitlesLength = this.Instance.SubTitlesLength;
				this._SubTitlesCache = new List<IInformationSubTitle>(subTitlesLength);
				for (int i = 0; i < subTitlesLength; i++)
				{
					this._SubTitlesCache.Add(IInformationSubTitle.Create(this.Instance.SubTitles(i)));
				}
				return this._SubTitlesCache;
			}
		}

		// Token: 0x17002418 RID: 9240
		// (get) Token: 0x0600749D RID: 29853 RVA: 0x0011893D File Offset: 0x00116B3D
		[Nullable(2)]
		public virtual string EdTidMainTitle
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04004289 RID: 17033
		private ILevelPlayInformation Instance;

		// Token: 0x0400428A RID: 17034
		private List<IInformationSubTitle> _SubTitlesCache;

		// Token: 0x0400428B RID: 17035
		private bool _SubTitlesInited;
	}
}
