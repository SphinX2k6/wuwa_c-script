using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.FollowShooterHack
{
	// Token: 0x02006E23 RID: 28195
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class FollowShooterHackController : ControllerBase
	{
		// Token: 0x06044BC5 RID: 281541 RVA: 0x010F7288 File Offset: 0x010F5488
		public void AddRelationship(long followerId, long hackTargetId)
		{
			if (!this.HackRelationshipMap.ContainsKey(followerId))
			{
				this.HackRelationshipMap[followerId] = new HashSet<long>();
			}
			if (this.HackRelationshipMap[followerId].Contains(hackTargetId))
			{
				return;
			}
			EntityHandle entity = CreatureModel.Instance.GetEntity(hackTargetId);
			if (entity != null)
			{
				WorldEntity entity2 = entity.Entity;
				if (entity2 != null && entity2.Valid)
				{
					BaseGameplayCueComponent component = entity.Entity.GetComponent<BaseGameplayCueComponent>();
					if (component == null)
					{
						return;
					}
					int num = component.AddCue(640015002L, null);
					this.HackedTargetGameplayCueMap[hackTargetId] = (long)num;
					this.HackRelationshipMap[followerId].Add(hackTargetId);
					return;
				}
			}
		}

		// Token: 0x06044BC6 RID: 281542 RVA: 0x010F7338 File Offset: 0x010F5538
		public void RemoveRelationship(long followerId, long hackTargetId)
		{
			if (!this.HackRelationshipMap.ContainsKey(followerId))
			{
				return;
			}
			if (!this.HackRelationshipMap[followerId].Contains(hackTargetId))
			{
				return;
			}
			if (this.HackedTargetGameplayCueMap.ContainsKey(hackTargetId))
			{
				long cueHandleId = this.HackedTargetGameplayCueMap[hackTargetId];
				this.HackedTargetGameplayCueMap.Remove(hackTargetId);
				EntityHandle entity = CreatureModel.Instance.GetEntity(hackTargetId);
				if (entity != null)
				{
					WorldEntity entity2 = entity.Entity;
					if (entity2 != null && entity2.Valid)
					{
						BaseGameplayCueComponent component = entity.Entity.GetComponent<BaseGameplayCueComponent>();
						if (component == null)
						{
							return;
						}
						component.RemoveCueByHandle(cueHandleId);
						goto IL_8A;
					}
				}
				return;
			}
			IL_8A:
			this.HackRelationshipMap[followerId].Remove(hackTargetId);
		}

		// Token: 0x170099FF RID: 39423
		// (get) Token: 0x06044BC7 RID: 281543 RVA: 0x010F73E2 File Offset: 0x010F55E2
		public static FollowShooterHackController Instance
		{
			get
			{
				return FollowShooterHackController._Instance;
			}
		}

		// Token: 0x06044BC8 RID: 281544 RVA: 0x010F73E9 File Offset: 0x010F55E9
		public static FollowShooterHackController GetOrCreateInstance()
		{
			if (FollowShooterHackController._Instance == null)
			{
				FollowShooterHackController.CreateInstance();
			}
			return FollowShooterHackController._Instance;
		}

		// Token: 0x06044BC9 RID: 281545 RVA: 0x010F73FD File Offset: 0x010F55FD
		public static bool CreateInstance()
		{
			if (FollowShooterHackController._Instance != null)
			{
				return true;
			}
			FollowShooterHackController._Instance = new FollowShooterHackController();
			return true;
		}

		// Token: 0x06044BCA RID: 281546 RVA: 0x010F7413 File Offset: 0x010F5613
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06044BCB RID: 281547 RVA: 0x010F7415 File Offset: 0x010F5615
		public static void ResetStaticDefaultValue()
		{
			FollowShooterHackController._Instance = null;
		}

		// Token: 0x06044BCC RID: 281548 RVA: 0x010F741D File Offset: 0x010F561D
		static FollowShooterHackController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FollowShooterHackController.CreateStaticDefaultValue), new Action(FollowShooterHackController.ResetStaticDefaultValue));
		}

		// Token: 0x04023C1A RID: 146458
		private const int GAMEPLAY_CUE_ID = 640015002;

		// Token: 0x04023C1B RID: 146459
		private readonly Dictionary<long, HashSet<long>> HackRelationshipMap = new Dictionary<long, HashSet<long>>();

		// Token: 0x04023C1C RID: 146460
		private readonly Dictionary<long, long> HackedTargetGameplayCueMap = new Dictionary<long, long>();

		// Token: 0x04023C1D RID: 146461
		[Nullable(2)]
		private static FollowShooterHackController _Instance;
	}
}
