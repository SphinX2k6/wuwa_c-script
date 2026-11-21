using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B65 RID: 2917
	public class IFightMusicsSwitchByTagList : IFightMusicsSwitchType
	{
		// Token: 0x06004292 RID: 17042 RVA: 0x000A90CE File Offset: 0x000A72CE
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

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x06004293 RID: 17043 RVA: 0x000A90ED File Offset: 0x000A72ED
		public override EFightMusicsSwitchType Type
		{
			get
			{
				return (EFightMusicsSwitchType)this.Instance.Type;
			}
		}

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x06004294 RID: 17044 RVA: 0x000A90FC File Offset: 0x000A72FC
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

		// Token: 0x040024DE RID: 9438
		private IFightMusicsSwitchByTagList Instance;

		// Token: 0x040024DF RID: 9439
		private List<IFightMusicSwitchByTag> _ElementCache;

		// Token: 0x040024E0 RID: 9440
		private bool _ElementInited;
	}
}
