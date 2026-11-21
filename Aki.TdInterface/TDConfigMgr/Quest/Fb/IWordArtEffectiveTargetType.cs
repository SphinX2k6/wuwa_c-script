using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001481 RID: 5249
	public class IWordArtEffectiveTargetType
	{
		// Token: 0x06007747 RID: 30535 RVA: 0x0011E300 File Offset: 0x0011C500
		public static IWordArtEffectiveTargetType Create(IWordArtEffectiveTargetType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWordArtEffectiveTargetType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025E7 RID: 9703
		// (get) Token: 0x06007748 RID: 30536 RVA: 0x0011E31F File Offset: 0x0011C51F
		public virtual EWordArtEffectiveTargetType Type
		{
			get
			{
				return (EWordArtEffectiveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04004479 RID: 17529
		private IWordArtEffectiveTargetType Instance;
	}
}
