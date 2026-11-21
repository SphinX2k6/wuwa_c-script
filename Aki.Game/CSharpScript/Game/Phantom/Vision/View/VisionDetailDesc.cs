using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Phantom.Vision.View
{
	// Token: 0x02003526 RID: 13606
	[NullableContext(1)]
	[Nullable(0)]
	public class VisionDetailDesc
	{
		// Token: 0x06022A22 RID: 141858 RVA: 0x009DACE9 File Offset: 0x009D8EE9
		public void SetNeedCheckChangeColor(bool state)
		{
			this.NeedCheckChangeColor = state;
		}

		// Token: 0x06022A23 RID: 141859 RVA: 0x009DACF2 File Offset: 0x009D8EF2
		public bool GetNeedCheckChangeColor()
		{
			return this.NeedCheckChangeColor;
		}

		// Token: 0x06022A24 RID: 141860 RVA: 0x009DACFA File Offset: 0x009D8EFA
		public bool GetNeedWarn()
		{
			return this.EquipSameMonster || this.EquipOverNeed;
		}

		// Token: 0x06022A25 RID: 141861 RVA: 0x009DAD0C File Offset: 0x009D8F0C
		public bool GetIsFetterData()
		{
			return this.FetterId > 0;
		}

		// Token: 0x06022A26 RID: 141862 RVA: 0x009DAD18 File Offset: 0x009D8F18
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

		// Token: 0x06022A27 RID: 141863 RVA: 0x009DAD80 File Offset: 0x009D8F80
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

		// Token: 0x06022A28 RID: 141864 RVA: 0x009DADE8 File Offset: 0x009D8FE8
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

		// Token: 0x06022A29 RID: 141865 RVA: 0x009DAE30 File Offset: 0x009D9030
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

		// Token: 0x06022A2A RID: 141866 RVA: 0x009DAE78 File Offset: 0x009D9078
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

		// Token: 0x06022A2B RID: 141867 RVA: 0x009DAF38 File Offset: 0x009D9138
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

		// Token: 0x06022A2D RID: 141869 RVA: 0x009DB078 File Offset: 0x009D9278
		[CompilerGenerated]
		internal static void <ConvertVisionSkillDescToDescData>g__callback|32_0()
		{
			HelpController.Instance.OpenHelpById(59);
		}

		// Token: 0x040132EC RID: 78572
		public string Title = "";

		// Token: 0x040132ED RID: 78573
		public bool TitleItemShowState = true;

		// Token: 0x040132EE RID: 78574
		[Nullable(2)]
		public Action JumpCallBack;

		// Token: 0x040132EF RID: 78575
		public bool NeedActiveState;

		// Token: 0x040132F0 RID: 78576
		public bool GreenActiveState;

		// Token: 0x040132F1 RID: 78577
		public bool NewState;

		// Token: 0x040132F2 RID: 78578
		public int FetterId;

		// Token: 0x040132F3 RID: 78579
		[Nullable(2)]
		public VisionFetterData FetterData;

		// Token: 0x040132F4 RID: 78580
		public bool IfMainPosition;

		// Token: 0x040132F5 RID: 78581
		public bool EmptyState;

		// Token: 0x040132F6 RID: 78582
		public string EmptyText = "";

		// Token: 0x040132F7 RID: 78583
		public string EmptyContentText = "";

		// Token: 0x040132F8 RID: 78584
		public PhantomSkill? SkillConfig;

		// Token: 0x040132F9 RID: 78585
		public int Level;

		// Token: 0x040132FA RID: 78586
		public int FetterGroupId;

		// Token: 0x040132FB RID: 78587
		private bool NeedCheckChangeColor = true;

		// Token: 0x040132FC RID: 78588
		public bool DoNotNeedCheckSimplyState;

		// Token: 0x040132FD RID: 78589
		public bool NeedSimplyStateChangeAnimation;

		// Token: 0x040132FE RID: 78590
		public bool AnimationState = true;

		// Token: 0x040132FF RID: 78591
		public int Quality;

		// Token: 0x04013300 RID: 78592
		public int TitleType = -1;

		// Token: 0x04013301 RID: 78593
		public bool EquipSameMonster;

		// Token: 0x04013302 RID: 78594
		public bool EquipOverNeed;

		// Token: 0x04013303 RID: 78595
		public bool CompareState;
	}
}
