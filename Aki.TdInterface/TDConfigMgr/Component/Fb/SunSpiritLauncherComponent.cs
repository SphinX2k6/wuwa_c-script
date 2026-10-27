using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DB9 RID: 3513
	public class SunSpiritLauncherComponent : IComponentBase
	{
		// Token: 0x06004FC0 RID: 20416 RVA: 0x000C561A File Offset: 0x000C381A
		[NullableContext(1)]
		public static SunSpiritLauncherComponent Create(ISunSpiritLauncherComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SunSpiritLauncherComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A0B RID: 6667
		// (get) Token: 0x06004FC1 RID: 20417 RVA: 0x000C563C File Offset: 0x000C383C
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x06004FC2 RID: 20418 RVA: 0x000C5674 File Offset: 0x000C3874
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x06004FC3 RID: 20419 RVA: 0x000C568A File Offset: 0x000C388A
		public virtual int AreaId
		{
			get
			{
				return this.Instance.AreaId;
			}
		}

		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x06004FC4 RID: 20420 RVA: 0x000C5697 File Offset: 0x000C3897
		public virtual int NeedsCount
		{
			get
			{
				return this.Instance.NeedsCount;
			}
		}

		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x06004FC5 RID: 20421 RVA: 0x000C56A4 File Offset: 0x000C38A4
		public virtual int SunSpiritGearId
		{
			get
			{
				return this.Instance.SunSpiritGearId;
			}
		}

		// Token: 0x04002DC4 RID: 11716
		private ISunSpiritLauncherComponent Instance;
	}
}
