using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.Module.MechanismTimeline.MechanismEvent
{
	// Token: 0x02004463 RID: 17507
	[NullableContext(1)]
	[Nullable(0)]
	public class MechanismEventAddTagToSelf : MechanismEventBase
	{
		// Token: 0x0602C264 RID: 180836 RVA: 0x00C65AF2 File Offset: 0x00C63CF2
		public MechanismEventAddTagToSelf(IMechanismEventInfo eventInfo, MechanismEventContext context, SceneItemEventListenerComponent eventListenerComponent, bool isServerAction) : base(eventInfo, context, eventListenerComponent, isServerAction)
		{
		}

		// Token: 0x0602C265 RID: 180837 RVA: 0x00C65AFF File Offset: 0x00C63CFF
		protected override void OnTrigger(ActionParams @params)
		{
		}

		// Token: 0x0602C266 RID: 180838 RVA: 0x00C65B04 File Offset: 0x00C63D04
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

		// Token: 0x0602C267 RID: 180839 RVA: 0x00C65B8C File Offset: 0x00C63D8C
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
