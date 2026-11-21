using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001C15 RID: 7189
public class RacingBetsDangoSkillTip : UiViewBase
{
	// Token: 0x06011DB8 RID: 73144 RVA: 0x0054043C File Offset: 0x0053E63C
	[NullableContext(1)]
	public RacingBetsDangoSkillTip(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011DB9 RID: 73145 RVA: 0x00540445 File Offset: 0x0053E645
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06011DBA RID: 73146 RVA: 0x00540480 File Offset: 0x0053E680
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

	// Token: 0x06011DBB RID: 73147 RVA: 0x005404E4 File Offset: 0x0053E6E4
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

	// Token: 0x02007F10 RID: 32528
	private enum EComponent
	{
		// Token: 0x040291F1 RID: 168433
		SkillIcon,
		// Token: 0x040291F2 RID: 168434
		SkillText
	}
}
