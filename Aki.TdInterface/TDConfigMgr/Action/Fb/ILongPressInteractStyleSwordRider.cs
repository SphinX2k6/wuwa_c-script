using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002615 RID: 9749
	public class ILongPressInteractStyleSwordRider : ILongPressInteractStyleConfig
	{
		// Token: 0x0600DADB RID: 56027 RVA: 0x00209879 File Offset: 0x00207A79
		[NullableContext(1)]
		public static ILongPressInteractStyleSwordRider Create(ILongPressInteractStyleSwordRider? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressInteractStyleSwordRider
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004073 RID: 16499
		// (get) Token: 0x0600DADC RID: 56028 RVA: 0x00209898 File Offset: 0x00207A98
		public override ELongPressInteractStyle Type
		{
			get
			{
				return (ELongPressInteractStyle)this.Instance.Type;
			}
		}

		// Token: 0x0400798B RID: 31115
		private ILongPressInteractStyleSwordRider Instance;
	}
}
