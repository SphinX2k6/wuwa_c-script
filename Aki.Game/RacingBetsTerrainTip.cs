using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001C25 RID: 7205
public class RacingBetsTerrainTip : UiViewBase
{
	// Token: 0x06011E8E RID: 73358 RVA: 0x00545C9E File Offset: 0x00543E9E
	[NullableContext(1)]
	public RacingBetsTerrainTip(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011E8F RID: 73359 RVA: 0x00545CA7 File Offset: 0x00543EA7
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06011E90 RID: 73360 RVA: 0x00545CE0 File Offset: 0x00543EE0
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

	// Token: 0x06011E91 RID: 73361 RVA: 0x00545DB6 File Offset: 0x00543FB6
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

	// Token: 0x02007F38 RID: 32568
	private class EComponent
	{
		// Token: 0x040292FC RID: 168700
		public const int TerrainIcon = 0;

		// Token: 0x040292FD RID: 168701
		public const int TerrainText = 1;
	}
}
