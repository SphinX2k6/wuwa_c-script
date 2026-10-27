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
	// Token: 0x02005D32 RID: 23858
	public class GuestItem : BattleChildView
	{
		// Token: 0x0603C81B RID: 247835 RVA: 0x00E84104 File Offset: 0x00E82304
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

		// Token: 0x0603C81C RID: 247836 RVA: 0x00E841F4 File Offset: 0x00E823F4
		protected override void OnShowBattleChildView()
		{
			EventSystem.Instance.Add(EEventName.PlotShowTalk, new Action<ITalkItem, bool>(this.OnShowTalk));
			EventSystem.Instance.Add(EEventName.PlotEndShowTalk, new Action(this.OnShowTalkEnd));
			EventSystem.Instance.Add(EEventName.ShowGuestEffect, new Action<bool>(this.OnGuestEffect));
		}

		// Token: 0x0603C81D RID: 247837 RVA: 0x00E84258 File Offset: 0x00E82458
		protected override void OnHideBattleChildView()
		{
			EventSystem.Instance.Remove(EEventName.PlotShowTalk, new Action<ITalkItem, bool>(this.OnShowTalk));
			EventSystem.Instance.Remove(EEventName.PlotEndShowTalk, new Action(this.OnShowTalkEnd));
			EventSystem.Instance.Remove(EEventName.ShowGuestEffect, new Action<bool>(this.OnGuestEffect));
		}

		// Token: 0x0603C81E RID: 247838 RVA: 0x00E842BC File Offset: 0x00E824BC
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

		// Token: 0x0603C81F RID: 247839 RVA: 0x00E84354 File Offset: 0x00E82554
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

		// Token: 0x0603C820 RID: 247840 RVA: 0x00E843B0 File Offset: 0x00E825B0
		private void OnGuestEffect(bool bShow)
		{
			GuestItem.EChildType name = bShow ? GuestItem.EChildType.BuffInAnim : GuestItem.EChildType.BuffOutAnim;
			TArray<UActorComponent> tarray = base.GetItem((int)name).GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
			for (int i = 0; i < tarray.Num(); i++)
			{
				((ULGUIPlayTweenComponent)tarray.Get(i)).Play();
			}
		}

		// Token: 0x0603C821 RID: 247841 RVA: 0x00E84404 File Offset: 0x00E82604
		protected override UniTask OnBeforeStartAsync()
		{
			GuestItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GuestItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C822 RID: 247842 RVA: 0x00E84447 File Offset: 0x00E82647
		protected override void OnAfterShow()
		{
			if (BattleUiModel.Instance.GuestEffect)
			{
				this.OnGuestEffect(true);
			}
		}

		// Token: 0x0603C823 RID: 247843 RVA: 0x00E8445C File Offset: 0x00E8265C
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

		// Token: 0x0401F866 RID: 129126
		[Nullable(2)]
		private HashSet<int> SpeakerSet;

		// Token: 0x0401F867 RID: 129127
		private bool IsSpeaking;

		// Token: 0x0200BFC9 RID: 49097
		private enum EChildType
		{
			// Token: 0x04039DBA RID: 236986
			HeadIcon,
			// Token: 0x04039DBB RID: 236987
			TalkInAnim,
			// Token: 0x04039DBC RID: 236988
			TalkOutAnim,
			// Token: 0x04039DBD RID: 236989
			BuffInAnim,
			// Token: 0x04039DBE RID: 236990
			BuffOutAnim,
			// Token: 0x04039DBF RID: 236991
			BuffNiagara
		}
	}
}
