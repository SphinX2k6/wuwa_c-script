using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x020053AD RID: 21421
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleBuffItem : UiPanelBase
	{
		// Token: 0x06036BCC RID: 224204 RVA: 0x00CF44F4 File Offset: 0x00CF26F4
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

		// Token: 0x06036BCD RID: 224205 RVA: 0x00CF4548 File Offset: 0x00CF2748
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

		// Token: 0x06036BCE RID: 224206 RVA: 0x00CF4634 File Offset: 0x00CF2834
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

		// Token: 0x06036BCF RID: 224207 RVA: 0x00CF4678 File Offset: 0x00CF2878
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

		// Token: 0x06036BD0 RID: 224208 RVA: 0x00CF46AC File Offset: 0x00CF28AC
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

		// Token: 0x06036BD1 RID: 224209 RVA: 0x00CF46EC File Offset: 0x00CF28EC
		public void SetStateActive()
		{
			this.SetStarState(true);
			this.SetLockState(false);
			this.SetStateItemShow(3);
			this.SetIcon(this.BuffData.Config.IconPathActive);
			this.UseIconChangeColor(true);
		}

		// Token: 0x06036BD2 RID: 224210 RVA: 0x00CF4720 File Offset: 0x00CF2920
		public void SetStateTempActive()
		{
			this.SetStarState(true);
			this.SetLockState(false);
			this.SetStateItemShow(2);
			this.SetIcon(this.BuffData.Config.IconPathActive);
			this.UseIconChangeColor(true);
		}

		// Token: 0x06036BD3 RID: 224211 RVA: 0x00CF4754 File Offset: 0x00CF2954
		public void SetStateNotActive()
		{
			this.SetStarState(false);
			this.SetLockState(true);
			this.SetStateItemShow(4);
			this.SetIcon(this.BuffData.Config.IconPathNormal);
			this.UseIconChangeColor(false);
		}

		// Token: 0x06036BD4 RID: 224212 RVA: 0x00CF4788 File Offset: 0x00CF2988
		private void SetStarState(bool show)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(show);
		}

		// Token: 0x06036BD5 RID: 224213 RVA: 0x00CF479C File Offset: 0x00CF299C
		private void SetLockState(bool show)
		{
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(show);
		}

		// Token: 0x06036BD6 RID: 224214 RVA: 0x00CF47B0 File Offset: 0x00CF29B0
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

		// Token: 0x06036BD7 RID: 224215 RVA: 0x00CF47F8 File Offset: 0x00CF29F8
		private void SetIcon(string path)
		{
			UUITexture texture = base.GetTexture(5);
			base.SetTextureByPath(path, texture, null, null);
		}

		// Token: 0x06036BD8 RID: 224216 RVA: 0x00CF4820 File Offset: 0x00CF2A20
		private void UseIconChangeColor(bool isUse)
		{
			UUITexture texture = base.GetTexture(5);
			UUIItem uuiitem = texture;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(isUse, fcolor);
		}

		// Token: 0x06036BD9 RID: 224217 RVA: 0x00CF484A File Offset: 0x00CF2A4A
		private void OnToggleBuffRoot(EToggleState toggleState)
		{
			Action<MoraleBuffData> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.BuffData);
		}

		// Token: 0x0401CE5F RID: 118367
		public MoraleBuffData BuffData;

		// Token: 0x0401CE60 RID: 118368
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<MoraleBuffData> ClickCallback;

		// Token: 0x0200B641 RID: 46657
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04037361 RID: 226145
			public const int SpriteStarActive = 0;

			// Token: 0x04037362 RID: 226146
			public const int ToggleBuffRoot = 1;

			// Token: 0x04037363 RID: 226147
			public const int ItemTempActive = 2;

			// Token: 0x04037364 RID: 226148
			public const int ItemActive = 3;

			// Token: 0x04037365 RID: 226149
			public const int ItemUnActive = 4;

			// Token: 0x04037366 RID: 226150
			public const int TextureIcon = 5;

			// Token: 0x04037367 RID: 226151
			public const int TextNum = 6;

			// Token: 0x04037368 RID: 226152
			public const int ItemLock = 7;
		}
	}
}
