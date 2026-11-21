using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200298A RID: 10634
	public class IRogueSelectRoomType
	{
		// Token: 0x0600EBD9 RID: 60377 RVA: 0x0022BC29 File Offset: 0x00229E29
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

		// Token: 0x17004573 RID: 17779
		// (get) Token: 0x0600EBDA RID: 60378 RVA: 0x0022BC48 File Offset: 0x00229E48
		public virtual ERogueSelectRoomType Type
		{
			get
			{
				return (ERogueSelectRoomType)this.Instance.Type;
			}
		}

		// Token: 0x040081E2 RID: 33250
		private IRogueSelectRoomType Instance;
	}
}
