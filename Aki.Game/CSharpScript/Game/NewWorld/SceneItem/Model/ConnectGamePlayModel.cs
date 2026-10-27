using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Common.Component;

namespace CSharpScript.Game.NewWorld.SceneItem.Model
{
	// Token: 0x020071D4 RID: 29140
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ConnectGamePlayModel : ModelBase
	{
		// Token: 0x0604750E RID: 292110 RVA: 0x01222F28 File Offset: 0x01221128
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

		// Token: 0x0604750F RID: 292111 RVA: 0x01222F9C File Offset: 0x0122119C
		public void SetRelationPortalParam(int scrId, PassThroughPortalParam portalParam)
		{
			this.ConnectedRelationPortalParam[scrId] = portalParam;
		}

		// Token: 0x06047510 RID: 292112 RVA: 0x01222FAC File Offset: 0x012211AC
		public void RemoveConnectRelation(int scrId, int targetId)
		{
			HashSet<int> hashSet;
			if (this.ConnectedRelationCache.TryGetValue(scrId, out hashSet))
			{
				hashSet.Remove(targetId);
			}
		}

		// Token: 0x06047511 RID: 292113 RVA: 0x01222FD1 File Offset: 0x012211D1
		public void RemoveRelationPortalType(int scrId)
		{
			this.ConnectedRelationPortalParam.Remove(scrId);
		}

		// Token: 0x06047512 RID: 292114 RVA: 0x01222FE0 File Offset: 0x012211E0
		[NullableContext(2)]
		public HashSet<int> GetRelationByEntityId(int scrId)
		{
			return this.ConnectedRelationCache.GetValueOrDefault(scrId);
		}

		// Token: 0x06047513 RID: 292115 RVA: 0x01222FEE File Offset: 0x012211EE
		[NullableContext(2)]
		public PassThroughPortalParam GetRelationPassThroughParam(int scrId)
		{
			return this.ConnectedRelationPortalParam.GetValueOrDefault(scrId);
		}

		// Token: 0x17009DEE RID: 40430
		// (get) Token: 0x06047514 RID: 292116 RVA: 0x01222FFC File Offset: 0x012211FC
		public static ConnectGamePlayModel Instance
		{
			get
			{
				return ConnectGamePlayModel._Instance;
			}
		}

		// Token: 0x06047515 RID: 292117 RVA: 0x01223003 File Offset: 0x01221203
		public static ConnectGamePlayModel GetOrCreateInstance()
		{
			if (ConnectGamePlayModel._Instance == null)
			{
				ConnectGamePlayModel.CreateInstance();
			}
			return ConnectGamePlayModel._Instance;
		}

		// Token: 0x06047516 RID: 292118 RVA: 0x01223017 File Offset: 0x01221217
		public static bool CreateInstance()
		{
			if (ConnectGamePlayModel._Instance != null)
			{
				return true;
			}
			ConnectGamePlayModel._Instance = new ConnectGamePlayModel();
			return true;
		}

		// Token: 0x06047517 RID: 292119 RVA: 0x0122302D File Offset: 0x0122122D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06047518 RID: 292120 RVA: 0x0122302F File Offset: 0x0122122F
		public static void ResetStaticDefaultValue()
		{
			ConnectGamePlayModel._Instance = null;
		}

		// Token: 0x06047519 RID: 292121 RVA: 0x01223037 File Offset: 0x01221237
		static ConnectGamePlayModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ConnectGamePlayModel.CreateStaticDefaultValue), new Action(ConnectGamePlayModel.ResetStaticDefaultValue));
		}

		// Token: 0x04025804 RID: 153604
		public readonly int TryConnectInterval = 500;

		// Token: 0x04025805 RID: 153605
		private readonly Dictionary<int, HashSet<int>> ConnectedRelationCache = new Dictionary<int, HashSet<int>>();

		// Token: 0x04025806 RID: 153606
		private readonly Dictionary<int, PassThroughPortalParam> ConnectedRelationPortalParam = new Dictionary<int, PassThroughPortalParam>();

		// Token: 0x04025807 RID: 153607
		[Nullable(2)]
		private static ConnectGamePlayModel _Instance;
	}
}
