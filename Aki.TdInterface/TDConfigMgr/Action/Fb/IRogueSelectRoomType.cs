using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026C6 RID: 9926
	public class IRogueSelectRoomType
	{
		// Token: 0x0600DDFD RID: 56829 RVA: 0x0020F3E9 File Offset: 0x0020D5E9
		[NullableContext(1)]
		public static IRogueSelectRoomType Create(IRogueSelectRoomType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRogueSelectRoomType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004233 RID: 16947
		// (get) Token: 0x0600DDFE RID: 56830 RVA: 0x0020F408 File Offset: 0x0020D608
		public virtual ERogueSelectRoomType Type
		{
			get
			{
				return (ERogueSelectRoomType)this.Instance.Type;
			}
		}

		// Token: 0x04007B42 RID: 31554
		private IRogueSelectRoomType Instance;
	}
}
