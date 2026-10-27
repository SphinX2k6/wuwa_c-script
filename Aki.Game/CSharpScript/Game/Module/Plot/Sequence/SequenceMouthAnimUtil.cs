using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence
{
	// Token: 0x02005019 RID: 20505
	[NullableContext(2)]
	[Nullable(0)]
	public static class SequenceMouthAnimUtil
	{
		// Token: 0x060347B2 RID: 214962 RVA: 0x00C5C9D8 File Offset: 0x00C5ABD8
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

		// Token: 0x060347B3 RID: 214963 RVA: 0x00C5CA10 File Offset: 0x00C5AC10
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

		// Token: 0x060347B4 RID: 214964 RVA: 0x00C5CA64 File Offset: 0x00C5AC64
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

		// Token: 0x060347B5 RID: 214965 RVA: 0x00C5CAC4 File Offset: 0x00C5ACC4
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
