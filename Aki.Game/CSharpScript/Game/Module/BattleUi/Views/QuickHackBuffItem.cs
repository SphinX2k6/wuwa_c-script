using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DAA RID: 23978
	[NullableContext(2)]
	[Nullable(0)]
	public class QuickHackBuffItem : BuffItemBase
	{
		// Token: 0x0603CE38 RID: 249400 RVA: 0x00EA078C File Offset: 0x00E9E98C
		[NullableContext(1)]
		public QuickHackBuffItem(USceneComponent parentItem)
		{
			AActor quickHackBuffItem = BattleUiControl.Instance.Pool.GetQuickHackBuffItem(parentItem);
			base.CreateThenShowByActor(quickHackBuffItem, null);
		}

		// Token: 0x0603CE39 RID: 249401 RVA: 0x00EA07B8 File Offset: 0x00E9E9B8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CE3A RID: 249402 RVA: 0x00EA0864 File Offset: 0x00E9EA64
		protected override void OnStart()
		{
			this.BarTexture = base.GetTexture(1);
			this.BarTexture.SetFillAmount(0f);
			this.IconTexture = base.GetTexture(2);
			this.IconMaskTexture = base.GetTexture(3);
			this.IconMaskTexture.SetFillAmount(0f);
		}

		// Token: 0x0603CE3B RID: 249403 RVA: 0x00EA08B8 File Offset: 0x00E9EAB8
		public override void Activate(GameplayCue buffCueConfig, IActiveBuff buff, bool playAnim, int buffNum)
		{
			this.Buff = buff;
			if (playAnim)
			{
				this.FillFinishTime = Time.Instance.Now + 200.0;
				this.SetPercent(0f);
				this.StartLoopAudio();
			}
			else
			{
				this.FillFinishTime = 0.0;
				float percent = (buff != null && buff.Duration > 0f) ? (buff.GetRemainDuration() / buff.Duration) : 1f;
				this.SetPercent(percent);
			}
			base.SetUiActive(true);
			string path = buffCueConfig.Path;
			this.IconTexture.SetUIActive(false);
			base.SetTextureByPath(path, this.IconTexture, null, delegate(bool result)
			{
				if (result)
				{
					UUITexture iconTexture = this.IconTexture;
					if (iconTexture == null)
					{
						return;
					}
					iconTexture.SetUIActive(true);
				}
			});
			this.IconMaskTexture.SetUIActive(false);
			base.SetTextureByPath(path, this.IconMaskTexture, null, delegate(bool result)
			{
				if (result)
				{
					UUITexture iconMaskTexture = this.IconMaskTexture;
					if (iconMaskTexture == null)
					{
						return;
					}
					iconMaskTexture.SetUIActive(true);
				}
			});
		}

		// Token: 0x0603CE3C RID: 249404 RVA: 0x00EA09A4 File Offset: 0x00E9EBA4
		public override void Tick(float delta)
		{
			if (this.FillFinishTime > 0.0)
			{
				this.TickFill();
				return;
			}
			if (this.Buff != null && this.Buff.Duration > 0f)
			{
				this.SetPercent(this.Buff.GetRemainDuration() / this.Buff.Duration);
			}
		}

		// Token: 0x0603CE3D RID: 249405 RVA: 0x00EA0A00 File Offset: 0x00E9EC00
		private void TickFill()
		{
			double now = Time.Instance.Now;
			float num = (float)(1.0 - (this.FillFinishTime - now) / 200.0);
			if (num >= 1f)
			{
				this.SetPercent(1f);
				this.FillFinishTime = 0.0;
				this.StopLoopAudio();
				AudioSystem.Instance.PostEvent("play_role_lucy_bat_burst01_qh_done");
				return;
			}
			this.SetPercent(num);
		}

		// Token: 0x0603CE3E RID: 249406 RVA: 0x00EA0A76 File Offset: 0x00E9EC76
		private void SetPercent(float percent)
		{
			if (percent == this.Percent)
			{
				return;
			}
			this.Percent = percent;
			UUITexture barTexture = this.BarTexture;
			if (barTexture != null)
			{
				barTexture.SetFillAmount(percent);
			}
			UUITexture iconMaskTexture = this.IconMaskTexture;
			if (iconMaskTexture == null)
			{
				return;
			}
			iconMaskTexture.SetFillAmount(percent);
		}

		// Token: 0x0603CE3F RID: 249407 RVA: 0x00EA0AAC File Offset: 0x00E9ECAC
		public override bool TickHiding(float delta)
		{
			if (this.FillFinishTime > 0.0)
			{
				this.TickFill();
				return true;
			}
			base.SetUiActive(false);
			return false;
		}

		// Token: 0x0603CE40 RID: 249408 RVA: 0x00EA0ACF File Offset: 0x00E9ECCF
		public override void Deactivate()
		{
			base.SetUiActive(false);
			this.FillFinishTime = 0.0;
		}

		// Token: 0x0603CE41 RID: 249409 RVA: 0x00EA0AE7 File Offset: 0x00E9ECE7
		public override void DeactivateWithCloseAnim()
		{
		}

		// Token: 0x0603CE42 RID: 249410 RVA: 0x00EA0AE9 File Offset: 0x00E9ECE9
		protected override bool DestroyOverride()
		{
			if (this.RootActor != null)
			{
				BattleUiControl.Instance.Pool.RecycleQuickHackBuffItem(this.RootActor);
			}
			return true;
		}

		// Token: 0x0603CE43 RID: 249411 RVA: 0x00EA0B0C File Offset: 0x00E9ED0C
		private void StartLoopAudio()
		{
			if (this.LoopAudioEventHandle != 0)
			{
				return;
			}
			int num = AudioSystem.Instance.PostEvent("play_role_lucy_bat_burst01_qh_loop");
			if (num != 0)
			{
				this.LoopAudioEventHandle = num;
				EventSystem.Instance.Add(EEventName.OnQuickHackClose, new Action(this.OnQuickHackClose));
			}
		}

		// Token: 0x0603CE44 RID: 249412 RVA: 0x00EA0B58 File Offset: 0x00E9ED58
		private void OnQuickHackClose()
		{
			this.StopLoopAudio();
		}

		// Token: 0x0603CE45 RID: 249413 RVA: 0x00EA0B60 File Offset: 0x00E9ED60
		private void StopLoopAudio()
		{
			if (this.LoopAudioEventHandle == 0)
			{
				return;
			}
			AudioSystem.Instance.ExecuteAction(this.LoopAudioEventHandle, EAudioActionType.Stop, null);
			this.LoopAudioEventHandle = 0;
			EventSystem.Instance.Remove(EEventName.OnQuickHackClose, new Action(this.OnQuickHackClose));
		}

		// Token: 0x0401FB71 RID: 129905
		private const double ACTIVATE_FILL_TIME = 200.0;

		// Token: 0x0401FB72 RID: 129906
		private IActiveBuff Buff;

		// Token: 0x0401FB73 RID: 129907
		private UUITexture BarTexture;

		// Token: 0x0401FB74 RID: 129908
		private UUITexture IconTexture;

		// Token: 0x0401FB75 RID: 129909
		private UUITexture IconMaskTexture;

		// Token: 0x0401FB76 RID: 129910
		private float Percent;

		// Token: 0x0401FB77 RID: 129911
		private double FillFinishTime;

		// Token: 0x0401FB78 RID: 129912
		private int LoopAudioEventHandle;

		// Token: 0x0200C085 RID: 49285
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0403A18D RID: 237965
			public const int BgTexture = 0;

			// Token: 0x0403A18E RID: 237966
			public const int BarTexture = 1;

			// Token: 0x0403A18F RID: 237967
			public const int IconTexture = 2;

			// Token: 0x0403A190 RID: 237968
			public const int IconMaskTexture = 3;
		}
	}
}
