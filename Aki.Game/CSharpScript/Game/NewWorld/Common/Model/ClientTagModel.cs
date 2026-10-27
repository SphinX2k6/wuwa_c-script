using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Common.Model
{
	// Token: 0x02007075 RID: 28789
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ClientTagModel : ModelBase
	{
		// Token: 0x06046190 RID: 287120 RVA: 0x0117E69E File Offset: 0x0117C89E
		protected override bool OnInit()
		{
			this.ClientModifiedTag = new Dictionary<int, HashSet<int>>();
			return true;
		}

		// Token: 0x06046191 RID: 287121 RVA: 0x0117E6AC File Offset: 0x0117C8AC
		protected override bool OnClear()
		{
			Dictionary<int, HashSet<int>> clientModifiedTag = this.ClientModifiedTag;
			if (clientModifiedTag != null)
			{
				clientModifiedTag.Clear();
			}
			this.ClientModifiedTag = null;
			return true;
		}

		// Token: 0x06046192 RID: 287122 RVA: 0x0117E6C8 File Offset: 0x0117C8C8
		public void ClientAddTagToTarget(int entityId, int tagId)
		{
			HashSet<int> hashSet;
			if (!this.ClientModifiedTag.TryGetValue(entityId, out hashSet))
			{
				hashSet = new HashSet<int>();
				this.ClientModifiedTag.Add(entityId, hashSet);
			}
			hashSet.Add(tagId);
		}

		// Token: 0x06046193 RID: 287123 RVA: 0x0117E700 File Offset: 0x0117C900
		public bool ClearTargetTagAdded(int entityId)
		{
			return this.ClientModifiedTag.Remove(entityId);
		}

		// Token: 0x06046194 RID: 287124 RVA: 0x0117E710 File Offset: 0x0117C910
		public bool ClientRemoveTagFromTarget(int entityId, int tagId)
		{
			HashSet<int> hashSet;
			return this.ClientModifiedTag.TryGetValue(entityId, out hashSet) && hashSet.Remove(tagId);
		}

		// Token: 0x17009C17 RID: 39959
		// (get) Token: 0x06046195 RID: 287125 RVA: 0x0117E736 File Offset: 0x0117C936
		public static ClientTagModel Instance
		{
			get
			{
				return ClientTagModel._Instance;
			}
		}

		// Token: 0x06046196 RID: 287126 RVA: 0x0117E73D File Offset: 0x0117C93D
		public static ClientTagModel GetOrCreateInstance()
		{
			if (ClientTagModel._Instance == null)
			{
				ClientTagModel.CreateInstance();
			}
			return ClientTagModel._Instance;
		}

		// Token: 0x06046197 RID: 287127 RVA: 0x0117E751 File Offset: 0x0117C951
		public static bool CreateInstance()
		{
			if (ClientTagModel._Instance != null)
			{
				return true;
			}
			ClientTagModel._Instance = new ClientTagModel();
			return true;
		}

		// Token: 0x06046198 RID: 287128 RVA: 0x0117E767 File Offset: 0x0117C967
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06046199 RID: 287129 RVA: 0x0117E769 File Offset: 0x0117C969
		public static void ResetStaticDefaultValue()
		{
			ClientTagModel._Instance = null;
		}

		// Token: 0x0604619A RID: 287130 RVA: 0x0117E771 File Offset: 0x0117C971
		static ClientTagModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ClientTagModel.CreateStaticDefaultValue), new Action(ClientTagModel.ResetStaticDefaultValue));
		}

		// Token: 0x04024B7D RID: 150397
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, HashSet<int>> ClientModifiedTag;

		// Token: 0x04024B7E RID: 150398
		[Nullable(2)]
		private static ClientTagModel _Instance;
	}
}
