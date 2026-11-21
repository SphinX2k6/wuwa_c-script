using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002125 RID: 8485
[Nullable(new byte[]
{
	0,
	1
})]
public class ExplanationItem : GridProxyAbstract<string>
{
	// Token: 0x06014CA8 RID: 85160 RVA: 0x0060B38C File Offset: 0x0060958C
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

	// Token: 0x06014CA9 RID: 85161 RVA: 0x0060B3F5 File Offset: 0x006095F5
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x06014CAA RID: 85162 RVA: 0x0060B408 File Offset: 0x00609608
	public override void OnSelected(bool fireEvent)
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("SelectIn", false, null, false);
	}

	// Token: 0x06014CAB RID: 85163 RVA: 0x0060B430 File Offset: 0x00609630
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

	// Token: 0x06014CAC RID: 85164 RVA: 0x0060B560 File Offset: 0x00609760
	public override void Clear()
	{
		this.LevelSequencePlayer.StopCurrentSequence(false, false);
		this.LevelSequencePlayer.PlayLevelSequenceByName("SelectOut", false, null, false);
	}

	// Token: 0x0400B151 RID: 45393
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x020083AA RID: 33706
	private class EExplanationComponentDefine
	{
		// Token: 0x0402A80B RID: 174091
		public const int TextTitle = 0;

		// Token: 0x0402A80C RID: 174092
		public const int TextContent = 1;
	}
}
