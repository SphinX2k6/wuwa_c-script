using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200671D RID: 26397
	public struct IExitMonsterMoveTarget : IFlatbufferObject
	{
		// Token: 0x1700C414 RID: 50196
		// (get) Token: 0x0602DEA3 RID: 188067 RVA: 0x00647112 File Offset: 0x00645312
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DEA4 RID: 188068 RVA: 0x0064711F File Offset: 0x0064531F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DEA5 RID: 188069 RVA: 0x00647128 File Offset: 0x00645328
		public static IExitMonsterMoveTarget GetRootAsIExitMonsterMoveTarget(ByteBuffer _bb)
		{
			return IExitMonsterMoveTarget.GetRootAsIExitMonsterMoveTarget(_bb, default(IExitMonsterMoveTarget));
		}

		// Token: 0x0602DEA6 RID: 188070 RVA: 0x00647144 File Offset: 0x00645344
		public static IExitMonsterMoveTarget GetRootAsIExitMonsterMoveTarget(ByteBuffer _bb, IExitMonsterMoveTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DEA7 RID: 188071 RVA: 0x00647161 File Offset: 0x00645361
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DEA8 RID: 188072 RVA: 0x00647170 File Offset: 0x00645370
		public IExitMonsterMoveTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C415 RID: 50197
		// (get) Token: 0x0602DEA9 RID: 188073 RVA: 0x00647180 File Offset: 0x00645380
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

		// Token: 0x0602DEAA RID: 188074 RVA: 0x006471BC File Offset: 0x006453BC
		public int TargetEntities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C416 RID: 50198
		// (get) Token: 0x0602DEAB RID: 188075 RVA: 0x006471FC File Offset: 0x006453FC
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

		// Token: 0x0602DEAC RID: 188076 RVA: 0x00647227 File Offset: 0x00645427
		public Span<int> GetTargetEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602DEAD RID: 188077 RVA: 0x00647236 File Offset: 0x00645436
		public int[] GetTargetEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0602DEAE RID: 188078 RVA: 0x00647244 File Offset: 0x00645444
		public static Offset<IExitMonsterMoveTarget> CreateIExitMonsterMoveTarget(FlatBufferBuilder builder, EExecBattleActionType Type = EExecBattleActionType.SetBattleTags, VectorOffset TargetEntitiesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IExitMonsterMoveTarget.AddTargetEntities(builder, TargetEntitiesOffset);
			IExitMonsterMoveTarget.AddType(builder, Type);
			return IExitMonsterMoveTarget.EndIExitMonsterMoveTarget(builder);
		}

		// Token: 0x0602DEAF RID: 188079 RVA: 0x00647261 File Offset: 0x00645461
		public static void StartIExitMonsterMoveTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DEB0 RID: 188080 RVA: 0x0064726A File Offset: 0x0064546A
		public static void AddType(FlatBufferBuilder builder, EExecBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DEB1 RID: 188081 RVA: 0x00647275 File Offset: 0x00645475
		public static void AddTargetEntities(FlatBufferBuilder builder, VectorOffset targetEntitiesOffset)
		{
			builder.AddOffset(1, targetEntitiesOffset.Value, 0);
		}

		// Token: 0x0602DEB2 RID: 188082 RVA: 0x00647288 File Offset: 0x00645488
		public static VectorOffset CreateTargetEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602DEB3 RID: 188083 RVA: 0x006472BF File Offset: 0x006454BF
		public static VectorOffset CreateTargetEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DEB4 RID: 188084 RVA: 0x006472D9 File Offset: 0x006454D9
		public static VectorOffset CreateTargetEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DEB5 RID: 188085 RVA: 0x006472F7 File Offset: 0x006454F7
		public static VectorOffset CreateTargetEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602DEB6 RID: 188086 RVA: 0x00647310 File Offset: 0x00645510
		public static void StartTargetEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602DEB7 RID: 188087 RVA: 0x0064731B File Offset: 0x0064551B
		public static Offset<IExitMonsterMoveTarget> EndIExitMonsterMoveTarget(FlatBufferBuilder builder)
		{
			return new Offset<IExitMonsterMoveTarget>(builder.EndTable());
		}

		// Token: 0x0602DEB8 RID: 188088 RVA: 0x00647328 File Offset: 0x00645528
		public IExitMonsterMoveTargetT UnPack()
		{
			IExitMonsterMoveTargetT exitMonsterMoveTargetT = new IExitMonsterMoveTargetT();
			this.UnPackTo(exitMonsterMoveTargetT);
			return exitMonsterMoveTargetT;
		}

		// Token: 0x0602DEB9 RID: 188089 RVA: 0x00647344 File Offset: 0x00645544
		public void UnPackTo(IExitMonsterMoveTargetT _o)
		{
			_o.Type = this.Type;
			_o.TargetEntities = new List<int>();
			for (int i = 0; i < this.TargetEntitiesLength; i++)
			{
				_o.TargetEntities.Add(this.TargetEntities(i));
			}
		}

		// Token: 0x0602DEBA RID: 188090 RVA: 0x0064738C File Offset: 0x0064558C
		public static Offset<IExitMonsterMoveTarget> Pack(FlatBufferBuilder builder, IExitMonsterMoveTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExitMonsterMoveTarget>);
			}
			VectorOffset targetEntitiesOffset = default(VectorOffset);
			if (_o.TargetEntities != null)
			{
				int[] data = _o.TargetEntities.ToArray();
				targetEntitiesOffset = IExitMonsterMoveTarget.CreateTargetEntitiesVector(builder, data);
			}
			return IExitMonsterMoveTarget.CreateIExitMonsterMoveTarget(builder, _o.Type, targetEntitiesOffset);
		}

		// Token: 0x04010E04 RID: 69124
		private Table __p;
	}
}
