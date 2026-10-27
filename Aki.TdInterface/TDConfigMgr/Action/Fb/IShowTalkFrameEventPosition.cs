using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025B0 RID: 9648
	public class IShowTalkFrameEventPosition
	{
		// Token: 0x0600D909 RID: 55561 RVA: 0x002061BC File Offset: 0x002043BC
		[NullableContext(1)]
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

		// Token: 0x17003F6B RID: 16235
		// (get) Token: 0x0600D90A RID: 55562 RVA: 0x002061DB File Offset: 0x002043DB
		public virtual int TalkItemId
		{
			get
			{
				return this.Instance.TalkItemId;
			}
		}

		// Token: 0x17003F6C RID: 16236
		// (get) Token: 0x0600D90B RID: 55563 RVA: 0x002061E8 File Offset: 0x002043E8
		public virtual int Offset
		{
			get
			{
				return this.Instance.Offset;
			}
		}

		// Token: 0x0400788E RID: 30862
		private IShowTalkFrameEventPosition Instance;
	}
}
