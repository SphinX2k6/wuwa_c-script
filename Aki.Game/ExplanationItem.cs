using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002BA9 RID: 11177
[Nullable(new byte[]
{
	0,
	1
})]
public class ExplanationItem : GridProxyAbstract<string>
{
	// Token: 0x06017277 RID: 94839 RVA: 0x005DE7B8 File Offset: 0x005DC9B8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06017278 RID: 94840 RVA: 0x005DE821 File Offset: 0x005DCA21
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x06017279 RID: 94841 RVA: 0x005DE834 File Offset: 0x005DCA34
	public override void OnSelected(bool fireEvent)
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("SelectIn", false, null, false);
	}

	// Token: 0x0601727A RID: 94842 RVA: 0x005DE85C File Offset: 0x005DCA5C
	[NullableContext(1)]
	public override void Refresh(string data, bool isSelected, int gridIndex)
	{
		int num;
		if (!int.TryParse(data, out num))
		{
			return;
		}
		TermConfig? config = ConfigTermConfigById.GetConfig(num, true);
		if (config == null)
		{
			return;
		}
		TermConfig value = config.Value;
		object[] array2;
		if (value.Placeholder().Length != 0)
		{
			object[] array = value.Placeholder();
			array2 = array;
		}
		else
		{
			array2 = new object[0];
		}
		object[] args = array2;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 2);
		defaultInterpolatedStringHandler.AppendLiteral("Term");
		defaultInterpolatedStringHandler.AppendFormatted<int>(num);
		defaultInterpolatedStringHandler.AppendLiteral("_");
		defaultInterpolatedStringHandler.AppendFormatted("Title");
		string textStringId = defaultInterpolatedStringHandler.ToStringAndClear();
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 2);
		defaultInterpolatedStringHandler.AppendLiteral("Term");
		defaultInterpolatedStringHandler.AppendFormatted<int>(num);
		defaultInterpolatedStringHandler.AppendLiteral("_");
		defaultInterpolatedStringHandler.AppendFormatted("Desc");
		string textStringId2 = defaultInterpolatedStringHandler.ToStringAndClear();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textStringId, args);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId2, args);
		if (isSelected)
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("SelectIn", false, null, false);
			return;
		}
		this.LevelSequencePlayer.PlayLevelSequenceByName("SelectOut", false, null, false);
	}

	// Token: 0x0601727B RID: 94843 RVA: 0x005DE98C File Offset: 0x005DCB8C
	public override void Clear()
	{
		this.LevelSequencePlayer.StopCurrentSequence(false, false);
		this.LevelSequencePlayer.PlayLevelSequenceByName("SelectOut", false, null, false);
	}

	// Token: 0x0400AD4A RID: 44362
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02009167 RID: 37223
	private class EExplanationComponentDefine
	{
		// Token: 0x0402F106 RID: 192774
		public const int TextTitle = 0;

		// Token: 0x0402F107 RID: 192775
		public const int TextContent = 1;
	}
}
