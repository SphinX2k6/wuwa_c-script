using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002B39 RID: 11065
public class SurvivorsCardTipsView : UiViewBase
{
	// Token: 0x06016F5A RID: 94042 RVA: 0x005D3B6D File Offset: 0x005D1D6D
	[NullableContext(1)]
	public SurvivorsCardTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016F5B RID: 94043 RVA: 0x005D3B78 File Offset: 0x005D1D78
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

	// Token: 0x06016F5C RID: 94044 RVA: 0x005D3BDF File Offset: 0x005D1DDF
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06016F5D RID: 94045 RVA: 0x005D3BE8 File Offset: 0x005D1DE8
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsCardTipsView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsCardTipsView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016F5E RID: 94046 RVA: 0x005D3C2C File Offset: 0x005D1E2C
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

	// Token: 0x0400AAFF RID: 43775
	[Nullable(2)]
	private SurvivorsRogueCardBase CardItem;
}
