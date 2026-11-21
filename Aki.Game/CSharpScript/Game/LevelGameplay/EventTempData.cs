using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005B09 RID: 23305
	[NullableContext(1)]
	[Nullable(0)]
	public class EventTempData : IStaticVariableResetter
	{
		// Token: 0x060394D3 RID: 234707 RVA: 0x0100C268 File Offset: 0x0100A468
		static EventTempData()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(EventTempData.CreateStaticDefaultValue), new Action(EventTempData.ResetStaticDefaultValue));
		}

		// Token: 0x060394D4 RID: 234708 RVA: 0x0100C288 File Offset: 0x0100A488
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

		// Token: 0x060394D5 RID: 234709 RVA: 0x0100C2F4 File Offset: 0x0100A4F4
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

		// Token: 0x060394D6 RID: 234710 RVA: 0x0100C340 File Offset: 0x0100A540
		public static void Release(EventTempData data)
		{
			data.Reset();
			EventTempData.Pool.Add(data);
		}

		// Token: 0x060394D7 RID: 234711 RVA: 0x0100C353 File Offset: 0x0100A553
		public static void CreateStaticDefaultValue()
		{
			EventTempData.Pool = new List<EventTempData>();
		}

		// Token: 0x060394D8 RID: 234712 RVA: 0x0100C35F File Offset: 0x0100A55F
		public static void ResetStaticDefaultValue()
		{
			EventTempData.Pool = null;
		}

		// Token: 0x0401E2B4 RID: 123572
		public string EventType = "";

		// Token: 0x0401E2B5 RID: 123573
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, string> EventParams;

		// Token: 0x0401E2B6 RID: 123574
		[Nullable(2)]
		public ActionParams EventParamsNew;

		// Token: 0x0401E2B7 RID: 123575
		public int EventEntityId;

		// Token: 0x0401E2B8 RID: 123576
		[Nullable(2)]
		public GeneralContext Context;

		// Token: 0x0401E2B9 RID: 123577
		public int PlayerId = -1;

		// Token: 0x0401E2BA RID: 123578
		public int SessionId = -1;

		// Token: 0x0401E2BB RID: 123579
		public int ActionIndex = -1;

		// Token: 0x0401E2BC RID: 123580
		public int ActionId;

		// Token: 0x0401E2BD RID: 123581
		public string ActionGuid = "";

		// Token: 0x0401E2BE RID: 123582
		public bool IsAsync;

		// Token: 0x0401E2BF RID: 123583
		[Nullable(2)]
		public AActor EventTrigger;

		// Token: 0x0401E2C0 RID: 123584
		private static List<EventTempData> Pool;
	}
}
