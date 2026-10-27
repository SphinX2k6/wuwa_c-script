using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui;
using CSharpScript.Launcher.Ui.HotFix;
using UnrealEngine;

namespace CSharpScript.Game.Module.Launcher.Action
{
	// Token: 0x02000032 RID: 50
	public class SubPackageDownLoadMobileClearItem : LaunchComponentsAction, IHotFixLayoutItem
	{
		// Token: 0x060001DD RID: 477 RVA: 0x0000A710 File Offset: 0x00008910
		[NullableContext(1)]
		public void SetRootActor(AActor actor)
		{
			base.SetRootActorLaunchComponentsAction(actor);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000A71C File Offset: 0x0000891C
		protected override void OnStart()
		{
			this.TitleItem = new SubPackageDownLoadMobileClearTitleItem();
			this.TitleItem.SetRootActorLaunchComponentsAction(base.GetItem(0).GetOwner());
			this.TitleItem.OnClickHelpBtnCallBack = this.OnClickHelpBtnCallBack;
			UUILayoutBase layout = base.GetLayout(1);
			AUIBaseActor gridActor = base.GetItem(2).GetOwner() as AUIBaseActor;
			this.InfoItemLayout = new HotFixLayout<SubPackageDownLoadMobileClearInfoItem, SubPackageDownLoadMobileClearInfoItemData>(layout, () => new SubPackageDownLoadMobileClearInfoItem
			{
				OnClickToggleCallBack = this.OnClickToggleCallBack
			}, gridActor);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000A790 File Offset: 0x00008990
		[NullableContext(1)]
		public virtual void Refresh(IHotFixLayoutData data)
		{
			ISubPackageDownLoadMobileClearData subPackageDownLoadMobileClearData = (ISubPackageDownLoadMobileClearData)data;
			SubPackageDownLoadMobileClearTitleItem titleItem = this.TitleItem;
			if (titleItem != null)
			{
				titleItem.RefreshItem(subPackageDownLoadMobileClearData.TitleId);
			}
			SubPackageDownLoadMobileClearTitleItem titleItem2 = this.TitleItem;
			if (titleItem2 != null)
			{
				titleItem2.SetActive(true);
			}
			List<SubPackageDownLoadMobileClearInfoItemData> list = new List<SubPackageDownLoadMobileClearInfoItemData>();
			if (subPackageDownLoadMobileClearData.TitleId == 3)
			{
				SubPackageDownLoadMobileClearInfoItemData item = new SubPackageDownLoadMobileClearInfoItemData
				{
					Type = ESubPackageDownLoadPackageType.OptionalPlot,
					HaveVideoCanClear = subPackageDownLoadMobileClearData.HaveVideoCanClear
				};
				list.Add(item);
			}
			else
			{
				if (subPackageDownLoadMobileClearData.TitleId == 2)
				{
					using (List<int>.Enumerator enumerator = (subPackageDownLoadMobileClearData.SceneIdList ?? new List<int>()).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							int value = enumerator.Current;
							SubPackageDownLoadMobileClearInfoItemData item2 = new SubPackageDownLoadMobileClearInfoItemData
							{
								Type = ESubPackageDownLoadPackageType.OptionalScene,
								SceneId = new int?(value)
							};
							list.Add(item2);
						}
						goto IL_12A;
					}
				}
				if (subPackageDownLoadMobileClearData.TitleId == 5)
				{
					foreach (string voiceLanguageCode in (subPackageDownLoadMobileClearData.VoiceLanguageCodeList ?? new List<string>()))
					{
						SubPackageDownLoadMobileClearInfoItemData item3 = new SubPackageDownLoadMobileClearInfoItemData
						{
							Type = ESubPackageDownLoadPackageType.Voice,
							VoiceLanguageCode = voiceLanguageCode
						};
						list.Add(item3);
					}
				}
			}
			IL_12A:
			HotFixLayout<SubPackageDownLoadMobileClearInfoItem, SubPackageDownLoadMobileClearInfoItemData> infoItemLayout = this.InfoItemLayout;
			if (infoItemLayout == null)
			{
				return;
			}
			infoItemLayout.RefreshByData(list);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000A8F4 File Offset: 0x00008AF4
		public void UnSelectItem()
		{
			SubPackageDownLoadMobileClearTitleItem titleItem = this.TitleItem;
			if (titleItem != null)
			{
				titleItem.UnSelectItem();
			}
			HotFixLayout<SubPackageDownLoadMobileClearInfoItem, SubPackageDownLoadMobileClearInfoItemData> infoItemLayout = this.InfoItemLayout;
			List<SubPackageDownLoadMobileClearInfoItem> list = ((infoItemLayout != null) ? infoItemLayout.GetLayoutItemList() : null) as List<SubPackageDownLoadMobileClearInfoItem>;
			if (list != null)
			{
				foreach (SubPackageDownLoadMobileClearInfoItem subPackageDownLoadMobileClearInfoItem in list)
				{
					subPackageDownLoadMobileClearInfoItem.UnSelectItem();
				}
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000A96C File Offset: 0x00008B6C
		public void SelectItem(int subIndex)
		{
			if (subIndex == 0)
			{
				SubPackageDownLoadMobileClearTitleItem titleItem = this.TitleItem;
				if (titleItem != null)
				{
					titleItem.SelectItem();
				}
				HotFixLayout<SubPackageDownLoadMobileClearInfoItem, SubPackageDownLoadMobileClearInfoItemData> infoItemLayout = this.InfoItemLayout;
				List<SubPackageDownLoadMobileClearInfoItem> list = ((infoItemLayout != null) ? infoItemLayout.GetLayoutItemList() : null) as List<SubPackageDownLoadMobileClearInfoItem>;
				if (list == null)
				{
					return;
				}
				using (List<SubPackageDownLoadMobileClearInfoItem>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						SubPackageDownLoadMobileClearInfoItem subPackageDownLoadMobileClearInfoItem = enumerator.Current;
						subPackageDownLoadMobileClearInfoItem.UnSelectItem();
					}
					return;
				}
			}
			SubPackageDownLoadMobileClearTitleItem titleItem2 = this.TitleItem;
			if (titleItem2 != null)
			{
				titleItem2.UnSelectItem();
			}
			HotFixLayout<SubPackageDownLoadMobileClearInfoItem, SubPackageDownLoadMobileClearInfoItemData> infoItemLayout2 = this.InfoItemLayout;
			SubPackageDownLoadMobileClearInfoItem subPackageDownLoadMobileClearInfoItem2 = ((infoItemLayout2 != null) ? infoItemLayout2.GetLayoutItemByIndex(subIndex - 1) : null) as SubPackageDownLoadMobileClearInfoItem;
			if (subPackageDownLoadMobileClearInfoItem2 == null)
			{
				return;
			}
			subPackageDownLoadMobileClearInfoItem2.SelectItem();
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000AA1C File Offset: 0x00008C1C
		public void OnClickItem(int subIndex)
		{
			if (subIndex == 0)
			{
				this.TitleItem.ClickItemOnGamePad();
				return;
			}
			HotFixLayout<SubPackageDownLoadMobileClearInfoItem, SubPackageDownLoadMobileClearInfoItemData> infoItemLayout = this.InfoItemLayout;
			SubPackageDownLoadMobileClearInfoItem subPackageDownLoadMobileClearInfoItem = ((infoItemLayout != null) ? infoItemLayout.GetLayoutItemByIndex(subIndex - 1) : null) as SubPackageDownLoadMobileClearInfoItem;
			if (subPackageDownLoadMobileClearInfoItem == null)
			{
				return;
			}
			subPackageDownLoadMobileClearInfoItem.ClickItemOnGamePad();
		}

		// Token: 0x040000DD RID: 221
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, UUIItem> OnClickHelpBtnCallBack;

		// Token: 0x040000DE RID: 222
		[Nullable(2)]
		public Action<int?, bool, EToggleState, string> OnClickToggleCallBack;

		// Token: 0x040000DF RID: 223
		[Nullable(2)]
		private SubPackageDownLoadMobileClearTitleItem TitleItem;

		// Token: 0x040000E0 RID: 224
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private HotFixLayout<SubPackageDownLoadMobileClearInfoItem, SubPackageDownLoadMobileClearInfoItemData> InfoItemLayout;

		// Token: 0x020002AD RID: 685
		private static class ESubPackageDownLoadMobileClearItem
		{
			// Token: 0x04000A86 RID: 2694
			public const int TitleItem = 0;

			// Token: 0x04000A87 RID: 2695
			public const int Layout = 1;

			// Token: 0x04000A88 RID: 2696
			public const int InfoItem = 2;
		}
	}
}
