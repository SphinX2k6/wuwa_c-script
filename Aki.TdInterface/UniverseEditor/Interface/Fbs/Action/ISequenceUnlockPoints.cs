using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200774D RID: 30541
	public struct ISequenceUnlockPoints : IFlatbufferObject
	{
		// Token: 0x1700DFE1 RID: 57313
		// (get) Token: 0x0603598C RID: 219532 RVA: 0x0072F102 File Offset: 0x0072D302
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603598D RID: 219533 RVA: 0x0072F10F File Offset: 0x0072D30F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603598E RID: 219534 RVA: 0x0072F118 File Offset: 0x0072D318
		public static ISequenceUnlockPoints GetRootAsISequenceUnlockPoints(ByteBuffer _bb)
		{
			return ISequenceUnlockPoints.GetRootAsISequenceUnlockPoints(_bb, default(ISequenceUnlockPoints));
		}

		// Token: 0x0603598F RID: 219535 RVA: 0x0072F134 File Offset: 0x0072D334
		public static ISequenceUnlockPoints GetRootAsISequenceUnlockPoints(ByteBuffer _bb, ISequenceUnlockPoints obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035990 RID: 219536 RVA: 0x0072F151 File Offset: 0x0072D351
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035991 RID: 219537 RVA: 0x0072F160 File Offset: 0x0072D360
		public ISequenceUnlockPoints __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DFE2 RID: 57314
		// (get) Token: 0x06035992 RID: 219538 RVA: 0x0072F170 File Offset: 0x0072D370
		public EInteractUnlockType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractUnlockType.Sequence;
				}
				return (EInteractUnlockType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035993 RID: 219539 RVA: 0x0072F1AC File Offset: 0x0072D3AC
		public ISequenceInteractStage? Stages(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISequenceInteractStage?(default(ISequenceInteractStage).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DFE3 RID: 57315
		// (get) Token: 0x06035994 RID: 219540 RVA: 0x0072F20C File Offset: 0x0072D40C
		public int StagesLength
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

		// Token: 0x06035995 RID: 219541 RVA: 0x0072F237 File Offset: 0x0072D437
		public static Offset<ISequenceUnlockPoints> CreateISequenceUnlockPoints(FlatBufferBuilder builder, EInteractUnlockType Type = EInteractUnlockType.Sequence, VectorOffset StagesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISequenceUnlockPoints.AddStages(builder, StagesOffset);
			ISequenceUnlockPoints.AddType(builder, Type);
			return ISequenceUnlockPoints.EndISequenceUnlockPoints(builder);
		}

		// Token: 0x06035996 RID: 219542 RVA: 0x0072F254 File Offset: 0x0072D454
		public static void StartISequenceUnlockPoints(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035997 RID: 219543 RVA: 0x0072F25D File Offset: 0x0072D45D
		public static void AddType(FlatBufferBuilder builder, EInteractUnlockType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035998 RID: 219544 RVA: 0x0072F268 File Offset: 0x0072D468
		public static void AddStages(FlatBufferBuilder builder, VectorOffset stagesOffset)
		{
			builder.AddOffset(1, stagesOffset.Value, 0);
		}

		// Token: 0x06035999 RID: 219545 RVA: 0x0072F278 File Offset: 0x0072D478
		public static VectorOffset CreateStagesVector(FlatBufferBuilder builder, Offset<ISequenceInteractStage>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603599A RID: 219546 RVA: 0x0072F2B8 File Offset: 0x0072D4B8
		public static VectorOffset CreateStagesVectorBlock(FlatBufferBuilder builder, Offset<ISequenceInteractStage>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISequenceInteractStage>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603599B RID: 219547 RVA: 0x0072F2D2 File Offset: 0x0072D4D2
		public static VectorOffset CreateStagesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISequenceInteractStage>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISequenceInteractStage>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603599C RID: 219548 RVA: 0x0072F2F0 File Offset: 0x0072D4F0
		public static VectorOffset CreateStagesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISequenceInteractStage>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603599D RID: 219549 RVA: 0x0072F309 File Offset: 0x0072D509
		public static void StartStagesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603599E RID: 219550 RVA: 0x0072F314 File Offset: 0x0072D514
		public static Offset<ISequenceUnlockPoints> EndISequenceUnlockPoints(FlatBufferBuilder builder)
		{
			return new Offset<ISequenceUnlockPoints>(builder.EndTable());
		}

		// Token: 0x0603599F RID: 219551 RVA: 0x0072F324 File Offset: 0x0072D524
		public ISequenceUnlockPointsT UnPack()
		{
			ISequenceUnlockPointsT sequenceUnlockPointsT = new ISequenceUnlockPointsT();
			this.UnPackTo(sequenceUnlockPointsT);
			return sequenceUnlockPointsT;
		}

		// Token: 0x060359A0 RID: 219552 RVA: 0x0072F340 File Offset: 0x0072D540
		public void UnPackTo(ISequenceUnlockPointsT _o)
		{
			_o.Type = this.Type;
			_o.Stages = new List<ISequenceInteractStageT>();
			for (int i = 0; i < this.StagesLength; i++)
			{
				_o.Stages.Add((this.Stages(i) != null) ? this.Stages(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060359A1 RID: 219553 RVA: 0x0072F3AC File Offset: 0x0072D5AC
		public static Offset<ISequenceUnlockPoints> Pack(FlatBufferBuilder builder, ISequenceUnlockPointsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISequenceUnlockPoints>);
			}
			VectorOffset stagesOffset = default(VectorOffset);
			if (_o.Stages != null)
			{
				Offset<ISequenceInteractStage>[] array = new Offset<ISequenceInteractStage>[_o.Stages.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISequenceInteractStage.Pack(builder, _o.Stages[i]);
				}
				stagesOffset = ISequenceUnlockPoints.CreateStagesVector(builder, array);
			}
			return ISequenceUnlockPoints.CreateISequenceUnlockPoints(builder, _o.Type, stagesOffset);
		}

		// Token: 0x04012966 RID: 76134
		private Table __p;
	}
}
