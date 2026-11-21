using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C7D RID: 11389
	public class IFollowShooterLeaveThrowInteractionPoint : IFollowShooterLeisureInteractType
	{
		// Token: 0x0600FA28 RID: 64040 RVA: 0x00244D27 File Offset: 0x00242F27
		public static IFollowShooterLeaveThrowInteractionPoint Create(IFollowShooterLeaveThrowInteractionPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowShooterLeaveThrowInteractionPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DDC RID: 19932
		// (get) Token: 0x0600FA29 RID: 64041 RVA: 0x00244D46 File Offset: 0x00242F46
		public override EFollowShooterLeisureInteractType Type
		{
			get
			{
				return (EFollowShooterLeisureInteractType)this.Instance.Type;
			}
		}

		// Token: 0x040088AD RID: 34989
		private IFollowShooterLeaveThrowInteractionPoint Instance;
	}
}
