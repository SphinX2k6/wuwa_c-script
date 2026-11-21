using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C55 RID: 3157
	public class IHitLogicChangeCountDownState : IHitLogicType
	{
		// Token: 0x0600483C RID: 18492 RVA: 0x000B6C72 File Offset: 0x000B4E72
		public static IHitLogicChangeCountDownState Create(IHitLogicChangeCountDownState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitLogicChangeCountDownState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x0600483D RID: 18493 RVA: 0x000B6C91 File Offset: 0x000B4E91
		public override EHitLogicType Type
		{
			get
			{
				return (EHitLogicType)this.Instance.Type;
			}
		}

		// Token: 0x0400288E RID: 10382
		private IHitLogicChangeCountDownState Instance;
	}
}
