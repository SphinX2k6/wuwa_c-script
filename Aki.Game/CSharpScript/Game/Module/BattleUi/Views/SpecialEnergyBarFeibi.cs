using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DBA RID: 19898
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarFeibi : SpecialEnergyBarBase
	{
		// Token: 0x06032059 RID: 204889 RVA: 0x00E00B6C File Offset: 0x00DFED6C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603205A RID: 204890 RVA: 0x00E00DAB File Offset: 0x00DFEFAB
		protected override void OnInitData()
		{
			this.YellowConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(150602);
			this.BlueConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(150603);
		}

		// Token: 0x0603205B RID: 204891 RVA: 0x00E00DE4 File Offset: 0x00DFEFE4
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1FeibiMd10011.逻辑.延奏标识1"], new BaseTagComponent.TTagSwitchedCallback(this.OnTagChange));
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1FeibiMd10011.逻辑.延奏标识2"], new BaseTagComponent.TTagSwitchedCallback(this.OnTagChange));
		}

		// Token: 0x0603205C RID: 204892 RVA: 0x00E00E39 File Offset: 0x00DFF039
		private void OnTagChange(int tagId, bool tagExist)
		{
			this.RefreshState(false);
		}

		// Token: 0x0603205D RID: 204893 RVA: 0x00E00E44 File Offset: 0x00DFF044
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarFeibi.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarFeibi.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603205E RID: 204894 RVA: 0x00E00E88 File Offset: 0x00DFF088
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarFeibi.<InitBarItem>d__14 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarFeibi.<InitBarItem>d__14>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603205F RID: 204895 RVA: 0x00E00ECB File Offset: 0x00DFF0CB
		protected override void OnStart()
		{
			base.InitTweenAnim(13);
			base.InitTweenAnim(14);
			this.RefreshState(true);
			this.RefreshBarPercent(true);
		}

		// Token: 0x06032060 RID: 204896 RVA: 0x00E00EEB File Offset: 0x00DFF0EB
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x06032061 RID: 204897 RVA: 0x00E00EF4 File Offset: 0x00DFF0F4
		private void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			switch (this.CurState)
			{
			case SpecialEnergyBarFeibi.EState.Normal:
			{
				UUITexture texture = base.GetTexture(11);
				if (texture != null)
				{
					texture.SetFillAmount(curPercent);
				}
				this.RefreshKeyEnable(isStart);
				return;
			}
			case SpecialEnergyBarFeibi.EState.Yellow:
			{
				UUITexture texture2 = base.GetTexture(5);
				if (texture2 == null)
				{
					return;
				}
				texture2.SetFillAmount(curPercent);
				return;
			}
			case SpecialEnergyBarFeibi.EState.Blue:
			{
				UUITexture texture3 = base.GetTexture(4);
				if (texture3 == null)
				{
					return;
				}
				texture3.SetFillAmount(curPercent);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06032062 RID: 204898 RVA: 0x00E00F68 File Offset: 0x00DFF168
		protected override void OnKeyEnableChanged()
		{
			this.RefreshKeyEnable(false);
		}

		// Token: 0x06032063 RID: 204899 RVA: 0x00E00F74 File Offset: 0x00DFF174
		private void RefreshKeyEnable(bool isStart = false)
		{
			bool keyEnable = this.GetKeyEnable();
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(keyEnable, isStart);
		}

		// Token: 0x06032064 RID: 204900 RVA: 0x00E00F9C File Offset: 0x00DFF19C
		private void RefreshState(bool isStart = false)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1FeibiMd10011.逻辑.延奏标识1"]))
			{
				this.SetState(SpecialEnergyBarFeibi.EState.Yellow, isStart);
			}
			else
			{
				BaseTagComponent tagComponent2 = this.TagComponent;
				if (tagComponent2 != null && tagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1FeibiMd10011.逻辑.延奏标识2"]))
				{
					this.SetState(SpecialEnergyBarFeibi.EState.Blue, isStart);
				}
				else
				{
					this.SetState(SpecialEnergyBarFeibi.EState.Normal, isStart);
				}
			}
			if (!isStart)
			{
				this.RefreshBarPercent(false);
			}
		}

		// Token: 0x06032065 RID: 204901 RVA: 0x00E01018 File Offset: 0x00DFF218
		private void SetState(SpecialEnergyBarFeibi.EState state, bool isStart = false)
		{
			if (state == this.CurState && !isStart)
			{
				return;
			}
			this.CurState = state;
			switch (this.CurState)
			{
			case SpecialEnergyBarFeibi.EState.Normal:
			{
				UUIItem item = base.GetItem(10);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUIItem item2 = base.GetItem(1);
				if (item2 != null)
				{
					item2.SetUIActive(false);
				}
				UUIItem item3 = base.GetItem(0);
				if (item3 != null)
				{
					item3.SetUIActive(false);
				}
				UUIItem item4 = base.GetItem(12);
				if (item4 != null)
				{
					item4.SetUIActive(true);
				}
				if (!isStart)
				{
					base.StopTweenAnim(13);
					base.PlayTweenAnim(14);
					return;
				}
				break;
			}
			case SpecialEnergyBarFeibi.EState.Yellow:
			{
				UUIItem item5 = base.GetItem(10);
				if (item5 != null)
				{
					item5.SetUIActive(false);
				}
				UUIItem item6 = base.GetItem(1);
				if (item6 != null)
				{
					item6.SetUIActive(true);
				}
				UUIItem item7 = base.GetItem(0);
				if (item7 != null)
				{
					item7.SetUIActive(false);
				}
				UUIItem item8 = base.GetItem(12);
				if (item8 != null)
				{
					item8.SetUIActive(false);
				}
				if (!isStart)
				{
					base.StopTweenAnim(14);
					base.PlayTweenAnim(13);
					return;
				}
				break;
			}
			case SpecialEnergyBarFeibi.EState.Blue:
			{
				UUIItem item9 = base.GetItem(10);
				if (item9 != null)
				{
					item9.SetUIActive(false);
				}
				UUIItem item10 = base.GetItem(1);
				if (item10 != null)
				{
					item10.SetUIActive(false);
				}
				UUIItem item11 = base.GetItem(0);
				if (item11 != null)
				{
					item11.SetUIActive(true);
				}
				UUIItem item12 = base.GetItem(12);
				if (item12 != null)
				{
					item12.SetUIActive(false);
				}
				if (!isStart)
				{
					base.StopTweenAnim(14);
					base.PlayTweenAnim(13);
				}
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x06032066 RID: 204902 RVA: 0x00E0117B File Offset: 0x00DFF37B
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarFeibiSlot barItemYellow = this.BarItemYellow;
			if (barItemYellow != null)
			{
				barItemYellow.Tick(delta);
			}
			SpecialEnergyBarFeibiSlot barItemBlue = this.BarItemBlue;
			if (barItemBlue == null)
			{
				return;
			}
			barItemBlue.Tick(delta);
		}

		// Token: 0x0401A7B7 RID: 108471
		private const int YELLOW_CONFIG_ID = 150602;

		// Token: 0x0401A7B8 RID: 108472
		private const int BLUE_CONFIG_ID = 150603;

		// Token: 0x0401A7B9 RID: 108473
		private SpecialEnergyBarInfo YellowConfig;

		// Token: 0x0401A7BA RID: 108474
		private SpecialEnergyBarInfo BlueConfig;

		// Token: 0x0401A7BB RID: 108475
		private SpecialEnergyBarFeibiSlot BarItemYellow;

		// Token: 0x0401A7BC RID: 108476
		private SpecialEnergyBarFeibiSlot BarItemBlue;

		// Token: 0x0401A7BD RID: 108477
		private SpecialEnergyBarFeibi.EState CurState;

		// Token: 0x0200AAFA RID: 43770
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034D85 RID: 216453
			BlueItem,
			// Token: 0x04034D86 RID: 216454
			YellowItem,
			// Token: 0x04034D87 RID: 216455
			SlotBarItemBlue,
			// Token: 0x04034D88 RID: 216456
			SlotBarItemYellow,
			// Token: 0x04034D89 RID: 216457
			BarTextureBlue,
			// Token: 0x04034D8A RID: 216458
			BarTextureYellow,
			// Token: 0x04034D8B RID: 216459
			CoreBlue,
			// Token: 0x04034D8C RID: 216460
			CoreYellow,
			// Token: 0x04034D8D RID: 216461
			BgBlueItem,
			// Token: 0x04034D8E RID: 216462
			BgYellowItem,
			// Token: 0x04034D8F RID: 216463
			NormalItem,
			// Token: 0x04034D90 RID: 216464
			BarTextureNormal,
			// Token: 0x04034D91 RID: 216465
			KeyItem,
			// Token: 0x04034D92 RID: 216466
			AnimAwakeIn,
			// Token: 0x04034D93 RID: 216467
			AnimAwakeOut,
			// Token: 0x04034D94 RID: 216468
			AnimBurst
		}

		// Token: 0x0200AAFB RID: 43771
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x04034D96 RID: 216470
			Normal,
			// Token: 0x04034D97 RID: 216471
			Yellow,
			// Token: 0x04034D98 RID: 216472
			Blue
		}
	}
}
