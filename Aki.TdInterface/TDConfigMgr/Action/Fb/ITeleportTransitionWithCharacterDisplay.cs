using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026A5 RID: 9893
	public class ITeleportTransitionWithCharacterDisplay : ITeleportTransitionType
	{
		// Token: 0x0600DD6E RID: 56686 RVA: 0x0020E506 File Offset: 0x0020C706
		[NullableContext(1)]
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

		// Token: 0x170041E6 RID: 16870
		// (get) Token: 0x0600DD6F RID: 56687 RVA: 0x0020E525 File Offset: 0x0020C725
		public override ETeleportTransitionType Type
		{
			get
			{
				return (ETeleportTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x170041E7 RID: 16871
		// (get) Token: 0x0600DD70 RID: 56688 RVA: 0x0020E532 File Offset: 0x0020C732
		public virtual int StyleId
		{
			get
			{
				return this.Instance.StyleId;
			}
		}

		// Token: 0x04007AFB RID: 31483
		private ITeleportTransitionWithCharacterDisplay Instance;
	}
}
