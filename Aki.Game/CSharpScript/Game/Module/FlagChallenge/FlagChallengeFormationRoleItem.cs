using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A62 RID: 23138
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FlagChallengeFormationRoleItem : GridProxyAbstract<IFlagChallengeFormationRoleItemData>
	{
		// Token: 0x0603AA55 RID: 240213 RVA: 0x00DF62D8 File Offset: 0x00DF44D8
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

		// Token: 0x0603AA56 RID: 240214 RVA: 0x00DF6358 File Offset: 0x00DF4558
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

		// Token: 0x0603AA57 RID: 240215 RVA: 0x00DF63CA File Offset: 0x00DF45CA
		public void SetClickCallback(Action<int> callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x0603AA58 RID: 240216 RVA: 0x00DF63D3 File Offset: 0x00DF45D3
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

		// Token: 0x0401E941 RID: 125249
		[Nullable(2)]
		private IFlagChallengeFormationRoleItemData Data;

		// Token: 0x0401E942 RID: 125250
		[Nullable(2)]
		private Action<int> ClickCallback;
	}
}
