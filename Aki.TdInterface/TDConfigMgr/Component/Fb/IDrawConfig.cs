using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BFB RID: 3067
	public class IDrawConfig
	{
		// Token: 0x0600466C RID: 18028 RVA: 0x000B371C File Offset: 0x000B191C
		public static IDrawConfig Create(IDrawConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDrawConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x0600466D RID: 18029 RVA: 0x000B373B File Offset: 0x000B193B
		public virtual int DrawDelay
		{
			get
			{
				return this.Instance.DrawDelay;
			}
		}

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x0600466E RID: 18030 RVA: 0x000B3748 File Offset: 0x000B1948
		public virtual int DrawTime
		{
			get
			{
				return this.Instance.DrawTime;
			}
		}

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x0600466F RID: 18031 RVA: 0x000B3755 File Offset: 0x000B1955
		public virtual int DrawAlignTime
		{
			get
			{
				return this.Instance.DrawAlignTime;
			}
		}

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x06004670 RID: 18032 RVA: 0x000B3762 File Offset: 0x000B1962
		public virtual int DrawAlignHeight
		{
			get
			{
				return this.Instance.DrawAlignHeight;
			}
		}

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x06004671 RID: 18033 RVA: 0x000B376F File Offset: 0x000B196F
		public virtual string DrawCameraShake
		{
			get
			{
				return this.Instance.DrawCameraShake;
			}
		}

		// Token: 0x04002792 RID: 10130
		private IDrawConfig Instance;
	}
}
