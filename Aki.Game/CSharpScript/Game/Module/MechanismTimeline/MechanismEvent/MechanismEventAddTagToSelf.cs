using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.Module.MechanismTimeline.MechanismEvent
{
	// Token: 0x02005480 RID: 21632
	[NullableContext(1)]
	[Nullable(0)]
	public class MechanismEventAddTagToSelf : MechanismEventBase
	{
		// Token: 0x0603731B RID: 226075 RVA: 0x00D1669A File Offset: 0x00D1489A
		public MechanismEventAddTagToSelf(IMechanismEventInfo eventInfo, MechanismEventContext context, SceneItemEventListenerComponent eventListenerComponent, bool isServerAction) : base(eventInfo, context, eventListenerComponent, isServerAction)
		{
		}

		// Token: 0x0603731C RID: 226076 RVA: 0x00D166A7 File Offset: 0x00D148A7
		protected override void OnTrigger(ActionParams @params)
		{
		}

		// Token: 0x0603731D RID: 226077 RVA: 0x00D166AC File Offset: 0x00D148AC
		protected unsafe override void OnStart(ActionParams @params)
		{
			SeqEventAddTagToSelf seqEventAddTagToSelf = @params as SeqEventAddTagToSelf;
			if (seqEventAddTagToSelf == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "MechanismEventAddTagToSelf.参数类型错误";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("context", this.Context);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("eventName", base.EventName);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.EventListenerComponent.AddTags(seqEventAddTagToSelf.Tags);
		}

		// Token: 0x0603731E RID: 226078 RVA: 0x00D16734 File Offset: 0x00D14934
		protected unsafe override void OnEnd(ActionParams @params)
		{
			SeqEventAddTagToSelf seqEventAddTagToSelf = @params as SeqEventAddTagToSelf;
			if (seqEventAddTagToSelf == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "MechanismEventAddTagToSelf.参数类型错误";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("context", this.Context);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("eventName", base.EventName);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.EventListenerComponent.RemoveTags(seqEventAddTagToSelf.Tags);
		}
	}
}
