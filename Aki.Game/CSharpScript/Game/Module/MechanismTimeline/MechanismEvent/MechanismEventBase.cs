using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.Module.MechanismTimeline.MechanismEvent
{
	// Token: 0x02004464 RID: 17508
	[NullableContext(1)]
	[Nullable(0)]
	public class MechanismEventBase
	{
		// Token: 0x0602C268 RID: 180840 RVA: 0x00C65C12 File Offset: 0x00C63E12
		public MechanismEventBase(IMechanismEventInfo eventInfo, MechanismEventContext context, SceneItemEventListenerComponent eventListenerComponent, bool isServerAction)
		{
		}

		// Token: 0x17005834 RID: 22580
		// (get) Token: 0x0602C269 RID: 180841 RVA: 0x00C65C37 File Offset: 0x00C63E37
		public string Type
		{
			get
			{
				return this.EventInfo.Info.Action.Name.ToEnumString();
			}
		}

		// Token: 0x17005835 RID: 22581
		// (get) Token: 0x0602C26A RID: 180842 RVA: 0x00C65C53 File Offset: 0x00C63E53
		public string SeqGuid
		{
			get
			{
				return this.EventInfo.SeqGuid;
			}
		}

		// Token: 0x17005836 RID: 22582
		// (get) Token: 0x0602C26B RID: 180843 RVA: 0x00C65C60 File Offset: 0x00C63E60
		public string EventName
		{
			get
			{
				return this.EventInfo.Info.EventName;
			}
		}

		// Token: 0x17005837 RID: 22583
		// (get) Token: 0x0602C26C RID: 180844 RVA: 0x00C65C72 File Offset: 0x00C63E72
		public int PlayerId
		{
			get
			{
				return this.EventListenerComponent.GetPlayerId();
			}
		}

		// Token: 0x17005838 RID: 22584
		// (get) Token: 0x0602C26D RID: 180845 RVA: 0x00C65C7F File Offset: 0x00C63E7F
		public long CreatureDataId
		{
			get
			{
				return this.EventListenerComponent.GetCreatureDataId();
			}
		}

		// Token: 0x0602C26E RID: 180846 RVA: 0x00C65C8C File Offset: 0x00C63E8C
		public void Dispose()
		{
			this.OnDispose();
		}

		// Token: 0x0602C26F RID: 180847 RVA: 0x00C65C94 File Offset: 0x00C63E94
		public void Trigger()
		{
			this.OnTrigger(this.EventInfo.Info.Action.Params);
			if (this.IsServerAction)
			{
				MechanismTimelineController.Instance.RequestSceneItemSequenceFrameStart(this.PlayerId, this.CreatureDataId, this.SeqGuid, this.EventName);
			}
		}

		// Token: 0x0602C270 RID: 180848 RVA: 0x00C65CE8 File Offset: 0x00C63EE8
		public void Start()
		{
			this.OnStart(this.EventInfo.Info.Action.Params);
			if (this.IsServerAction)
			{
				MechanismTimelineController.Instance.RequestSceneItemSequenceFrameStart(this.PlayerId, this.CreatureDataId, this.SeqGuid, this.EventName);
			}
		}

		// Token: 0x0602C271 RID: 180849 RVA: 0x00C65D3A File Offset: 0x00C63F3A
		public void Tick()
		{
			this.OnTick();
		}

		// Token: 0x0602C272 RID: 180850 RVA: 0x00C65D44 File Offset: 0x00C63F44
		public void End()
		{
			this.OnEnd(this.EventInfo.Info.Action.Params);
			if (this.IsServerAction)
			{
				MechanismTimelineController.Instance.RequestSceneItemSequenceFrameEnd(this.PlayerId, this.CreatureDataId, this.SeqGuid, this.EventName);
			}
		}

		// Token: 0x0602C273 RID: 180851 RVA: 0x00C65D96 File Offset: 0x00C63F96
		protected virtual void OnTrigger(ActionParams @params)
		{
		}

		// Token: 0x0602C274 RID: 180852 RVA: 0x00C65D98 File Offset: 0x00C63F98
		protected virtual void OnStart(ActionParams @params)
		{
		}

		// Token: 0x0602C275 RID: 180853 RVA: 0x00C65D9A File Offset: 0x00C63F9A
		protected virtual void OnTick()
		{
		}

		// Token: 0x0602C276 RID: 180854 RVA: 0x00C65D9C File Offset: 0x00C63F9C
		protected virtual void OnEnd(ActionParams @params)
		{
		}

		// Token: 0x0602C277 RID: 180855 RVA: 0x00C65D9E File Offset: 0x00C63F9E
		protected virtual void OnDispose()
		{
		}

		// Token: 0x04017C56 RID: 97366
		public readonly IMechanismEventInfo EventInfo = eventInfo;

		// Token: 0x04017C57 RID: 97367
		public readonly MechanismEventContext Context = context;

		// Token: 0x04017C58 RID: 97368
		public readonly SceneItemEventListenerComponent EventListenerComponent = eventListenerComponent;

		// Token: 0x04017C59 RID: 97369
		public readonly bool IsServerAction = isServerAction;
	}
}
