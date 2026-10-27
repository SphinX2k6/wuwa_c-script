using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x020069AD RID: 27053
	[NullableContext(1)]
	[Nullable(0)]
	public class EventTempData : IStaticVariableResetter
	{
		// Token: 0x0604349B RID: 275611 RVA: 0x01068070 File Offset: 0x01066270
		static EventTempData()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(EventTempData.CreateStaticDefaultValue), new Action(EventTempData.ResetStaticDefaultValue));
		}

		// Token: 0x0604349C RID: 275612 RVA: 0x01068090 File Offset: 0x01066290
		public void Reset()
		{
			this.EventType = "";
			this.EventParams = null;
			this.EventParamsNew = null;
			this.EventType = "";
			this.Context = null;
			this.PlayerId = -1;
			this.SessionId = -1;
			this.ActionIndex = -1;
			this.ActionId = 0;
			this.EventEntityId = 0;
			this.EventTrigger = null;
			this.IsAsync = false;
		}

		// Token: 0x0604349D RID: 275613 RVA: 0x010680FC File Offset: 0x010662FC
		public static EventTempData Create()
		{
			if (EventTempData.Pool.Count > 0)
			{
				EventTempData result = EventTempData.Pool[EventTempData.Pool.Count - 1];
				EventTempData.Pool.RemoveAt(EventTempData.Pool.Count - 1);
				return result;
			}
			return new EventTempData();
		}

		// Token: 0x0604349E RID: 275614 RVA: 0x01068148 File Offset: 0x01066348
		public static void Release(EventTempData data)
		{
			data.Reset();
			EventTempData.Pool.Add(data);
		}

		// Token: 0x0604349F RID: 275615 RVA: 0x0106815B File Offset: 0x0106635B
		public static void CreateStaticDefaultValue()
		{
			EventTempData.Pool = new List<EventTempData>();
		}

		// Token: 0x060434A0 RID: 275616 RVA: 0x01068167 File Offset: 0x01066367
		public static void ResetStaticDefaultValue()
		{
			EventTempData.Pool = null;
		}

		// Token: 0x040230CC RID: 143564
		public string EventType = "";

		// Token: 0x040230CD RID: 143565
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, string> EventParams;

		// Token: 0x040230CE RID: 143566
		[Nullable(2)]
		public ActionParams EventParamsNew;

		// Token: 0x040230CF RID: 143567
		public int EventEntityId;

		// Token: 0x040230D0 RID: 143568
		[Nullable(2)]
		public GeneralContext Context;

		// Token: 0x040230D1 RID: 143569
		public int PlayerId = -1;

		// Token: 0x040230D2 RID: 143570
		public int SessionId = -1;

		// Token: 0x040230D3 RID: 143571
		public int ActionIndex = -1;

		// Token: 0x040230D4 RID: 143572
		public int ActionId;

		// Token: 0x040230D5 RID: 143573
		public string ActionGuid = "";

		// Token: 0x040230D6 RID: 143574
		public bool IsAsync;

		// Token: 0x040230D7 RID: 143575
		[Nullable(2)]
		public AActor EventTrigger;

		// Token: 0x040230D8 RID: 143576
		private static List<EventTempData> Pool;
	}
}
