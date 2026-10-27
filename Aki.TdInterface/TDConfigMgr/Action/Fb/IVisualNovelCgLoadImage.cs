using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002567 RID: 9575
	public class IVisualNovelCgLoadImage : IVisualNovelCgBase
	{
		// Token: 0x0600D6F4 RID: 55028 RVA: 0x002008CD File Offset: 0x001FEACD
		[NullableContext(1)]
		public static IVisualNovelCgLoadImage Create(IVisualNovelCgLoadImage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelCgLoadImage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DE8 RID: 15848
		// (get) Token: 0x0600D6F5 RID: 55029 RVA: 0x002008EC File Offset: 0x001FEAEC
		public override EVisualNovelCgType Type
		{
			get
			{
				return (EVisualNovelCgType)this.Instance.Type;
			}
		}

		// Token: 0x17003DE9 RID: 15849
		// (get) Token: 0x0600D6F6 RID: 55030 RVA: 0x002008F9 File Offset: 0x001FEAF9
		public virtual int ImageId
		{
			get
			{
				return this.Instance.ImageId;
			}
		}

		// Token: 0x04007709 RID: 30473
		private IVisualNovelCgLoadImage Instance;
	}
}
