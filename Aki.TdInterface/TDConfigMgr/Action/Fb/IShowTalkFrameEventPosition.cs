using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200285F RID: 10335
	public class IShowTalkFrameEventPosition
	{
		// Token: 0x0600E683 RID: 59011 RVA: 0x00221E90 File Offset: 0x00220090
		public static IShowTalkFrameEventPosition Create(IShowTalkFrameEventPosition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowTalkFrameEventPosition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004273 RID: 17011
		// (get) Token: 0x0600E684 RID: 59012 RVA: 0x00221EAF File Offset: 0x002200AF
		public virtual int TalkItemId
		{
			get
			{
				return this.Instance.TalkItemId;
			}
		}

		// Token: 0x17004274 RID: 17012
		// (get) Token: 0x0600E685 RID: 59013 RVA: 0x00221EBC File Offset: 0x002200BC
		public virtual int Offset
		{
			get
			{
				return this.Instance.Offset;
			}
		}

		// Token: 0x04007EF5 RID: 32501
		private IShowTalkFrameEventPosition Instance;
	}
}
