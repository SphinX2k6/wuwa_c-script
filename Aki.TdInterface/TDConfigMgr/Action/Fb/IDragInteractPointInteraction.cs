using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200284E RID: 10318
	public class IDragInteractPointInteraction : IInteractPointInteraction
	{
		// Token: 0x0600E4B4 RID: 58548 RVA: 0x0021A7AE File Offset: 0x002189AE
		[NullableContext(1)]
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

		// Token: 0x170045DA RID: 17882
		// (get) Token: 0x0600E4B5 RID: 58549 RVA: 0x0021A7CD File Offset: 0x002189CD
		public override EInteractPointInteractionType Type
		{
			get
			{
				return (EInteractPointInteractionType)this.Instance.Type;
			}
		}

		// Token: 0x170045DB RID: 17883
		// (get) Token: 0x0600E4B6 RID: 58550 RVA: 0x0021A7DA File Offset: 0x002189DA
		public virtual int DragItemTag
		{
			get
			{
				return this.Instance.DragItemTag;
			}
		}

		// Token: 0x170045DC RID: 17884
		// (get) Token: 0x0600E4B7 RID: 58551 RVA: 0x0021A7E8 File Offset: 0x002189E8
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

		// Token: 0x04007E88 RID: 32392
		private IDragInteractPointInteraction Instance;
	}
}
