using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;

namespace CSharpScript.Game.Module.MechanismTimeline.MechanismEvent
{
	// Token: 0x02004465 RID: 17509
	[NullableContext(1)]
	[Nullable(0)]
	public class MechanismEventCenter : Singleton
	{
		// Token: 0x0602C278 RID: 180856 RVA: 0x00C65DA0 File Offset: 0x00C63FA0
		public void RegisterEvents()
		{
			<>f__AnonymousDelegate7<EAction, MechanismEventCenter.EventBaseConstructor, bool> <>f__AnonymousDelegate = new <>f__AnonymousDelegate7<EAction, MechanismEventCenter.EventBaseConstructor, bool>(this.SetupEvent);
			<>f__AnonymousDelegate(EAction.SeqEventAddTagToSelf, (IMechanismEventInfo eventInfo, MechanismEventContext context, SceneItemEventListenerComponent eventListenerComponent, bool isServerAction) => new MechanismEventAddTagToSelf(eventInfo, context, eventListenerComponent, isServerAction), false);
			<>f__AnonymousDelegate(EAction.SeqEventFireBullet, (IMechanismEventInfo eventInfo, MechanismEventContext context, SceneItemEventListenerComponent eventListenerComponent, bool isServerAction) => new MechanismEventFireBullet(eventInfo, context, eventListenerComponent, isServerAction), false);
		}

		// Token: 0x0602C279 RID: 180857 RVA: 0x00C65E0E File Offset: 0x00C6400E
		public void Clear()
		{
			this.EventMap.Clear();
		}

		// Token: 0x0602C27A RID: 180858 RVA: 0x00C65E1B File Offset: 0x00C6401B
		private void SetupEvent(EAction actionName, MechanismEventCenter.EventBaseConstructor actionClass, bool bServerAction = false)
		{
			this.EventMap.TryAdd(actionName, actionClass);
			this.ServerActions[actionName] = bServerAction;
		}

		// Token: 0x0602C27B RID: 180859 RVA: 0x00C65E38 File Offset: 0x00C64038
		[NullableContext(2)]
		public MechanismEventCenter.EventBaseConstructor GetEventClass(EAction eventType)
		{
			return this.EventMap.GetValueOrDefault(eventType);
		}

		// Token: 0x0602C27C RID: 180860 RVA: 0x00C65E48 File Offset: 0x00C64048
		public bool GetEventIsServerAction(EAction eventType)
		{
			bool flag;
			return this.ServerActions.TryGetValue(eventType, out flag) && flag;
		}

		// Token: 0x0602C27D RID: 180861 RVA: 0x00C65E68 File Offset: 0x00C64068
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

		// Token: 0x17005839 RID: 22585
		// (get) Token: 0x0602C27E RID: 180862 RVA: 0x00C65F18 File Offset: 0x00C64118
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

		// Token: 0x0602C27F RID: 180863 RVA: 0x00C65F3B File Offset: 0x00C6413B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602C280 RID: 180864 RVA: 0x00C65F3D File Offset: 0x00C6413D
		public static void ResetStaticDefaultValue()
		{
			MechanismEventCenter instance = MechanismEventCenter._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			MechanismEventCenter._instance = null;
		}

		// Token: 0x0602C281 RID: 180865 RVA: 0x00C65F56 File Offset: 0x00C64156
		static MechanismEventCenter()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MechanismEventCenter.CreateStaticDefaultValue), new Action(MechanismEventCenter.ResetStaticDefaultValue));
		}

		// Token: 0x04017C5A RID: 97370
		private readonly Dictionary<EAction, MechanismEventCenter.EventBaseConstructor> EventMap = new Dictionary<EAction, MechanismEventCenter.EventBaseConstructor>();

		// Token: 0x04017C5B RID: 97371
		private readonly Dictionary<EAction, bool> ServerActions = new Dictionary<EAction, bool>();

		// Token: 0x04017C5C RID: 97372
		private readonly ConditionalWeakTable<UMovieSceneSequencePlayer, Dictionary<int, MechanismEventBase>> EventStateMap = new ConditionalWeakTable<UMovieSceneSequencePlayer, Dictionary<int, MechanismEventBase>>();

		// Token: 0x04017C5D RID: 97373
		[Nullable(2)]
		private static MechanismEventCenter _instance;

		// Token: 0x0200A12A RID: 41258
		// (Invoke) Token: 0x060456E0 RID: 284384
		[NullableContext(0)]
		public delegate MechanismEventBase EventBaseConstructor(IMechanismEventInfo eventInfo, MechanismEventContext context, SceneItemEventListenerComponent eventListenerComponent, bool isServerAction);
	}
}
