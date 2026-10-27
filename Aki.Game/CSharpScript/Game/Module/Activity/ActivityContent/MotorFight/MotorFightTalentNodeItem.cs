using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200641B RID: 25627
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightTalentNodeItem : UiPanelBase
	{
		// Token: 0x0604072C RID: 263980 RVA: 0x00F98158 File Offset: 0x00F96358
		public MotorFightTalentNodeItem(UUIItem parent, MotorFightTalentData data, UUIItem gridPanelItem)
		{
			this.Data = data2;
			this.PreItem = parent;
			this.GridPanelItem = gridPanelItem;
		}

		// Token: 0x0604072D RID: 263981 RVA: 0x00F981B0 File Offset: 0x00F963B0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604072E RID: 263982 RVA: 0x00F983A4 File Offset: 0x00F965A4
		protected override void OnStart()
		{
			base.GetExtendToggle(0).bLockStateOnSelect = true;
		}

		// Token: 0x0604072F RID: 263983 RVA: 0x00F983B4 File Offset: 0x00F965B4
		[NullableContext(2)]
		public unsafe void Refresh(MotorFightTalentData data = null)
		{
			this.Data = (data ?? this.Data);
			MotorFightActivityData motorFightActivityData = MotorFightController.Instance.GetMotorFightActivityData();
			Span<int> preNode = this.Data.PreNode;
			int i;
			Action<AActor> <>9__0;
			int j;
			for (i = 0; i < preNode.Length; i = j + 1)
			{
				int offset = motorFightActivityData.GetMotorFightTalentData(*preNode[i]).Row - this.Data.Row;
				UUIItem prePosItem = this.GetPrePosItem(offset);
				if (this.LineComponentList.Count <= i || this.LineComponentList[i] == null)
				{
					UniTask<AActor> task = LguiUtil.Instance.LoadPrefabByResourceIdAsync("UiItem_MotorFightTogLine", prePosItem, null, ResourceSystem.EResourceLoadPriority.Default, "js_undefined");
					Action<AActor> continuationFunction;
					if ((continuationFunction = <>9__0) == null)
					{
						continuationFunction = (<>9__0 = delegate(AActor prefab)
						{
							if (prefab == null)
							{
								return;
							}
							MotorFightTalentLine component = new MotorFightTalentLine();
							component.CreateThenShowByActorAsync(prefab, null, false).ContinueWith(delegate()
							{
								component.Refresh(this.Data.IsUnLock);
							});
							if (this.LineComponentList.Count <= i)
							{
								this.LineComponentList.AddRange(Enumerable.Repeat<MotorFightTalentLine>(null, i - this.LineComponentList.Count + 1));
							}
							this.LineComponentList[i] = component;
						});
					}
					task.ContinueWith(continuationFunction);
				}
				else
				{
					this.LineComponentList[i].Refresh(this.Data.IsUnLock);
				}
				j = i;
			}
			bool flag = motorFightActivityData.GetTalentCoinNum() >= this.Data.Cost;
			bool flag2 = motorFightActivityData.IsPreNodeAllUnlock(this.Data);
			UUISprite sprite = base.GetSprite(10);
			this.SetSpriteByPath(this.Data.Icon, sprite, false, null, null);
			UUIItem uuiitem = sprite;
			bool bUseChangeColor = !this.Data.IsUnLock;
			FColor? fcolor = new FColor?(sprite.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			bool flag3 = flag2 && this.Data.IsFinishPreCondition && flag;
			base.GetSprite(7).SetUIActive(!flag3 && !this.Data.IsUnLock);
			base.GetSprite(8).SetUIActive(flag3 && !this.Data.IsUnLock);
			base.GetSprite(11).SetUIActive(flag3 && !this.Data.IsUnLock);
			base.GetSprite(9).SetUIActive(this.Data.IsUnLock);
			if (motorFightActivityData.SelectedTalentNodeId == this.Data.Id)
			{
				this.OnClickCallback(this);
			}
		}

		// Token: 0x06040730 RID: 263984 RVA: 0x00F98600 File Offset: 0x00F96800
		public UUIItem GetPrePosItem(int offset)
		{
			if (offset > 0)
			{
				return base.GetItem(3);
			}
			if (offset < 0)
			{
				return base.GetItem(1);
			}
			return base.GetItem(2);
		}

		// Token: 0x06040731 RID: 263985 RVA: 0x00F98621 File Offset: 0x00F96821
		private void OnToggleClick(EToggleState _)
		{
			if (this.OnClickCallback != null)
			{
				this.OnClickCallback(this);
			}
		}

		// Token: 0x06040732 RID: 263986 RVA: 0x00F98637 File Offset: 0x00F96837
		public void SetToggleState(EToggleState state)
		{
			base.GetExtendToggle(0).SetToggleState(state, false, false, false);
		}

		// Token: 0x0402181F RID: 137247
		[Nullable(2)]
		public MotorFightTalentData Data;

		// Token: 0x04021820 RID: 137248
		[Nullable(2)]
		public UUIItem PreItem;

		// Token: 0x04021821 RID: 137249
		public List<MotorFightTalentLine> LineComponentList = new List<MotorFightTalentLine>();

		// Token: 0x04021822 RID: 137250
		[Nullable(2)]
		public UUIItem GridPanelItem;

		// Token: 0x04021823 RID: 137251
		public Action<MotorFightTalentNodeItem> OnClickCallback = delegate(MotorFightTalentNodeItem data)
		{
		};

		// Token: 0x0200C643 RID: 50755
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BDBA RID: 245178
			public const int Toggle = 0;

			// Token: 0x0403BDBB RID: 245179
			public const int PrePos1 = 1;

			// Token: 0x0403BDBC RID: 245180
			public const int PrePos2 = 2;

			// Token: 0x0403BDBD RID: 245181
			public const int PrePos3 = 3;

			// Token: 0x0403BDBE RID: 245182
			public const int OutPos1 = 4;

			// Token: 0x0403BDBF RID: 245183
			public const int OutPos2 = 5;

			// Token: 0x0403BDC0 RID: 245184
			public const int OutPos3 = 6;

			// Token: 0x0403BDC1 RID: 245185
			public const int SpriteLock = 7;

			// Token: 0x0403BDC2 RID: 245186
			public const int SpriteCanUnlock = 8;

			// Token: 0x0403BDC3 RID: 245187
			public const int SpriteUnlock = 9;

			// Token: 0x0403BDC4 RID: 245188
			public const int SpriteIcon = 10;

			// Token: 0x0403BDC5 RID: 245189
			public const int SpriteUp = 11;
		}
	}
}
