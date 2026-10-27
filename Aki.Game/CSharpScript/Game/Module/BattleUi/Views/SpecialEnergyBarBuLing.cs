using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DCF RID: 24015
	public class SpecialEnergyBarBuLing : SpecialEnergyBarBase
	{
		// Token: 0x0603D080 RID: 249984 RVA: 0x00EAD664 File Offset: 0x00EAB864
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
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
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D081 RID: 249985 RVA: 0x00EAD840 File Offset: 0x00EABA40
		protected override void OnInitData()
		{
			base.OnInitData();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarBuLing.TagLeft, new BaseTagComponent.TTagSwitchedCallback(this.OnTagLeftChanged));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarBuLing.TagRight, new BaseTagComponent.TTagSwitchedCallback(this.OnTagRightChanged));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarBuLing.TagAll, new BaseTagComponent.TTagSwitchedCallback(this.OnTagAllChanged));
		}

		// Token: 0x0603D082 RID: 249986 RVA: 0x00EAD898 File Offset: 0x00EABA98
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarBuLing.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarBuLing.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D083 RID: 249987 RVA: 0x00EAD8DC File Offset: 0x00EABADC
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarBuLing.<InitBarItem>d__14 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarBuLing.<InitBarItem>d__14>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D084 RID: 249988 RVA: 0x00EAD91F File Offset: 0x00EABB1F
		private void OnTagLeftChanged(int tagId, bool tagExist)
		{
			this.HasTagLeft = tagExist;
			this.RefreshState(false);
		}

		// Token: 0x0603D085 RID: 249989 RVA: 0x00EAD92F File Offset: 0x00EABB2F
		private void OnTagRightChanged(int tagId, bool tagExist)
		{
			this.HasTagRight = tagExist;
			this.RefreshState(false);
		}

		// Token: 0x0603D086 RID: 249990 RVA: 0x00EAD93F File Offset: 0x00EABB3F
		private void OnTagAllChanged(int tagId, bool tagExist)
		{
			this.HasTagAll = tagExist;
			this.RefreshState(false);
		}

		// Token: 0x0603D087 RID: 249991 RVA: 0x00EAD950 File Offset: 0x00EABB50
		protected override void OnStart()
		{
			base.InitTweenAnim(7);
			base.InitTweenAnim(9);
			base.InitTweenAnim(8);
			base.InitTweenAnim(10);
			base.InitTweenAnim(11);
			base.InitTweenAnim(12);
			BaseTagComponent tagComponent = this.TagComponent;
			this.HasTagLeft = (tagComponent != null && tagComponent.HasTag(SpecialEnergyBarBuLing.TagLeft));
			BaseTagComponent tagComponent2 = this.TagComponent;
			this.HasTagRight = (tagComponent2 != null && tagComponent2.HasTag(SpecialEnergyBarBuLing.TagRight));
			BaseTagComponent tagComponent3 = this.TagComponent;
			this.HasTagAll = (tagComponent3 != null && tagComponent3.HasTag(SpecialEnergyBarBuLing.TagAll));
			this.RefreshState(true);
		}

		// Token: 0x0603D088 RID: 249992 RVA: 0x00EAD9EC File Offset: 0x00EABBEC
		private void RefreshState(bool isStart = false)
		{
			this.BarItem.SetState(this.HasTagLeft || this.HasTagAll, this.HasTagRight || this.HasTagAll);
			int num = 0;
			if (this.HasTagAll)
			{
				num = 3;
			}
			else if (this.HasTagLeft)
			{
				num = 1;
			}
			else if (this.HasTagRight)
			{
				num = 2;
			}
			if (num == this.State && !isStart)
			{
				return;
			}
			int state = this.State;
			this.State = num;
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(this.State == 0);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 != null)
			{
				item2.SetUIActive(this.State == 1);
			}
			UUIItem item3 = base.GetItem(2);
			if (item3 != null)
			{
				item3.SetUIActive(this.State == 2);
			}
			UUIItem item4 = base.GetItem(4);
			if (item4 != null)
			{
				item4.SetUIActive(this.State == 3);
			}
			UUIItem item5 = base.GetItem(5);
			if (item5 != null)
			{
				item5.SetUIActive(this.HasTagLeft || this.HasTagAll);
			}
			UUIItem item6 = base.GetItem(6);
			if (item6 != null)
			{
				item6.SetUIActive(this.HasTagRight || this.HasTagAll);
			}
			if (!isStart)
			{
				if (this.State == 0)
				{
					if (state == 3)
					{
						this.PlayTweenAnimOnly(10);
						return;
					}
					if (state == 1)
					{
						this.PlayTweenAnimOnly(11);
						return;
					}
					if (state == 2)
					{
						this.PlayTweenAnimOnly(12);
						return;
					}
				}
				else
				{
					if (this.State == 3)
					{
						this.PlayTweenAnimOnly(9);
						return;
					}
					if (this.State == 1)
					{
						if (state == 0)
						{
							this.PlayTweenAnimOnly(7);
							return;
						}
					}
					else if (this.State == 2 && state == 0)
					{
						this.PlayTweenAnimOnly(8);
					}
				}
			}
		}

		// Token: 0x0603D089 RID: 249993 RVA: 0x00EADB82 File Offset: 0x00EABD82
		protected void PlayTweenAnimOnly(int componentType)
		{
			if (this.LastAni >= 0)
			{
				base.StopTweenAnim(this.LastAni);
			}
			this.LastAni = componentType;
			base.PlayTweenAnim(componentType);
		}

		// Token: 0x0603D08A RID: 249994 RVA: 0x00EADBA7 File Offset: 0x00EABDA7
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarBuLingSlot barItem = this.BarItem;
			if (barItem == null)
			{
				return;
			}
			barItem.Tick(delta);
		}

		// Token: 0x0401FCBE RID: 130238
		[StaticVariableRuleIgnore]
		private static readonly int TagLeft = GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.阴阳鱼.阳侧"];

		// Token: 0x0401FCBF RID: 130239
		[StaticVariableRuleIgnore]
		private static readonly int TagRight = GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.阴阳鱼.阴侧"];

		// Token: 0x0401FCC0 RID: 130240
		[StaticVariableRuleIgnore]
		private static readonly int TagAll = GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.阴阳鱼.嵌合中"];

		// Token: 0x0401FCC1 RID: 130241
		private const float EFFECT_BASE_PERCENT = 0.41463414f;

		// Token: 0x0401FCC2 RID: 130242
		private bool HasTagLeft;

		// Token: 0x0401FCC3 RID: 130243
		private bool HasTagRight;

		// Token: 0x0401FCC4 RID: 130244
		private bool HasTagAll;

		// Token: 0x0401FCC5 RID: 130245
		private int State;

		// Token: 0x0401FCC6 RID: 130246
		private int LastAni = -1;

		// Token: 0x0401FCC7 RID: 130247
		[Nullable(2)]
		private SpecialEnergyBarBuLingSlot BarItem;

		// Token: 0x0200C0E2 RID: 49378
		private enum EChildType
		{
			// Token: 0x0403A33F RID: 238399
			SlotItem,
			// Token: 0x0403A340 RID: 238400
			StateNoneItem,
			// Token: 0x0403A341 RID: 238401
			StateRightItem,
			// Token: 0x0403A342 RID: 238402
			StateLeftItem,
			// Token: 0x0403A343 RID: 238403
			StateAllItem,
			// Token: 0x0403A344 RID: 238404
			LeftBottomItem,
			// Token: 0x0403A345 RID: 238405
			RightBottomItem,
			// Token: 0x0403A346 RID: 238406
			AniLeftIn,
			// Token: 0x0403A347 RID: 238407
			AniRightIn,
			// Token: 0x0403A348 RID: 238408
			AniAllIn,
			// Token: 0x0403A349 RID: 238409
			AniAllOut,
			// Token: 0x0403A34A RID: 238410
			AniLeftOut,
			// Token: 0x0403A34B RID: 238411
			AniRightOut
		}
	}
}
