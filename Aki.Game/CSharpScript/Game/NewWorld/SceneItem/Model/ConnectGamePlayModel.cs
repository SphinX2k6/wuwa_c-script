using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Common.Component;

namespace CSharpScript.Game.NewWorld.SceneItem.Model
{
	// Token: 0x02006289 RID: 25225
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ConnectGamePlayModel : ModelBase
	{
		// Token: 0x0603CE10 RID: 249360 RVA: 0x0117CD5C File Offset: 0x0117AF5C
		public void AddConnectedRelation(int scrId, List<int> targetId)
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

		// Token: 0x0603CE11 RID: 249361 RVA: 0x0117CDD0 File Offset: 0x0117AFD0
		public void SetRelationPortalParam(int scrId, PassThroughPortalParam portalParam)
		{
			this.ConnectedRelationPortalParam[scrId] = portalParam;
		}

		// Token: 0x0603CE12 RID: 249362 RVA: 0x0117CDE0 File Offset: 0x0117AFE0
		public void RemoveConnectRelation(int scrId, int targetId)
		{
			HashSet<int> hashSet;
			if (this.ConnectedRelationCache.TryGetValue(scrId, out hashSet))
			{
				hashSet.Remove(targetId);
			}
		}

		// Token: 0x0603CE13 RID: 249363 RVA: 0x0117CE05 File Offset: 0x0117B005
		public void RemoveRelationPortalType(int scrId)
		{
			this.ConnectedRelationPortalParam.Remove(scrId);
		}

		// Token: 0x0603CE14 RID: 249364 RVA: 0x0117CE14 File Offset: 0x0117B014
		[NullableContext(2)]
		public HashSet<int> GetRelationByEntityId(int scrId)
		{
			return this.ConnectedRelationCache.GetValueOrDefault(scrId);
		}

		// Token: 0x0603CE15 RID: 249365 RVA: 0x0117CE22 File Offset: 0x0117B022
		[NullableContext(2)]
		public PassThroughPortalParam GetRelationPassThroughParam(int scrId)
		{
			return this.ConnectedRelationPortalParam.GetValueOrDefault(scrId);
		}

		// Token: 0x17007345 RID: 29509
		// (get) Token: 0x0603CE16 RID: 249366 RVA: 0x0117CE30 File Offset: 0x0117B030
		public static ConnectGamePlayModel Instance
		{
			get
			{
				return ConnectGamePlayModel._Instance;
			}
		}

		// Token: 0x0603CE17 RID: 249367 RVA: 0x0117CE37 File Offset: 0x0117B037
		public static ConnectGamePlayModel GetOrCreateInstance()
		{
			if (ConnectGamePlayModel._Instance == null)
			{
				ConnectGamePlayModel.CreateInstance();
			}
			return ConnectGamePlayModel._Instance;
		}

		// Token: 0x0603CE18 RID: 249368 RVA: 0x0117CE4B File Offset: 0x0117B04B
		public static bool CreateInstance()
		{
			if (ConnectGamePlayModel._Instance != null)
			{
				return true;
			}
			ConnectGamePlayModel._Instance = new ConnectGamePlayModel();
			return true;
		}

		// Token: 0x0603CE19 RID: 249369 RVA: 0x0117CE61 File Offset: 0x0117B061
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603CE1A RID: 249370 RVA: 0x0117CE63 File Offset: 0x0117B063
		public static void ResetStaticDefaultValue()
		{
			ConnectGamePlayModel._Instance = null;
		}

		// Token: 0x0603CE1B RID: 249371 RVA: 0x0117CE6B File Offset: 0x0117B06B
		static ConnectGamePlayModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ConnectGamePlayModel.CreateStaticDefaultValue), new Action(ConnectGamePlayModel.ResetStaticDefaultValue));
		}

		// Token: 0x04020473 RID: 132211
		public readonly int TryConnectInterval = 500;

		// Token: 0x04020474 RID: 132212
		private readonly Dictionary<int, HashSet<int>> ConnectedRelationCache = new Dictionary<int, HashSet<int>>();

		// Token: 0x04020475 RID: 132213
		private readonly Dictionary<int, PassThroughPortalParam> ConnectedRelationPortalParam = new Dictionary<int, PassThroughPortalParam>();

		// Token: 0x04020476 RID: 132214
		[Nullable(2)]
		private static ConnectGamePlayModel _Instance;
	}
}
