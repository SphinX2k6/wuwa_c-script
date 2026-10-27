using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Mechanics;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x020064DC RID: 25820
	public class MatchThreeMechanicItemView : GridProxyAbstract<MechanicDisplayData>
	{
		// Token: 0x06040CE6 RID: 265446 RVA: 0x00FB2598 File Offset: 0x00FB0798
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

		// Token: 0x06040CE7 RID: 265447 RVA: 0x00FB26A4 File Offset: 0x00FB08A4
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

		// Token: 0x06040CE8 RID: 265448 RVA: 0x00FB2768 File Offset: 0x00FB0968
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

		// Token: 0x04021C30 RID: 138288
		private MechanicDisplayData? Data;

		// Token: 0x0200C70C RID: 50956
		private enum EComponent
		{
			// Token: 0x0403C223 RID: 246307
			BtnEnvEffect,
			// Token: 0x0403C224 RID: 246308
			SprIcon,
			// Token: 0x0403C225 RID: 246309
			TxtRemainTime,
			// Token: 0x0403C226 RID: 246310
			TxtGenerateNum,
			// Token: 0x0403C227 RID: 246311
			PnlRemainTime
		}
	}
}
