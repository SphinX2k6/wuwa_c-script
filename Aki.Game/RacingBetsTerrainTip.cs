using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x0200273A RID: 10042
public class RacingBetsTerrainTip : UiViewBase
{
	// Token: 0x060149AC RID: 84396 RVA: 0x00536F92 File Offset: 0x00535192
	[NullableContext(1)]
	public RacingBetsTerrainTip(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060149AD RID: 84397 RVA: 0x00536F9B File Offset: 0x0053519B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x060149AE RID: 84398 RVA: 0x00536FD4 File Offset: 0x005351D4
	protected override void OnBeforeShow()
	{
		object[] array = this.OpenParam as object[];
		if (array == null || array.Length < 3)
		{
			return;
		}
		int organId = (int)array[0];
		int id = (int)array[1];
		RacingBetsOrgan? organConfig = RacingBetsConfig.Instance.GetOrganConfig(organId);
		DangoData dangoData = DangoManager.Instance.GetDangoData(id);
		base.SetTextureShowUntilLoaded(dangoData.IconAttack, base.GetTexture(0), delegate(bool _)
		{
			UUITexture texture = base.GetTexture(0);
			if (texture == null)
			{
				return;
			}
			texture.SetSizeFromTexture();
		});
		string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(organConfig.Value.Name);
		string multiTextByKey2 = TextConfig.Instance.GetMultiTextByKey(organConfig.Value.ActivateDesc);
		string multiText = TextConfig.Instance.GetMultiText("Dango_InGame_SkillActivated", new string[]
		{
			multiTextByKey,
			multiTextByKey2
		});
		base.GetText(1).SetText(multiText, true);
	}

	// Token: 0x060149AF RID: 84399 RVA: 0x005370AA File Offset: 0x005352AA
	protected override void OnAfterPlayStartSequence()
	{
		TimerSystem.Instance.Next(delegate(float _)
		{
			object[] array = this.OpenParam as object[];
			if (array == null || array.Length < 3)
			{
				return;
			}
			base.CloseMe(null);
			CustomPromise<UniTaskVoid> customPromise = array[2] as CustomPromise<UniTaskVoid>;
			if (customPromise == null)
			{
				return;
			}
			customPromise.SetResult(default(UniTaskVoid));
		}, null, null);
	}

	// Token: 0x02008DB0 RID: 36272
	private class EComponent
	{
		// Token: 0x0402DFE6 RID: 188390
		public const int TerrainIcon = 0;

		// Token: 0x0402DFE7 RID: 188391
		public const int TerrainText = 1;
	}
}
