using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Plot;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BD2 RID: 23506
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalStepData
	{
		// Token: 0x0603B6C7 RID: 243399 RVA: 0x00E2BA21 File Offset: 0x00E29C21
		public CiacconaGalStepData(CiacconaGalStep Config)
		{
			this.Config = Config;
		}

		// Token: 0x17008D41 RID: 36161
		// (get) Token: 0x0603B6C8 RID: 243400 RVA: 0x00E2BA30 File Offset: 0x00E29C30
		private CiacconaGalStep Config { get; }

		// Token: 0x17008D42 RID: 36162
		// (get) Token: 0x0603B6C9 RID: 243401 RVA: 0x00E2BA38 File Offset: 0x00E29C38
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17008D43 RID: 36163
		// (get) Token: 0x0603B6CA RID: 243402 RVA: 0x00E2BA54 File Offset: 0x00E29C54
		public ECiacconaGalStepType Type
		{
			get
			{
				return (ECiacconaGalStepType)this.Config.Type;
			}
		}

		// Token: 0x17008D44 RID: 36164
		// (get) Token: 0x0603B6CB RID: 243403 RVA: 0x00E2BA70 File Offset: 0x00E29C70
		public string TalkTid
		{
			get
			{
				return this.Config.Content;
			}
		}

		// Token: 0x17008D45 RID: 36165
		// (get) Token: 0x0603B6CC RID: 243404 RVA: 0x00E2BA8C File Offset: 0x00E29C8C
		public string Content
		{
			get
			{
				if (StringUtils.IsEmpty(this.Config.Content))
				{
					return string.Empty;
				}
				string flowConfigLocalText = PublicUtil.Instance.GetFlowConfigLocalText(this.Config.Content);
				return PlotModel.Instance.PlotTextReplacer.Replace(flowConfigLocalText, false);
			}
		}

		// Token: 0x17008D46 RID: 36166
		// (get) Token: 0x0603B6CD RID: 243405 RVA: 0x00E2BAE0 File Offset: 0x00E29CE0
		public string ImagePath
		{
			get
			{
				if (string.IsNullOrEmpty(this.Config.ImageMale))
				{
					return this.Config.ImageFemale;
				}
				if (string.IsNullOrEmpty(this.Config.ImageFemale))
				{
					return this.Config.ImageMale;
				}
				EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
				if (playerGender == EPlayerGender.Male)
				{
					return this.Config.ImageMale;
				}
				if (playerGender == EPlayerGender.Female)
				{
					return this.Config.ImageFemale;
				}
				return string.Empty;
			}
		}

		// Token: 0x17008D47 RID: 36167
		// (get) Token: 0x0603B6CE RID: 243406 RVA: 0x00E2BB6C File Offset: 0x00E29D6C
		public string AudioEvent
		{
			get
			{
				return this.Config.Audio;
			}
		}

		// Token: 0x17008D48 RID: 36168
		// (get) Token: 0x0603B6CF RID: 243407 RVA: 0x00E2BB88 File Offset: 0x00E29D88
		public string MusicState
		{
			get
			{
				return this.Config.MusicState;
			}
		}

		// Token: 0x17008D49 RID: 36169
		// (get) Token: 0x0603B6D0 RID: 243408 RVA: 0x00E2BBA4 File Offset: 0x00E29DA4
		public string AnimPath
		{
			get
			{
				return this.Config.Anim;
			}
		}

		// Token: 0x17008D4A RID: 36170
		// (get) Token: 0x0603B6D1 RID: 243409 RVA: 0x00E2BBC0 File Offset: 0x00E29DC0
		public int TriggerSubEndingId
		{
			get
			{
				return this.Config.TriggerSubEnding;
			}
		}

		// Token: 0x17008D4B RID: 36171
		// (get) Token: 0x0603B6D2 RID: 243410 RVA: 0x00E2BBDC File Offset: 0x00E29DDC
		public int[] ChoiceIds
		{
			get
			{
				return this.Config.Choices();
			}
		}

		// Token: 0x17008D4C RID: 36172
		// (get) Token: 0x0603B6D3 RID: 243411 RVA: 0x00E2BBF8 File Offset: 0x00E29DF8
		public int NextStepId
		{
			get
			{
				return this.Config.Id + 1;
			}
		}

		// Token: 0x17008D4D RID: 36173
		// (get) Token: 0x0603B6D4 RID: 243412 RVA: 0x00E2BC18 File Offset: 0x00E29E18
		public int SubEndingId
		{
			get
			{
				return this.Config.TriggerSubEnding;
			}
		}

		// Token: 0x17008D4E RID: 36174
		// (get) Token: 0x0603B6D5 RID: 243413 RVA: 0x00E2BC33 File Offset: 0x00E29E33
		public int TextAnimDefaultDuration
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x17008D4F RID: 36175
		// (get) Token: 0x0603B6D6 RID: 243414 RVA: 0x00E2BC36 File Offset: 0x00E29E36
		// (set) Token: 0x0603B6D7 RID: 243415 RVA: 0x00E2BC3E File Offset: 0x00E29E3E
		public int ChosenId
		{
			get
			{
				return this.ChosenIdCache;
			}
			set
			{
				this.ChosenIdCache = value;
			}
		}

		// Token: 0x17008D50 RID: 36176
		// (get) Token: 0x0603B6D8 RID: 243416 RVA: 0x00E2BC48 File Offset: 0x00E29E48
		public bool HasText
		{
			get
			{
				return !string.IsNullOrEmpty(this.Config.Content);
			}
		}

		// Token: 0x0401EF77 RID: 126839
		private int ChosenIdCache;
	}
}
