using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CD3 RID: 23763
	public class BattleEntranceRoleButton : BattleEntranceButton
	{
		// Token: 0x0603C218 RID: 246296 RVA: 0x00E6498A File Offset: 0x00E62B8A
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUISprite)));
		}

		// Token: 0x0603C219 RID: 246297 RVA: 0x00E649AD File Offset: 0x00E62BAD
		[NullableContext(2)]
		public override void Initialize(object parameter = null)
		{
			base.Initialize(parameter);
			this.RefreshSpriteIconByFunctionType();
		}

		// Token: 0x0603C21A RID: 246298 RVA: 0x00E649BC File Offset: 0x00E62BBC
		private void RefreshSpriteIconByFunctionType()
		{
			if (this.FunctionType.GetValueOrDefault() == EFunctionType.Role)
			{
				string fightIconResonancePath = FunctionConfig.Instance.GetFightIconResonancePath();
				this.SetSpriteByPath(fightIconResonancePath, base.GetSprite(2), true, null, null);
			}
		}

		// Token: 0x0200BF23 RID: 48931
		private enum EComponent
		{
			// Token: 0x04039A7A RID: 236154
			SpriteIcon = 2
		}
	}
}
