using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common
{
	// Token: 0x02005B43 RID: 23363
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonFlowTextLogic<T> where T : class
	{
		// Token: 0x0603B26F RID: 242287 RVA: 0x00E1AC18 File Offset: 0x00E18E18
		private void RemoveAnimTimer()
		{
			if (this.AnimTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.AnimTimer);
				this.AnimTimer = null;
			}
		}

		// Token: 0x0603B270 RID: 242288 RVA: 0x00E1AC3A File Offset: 0x00E18E3A
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

		// Token: 0x0603B271 RID: 242289 RVA: 0x00E1AC6C File Offset: 0x00E18E6C
		private void SetFlowText(UUIText text)
		{
			if (PublicUtil.Instance.UseDbConfig())
			{
				LguiUtil.Instance.SetLocalTextNew(text, this.TalkData.TidTalk, Array.Empty<object>());
				return;
			}
			string text2 = PublicUtil.Instance.GetFlowConfigLocalText(this.TalkData.TidTalk);
			if (StringUtils.IsEmpty(text2))
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "字幕为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", this.TalkData.TidTalk);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				text2 = this.TalkData.TidTalk;
			}
			text.SetGameRichText(true);
			text.SetText(text2, true);
		}

		// Token: 0x0603B272 RID: 242290 RVA: 0x00E1AD0C File Offset: 0x00E18F0C
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

		// Token: 0x0603B273 RID: 242291 RVA: 0x00E1AE1F File Offset: 0x00E1901F
		public void InitData(ICommonFlowTextLogicData<T> data)
		{
			this.Data = data;
		}

		// Token: 0x0603B274 RID: 242292 RVA: 0x00E1AE28 File Offset: 0x00E19028
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

		// Token: 0x0603B275 RID: 242293 RVA: 0x00E1AE9C File Offset: 0x00E1909C
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

		// Token: 0x0603B276 RID: 242294 RVA: 0x00E1AEF0 File Offset: 0x00E190F0
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

		// Token: 0x0401ED4E RID: 126286
		private ULGUIPlayTweenComponent TextAnimComp;

		// Token: 0x0401ED4F RID: 126287
		private ITalkItem TalkData;

		// Token: 0x0401ED50 RID: 126288
		[Nullable(2)]
		private T ExtraData;

		// Token: 0x0401ED51 RID: 126289
		private ICommonFlowTextLogicData<T> Data;

		// Token: 0x0401ED52 RID: 126290
		private TimerHandle AnimTimer;
	}
}
