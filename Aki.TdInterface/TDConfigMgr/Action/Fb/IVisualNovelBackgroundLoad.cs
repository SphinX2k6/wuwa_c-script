using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200256A RID: 9578
	public class IVisualNovelBackgroundLoad : IVisualNovelBackgroundBase
	{
		// Token: 0x0600D6FE RID: 55038 RVA: 0x00200976 File Offset: 0x001FEB76
		[NullableContext(1)]
		public static IVisualNovelBackgroundLoad Create(IVisualNovelBackgroundLoad? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelBackgroundLoad
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DEC RID: 15852
		// (get) Token: 0x0600D6FF RID: 55039 RVA: 0x00200995 File Offset: 0x001FEB95
		public override EVisualNovelBackgroundType Type
		{
			get
			{
				return (EVisualNovelBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x17003DED RID: 15853
		// (get) Token: 0x0600D700 RID: 55040 RVA: 0x002009A2 File Offset: 0x001FEBA2
		public virtual int BackgroundId
		{
			get
			{
				return this.Instance.BackgroundId;
			}
		}

		// Token: 0x0400770C RID: 30476
		private IVisualNovelBackgroundLoad Instance;
	}
}
