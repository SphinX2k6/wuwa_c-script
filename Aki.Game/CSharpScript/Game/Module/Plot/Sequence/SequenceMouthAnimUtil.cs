using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence
{
	// Token: 0x02003FE3 RID: 16355
	[NullableContext(2)]
	[Nullable(0)]
	public static class SequenceMouthAnimUtil
	{
		// Token: 0x06029655 RID: 169557 RVA: 0x00BA7F24 File Offset: 0x00BA6124
		public static string GetSequenceMouthAnimKey(ITalkItem talkItem)
		{
			if (!SequenceMouthAnimUtil.ShouldApplySequenceMouthAnim(talkItem))
			{
				return null;
			}
			if (!StringUtils.IsEmpty(talkItem.PlotLineKey))
			{
				return talkItem.PlotLineKey;
			}
			if (!StringUtils.IsEmpty(talkItem.TidTalk))
			{
				return talkItem.TidTalk;
			}
			return null;
		}

		// Token: 0x06029656 RID: 169558 RVA: 0x00BA7F5C File Offset: 0x00BA615C
		[return: Nullable(1)]
		public static List<int> GetSequenceMouthAnimSpeakerIds(ITalkItem talkItem, TArray<int> unisonIdList = null)
		{
			List<int> list = new List<int>();
			SequenceMouthAnimUtil.AddMouthAnimSpeakerId(list, (talkItem != null) ? talkItem.WhoId : null);
			if (unisonIdList != null)
			{
				for (int i = 0; i < unisonIdList.Num(); i++)
				{
					SequenceMouthAnimUtil.AddMouthAnimSpeakerId(list, new int?(unisonIdList.Get(i)));
				}
			}
			return list;
		}

		// Token: 0x06029657 RID: 169559 RVA: 0x00BA7FB0 File Offset: 0x00BA61B0
		private static bool ShouldApplySequenceMouthAnim(ITalkItem talkItem)
		{
			if (talkItem == null || !talkItem.PlayVoice.GetValueOrDefault())
			{
				return false;
			}
			ITalkItemDialog talkItemDialog = talkItem as ITalkItemDialog;
			if (talkItemDialog == null)
			{
				return true;
			}
			ITalkItemStyle style = talkItemDialog.Style;
			return (style == null || style.Type > ETalkItemStyle.InnerVoice) && !talkItemDialog.NoMouthAnim.GetValueOrDefault();
		}

		// Token: 0x06029658 RID: 169560 RVA: 0x00BA8010 File Offset: 0x00BA6210
		[NullableContext(1)]
		private static void AddMouthAnimSpeakerId(List<int> idList, int? id)
		{
			if (id != null)
			{
				int? num = id;
				int num2 = 0;
				if (!(num.GetValueOrDefault() <= num2 & num != null) && !idList.Contains(id.Value))
				{
					idList.Add(id.Value);
					return;
				}
			}
		}
	}
}
