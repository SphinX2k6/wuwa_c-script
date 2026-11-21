using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C54 RID: 3156
	public class IHitLogicChangeLockState : IHitLogicType
	{
		// Token: 0x06004839 RID: 18489 RVA: 0x000B6C3E File Offset: 0x000B4E3E
		public static IHitLogicChangeLockState Create(IHitLogicChangeLockState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitLogicChangeLockState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x0600483A RID: 18490 RVA: 0x000B6C5D File Offset: 0x000B4E5D
		public override EHitLogicType Type
		{
			get
			{
				return (EHitLogicType)this.Instance.Type;
			}
		}

		// Token: 0x0400288D RID: 10381
		private IHitLogicChangeLockState Instance;
	}
}
