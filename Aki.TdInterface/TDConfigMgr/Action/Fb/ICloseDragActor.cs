using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200287F RID: 10367
	public class ICloseDragActor : ICloseUiGame
	{
		// Token: 0x0600E5AB RID: 58795 RVA: 0x0021C29F File Offset: 0x0021A49F
		[NullableContext(1)]
		public static ICloseDragActor Create(ICloseDragActor? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseDragActor
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700466F RID: 18031
		// (get) Token: 0x0600E5AC RID: 58796 RVA: 0x0021C2BE File Offset: 0x0021A4BE
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004670 RID: 18032
		// (get) Token: 0x0600E5AD RID: 58797 RVA: 0x0021C2CB File Offset: 0x0021A4CB
		public virtual int TargetEntityId
		{
			get
			{
				return this.Instance.TargetEntityId;
			}
		}

		// Token: 0x04007F01 RID: 32513
		private ICloseDragActor Instance;
	}
}
