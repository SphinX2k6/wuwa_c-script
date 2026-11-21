using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ActorFxEmote
{
	// Token: 0x02004ED5 RID: 20181
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ActorFxEmoteModel : ModelBase
	{
		// Token: 0x06032BA6 RID: 207782 RVA: 0x00E3F4C3 File Offset: 0x00E3D6C3
		protected override bool OnClear()
		{
			this.EntityDataMap.Clear();
			return true;
		}

		// Token: 0x06032BA7 RID: 207783 RVA: 0x00E3F4D1 File Offset: 0x00E3D6D1
		[NullableContext(2)]
		public ActorFxEmoteData GetEntityData(int entityId)
		{
			return this.EntityDataMap.GetValueOrDefault(entityId);
		}

		// Token: 0x06032BA8 RID: 207784 RVA: 0x00E3F4E0 File Offset: 0x00E3D6E0
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

		// Token: 0x06032BA9 RID: 207785 RVA: 0x00E3F511 File Offset: 0x00E3D711
		public void RemoveEntityData(int entityId)
		{
			this.EntityDataMap.Remove(entityId);
		}

		// Token: 0x06032BAA RID: 207786 RVA: 0x00E3F520 File Offset: 0x00E3D720
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

		// Token: 0x170062BB RID: 25275
		// (get) Token: 0x06032BAB RID: 207787 RVA: 0x00E3F588 File Offset: 0x00E3D788
		public static ActorFxEmoteModel Instance
		{
			get
			{
				return ActorFxEmoteModel._Instance;
			}
		}

		// Token: 0x06032BAC RID: 207788 RVA: 0x00E3F58F File Offset: 0x00E3D78F
		public static ActorFxEmoteModel GetOrCreateInstance()
		{
			if (ActorFxEmoteModel._Instance == null)
			{
				ActorFxEmoteModel.CreateInstance();
			}
			return ActorFxEmoteModel._Instance;
		}

		// Token: 0x06032BAD RID: 207789 RVA: 0x00E3F5A3 File Offset: 0x00E3D7A3
		public static bool CreateInstance()
		{
			if (ActorFxEmoteModel._Instance != null)
			{
				return true;
			}
			ActorFxEmoteModel._Instance = new ActorFxEmoteModel();
			return true;
		}

		// Token: 0x06032BAE RID: 207790 RVA: 0x00E3F5B9 File Offset: 0x00E3D7B9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06032BAF RID: 207791 RVA: 0x00E3F5BB File Offset: 0x00E3D7BB
		public static void ResetStaticDefaultValue()
		{
			ActorFxEmoteModel._Instance = null;
		}

		// Token: 0x06032BB0 RID: 207792 RVA: 0x00E3F5C3 File Offset: 0x00E3D7C3
		static ActorFxEmoteModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActorFxEmoteModel.CreateStaticDefaultValue), new Action(ActorFxEmoteModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401AF24 RID: 110372
		public const string DEFAULT_SOCKET_KEY = "__default";

		// Token: 0x0401AF25 RID: 110373
		private Dictionary<int, ActorFxEmoteData> EntityDataMap = new Dictionary<int, ActorFxEmoteData>();

		// Token: 0x0401AF26 RID: 110374
		[Nullable(2)]
		private static ActorFxEmoteModel _Instance;
	}
}
