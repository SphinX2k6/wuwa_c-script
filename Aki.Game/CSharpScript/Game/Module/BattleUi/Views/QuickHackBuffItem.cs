using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D8E RID: 19854
	[NullableContext(2)]
	[Nullable(0)]
	public class QuickHackBuffItem : BuffItemBase
	{
		// Token: 0x06031DAF RID: 204207 RVA: 0x00DF1638 File Offset: 0x00DEF838
		[NullableContext(1)]
		public QuickHackBuffItem(USceneComponent parentItem)
		{
			AActor quickHackBuffItem = BattleUiControl.Instance.Pool.GetQuickHackBuffItem(parentItem);
			base.CreateThenShowByActor(quickHackBuffItem, null);
		}

		// Token: 0x06031DB0 RID: 204208 RVA: 0x00DF1664 File Offset: 0x00DEF864
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

		// Token: 0x06031DB1 RID: 204209 RVA: 0x00DF1710 File Offset: 0x00DEF910
		protected override void OnStart()
		{
			this.BarTexture = base.GetTexture(1);
			this.BarTexture.SetFillAmount(0f);
			this.IconTexture = base.GetTexture(2);
			this.IconMaskTexture = base.GetTexture(3);
			this.IconMaskTexture.SetFillAmount(0f);
		}

		// Token: 0x06031DB2 RID: 204210 RVA: 0x00DF1764 File Offset: 0x00DEF964
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

		// Token: 0x06031DB3 RID: 204211 RVA: 0x00DF1850 File Offset: 0x00DEFA50
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

		// Token: 0x06031DB4 RID: 204212 RVA: 0x00DF18AC File Offset: 0x00DEFAAC
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

		// Token: 0x06031DB5 RID: 204213 RVA: 0x00DF1922 File Offset: 0x00DEFB22
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

		// Token: 0x06031DB6 RID: 204214 RVA: 0x00DF1958 File Offset: 0x00DEFB58
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

		// Token: 0x06031DB7 RID: 204215 RVA: 0x00DF197B File Offset: 0x00DEFB7B
		public override void Deactivate()
		{
			base.SetUiActive(false);
			this.FillFinishTime = 0.0;
		}

		// Token: 0x06031DB8 RID: 204216 RVA: 0x00DF1993 File Offset: 0x00DEFB93
		public override void DeactivateWithCloseAnim()
		{
		}

		// Token: 0x06031DB9 RID: 204217 RVA: 0x00DF1995 File Offset: 0x00DEFB95
		protected override bool DestroyOverride()
		{
			if (this.RootActor != null)
			{
				BattleUiControl.Instance.Pool.RecycleQuickHackBuffItem(this.RootActor);
			}
			return true;
		}

		// Token: 0x06031DBA RID: 204218 RVA: 0x00DF19B8 File Offset: 0x00DEFBB8
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

		// Token: 0x06031DBB RID: 204219 RVA: 0x00DF1A04 File Offset: 0x00DEFC04
		private void OnQuickHackClose()
		{
			this.StopLoopAudio();
		}

		// Token: 0x06031DBC RID: 204220 RVA: 0x00DF1A0C File Offset: 0x00DEFC0C
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

		// Token: 0x0401A62E RID: 108078
		private const double ACTIVATE_FILL_TIME = 200.0;

		// Token: 0x0401A62F RID: 108079
		private IActiveBuff Buff;

		// Token: 0x0401A630 RID: 108080
		private UUITexture BarTexture;

		// Token: 0x0401A631 RID: 108081
		private UUITexture IconTexture;

		// Token: 0x0401A632 RID: 108082
		private UUITexture IconMaskTexture;

		// Token: 0x0401A633 RID: 108083
		private float Percent;

		// Token: 0x0401A634 RID: 108084
		private double FillFinishTime;

		// Token: 0x0401A635 RID: 108085
		private int LoopAudioEventHandle;

		// Token: 0x0200AA8F RID: 43663
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04034B61 RID: 215905
			public const int BgTexture = 0;

			// Token: 0x04034B62 RID: 215906
			public const int BarTexture = 1;

			// Token: 0x04034B63 RID: 215907
			public const int IconTexture = 2;

			// Token: 0x04034B64 RID: 215908
			public const int IconMaskTexture = 3;
		}
	}
}
