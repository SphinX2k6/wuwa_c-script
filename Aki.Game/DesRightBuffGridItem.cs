using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001154 RID: 4436
[NullableContext(2)]
[Nullable(0)]
internal class DesRightBuffGridItem : GridProxyAbstract<int>
{
	// Token: 0x0600748B RID: 29835 RVA: 0x0017DEB0 File Offset: 0x0017C0B0
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

	// Token: 0x0600748C RID: 29836 RVA: 0x0017DFB9 File Offset: 0x0017C1B9
	protected override void OnStart()
	{
		if (this.RootItem != null)
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}
	}

	// Token: 0x0600748D RID: 29837 RVA: 0x0017DFD4 File Offset: 0x0017C1D4
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

	// Token: 0x0600748E RID: 29838 RVA: 0x0017E090 File Offset: 0x0017C290
	public void PlayStartSequence()
	{
		if (this.LevelSequencePlayer != null)
		{
			this.LevelSequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
		}
	}

	// Token: 0x0600748F RID: 29839 RVA: 0x0017E0C0 File Offset: 0x0017C2C0
	public void PlayCloseSequence()
	{
		if (this.LevelSequencePlayer != null)
		{
			this.LevelSequencePlayer.PlayOrReplaySequenceByName("Close", false, null);
		}
	}

	// Token: 0x06007490 RID: 29840 RVA: 0x0017E0EF File Offset: 0x0017C2EF
	private void OnClickBtn()
	{
		Action<int> onClickCallBack = this.OnClickCallBack;
		if (onClickCallBack == null)
		{
			return;
		}
		onClickCallBack(this.DeTermId);
	}

	// Token: 0x040035A3 RID: 13731
	public int DeTermId;

	// Token: 0x040035A4 RID: 13732
	public Action<int> OnClickCallBack;

	// Token: 0x040035A5 RID: 13733
	public Action<int, bool> OnBuffStateChange;

	// Token: 0x040035A6 RID: 13734
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0200770F RID: 30479
	[NullableContext(0)]
	private class EBuffItemSubComponent
	{
		// Token: 0x04027469 RID: 160873
		public const int BuffItemRoot = 0;

		// Token: 0x0402746A RID: 160874
		public const int TexBg = 1;

		// Token: 0x0402746B RID: 160875
		public const int TexIcon = 2;

		// Token: 0x0402746C RID: 160876
		public const int TxtDesc = 3;

		// Token: 0x0402746D RID: 160877
		public const int TxtNum = 4;
	}
}
