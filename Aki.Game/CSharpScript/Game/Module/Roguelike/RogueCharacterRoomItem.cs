using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DF7 RID: 19959
	public class RogueCharacterRoomItem : GridProxyAbstract<int>
	{
		// Token: 0x0603380E RID: 210958 RVA: 0x00C08B88 File Offset: 0x00C06D88
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.ToggleCallBackInternal));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603380F RID: 210959 RVA: 0x00C08C94 File Offset: 0x00C06E94
		protected override UniTask OnBeforeStartAsync()
		{
			RogueCharacterRoomItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueCharacterRoomItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033810 RID: 210960 RVA: 0x00C08CD7 File Offset: 0x00C06ED7
		[NullableContext(1)]
		private CommonElementItem CreateElement()
		{
			return new CommonElementItem();
		}

		// Token: 0x06033811 RID: 210961 RVA: 0x00C08CDE File Offset: 0x00C06EDE
		public void SetItemToggleState(EToggleState state)
		{
			base.GetExtendToggle(3).SetToggleState(state, false, false, false);
		}

		// Token: 0x06033812 RID: 210962 RVA: 0x00C08CF1 File Offset: 0x00C06EF1
		private void ToggleCallBackInternal(EToggleState state)
		{
			if (this.ClickCallback != null)
			{
				this.ClickCallback(base.GridIndex, this.IsSelectRoom(), this.RoomId);
			}
		}

		// Token: 0x06033813 RID: 210963 RVA: 0x00C08D18 File Offset: 0x00C06F18
		public override void OnDeselected(bool fireEvent)
		{
			this.SetItemToggleState(EToggleState.ETT_UnChecked);
		}

		// Token: 0x06033814 RID: 210964 RVA: 0x00C08D21 File Offset: 0x00C06F21
		public override void OnSelected(bool fireEvent)
		{
			this.SetItemToggleState(EToggleState.ETT_Checked);
		}

		// Token: 0x06033815 RID: 210965 RVA: 0x00C08D2A File Offset: 0x00C06F2A
		public bool IsSelectRoom()
		{
			return base.GetExtendToggle(3).GetToggleState() == EToggleState.ETT_Checked;
		}

		// Token: 0x06033816 RID: 210966 RVA: 0x00C08D3C File Offset: 0x00C06F3C
		public override void Refresh(int roomId, bool isSelected, int gridIndex)
		{
			this.RoomId = roomId;
			RogueRoomShowConfig? rogueRoomShowConfig = RoguelikeConfig.Instance.GetRogueRoomShowConfig(roomId);
			if (rogueRoomShowConfig == null)
			{
				return;
			}
			RogueBuffPool? rogueBuffConfig = RoguelikeConfig.Instance.GetRogueBuffConfig(rogueRoomShowConfig.Value.BuffId);
			if (rogueBuffConfig == null)
			{
				return;
			}
			List<int> list = null;
			foreach (DicIntInt dicIntInt in rogueBuffConfig.Value.BuffElementIter())
			{
				int key = dicIntInt.Key;
				int value = dicIntInt.Value;
				list = new List<int>();
				for (int i = 0; i < value; i++)
				{
					list.Add(key);
				}
			}
			if (list != null)
			{
				GenericLayout<CommonElementItem, int> genericLayout = this.GenericLayout;
				if (genericLayout != null)
				{
					genericLayout.RefreshByData(list, null, false);
				}
			}
			base.SetTextureByPath(rogueRoomShowConfig.Value.Icon, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), rogueRoomShowConfig.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), rogueRoomShowConfig.Value.Desc, Array.Empty<object>());
		}

		// Token: 0x0401B546 RID: 111942
		[Nullable(2)]
		public Action<int, bool, int> ClickCallback;

		// Token: 0x0401B547 RID: 111943
		public int RoomId = -1;

		// Token: 0x0401B548 RID: 111944
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonElementItem, int> GenericLayout;

		// Token: 0x0200AF80 RID: 44928
		private class ERogueCharacterRoomItemDefine
		{
			// Token: 0x0403549E RID: 218270
			public const int TextureIcon = 0;

			// Token: 0x0403549F RID: 218271
			public const int TxtName = 1;

			// Token: 0x040354A0 RID: 218272
			public const int TxtDesc = 2;

			// Token: 0x040354A1 RID: 218273
			public const int ExtendToggle = 3;

			// Token: 0x040354A2 RID: 218274
			public const int ElementLayout = 4;
		}
	}
}
