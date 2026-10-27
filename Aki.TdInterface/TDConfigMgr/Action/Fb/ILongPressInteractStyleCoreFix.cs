using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002616 RID: 9750
	public class ILongPressInteractStyleCoreFix : ILongPressInteractStyleConfig
	{
		// Token: 0x0600DADE RID: 56030 RVA: 0x002098AD File Offset: 0x00207AAD
		[NullableContext(1)]
		public static ILongPressInteractStyleCoreFix Create(ILongPressInteractStyleCoreFix? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressInteractStyleCoreFix
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004074 RID: 16500
		// (get) Token: 0x0600DADF RID: 56031 RVA: 0x002098CC File Offset: 0x00207ACC
		public override ELongPressInteractStyle Type
		{
			get
			{
				return (ELongPressInteractStyle)this.Instance.Type;
			}
		}

		// Token: 0x0400798C RID: 31116
		private ILongPressInteractStyleCoreFix Instance;
	}
}
