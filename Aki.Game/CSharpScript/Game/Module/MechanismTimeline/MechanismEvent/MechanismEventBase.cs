using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.Module.MechanismTimeline.MechanismEvent
{
	// Token: 0x02005481 RID: 21633
	[NullableContext(1)]
	[Nullable(0)]
	public class MechanismEventBase
	{
		// Token: 0x0603731F RID: 226079 RVA: 0x00D167BA File Offset: 0x00D149BA
		public MechanismEventBase(IMechanismEventInfo eventInfo, MechanismEventContext context, SceneItemEventListenerComponent eventListenerComponent, bool isServerAction)
		{
		}

		// Token: 0x17008468 RID: 33896
		// (get) Token: 0x06037320 RID: 226080 RVA: 0x00D167DF File Offset: 0x00D149DF
		public string Type
		{
			get
			{
				return this.EventInfo.Info.Action.Name.ToEnumString();
			}
		}

		// Token: 0x17008469 RID: 33897
		// (get) Token: 0x06037321 RID: 226081 RVA: 0x00D167FB File Offset: 0x00D149FB
		public string SeqGuid
		{
			get
			{
				return this.EventInfo.SeqGuid;
			}
		}

		// Token: 0x1700846A RID: 33898
		// (get) Token: 0x06037322 RID: 226082 RVA: 0x00D16808 File Offset: 0x00D14A08
		public string EventName
		{
			get
			{
				return this.EventInfo.Info.EventName;
			}
		}

		// Token: 0x1700846B RID: 33899
		// (get) Token: 0x06037323 RID: 226083 RVA: 0x00D1681A File Offset: 0x00D14A1A
		public int PlayerId
		{
			get
			{
				return this.EventListenerComponent.GetPlayerId();
			}
		}

		// Token: 0x1700846C RID: 33900
		// (get) Token: 0x06037324 RID: 226084 RVA: 0x00D16827 File Offset: 0x00D14A27
		public long CreatureDataId
		{
			get
			{
				return this.EventListenerComponent.GetCreatureDataId();
			}
		}

		// Token: 0x06037325 RID: 226085 RVA: 0x00D16834 File Offset: 0x00D14A34
		public void Dispose()
		{
			this.OnDispose();
		}

		// Token: 0x06037326 RID: 226086 RVA: 0x00D1683C File Offset: 0x00D14A3C
		public void Trigger()
		{
			this.OnTrigger(this.EventInfo.Info.Action.Params);
			if (this.IsServerAction)
			{
				MechanismTimelineController.Instance.RequestSceneItemSequenceFrameStart(this.PlayerId, this.CreatureDataId, this.SeqGuid, this.EventName);
			}
		}

		// Token: 0x06037327 RID: 226087 RVA: 0x00D16890 File Offset: 0x00D14A90
		public void Start()
		{
			this.OnStart(this.EventInfo.Info.Action.Params);
			if (this.IsServerAction)
			{
				MechanismTimelineController.Instance.RequestSceneItemSequenceFrameStart(this.PlayerId, this.CreatureDataId, this.SeqGuid, this.EventName);
			}
		}

		// Token: 0x06037328 RID: 226088 RVA: 0x00D168E2 File Offset: 0x00D14AE2
		public void Tick()
		{
			this.OnTick();
		}

		// Token: 0x06037329 RID: 226089 RVA: 0x00D168EC File Offset: 0x00D14AEC
		public void End()
		{
			this.OnEnd(this.EventInfo.Info.Action.Params);
			if (this.IsServerAction)
			{
				MechanismTimelineController.Instance.RequestSceneItemSequenceFrameEnd(this.PlayerId, this.CreatureDataId, this.SeqGuid, this.EventName);
			}
		}

		// Token: 0x0603732A RID: 226090 RVA: 0x00D1693E File Offset: 0x00D14B3E
		protected virtual void OnTrigger(ActionParams @params)
		{
		}

		// Token: 0x0603732B RID: 226091 RVA: 0x00D16940 File Offset: 0x00D14B40
		protected virtual void OnStart(ActionParams @params)
		{
		}

		// Token: 0x0603732C RID: 226092 RVA: 0x00D16942 File Offset: 0x00D14B42
		protected virtual void OnTick()
		{
		}

		// Token: 0x0603732D RID: 226093 RVA: 0x00D16944 File Offset: 0x00D14B44
		protected virtual void OnEnd(ActionParams @params)
		{
		}

		// Token: 0x0603732E RID: 226094 RVA: 0x00D16946 File Offset: 0x00D14B46
		protected virtual void OnDispose()
		{
		}

		// Token: 0x0401D1BD RID: 119229
		public readonly IMechanismEventInfo EventInfo = eventInfo;

		// Token: 0x0401D1BE RID: 119230
		public readonly MechanismEventContext Context = context;

		// Token: 0x0401D1BF RID: 119231
		public readonly SceneItemEventListenerComponent EventListenerComponent = eventListenerComponent;

		// Token: 0x0401D1C0 RID: 119232
		public readonly bool IsServerAction = isServerAction;
	}
}
