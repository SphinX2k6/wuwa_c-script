using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DA0 RID: 28064
	public struct IExitMonsterMoveWithSpline : IFlatbufferObject
	{
		// Token: 0x1700CDCF RID: 52687
		// (get) Token: 0x06030707 RID: 198407 RVA: 0x00694B83 File Offset: 0x00692D83
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030708 RID: 198408 RVA: 0x00694B90 File Offset: 0x00692D90
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030709 RID: 198409 RVA: 0x00694B98 File Offset: 0x00692D98
		public static IExitMonsterMoveWithSpline GetRootAsIExitMonsterMoveWithSpline(ByteBuffer _bb)
		{
			return IExitMonsterMoveWithSpline.GetRootAsIExitMonsterMoveWithSpline(_bb, default(IExitMonsterMoveWithSpline));
		}

		// Token: 0x0603070A RID: 198410 RVA: 0x00694BB4 File Offset: 0x00692DB4
		public static IExitMonsterMoveWithSpline GetRootAsIExitMonsterMoveWithSpline(ByteBuffer _bb, IExitMonsterMoveWithSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603070B RID: 198411 RVA: 0x00694BD1 File Offset: 0x00692DD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603070C RID: 198412 RVA: 0x00694BE0 File Offset: 0x00692DE0
		public IExitMonsterMoveWithSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDD0 RID: 52688
		// (get) Token: 0x0603070D RID: 198413 RVA: 0x00694BF0 File Offset: 0x00692DF0
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

		// Token: 0x0603070E RID: 198414 RVA: 0x00694C2C File Offset: 0x00692E2C
		public int TargetEntities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CDD1 RID: 52689
		// (get) Token: 0x0603070F RID: 198415 RVA: 0x00694C6C File Offset: 0x00692E6C
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

		// Token: 0x06030710 RID: 198416 RVA: 0x00694C97 File Offset: 0x00692E97
		public Span<int> GetTargetEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06030711 RID: 198417 RVA: 0x00694CA6 File Offset: 0x00692EA6
		public int[] GetTargetEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06030712 RID: 198418 RVA: 0x00694CB4 File Offset: 0x00692EB4
		public static Offset<IExitMonsterMoveWithSpline> CreateIExitMonsterMoveWithSpline(FlatBufferBuilder builder, EExecBattleActionType Type = EExecBattleActionType.SetBattleTags, VectorOffset TargetEntitiesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IExitMonsterMoveWithSpline.AddTargetEntities(builder, TargetEntitiesOffset);
			IExitMonsterMoveWithSpline.AddType(builder, Type);
			return IExitMonsterMoveWithSpline.EndIExitMonsterMoveWithSpline(builder);
		}

		// Token: 0x06030713 RID: 198419 RVA: 0x00694CD1 File Offset: 0x00692ED1
		public static void StartIExitMonsterMoveWithSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030714 RID: 198420 RVA: 0x00694CDA File Offset: 0x00692EDA
		public static void AddType(FlatBufferBuilder builder, EExecBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030715 RID: 198421 RVA: 0x00694CE5 File Offset: 0x00692EE5
		public static void AddTargetEntities(FlatBufferBuilder builder, VectorOffset targetEntitiesOffset)
		{
			builder.AddOffset(1, targetEntitiesOffset.Value, 0);
		}

		// Token: 0x06030716 RID: 198422 RVA: 0x00694CF8 File Offset: 0x00692EF8
		public static VectorOffset CreateTargetEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06030717 RID: 198423 RVA: 0x00694D2F File Offset: 0x00692F2F
		public static VectorOffset CreateTargetEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06030718 RID: 198424 RVA: 0x00694D49 File Offset: 0x00692F49
		public static VectorOffset CreateTargetEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06030719 RID: 198425 RVA: 0x00694D67 File Offset: 0x00692F67
		public static VectorOffset CreateTargetEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603071A RID: 198426 RVA: 0x00694D80 File Offset: 0x00692F80
		public static void StartTargetEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603071B RID: 198427 RVA: 0x00694D8B File Offset: 0x00692F8B
		public static Offset<IExitMonsterMoveWithSpline> EndIExitMonsterMoveWithSpline(FlatBufferBuilder builder)
		{
			return new Offset<IExitMonsterMoveWithSpline>(builder.EndTable());
		}

		// Token: 0x0603071C RID: 198428 RVA: 0x00694D98 File Offset: 0x00692F98
		public IExitMonsterMoveWithSplineT UnPack()
		{
			IExitMonsterMoveWithSplineT exitMonsterMoveWithSplineT = new IExitMonsterMoveWithSplineT();
			this.UnPackTo(exitMonsterMoveWithSplineT);
			return exitMonsterMoveWithSplineT;
		}

		// Token: 0x0603071D RID: 198429 RVA: 0x00694DB4 File Offset: 0x00692FB4
		public void UnPackTo(IExitMonsterMoveWithSplineT _o)
		{
			_o.Type = this.Type;
			_o.TargetEntities = new List<int>();
			for (int i = 0; i < this.TargetEntitiesLength; i++)
			{
				_o.TargetEntities.Add(this.TargetEntities(i));
			}
		}

		// Token: 0x0603071E RID: 198430 RVA: 0x00694DFC File Offset: 0x00692FFC
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

		// Token: 0x04011C39 RID: 72761
		private Table __p;
	}
}
