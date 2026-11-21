using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A3E RID: 19006
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FlagChallengeFormationRoleItem : GridProxyAbstract<IFlagChallengeFormationRoleItemData>
	{
		// Token: 0x0602F99E RID: 194974 RVA: 0x00D4685C File Offset: 0x00D44A5C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUITexture))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickButton))
			};
		}

		// Token: 0x0602F99F RID: 194975 RVA: 0x00D468DC File Offset: 0x00D44ADC
		public override void Refresh(IFlagChallengeFormationRoleItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			RoleDataBase roleData = data.RoleData;
			UUITexture roleIconTex = base.GetTexture(2);
			roleIconTex.SetUIActive(false);
			if (roleData != null)
			{
				base.SetRoleIcon(roleData.GetRoleConfig().RoleHeadIconCircle, roleIconTex, roleData.GetRoleId(), null, delegate(bool _)
				{
					roleIconTex.SetUIActive(true);
				});
			}
		}

		// Token: 0x0602F9A0 RID: 194976 RVA: 0x00D4694E File Offset: 0x00D44B4E
		public void SetClickCallback(Action<int> callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x0602F9A1 RID: 194977 RVA: 0x00D46957 File Offset: 0x00D44B57
		private void OnClickButton()
		{
			if (this.Data == null || this.Data.RoleData == null)
			{
				return;
			}
			Action<int> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.Data.RoleData.GetDataId());
		}

		// Token: 0x040193E8 RID: 103400
		[Nullable(2)]
		private IFlagChallengeFormationRoleItemData Data;

		// Token: 0x040193E9 RID: 103401
		[Nullable(2)]
		private Action<int> ClickCallback;
	}
}
