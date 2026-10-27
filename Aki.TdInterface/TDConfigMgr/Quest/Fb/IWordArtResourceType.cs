using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001333 RID: 4915
	public class IWordArtResourceType
	{
		// Token: 0x060070AE RID: 28846 RVA: 0x0010FE32 File Offset: 0x0010E032
		[NullableContext(1)]
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

		// Token: 0x1700241B RID: 9243
		// (get) Token: 0x060070AF RID: 28847 RVA: 0x0010FE51 File Offset: 0x0010E051
		public virtual EWordArtResourceType Type
		{
			get
			{
				return (EWordArtResourceType)this.Instance.Type;
			}
		}

		// Token: 0x040040FF RID: 16639
		private IWordArtResourceType Instance;
	}
}
