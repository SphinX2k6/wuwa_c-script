using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000608 RID: 1544
[NullableContext(2)]
[Nullable(0)]
internal class DesRightBuffGridItem : GridProxyAbstract<int>
{
	// Token: 0x06004822 RID: 18466 RVA: 0x001869FC File Offset: 0x00184BFC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06004823 RID: 18467 RVA: 0x00186B05 File Offset: 0x00184D05
	protected override void OnStart()
	{
		if (this.RootItem != null)
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}
	}

	// Token: 0x06004824 RID: 18468 RVA: 0x00186B20 File Offset: 0x00184D20
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.DeTermId = data;
		BabelTowerDeTerm? config = ConfigBabelTowerDeTermById.GetConfig(data, true);
		if (config == null)
		{
			return;
		}
		BabelTowerDeTerm value = config.Value;
		UUIText text = base.GetText(3);
		if (text != null)
		{
			LguiUtil.Instance.SetLocalTextNew(text, value.DesText, Array.Empty<object>());
		}
		UUIText text2 = base.GetText(4);
		if (text2 != null)
		{
			text2.SetText(value.Star.ToString() ?? "", true);
		}
		UUITexture texture = base.GetTexture(2);
		if (texture != null)
		{
			base.SetTextureByPath(value.Texture, texture, null, null);
		}
		UUITexture texture2 = base.GetTexture(1);
		if (texture2 != null)
		{
			texture2.SetUIActive(gridIndex % 2 == 0);
		}
	}

	// Token: 0x06004825 RID: 18469 RVA: 0x00186BDC File Offset: 0x00184DDC
	public void PlayStartSequence()
	{
		if (this.LevelSequencePlayer != null)
		{
			this.LevelSequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
		}
	}

	// Token: 0x06004826 RID: 18470 RVA: 0x00186C0C File Offset: 0x00184E0C
	public void PlayCloseSequence()
	{
		if (this.LevelSequencePlayer != null)
		{
			this.LevelSequencePlayer.PlayOrReplaySequenceByName("Close", false, null);
		}
	}

	// Token: 0x06004827 RID: 18471 RVA: 0x00186C3B File Offset: 0x00184E3B
	private void OnClickBtn()
	{
		Action<int> onClickCallBack = this.OnClickCallBack;
		if (onClickCallBack == null)
		{
			return;
		}
		onClickCallBack(this.DeTermId);
	}

	// Token: 0x0400363C RID: 13884
	public int DeTermId;

	// Token: 0x0400363D RID: 13885
	public Action<int> OnClickCallBack;

	// Token: 0x0400363E RID: 13886
	public Action<int, bool> OnBuffStateChange;

	// Token: 0x0400363F RID: 13887
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0200689E RID: 26782
	[NullableContext(0)]
	private class EBuffItemSubComponent
	{
		// Token: 0x040227AA RID: 141226
		public const int BuffItemRoot = 0;

		// Token: 0x040227AB RID: 141227
		public const int TexBg = 1;

		// Token: 0x040227AC RID: 141228
		public const int TexIcon = 2;

		// Token: 0x040227AD RID: 141229
		public const int TxtDesc = 3;

		// Token: 0x040227AE RID: 141230
		public const int TxtNum = 4;
	}
}
