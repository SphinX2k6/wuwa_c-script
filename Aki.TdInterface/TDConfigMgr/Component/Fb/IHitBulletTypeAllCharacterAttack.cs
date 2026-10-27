using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B97 RID: 2967
	public class IHitBulletTypeAllCharacterAttack : IHitBulletType
	{
		// Token: 0x06004427 RID: 17447 RVA: 0x000AD486 File Offset: 0x000AB686
		[NullableContext(1)]
		public static IHitBulletTypeAllCharacterAttack Create(IHitBulletTypeAllCharacterAttack? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitBulletTypeAllCharacterAttack
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x06004428 RID: 17448 RVA: 0x000AD4A5 File Offset: 0x000AB6A5
		public override EHitBulletType Type
		{
			get
			{
				return (EHitBulletType)this.Instance.Type;
			}
		}

		// Token: 0x04002676 RID: 9846
		private IHitBulletTypeAllCharacterAttack Instance;
	}
}
