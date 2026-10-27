using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Item
{
	// Token: 0x02005823 RID: 22563
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleDescribeComponent : UiPanelBase
	{
		// Token: 0x06039536 RID: 234806 RVA: 0x00D98AB0 File Offset: 0x00D96CB0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039537 RID: 234807 RVA: 0x00D98BA0 File Offset: 0x00D96DA0
		protected override void OnStart()
		{
			this.LevelSequencePlayerInstance = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayerInstance.PlayLevelSequenceByName("Start", false, null, false);
			this.StarLayout = new SimpleGenericLayout(base.GetHorizontalLayout(2));
			UUITexture texture = base.GetTexture(3);
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			UUISprite sprite = base.GetSprite(5);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			base.GetItem(1).SetUIActive(false);
		}

		// Token: 0x06039538 RID: 234808 RVA: 0x00D98C20 File Offset: 0x00D96E20
		public void Update(int roleId)
		{
			this.RoleId = roleId;
			RoleInfo? roleInfoById = GachaConfig.Instance.GetRoleInfoById(this.RoleId);
			if (roleInfoById == null)
			{
				return;
			}
			base.GetText(0).ShowTextNew(roleInfoById.Value.Name);
			ElementInfo? elementConfig = CommonConfig.Instance.GetElementConfig(roleInfoById.Value.ElementId);
			UUITexture texture = base.GetTexture(3);
			UUISprite sprite = base.GetSprite(4);
			base.SetTextureByPath(elementConfig.Value.Icon, texture, null, null);
			this.SetSpriteByPath(elementConfig.Value.GachaElementBgSpritePath, sprite, false, null, null);
			this.UpdateQuality(roleInfoById.Value.QualityId);
		}

		// Token: 0x06039539 RID: 234809 RVA: 0x00D98CF1 File Offset: 0x00D96EF1
		private void UpdateQuality(int quality)
		{
			this.StarLayout.RebuildLayout(quality);
		}

		// Token: 0x0401DFB8 RID: 122808
		private int RoleId;

		// Token: 0x0401DFB9 RID: 122809
		private LevelSequencePlayer LevelSequencePlayerInstance;

		// Token: 0x0401DFBA RID: 122810
		private SimpleGenericLayout StarLayout;
	}
}
