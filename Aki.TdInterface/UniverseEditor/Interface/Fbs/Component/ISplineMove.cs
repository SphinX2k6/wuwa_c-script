using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005983 RID: 22915
	public struct ISplineMove : IFlatbufferObject
	{
		// Token: 0x1700ABF3 RID: 44019
		// (get) Token: 0x06026CBE RID: 158910 RVA: 0x00557398 File Offset: 0x00555598
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026CBF RID: 158911 RVA: 0x005573A5 File Offset: 0x005555A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026CC0 RID: 158912 RVA: 0x005573AC File Offset: 0x005555AC
		public static ISplineMove GetRootAsISplineMove(ByteBuffer _bb)
		{
			return ISplineMove.GetRootAsISplineMove(_bb, default(ISplineMove));
		}

		// Token: 0x06026CC1 RID: 158913 RVA: 0x005573C8 File Offset: 0x005555C8
		public static ISplineMove GetRootAsISplineMove(ByteBuffer _bb, ISplineMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026CC2 RID: 158914 RVA: 0x005573E5 File Offset: 0x005555E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026CC3 RID: 158915 RVA: 0x005573F4 File Offset: 0x005555F4
		public ISplineMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06026CC4 RID: 158916 RVA: 0x00557404 File Offset: 0x00555604
		public IEntityStateCondition? StateConditions(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEntityStateCondition?(default(IEntityStateCondition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700ABF4 RID: 44020
		// (get) Token: 0x06026CC5 RID: 158917 RVA: 0x00557464 File Offset: 0x00555664
		public int StateConditionsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700ABF5 RID: 44021
		// (get) Token: 0x06026CC6 RID: 158918 RVA: 0x00557490 File Offset: 0x00555690
		public int Speed
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

		// Token: 0x1700ABF6 RID: 44022
		// (get) Token: 0x06026CC7 RID: 158919 RVA: 0x005574CC File Offset: 0x005556CC
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700ABF7 RID: 44023
		// (get) Token: 0x06026CC8 RID: 158920 RVA: 0x00557508 File Offset: 0x00555708
		public bool IsCircle
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ABF8 RID: 44024
		// (get) Token: 0x06026CC9 RID: 158921 RVA: 0x00557548 File Offset: 0x00555748
		public bool IsLookDir
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ABF9 RID: 44025
		// (get) Token: 0x06026CCA RID: 158922 RVA: 0x00557588 File Offset: 0x00555788
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026CCB RID: 158923 RVA: 0x005575C5 File Offset: 0x005557C5
		public static Offset<ISplineMove> CreateISplineMove(FlatBufferBuilder builder, VectorOffset StateConditionsOffset = default(VectorOffset), int Speed = 0, int SplineEntityId = 0, bool IsCircle = false, bool IsLookDir = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			ISplineMove.AddSplineEntityId(builder, SplineEntityId);
			ISplineMove.AddSpeed(builder, Speed);
			ISplineMove.AddStateConditions(builder, StateConditionsOffset);
			ISplineMove.AddNullMask(builder, NullMask);
			ISplineMove.AddIsLookDir(builder, IsLookDir);
			ISplineMove.AddIsCircle(builder, IsCircle);
			return ISplineMove.EndISplineMove(builder);
		}

		// Token: 0x06026CCC RID: 158924 RVA: 0x00557601 File Offset: 0x00555801
		public static void StartISplineMove(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06026CCD RID: 158925 RVA: 0x0055760A File Offset: 0x0055580A
		public static void AddStateConditions(FlatBufferBuilder builder, VectorOffset stateConditionsOffset)
		{
			builder.AddOffset(0, stateConditionsOffset.Value, 0);
		}

		// Token: 0x06026CCE RID: 158926 RVA: 0x0055761C File Offset: 0x0055581C
		public static VectorOffset CreateStateConditionsVector(FlatBufferBuilder builder, Offset<IEntityStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026CCF RID: 158927 RVA: 0x0055765C File Offset: 0x0055585C
		public static VectorOffset CreateStateConditionsVectorBlock(FlatBufferBuilder builder, Offset<IEntityStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026CD0 RID: 158928 RVA: 0x00557676 File Offset: 0x00555876
		public static VectorOffset CreateStateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityStateCondition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026CD1 RID: 158929 RVA: 0x00557694 File Offset: 0x00555894
		public static VectorOffset CreateStateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityStateCondition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026CD2 RID: 158930 RVA: 0x005576AD File Offset: 0x005558AD
		public static void StartStateConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026CD3 RID: 158931 RVA: 0x005576B8 File Offset: 0x005558B8
		public static void AddSpeed(FlatBufferBuilder builder, int speed)
		{
			builder.AddInt(1, speed, 0);
		}

		// Token: 0x06026CD4 RID: 158932 RVA: 0x005576C3 File Offset: 0x005558C3
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(2, splineEntityId, 0);
		}

		// Token: 0x06026CD5 RID: 158933 RVA: 0x005576CE File Offset: 0x005558CE
		public static void AddIsCircle(FlatBufferBuilder builder, bool isCircle)
		{
			builder.AddBool(3, isCircle, false);
		}

		// Token: 0x06026CD6 RID: 158934 RVA: 0x005576D9 File Offset: 0x005558D9
		public static void AddIsLookDir(FlatBufferBuilder builder, bool isLookDir)
		{
			builder.AddBool(4, isLookDir, false);
		}

		// Token: 0x06026CD7 RID: 158935 RVA: 0x005576E4 File Offset: 0x005558E4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06026CD8 RID: 158936 RVA: 0x005576EF File Offset: 0x005558EF
		public static Offset<ISplineMove> EndISplineMove(FlatBufferBuilder builder)
		{
			return new Offset<ISplineMove>(builder.EndTable());
		}

		// Token: 0x06026CD9 RID: 158937 RVA: 0x005576FC File Offset: 0x005558FC
		public ISplineMoveT UnPack()
		{
			ISplineMoveT splineMoveT = new ISplineMoveT();
			this.UnPackTo(splineMoveT);
			return splineMoveT;
		}

		// Token: 0x06026CDA RID: 158938 RVA: 0x00557718 File Offset: 0x00555918
		public void UnPackTo(ISplineMoveT _o)
		{
			_o.StateConditions = new List<IEntityStateConditionT>();
			for (int i = 0; i < this.StateConditionsLength; i++)
			{
				_o.StateConditions.Add((this.StateConditions(i) != null) ? this.StateConditions(i).Value.UnPack() : null);
			}
			_o.Speed = this.Speed;
			_o.SplineEntityId = this.SplineEntityId;
			_o.IsCircle = this.IsCircle;
			_o.IsLookDir = this.IsLookDir;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026CDB RID: 158939 RVA: 0x005577B4 File Offset: 0x005559B4
		public static Offset<ISplineMove> Pack(FlatBufferBuilder builder, ISplineMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISplineMove>);
			}
			VectorOffset stateConditionsOffset = default(VectorOffset);
			if (_o.StateConditions != null)
			{
				Offset<IEntityStateCondition>[] array = new Offset<IEntityStateCondition>[_o.StateConditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityStateCondition.Pack(builder, _o.StateConditions[i]);
				}
				stateConditionsOffset = ISplineMove.CreateStateConditionsVector(builder, array);
			}
			return ISplineMove.CreateISplineMove(builder, stateConditionsOffset, _o.Speed, _o.SplineEntityId, _o.IsCircle, _o.IsLookDir, _o.NullMask);
		}

		// Token: 0x0400EF74 RID: 61300
		private Table __p;
	}
}
