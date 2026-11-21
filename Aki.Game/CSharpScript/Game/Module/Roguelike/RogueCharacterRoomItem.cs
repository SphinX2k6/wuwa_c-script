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
	// Token: 0x02003DC0 RID: 15808
	public class RogueCharacterRoomItem : GridProxyAbstract<int>
	{
		// Token: 0x06028679 RID: 165497 RVA: 0x00B52098 File Offset: 0x00B50298
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

		// Token: 0x0602867A RID: 165498 RVA: 0x00B521A4 File Offset: 0x00B503A4
		protected override UniTask OnBeforeStartAsync()
		{
			RogueCharacterRoomItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueCharacterRoomItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602867B RID: 165499 RVA: 0x00B521E7 File Offset: 0x00B503E7
		[NullableContext(1)]
		private CommonElementItem CreateElement()
		{
			return new CommonElementItem();
		}

		// Token: 0x0602867C RID: 165500 RVA: 0x00B521EE File Offset: 0x00B503EE
		public void SetItemToggleState(EToggleState state)
		{
			base.GetExtendToggle(3).SetToggleState(state, false, false, false);
		}

		// Token: 0x0602867D RID: 165501 RVA: 0x00B52201 File Offset: 0x00B50401
		private void ToggleCallBackInternal(EToggleState state)
		{
			if (this.ClickCallback != null)
			{
				this.ClickCallback(base.GridIndex, this.IsSelectRoom(), this.RoomId);
			}
		}

		// Token: 0x0602867E RID: 165502 RVA: 0x00B52228 File Offset: 0x00B50428
		public override void OnDeselected(bool fireEvent)
		{
			this.SetItemToggleState(EToggleState.ETT_UnChecked);
		}

		// Token: 0x0602867F RID: 165503 RVA: 0x00B52231 File Offset: 0x00B50431
		public override void OnSelected(bool fireEvent)
		{
			this.SetItemToggleState(EToggleState.ETT_Checked);
		}

		// Token: 0x06028680 RID: 165504 RVA: 0x00B5223A File Offset: 0x00B5043A
		public bool IsSelectRoom()
		{
			return base.GetExtendToggle(3).GetToggleState() == EToggleState.ETT_Checked;
		}

		// Token: 0x06028681 RID: 165505 RVA: 0x00B5224C File Offset: 0x00B5044C
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

		// Token: 0x04015F19 RID: 89881
		[Nullable(2)]
		public Action<int, bool, int> ClickCallback;

		// Token: 0x04015F1A RID: 89882
		public int RoomId = -1;

		// Token: 0x04015F1B RID: 89883
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonElementItem, int> GenericLayout;

		// Token: 0x020099B5 RID: 39349
		private class ERogueCharacterRoomItemDefine
		{
			// Token: 0x0402FED1 RID: 196305
			public const int TextureIcon = 0;

			// Token: 0x0402FED2 RID: 196306
			public const int TxtName = 1;

			// Token: 0x0402FED3 RID: 196307
			public const int TxtDesc = 2;

			// Token: 0x0402FED4 RID: 196308
			public const int ExtendToggle = 3;

			// Token: 0x0402FED5 RID: 196309
			public const int ElementLayout = 4;
		}
	}
}
