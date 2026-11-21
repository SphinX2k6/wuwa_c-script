using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Common.Model
{
	// Token: 0x020061F6 RID: 25078
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ClientTagModel : ModelBase
	{
		// Token: 0x0603C39A RID: 246682 RVA: 0x01127EBA File Offset: 0x011260BA
		protected override bool OnInit()
		{
			this.ClientModifiedTag = new Dictionary<int, HashSet<int>>();
			return true;
		}

		// Token: 0x0603C39B RID: 246683 RVA: 0x01127EC8 File Offset: 0x011260C8
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

		// Token: 0x0603C39C RID: 246684 RVA: 0x01127EE4 File Offset: 0x011260E4
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

		// Token: 0x0603C39D RID: 246685 RVA: 0x01127F1C File Offset: 0x0112611C
		public bool ClearTargetTagAdded(int entityId)
		{
			return this.ClientModifiedTag.Remove(entityId);
		}

		// Token: 0x0603C39E RID: 246686 RVA: 0x01127F2C File Offset: 0x0112612C
		public bool ClientRemoveTagFromTarget(int entityId, int tagId)
		{
			HashSet<int> hashSet;
			return this.ClientModifiedTag.TryGetValue(entityId, out hashSet) && hashSet.Remove(tagId);
		}

		// Token: 0x170071AC RID: 29100
		// (get) Token: 0x0603C39F RID: 246687 RVA: 0x01127F52 File Offset: 0x01126152
		public static ClientTagModel Instance
		{
			get
			{
				return ClientTagModel._Instance;
			}
		}

		// Token: 0x0603C3A0 RID: 246688 RVA: 0x01127F59 File Offset: 0x01126159
		public static ClientTagModel GetOrCreateInstance()
		{
			if (ClientTagModel._Instance == null)
			{
				ClientTagModel.CreateInstance();
			}
			return ClientTagModel._Instance;
		}

		// Token: 0x0603C3A1 RID: 246689 RVA: 0x01127F6D File Offset: 0x0112616D
		public static bool CreateInstance()
		{
			if (ClientTagModel._Instance != null)
			{
				return true;
			}
			ClientTagModel._Instance = new ClientTagModel();
			return true;
		}

		// Token: 0x0603C3A2 RID: 246690 RVA: 0x01127F83 File Offset: 0x01126183
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603C3A3 RID: 246691 RVA: 0x01127F85 File Offset: 0x01126185
		public static void ResetStaticDefaultValue()
		{
			ClientTagModel._Instance = null;
		}

		// Token: 0x0603C3A4 RID: 246692 RVA: 0x01127F8D File Offset: 0x0112618D
		static ClientTagModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ClientTagModel.CreateStaticDefaultValue), new Action(ClientTagModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401FE38 RID: 130616
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, HashSet<int>> ClientModifiedTag;

		// Token: 0x0401FE39 RID: 130617
		[Nullable(2)]
		private static ClientTagModel _Instance;
	}
}
