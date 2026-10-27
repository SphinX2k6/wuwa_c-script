using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002807 RID: 10247
	[NullableContext(2)]
	[Nullable(0)]
	public class IFoxPushBox : ILeisureInteractType
	{
		// Token: 0x0600E363 RID: 58211 RVA: 0x0021851A File Offset: 0x0021671A
		[NullableContext(1)]
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

		// Token: 0x17004517 RID: 17687
		// (get) Token: 0x0600E364 RID: 58212 RVA: 0x00218539 File Offset: 0x00216739
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x17004518 RID: 17688
		// (get) Token: 0x0600E365 RID: 58213 RVA: 0x00218546 File Offset: 0x00216746
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004519 RID: 17689
		// (get) Token: 0x0600E366 RID: 58214 RVA: 0x00218553 File Offset: 0x00216753
		public virtual int CollisionRadius
		{
			get
			{
				return this.Instance.CollisionRadius;
			}
		}

		// Token: 0x1700451A RID: 17690
		// (get) Token: 0x0600E367 RID: 58215 RVA: 0x00218560 File Offset: 0x00216760
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x1700451B RID: 17691
		// (get) Token: 0x0600E368 RID: 58216 RVA: 0x0021856D File Offset: 0x0021676D
		public virtual string SendEntityEventOnSplineFinish
		{
			get
			{
				return this.Instance.SendEntityEventOnSplineFinish;
			}
		}

		// Token: 0x04007DEB RID: 32235
		private IFoxPushBox Instance;
	}
}
