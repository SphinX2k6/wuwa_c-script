using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027AA RID: 10154
	public class IToggleDragActorPlayDisable : IToggleDragActorPlayType
	{
		// Token: 0x0600E1EF RID: 57839 RVA: 0x00215F8B File Offset: 0x0021418B
		[NullableContext(1)]
		public static IToggleDragActorPlayDisable Create(IToggleDragActorPlayDisable? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IToggleDragActorPlayDisable
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700445D RID: 17501
		// (get) Token: 0x0600E1F0 RID: 57840 RVA: 0x00215FAA File Offset: 0x002141AA
		public override EToggleDragActorPlayType Type
		{
			get
			{
				return (EToggleDragActorPlayType)this.Instance.Type;
			}
		}

		// Token: 0x04007D48 RID: 32072
		private IToggleDragActorPlayDisable Instance;
	}
}
