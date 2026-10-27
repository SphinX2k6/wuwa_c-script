using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001334 RID: 4916
	public class IWordArtDefaultResourceType : IWordArtResourceType
	{
		// Token: 0x060070B1 RID: 28849 RVA: 0x0010FE66 File Offset: 0x0010E066
		[NullableContext(1)]
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

		// Token: 0x1700241C RID: 9244
		// (get) Token: 0x060070B2 RID: 28850 RVA: 0x0010FE85 File Offset: 0x0010E085
		public override EWordArtResourceType Type
		{
			get
			{
				return (EWordArtResourceType)this.Instance.Type;
			}
		}

		// Token: 0x1700241D RID: 9245
		// (get) Token: 0x060070B3 RID: 28851 RVA: 0x0010FE94 File Offset: 0x0010E094
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

		// Token: 0x04004100 RID: 16640
		private IWordArtDefaultResourceType Instance;
	}
}
