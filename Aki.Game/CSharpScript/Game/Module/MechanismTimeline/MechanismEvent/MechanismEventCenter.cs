using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;

namespace CSharpScript.Game.Module.MechanismTimeline.MechanismEvent
{
	// Token: 0x02005482 RID: 21634
	[NullableContext(1)]
	[Nullable(0)]
	public class MechanismEventCenter : Singleton
	{
		// Token: 0x0603732F RID: 226095 RVA: 0x00D16948 File Offset: 0x00D14B48
		public void RegisterEvents()
		{
			<>f__AnonymousDelegate7<EAction, MechanismEventCenter.EventBaseConstructor, bool> <>f__AnonymousDelegate = new <>f__AnonymousDelegate7<EAction, MechanismEventCenter.EventBaseConstructor, bool>(this.SetupEvent);
			<>f__AnonymousDelegate(EAction.SeqEventAddTagToSelf, (IMechanismEventInfo eventInfo, MechanismEventContext context, SceneItemEventListenerComponent eventListenerComponent, bool isServerAction) => new MechanismEventAddTagToSelf(eventInfo, context, eventListenerComponent, isServerAction), false);
			<>f__AnonymousDelegate(EAction.SeqEventFireBullet, (IMechanismEventInfo eventInfo, MechanismEventContext context, SceneItemEventListenerComponent eventListenerComponent, bool isServerAction) => new MechanismEventFireBullet(eventInfo, context, eventListenerComponent, isServerAction), false);
		}

		// Token: 0x06037330 RID: 226096 RVA: 0x00D169B6 File Offset: 0x00D14BB6
		public void Clear()
		{
			this.EventMap.Clear();
		}

		// Token: 0x06037331 RID: 226097 RVA: 0x00D169C3 File Offset: 0x00D14BC3
		private void SetupEvent(EAction actionName, MechanismEventCenter.EventBaseConstructor actionClass, bool bServerAction = false)
		{
			this.EventMap.TryAdd(actionName, actionClass);
			this.ServerActions[actionName] = bServerAction;
		}

		// Token: 0x06037332 RID: 226098 RVA: 0x00D169E0 File Offset: 0x00D14BE0
		[NullableContext(2)]
		public MechanismEventCenter.EventBaseConstructor GetEventClass(EAction eventType)
		{
			return this.EventMap.GetValueOrDefault(eventType);
		}

		// Token: 0x06037333 RID: 226099 RVA: 0x00D169F0 File Offset: 0x00D14BF0
		public bool GetEventIsServerAction(EAction eventType)
		{
			bool flag;
			return this.ServerActions.TryGetValue(eventType, out flag) && flag;
		}

		// Token: 0x06037334 RID: 226100 RVA: 0x00D16A10 File Offset: 0x00D14C10
		public unsafe bool DeleteEvent(EAction eventType, EMechanismEventExecuteType executeType, UMovieSceneSequencePlayer sequencePlayer, int sectionId)
		{
			if (executeType != EMechanismEventExecuteType.End)
			{
				return false;
			}
			Dictionary<int, MechanismEventBase> dictionary2;
			Dictionary<int, MechanismEventBase> dictionary = this.EventStateMap.TryGetValue(sequencePlayer, out dictionary2) ? dictionary2 : null;
			if (dictionary == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "MechanismEventCenter.DeleteEvent,通过sequencePlayer获取EventStates失败";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("eventType", eventType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("sequence", sequencePlayer.Sequence);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("sectionId", sectionId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return false;
			}
			return dictionary.Remove(sectionId);
		}

		// Token: 0x1700846D RID: 33901
		// (get) Token: 0x06037335 RID: 226101 RVA: 0x00D16AC0 File Offset: 0x00D14CC0
		public static MechanismEventCenter Instance
		{
			get
			{
				if (MechanismEventCenter._instance == null)
				{
					MechanismEventCenter._instance = new MechanismEventCenter();
					MechanismEventCenter._instance.OnInit();
				}
				return MechanismEventCenter._instance;
			}
		}

		// Token: 0x06037336 RID: 226102 RVA: 0x00D16AE3 File Offset: 0x00D14CE3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06037337 RID: 226103 RVA: 0x00D16AE5 File Offset: 0x00D14CE5
		public static void ResetStaticDefaultValue()
		{
			MechanismEventCenter instance = MechanismEventCenter._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			MechanismEventCenter._instance = null;
		}

		// Token: 0x06037338 RID: 226104 RVA: 0x00D16AFE File Offset: 0x00D14CFE
		static MechanismEventCenter()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MechanismEventCenter.CreateStaticDefaultValue), new Action(MechanismEventCenter.ResetStaticDefaultValue));
		}

		// Token: 0x0401D1C1 RID: 119233
		private readonly Dictionary<EAction, MechanismEventCenter.EventBaseConstructor> EventMap = new Dictionary<EAction, MechanismEventCenter.EventBaseConstructor>();

		// Token: 0x0401D1C2 RID: 119234
		private readonly Dictionary<EAction, bool> ServerActions = new Dictionary<EAction, bool>();

		// Token: 0x0401D1C3 RID: 119235
		private readonly ConditionalWeakTable<UMovieSceneSequencePlayer, Dictionary<int, MechanismEventBase>> EventStateMap = new ConditionalWeakTable<UMovieSceneSequencePlayer, Dictionary<int, MechanismEventBase>>();

		// Token: 0x0401D1C4 RID: 119236
		[Nullable(2)]
		private static MechanismEventCenter _instance;

		// Token: 0x0200B6F2 RID: 46834
		// (Invoke) Token: 0x0604F0E3 RID: 323811
		[NullableContext(0)]
		public delegate MechanismEventBase EventBaseConstructor(IMechanismEventInfo eventInfo, MechanismEventContext context, SceneItemEventListenerComponent eventListenerComponent, bool isServerAction);
	}
}
