using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B0B RID: 19211
	public struct ICheckRoadBuildState : IFlatbufferObject
	{
		// Token: 0x17008B5B RID: 35675
		// (get) Token: 0x0601E362 RID: 123746 RVA: 0x0043C800 File Offset: 0x0043AA00
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E363 RID: 123747 RVA: 0x0043C80D File Offset: 0x0043AA0D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E364 RID: 123748 RVA: 0x0043C814 File Offset: 0x0043AA14
		public static ICheckRoadBuildState GetRootAsICheckRoadBuildState(ByteBuffer _bb)
		{
			return ICheckRoadBuildState.GetRootAsICheckRoadBuildState(_bb, default(ICheckRoadBuildState));
		}

		// Token: 0x0601E365 RID: 123749 RVA: 0x0043C830 File Offset: 0x0043AA30
		public static ICheckRoadBuildState GetRootAsICheckRoadBuildState(ByteBuffer _bb, ICheckRoadBuildState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E366 RID: 123750 RVA: 0x0043C84D File Offset: 0x0043AA4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E367 RID: 123751 RVA: 0x0043C85C File Offset: 0x0043AA5C
		public ICheckRoadBuildState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B5C RID: 35676
		// (get) Token: 0x0601E368 RID: 123752 RVA: 0x0043C86C File Offset: 0x0043AA6C
		public ECheckSystemStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckSystemStateType.TrackMoonBuilding;
				}
				return (ECheckSystemStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008B5D RID: 35677
		// (get) Token: 0x0601E369 RID: 123753 RVA: 0x0043C8A8 File Offset: 0x0043AAA8
		public int RoadId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008B5E RID: 35678
		// (get) Token: 0x0601E36A RID: 123754 RVA: 0x0043C8E4 File Offset: 0x0043AAE4
		public bool IsBuilt
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601E36B RID: 123755 RVA: 0x0043C923 File Offset: 0x0043AB23
		public static Offset<ICheckRoadBuildState> CreateICheckRoadBuildState(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int RoadId = 0, bool IsBuilt = false)
		{
			builder.StartTable(3);
			ICheckRoadBuildState.AddRoadId(builder, RoadId);
			ICheckRoadBuildState.AddIsBuilt(builder, IsBuilt);
			ICheckRoadBuildState.AddType(builder, Type);
			return ICheckRoadBuildState.EndICheckRoadBuildState(builder);
		}

		// Token: 0x0601E36C RID: 123756 RVA: 0x0043C947 File Offset: 0x0043AB47
		public static void StartICheckRoadBuildState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E36D RID: 123757 RVA: 0x0043C950 File Offset: 0x0043AB50
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E36E RID: 123758 RVA: 0x0043C95B File Offset: 0x0043AB5B
		public static void AddRoadId(FlatBufferBuilder builder, int roadId)
		{
			builder.AddInt(1, roadId, 0);
		}

		// Token: 0x0601E36F RID: 123759 RVA: 0x0043C966 File Offset: 0x0043AB66
		public static void AddIsBuilt(FlatBufferBuilder builder, bool isBuilt)
		{
			builder.AddBool(2, isBuilt, false);
		}

		// Token: 0x0601E370 RID: 123760 RVA: 0x0043C971 File Offset: 0x0043AB71
		public static Offset<ICheckRoadBuildState> EndICheckRoadBuildState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckRoadBuildState>(builder.EndTable());
		}

		// Token: 0x0601E371 RID: 123761 RVA: 0x0043C980 File Offset: 0x0043AB80
		public ICheckRoadBuildStateT UnPack()
		{
			ICheckRoadBuildStateT checkRoadBuildStateT = new ICheckRoadBuildStateT();
			this.UnPackTo(checkRoadBuildStateT);
			return checkRoadBuildStateT;
		}

		// Token: 0x0601E372 RID: 123762 RVA: 0x0043C99B File Offset: 0x0043AB9B
		public void UnPackTo(ICheckRoadBuildStateT _o)
		{
			_o.Type = this.Type;
			_o.RoadId = this.RoadId;
			_o.IsBuilt = this.IsBuilt;
		}

		// Token: 0x0601E373 RID: 123763 RVA: 0x0043C9C4 File Offset: 0x0043ABC4
		public static Offset<ICheckRoadBuildState> Pack(FlatBufferBuilder builder, ICheckRoadBuildStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckRoadBuildState>);
			}
			return ICheckRoadBuildState.CreateICheckRoadBuildState(builder, _o.Type, _o.RoadId, _o.IsBuilt);
		}

		// Token: 0x0400D3A6 RID: 54182
		private Table __p;
	}
}
