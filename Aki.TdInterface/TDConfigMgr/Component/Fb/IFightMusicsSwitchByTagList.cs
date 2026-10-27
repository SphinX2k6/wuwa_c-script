using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A9B RID: 2715
	[NullableContext(1)]
	[Nullable(0)]
	public class IFightMusicsSwitchByTagList : IFightMusicsSwitchType
	{
		// Token: 0x06003E69 RID: 15977 RVA: 0x0009FB16 File Offset: 0x0009DD16
		public static IFightMusicsSwitchByTagList Create(IFightMusicsSwitchByTagList? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFightMusicsSwitchByTagList
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06003E6A RID: 15978 RVA: 0x0009FB35 File Offset: 0x0009DD35
		public override EFightMusicsSwitchType Type
		{
			get
			{
				return (EFightMusicsSwitchType)this.Instance.Type;
			}
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06003E6B RID: 15979 RVA: 0x0009FB44 File Offset: 0x0009DD44
		public virtual List<IFightMusicSwitchByTag> Element
		{
			get
			{
				if (this._ElementInited)
				{
					return this._ElementCache;
				}
				this._ElementInited = true;
				int elementLength = this.Instance.ElementLength;
				this._ElementCache = new List<IFightMusicSwitchByTag>(elementLength);
				for (int i = 0; i < elementLength; i++)
				{
					this._ElementCache.Add(IFightMusicSwitchByTag.Create(this.Instance.Element(i)));
				}
				return this._ElementCache;
			}
		}

		// Token: 0x040022C2 RID: 8898
		private IFightMusicsSwitchByTagList Instance;

		// Token: 0x040022C3 RID: 8899
		private List<IFightMusicSwitchByTag> _ElementCache;

		// Token: 0x040022C4 RID: 8900
		private bool _ElementInited;
	}
}
