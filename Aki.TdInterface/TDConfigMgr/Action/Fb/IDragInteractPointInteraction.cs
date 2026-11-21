using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B21 RID: 11041
	public class IDragInteractPointInteraction : IInteractPointInteraction
	{
		// Token: 0x0600F2D9 RID: 62169 RVA: 0x00237612 File Offset: 0x00235812
		public static IDragInteractPointInteraction Create(IDragInteractPointInteraction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDragInteractPointInteraction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004945 RID: 18757
		// (get) Token: 0x0600F2DA RID: 62170 RVA: 0x00237631 File Offset: 0x00235831
		public override EInteractPointInteractionType Type
		{
			get
			{
				return (EInteractPointInteractionType)this.Instance.Type;
			}
		}

		// Token: 0x17004946 RID: 18758
		// (get) Token: 0x0600F2DB RID: 62171 RVA: 0x0023763E File Offset: 0x0023583E
		public virtual int DragItemTag
		{
			get
			{
				return this.Instance.DragItemTag;
			}
		}

		// Token: 0x17004947 RID: 18759
		// (get) Token: 0x0600F2DC RID: 62172 RVA: 0x0023764C File Offset: 0x0023584C
		public virtual float? CheckDistance
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.CheckDistance);
			}
		}

		// Token: 0x04008545 RID: 34117
		private IDragInteractPointInteraction Instance;
	}
}
