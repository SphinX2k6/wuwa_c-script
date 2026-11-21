using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x02004977 RID: 18807
	public class ChallengeWantedAchieveFloatTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0602F281 RID: 193153 RVA: 0x00D24984 File Offset: 0x00D22B84
		[NullableContext(1)]
		public ChallengeWantedAchieveFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F282 RID: 193154 RVA: 0x00D24990 File Offset: 0x00D22B90
		protected override void SetMainText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
			UUIText text = base.GetText(0);
			IPromptParamHub data = this.Data;
			string value;
			if (data == null)
			{
				value = null;
			}
			else
			{
				TableTextArgNew mainTextObj = data.MainTextObj;
				value = ((mainTextObj != null) ? mainTextObj.TextKey : null);
			}
			if (!string.IsNullOrEmpty(value))
			{
				string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(this.Data.MainTextObj.TextKey);
				if (!StringUtils.IsBlank(configTextByKey))
				{
					string[] array = new string[param.Count];
					for (int i = 0; i < param.Count; i++)
					{
						string[] array2 = array;
						int num = i;
						object obj = param[i];
						array2[num] = ((obj != null) ? obj.ToString() : null);
					}
					if (text != null)
					{
						text.SetText(StringUtils.Format(configTextByKey, array), true);
					}
					if (text != null)
					{
						text.SetUIActive(true);
						return;
					}
				}
				else
				{
					text.SetUIActive(false);
				}
				return;
			}
			if (!StringUtils.IsBlank(this.TypeConfig.Value.GeneralText))
			{
				LguiUtil.Instance.SetLocalTextNew(text, this.TypeConfig.Value.GeneralText, param);
				if (text != null)
				{
					text.SetUIActive(true);
				}
				return;
			}
			if (text != null)
			{
				text.SetUIActive(false);
			}
		}

		// Token: 0x0602F283 RID: 193155 RVA: 0x00D24A94 File Offset: 0x00D22C94
		protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
			UUIText text = base.GetText(1);
			IPromptParamHub data = this.Data;
			string value;
			if (data == null)
			{
				value = null;
			}
			else
			{
				TableTextArgNew extraTextObj = data.ExtraTextObj;
				value = ((extraTextObj != null) ? extraTextObj.TextKey : null);
			}
			if (!string.IsNullOrEmpty(value))
			{
				string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(this.Data.ExtraTextObj.TextKey);
				if (!StringUtils.IsBlank(configTextByKey))
				{
					string[] array = new string[param.Count];
					for (int i = 0; i < param.Count; i++)
					{
						string[] array2 = array;
						int num = i;
						object obj = param[i];
						array2[num] = ((obj != null) ? obj.ToString() : null);
					}
					if (text != null)
					{
						text.SetText(StringUtils.Format(configTextByKey, array), true);
					}
					if (text != null)
					{
						text.SetUIActive(true);
						return;
					}
				}
				else
				{
					text.SetUIActive(false);
				}
				return;
			}
			if (!StringUtils.IsBlank(this.TypeConfig.Value.GeneralExtraText))
			{
				LguiUtil.Instance.SetLocalTextNew(text, this.TypeConfig.Value.GeneralExtraText, param);
				if (text != null)
				{
					text.SetUIActive(true);
				}
				return;
			}
			if (text != null)
			{
				text.SetUIActive(false);
			}
		}
	}
}
