using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001483 RID: 5251
	public class IWordArtResourceType
	{
		// Token: 0x0600774E RID: 30542 RVA: 0x0011E39E File Offset: 0x0011C59E
		public static IWordArtResourceType Create(IWordArtResourceType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWordArtResourceType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025EA RID: 9706
		// (get) Token: 0x0600774F RID: 30543 RVA: 0x0011E3BD File Offset: 0x0011C5BD
		public virtual EWordArtResourceType Type
		{
			get
			{
				return (EWordArtResourceType)this.Instance.Type;
			}
		}

		// Token: 0x0400447B RID: 17531
		private IWordArtResourceType Instance;
	}
}
