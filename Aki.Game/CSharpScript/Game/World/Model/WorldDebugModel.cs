using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.World.Model
{
	// Token: 0x0200452C RID: 17708
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldDebugModel : ModelBase
	{
		// Token: 0x17007514 RID: 29972
		// (get) Token: 0x0602DBDB RID: 187355 RVA: 0x00A829C0 File Offset: 0x00A80BC0
		// (set) Token: 0x0602DBDC RID: 187356 RVA: 0x00A829C8 File Offset: 0x00A80BC8
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

		// Token: 0x0602DBDD RID: 187357 RVA: 0x00A829D1 File Offset: 0x00A80BD1
		public void AddSummonEntity(EntityHandle entity)
		{
			if (!entity)
			{
				return;
			}
			this.AoiSummonSet.Add(entity);
			this.AoiTotalSet.Add(entity);
		}

		// Token: 0x0602DBDE RID: 187358 RVA: 0x00A829F6 File Offset: 0x00A80BF6
		public void AddVisionEntity(EntityHandle entity)
		{
			if (!entity)
			{
				return;
			}
			this.AoiVisionSet.Add(entity);
			this.AoiTotalSet.Add(entity);
		}

		// Token: 0x0602DBDF RID: 187359 RVA: 0x00A82A1B File Offset: 0x00A80C1B
		public void AddMonsterEntity(EntityHandle entity)
		{
			if (!entity)
			{
				return;
			}
			this.AoiMonsterSet.Add(entity);
			this.AoiTotalSet.Add(entity);
		}

		// Token: 0x0602DBE0 RID: 187360 RVA: 0x00A82A40 File Offset: 0x00A80C40
		public void AddNpcEntity(EntityHandle entity)
		{
			if (!entity)
			{
				return;
			}
			this.AoiNpcSet.Add(entity);
			this.AoiTotalSet.Add(entity);
		}

		// Token: 0x0602DBE1 RID: 187361 RVA: 0x00A82A65 File Offset: 0x00A80C65
		public void AddRoleEntity(EntityHandle entity)
		{
			if (!entity)
			{
				return;
			}
			this.AoiRoleSet.Add(entity);
			this.AoiTotalSet.Add(entity);
		}

		// Token: 0x0602DBE2 RID: 187362 RVA: 0x00A82A8A File Offset: 0x00A80C8A
		public void RemoveSummonEntity(EntityHandle entity)
		{
			if (!entity)
			{
				return;
			}
			this.AoiSummonSet.Remove(entity);
			this.AoiTotalSet.Remove(entity);
		}

		// Token: 0x0602DBE3 RID: 187363 RVA: 0x00A82AB0 File Offset: 0x00A80CB0
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

		// Token: 0x0602DBE4 RID: 187364 RVA: 0x00A82AFC File Offset: 0x00A80CFC
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

		// Token: 0x0602DBE5 RID: 187365 RVA: 0x00A82B94 File Offset: 0x00A80D94
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

		// Token: 0x17007515 RID: 29973
		// (get) Token: 0x0602DBE6 RID: 187366 RVA: 0x00A82BFC File Offset: 0x00A80DFC
		public static WorldDebugModel Instance
		{
			get
			{
				return WorldDebugModel._Instance;
			}
		}

		// Token: 0x0602DBE7 RID: 187367 RVA: 0x00A82C03 File Offset: 0x00A80E03
		public static WorldDebugModel GetOrCreateInstance()
		{
			if (WorldDebugModel._Instance == null)
			{
				WorldDebugModel.CreateInstance();
			}
			return WorldDebugModel._Instance;
		}

		// Token: 0x0602DBE8 RID: 187368 RVA: 0x00A82C17 File Offset: 0x00A80E17
		public static bool CreateInstance()
		{
			if (WorldDebugModel._Instance != null)
			{
				return true;
			}
			WorldDebugModel._Instance = new WorldDebugModel();
			return true;
		}

		// Token: 0x0602DBE9 RID: 187369 RVA: 0x00A82C2D File Offset: 0x00A80E2D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DBEA RID: 187370 RVA: 0x00A82C2F File Offset: 0x00A80E2F
		public static void ResetStaticDefaultValue()
		{
			WorldDebugModel._Instance = null;
		}

		// Token: 0x0602DBEB RID: 187371 RVA: 0x00A82C37 File Offset: 0x00A80E37
		static WorldDebugModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WorldDebugModel.CreateStaticDefaultValue), new Action(WorldDebugModel.ResetStaticDefaultValue));
		}

		// Token: 0x040186B2 RID: 100018
		public const int FIGHTING_AOI_WEAPON_MAX_COUNT = 4;

		// Token: 0x040186B3 RID: 100019
		public const int FIGHTING_AOI_ROLE_MAX_COUNT = 4;

		// Token: 0x040186B4 RID: 100020
		public const int FIGHTING_AOI_SUMMON_MAX_COUNT = 4;

		// Token: 0x040186B5 RID: 100021
		public const int FIGHTING_AOI_VISION_MAX_COUNT = 4;

		// Token: 0x040186B6 RID: 100022
		public const int FIGHTING_AOI_NPC_MONSTER_MAX_COUNT = 50;

		// Token: 0x040186B7 RID: 100023
		public const int FIGHTING_TOTAL_MAX_COUINT = 97;

		// Token: 0x040186B8 RID: 100024
		public const int AOI_WEAPON_MAX_COUNT = 6;

		// Token: 0x040186B9 RID: 100025
		public const int AOI_ROLE_MAX_COUNT = 4;

		// Token: 0x040186BA RID: 100026
		public const int AOI_SUMMON_MAX_COUNT = 4;

		// Token: 0x040186BB RID: 100027
		public const int AOI_VISION_MAX_COUNT = 4;

		// Token: 0x040186BC RID: 100028
		public const int AOI_NPC_MONSTER_MAX_COUNT = 50;

		// Token: 0x040186BD RID: 100029
		public const int TOTAL_MAX_COUINT = 95;

		// Token: 0x040186BE RID: 100030
		private bool EnableDebugInternal = true;

		// Token: 0x040186BF RID: 100031
		public readonly HashSet<EntityHandle> AoiTotalSet = new HashSet<EntityHandle>();

		// Token: 0x040186C0 RID: 100032
		public readonly HashSet<EntityHandle> AoiSummonSet = new HashSet<EntityHandle>();

		// Token: 0x040186C1 RID: 100033
		public readonly HashSet<EntityHandle> AoiVisionSet = new HashSet<EntityHandle>();

		// Token: 0x040186C2 RID: 100034
		public readonly HashSet<EntityHandle> AoiMonsterSet = new HashSet<EntityHandle>();

		// Token: 0x040186C3 RID: 100035
		public readonly HashSet<EntityHandle> AoiNpcSet = new HashSet<EntityHandle>();

		// Token: 0x040186C4 RID: 100036
		public readonly HashSet<EntityHandle> AoiRoleSet = new HashSet<EntityHandle>();

		// Token: 0x040186C5 RID: 100037
		[Nullable(2)]
		private static WorldDebugModel _Instance;
	}
}
