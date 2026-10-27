using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001315 RID: 4885
	public class ITrackEffectType
	{
		// Token: 0x0600702D RID: 28717 RVA: 0x0010F122 File Offset: 0x0010D322
		[NullableContext(1)]
		public static ITrackEffectType Create(ITrackEffectType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackEffectType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170023D6 RID: 9174
		// (get) Token: 0x0600702E RID: 28718 RVA: 0x0010F141 File Offset: 0x0010D341
		public virtual ETrackEffectType Type
		{
			get
			{
				return (ETrackEffectType)this.Instance.Type;
			}
		}

		// Token: 0x040040BB RID: 16571
		private ITrackEffectType Instance;
	}
}
