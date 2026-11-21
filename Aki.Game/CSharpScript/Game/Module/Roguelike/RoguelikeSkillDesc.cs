using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DF7 RID: 15863
	public class RoguelikeSkillDesc : UiPanelBase
	{
		// Token: 0x06028823 RID: 165923 RVA: 0x00B5CE98 File Offset: 0x00B5B098
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06028824 RID: 165924 RVA: 0x00B5CF43 File Offset: 0x00B5B143
		protected override void OnStart()
		{
			this.Refresh();
		}

		// Token: 0x06028825 RID: 165925 RVA: 0x00B5CF4C File Offset: 0x00B5B14C
		public void Refresh()
		{
			if (this.Data == null)
			{
				return;
			}
			RogueTalentTreeDesc? rogueTalentTreeDescConfig = RoguelikeConfig.Instance.GetRogueTalentTreeDescConfig(this.Data.Value.Describe);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), rogueTalentTreeDescConfig.Value.BaseDesc, rogueTalentTreeDescConfig.Value.Params());
			if (this.Index % 2 == 1)
			{
				base.GetSprite(2).useChangeColor = true;
			}
		}

		// Token: 0x04015FC9 RID: 90057
		public RogueTalentTree? Data;

		// Token: 0x04015FCA RID: 90058
		public int Index;

		// Token: 0x02009A12 RID: 39442
		private class ERoguelikeSkillDescDefine
		{
			// Token: 0x04030084 RID: 196740
			public const int TexIcon = 0;

			// Token: 0x04030085 RID: 196741
			public const int TxtTitle = 1;

			// Token: 0x04030086 RID: 196742
			public const int SpriteBg = 2;

			// Token: 0x04030087 RID: 196743
			public const int TxtNum = 3;
		}
	}
}
