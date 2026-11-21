using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059C9 RID: 22985
	public class SolarSchoolBehaviorDonePopupView : UiTickViewBase
	{
		// Token: 0x06038A63 RID: 232035 RVA: 0x00FDA37E File Offset: 0x00FD857E
		[NullableContext(1)]
		public SolarSchoolBehaviorDonePopupView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038A64 RID: 232036 RVA: 0x00FDA388 File Offset: 0x00FD8588
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038A65 RID: 232037 RVA: 0x00FDA498 File Offset: 0x00FD8698
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolBehaviorDonePopupView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolBehaviorDonePopupView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038A66 RID: 232038 RVA: 0x00FDA4DB File Offset: 0x00FD86DB
		protected override void OnStart()
		{
			this.CreateStarLayout();
		}

		// Token: 0x06038A67 RID: 232039 RVA: 0x00FDA4E4 File Offset: 0x00FD86E4
		protected override void OnBeforeShow()
		{
			this.Elapsed = 0f;
			this.Closing = false;
			SolarSchoolBehaviorDonePopupParam solarSchoolBehaviorDonePopupParam = this.OpenParam as SolarSchoolBehaviorDonePopupParam;
			if (solarSchoolBehaviorDonePopupParam == null)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] 行为完成弹窗打开参数缺失或类型错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			SolarSchoolPlayerData playerData = SolarSchoolGamePlayModel.Instance.PlayerData;
			SolarSchoolBehavior? currentLevelRow = playerData.GetCurrentLevelRow(solarSchoolBehaviorDonePopupParam.BehaviorId);
			if (currentLevelRow == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 行为完成弹窗取不到行为配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("behaviorId", solarSchoolBehaviorDonePopupParam.BehaviorId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			string text;
			if ((text = ConfigMultiTextLang.GetLocalTextNew(string.IsNullOrEmpty(solarSchoolBehaviorDonePopupParam.TextKey) ? "SolarSchool_BehaviorDone_DefaultTitle" : solarSchoolBehaviorDonePopupParam.TextKey, null)) == null)
			{
				text = (ConfigMultiTextLang.GetLocalTextNew("SolarSchool_BehaviorDone_DefaultTitle", null) ?? string.Empty);
			}
			string newText = text;
			UUIText text2 = base.GetText(0);
			if (text2 != null)
			{
				text2.SetText(newText, true);
			}
			UUIText text3 = base.GetText(1);
			if (text3 != null)
			{
				text3.SetText(playerData.GetBehaviorNameWithLevel(solarSchoolBehaviorDonePopupParam.BehaviorId), true);
			}
			this.RefreshStars(currentLevelRow.Value.StarLevel);
		}

		// Token: 0x06038A68 RID: 232040 RVA: 0x00FDA60B File Offset: 0x00FD880B
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			GenericLayout<SolarSchoolBehaviorDonePopupItem, SolarSchoolBehaviorDoneAttrData> attrLayout = this.AttrLayout;
			if (attrLayout != null)
			{
				attrLayout.PlayGridAnim();
			}
			return UniTask.CompletedTask;
		}

		// Token: 0x06038A69 RID: 232041 RVA: 0x00FDA623 File Offset: 0x00FD8823
		protected override void OnTick(float delta)
		{
			if (this.Closing)
			{
				return;
			}
			this.Elapsed += delta;
			if (this.Elapsed < 2000f)
			{
				return;
			}
			this.Closing = true;
			this.CloseSelf();
		}

		// Token: 0x06038A6A RID: 232042 RVA: 0x00FDA657 File Offset: 0x00FD8857
		protected override void OnBeforeHide()
		{
			this.StopStarAnimation();
		}

		// Token: 0x06038A6B RID: 232043 RVA: 0x00FDA65F File Offset: 0x00FD885F
		protected override void OnBeforeDestroy()
		{
			this.StopStarAnimation();
			SolarSchoolBehaviorDonePopupParam solarSchoolBehaviorDonePopupParam = this.OpenParam as SolarSchoolBehaviorDonePopupParam;
			if (solarSchoolBehaviorDonePopupParam == null)
			{
				return;
			}
			Action closeCallback = solarSchoolBehaviorDonePopupParam.CloseCallback;
			if (closeCallback == null)
			{
				return;
			}
			closeCallback();
		}

		// Token: 0x06038A6C RID: 232044 RVA: 0x00FDA688 File Offset: 0x00FD8888
		private void CreateStarLayout()
		{
			UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(2);
			UUISprite sprite = base.GetSprite(3);
			AUIBaseActor auibaseActor = ((sprite != null) ? sprite.GetOwner() : null) as AUIBaseActor;
			if (horizontalLayout == null || auibaseActor == null)
			{
				return;
			}
			this.StarLayout = new GenericLayout<SolarSchoolStarItem, bool>(horizontalLayout, () => new SolarSchoolStarItem(), auibaseActor, false, true);
		}

		// Token: 0x06038A6D RID: 232045 RVA: 0x00FDA6EC File Offset: 0x00FD88EC
		private void RefreshStars(int starLevel)
		{
			SolarSchoolBehaviorDonePopupView.<>c__DisplayClass17_0 CS$<>8__locals1 = new SolarSchoolBehaviorDonePopupView.<>c__DisplayClass17_0();
			CS$<>8__locals1.<>4__this = this;
			bool[] array = new bool[Math.Max(0, starLevel)];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = true;
			}
			SolarSchoolBehaviorDonePopupView.<>c__DisplayClass17_0 CS$<>8__locals2 = CS$<>8__locals1;
			int num = this.StarAnimationVersion + 1;
			this.StarAnimationVersion = num;
			CS$<>8__locals2.version = num;
			GenericLayout<SolarSchoolStarItem, bool> starLayout = this.StarLayout;
			if (starLayout == null)
			{
				return;
			}
			starLayout.RefreshByData(array, delegate
			{
				CS$<>8__locals1.<>4__this.PlayStarAnimation(CS$<>8__locals1.version);
			}, false);
		}

		// Token: 0x06038A6E RID: 232046 RVA: 0x00FDA75C File Offset: 0x00FD895C
		private void PlayStarAnimation(int version)
		{
			if (version != this.StarAnimationVersion || !base.IsShowOrShowing || this.StarLayout == null)
			{
				return;
			}
			TArray<UUIItem> tarray = new TArray<UUIItem>();
			foreach (SolarSchoolStarItem solarSchoolStarItem in this.StarLayout.GetLayoutItemList())
			{
				UUIItem rootItem = solarSchoolStarItem.GetRootItem();
				if (rootItem != null)
				{
					tarray.Add(rootItem);
				}
			}
			if (tarray.Num() > 0)
			{
				UUIInturnAnimController uiAnimController = this.StarLayout.GetUiAnimController();
				if (uiAnimController == null)
				{
					return;
				}
				uiAnimController.PlayWithItems(tarray, "Start");
			}
		}

		// Token: 0x06038A6F RID: 232047 RVA: 0x00FDA804 File Offset: 0x00FD8A04
		private void StopStarAnimation()
		{
			this.StarAnimationVersion++;
			GenericLayout<SolarSchoolStarItem, bool> starLayout = this.StarLayout;
			UUIInturnAnimController uuiinturnAnimController = (starLayout != null) ? starLayout.GetUiAnimController() : null;
			if (uuiinturnAnimController != null && uuiinturnAnimController.IsPlaying())
			{
				uuiinturnAnimController.Stop();
			}
		}

		// Token: 0x06038A70 RID: 232048 RVA: 0x00FDA844 File Offset: 0x00FD8A44
		private void CreateAttrLayout()
		{
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(5);
			UUIItem item = base.GetItem(6);
			AUIBaseActor auibaseActor = ((item != null) ? item.GetOwner() : null) as AUIBaseActor;
			if (verticalLayout == null || auibaseActor == null)
			{
				return;
			}
			this.AttrLayout = new GenericLayout<SolarSchoolBehaviorDonePopupItem, SolarSchoolBehaviorDoneAttrData>(verticalLayout, () => new SolarSchoolBehaviorDonePopupItem(), auibaseActor, false, true);
		}

		// Token: 0x06038A71 RID: 232049 RVA: 0x00FDA8A8 File Offset: 0x00FD8AA8
		[NullableContext(1)]
		private static List<SolarSchoolBehaviorDoneAttrData> BuildAttrItems(int rewardGroupId)
		{
			List<SolarSchoolBehaviorDoneAttrData> list = new List<SolarSchoolBehaviorDoneAttrData>();
			if (rewardGroupId == 0)
			{
				return list;
			}
			Dictionary<ESolarSchoolSecondAttr, int> dictionary = new Dictionary<ESolarSchoolSecondAttr, int>();
			foreach (SolarSchoolReward solarSchoolReward in SolarSchoolRewardCenter.Instance.GetRewardPreview(rewardGroupId))
			{
				if (solarSchoolReward.RewardType == 0)
				{
					SolarSchoolAttr? attr = SolarSchoolConfig.Instance.GetAttr(solarSchoolReward.TargetId);
					if (attr != null)
					{
						ESolarSchoolSecondAttr attrType = (ESolarSchoolSecondAttr)attr.Value.AttrType;
						int num;
						dictionary.TryGetValue(attrType, out num);
						dictionary[attrType] = num + solarSchoolReward.Value;
					}
				}
			}
			SolarSchoolPlayerData playerData = SolarSchoolGamePlayModel.Instance.PlayerData;
			foreach (KeyValuePair<ESolarSchoolSecondAttr, int> keyValuePair in dictionary)
			{
				ESolarSchoolSecondAttr esolarSchoolSecondAttr;
				int num2;
				keyValuePair.Deconstruct(out esolarSchoolSecondAttr, out num2);
				ESolarSchoolSecondAttr attr2 = esolarSchoolSecondAttr;
				int num3 = num2;
				SolarSchoolAttr? attrConfig = SolarSchoolGamePlayModel.Instance.GetAttrConfig(attr2);
				if (attrConfig != null)
				{
					int attr3 = playerData.GetAttr(attr2);
					int newValue = (int)Math.Clamp((long)((int)Math.Clamp((long)playerData.GetBaseAttr(attr2) + (long)num3, (long)attrConfig.Value.MinValue, (long)attrConfig.Value.MaxValue)) + (long)playerData.GetAttrBonus(attr2), (long)attrConfig.Value.MinValue, (long)attrConfig.Value.MaxValue);
					list.Add(new SolarSchoolBehaviorDoneAttrData(attr2, attr3, newValue));
				}
			}
			return list;
		}

		// Token: 0x0401DD3E RID: 122174
		private const float AutoCloseMilliseconds = 2000f;

		// Token: 0x0401DD3F RID: 122175
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SolarSchoolStarItem, bool> StarLayout;

		// Token: 0x0401DD40 RID: 122176
		private int StarAnimationVersion;

		// Token: 0x0401DD41 RID: 122177
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SolarSchoolBehaviorDonePopupItem, SolarSchoolBehaviorDoneAttrData> AttrLayout;

		// Token: 0x0401DD42 RID: 122178
		private float Elapsed;

		// Token: 0x0401DD43 RID: 122179
		private bool Closing;

		// Token: 0x0200B579 RID: 46457
		private class EComponents
		{
			// Token: 0x040381DE RID: 229854
			public const int TxtTitle = 0;

			// Token: 0x040381DF RID: 229855
			public const int TxtName = 1;

			// Token: 0x040381E0 RID: 229856
			public const int PnlStarLayout = 2;

			// Token: 0x040381E1 RID: 229857
			public const int SprStarItem = 3;

			// Token: 0x040381E2 RID: 229858
			public const int TexBottomBg = 4;

			// Token: 0x040381E3 RID: 229859
			public const int PnlAttrList = 5;

			// Token: 0x040381E4 RID: 229860
			public const int AttrItem = 6;
		}
	}
}
