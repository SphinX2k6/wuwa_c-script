using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A90 RID: 10896
	public class IPlayerEntity : ITargetEntityType
	{
		// Token: 0x0600F06E RID: 61550 RVA: 0x00233B3B File Offset: 0x00231D3B
		public static IPlayerEntity Create(IPlayerEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047FC RID: 18428
		// (get) Token: 0x0600F06F RID: 61551 RVA: 0x00233B5A File Offset: 0x00231D5A
		public override ETargetEntityType Type
		{
			get
			{
				return (ETargetEntityType)this.Instance.Type;
			}
		}

		// Token: 0x170047FD RID: 18429
		// (get) Token: 0x0600F070 RID: 61552 RVA: 0x00233B68 File Offset: 0x00231D68
		public virtual EPlayerTargetType? PlayerTargetType
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EPlayerTargetType?((EPlayerTargetType)this.Instance.PlayerTargetType);
			}
		}

		// Token: 0x04008434 RID: 33844
		private IPlayerEntity Instance;
	}
}
