using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001482 RID: 5250
	public class INumberWordArtEffectiveTargetType : IWordArtEffectiveTargetType
	{
		// Token: 0x0600774A RID: 30538 RVA: 0x0011E334 File Offset: 0x0011C534
		public static INumberWordArtEffectiveTargetType Create(INumberWordArtEffectiveTargetType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INumberWordArtEffectiveTargetType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025E8 RID: 9704
		// (get) Token: 0x0600774B RID: 30539 RVA: 0x0011E353 File Offset: 0x0011C553
		public override EWordArtEffectiveTargetType Type
		{
			get
			{
				return (EWordArtEffectiveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x170025E9 RID: 9705
		// (get) Token: 0x0600774C RID: 30540 RVA: 0x0011E360 File Offset: 0x0011C560
		public virtual bool? ShowUiMotion
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ShowUiMotion);
			}
		}

		// Token: 0x0400447A RID: 17530
		private INumberWordArtEffectiveTargetType Instance;
	}
}
