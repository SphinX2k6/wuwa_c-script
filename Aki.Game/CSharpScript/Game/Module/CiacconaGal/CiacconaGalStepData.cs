using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Plot;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BB2 RID: 19378
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalStepData
	{
		// Token: 0x06030612 RID: 198162 RVA: 0x00D7BD29 File Offset: 0x00D79F29
		public CiacconaGalStepData(CiacconaGalStep Config)
		{
			this.Config = Config;
		}

		// Token: 0x17006113 RID: 24851
		// (get) Token: 0x06030613 RID: 198163 RVA: 0x00D7BD38 File Offset: 0x00D79F38
		private CiacconaGalStep Config { get; }

		// Token: 0x17006114 RID: 24852
		// (get) Token: 0x06030614 RID: 198164 RVA: 0x00D7BD40 File Offset: 0x00D79F40
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17006115 RID: 24853
		// (get) Token: 0x06030615 RID: 198165 RVA: 0x00D7BD5C File Offset: 0x00D79F5C
		public ECiacconaGalStepType Type
		{
			get
			{
				return (ECiacconaGalStepType)this.Config.Type;
			}
		}

		// Token: 0x17006116 RID: 24854
		// (get) Token: 0x06030616 RID: 198166 RVA: 0x00D7BD78 File Offset: 0x00D79F78
		public string TalkTid
		{
			get
			{
				return this.Config.Content;
			}
		}

		// Token: 0x17006117 RID: 24855
		// (get) Token: 0x06030617 RID: 198167 RVA: 0x00D7BD94 File Offset: 0x00D79F94
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

		// Token: 0x17006118 RID: 24856
		// (get) Token: 0x06030618 RID: 198168 RVA: 0x00D7BDE8 File Offset: 0x00D79FE8
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

		// Token: 0x17006119 RID: 24857
		// (get) Token: 0x06030619 RID: 198169 RVA: 0x00D7BE74 File Offset: 0x00D7A074
		public string AudioEvent
		{
			get
			{
				return this.Config.Audio;
			}
		}

		// Token: 0x1700611A RID: 24858
		// (get) Token: 0x0603061A RID: 198170 RVA: 0x00D7BE90 File Offset: 0x00D7A090
		public string MusicState
		{
			get
			{
				return this.Config.MusicState;
			}
		}

		// Token: 0x1700611B RID: 24859
		// (get) Token: 0x0603061B RID: 198171 RVA: 0x00D7BEAC File Offset: 0x00D7A0AC
		public string AnimPath
		{
			get
			{
				return this.Config.Anim;
			}
		}

		// Token: 0x1700611C RID: 24860
		// (get) Token: 0x0603061C RID: 198172 RVA: 0x00D7BEC8 File Offset: 0x00D7A0C8
		public int TriggerSubEndingId
		{
			get
			{
				return this.Config.TriggerSubEnding;
			}
		}

		// Token: 0x1700611D RID: 24861
		// (get) Token: 0x0603061D RID: 198173 RVA: 0x00D7BEE4 File Offset: 0x00D7A0E4
		public int[] ChoiceIds
		{
			get
			{
				return this.Config.Choices();
			}
		}

		// Token: 0x1700611E RID: 24862
		// (get) Token: 0x0603061E RID: 198174 RVA: 0x00D7BF00 File Offset: 0x00D7A100
		public int NextStepId
		{
			get
			{
				return this.Config.Id + 1;
			}
		}

		// Token: 0x1700611F RID: 24863
		// (get) Token: 0x0603061F RID: 198175 RVA: 0x00D7BF20 File Offset: 0x00D7A120
		public int SubEndingId
		{
			get
			{
				return this.Config.TriggerSubEnding;
			}
		}

		// Token: 0x17006120 RID: 24864
		// (get) Token: 0x06030620 RID: 198176 RVA: 0x00D7BF3B File Offset: 0x00D7A13B
		public int TextAnimDefaultDuration
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x17006121 RID: 24865
		// (get) Token: 0x06030621 RID: 198177 RVA: 0x00D7BF3E File Offset: 0x00D7A13E
		// (set) Token: 0x06030622 RID: 198178 RVA: 0x00D7BF46 File Offset: 0x00D7A146
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

		// Token: 0x17006122 RID: 24866
		// (get) Token: 0x06030623 RID: 198179 RVA: 0x00D7BF50 File Offset: 0x00D7A150
		public bool HasText
		{
			get
			{
				return !string.IsNullOrEmpty(this.Config.Content);
			}
		}

		// Token: 0x04019A28 RID: 105000
		private int ChosenIdCache;
	}
}
