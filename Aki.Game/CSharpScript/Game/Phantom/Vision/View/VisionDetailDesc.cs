using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Phantom.Vision.View
{
	// Token: 0x020045FD RID: 17917
	[NullableContext(1)]
	[Nullable(0)]
	public class VisionDetailDesc
	{
		// Token: 0x0602E32D RID: 189229 RVA: 0x00AAE5F5 File Offset: 0x00AAC7F5
		public void SetNeedCheckChangeColor(bool state)
		{
			this.NeedCheckChangeColor = state;
		}

		// Token: 0x0602E32E RID: 189230 RVA: 0x00AAE5FE File Offset: 0x00AAC7FE
		public bool GetNeedCheckChangeColor()
		{
			return this.NeedCheckChangeColor;
		}

		// Token: 0x0602E32F RID: 189231 RVA: 0x00AAE606 File Offset: 0x00AAC806
		public bool GetNeedWarn()
		{
			return this.EquipSameMonster || this.EquipOverNeed;
		}

		// Token: 0x0602E330 RID: 189232 RVA: 0x00AAE618 File Offset: 0x00AAC818
		public bool GetIsFetterData()
		{
			return this.FetterId > 0;
		}

		// Token: 0x0602E331 RID: 189233 RVA: 0x00AAE624 File Offset: 0x00AAC824
		public static List<VisionDetailDesc> CreateEmptySkillDescData()
		{
			return new List<VisionDetailDesc>
			{
				new VisionDetailDesc
				{
					TitleItemShowState = true,
					Title = (ConfigMultiTextLang.GetLocalTextNew("VisionSkillTitle", null) ?? ""),
					EmptyState = true,
					EmptyText = (ConfigMultiTextLang.GetLocalTextNew("MainVisionEmpty", null) ?? ""),
					TitleType = 0
				}
			};
		}

		// Token: 0x0602E332 RID: 189234 RVA: 0x00AAE68C File Offset: 0x00AAC88C
		public static List<VisionDetailDesc> CreateEmptyFetterDescData()
		{
			return new List<VisionDetailDesc>
			{
				new VisionDetailDesc
				{
					TitleItemShowState = true,
					Title = (ConfigMultiTextLang.GetLocalTextNew("VisionFetterTitle", null) ?? ""),
					EmptyState = true,
					EmptyText = (ConfigMultiTextLang.GetLocalTextNew("FetterEmpty", null) ?? ""),
					TitleType = 1
				}
			};
		}

		// Token: 0x0602E333 RID: 189235 RVA: 0x00AAE6F4 File Offset: 0x00AAC8F4
		public static List<VisionDetailDesc> CreateSameMonsterTips()
		{
			return new List<VisionDetailDesc>
			{
				new VisionDetailDesc
				{
					Title = (ConfigMultiTextLang.GetLocalTextNew("VisionFetterTitle", null) ?? ""),
					EquipSameMonster = true,
					TitleItemShowState = false
				}
			};
		}

		// Token: 0x0602E334 RID: 189236 RVA: 0x00AAE73C File Offset: 0x00AAC93C
		public static List<VisionDetailDesc> CreateOverNeedTips()
		{
			return new List<VisionDetailDesc>
			{
				new VisionDetailDesc
				{
					Title = (ConfigMultiTextLang.GetLocalTextNew("VisionFetterTitle", null) ?? ""),
					EquipOverNeed = true,
					TitleItemShowState = false
				}
			};
		}

		// Token: 0x0602E335 RID: 189237 RVA: 0x00AAE784 File Offset: 0x00AAC984
		public static List<VisionDetailDesc> ConvertVisionSkillDescToDescData(PhantomSkill data, int level, bool ifMainPosition, bool ifPreview, int quality)
		{
			List<VisionDetailDesc> list = new List<VisionDetailDesc>();
			VisionDetailDesc visionDetailDesc = new VisionDetailDesc();
			visionDetailDesc.TitleItemShowState = true;
			visionDetailDesc.SkillConfig = new PhantomSkill?(data);
			visionDetailDesc.Level = level;
			visionDetailDesc.Quality = quality;
			visionDetailDesc.IfMainPosition = (ifMainPosition && !ifPreview);
			visionDetailDesc.NeedActiveState = true;
			if (ifMainPosition && !ifPreview)
			{
				visionDetailDesc.GreenActiveState = true;
			}
			else
			{
				visionDetailDesc.GreenActiveState = false;
			}
			if (data.IfCounterSkill)
			{
				visionDetailDesc.JumpCallBack = new Action(VisionDetailDesc.<ConvertVisionSkillDescToDescData>g__callback|32_0);
				visionDetailDesc.Title = (ConfigMultiTextLang.GetLocalTextNew("VisionCounterSkillText", null) ?? "");
			}
			else
			{
				visionDetailDesc.Title = (ConfigMultiTextLang.GetLocalTextNew("VisionSkillTitle", null) ?? "");
			}
			list.Add(visionDetailDesc);
			return list;
		}

		// Token: 0x0602E336 RID: 189238 RVA: 0x00AAE844 File Offset: 0x00AACA44
		public static List<VisionDetailDesc> ConvertVisionFetterDataToDetailDescData(List<VisionFetterData> data, bool ifEquipSameMonster, bool? ifEquipOverNeed = null, [Nullable(2)] Action jumpCallBack = null)
		{
			List<VisionDetailDesc> list = new List<VisionDetailDesc>();
			int count = data.Count;
			for (int i = 0; i < count; i++)
			{
				VisionDetailDesc visionDetailDesc = new VisionDetailDesc();
				if (i >= 1)
				{
					visionDetailDesc.TitleItemShowState = false;
				}
				visionDetailDesc.Title = (ConfigMultiTextLang.GetLocalTextNew("VisionFetterTitle", null) ?? "");
				visionDetailDesc.NeedActiveState = true;
				visionDetailDesc.NewState = data[i].NewAdd;
				visionDetailDesc.EquipSameMonster = ifEquipSameMonster;
				visionDetailDesc.EquipOverNeed = ifEquipOverNeed.GetValueOrDefault();
				if (data[i].ActiveState || data[i].NewAdd)
				{
					visionDetailDesc.GreenActiveState = true;
				}
				else
				{
					visionDetailDesc.GreenActiveState = false;
				}
				visionDetailDesc.FetterGroupId = data[i].FetterGroupId;
				visionDetailDesc.FetterId = data[i].FetterId;
				visionDetailDesc.FetterData = data[i];
				visionDetailDesc.JumpCallBack = jumpCallBack;
				list.Add(visionDetailDesc);
			}
			return list;
		}

		// Token: 0x0602E338 RID: 189240 RVA: 0x00AAE984 File Offset: 0x00AACB84
		[CompilerGenerated]
		internal static void <ConvertVisionSkillDescToDescData>g__callback|32_0()
		{
			HelpController.Instance.OpenHelpById(59);
		}

		// Token: 0x04018CAD RID: 101549
		public string Title = "";

		// Token: 0x04018CAE RID: 101550
		public bool TitleItemShowState = true;

		// Token: 0x04018CAF RID: 101551
		[Nullable(2)]
		public Action JumpCallBack;

		// Token: 0x04018CB0 RID: 101552
		public bool NeedActiveState;

		// Token: 0x04018CB1 RID: 101553
		public bool GreenActiveState;

		// Token: 0x04018CB2 RID: 101554
		public bool NewState;

		// Token: 0x04018CB3 RID: 101555
		public int FetterId;

		// Token: 0x04018CB4 RID: 101556
		[Nullable(2)]
		public VisionFetterData FetterData;

		// Token: 0x04018CB5 RID: 101557
		public bool IfMainPosition;

		// Token: 0x04018CB6 RID: 101558
		public bool EmptyState;

		// Token: 0x04018CB7 RID: 101559
		public string EmptyText = "";

		// Token: 0x04018CB8 RID: 101560
		public string EmptyContentText = "";

		// Token: 0x04018CB9 RID: 101561
		public PhantomSkill? SkillConfig;

		// Token: 0x04018CBA RID: 101562
		public int Level;

		// Token: 0x04018CBB RID: 101563
		public int FetterGroupId;

		// Token: 0x04018CBC RID: 101564
		private bool NeedCheckChangeColor = true;

		// Token: 0x04018CBD RID: 101565
		public bool DoNotNeedCheckSimplyState;

		// Token: 0x04018CBE RID: 101566
		public bool NeedSimplyStateChangeAnimation;

		// Token: 0x04018CBF RID: 101567
		public bool AnimationState = true;

		// Token: 0x04018CC0 RID: 101568
		public int Quality;

		// Token: 0x04018CC1 RID: 101569
		public int TitleType = -1;

		// Token: 0x04018CC2 RID: 101570
		public bool EquipSameMonster;

		// Token: 0x04018CC3 RID: 101571
		public bool EquipOverNeed;

		// Token: 0x04018CC4 RID: 101572
		public bool CompareState;
	}
}
