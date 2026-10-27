using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013B4 RID: 5044
	[NullableContext(1)]
	[Nullable(0)]
	public class ITakePhoto2TargetPlayMontageCondition
	{
		// Token: 0x0600732C RID: 29484 RVA: 0x00114908 File Offset: 0x00112B08
		public static ITakePhoto2TargetPlayMontageCondition Create(ITakePhoto2TargetPlayMontageCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2TargetPlayMontageCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002597 RID: 9623
		// (get) Token: 0x0600732D RID: 29485 RVA: 0x00114927 File Offset: 0x00112B27
		public virtual string MontagePath
		{
			get
			{
				return this.Instance.MontagePath;
			}
		}

		// Token: 0x0400429A RID: 17050
		private ITakePhoto2TargetPlayMontageCondition Instance;
	}
}
