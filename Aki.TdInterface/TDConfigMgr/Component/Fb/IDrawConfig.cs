using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B2D RID: 2861
	[NullableContext(1)]
	[Nullable(0)]
	public class IDrawConfig
	{
		// Token: 0x06004213 RID: 16915 RVA: 0x000A9658 File Offset: 0x000A7858
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

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x06004214 RID: 16916 RVA: 0x000A9677 File Offset: 0x000A7877
		public virtual int DrawDelay
		{
			get
			{
				return this.Instance.DrawDelay;
			}
		}

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x06004215 RID: 16917 RVA: 0x000A9684 File Offset: 0x000A7884
		public virtual int DrawTime
		{
			get
			{
				return this.Instance.DrawTime;
			}
		}

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x06004216 RID: 16918 RVA: 0x000A9691 File Offset: 0x000A7891
		public virtual int DrawAlignTime
		{
			get
			{
				return this.Instance.DrawAlignTime;
			}
		}

		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x06004217 RID: 16919 RVA: 0x000A969E File Offset: 0x000A789E
		public virtual int DrawAlignHeight
		{
			get
			{
				return this.Instance.DrawAlignHeight;
			}
		}

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x06004218 RID: 16920 RVA: 0x000A96AB File Offset: 0x000A78AB
		public virtual string DrawCameraShake
		{
			get
			{
				return this.Instance.DrawCameraShake;
			}
		}

		// Token: 0x0400254A RID: 9546
		private IDrawConfig Instance;
	}
}
