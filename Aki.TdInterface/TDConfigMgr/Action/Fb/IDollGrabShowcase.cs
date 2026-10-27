using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002840 RID: 10304
	public class IDollGrabShowcase : IUiGame
	{
		// Token: 0x0600E471 RID: 58481 RVA: 0x00219FCD File Offset: 0x002181CD
		[NullableContext(1)]
		public static IDollGrabShowcase Create(IDollGrabShowcase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollGrabShowcase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045B3 RID: 17843
		// (get) Token: 0x0600E472 RID: 58482 RVA: 0x00219FEC File Offset: 0x002181EC
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x170045B4 RID: 17844
		// (get) Token: 0x0600E473 RID: 58483 RVA: 0x00219FF9 File Offset: 0x002181F9
		public virtual int ShowcaseEntityId
		{
			get
			{
				return this.Instance.ShowcaseEntityId;
			}
		}

		// Token: 0x04007E66 RID: 32358
		private IDollGrabShowcase Instance;
	}
}
