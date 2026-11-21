using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Dango.DangoLogic;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001C24 RID: 7204
public class RacingBetsSpecialTip : UiViewBase
{
	// Token: 0x06011E8A RID: 73354 RVA: 0x00545B51 File Offset: 0x00543D51
	[NullableContext(1)]
	public RacingBetsSpecialTip(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011E8B RID: 73355 RVA: 0x00545B5A File Offset: 0x00543D5A
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06011E8C RID: 73356 RVA: 0x00545B94 File Offset: 0x00543D94
	protected override void OnBeforeShow()
	{
		object[] array = this.OpenParam as object[];
		if (array == null || array.Length < 3)
		{
			return;
		}
		int id = (int)array[0];
		DangoData dangoData = DangoManager.Instance.GetDangoData(id);
		base.SetTextureShowUntilLoaded(dangoData.Icon, base.GetTexture(0), null);
		int id2 = (int)array[1];
		DangoSkill? dangoSkillById = DangoConfig.Instance.GetDangoSkillById(id2);
		string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(dangoSkillById.Value.Name);
		string multiTextByKey2 = TextConfig.Instance.GetMultiTextByKey(dangoSkillById.Value.ActivateDesc);
		string multiText = TextConfig.Instance.GetMultiText("Dango_InGame_SkillActivated", new string[]
		{
			multiTextByKey,
			multiTextByKey2
		});
		base.GetText(1).SetText(multiText, true);
	}

	// Token: 0x06011E8D RID: 73357 RVA: 0x00545C60 File Offset: 0x00543E60
	protected override void OnAfterPlayStartSequence()
	{
		object[] array = this.OpenParam as object[];
		if (array == null || array.Length < 3)
		{
			return;
		}
		base.CloseMe(null);
		UniTaskCompletionSource<bool> uniTaskCompletionSource = array[2] as UniTaskCompletionSource<bool>;
		if (uniTaskCompletionSource == null)
		{
			return;
		}
		uniTaskCompletionSource.TrySetResult(true);
	}

	// Token: 0x02007F37 RID: 32567
	private class EComponent
	{
		// Token: 0x040292FA RID: 168698
		public const int SpecialIcon = 0;

		// Token: 0x040292FB RID: 168699
		public const int SpecialText = 1;
	}
}
