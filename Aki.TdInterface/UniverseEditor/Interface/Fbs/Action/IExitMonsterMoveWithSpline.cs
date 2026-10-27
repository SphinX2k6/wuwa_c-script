using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006720 RID: 26400
	public struct IExitMonsterMoveWithSpline : IFlatbufferObject
	{
		// Token: 0x1700C419 RID: 50201
		// (get) Token: 0x0602DEC1 RID: 188097 RVA: 0x0064743F File Offset: 0x0064563F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DEC2 RID: 188098 RVA: 0x0064744C File Offset: 0x0064564C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DEC3 RID: 188099 RVA: 0x00647454 File Offset: 0x00645654
		public static IExitMonsterMoveWithSpline GetRootAsIExitMonsterMoveWithSpline(ByteBuffer _bb)
		{
			return IExitMonsterMoveWithSpline.GetRootAsIExitMonsterMoveWithSpline(_bb, default(IExitMonsterMoveWithSpline));
		}

		// Token: 0x0602DEC4 RID: 188100 RVA: 0x00647470 File Offset: 0x00645670
		public static IExitMonsterMoveWithSpline GetRootAsIExitMonsterMoveWithSpline(ByteBuffer _bb, IExitMonsterMoveWithSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DEC5 RID: 188101 RVA: 0x0064748D File Offset: 0x0064568D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DEC6 RID: 188102 RVA: 0x0064749C File Offset: 0x0064569C
		public IExitMonsterMoveWithSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C41A RID: 50202
		// (get) Token: 0x0602DEC7 RID: 188103 RVA: 0x006474AC File Offset: 0x006456AC
		public EExecBattleActionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExecBattleActionType.SetBattleTags;
				}
				return (EExecBattleActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DEC8 RID: 188104 RVA: 0x006474E8 File Offset: 0x006456E8
		public int TargetEntities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C41B RID: 50203
		// (get) Token: 0x0602DEC9 RID: 188105 RVA: 0x00647528 File Offset: 0x00645728
		public int TargetEntitiesLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602DECA RID: 188106 RVA: 0x00647553 File Offset: 0x00645753
		public Span<int> GetTargetEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602DECB RID: 188107 RVA: 0x00647562 File Offset: 0x00645762
		public int[] GetTargetEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0602DECC RID: 188108 RVA: 0x00647570 File Offset: 0x00645770
		public static Offset<IExitMonsterMoveWithSpline> CreateIExitMonsterMoveWithSpline(FlatBufferBuilder builder, EExecBattleActionType Type = EExecBattleActionType.SetBattleTags, VectorOffset TargetEntitiesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IExitMonsterMoveWithSpline.AddTargetEntities(builder, TargetEntitiesOffset);
			IExitMonsterMoveWithSpline.AddType(builder, Type);
			return IExitMonsterMoveWithSpline.EndIExitMonsterMoveWithSpline(builder);
		}

		// Token: 0x0602DECD RID: 188109 RVA: 0x0064758D File Offset: 0x0064578D
		public static void StartIExitMonsterMoveWithSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DECE RID: 188110 RVA: 0x00647596 File Offset: 0x00645796
		public static void AddType(FlatBufferBuilder builder, EExecBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DECF RID: 188111 RVA: 0x006475A1 File Offset: 0x006457A1
		public static void AddTargetEntities(FlatBufferBuilder builder, VectorOffset targetEntitiesOffset)
		{
			builder.AddOffset(1, targetEntitiesOffset.Value, 0);
		}

		// Token: 0x0602DED0 RID: 188112 RVA: 0x006475B4 File Offset: 0x006457B4
		public static VectorOffset CreateTargetEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602DED1 RID: 188113 RVA: 0x006475EB File Offset: 0x006457EB
		public static VectorOffset CreateTargetEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DED2 RID: 188114 RVA: 0x00647605 File Offset: 0x00645805
		public static VectorOffset CreateTargetEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DED3 RID: 188115 RVA: 0x00647623 File Offset: 0x00645823
		public static VectorOffset CreateTargetEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602DED4 RID: 188116 RVA: 0x0064763C File Offset: 0x0064583C
		public static void StartTargetEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602DED5 RID: 188117 RVA: 0x00647647 File Offset: 0x00645847
		public static Offset<IExitMonsterMoveWithSpline> EndIExitMonsterMoveWithSpline(FlatBufferBuilder builder)
		{
			return new Offset<IExitMonsterMoveWithSpline>(builder.EndTable());
		}

		// Token: 0x0602DED6 RID: 188118 RVA: 0x00647654 File Offset: 0x00645854
		public IExitMonsterMoveWithSplineT UnPack()
		{
			IExitMonsterMoveWithSplineT exitMonsterMoveWithSplineT = new IExitMonsterMoveWithSplineT();
			this.UnPackTo(exitMonsterMoveWithSplineT);
			return exitMonsterMoveWithSplineT;
		}

		// Token: 0x0602DED7 RID: 188119 RVA: 0x00647670 File Offset: 0x00645870
		public void UnPackTo(IExitMonsterMoveWithSplineT _o)
		{
			_o.Type = this.Type;
			_o.TargetEntities = new List<int>();
			for (int i = 0; i < this.TargetEntitiesLength; i++)
			{
				_o.TargetEntities.Add(this.TargetEntities(i));
			}
		}

		// Token: 0x0602DED8 RID: 188120 RVA: 0x006476B8 File Offset: 0x006458B8
		public static Offset<IExitMonsterMoveWithSpline> Pack(FlatBufferBuilder builder, IExitMonsterMoveWithSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExitMonsterMoveWithSpline>);
			}
			VectorOffset targetEntitiesOffset = default(VectorOffset);
			if (_o.TargetEntities != null)
			{
				int[] data = _o.TargetEntities.ToArray();
				targetEntitiesOffset = IExitMonsterMoveWithSpline.CreateTargetEntitiesVector(builder, data);
			}
			return IExitMonsterMoveWithSpline.CreateIExitMonsterMoveWithSpline(builder, _o.Type, targetEntitiesOffset);
		}

		// Token: 0x04010E07 RID: 69127
		private Table __p;
	}
}
