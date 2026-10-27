using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F87 RID: 28551
	public struct ISequenceUnlockPoints : IFlatbufferObject
	{
		// Token: 0x1700D412 RID: 54290
		// (get) Token: 0x0603273C RID: 206652 RVA: 0x006CF74A File Offset: 0x006CD94A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603273D RID: 206653 RVA: 0x006CF757 File Offset: 0x006CD957
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603273E RID: 206654 RVA: 0x006CF760 File Offset: 0x006CD960
		public static ISequenceUnlockPoints GetRootAsISequenceUnlockPoints(ByteBuffer _bb)
		{
			return ISequenceUnlockPoints.GetRootAsISequenceUnlockPoints(_bb, default(ISequenceUnlockPoints));
		}

		// Token: 0x0603273F RID: 206655 RVA: 0x006CF77C File Offset: 0x006CD97C
		public static ISequenceUnlockPoints GetRootAsISequenceUnlockPoints(ByteBuffer _bb, ISequenceUnlockPoints obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032740 RID: 206656 RVA: 0x006CF799 File Offset: 0x006CD999
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032741 RID: 206657 RVA: 0x006CF7A8 File Offset: 0x006CD9A8
		public ISequenceUnlockPoints __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D413 RID: 54291
		// (get) Token: 0x06032742 RID: 206658 RVA: 0x006CF7B8 File Offset: 0x006CD9B8
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

		// Token: 0x06032743 RID: 206659 RVA: 0x006CF7F4 File Offset: 0x006CD9F4
		public ISequenceInteractStage? Stages(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISequenceInteractStage?(default(ISequenceInteractStage).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D414 RID: 54292
		// (get) Token: 0x06032744 RID: 206660 RVA: 0x006CF854 File Offset: 0x006CDA54
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

		// Token: 0x06032745 RID: 206661 RVA: 0x006CF87F File Offset: 0x006CDA7F
		public static Offset<ISequenceUnlockPoints> CreateISequenceUnlockPoints(FlatBufferBuilder builder, EInteractUnlockType Type = EInteractUnlockType.Sequence, VectorOffset StagesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISequenceUnlockPoints.AddStages(builder, StagesOffset);
			ISequenceUnlockPoints.AddType(builder, Type);
			return ISequenceUnlockPoints.EndISequenceUnlockPoints(builder);
		}

		// Token: 0x06032746 RID: 206662 RVA: 0x006CF89C File Offset: 0x006CDA9C
		public static void StartISequenceUnlockPoints(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032747 RID: 206663 RVA: 0x006CF8A5 File Offset: 0x006CDAA5
		public static void AddType(FlatBufferBuilder builder, EInteractUnlockType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032748 RID: 206664 RVA: 0x006CF8B0 File Offset: 0x006CDAB0
		public static void AddStages(FlatBufferBuilder builder, VectorOffset stagesOffset)
		{
			builder.AddOffset(1, stagesOffset.Value, 0);
		}

		// Token: 0x06032749 RID: 206665 RVA: 0x006CF8C0 File Offset: 0x006CDAC0
		public static VectorOffset CreateStagesVector(FlatBufferBuilder builder, Offset<ISequenceInteractStage>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603274A RID: 206666 RVA: 0x006CF900 File Offset: 0x006CDB00
		public static VectorOffset CreateStagesVectorBlock(FlatBufferBuilder builder, Offset<ISequenceInteractStage>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISequenceInteractStage>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603274B RID: 206667 RVA: 0x006CF91A File Offset: 0x006CDB1A
		public static VectorOffset CreateStagesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISequenceInteractStage>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISequenceInteractStage>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603274C RID: 206668 RVA: 0x006CF938 File Offset: 0x006CDB38
		public static VectorOffset CreateStagesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISequenceInteractStage>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603274D RID: 206669 RVA: 0x006CF951 File Offset: 0x006CDB51
		public static void StartStagesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603274E RID: 206670 RVA: 0x006CF95C File Offset: 0x006CDB5C
		public static Offset<ISequenceUnlockPoints> EndISequenceUnlockPoints(FlatBufferBuilder builder)
		{
			return new Offset<ISequenceUnlockPoints>(builder.EndTable());
		}

		// Token: 0x0603274F RID: 206671 RVA: 0x006CF96C File Offset: 0x006CDB6C
		public ISequenceUnlockPointsT UnPack()
		{
			ISequenceUnlockPointsT sequenceUnlockPointsT = new ISequenceUnlockPointsT();
			this.UnPackTo(sequenceUnlockPointsT);
			return sequenceUnlockPointsT;
		}

		// Token: 0x06032750 RID: 206672 RVA: 0x006CF988 File Offset: 0x006CDB88
		public void UnPackTo(ISequenceUnlockPointsT _o)
		{
			_o.Type = this.Type;
			_o.Stages = new List<ISequenceInteractStageT>();
			for (int i = 0; i < this.StagesLength; i++)
			{
				_o.Stages.Add((this.Stages(i) != null) ? this.Stages(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06032751 RID: 206673 RVA: 0x006CF9F4 File Offset: 0x006CDBF4
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

		// Token: 0x04011984 RID: 72068
		private Table __p;
	}
}
