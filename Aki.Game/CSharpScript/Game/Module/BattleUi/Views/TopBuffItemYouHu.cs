using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E29 RID: 20009
	public class TopBuffItemYouHu : TopBuffItem
	{
		// Token: 0x06032559 RID: 206169 RVA: 0x00E1C688 File Offset: 0x00E1A888
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603255A RID: 206170 RVA: 0x00E1C6D0 File Offset: 0x00E1A8D0
		public void RefreshByTag(int tagId)
		{
			if (this.TagId == tagId)
			{
				return;
			}
			this.TagId = tagId;
			string resourceId;
			if (!TopBuffItemYouHu.Tag2IconMap.TryGetValue(tagId, out resourceId))
			{
				return;
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			this.SetIcon(resourcePath);
		}

		// Token: 0x0603255B RID: 206171 RVA: 0x00E1C711 File Offset: 0x00E1A911
		[NullableContext(2)]
		public void SetIcon(string iconPath)
		{
			base.GetTexture(0).SetUIActive(false);
			if (string.IsNullOrEmpty(iconPath))
			{
				return;
			}
			this.LoadIconId = ResourceSystem.Instance.LoadAsync<UTexture>(iconPath, delegate([Nullable(2)] UTexture skillIconTexture, string _)
			{
				this.LoadIconId = -1;
				if (skillIconTexture == null)
				{
					return;
				}
				UUITexture texture = base.GetTexture(0);
				if (texture == null)
				{
					return;
				}
				texture.SetUIActive(true);
				texture.SetTexture(skillIconTexture);
			}, 103, "js_undefined");
		}

		// Token: 0x0603255C RID: 206172 RVA: 0x00E1C74D File Offset: 0x00E1A94D
		protected override void OnBeforeDestroyImplement()
		{
			base.OnBeforeDestroyImplement();
			if (this.LoadIconId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadIconId);
				this.LoadIconId = -1;
			}
		}

		// Token: 0x0603255E RID: 206174 RVA: 0x00E1C780 File Offset: 0x00E1A980
		// Note: this type is marked as 'beforefieldinit'.
		static TopBuffItemYouHu()
		{
			Dictionary<int, string> dictionary = new Dictionary<int, string>();
			int key = GameplayTagDefine.EGameplayTagId["角色.R2T1YouHuMd10011.逻辑.底奖.如意"];
			dictionary[key] = "T_IconYouhuBuff05";
			int key2 = GameplayTagDefine.EGameplayTagId["角色.R2T1YouHuMd10011.逻辑.底奖.编钟"];
			dictionary[key2] = "T_IconYouhuBuff01";
			int key3 = GameplayTagDefine.EGameplayTagId["角色.R2T1YouHuMd10011.逻辑.底奖.面具"];
			dictionary[key3] = "T_IconYouhuBuff04";
			int key4 = GameplayTagDefine.EGameplayTagId["角色.R2T1YouHuMd10011.逻辑.底奖.鼎"];
			dictionary[key4] = "T_IconYouhuBuff02";
			TopBuffItemYouHu.Tag2IconMap = dictionary;
		}

		// Token: 0x0401AADE RID: 109278
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<int, string> Tag2IconMap;

		// Token: 0x0401AADF RID: 109279
		private int TagId;

		// Token: 0x0401AAE0 RID: 109280
		private int LoadIconId;

		// Token: 0x0200ABD2 RID: 43986
		private enum EChildType
		{
			// Token: 0x040352D1 RID: 217809
			IconTexture
		}
	}
}
