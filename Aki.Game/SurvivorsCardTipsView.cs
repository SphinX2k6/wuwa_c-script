using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020020B5 RID: 8373
public class SurvivorsCardTipsView : UiViewBase
{
	// Token: 0x0601498B RID: 84363 RVA: 0x006006DD File Offset: 0x005FE8DD
	[NullableContext(1)]
	public SurvivorsCardTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601498C RID: 84364 RVA: 0x006006E8 File Offset: 0x005FE8E8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickCloseBtn))
		};
	}

	// Token: 0x0601498D RID: 84365 RVA: 0x0060074F File Offset: 0x005FE94F
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0601498E RID: 84366 RVA: 0x00600758 File Offset: 0x005FE958
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsCardTipsView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsCardTipsView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601498F RID: 84367 RVA: 0x0060079C File Offset: 0x005FE99C
	protected override void OnStart()
	{
		object openParam = this.OpenParam;
		if (openParam != null)
		{
			SurvivorsRogueItemCard survivorsRogueItemCard = openParam as SurvivorsRogueItemCard;
			if (survivorsRogueItemCard != null)
			{
				SurvivorsRogueCardBase cardItem = this.CardItem;
				if (cardItem == null)
				{
					return;
				}
				cardItem.Apply(survivorsRogueItemCard);
				return;
			}
			else
			{
				SurvivorsRogueCharacterCard survivorsRogueCharacterCard = openParam as SurvivorsRogueCharacterCard;
				if (survivorsRogueCharacterCard != null)
				{
					SurvivorsRogueCardBase cardItem2 = this.CardItem;
					if (cardItem2 == null)
					{
						return;
					}
					cardItem2.Apply(survivorsRogueCharacterCard);
					return;
				}
				else
				{
					SurvivorsRogueWeaponCard survivorsRogueWeaponCard = openParam as SurvivorsRogueWeaponCard;
					if (survivorsRogueWeaponCard != null)
					{
						SurvivorsRogueCardBase cardItem3 = this.CardItem;
						if (cardItem3 == null)
						{
							return;
						}
						cardItem3.Apply(survivorsRogueWeaponCard);
					}
				}
			}
		}
	}

	// Token: 0x0400AF05 RID: 44805
	[Nullable(2)]
	private SurvivorsRogueCardBase CardItem;
}
