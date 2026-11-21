using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb.DamageStatistics
{
	// Token: 0x0200424B RID: 16971
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleDamageStatisticsPanel : UiPanelBase
	{
		// Token: 0x0602AF04 RID: 175876 RVA: 0x00C14F84 File Offset: 0x00C13184
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(6, typeof(UUIExtendToggle))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickDamageRank)),
				new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickInjuryRank)),
				new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.OnClickSwitchContent)),
				new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.OnClickSwitchShow))
			};
		}

		// Token: 0x0602AF05 RID: 175877 RVA: 0x00C150A4 File Offset: 0x00C132A4
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaBattleDamageStatisticsPanel.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaBattleDamageStatisticsPanel.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF06 RID: 175878 RVA: 0x00C150E7 File Offset: 0x00C132E7
		protected override void OnStart()
		{
			this.InitTween();
			this.InitSequence();
			this.InitToggle();
			this.InitContentHeight();
			this.HideTemplateItem();
		}

		// Token: 0x0602AF07 RID: 175879 RVA: 0x00C15107 File Offset: 0x00C13307
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
			this.HeightTween.Destroy();
		}

		// Token: 0x0602AF08 RID: 175880 RVA: 0x00C1511F File Offset: 0x00C1331F
		public void Tick(float deltaTime)
		{
			this.HandleNotifyValueChange();
		}

		// Token: 0x0602AF09 RID: 175881 RVA: 0x00C15127 File Offset: 0x00C13327
		private void InitTween()
		{
			this.HeightTween = new LguiIntTween();
			this.HeightTween.BindUpdateTween(new Action<int>(this.UpdateLayoutHeight));
		}

		// Token: 0x0602AF0A RID: 175882 RVA: 0x00C1514B File Offset: 0x00C1334B
		private void InitSequence()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.OnEndSequenceEvent));
		}

		// Token: 0x0602AF0B RID: 175883 RVA: 0x00C15178 File Offset: 0x00C13378
		private void InitToggle()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(1);
			extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanDamageExecuteChange));
			extendToggle2.CanExecuteChange.Bind(new Func<bool>(this.CanInjuryExecuteChange));
			List<long> allEntityIdList = PhantomArenaBattleModel.Instance.BattleData.GetAllEntityIdList();
			base.GetExtendToggle(5).RootUIComp.Get().SetUIActive(allEntityIdList.Count > 3);
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, true, false, false);
		}

		// Token: 0x0602AF0C RID: 175884 RVA: 0x00C15204 File Offset: 0x00C13404
		private void InitContentHeight()
		{
			this.ContentItem = base.GetItem(3);
			this.OriginalHeight = this.ContentItem.Height;
			this.ContentItem.SetHeight(this.OriginalHeight + (this.GridItemHeight + 12f) * 2f);
		}

		// Token: 0x0602AF0D RID: 175885 RVA: 0x00C15253 File Offset: 0x00C13453
		private void HideTemplateItem()
		{
			base.GetItem(4).SetUIActive(false);
		}

		// Token: 0x0602AF0E RID: 175886 RVA: 0x00C15264 File Offset: 0x00C13464
		private UniTask InitMoveCurve()
		{
			PhantomArenaBattleDamageStatisticsPanel.<InitMoveCurve>d__28 <InitMoveCurve>d__;
			<InitMoveCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMoveCurve>d__.<>4__this = this;
			<InitMoveCurve>d__.<>1__state = -1;
			<InitMoveCurve>d__.<>t__builder.Start<PhantomArenaBattleDamageStatisticsPanel.<InitMoveCurve>d__28>(ref <InitMoveCurve>d__);
			return <InitMoveCurve>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF0F RID: 175887 RVA: 0x00C152A8 File Offset: 0x00C134A8
		private UUIItem CreateItemActor()
		{
			UUIItem item = base.GetItem(4);
			return LguiUtil.Instance.CopyItem(item, base.GetItem(3));
		}

		// Token: 0x0602AF10 RID: 175888 RVA: 0x00C152D0 File Offset: 0x00C134D0
		private UniTask InitLayout()
		{
			PhantomArenaBattleDamageStatisticsPanel.<InitLayout>d__30 <InitLayout>d__;
			<InitLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLayout>d__.<>4__this = this;
			<InitLayout>d__.<>1__state = -1;
			<InitLayout>d__.<>t__builder.Start<PhantomArenaBattleDamageStatisticsPanel.<InitLayout>d__30>(ref <InitLayout>d__);
			return <InitLayout>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF11 RID: 175889 RVA: 0x00C15313 File Offset: 0x00C13513
		private void InitGridItemHeight()
		{
			this.GridItemHeight = base.GetItem(4).Height;
		}

		// Token: 0x0602AF12 RID: 175890 RVA: 0x00C15327 File Offset: 0x00C13527
		private void HandleNotifyValueChange()
		{
			if (this.IsNotifyValueChange)
			{
				this.IsNotifyValueChange = false;
				this.RefreshContent();
			}
		}

		// Token: 0x0602AF13 RID: 175891 RVA: 0x00C15340 File Offset: 0x00C13540
		private void RefreshContent()
		{
			List<IDamageData> list = new List<IDamageData>(this.DamageDataMap[this.SelectRankType].Values);
			list.Sort((IDamageData a, IDamageData b) => b.Damage - a.Damage);
			for (int i = 0; i < list.Count; i++)
			{
				IDamageData damageData = list[i];
				PhantomArenaBattleDamageStatisticsItem phantomArenaBattleDamageStatisticsItem = this.LayoutItemMap[damageData.EntityId];
				float offsetY = this.DefaultOffsetY - (float)i * (this.GridItemHeight + 12f);
				phantomArenaBattleDamageStatisticsItem.RefreshOffsetY(offsetY);
				phantomArenaBattleDamageStatisticsItem.RefreshCount();
			}
		}

		// Token: 0x0602AF14 RID: 175892 RVA: 0x00C153DC File Offset: 0x00C135DC
		private UniTask CreateDamageStatisticsItem(long entityId, int index)
		{
			PhantomArenaBattleDamageStatisticsPanel.<CreateDamageStatisticsItem>d__34 <CreateDamageStatisticsItem>d__;
			<CreateDamageStatisticsItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateDamageStatisticsItem>d__.<>4__this = this;
			<CreateDamageStatisticsItem>d__.entityId = entityId;
			<CreateDamageStatisticsItem>d__.index = index;
			<CreateDamageStatisticsItem>d__.<>1__state = -1;
			<CreateDamageStatisticsItem>d__.<>t__builder.Start<PhantomArenaBattleDamageStatisticsPanel.<CreateDamageStatisticsItem>d__34>(ref <CreateDamageStatisticsItem>d__);
			return <CreateDamageStatisticsItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF15 RID: 175893 RVA: 0x00C1542F File Offset: 0x00C1362F
		private void OnEndSequenceEvent(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				base.GetItem(2).SetUIActive(false);
			}
		}

		// Token: 0x0602AF16 RID: 175894 RVA: 0x00C1544B File Offset: 0x00C1364B
		private bool CanDamageExecuteChange()
		{
			return this.SelectRankType != EDamageStatisticsRankType.Damage;
		}

		// Token: 0x0602AF17 RID: 175895 RVA: 0x00C15459 File Offset: 0x00C13659
		private bool CanInjuryExecuteChange()
		{
			return this.SelectRankType != EDamageStatisticsRankType.Injury;
		}

		// Token: 0x0602AF18 RID: 175896 RVA: 0x00C15467 File Offset: 0x00C13667
		private void OnClickDamageRank(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.SelectRankType = EDamageStatisticsRankType.Damage;
				base.GetExtendToggle(1).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
				this.RefreshContent();
			}
		}

		// Token: 0x0602AF19 RID: 175897 RVA: 0x00C1548A File Offset: 0x00C1368A
		private void OnClickInjuryRank(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.SelectRankType = EDamageStatisticsRankType.Injury;
				base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
				this.RefreshContent();
			}
		}

		// Token: 0x0602AF1A RID: 175898 RVA: 0x00C154B0 File Offset: 0x00C136B0
		private void OnClickSwitchContent(EToggleState state)
		{
			float height = base.GetItem(3).Height;
			float num;
			if (state == EToggleState.ETT_Checked)
			{
				num = this.OriginalHeight + (this.GridItemHeight + 12f) * (float)(this.LayoutItemMap.Count - 1);
			}
			else
			{
				num = this.OriginalHeight + (this.GridItemHeight + 12f) * 2f;
			}
			this.HeightTween.PlayTween((int)height, (int)num, 0.3f, this.LerpCurve);
		}

		// Token: 0x0602AF1B RID: 175899 RVA: 0x00C15530 File Offset: 0x00C13730
		private void OnClickSwitchShow(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.Sequence.StopSequenceByKey("Close", false, true);
				base.GetItem(2).SetUIActive(true);
				this.Sequence.PlaySequence("Start", false, null);
				return;
			}
			this.Sequence.StopSequenceByKey("Start", false, true);
			this.Sequence.PlaySequence("Close", false, null);
		}

		// Token: 0x0602AF1C RID: 175900 RVA: 0x00C155A8 File Offset: 0x00C137A8
		private void NotifyValueChange(long entityId, int damageValue, int hpValue, EDamageStatisticsRankType rankType)
		{
			if (rankType == EDamageStatisticsRankType.Injury)
			{
				this.AllInjury += damageValue;
				this.DamageDataMap[EDamageStatisticsRankType.Injury][entityId].Damage += damageValue;
			}
			else if (rankType == EDamageStatisticsRankType.Damage)
			{
				this.AllDamage += damageValue;
				this.DamageDataMap[EDamageStatisticsRankType.Damage][entityId].Damage += damageValue;
			}
			if (rankType != this.SelectRankType)
			{
				return;
			}
			if ((float)damageValue / (float)hpValue <= 0.01f)
			{
				return;
			}
			this.IsNotifyValueChange = true;
		}

		// Token: 0x0602AF1D RID: 175901 RVA: 0x00C1563A File Offset: 0x00C1383A
		private int GetAllCount()
		{
			if (this.SelectRankType == EDamageStatisticsRankType.Damage)
			{
				return this.AllDamage;
			}
			return this.AllInjury;
		}

		// Token: 0x0602AF1E RID: 175902 RVA: 0x00C15652 File Offset: 0x00C13852
		private int GetCount(long entityId)
		{
			if (this.SelectRankType == EDamageStatisticsRankType.Damage)
			{
				return this.DamageDataMap[EDamageStatisticsRankType.Damage][entityId].Damage;
			}
			return this.DamageDataMap[EDamageStatisticsRankType.Injury][entityId].Damage;
		}

		// Token: 0x0602AF1F RID: 175903 RVA: 0x00C1568C File Offset: 0x00C1388C
		private void UpdateLayoutHeight(int value)
		{
			this.ContentItem.SetHeight((float)value);
		}

		// Token: 0x040173BA RID: 95162
		private const int LIMIT_MIN_NUM = 3;

		// Token: 0x040173BB RID: 95163
		private const float LIMIT_DAMAGE_RATE = 0.01f;

		// Token: 0x040173BC RID: 95164
		private const int ITEM_HEIGHT_INTERVAL = 12;

		// Token: 0x040173BD RID: 95165
		private const float TWEEN_DURATION = 0.3f;

		// Token: 0x040173BE RID: 95166
		protected EDamageStatisticsRankType SelectRankType;

		// Token: 0x040173BF RID: 95167
		protected UiSequencePlayer Sequence;

		// Token: 0x040173C0 RID: 95168
		protected Dictionary<long, PhantomArenaBattleDamageStatisticsItem> LayoutItemMap = new Dictionary<long, PhantomArenaBattleDamageStatisticsItem>();

		// Token: 0x040173C1 RID: 95169
		protected float GridItemHeight;

		// Token: 0x040173C2 RID: 95170
		protected float OriginalHeight;

		// Token: 0x040173C3 RID: 95171
		protected int AllDamage;

		// Token: 0x040173C4 RID: 95172
		protected int AllInjury;

		// Token: 0x040173C5 RID: 95173
		protected Dictionary<EDamageStatisticsRankType, Dictionary<long, IDamageData>> DamageDataMap = new Dictionary<EDamageStatisticsRankType, Dictionary<long, IDamageData>>();

		// Token: 0x040173C6 RID: 95174
		protected bool IsNotifyValueChange;

		// Token: 0x040173C7 RID: 95175
		protected UCurveFloat LerpCurve;

		// Token: 0x040173C8 RID: 95176
		protected float DefaultOffsetY;

		// Token: 0x040173C9 RID: 95177
		protected LguiIntTween HeightTween;

		// Token: 0x040173CA RID: 95178
		protected UUIItem ContentItem;

		// Token: 0x02009EB2 RID: 40626
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04031537 RID: 202039
			public const int DamageRankToggle = 0;

			// Token: 0x04031538 RID: 202040
			public const int InjuryRankToggle = 1;

			// Token: 0x04031539 RID: 202041
			public const int ContentRootItem = 2;

			// Token: 0x0403153A RID: 202042
			public const int ContentItem = 3;

			// Token: 0x0403153B RID: 202043
			public const int TemplateItem = 4;

			// Token: 0x0403153C RID: 202044
			public const int SwitchContentToggle = 5;

			// Token: 0x0403153D RID: 202045
			public const int SwitchShowToggle = 6;
		}
	}
}
