using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.Model
{
	// Token: 0x0200628E RID: 25230
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class SceneItemConnectorModel : ModelBase
	{
		// Token: 0x0603CE4F RID: 249423 RVA: 0x0117D50C File Offset: 0x0117B70C
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

		// Token: 0x0603CE50 RID: 249424 RVA: 0x0117D558 File Offset: 0x0117B758
		public void RemoveConnectRelation(int scrId, int targetId)
		{
			HashSet<int> hashSet;
			if (this.ConnectedRelationCache.TryGetValue(scrId, out hashSet))
			{
				hashSet.Remove(targetId);
			}
		}

		// Token: 0x0603CE51 RID: 249425 RVA: 0x0117D57D File Offset: 0x0117B77D
		[NullableContext(2)]
		public HashSet<int> GetRelationByEntityId(int scrId)
		{
			return this.ConnectedRelationCache.GetValueOrDefault(scrId);
		}

		// Token: 0x1700734A RID: 29514
		// (get) Token: 0x0603CE52 RID: 249426 RVA: 0x0117D58B File Offset: 0x0117B78B
		public static SceneItemConnectorModel Instance
		{
			get
			{
				return SceneItemConnectorModel._Instance;
			}
		}

		// Token: 0x0603CE53 RID: 249427 RVA: 0x0117D592 File Offset: 0x0117B792
		public static SceneItemConnectorModel GetOrCreateInstance()
		{
			if (SceneItemConnectorModel._Instance == null)
			{
				SceneItemConnectorModel.CreateInstance();
			}
			return SceneItemConnectorModel._Instance;
		}

		// Token: 0x0603CE54 RID: 249428 RVA: 0x0117D5A6 File Offset: 0x0117B7A6
		public static bool CreateInstance()
		{
			if (SceneItemConnectorModel._Instance != null)
			{
				return true;
			}
			SceneItemConnectorModel._Instance = new SceneItemConnectorModel();
			return true;
		}

		// Token: 0x0603CE55 RID: 249429 RVA: 0x0117D5BC File Offset: 0x0117B7BC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603CE56 RID: 249430 RVA: 0x0117D5BE File Offset: 0x0117B7BE
		public static void ResetStaticDefaultValue()
		{
			SceneItemConnectorModel._Instance = null;
		}

		// Token: 0x0603CE57 RID: 249431 RVA: 0x0117D5C6 File Offset: 0x0117B7C6
		static SceneItemConnectorModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneItemConnectorModel.CreateStaticDefaultValue), new Action(SceneItemConnectorModel.ResetStaticDefaultValue));
		}

		// Token: 0x04020481 RID: 132225
		private readonly Dictionary<int, HashSet<int>> ConnectedRelationCache = new Dictionary<int, HashSet<int>>();

		// Token: 0x04020482 RID: 132226
		[Nullable(2)]
		private static SceneItemConnectorModel _Instance;
	}
}
