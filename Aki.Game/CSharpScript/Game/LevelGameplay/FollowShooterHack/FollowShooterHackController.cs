using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.FollowShooterHack
{
	// Token: 0x02005FA3 RID: 24483
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class FollowShooterHackController : ControllerBase
	{
		// Token: 0x0603AD2E RID: 240942 RVA: 0x010A17C4 File Offset: 0x0109F9C4
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

		// Token: 0x0603AD2F RID: 240943 RVA: 0x010A1874 File Offset: 0x0109FA74
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

		// Token: 0x17006F02 RID: 28418
		// (get) Token: 0x0603AD30 RID: 240944 RVA: 0x010A191E File Offset: 0x0109FB1E
		public static FollowShooterHackController Instance
		{
			get
			{
				return FollowShooterHackController._Instance;
			}
		}

		// Token: 0x0603AD31 RID: 240945 RVA: 0x010A1925 File Offset: 0x0109FB25
		public static FollowShooterHackController GetOrCreateInstance()
		{
			if (FollowShooterHackController._Instance == null)
			{
				FollowShooterHackController.CreateInstance();
			}
			return FollowShooterHackController._Instance;
		}

		// Token: 0x0603AD32 RID: 240946 RVA: 0x010A1939 File Offset: 0x0109FB39
		public static bool CreateInstance()
		{
			if (FollowShooterHackController._Instance != null)
			{
				return true;
			}
			FollowShooterHackController._Instance = new FollowShooterHackController();
			return true;
		}

		// Token: 0x0603AD33 RID: 240947 RVA: 0x010A194F File Offset: 0x0109FB4F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603AD34 RID: 240948 RVA: 0x010A1951 File Offset: 0x0109FB51
		public static void ResetStaticDefaultValue()
		{
			FollowShooterHackController._Instance = null;
		}

		// Token: 0x0603AD35 RID: 240949 RVA: 0x010A1959 File Offset: 0x0109FB59
		static FollowShooterHackController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FollowShooterHackController.CreateStaticDefaultValue), new Action(FollowShooterHackController.ResetStaticDefaultValue));
		}

		// Token: 0x0401EEBD RID: 126653
		private const int GAMEPLAY_CUE_ID = 640015002;

		// Token: 0x0401EEBE RID: 126654
		private readonly Dictionary<long, HashSet<long>> HackRelationshipMap = new Dictionary<long, HashSet<long>>();

		// Token: 0x0401EEBF RID: 126655
		private readonly Dictionary<long, long> HackedTargetGameplayCueMap = new Dictionary<long, long>();

		// Token: 0x0401EEC0 RID: 126656
		[Nullable(2)]
		private static FollowShooterHackController _Instance;
	}
}
