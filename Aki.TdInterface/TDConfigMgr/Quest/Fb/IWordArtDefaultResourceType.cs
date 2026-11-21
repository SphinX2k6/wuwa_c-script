using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001484 RID: 5252
	public class IWordArtDefaultResourceType : IWordArtResourceType
	{
		// Token: 0x06007751 RID: 30545 RVA: 0x0011E3D2 File Offset: 0x0011C5D2
		public static IWordArtDefaultResourceType Create(IWordArtDefaultResourceType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWordArtDefaultResourceType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025EB RID: 9707
		// (get) Token: 0x06007752 RID: 30546 RVA: 0x0011E3F1 File Offset: 0x0011C5F1
		public override EWordArtResourceType Type
		{
			get
			{
				return (EWordArtResourceType)this.Instance.Type;
			}
		}

		// Token: 0x170025EC RID: 9708
		// (get) Token: 0x06007753 RID: 30547 RVA: 0x0011E400 File Offset: 0x0011C600
		public virtual float? Scale
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Scale);
			}
		}

		// Token: 0x0400447C RID: 17532
		private IWordArtDefaultResourceType Instance;
	}
}
