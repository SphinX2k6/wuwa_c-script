using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E2E RID: 20014
	public class RoguelikeSkillDesc : UiPanelBase
	{
		// Token: 0x060339B8 RID: 211384 RVA: 0x00C13964 File Offset: 0x00C11B64
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

		// Token: 0x060339B9 RID: 211385 RVA: 0x00C13A0F File Offset: 0x00C11C0F
		protected override void OnStart()
		{
			this.Refresh();
		}

		// Token: 0x060339BA RID: 211386 RVA: 0x00C13A18 File Offset: 0x00C11C18
		public void Refresh()
		{
			if (this.Data == null)
			{
				return;
			}
			RogueTalentTreeDesc? rogueTalentTreeDescConfig = RoguelikeConfig.Instance.GetRogueTalentTreeDescConfig(this.Data.Value.Describe);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), rogueTalentTreeDescConfig.Value.BaseDesc, rogueTalentTreeDescConfig.Value.Params().ToArray<string>());
			if (this.Index % 2 == 1)
			{
				base.GetSprite(2).useChangeColor = true;
			}
		}

		// Token: 0x0401B5F6 RID: 112118
		public RogueTalentTree? Data;

		// Token: 0x0401B5F7 RID: 112119
		public int Index;

		// Token: 0x0200AFE0 RID: 45024
		private class ERoguelikeSkillDescDefine
		{
			// Token: 0x04035654 RID: 218708
			public const int TexIcon = 0;

			// Token: 0x04035655 RID: 218709
			public const int TxtTitle = 1;

			// Token: 0x04035656 RID: 218710
			public const int SpriteBg = 2;

			// Token: 0x04035657 RID: 218711
			public const int TxtNum = 3;
		}
	}
}
