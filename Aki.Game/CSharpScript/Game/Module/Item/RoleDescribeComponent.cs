using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Item
{
	// Token: 0x020047FA RID: 18426
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleDescribeComponent : UiPanelBase
	{
		// Token: 0x0602E44A RID: 189514 RVA: 0x00CE793C File Offset: 0x00CE5B3C
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

		// Token: 0x0602E44B RID: 189515 RVA: 0x00CE7A2C File Offset: 0x00CE5C2C
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

		// Token: 0x0602E44C RID: 189516 RVA: 0x00CE7AAC File Offset: 0x00CE5CAC
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

		// Token: 0x0602E44D RID: 189517 RVA: 0x00CE7B7D File Offset: 0x00CE5D7D
		private void UpdateQuality(int quality)
		{
			this.StarLayout.RebuildLayout(quality);
		}

		// Token: 0x04018A4F RID: 100943
		private int RoleId;

		// Token: 0x04018A50 RID: 100944
		private LevelSequencePlayer LevelSequencePlayerInstance;

		// Token: 0x04018A51 RID: 100945
		private SimpleGenericLayout StarLayout;
	}
}
