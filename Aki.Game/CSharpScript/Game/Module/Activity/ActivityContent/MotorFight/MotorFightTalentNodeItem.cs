using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02005399 RID: 21401
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightTalentNodeItem : UiPanelBase
	{
		// Token: 0x060353ED RID: 218093 RVA: 0x00EDF0F8 File Offset: 0x00EDD2F8
		public MotorFightTalentNodeItem(UUIItem parent, MotorFightTalentData data, UUIItem gridPanelItem)
		{
			this.Data = data2;
			this.PreItem = parent;
			this.GridPanelItem = gridPanelItem;
		}

		// Token: 0x060353EE RID: 218094 RVA: 0x00EDF150 File Offset: 0x00EDD350
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

		// Token: 0x060353EF RID: 218095 RVA: 0x00EDF344 File Offset: 0x00EDD544
		protected override void OnStart()
		{
			base.GetExtendToggle(0).bLockStateOnSelect = true;
		}

		// Token: 0x060353F0 RID: 218096 RVA: 0x00EDF354 File Offset: 0x00EDD554
		[NullableContext(2)]
		public unsafe void Refresh(MotorFightTalentData data = null)
		{
			this.Data = (data ?? this.Data);
			MotorFightActivityData motorFightActivityData = MotorFightController.Instance.GetMotorFightActivityData();
			Span<int> preNode = this.Data.PreNode;
			int i;
			Action<AActor> <>9__0;
			int k;
			for (i = 0; i < preNode.Length; i = k + 1)
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
								int num = i - this.LineComponentList.Count + 1;
								for (int j = 0; j < num; j++)
								{
									this.LineComponentList.Add(null);
								}
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
				k = i;
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

		// Token: 0x060353F1 RID: 218097 RVA: 0x00EDF5A0 File Offset: 0x00EDD7A0
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

		// Token: 0x060353F2 RID: 218098 RVA: 0x00EDF5C1 File Offset: 0x00EDD7C1
		private void OnToggleClick(EToggleState _)
		{
			if (this.OnClickCallback != null)
			{
				this.OnClickCallback(this);
			}
		}

		// Token: 0x060353F3 RID: 218099 RVA: 0x00EDF5D7 File Offset: 0x00EDD7D7
		public void SetToggleState(EToggleState state)
		{
			base.GetExtendToggle(0).SetToggleState(state, false, false, false);
		}

		// Token: 0x0401C14E RID: 115022
		[Nullable(2)]
		public MotorFightTalentData Data;

		// Token: 0x0401C14F RID: 115023
		[Nullable(2)]
		public UUIItem PreItem;

		// Token: 0x0401C150 RID: 115024
		public List<MotorFightTalentLine> LineComponentList = new List<MotorFightTalentLine>();

		// Token: 0x0401C151 RID: 115025
		[Nullable(2)]
		public UUIItem GridPanelItem;

		// Token: 0x0401C152 RID: 115026
		public Action<MotorFightTalentNodeItem> OnClickCallback = delegate(MotorFightTalentNodeItem data)
		{
		};

		// Token: 0x0200B02A RID: 45098
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04036717 RID: 222999
			public const int Toggle = 0;

			// Token: 0x04036718 RID: 223000
			public const int PrePos1 = 1;

			// Token: 0x04036719 RID: 223001
			public const int PrePos2 = 2;

			// Token: 0x0403671A RID: 223002
			public const int PrePos3 = 3;

			// Token: 0x0403671B RID: 223003
			public const int OutPos1 = 4;

			// Token: 0x0403671C RID: 223004
			public const int OutPos2 = 5;

			// Token: 0x0403671D RID: 223005
			public const int OutPos3 = 6;

			// Token: 0x0403671E RID: 223006
			public const int SpriteLock = 7;

			// Token: 0x0403671F RID: 223007
			public const int SpriteCanUnlock = 8;

			// Token: 0x04036720 RID: 223008
			public const int SpriteUnlock = 9;

			// Token: 0x04036721 RID: 223009
			public const int SpriteIcon = 10;

			// Token: 0x04036722 RID: 223010
			public const int SpriteUp = 11;
		}
	}
}
