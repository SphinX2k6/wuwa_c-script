using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200256D RID: 9581
	public class IVisualNovelDisplayItemImage : IVisualNovelDisplayItemBase
	{
		// Token: 0x0600D708 RID: 55048 RVA: 0x00200A1F File Offset: 0x001FEC1F
		[NullableContext(1)]
		public static IVisualNovelDisplayItemImage Create(IVisualNovelDisplayItemImage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelDisplayItemImage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DF0 RID: 15856
		// (get) Token: 0x0600D709 RID: 55049 RVA: 0x00200A3E File Offset: 0x001FEC3E
		public override EVisualNovelDisplayItemType Type
		{
			get
			{
				return (EVisualNovelDisplayItemType)this.Instance.Type;
			}
		}

		// Token: 0x17003DF1 RID: 15857
		// (get) Token: 0x0600D70A RID: 55050 RVA: 0x00200A4B File Offset: 0x001FEC4B
		public virtual int DisplayImageId
		{
			get
			{
				return this.Instance.DisplayImageId;
			}
		}

		// Token: 0x0400770F RID: 30479
		private IVisualNovelDisplayItemImage Instance;
	}
}
