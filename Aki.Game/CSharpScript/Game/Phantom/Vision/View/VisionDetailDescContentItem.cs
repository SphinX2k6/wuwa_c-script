using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Phantom.Vision.View
{
	// Token: 0x02004602 RID: 17922
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class VisionDetailDescContentItem : GridProxyAbstract<VisionDetailDesc>
	{
		// Token: 0x0602E354 RID: 189268 RVA: 0x00AAF120 File Offset: 0x00AAD320
		public override void Refresh(VisionDetailDesc data, bool isSelected, int gridIndex)
		{
			this.Update(data);
		}

		// Token: 0x0602E355 RID: 189269 RVA: 0x00AAF12C File Offset: 0x00AAD32C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602E356 RID: 189270 RVA: 0x00AAF2C4 File Offset: 0x00AAD4C4
		protected override UniTask OnBeforeStartAsync()
		{
			VisionDetailDescContentItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VisionDetailDescContentItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E357 RID: 189271 RVA: 0x00AAF307 File Offset: 0x00AAD507
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetItem(7));
		}

		// Token: 0x0602E358 RID: 189272 RVA: 0x00AAF31C File Offset: 0x00AAD51C
		public void Update(VisionDetailDesc data)
		{
			this.Data = data;
			if (this.Data == null)
			{
				return;
			}
			this.RefreshActiveContentItem(data);
			this.RefreshActiveStateItem(data);
			this.RefreshContent(data);
			this.RefreshElement(data);
			this.RefreshNoneItem(data);
			this.RefreshAnimation(data);
			this.RefreshSimplyAnimation(data);
		}

		// Token: 0x0602E359 RID: 189273 RVA: 0x00AAF36C File Offset: 0x00AAD56C
		private void RefreshSimplyAnimation(VisionDetailDesc data)
		{
			if (data.NeedSimplyStateChangeAnimation && data.AnimationState)
			{
				this.LevelSequencePlayer.StopSequenceByKey("Switch", false, true);
				this.LevelSequencePlayer.PlayLevelSequenceByName("Switch", false, null, false);
			}
		}

		// Token: 0x0602E35A RID: 189274 RVA: 0x00AAF3B8 File Offset: 0x00AAD5B8
		private void RefreshAnimation(VisionDetailDesc data)
		{
			if (this.AnimationState && data.AnimationState)
			{
				string text = null;
				bool flag = false;
				if (data.GreenActiveState && data.NewState && data.FetterId > 0)
				{
					text = "Choose";
					flag = true;
				}
				if (data.FetterId > 0 && !flag && data.FetterData.ActiveState)
				{
					text = "Activate";
				}
				string currentSequence = this.LevelSequencePlayer.GetCurrentSequence();
				if (currentSequence != null && text != currentSequence)
				{
					this.LevelSequencePlayer.StopSequenceByKey(currentSequence, false, true);
				}
				if (text != null)
				{
					if (text != currentSequence)
					{
						this.LevelSequencePlayer.PlayLevelSequenceByName(text, false, null, false);
					}
					else
					{
						this.LevelSequencePlayer.ReplaySequenceByKey(text);
					}
				}
				UUIItem item = base.GetItem(10);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(data.GetNeedWarn() && !data.GetIsFetterData() && text == null);
				return;
			}
			else
			{
				UUIItem item2 = base.GetItem(10);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(data.GetNeedWarn() && !data.GetIsFetterData());
				return;
			}
		}

		// Token: 0x0602E35B RID: 189275 RVA: 0x00AAF4C6 File Offset: 0x00AAD6C6
		private void RefreshActiveStateItem(VisionDetailDesc data)
		{
			base.GetItem(0).SetUIActive(data.NeedActiveState || data.GetNeedWarn());
		}

		// Token: 0x0602E35C RID: 189276 RVA: 0x00AAF4E5 File Offset: 0x00AAD6E5
		private void RefreshActiveContentItem(VisionDetailDesc data)
		{
			if (data.NeedActiveState)
			{
				base.GetItem(2).SetUIActive(data.GreenActiveState);
				return;
			}
			if (data.GetNeedWarn())
			{
				base.GetItem(2).SetUIActive(false);
			}
		}

		// Token: 0x0602E35D RID: 189277 RVA: 0x00AAF518 File Offset: 0x00AAD718
		private void RefreshNoneItem(VisionDetailDesc data)
		{
			if (data.GreenActiveState && !data.NewState && data.FetterId > 0)
			{
				base.GetItem(1).SetUIActive(false);
				return;
			}
			if (data.GetNeedWarn() && !data.GetIsFetterData())
			{
				base.GetItem(1).SetUIActive(false);
				return;
			}
			if (data.GreenActiveState && data.SkillConfig != null)
			{
				base.GetItem(1).SetUIActive(false);
				return;
			}
			base.GetItem(1).SetUIActive(true);
		}

		// Token: 0x0602E35E RID: 189278 RVA: 0x00AAF59C File Offset: 0x00AAD79C
		private void RefreshElement(VisionDetailDesc data)
		{
			if (data.FetterId > 0)
			{
				base.GetItem(5).SetUIActive(true);
				PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(data.FetterGroupId);
				this.VisionFetterSuitItem.Update(new PhantomFetterGroup?(fetterGroupById));
				int num = (data.FetterData.ActiveFetterGroupNum > data.FetterData.NeedActiveNum) ? data.FetterData.NeedActiveNum : data.FetterData.ActiveFetterGroupNum;
				if (data.EquipOverNeed)
				{
					num = data.FetterData.ActiveFetterGroupNum;
				}
				string newText = StringUtils.Format("({0}/{1})", new string[]
				{
					num.ToString(),
					data.FetterData.NeedActiveNum.ToString()
				});
				string hexStr;
				if (data.FetterData.ActiveState)
				{
					hexStr = "E0D799FF";
				}
				else
				{
					hexStr = "F9FFFF6F";
				}
				base.GetText(9).SetText(newText, true);
				base.GetText(9).SetColor(FColor.FromHex(hexStr));
				return;
			}
			base.GetItem(5).SetUIActive(false);
		}

		// Token: 0x0602E35F RID: 189279 RVA: 0x00AAF6A8 File Offset: 0x00AAD8A8
		private void RefreshContent(VisionDetailDesc data)
		{
			if (data.GetNeedWarn() && data.FetterId <= 0)
			{
				UUIText text = base.GetText(6);
				base.GetItem(8).SetUIActive(false);
				text.SetUIActive(true);
				base.GetText(4).SetUIActive(false);
				text.SetColor(FColor.FromHex("F9FFFF6F"));
				string textStringId = data.EquipSameMonster ? "SameVisionNoCountValue" : "OverNeedWarnText";
				LguiUtil.Instance.SetLocalTextNew(text, textStringId, Array.Empty<object>());
				return;
			}
			bool flag = PhantomBattleModel.Instance.GetIfSimpleState(1);
			flag = !flag;
			if (data.DoNotNeedCheckSimplyState)
			{
				flag = true;
			}
			if (data.FetterId > 0)
			{
				PhantomFetter phantomFetterById = PhantomBattleConfig.Instance.GetPhantomFetterById(data.FetterId);
				string newText = ConfigMultiTextLang.GetLocalTextNew(phantomFetterById.Name, null) ?? "";
				base.GetText(4).SetText(newText, true);
				if (flag)
				{
					if (StringUtils.IsEmpty(phantomFetterById.SimplyEffectDesc))
					{
						base.GetText(6).SetText("", true);
					}
					else
					{
						LguiUtil.Instance.SetLocalTextNew(base.GetText(6), phantomFetterById.SimplyEffectDesc, Array.Empty<object>());
					}
				}
				else
				{
					int effectDescriptionParamLength = phantomFetterById.EffectDescriptionParamLength;
					object[] array = new object[effectDescriptionParamLength];
					for (int i = 0; i < effectDescriptionParamLength; i++)
					{
						array[i] = phantomFetterById.EffectDescriptionParam(i);
					}
					LguiUtil.Instance.SetLocalTextNew(base.GetText(6), phantomFetterById.EffectDescription, array);
				}
				base.GetText(4).SetUIActive(true);
				base.GetText(6).SetUIActive(true);
				if (data.GetNeedCheckChangeColor())
				{
					string hexStr;
					if (data.FetterData.ActiveState)
					{
						hexStr = "E0D799FF";
					}
					else
					{
						hexStr = "F9FFFF6F";
					}
					base.GetText(4).SetColor(FColor.FromHex(hexStr));
					base.GetText(6).SetColor(FColor.FromHex(hexStr));
					return;
				}
			}
			else if (data.SkillConfig != null)
			{
				if (flag)
				{
					if (StringUtils.IsEmpty(data.SkillConfig.Value.SimplyDescription))
					{
						base.GetText(6).SetText("", true);
					}
					else
					{
						LguiUtil.Instance.SetLocalTextNew(base.GetText(6), data.SkillConfig.Value.SimplyDescription, Array.Empty<object>());
					}
				}
				else
				{
					string[] phantomSkillDescExBySkillIdAndQuality = PhantomBattleConfig.Instance.GetPhantomSkillDescExBySkillIdAndQuality(data.SkillConfig.Value.Id, data.Quality);
					LguiUtil.Instance.SetLocalTextNew(base.GetText(6), data.SkillConfig.Value.DescriptionEx, phantomSkillDescExBySkillIdAndQuality);
				}
				base.GetItem(8).SetUIActive(false);
				base.GetText(6).SetUIActive(true);
				if (data.GetNeedCheckChangeColor())
				{
					string hexStr2 = "F9FFFF6F";
					if (data.IfMainPosition)
					{
						hexStr2 = "E0D799FF";
					}
					base.GetText(6).SetColor(FColor.FromHex(hexStr2));
				}
			}
		}

		// Token: 0x0602E360 RID: 189280 RVA: 0x00AAF98A File Offset: 0x00AADB8A
		protected override void OnBeforeHide()
		{
			this.LevelSequencePlayer.StopCurrentSequence(false, false);
		}

		// Token: 0x04018CE4 RID: 101604
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04018CE5 RID: 101605
		private readonly bool AnimationState = true;

		// Token: 0x04018CE6 RID: 101606
		[Nullable(2)]
		protected VisionDetailDesc CurrentData;

		// Token: 0x04018CE7 RID: 101607
		[Nullable(2)]
		private VisionFetterSuitItem VisionFetterSuitItem;

		// Token: 0x04018CE8 RID: 101608
		[Nullable(2)]
		private VisionDetailDesc Data;
	}
}
