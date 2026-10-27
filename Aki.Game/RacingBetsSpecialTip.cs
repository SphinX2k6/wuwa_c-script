using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Dango.DangoLogic;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02002739 RID: 10041
public class RacingBetsSpecialTip : UiViewBase
{
	// Token: 0x060149A8 RID: 84392 RVA: 0x00536E45 File Offset: 0x00535045
	[NullableContext(1)]
	public RacingBetsSpecialTip(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060149A9 RID: 84393 RVA: 0x00536E4E File Offset: 0x0053504E
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x060149AA RID: 84394 RVA: 0x00536E88 File Offset: 0x00535088
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

	// Token: 0x060149AB RID: 84395 RVA: 0x00536F54 File Offset: 0x00535154
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

	// Token: 0x02008DAF RID: 36271
	private class EComponent
	{
		// Token: 0x0402DFE4 RID: 188388
		public const int SpecialIcon = 0;

		// Token: 0x0402DFE5 RID: 188389
		public const int SpecialText = 1;
	}
}
