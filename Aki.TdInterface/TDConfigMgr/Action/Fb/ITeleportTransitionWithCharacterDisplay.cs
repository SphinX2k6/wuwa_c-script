using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002968 RID: 10600
	public class ITeleportTransitionWithCharacterDisplay : ITeleportTransitionType
	{
		// Token: 0x0600EB45 RID: 60229 RVA: 0x0022ACA6 File Offset: 0x00228EA6
		public static ITeleportTransitionWithCharacterDisplay Create(ITeleportTransitionWithCharacterDisplay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionWithCharacterDisplay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004523 RID: 17699
		// (get) Token: 0x0600EB46 RID: 60230 RVA: 0x0022ACC5 File Offset: 0x00228EC5
		public override ETeleportTransitionType Type
		{
			get
			{
				return (ETeleportTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x17004524 RID: 17700
		// (get) Token: 0x0600EB47 RID: 60231 RVA: 0x0022ACD2 File Offset: 0x00228ED2
		public virtual int StyleId
		{
			get
			{
				return this.Instance.StyleId;
			}
		}

		// Token: 0x04008198 RID: 33176
		private ITeleportTransitionWithCharacterDisplay Instance;
	}
}
