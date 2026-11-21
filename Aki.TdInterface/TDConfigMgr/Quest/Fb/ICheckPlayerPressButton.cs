using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200151D RID: 5405
	public class ICheckPlayerPressButton : ICheckPlayerInputBase
	{
		// Token: 0x06007A5B RID: 31323 RVA: 0x00123FB6 File Offset: 0x001221B6
		public static ICheckPlayerPressButton Create(ICheckPlayerPressButton? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckPlayerPressButton
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027C3 RID: 10179
		// (get) Token: 0x06007A5C RID: 31324 RVA: 0x00123FD5 File Offset: 0x001221D5
		public override ECheckPlayerInputType Type
		{
			get
			{
				return (ECheckPlayerInputType)this.Instance.Type;
			}
		}

		// Token: 0x170027C4 RID: 10180
		// (get) Token: 0x06007A5D RID: 31325 RVA: 0x00123FE2 File Offset: 0x001221E2
		public virtual EPlayerButtonType ButtonType
		{
			get
			{
				return (EPlayerButtonType)this.Instance.ButtonType;
			}
		}

		// Token: 0x0400467D RID: 18045
		private ICheckPlayerPressButton Instance;
	}
}
