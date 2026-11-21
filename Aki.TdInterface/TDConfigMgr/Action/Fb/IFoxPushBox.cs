using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ADA RID: 10970
	public class IFoxPushBox : ILeisureInteractType
	{
		// Token: 0x0600F188 RID: 61832 RVA: 0x0023537E File Offset: 0x0023357E
		public static IFoxPushBox Create(IFoxPushBox? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFoxPushBox
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004882 RID: 18562
		// (get) Token: 0x0600F189 RID: 61833 RVA: 0x0023539D File Offset: 0x0023359D
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x17004883 RID: 18563
		// (get) Token: 0x0600F18A RID: 61834 RVA: 0x002353AA File Offset: 0x002335AA
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004884 RID: 18564
		// (get) Token: 0x0600F18B RID: 61835 RVA: 0x002353B7 File Offset: 0x002335B7
		public virtual int CollisionRadius
		{
			get
			{
				return this.Instance.CollisionRadius;
			}
		}

		// Token: 0x17004885 RID: 18565
		// (get) Token: 0x0600F18C RID: 61836 RVA: 0x002353C4 File Offset: 0x002335C4
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x17004886 RID: 18566
		// (get) Token: 0x0600F18D RID: 61837 RVA: 0x002353D1 File Offset: 0x002335D1
		[Nullable(2)]
		public virtual string SendEntityEventOnSplineFinish
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.SendEntityEventOnSplineFinish;
			}
		}

		// Token: 0x040084A8 RID: 33960
		private IFoxPushBox Instance;
	}
}
