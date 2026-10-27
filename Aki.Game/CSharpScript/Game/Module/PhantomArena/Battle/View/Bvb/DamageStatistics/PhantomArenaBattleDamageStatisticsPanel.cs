using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb.DamageStatistics
{
	// Token: 0x0200527B RID: 21115
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleDamageStatisticsPanel : UiPanelBase
	{
		// Token: 0x06036009 RID: 221193 RVA: 0x00CC7884 File Offset: 0x00CC5A84
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

		// Token: 0x0603600A RID: 221194 RVA: 0x00CC79A4 File Offset: 0x00CC5BA4
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaBattleDamageStatisticsPanel.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaBattleDamageStatisticsPanel.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603600B RID: 221195 RVA: 0x00CC79E7 File Offset: 0x00CC5BE7
		protected override void OnStart()
		{
			this.InitTween();
			this.InitSequence();
			this.InitToggle();
			this.InitContentHeight();
			this.HideTemplateItem();
		}

		// Token: 0x0603600C RID: 221196 RVA: 0x00CC7A07 File Offset: 0x00CC5C07
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
			this.HeightTween.Destroy();
		}

		// Token: 0x0603600D RID: 221197 RVA: 0x00CC7A1F File Offset: 0x00CC5C1F
		public void Tick(float deltaTime)
		{
			this.HandleNotifyValueChange();
		}

		// Token: 0x0603600E RID: 221198 RVA: 0x00CC7A27 File Offset: 0x00CC5C27
		private void InitTween()
		{
			this.HeightTween = new LguiIntTween();
			this.HeightTween.BindUpdateTween(new Action<int>(this.UpdateLayoutHeight));
		}

		// Token: 0x0603600F RID: 221199 RVA: 0x00CC7A4B File Offset: 0x00CC5C4B
		private void InitSequence()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.OnEndSequenceEvent));
		}

		// Token: 0x06036010 RID: 221200 RVA: 0x00CC7A78 File Offset: 0x00CC5C78
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

		// Token: 0x06036011 RID: 221201 RVA: 0x00CC7B04 File Offset: 0x00CC5D04
		private void InitContentHeight()
		{
			this.ContentItem = base.GetItem(3);
			this.OriginalHeight = this.ContentItem.Height;
			this.ContentItem.SetHeight(this.OriginalHeight + (this.GridItemHeight + 12f) * 2f);
		}

		// Token: 0x06036012 RID: 221202 RVA: 0x00CC7B53 File Offset: 0x00CC5D53
		private void HideTemplateItem()
		{
			base.GetItem(4).SetUIActive(false);
		}

		// Token: 0x06036013 RID: 221203 RVA: 0x00CC7B64 File Offset: 0x00CC5D64
		private UniTask InitMoveCurve()
		{
			PhantomArenaBattleDamageStatisticsPanel.<InitMoveCurve>d__28 <InitMoveCurve>d__;
			<InitMoveCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMoveCurve>d__.<>4__this = this;
			<InitMoveCurve>d__.<>1__state = -1;
			<InitMoveCurve>d__.<>t__builder.Start<PhantomArenaBattleDamageStatisticsPanel.<InitMoveCurve>d__28>(ref <InitMoveCurve>d__);
			return <InitMoveCurve>d__.<>t__builder.Task;
		}

		// Token: 0x06036014 RID: 221204 RVA: 0x00CC7BA8 File Offset: 0x00CC5DA8
		private UUIItem CreateItemActor()
		{
			UUIItem item = base.GetItem(4);
			return LguiUtil.Instance.CopyItem(item, base.GetItem(3));
		}

		// Token: 0x06036015 RID: 221205 RVA: 0x00CC7BD0 File Offset: 0x00CC5DD0
		private UniTask InitLayout()
		{
			PhantomArenaBattleDamageStatisticsPanel.<InitLayout>d__30 <InitLayout>d__;
			<InitLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLayout>d__.<>4__this = this;
			<InitLayout>d__.<>1__state = -1;
			<InitLayout>d__.<>t__builder.Start<PhantomArenaBattleDamageStatisticsPanel.<InitLayout>d__30>(ref <InitLayout>d__);
			return <InitLayout>d__.<>t__builder.Task;
		}

		// Token: 0x06036016 RID: 221206 RVA: 0x00CC7C13 File Offset: 0x00CC5E13
		private void InitGridItemHeight()
		{
			this.GridItemHeight = base.GetItem(4).Height;
		}

		// Token: 0x06036017 RID: 221207 RVA: 0x00CC7C27 File Offset: 0x00CC5E27
		private void HandleNotifyValueChange()
		{
			if (this.IsNotifyValueChange)
			{
				this.IsNotifyValueChange = false;
				this.RefreshContent();
			}
		}

		// Token: 0x06036018 RID: 221208 RVA: 0x00CC7C40 File Offset: 0x00CC5E40
		private void RefreshContent()
		{
			List<IDamageData> list = this.DamageDataMap[this.SelectRankType].Values.ToList<IDamageData>();
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

		// Token: 0x06036019 RID: 221209 RVA: 0x00CC7CDC File Offset: 0x00CC5EDC
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

		// Token: 0x0603601A RID: 221210 RVA: 0x00CC7D2F File Offset: 0x00CC5F2F
		private void OnEndSequenceEvent(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				base.GetItem(2).SetUIActive(false);
			}
		}

		// Token: 0x0603601B RID: 221211 RVA: 0x00CC7D4B File Offset: 0x00CC5F4B
		private bool CanDamageExecuteChange()
		{
			return this.SelectRankType != EDamageStatisticsRankType.Damage;
		}

		// Token: 0x0603601C RID: 221212 RVA: 0x00CC7D59 File Offset: 0x00CC5F59
		private bool CanInjuryExecuteChange()
		{
			return this.SelectRankType != EDamageStatisticsRankType.Injury;
		}

		// Token: 0x0603601D RID: 221213 RVA: 0x00CC7D67 File Offset: 0x00CC5F67
		private void OnClickDamageRank(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.SelectRankType = EDamageStatisticsRankType.Damage;
				base.GetExtendToggle(1).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
				this.RefreshContent();
			}
		}

		// Token: 0x0603601E RID: 221214 RVA: 0x00CC7D8A File Offset: 0x00CC5F8A
		private void OnClickInjuryRank(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.SelectRankType = EDamageStatisticsRankType.Injury;
				base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
				this.RefreshContent();
			}
		}

		// Token: 0x0603601F RID: 221215 RVA: 0x00CC7DB0 File Offset: 0x00CC5FB0
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

		// Token: 0x06036020 RID: 221216 RVA: 0x00CC7E30 File Offset: 0x00CC6030
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

		// Token: 0x06036021 RID: 221217 RVA: 0x00CC7EA8 File Offset: 0x00CC60A8
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

		// Token: 0x06036022 RID: 221218 RVA: 0x00CC7F3A File Offset: 0x00CC613A
		private int GetAllCount()
		{
			if (this.SelectRankType == EDamageStatisticsRankType.Damage)
			{
				return this.AllDamage;
			}
			return this.AllInjury;
		}

		// Token: 0x06036023 RID: 221219 RVA: 0x00CC7F52 File Offset: 0x00CC6152
		private int GetCount(long entityId)
		{
			if (this.SelectRankType == EDamageStatisticsRankType.Damage)
			{
				return this.DamageDataMap[EDamageStatisticsRankType.Damage][entityId].Damage;
			}
			return this.DamageDataMap[EDamageStatisticsRankType.Injury][entityId].Damage;
		}

		// Token: 0x06036024 RID: 221220 RVA: 0x00CC7F8C File Offset: 0x00CC618C
		private void UpdateLayoutHeight(int value)
		{
			this.ContentItem.SetHeight((float)value);
		}

		// Token: 0x0401C985 RID: 117125
		private const int LIMIT_MIN_NUM = 3;

		// Token: 0x0401C986 RID: 117126
		private const float LIMIT_DAMAGE_RATE = 0.01f;

		// Token: 0x0401C987 RID: 117127
		private const int ITEM_HEIGHT_INTERVAL = 12;

		// Token: 0x0401C988 RID: 117128
		private const float TWEEN_DURATION = 0.3f;

		// Token: 0x0401C989 RID: 117129
		protected EDamageStatisticsRankType SelectRankType;

		// Token: 0x0401C98A RID: 117130
		protected UiSequencePlayer Sequence;

		// Token: 0x0401C98B RID: 117131
		protected Dictionary<long, PhantomArenaBattleDamageStatisticsItem> LayoutItemMap = new Dictionary<long, PhantomArenaBattleDamageStatisticsItem>();

		// Token: 0x0401C98C RID: 117132
		protected float GridItemHeight;

		// Token: 0x0401C98D RID: 117133
		protected float OriginalHeight;

		// Token: 0x0401C98E RID: 117134
		protected int AllDamage;

		// Token: 0x0401C98F RID: 117135
		protected int AllInjury;

		// Token: 0x0401C990 RID: 117136
		protected Dictionary<EDamageStatisticsRankType, Dictionary<long, IDamageData>> DamageDataMap = new Dictionary<EDamageStatisticsRankType, Dictionary<long, IDamageData>>();

		// Token: 0x0401C991 RID: 117137
		protected bool IsNotifyValueChange;

		// Token: 0x0401C992 RID: 117138
		protected UCurveFloat LerpCurve;

		// Token: 0x0401C993 RID: 117139
		protected float DefaultOffsetY;

		// Token: 0x0401C994 RID: 117140
		protected LguiIntTween HeightTween;

		// Token: 0x0401C995 RID: 117141
		protected UUIItem ContentItem;

		// Token: 0x0200B47A RID: 46202
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036AE4 RID: 223972
			public const int DamageRankToggle = 0;

			// Token: 0x04036AE5 RID: 223973
			public const int InjuryRankToggle = 1;

			// Token: 0x04036AE6 RID: 223974
			public const int ContentRootItem = 2;

			// Token: 0x04036AE7 RID: 223975
			public const int ContentItem = 3;

			// Token: 0x04036AE8 RID: 223976
			public const int TemplateItem = 4;

			// Token: 0x04036AE9 RID: 223977
			public const int SwitchContentToggle = 5;

			// Token: 0x04036AEA RID: 223978
			public const int SwitchShowToggle = 6;
		}
	}
}
