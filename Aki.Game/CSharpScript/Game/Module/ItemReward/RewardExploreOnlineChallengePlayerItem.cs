using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047D9 RID: 18393
	public class RewardExploreOnlineChallengePlayerItem : UiPanelBase
	{
		// Token: 0x0602E387 RID: 189319 RVA: 0x00CE450C File Offset: 0x00CE270C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602E388 RID: 189320 RVA: 0x00CE4575 File Offset: 0x00CE2775
		protected override void OnStart()
		{
			UUITexture texture = base.GetTexture(0);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(false);
		}

		// Token: 0x0602E389 RID: 189321 RVA: 0x00CE458C File Offset: 0x00CE278C
		public void Refresh(int data)
		{
			RewardExploreOnlineChallengePlayerItem.<>c__DisplayClass3_0 CS$<>8__locals1 = new RewardExploreOnlineChallengePlayerItem.<>c__DisplayClass3_0();
			List<SceneTeamItem> teamItemsByPlayer = SceneTeamModel.Instance.GetTeamItemsByPlayer(data);
			int num = 0;
			foreach (SceneTeamItem sceneTeamItem in teamItemsByPlayer)
			{
				if (sceneTeamItem.IsControl())
				{
					num = sceneTeamItem.GetConfigId;
				}
			}
			if (num == 0)
			{
				base.SetUiActive(false);
				return;
			}
			RoleInfo? roleInfo;
			string text = (RoleConfig.Instance.GetRoleConfig(num) != null) ? roleInfo.GetValueOrDefault().RoleHeadIconBig : null;
			if (string.IsNullOrEmpty(text))
			{
				base.SetUiActive(false);
				return;
			}
			CS$<>8__locals1.roleTexture = base.GetTexture(0);
			if (CS$<>8__locals1.roleTexture == null)
			{
				base.SetUiActive(false);
				return;
			}
			base.SetRoleIcon(text, CS$<>8__locals1.roleTexture, num, null, new Action<bool>(CS$<>8__locals1.<Refresh>g__iconCallback|0));
			string text2;
			if (data == CreatureModel.Instance.GetPlayerId())
			{
				text2 = "SP_Online{0}PIcon_Self";
			}
			else
			{
				text2 = "SP_Online{0}PIcon";
			}
			UUISprite sprite = base.GetSprite(1);
			string inString = text2;
			string[] array = new string[1];
			int num2 = 0;
			OnlineTeamData currentTeamListById = OnlineModel.Instance.GetCurrentTeamListById(data);
			array[num2] = (((currentTeamListById != null) ? currentTeamListById.PlayerNumber.ToString() : null) ?? "1");
			string resourceId = StringUtils.Format(inString, array);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			if (string.IsNullOrEmpty(resourcePath))
			{
				sprite.SetUIActive(false);
				return;
			}
			sprite.SetUIActive(true);
			this.SetSpriteByPath(resourcePath, sprite, false, null, null);
		}

		// Token: 0x0200A412 RID: 42002
		private class EChildType
		{
			// Token: 0x04032D83 RID: 208259
			public const int HeadTexture = 0;

			// Token: 0x04032D84 RID: 208260
			public const int PlayerNumberSprite = 1;
		}
	}
}
