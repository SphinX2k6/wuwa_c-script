using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001331 RID: 4913
	public class IWordArtEffectiveTargetType
	{
		// Token: 0x060070A7 RID: 28839 RVA: 0x0010FD94 File Offset: 0x0010DF94
		[NullableContext(1)]
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

		// Token: 0x17002418 RID: 9240
		// (get) Token: 0x060070A8 RID: 28840 RVA: 0x0010FDB3 File Offset: 0x0010DFB3
		public virtual EWordArtEffectiveTargetType Type
		{
			get
			{
				return (EWordArtEffectiveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x040040FD RID: 16637
		private IWordArtEffectiveTargetType Instance;
	}
}
