using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002027 RID: 8231
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SubPackageDownLoadMobileClearItem : GridProxyAbstract<ISubPackageDownLoadMobileClearData>
{
	// Token: 0x0601461E RID: 83486 RVA: 0x005F2224 File Offset: 0x005F0424
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0601461F RID: 83487 RVA: 0x005F2280 File Offset: 0x005F0480
	protected override UniTask OnBeforeStartAsync()
	{
		SubPackageDownLoadMobileClearItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SubPackageDownLoadMobileClearItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014620 RID: 83488 RVA: 0x005F22C3 File Offset: 0x005F04C3
	private SubPackageDownLoadMobileClearInfoItem InitInfoItem()
	{
		return new SubPackageDownLoadMobileClearInfoItem
		{
			OnClickToggleCallBack = this.OnClickToggleCallBack
		};
	}

	// Token: 0x06014621 RID: 83489 RVA: 0x005F22D8 File Offset: 0x005F04D8
	public override void Refresh(ISubPackageDownLoadMobileClearData data, bool isSelected, int gridIndex)
	{
		SubPackageDownLoadMobileClearTitleItem titleItem = this.TitleItem;
		if (titleItem != null)
		{
			titleItem.RefreshItem(data.TitleId);
		}
		SubPackageDownLoadMobileClearTitleItem titleItem2 = this.TitleItem;
		if (titleItem2 != null)
		{
			titleItem2.SetUiActive(true);
		}
		List<ISubPackageDownLoadMobileClearInfoItemData> list = new List<ISubPackageDownLoadMobileClearInfoItemData>();
		if (data.TitleId == 3)
		{
			ISubPackageDownLoadMobileClearInfoItemData item = new SubPackageDownLoadMobileClearInfoItemData
			{
				Type = ESubPackageDownLoadPackageType.OptionalPlot,
				HaveVideoCanClear = data.HaveVideoCanClear
			};
			list.Add(item);
		}
		else
		{
			if (data.TitleId == 2)
			{
				using (List<int>.Enumerator enumerator = (data.SceneIdList ?? new List<int>()).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						int value = enumerator.Current;
						ISubPackageDownLoadMobileClearInfoItemData item2 = new SubPackageDownLoadMobileClearInfoItemData
						{
							Type = ESubPackageDownLoadPackageType.OptionalScene,
							SceneId = new int?(value)
						};
						list.Add(item2);
					}
					goto IL_121;
				}
			}
			if (data.TitleId == 5)
			{
				foreach (string voiceLanguageCode in (data.VoiceLanguageCodeList ?? new List<string>()))
				{
					ISubPackageDownLoadMobileClearInfoItemData item3 = new SubPackageDownLoadMobileClearInfoItemData
					{
						Type = ESubPackageDownLoadPackageType.Voice,
						VoiceLanguageCode = voiceLanguageCode
					};
					list.Add(item3);
				}
			}
		}
		IL_121:
		GenericLayout<SubPackageDownLoadMobileClearInfoItem, ISubPackageDownLoadMobileClearInfoItemData> infoItemLayout = this.InfoItemLayout;
		if (infoItemLayout == null)
		{
			return;
		}
		infoItemLayout.RefreshByData(list, null, false);
	}

	// Token: 0x0400ACD7 RID: 44247
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, UUIItem> OnClickHelpBtnCallBack;

	// Token: 0x0400ACD8 RID: 44248
	[Nullable(2)]
	public Action<int?, bool, EToggleState, string> OnClickToggleCallBack;

	// Token: 0x0400ACD9 RID: 44249
	[Nullable(2)]
	private SubPackageDownLoadMobileClearTitleItem TitleItem;

	// Token: 0x0400ACDA RID: 44250
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SubPackageDownLoadMobileClearInfoItem, ISubPackageDownLoadMobileClearInfoItemData> InfoItemLayout;

	// Token: 0x0200831E RID: 33566
	[NullableContext(0)]
	private class ESubPackageDownLoadMobileClearItem
	{
		// Token: 0x0402A5EA RID: 173546
		public const int TitleItem = 0;

		// Token: 0x0402A5EB RID: 173547
		public const int InfoLayout = 1;

		// Token: 0x0402A5EC RID: 173548
		public const int InfoItem = 2;
	}
}
