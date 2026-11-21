using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CB5 RID: 19637
	public class BattleEntranceRoleButton : BattleEntranceButton
	{
		// Token: 0x0603116E RID: 201070 RVA: 0x00DB4F66 File Offset: 0x00DB3166
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUISprite)));
		}

		// Token: 0x0603116F RID: 201071 RVA: 0x00DB4F89 File Offset: 0x00DB3189
		[NullableContext(2)]
		public override void Initialize(object parameter = null)
		{
			base.Initialize(parameter);
			this.RefreshSpriteIconByFunctionType();
		}

		// Token: 0x06031170 RID: 201072 RVA: 0x00DB4F98 File Offset: 0x00DB3198
		private void RefreshSpriteIconByFunctionType()
		{
			if (this.FunctionType.GetValueOrDefault() == EFunctionType.Role)
			{
				string fightIconResonancePath = FunctionConfig.Instance.GetFightIconResonancePath();
				this.SetSpriteByPath(fightIconResonancePath, base.GetSprite(2), true, null, null);
			}
		}

		// Token: 0x0200A929 RID: 43305
		private enum EComponent
		{
			// Token: 0x0403443C RID: 214076
			SpriteIcon = 2
		}
	}
}
