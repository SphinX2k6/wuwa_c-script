using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012D8 RID: 4824
	public class IFirstPersonTurretGamePlayConfig : ISpecialGamePlayConfig
	{
		// Token: 0x06006E40 RID: 28224 RVA: 0x0010A972 File Offset: 0x00108B72
		[NullableContext(1)]
		public static IFirstPersonTurretGamePlayConfig Create(IFirstPersonTurretGamePlayConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFirstPersonTurretGamePlayConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002263 RID: 8803
		// (get) Token: 0x06006E41 RID: 28225 RVA: 0x0010A991 File Offset: 0x00108B91
		public override ESpecialGamePlayConfigType Type
		{
			get
			{
				return (ESpecialGamePlayConfigType)this.Instance.Type;
			}
		}

		// Token: 0x04003F2E RID: 16174
		private IFirstPersonTurretGamePlayConfig Instance;
	}
}
