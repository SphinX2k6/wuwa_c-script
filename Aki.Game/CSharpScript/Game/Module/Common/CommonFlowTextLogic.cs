using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common
{
	// Token: 0x02004B24 RID: 19236
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonFlowTextLogic<T> where T : class
	{
		// Token: 0x060301E1 RID: 197089 RVA: 0x00D6B930 File Offset: 0x00D69B30
		private void RemoveAnimTimer()
		{
			if (this.AnimTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.AnimTimer);
				this.AnimTimer = null;
			}
		}

		// Token: 0x060301E2 RID: 197090 RVA: 0x00D6B952 File Offset: 0x00D69B52
		private void HandleSubtitleAnimFinished(float _)
		{
			this.AnimTimer = null;
			ICommonFlowTextLogicData<T> data = this.Data;
			if (data == null)
			{
				return;
			}
			Action<ITalkItem, T> textAnimFinishDelegate = data.TextAnimFinishDelegate;
			if (textAnimFinishDelegate == null)
			{
				return;
			}
			textAnimFinishDelegate(this.TalkData, this.ExtraData);
		}

		// Token: 0x060301E3 RID: 197091 RVA: 0x00D6B984 File Offset: 0x00D69B84
		private void SetFlowText(UUIText text)
		{
			LguiUtil.Instance.SetLocalTextNew(text, this.TalkData.TidTalk, Array.Empty<object>());
		}

		// Token: 0x060301E4 RID: 197092 RVA: 0x00D6B9AC File Offset: 0x00D69BAC
		private void PlayTextAnim(UUIText text, float? totalTime = null)
		{
			this.RemoveAnimTimer();
			ICommonFlowTextLogicData<T> data = this.Data;
			if (data != null)
			{
				Action<ITalkItem, T> textAnimStartDelegate = data.TextAnimStartDelegate;
				if (textAnimStartDelegate != null)
				{
					textAnimStartDelegate(this.TalkData, this.ExtraData);
				}
			}
			int displayCharLength = text.GetDisplayCharLength();
			float num;
			if (totalTime != null)
			{
				num = totalTime.Value;
			}
			else
			{
				num = (float)displayCharLength / PlotModel.Instance.PlotGlobalConfig.TextAnimSpeedLevelD;
			}
			float interval = Math.Max(num * 1000f, 20f);
			UUIEffectTextAnimation uuieffectTextAnimation = text.GetOwner().GetComponentByClass(UUIEffectTextAnimation.StaticClass()) as UUIEffectTextAnimation;
			if (uuieffectTextAnimation != null)
			{
				uuieffectTextAnimation.SetSelectorOffset(1f);
			}
			this.TextAnimComp = (text.GetOwner().GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent);
			if (this.TextAnimComp != null)
			{
				this.TextAnimComp.GetPlayTween().duration = num;
				this.TextAnimComp.Play();
			}
			this.AnimTimer = TimerSystem.GameplayTimeInstance.Delay(new TTimerAction(this.HandleSubtitleAnimFinished), interval, null, null, true, 1f);
		}

		// Token: 0x060301E5 RID: 197093 RVA: 0x00D6BABF File Offset: 0x00D69CBF
		public void InitData(ICommonFlowTextLogicData<T> data)
		{
			this.Data = data;
		}

		// Token: 0x060301E6 RID: 197094 RVA: 0x00D6BAC8 File Offset: 0x00D69CC8
		public void PlayFlowText(ITalkItem talkData, [Nullable(2)] T param)
		{
			this.TalkData = talkData;
			this.ExtraData = param;
			ICommonFlowTextLogicData<T> data = this.Data;
			UUIText uuitext;
			if (data == null)
			{
				uuitext = null;
			}
			else
			{
				Func<ITalkItem, UUIText> getTextComp = data.GetTextComp;
				uuitext = ((getTextComp != null) ? getTextComp(talkData) : null);
			}
			UUIText uuitext2 = uuitext;
			if (uuitext2 == null)
			{
				return;
			}
			this.PlayAkEvent();
			this.SetFlowText(uuitext2);
			ICaptionParam captionParams = this.TalkData.CaptionParams;
			this.PlayTextAnim(uuitext2, (captionParams != null) ? captionParams.TotalTime : null);
		}

		// Token: 0x060301E7 RID: 197095 RVA: 0x00D6BB3C File Offset: 0x00D69D3C
		public void Clear()
		{
			ULGUIPlayTweenComponent textAnimComp = this.TextAnimComp;
			if (textAnimComp != null)
			{
				textAnimComp.Stop();
			}
			this.RemoveAnimTimer();
			ICommonFlowTextLogicData<T> data = this.Data;
			if (data != null)
			{
				Action clearDelegate = data.ClearDelegate;
				if (clearDelegate != null)
				{
					clearDelegate();
				}
			}
			this.TalkData = null;
			this.ExtraData = default(T);
		}

		// Token: 0x060301E8 RID: 197096 RVA: 0x00D6BB90 File Offset: 0x00D69D90
		private void PlayAkEvent()
		{
			IPostAkEventType talkAkEvent = this.TalkData.TalkAkEvent;
			if (talkAkEvent == null)
			{
				return;
			}
			if (talkAkEvent.Type != EPostAkEvent.Global)
			{
				if (talkAkEvent.Type == EPostAkEvent.Target)
				{
					IPostAkEventTargeted postAkEventTargeted = talkAkEvent as IPostAkEventTargeted;
					string text = AudioSystem.Instance.parseAudioEventPath(postAkEventTargeted.AkEvent);
					if (text == null)
					{
						return;
					}
					int entityId = postAkEventTargeted.EntityId;
					EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(entityId);
					if (entityByPbDataId == null)
					{
						global::Log instance = global::Log.Instance;
						ELogModule module = ELogModule.Event;
						ELogAuthor author = ELogAuthor.FZX;
						string message = "实体不存在";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", entityId);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						return;
					}
					WorldEntity entity = entityByPbDataId.Entity;
					AActor aactor;
					if (entity == null)
					{
						aactor = null;
					}
					else
					{
						BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
						aactor = ((component != null) ? component.Owner : null);
					}
					AActor aactor2 = aactor;
					if (aactor2 == null || !aactor2.IsValid())
					{
						global::Log instance2 = global::Log.Instance;
						ELogModule module2 = ELogModule.Event;
						ELogAuthor author2 = ELogAuthor.FZX;
						string message2 = "未能获取到该实体对应的有效Actor";
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("entityId", entityId);
						instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
						return;
					}
					AudioSystem.Instance.PostEvent(text, aactor2, null);
				}
				return;
			}
			IPostAkEventGlobal postAkEventGlobal = talkAkEvent as IPostAkEventGlobal;
			string text2 = AudioSystem.Instance.parseAudioEventPath(postAkEventGlobal.AkEvent);
			if (text2 == null)
			{
				return;
			}
			AudioSystem.Instance.PostEvent(text2);
		}

		// Token: 0x0401980A RID: 104458
		private ULGUIPlayTweenComponent TextAnimComp;

		// Token: 0x0401980B RID: 104459
		private ITalkItem TalkData;

		// Token: 0x0401980C RID: 104460
		[Nullable(2)]
		private T ExtraData;

		// Token: 0x0401980D RID: 104461
		private ICommonFlowTextLogicData<T> Data;

		// Token: 0x0401980E RID: 104462
		private TimerHandle AnimTimer;
	}
}
