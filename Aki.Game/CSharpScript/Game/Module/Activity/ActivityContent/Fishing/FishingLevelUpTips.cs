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
	// Token: 0x02006631 RID: 26161
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingLevelUpTips : UiTickViewBase
	{
		// Token: 0x06041949 RID: 268617 RVA: 0x00FE7D43 File Offset: 0x00FE5F43
		public FishingLevelUpTips(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0604194A RID: 268618 RVA: 0x00FE7D54 File Offset: 0x00FE5F54
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

		// Token: 0x0604194B RID: 268619 RVA: 0x00FE7E34 File Offset: 0x00FE6034
		protected override UniTask OnBeforeStartAsync()
		{
			FishingLevelUpTips.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingLevelUpTips.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604194C RID: 268620 RVA: 0x00FE7E78 File Offset: 0x00FE6078
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

		// Token: 0x0604194D RID: 268621 RVA: 0x00FE7F38 File Offset: 0x00FE6138
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

		// Token: 0x0604194E RID: 268622 RVA: 0x00FE7F94 File Offset: 0x00FE6194
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

		// Token: 0x040221DB RID: 139739
		private const int TICK_TIME = 2000;

		// Token: 0x040221DC RID: 139740
		protected FishingLevelUpData ExpData;

		// Token: 0x040221DD RID: 139741
		protected int Level;

		// Token: 0x040221DE RID: 139742
		protected float CurrentExp;

		// Token: 0x040221DF RID: 139743
		protected float DeltaAddExp;

		// Token: 0x040221E0 RID: 139744
		protected int CurrentMaxExp;

		// Token: 0x040221E1 RID: 139745
		protected bool IsTick = true;

		// Token: 0x040221E2 RID: 139746
		protected UUIText AddText;

		// Token: 0x040221E3 RID: 139747
		protected UUISprite SpriteBar;

		// Token: 0x0200C84D RID: 51277
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C817 RID: 247831
			public const int LevelNum = 0;

			// Token: 0x0403C818 RID: 247832
			public const int AddText = 1;

			// Token: 0x0403C819 RID: 247833
			public const int SpriteBar = 2;

			// Token: 0x0403C81A RID: 247834
			public const int Title = 3;

			// Token: 0x0403C81B RID: 247835
			public const int Texture = 4;
		}
	}
}
