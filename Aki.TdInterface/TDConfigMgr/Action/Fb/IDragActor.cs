using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002869 RID: 10345
	public class IDragActor : IUiGame
	{
		// Token: 0x0600E542 RID: 58690 RVA: 0x0021B756 File Offset: 0x00219956
		[NullableContext(1)]
		public static IDragActor Create(IDragActor? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDragActor
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004632 RID: 17970
		// (get) Token: 0x0600E543 RID: 58691 RVA: 0x0021B775 File Offset: 0x00219975
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004633 RID: 17971
		// (get) Token: 0x0600E544 RID: 58692 RVA: 0x0021B782 File Offset: 0x00219982
		public virtual int TargetEntityId
		{
			get
			{
				return this.Instance.TargetEntityId;
			}
		}

		// Token: 0x04007ECB RID: 32459
		private IDragActor Instance;
	}
}
