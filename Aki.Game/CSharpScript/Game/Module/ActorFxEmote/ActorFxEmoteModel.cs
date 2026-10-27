using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ActorFxEmote
{
	// Token: 0x02005EEE RID: 24302
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ActorFxEmoteModel : ModelBase
	{
		// Token: 0x0603DC0B RID: 252939 RVA: 0x00EED7FF File Offset: 0x00EEB9FF
		protected override bool OnClear()
		{
			this.EntityDataMap.Clear();
			return true;
		}

		// Token: 0x0603DC0C RID: 252940 RVA: 0x00EED80D File Offset: 0x00EEBA0D
		[NullableContext(2)]
		public ActorFxEmoteData GetEntityData(int entityId)
		{
			return this.EntityDataMap.GetValueOrDefault(entityId);
		}

		// Token: 0x0603DC0D RID: 252941 RVA: 0x00EED81C File Offset: 0x00EEBA1C
		public ActorFxEmoteData GetOrCreateEntityData(int entityId)
		{
			ActorFxEmoteData actorFxEmoteData;
			if (!this.EntityDataMap.TryGetValue(entityId, out actorFxEmoteData))
			{
				actorFxEmoteData = new ActorFxEmoteData();
				this.EntityDataMap[entityId] = actorFxEmoteData;
			}
			return actorFxEmoteData;
		}

		// Token: 0x0603DC0E RID: 252942 RVA: 0x00EED84D File Offset: 0x00EEBA4D
		public void RemoveEntityData(int entityId)
		{
			this.EntityDataMap.Remove(entityId);
		}

		// Token: 0x0603DC0F RID: 252943 RVA: 0x00EED85C File Offset: 0x00EEBA5C
		public void ForEachEntityData(Action<int, ActorFxEmoteData> callback)
		{
			foreach (KeyValuePair<int, ActorFxEmoteData> keyValuePair in this.EntityDataMap)
			{
				int num;
				ActorFxEmoteData actorFxEmoteData;
				keyValuePair.Deconstruct(out num, out actorFxEmoteData);
				int arg = num;
				ActorFxEmoteData arg2 = actorFxEmoteData;
				callback(arg, arg2);
			}
		}

		// Token: 0x17008EE9 RID: 36585
		// (get) Token: 0x0603DC10 RID: 252944 RVA: 0x00EED8C4 File Offset: 0x00EEBAC4
		public static ActorFxEmoteModel Instance
		{
			get
			{
				return ActorFxEmoteModel._Instance;
			}
		}

		// Token: 0x0603DC11 RID: 252945 RVA: 0x00EED8CB File Offset: 0x00EEBACB
		public static ActorFxEmoteModel GetOrCreateInstance()
		{
			if (ActorFxEmoteModel._Instance == null)
			{
				ActorFxEmoteModel.CreateInstance();
			}
			return ActorFxEmoteModel._Instance;
		}

		// Token: 0x0603DC12 RID: 252946 RVA: 0x00EED8DF File Offset: 0x00EEBADF
		public static bool CreateInstance()
		{
			if (ActorFxEmoteModel._Instance != null)
			{
				return true;
			}
			ActorFxEmoteModel._Instance = new ActorFxEmoteModel();
			return true;
		}

		// Token: 0x0603DC13 RID: 252947 RVA: 0x00EED8F5 File Offset: 0x00EEBAF5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603DC14 RID: 252948 RVA: 0x00EED8F7 File Offset: 0x00EEBAF7
		public static void ResetStaticDefaultValue()
		{
			ActorFxEmoteModel._Instance = null;
		}

		// Token: 0x0603DC15 RID: 252949 RVA: 0x00EED8FF File Offset: 0x00EEBAFF
		static ActorFxEmoteModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActorFxEmoteModel.CreateStaticDefaultValue), new Action(ActorFxEmoteModel.ResetStaticDefaultValue));
		}

		// Token: 0x04020452 RID: 132178
		public const string DEFAULT_SOCKET_KEY = "__default";

		// Token: 0x04020453 RID: 132179
		private Dictionary<int, ActorFxEmoteData> EntityDataMap = new Dictionary<int, ActorFxEmoteData>();

		// Token: 0x04020454 RID: 132180
		[Nullable(2)]
		private static ActorFxEmoteModel _Instance;
	}
}
