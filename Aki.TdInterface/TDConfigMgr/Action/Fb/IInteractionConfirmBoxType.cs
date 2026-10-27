using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200260B RID: 9739
	public class IInteractionConfirmBoxType
	{
		// Token: 0x0600DAB3 RID: 55987 RVA: 0x0020951D File Offset: 0x0020771D
		[NullableContext(1)]
		public static IInteractionConfirmBoxType Create(IInteractionConfirmBoxType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractionConfirmBoxType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700405F RID: 16479
		// (get) Token: 0x0600DAB4 RID: 55988 RVA: 0x0020953C File Offset: 0x0020773C
		public virtual EInteractionConfirmBoxType Type
		{
			get
			{
				return (EInteractionConfirmBoxType)this.Instance.Type;
			}
		}

		// Token: 0x0400797B RID: 31099
		private IInteractionConfirmBoxType Instance;
	}
}
