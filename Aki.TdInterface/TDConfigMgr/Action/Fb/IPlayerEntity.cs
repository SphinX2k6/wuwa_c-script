using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027BD RID: 10173
	public class IPlayerEntity : ITargetEntityType
	{
		// Token: 0x0600E24C RID: 57932 RVA: 0x00216D67 File Offset: 0x00214F67
		[NullableContext(1)]
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

		// Token: 0x17004494 RID: 17556
		// (get) Token: 0x0600E24D RID: 57933 RVA: 0x00216D86 File Offset: 0x00214F86
		public override ETargetEntityType Type
		{
			get
			{
				return (ETargetEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17004495 RID: 17557
		// (get) Token: 0x0600E24E RID: 57934 RVA: 0x00216D94 File Offset: 0x00214F94
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

		// Token: 0x04007D7D RID: 32125
		private IPlayerEntity Instance;
	}
}
