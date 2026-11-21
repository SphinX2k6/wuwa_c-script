using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D9D RID: 28061
	public struct IExitMonsterMoveTarget : IFlatbufferObject
	{
		// Token: 0x1700CDCA RID: 52682
		// (get) Token: 0x060306E9 RID: 198377 RVA: 0x00694856 File Offset: 0x00692A56
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060306EA RID: 198378 RVA: 0x00694863 File Offset: 0x00692A63
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060306EB RID: 198379 RVA: 0x0069486C File Offset: 0x00692A6C
		public static IExitMonsterMoveTarget GetRootAsIExitMonsterMoveTarget(ByteBuffer _bb)
		{
			return IExitMonsterMoveTarget.GetRootAsIExitMonsterMoveTarget(_bb, default(IExitMonsterMoveTarget));
		}

		// Token: 0x060306EC RID: 198380 RVA: 0x00694888 File Offset: 0x00692A88
		public static IExitMonsterMoveTarget GetRootAsIExitMonsterMoveTarget(ByteBuffer _bb, IExitMonsterMoveTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060306ED RID: 198381 RVA: 0x006948A5 File Offset: 0x00692AA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060306EE RID: 198382 RVA: 0x006948B4 File Offset: 0x00692AB4
		public IExitMonsterMoveTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDCB RID: 52683
		// (get) Token: 0x060306EF RID: 198383 RVA: 0x006948C4 File Offset: 0x00692AC4
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

		// Token: 0x060306F0 RID: 198384 RVA: 0x00694900 File Offset: 0x00692B00
		public int TargetEntities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CDCC RID: 52684
		// (get) Token: 0x060306F1 RID: 198385 RVA: 0x00694940 File Offset: 0x00692B40
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

		// Token: 0x060306F2 RID: 198386 RVA: 0x0069496B File Offset: 0x00692B6B
		public Span<int> GetTargetEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060306F3 RID: 198387 RVA: 0x0069497A File Offset: 0x00692B7A
		public int[] GetTargetEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x060306F4 RID: 198388 RVA: 0x00694988 File Offset: 0x00692B88
		public static Offset<IExitMonsterMoveTarget> CreateIExitMonsterMoveTarget(FlatBufferBuilder builder, EExecBattleActionType Type = EExecBattleActionType.SetBattleTags, VectorOffset TargetEntitiesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IExitMonsterMoveTarget.AddTargetEntities(builder, TargetEntitiesOffset);
			IExitMonsterMoveTarget.AddType(builder, Type);
			return IExitMonsterMoveTarget.EndIExitMonsterMoveTarget(builder);
		}

		// Token: 0x060306F5 RID: 198389 RVA: 0x006949A5 File Offset: 0x00692BA5
		public static void StartIExitMonsterMoveTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060306F6 RID: 198390 RVA: 0x006949AE File Offset: 0x00692BAE
		public static void AddType(FlatBufferBuilder builder, EExecBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060306F7 RID: 198391 RVA: 0x006949B9 File Offset: 0x00692BB9
		public static void AddTargetEntities(FlatBufferBuilder builder, VectorOffset targetEntitiesOffset)
		{
			builder.AddOffset(1, targetEntitiesOffset.Value, 0);
		}

		// Token: 0x060306F8 RID: 198392 RVA: 0x006949CC File Offset: 0x00692BCC
		public static VectorOffset CreateTargetEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060306F9 RID: 198393 RVA: 0x00694A03 File Offset: 0x00692C03
		public static VectorOffset CreateTargetEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060306FA RID: 198394 RVA: 0x00694A1D File Offset: 0x00692C1D
		public static VectorOffset CreateTargetEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060306FB RID: 198395 RVA: 0x00694A3B File Offset: 0x00692C3B
		public static VectorOffset CreateTargetEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060306FC RID: 198396 RVA: 0x00694A54 File Offset: 0x00692C54
		public static void StartTargetEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060306FD RID: 198397 RVA: 0x00694A5F File Offset: 0x00692C5F
		public static Offset<IExitMonsterMoveTarget> EndIExitMonsterMoveTarget(FlatBufferBuilder builder)
		{
			return new Offset<IExitMonsterMoveTarget>(builder.EndTable());
		}

		// Token: 0x060306FE RID: 198398 RVA: 0x00694A6C File Offset: 0x00692C6C
		public IExitMonsterMoveTargetT UnPack()
		{
			IExitMonsterMoveTargetT exitMonsterMoveTargetT = new IExitMonsterMoveTargetT();
			this.UnPackTo(exitMonsterMoveTargetT);
			return exitMonsterMoveTargetT;
		}

		// Token: 0x060306FF RID: 198399 RVA: 0x00694A88 File Offset: 0x00692C88
		public void UnPackTo(IExitMonsterMoveTargetT _o)
		{
			_o.Type = this.Type;
			_o.TargetEntities = new List<int>();
			for (int i = 0; i < this.TargetEntitiesLength; i++)
			{
				_o.TargetEntities.Add(this.TargetEntities(i));
			}
		}

		// Token: 0x06030700 RID: 198400 RVA: 0x00694AD0 File Offset: 0x00692CD0
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

		// Token: 0x04011C36 RID: 72758
		private Table __p;
	}
}
