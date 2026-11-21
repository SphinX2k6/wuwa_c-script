using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E1B RID: 3611
	public class ISceneTextGuideUiScaleConfig
	{
		// Token: 0x060051D2 RID: 20946 RVA: 0x000CA776 File Offset: 0x000C8976
		public static ISceneTextGuideUiScaleConfig Create(ISceneTextGuideUiScaleConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneTextGuideUiScaleConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x060051D3 RID: 20947 RVA: 0x000CA795 File Offset: 0x000C8995
		public virtual int MinDist
		{
			get
			{
				return this.Instance.MinDist;
			}
		}

		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x060051D4 RID: 20948 RVA: 0x000CA7A2 File Offset: 0x000C89A2
		public virtual int MaxDist
		{
			get
			{
				return this.Instance.MaxDist;
			}
		}

		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x060051D5 RID: 20949 RVA: 0x000CA7AF File Offset: 0x000C89AF
		public virtual float MinScale
		{
			get
			{
				return this.Instance.MinScale;
			}
		}

		// Token: 0x1700199A RID: 6554
		// (get) Token: 0x060051D6 RID: 20950 RVA: 0x000CA7BC File Offset: 0x000C89BC
		public virtual float MaxScale
		{
			get
			{
				return this.Instance.MaxScale;
			}
		}

		// Token: 0x1700199B RID: 6555
		// (get) Token: 0x060051D7 RID: 20951 RVA: 0x000CA7C9 File Offset: 0x000C89C9
		public virtual ESceneTextGuideUiScaleType ScaleType
		{
			get
			{
				return (ESceneTextGuideUiScaleType)this.Instance.ScaleType;
			}
		}

		// Token: 0x04002EA8 RID: 11944
		private ISceneTextGuideUiScaleConfig Instance;
	}
}
