using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D21 RID: 3361
	public class ISceneTextGuideUiScaleConfig
	{
		// Token: 0x06004CB6 RID: 19638 RVA: 0x000BF032 File Offset: 0x000BD232
		[NullableContext(1)]
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

		// Token: 0x17001831 RID: 6193
		// (get) Token: 0x06004CB7 RID: 19639 RVA: 0x000BF051 File Offset: 0x000BD251
		public virtual int MinDist
		{
			get
			{
				return this.Instance.MinDist;
			}
		}

		// Token: 0x17001832 RID: 6194
		// (get) Token: 0x06004CB8 RID: 19640 RVA: 0x000BF05E File Offset: 0x000BD25E
		public virtual int MaxDist
		{
			get
			{
				return this.Instance.MaxDist;
			}
		}

		// Token: 0x17001833 RID: 6195
		// (get) Token: 0x06004CB9 RID: 19641 RVA: 0x000BF06B File Offset: 0x000BD26B
		public virtual float MinScale
		{
			get
			{
				return this.Instance.MinScale;
			}
		}

		// Token: 0x17001834 RID: 6196
		// (get) Token: 0x06004CBA RID: 19642 RVA: 0x000BF078 File Offset: 0x000BD278
		public virtual float MaxScale
		{
			get
			{
				return this.Instance.MaxScale;
			}
		}

		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x06004CBB RID: 19643 RVA: 0x000BF085 File Offset: 0x000BD285
		public virtual ESceneTextGuideUiScaleType ScaleType
		{
			get
			{
				return (ESceneTextGuideUiScaleType)this.Instance.ScaleType;
			}
		}

		// Token: 0x04002BE8 RID: 11240
		private ISceneTextGuideUiScaleConfig Instance;
	}
}
