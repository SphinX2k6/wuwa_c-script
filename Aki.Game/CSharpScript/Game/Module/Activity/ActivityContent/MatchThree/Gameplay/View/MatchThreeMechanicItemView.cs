using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Mechanics;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x0200545A RID: 21594
	public class MatchThreeMechanicItemView : GridProxyAbstract<MechanicDisplayData>
	{
		// Token: 0x060359AA RID: 219562 RVA: 0x00EF95C8 File Offset: 0x00EF77C8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClicked));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060359AB RID: 219563 RVA: 0x00EF96D4 File Offset: 0x00EF78D4
		public override void Refresh(MechanicDisplayData data, bool isSelected, int gridIndex)
		{
			this.Data = new MechanicDisplayData?(data);
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(data.ShowRemainTime);
			}
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(data.RemainRounds.ToString(), true);
			}
			UUIText text2 = base.GetText(3);
			if (text2 != null)
			{
				text2.SetUIActive(data.ShowRemainTime);
			}
			if (text2 != null)
			{
				text2.SetText(data.GenerateCount.ToString(), true);
			}
			UUISprite sprite = base.GetSprite(1);
			if (sprite == null)
			{
				return;
			}
			string item2 = MatchThreeGameplayDefine.GetPieceRes(data.TargetType).Item2;
			base.TrySetSpriteByPath((item2 == null) ? null : UiResourceConfig.Instance.GetResourcePath(item2), sprite, false, null, null);
		}

		// Token: 0x060359AC RID: 219564 RVA: 0x00EF9798 File Offset: 0x00EF7998
		private void OnClicked()
		{
			if (this.Data == null || this.Data.Value.EnvId <= 0)
			{
				return;
			}
			MatchThreeGameplayContext context = MatchThreeController.Instance.Context;
			if (context == null)
			{
				return;
			}
			ActivityMatchThreeController.Instance.OpenPopupInfoByLevel(context.LevelId, context.RoleId, true, 0, this.Data.Value.EnvId);
		}

		// Token: 0x0401C561 RID: 116065
		private MechanicDisplayData? Data;

		// Token: 0x0200B0F2 RID: 45298
		private enum EComponent
		{
			// Token: 0x04036B7E RID: 224126
			BtnEnvEffect,
			// Token: 0x04036B7F RID: 224127
			SprIcon,
			// Token: 0x04036B80 RID: 224128
			TxtRemainTime,
			// Token: 0x04036B81 RID: 224129
			TxtGenerateNum,
			// Token: 0x04036B82 RID: 224130
			PnlRemainTime
		}
	}
}
