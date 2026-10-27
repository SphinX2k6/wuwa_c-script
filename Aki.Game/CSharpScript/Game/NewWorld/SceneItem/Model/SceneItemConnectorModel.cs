using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.Model
{
	// Token: 0x020071D9 RID: 29145
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class SceneItemConnectorModel : ModelBase
	{
		// Token: 0x0604754D RID: 292173 RVA: 0x012236D8 File Offset: 0x012218D8
		public void AddConnectedRelation(int scrId, int[] targetId)
		{
			HashSet<int> hashSet;
			if (!this.ConnectedRelationCache.TryGetValue(scrId, out hashSet))
			{
				hashSet = new HashSet<int>();
				this.ConnectedRelationCache[scrId] = hashSet;
			}
			foreach (int item in targetId)
			{
				hashSet.Add(item);
			}
		}

		// Token: 0x0604754E RID: 292174 RVA: 0x01223724 File Offset: 0x01221924
		public void RemoveConnectRelation(int scrId, int targetId)
		{
			HashSet<int> hashSet;
			if (this.ConnectedRelationCache.TryGetValue(scrId, out hashSet))
			{
				hashSet.Remove(targetId);
			}
		}

		// Token: 0x0604754F RID: 292175 RVA: 0x01223749 File Offset: 0x01221949
		[NullableContext(2)]
		public HashSet<int> GetRelationByEntityId(int scrId)
		{
			return this.ConnectedRelationCache.GetValueOrDefault(scrId);
		}

		// Token: 0x17009DF3 RID: 40435
		// (get) Token: 0x06047550 RID: 292176 RVA: 0x01223757 File Offset: 0x01221957
		public static SceneItemConnectorModel Instance
		{
			get
			{
				return SceneItemConnectorModel._Instance;
			}
		}

		// Token: 0x06047551 RID: 292177 RVA: 0x0122375E File Offset: 0x0122195E
		public static SceneItemConnectorModel GetOrCreateInstance()
		{
			if (SceneItemConnectorModel._Instance == null)
			{
				SceneItemConnectorModel.CreateInstance();
			}
			return SceneItemConnectorModel._Instance;
		}

		// Token: 0x06047552 RID: 292178 RVA: 0x01223772 File Offset: 0x01221972
		public static bool CreateInstance()
		{
			if (SceneItemConnectorModel._Instance != null)
			{
				return true;
			}
			SceneItemConnectorModel._Instance = new SceneItemConnectorModel();
			return true;
		}

		// Token: 0x06047553 RID: 292179 RVA: 0x01223788 File Offset: 0x01221988
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06047554 RID: 292180 RVA: 0x0122378A File Offset: 0x0122198A
		public static void ResetStaticDefaultValue()
		{
			SceneItemConnectorModel._Instance = null;
		}

		// Token: 0x06047555 RID: 292181 RVA: 0x01223792 File Offset: 0x01221992
		static SceneItemConnectorModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneItemConnectorModel.CreateStaticDefaultValue), new Action(SceneItemConnectorModel.ResetStaticDefaultValue));
		}

		// Token: 0x04025812 RID: 153618
		private readonly Dictionary<int, HashSet<int>> ConnectedRelationCache = new Dictionary<int, HashSet<int>>();

		// Token: 0x04025813 RID: 153619
		[Nullable(2)]
		private static SceneItemConnectorModel _Instance;
	}
}
