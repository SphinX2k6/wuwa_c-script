using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x0200272A RID: 10026
public class RacingBetsDangoSkillTip : UiViewBase
{
	// Token: 0x060148D6 RID: 84182 RVA: 0x00531724 File Offset: 0x0052F924
	[NullableContext(1)]
	public RacingBetsDangoSkillTip(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060148D7 RID: 84183 RVA: 0x0053172D File Offset: 0x0052F92D
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x060148D8 RID: 84184 RVA: 0x00531768 File Offset: 0x0052F968
	protected override void OnBeforeShow()
	{
		object[] array = this.OpenParam as object[];
		if (array == null || array.Length < 2)
		{
			return;
		}
		int id = (int)array[0];
		DangoData dangoData = DangoManager.Instance.GetDangoData(id);
		base.SetTextureShowUntilLoaded(dangoData.IconAttack, base.GetTexture(0), null);
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(dangoData.GetDangoActiveSkillDesc(), true);
	}

	// Token: 0x060148D9 RID: 84185 RVA: 0x005317CC File Offset: 0x0052F9CC
	protected override void OnAfterPlayStartSequence()
	{
		TimerSystem.Instance.Next(delegate(float _)
		{
			object[] array = this.OpenParam as object[];
			if (array == null || array.Length < 2)
			{
				return;
			}
			UniTaskCompletionSource uniTaskCompletionSource = array[1] as UniTaskCompletionSource;
			base.CloseMe(null);
			if (uniTaskCompletionSource == null)
			{
				return;
			}
			uniTaskCompletionSource.TrySetResult();
		}, null, null);
	}

	// Token: 0x02008D88 RID: 36232
	private enum EComponent
	{
		// Token: 0x0402DEDB RID: 188123
		SkillIcon,
		// Token: 0x0402DEDC RID: 188124
		SkillText
	}
}
