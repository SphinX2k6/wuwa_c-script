using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020055AF RID: 21935
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingLevelUpTips : UiTickViewBase
	{
		// Token: 0x0603660E RID: 222734 RVA: 0x00F2EDFB File Offset: 0x00F2CFFB
		public FishingLevelUpTips(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603660F RID: 222735 RVA: 0x00F2EE0C File Offset: 0x00F2D00C
		protected unsafe override void OnRegisterComponent()
		{
			this.ExpData = (this.OpenParam as FishingLevelUpData);
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06036610 RID: 222736 RVA: 0x00F2EEEC File Offset: 0x00F2D0EC
		protected override UniTask OnBeforeStartAsync()
		{
			FishingLevelUpTips.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingLevelUpTips.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036611 RID: 222737 RVA: 0x00F2EF30 File Offset: 0x00F2D130
		protected override void OnStart()
		{
			this.AddText = base.GetText(1);
			this.SpriteBar = base.GetSprite(2);
			this.Level = this.ExpData.LastLevel;
			this.CurrentExp = (float)this.ExpData.LastExp;
			this.CurrentMaxExp = this.ExpData.GetMaxExpByLevel(this.Level);
			LguiUtil.Instance.SetLocalTextNew(this.AddText, "Fishing_Experience", new <>z__ReadOnlySingleElementList<object>(this.ExpData.AddExp));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "Fishing_Level", Array.Empty<object>());
			base.GetText(0).SetText(this.Level.ToString(), true);
		}

		// Token: 0x06036612 RID: 222738 RVA: 0x00F2EFF0 File Offset: 0x00F2D1F0
		protected override void OnTick(float delta)
		{
			if (!this.IsTick)
			{
				return;
			}
			if (this.DeltaAddExp >= (float)this.ExpData.AddExp)
			{
				base.CloseMe(null);
				this.IsTick = false;
				return;
			}
			this.RefreshExp((float)this.ExpData.AddExp * 1f / 2000f * delta);
		}

		// Token: 0x06036613 RID: 222739 RVA: 0x00F2F04C File Offset: 0x00F2D24C
		private void RefreshExp(float addExp)
		{
			this.DeltaAddExp += addExp;
			this.CurrentExp = MathUtils.Instance.Clamp(this.CurrentExp + addExp, this.CurrentExp, (float)this.CurrentMaxExp);
			this.SpriteBar.SetFillAmount(this.CurrentExp / (float)this.CurrentMaxExp);
			if (this.CurrentExp >= (float)this.CurrentMaxExp && this.Level < this.ExpData.CurrentLevel)
			{
				this.Level++;
				this.CurrentExp = 0f;
				this.CurrentMaxExp = this.ExpData.GetMaxExpByLevel(this.Level);
				base.GetText(0).SetText(this.Level.ToString(), true);
			}
		}

		// Token: 0x0401CB0C RID: 117516
		private const int TICK_TIME = 2000;

		// Token: 0x0401CB0D RID: 117517
		protected FishingLevelUpData ExpData;

		// Token: 0x0401CB0E RID: 117518
		protected int Level;

		// Token: 0x0401CB0F RID: 117519
		protected float CurrentExp;

		// Token: 0x0401CB10 RID: 117520
		protected float DeltaAddExp;

		// Token: 0x0401CB11 RID: 117521
		protected int CurrentMaxExp;

		// Token: 0x0401CB12 RID: 117522
		protected bool IsTick = true;

		// Token: 0x0401CB13 RID: 117523
		protected UUIText AddText;

		// Token: 0x0401CB14 RID: 117524
		protected UUISprite SpriteBar;

		// Token: 0x0200B22F RID: 45615
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403715C RID: 225628
			public const int LevelNum = 0;

			// Token: 0x0403715D RID: 225629
			public const int AddText = 1;

			// Token: 0x0403715E RID: 225630
			public const int SpriteBar = 2;

			// Token: 0x0403715F RID: 225631
			public const int Title = 3;

			// Token: 0x04037160 RID: 225632
			public const int Texture = 4;
		}
	}
}
