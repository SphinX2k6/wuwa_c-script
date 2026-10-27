using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C76 RID: 3190
	public class IFixedAngleItem
	{
		// Token: 0x06004919 RID: 18713 RVA: 0x000B778E File Offset: 0x000B598E
		[NullableContext(1)]
		public static IFixedAngleItem Create(IFixedAngleItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixedAngleItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015EA RID: 5610
		// (get) Token: 0x0600491A RID: 18714 RVA: 0x000B77AD File Offset: 0x000B59AD
		public virtual int InitAngle
		{
			get
			{
				return this.Instance.InitAngle;
			}
		}

		// Token: 0x170015EB RID: 5611
		// (get) Token: 0x0600491B RID: 18715 RVA: 0x000B77BA File Offset: 0x000B59BA
		public virtual int TargetAngle
		{
			get
			{
				return this.Instance.TargetAngle;
			}
		}

		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x0600491C RID: 18716 RVA: 0x000B77C7 File Offset: 0x000B59C7
		public virtual int RotateAngle
		{
			get
			{
				return this.Instance.RotateAngle;
			}
		}

		// Token: 0x040029B3 RID: 10675
		private IFixedAngleItem Instance;
	}
}
