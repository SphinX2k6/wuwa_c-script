using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027A8 RID: 10152
	public class IToggleDragActorPlayType
	{
		// Token: 0x0600E1E0 RID: 57824 RVA: 0x00215E4E File Offset: 0x0021404E
		[NullableContext(1)]
		public static IToggleDragActorPlayType Create(IToggleDragActorPlayType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IToggleDragActorPlayType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004452 RID: 17490
		// (get) Token: 0x0600E1E1 RID: 57825 RVA: 0x00215E6D File Offset: 0x0021406D
		public virtual EToggleDragActorPlayType Type
		{
			get
			{
				return (EToggleDragActorPlayType)this.Instance.Type;
			}
		}

		// Token: 0x04007D44 RID: 32068
		private IToggleDragActorPlayType Instance;
	}
}
