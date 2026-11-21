using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D14 RID: 19732
	public class GuestItem : BattleChildView
	{
		// Token: 0x06031774 RID: 202612 RVA: 0x00DD48A4 File Offset: 0x00DD2AA4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031775 RID: 202613 RVA: 0x00DD4994 File Offset: 0x00DD2B94
		protected override void OnShowBattleChildView()
		{
			EventSystem.Instance.Add(EEventName.PlotShowTalk, new Action<ITalkItem, bool>(this.OnShowTalk));
			EventSystem.Instance.Add(EEventName.PlotEndShowTalk, new Action(this.OnShowTalkEnd));
			EventSystem.Instance.Add(EEventName.ShowGuestEffect, new Action<bool>(this.OnGuestEffect));
		}

		// Token: 0x06031776 RID: 202614 RVA: 0x00DD49F8 File Offset: 0x00DD2BF8
		protected override void OnHideBattleChildView()
		{
			EventSystem.Instance.Remove(EEventName.PlotShowTalk, new Action<ITalkItem, bool>(this.OnShowTalk));
			EventSystem.Instance.Remove(EEventName.PlotEndShowTalk, new Action(this.OnShowTalkEnd));
			EventSystem.Instance.Remove(EEventName.ShowGuestEffect, new Action<bool>(this.OnGuestEffect));
		}

		// Token: 0x06031777 RID: 202615 RVA: 0x00DD4A5C File Offset: 0x00DD2C5C
		[NullableContext(1)]
		private void OnShowTalk(ITalkItem talkItem, bool bShow)
		{
			if (!bShow)
			{
				return;
			}
			if (talkItem.WhoId != null)
			{
				HashSet<int> speakerSet = this.SpeakerSet;
				if (speakerSet != null && speakerSet.Contains(talkItem.WhoId.Value))
				{
					if (this.IsSpeaking)
					{
						return;
					}
					this.IsSpeaking = true;
					TArray<UActorComponent> tarray = base.GetItem(1).GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
					for (int i = 0; i < tarray.Num(); i++)
					{
						((ULGUIPlayTweenComponent)tarray.Get(i)).Play();
					}
					return;
				}
			}
			this.OnShowTalkEnd();
		}

		// Token: 0x06031778 RID: 202616 RVA: 0x00DD4AF4 File Offset: 0x00DD2CF4
		private void OnShowTalkEnd()
		{
			if (!this.IsSpeaking)
			{
				return;
			}
			this.IsSpeaking = false;
			TArray<UActorComponent> tarray = base.GetItem(2).GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
			for (int i = 0; i < tarray.Num(); i++)
			{
				((ULGUIPlayTweenComponent)tarray.Get(i)).Play();
			}
		}

		// Token: 0x06031779 RID: 202617 RVA: 0x00DD4B50 File Offset: 0x00DD2D50
		private void OnGuestEffect(bool bShow)
		{
			GuestItem.EChildType name = bShow ? GuestItem.EChildType.BuffInAnim : GuestItem.EChildType.BuffOutAnim;
			TArray<UActorComponent> tarray = base.GetItem((int)name).GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
			for (int i = 0; i < tarray.Num(); i++)
			{
				((ULGUIPlayTweenComponent)tarray.Get(i)).Play();
			}
		}

		// Token: 0x0603177A RID: 202618 RVA: 0x00DD4BA4 File Offset: 0x00DD2DA4
		protected override UniTask OnBeforeStartAsync()
		{
			GuestItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GuestItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603177B RID: 202619 RVA: 0x00DD4BE7 File Offset: 0x00DD2DE7
		protected override void OnAfterShow()
		{
			if (BattleUiModel.Instance.GuestEffect)
			{
				this.OnGuestEffect(true);
			}
		}

		// Token: 0x0603177C RID: 202620 RVA: 0x00DD4BFC File Offset: 0x00DD2DFC
		public UniTask SetGuest(int id)
		{
			GuestItem.<SetGuest>d__11 <SetGuest>d__;
			<SetGuest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetGuest>d__.<>4__this = this;
			<SetGuest>d__.id = id;
			<SetGuest>d__.<>1__state = -1;
			<SetGuest>d__.<>t__builder.Start<GuestItem.<SetGuest>d__11>(ref <SetGuest>d__);
			return <SetGuest>d__.<>t__builder.Task;
		}

		// Token: 0x0401A31F RID: 107295
		[Nullable(2)]
		private HashSet<int> SpeakerSet;

		// Token: 0x0401A320 RID: 107296
		private bool IsSpeaking;

		// Token: 0x0200A9CF RID: 43471
		private enum EChildType
		{
			// Token: 0x0403477C RID: 214908
			HeadIcon,
			// Token: 0x0403477D RID: 214909
			TalkInAnim,
			// Token: 0x0403477E RID: 214910
			TalkOutAnim,
			// Token: 0x0403477F RID: 214911
			BuffInAnim,
			// Token: 0x04034780 RID: 214912
			BuffOutAnim,
			// Token: 0x04034781 RID: 214913
			BuffNiagara
		}
	}
}
