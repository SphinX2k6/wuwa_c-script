using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x02004390 RID: 17296
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleBuffItem : UiPanelBase
	{
		// Token: 0x0602BB12 RID: 178962 RVA: 0x00C4359C File Offset: 0x00C4179C
		public UniTask Init(UUIItem item, MoraleBuffData data)
		{
			MoraleBuffItem.<Init>d__3 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.data = data;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MoraleBuffItem.<Init>d__3>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602BB13 RID: 178963 RVA: 0x00C435F0 File Offset: 0x00C417F0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUITexture)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnToggleBuffRoot))
			};
		}

		// Token: 0x0602BB14 RID: 178964 RVA: 0x00C436DC File Offset: 0x00C418DC
		public void UpdateData()
		{
			UUIText text = base.GetText(6);
			if (text != null)
			{
				text.SetText(this.BuffData.Config.LvStage.ToString(), true);
			}
			this.UpdateToggleState();
			this.UpdateState();
		}

		// Token: 0x0602BB15 RID: 178965 RVA: 0x00C43720 File Offset: 0x00C41920
		public void UpdateToggleState()
		{
			EToggleState state = this.BuffData.IsSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x0602BB16 RID: 178966 RVA: 0x00C43754 File Offset: 0x00C41954
		public void UpdateState()
		{
			switch (this.BuffData.GetActiveState())
			{
			case EMoraleBuffState.TempActive:
				this.SetStateTempActive();
				return;
			case EMoraleBuffState.Active:
				this.SetStateActive();
				return;
			case EMoraleBuffState.NotActive:
				this.SetStateNotActive();
				return;
			default:
				return;
			}
		}

		// Token: 0x0602BB17 RID: 178967 RVA: 0x00C43794 File Offset: 0x00C41994
		public void SetStateActive()
		{
			this.SetStarState(true);
			this.SetLockState(false);
			this.SetStateItemShow(3);
			this.SetIcon(this.BuffData.Config.IconPathActive);
			this.UseIconChangeColor(true);
		}

		// Token: 0x0602BB18 RID: 178968 RVA: 0x00C437C8 File Offset: 0x00C419C8
		public void SetStateTempActive()
		{
			this.SetStarState(true);
			this.SetLockState(false);
			this.SetStateItemShow(2);
			this.SetIcon(this.BuffData.Config.IconPathActive);
			this.UseIconChangeColor(true);
		}

		// Token: 0x0602BB19 RID: 178969 RVA: 0x00C437FC File Offset: 0x00C419FC
		public void SetStateNotActive()
		{
			this.SetStarState(false);
			this.SetLockState(true);
			this.SetStateItemShow(4);
			this.SetIcon(this.BuffData.Config.IconPathNormal);
			this.UseIconChangeColor(false);
		}

		// Token: 0x0602BB1A RID: 178970 RVA: 0x00C43830 File Offset: 0x00C41A30
		private void SetStarState(bool show)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(show);
		}

		// Token: 0x0602BB1B RID: 178971 RVA: 0x00C43844 File Offset: 0x00C41A44
		private void SetLockState(bool show)
		{
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(show);
		}

		// Token: 0x0602BB1C RID: 178972 RVA: 0x00C43858 File Offset: 0x00C41A58
		private void SetStateItemShow(int index)
		{
			foreach (int num in new int[]
			{
				3,
				2,
				4
			})
			{
				UUIItem item = base.GetItem(num);
				if (item != null)
				{
					item.SetUIActive(index == num);
				}
			}
		}

		// Token: 0x0602BB1D RID: 178973 RVA: 0x00C438A0 File Offset: 0x00C41AA0
		private void SetIcon(string path)
		{
			UUITexture texture = base.GetTexture(5);
			base.SetTextureByPath(path, texture, null, null);
		}

		// Token: 0x0602BB1E RID: 178974 RVA: 0x00C438C8 File Offset: 0x00C41AC8
		private void UseIconChangeColor(bool isUse)
		{
			UUITexture texture = base.GetTexture(5);
			UUIItem uuiitem = texture;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(isUse, fcolor);
		}

		// Token: 0x0602BB1F RID: 178975 RVA: 0x00C438F2 File Offset: 0x00C41AF2
		private void OnToggleBuffRoot(EToggleState toggleState)
		{
			Action<MoraleBuffData> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.BuffData);
		}

		// Token: 0x040178F7 RID: 96503
		public MoraleBuffData BuffData;

		// Token: 0x040178F8 RID: 96504
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<MoraleBuffData> ClickCallback;

		// Token: 0x0200A079 RID: 41081
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04031DB6 RID: 204214
			public const int SpriteStarActive = 0;

			// Token: 0x04031DB7 RID: 204215
			public const int ToggleBuffRoot = 1;

			// Token: 0x04031DB8 RID: 204216
			public const int ItemTempActive = 2;

			// Token: 0x04031DB9 RID: 204217
			public const int ItemActive = 3;

			// Token: 0x04031DBA RID: 204218
			public const int ItemUnActive = 4;

			// Token: 0x04031DBB RID: 204219
			public const int TextureIcon = 5;

			// Token: 0x04031DBC RID: 204220
			public const int TextNum = 6;

			// Token: 0x04031DBD RID: 204221
			public const int ItemLock = 7;
		}
	}
}
