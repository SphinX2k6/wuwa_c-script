using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027CD RID: 10189
	public class ILimitPlayerMouse : ILimitPlayerOption
	{
		// Token: 0x0600E288 RID: 57992 RVA: 0x00217356 File Offset: 0x00215556
		[NullableContext(1)]
		public static ILimitPlayerMouse Create(ILimitPlayerMouse? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerMouse
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044B0 RID: 17584
		// (get) Token: 0x0600E289 RID: 57993 RVA: 0x00217375 File Offset: 0x00215575
		public override ELimitPlayOperation Type
		{
			get
			{
				return (ELimitPlayOperation)this.Instance.Type;
			}
		}

		// Token: 0x04007D9F RID: 32159
		private ILimitPlayerMouse Instance;
	}
}
