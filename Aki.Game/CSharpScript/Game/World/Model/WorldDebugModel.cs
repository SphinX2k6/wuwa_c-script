using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.World.Model
{
	// Token: 0x02003451 RID: 13393
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldDebugModel : ModelBase
	{
		// Token: 0x170047C7 RID: 18375
		// (get) Token: 0x060222A2 RID: 139938 RVA: 0x009ADBD8 File Offset: 0x009ABDD8
		// (set) Token: 0x060222A3 RID: 139939 RVA: 0x009ADBE0 File Offset: 0x009ABDE0
		public bool EnableDebug
		{
			get
			{
				return this.EnableDebugInternal;
			}
			set
			{
				this.EnableDebugInternal = value;
			}
		}

		// Token: 0x060222A4 RID: 139940 RVA: 0x009ADBE9 File Offset: 0x009ABDE9
		public void AddSummonEntity(EntityHandle entity)
		{
			if (!entity)
			{
				return;
			}
			this.AoiSummonSet.Add(entity);
			this.AoiTotalSet.Add(entity);
		}

		// Token: 0x060222A5 RID: 139941 RVA: 0x009ADC0E File Offset: 0x009ABE0E
		public void AddVisionEntity(EntityHandle entity)
		{
			if (!entity)
			{
				return;
			}
			this.AoiVisionSet.Add(entity);
			this.AoiTotalSet.Add(entity);
		}

		// Token: 0x060222A6 RID: 139942 RVA: 0x009ADC33 File Offset: 0x009ABE33
		public void AddMonsterEntity(EntityHandle entity)
		{
			if (!entity)
			{
				return;
			}
			this.AoiMonsterSet.Add(entity);
			this.AoiTotalSet.Add(entity);
		}

		// Token: 0x060222A7 RID: 139943 RVA: 0x009ADC58 File Offset: 0x009ABE58
		public void AddNpcEntity(EntityHandle entity)
		{
			if (!entity)
			{
				return;
			}
			this.AoiNpcSet.Add(entity);
			this.AoiTotalSet.Add(entity);
		}

		// Token: 0x060222A8 RID: 139944 RVA: 0x009ADC7D File Offset: 0x009ABE7D
		public void AddRoleEntity(EntityHandle entity)
		{
			if (!entity)
			{
				return;
			}
			this.AoiRoleSet.Add(entity);
			this.AoiTotalSet.Add(entity);
		}

		// Token: 0x060222A9 RID: 139945 RVA: 0x009ADCA2 File Offset: 0x009ABEA2
		public void RemoveSummonEntity(EntityHandle entity)
		{
			if (!entity)
			{
				return;
			}
			this.AoiSummonSet.Remove(entity);
			this.AoiTotalSet.Remove(entity);
		}

		// Token: 0x060222AA RID: 139946 RVA: 0x009ADCC8 File Offset: 0x009ABEC8
		public void AddEntity(EEntityType entityType, EntityHandle entity)
		{
			if (!entity)
			{
				return;
			}
			switch (entityType)
			{
			case EEntityType.Player:
				this.AddRoleEntity(entity);
				return;
			case EEntityType.Npc:
				this.AddNpcEntity(entity);
				return;
			case EEntityType.Monster:
				this.AddMonsterEntity(entity);
				return;
			default:
				if (entityType != EEntityType.Vision)
				{
					return;
				}
				this.AddVisionEntity(entity);
				return;
			}
		}

		// Token: 0x060222AB RID: 139947 RVA: 0x009ADD14 File Offset: 0x009ABF14
		public void RemoveEntity(EEntityType entityType, EntityHandle handle)
		{
			if (!handle)
			{
				return;
			}
			switch (entityType)
			{
			case EEntityType.Player:
				this.AoiRoleSet.Remove(handle);
				this.AoiTotalSet.Remove(handle);
				return;
			case EEntityType.Npc:
				this.AoiNpcSet.Remove(handle);
				this.AoiTotalSet.Remove(handle);
				return;
			case EEntityType.Monster:
				this.AoiMonsterSet.Remove(handle);
				this.AoiTotalSet.Remove(handle);
				return;
			default:
				if (entityType != EEntityType.Vision)
				{
					return;
				}
				this.AoiVisionSet.Remove(handle);
				this.AoiTotalSet.Remove(handle);
				return;
			}
		}

		// Token: 0x060222AC RID: 139948 RVA: 0x009ADDAC File Offset: 0x009ABFAC
		protected override bool OnLeaveLevel()
		{
			if (!UKuroStaticLibrary.IsEditor(GlobalData.World))
			{
				return true;
			}
			if (!this.EnableDebug)
			{
				return true;
			}
			this.AoiTotalSet.Clear();
			this.AoiSummonSet.Clear();
			this.AoiVisionSet.Clear();
			this.AoiMonsterSet.Clear();
			this.AoiNpcSet.Clear();
			this.AoiRoleSet.Clear();
			return true;
		}

		// Token: 0x170047C8 RID: 18376
		// (get) Token: 0x060222AD RID: 139949 RVA: 0x009ADE14 File Offset: 0x009AC014
		public static WorldDebugModel Instance
		{
			get
			{
				return WorldDebugModel._Instance;
			}
		}

		// Token: 0x060222AE RID: 139950 RVA: 0x009ADE1B File Offset: 0x009AC01B
		public static WorldDebugModel GetOrCreateInstance()
		{
			if (WorldDebugModel._Instance == null)
			{
				WorldDebugModel.CreateInstance();
			}
			return WorldDebugModel._Instance;
		}

		// Token: 0x060222AF RID: 139951 RVA: 0x009ADE2F File Offset: 0x009AC02F
		public static bool CreateInstance()
		{
			if (WorldDebugModel._Instance != null)
			{
				return true;
			}
			WorldDebugModel._Instance = new WorldDebugModel();
			return true;
		}

		// Token: 0x060222B0 RID: 139952 RVA: 0x009ADE45 File Offset: 0x009AC045
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060222B1 RID: 139953 RVA: 0x009ADE47 File Offset: 0x009AC047
		public static void ResetStaticDefaultValue()
		{
			WorldDebugModel._Instance = null;
		}

		// Token: 0x060222B2 RID: 139954 RVA: 0x009ADE4F File Offset: 0x009AC04F
		static WorldDebugModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WorldDebugModel.CreateStaticDefaultValue), new Action(WorldDebugModel.ResetStaticDefaultValue));
		}

		// Token: 0x04012CD6 RID: 77014
		public const int FIGHTING_AOI_WEAPON_MAX_COUNT = 4;

		// Token: 0x04012CD7 RID: 77015
		public const int FIGHTING_AOI_ROLE_MAX_COUNT = 4;

		// Token: 0x04012CD8 RID: 77016
		public const int FIGHTING_AOI_SUMMON_MAX_COUNT = 4;

		// Token: 0x04012CD9 RID: 77017
		public const int FIGHTING_AOI_VISION_MAX_COUNT = 4;

		// Token: 0x04012CDA RID: 77018
		public const int FIGHTING_AOI_NPC_MONSTER_MAX_COUNT = 50;

		// Token: 0x04012CDB RID: 77019
		public const int FIGHTING_TOTAL_MAX_COUINT = 97;

		// Token: 0x04012CDC RID: 77020
		public const int AOI_WEAPON_MAX_COUNT = 6;

		// Token: 0x04012CDD RID: 77021
		public const int AOI_ROLE_MAX_COUNT = 4;

		// Token: 0x04012CDE RID: 77022
		public const int AOI_SUMMON_MAX_COUNT = 4;

		// Token: 0x04012CDF RID: 77023
		public const int AOI_VISION_MAX_COUNT = 4;

		// Token: 0x04012CE0 RID: 77024
		public const int AOI_NPC_MONSTER_MAX_COUNT = 50;

		// Token: 0x04012CE1 RID: 77025
		public const int TOTAL_MAX_COUINT = 95;

		// Token: 0x04012CE2 RID: 77026
		private bool EnableDebugInternal = true;

		// Token: 0x04012CE3 RID: 77027
		public readonly HashSet<EntityHandle> AoiTotalSet = new HashSet<EntityHandle>();

		// Token: 0x04012CE4 RID: 77028
		public readonly HashSet<EntityHandle> AoiSummonSet = new HashSet<EntityHandle>();

		// Token: 0x04012CE5 RID: 77029
		public readonly HashSet<EntityHandle> AoiVisionSet = new HashSet<EntityHandle>();

		// Token: 0x04012CE6 RID: 77030
		public readonly HashSet<EntityHandle> AoiMonsterSet = new HashSet<EntityHandle>();

		// Token: 0x04012CE7 RID: 77031
		public readonly HashSet<EntityHandle> AoiNpcSet = new HashSet<EntityHandle>();

		// Token: 0x04012CE8 RID: 77032
		public readonly HashSet<EntityHandle> AoiRoleSet = new HashSet<EntityHandle>();

		// Token: 0x04012CE9 RID: 77033
		[Nullable(2)]
		private static WorldDebugModel _Instance;
	}
}
