using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F90 RID: 24464
	public struct ISplineMove : IFlatbufferObject
	{
		// Token: 0x1700B527 RID: 46375
		// (get) Token: 0x06029228 RID: 168488 RVA: 0x0059E004 File Offset: 0x0059C204
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029229 RID: 168489 RVA: 0x0059E011 File Offset: 0x0059C211
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602922A RID: 168490 RVA: 0x0059E018 File Offset: 0x0059C218
		public static ISplineMove GetRootAsISplineMove(ByteBuffer _bb)
		{
			return ISplineMove.GetRootAsISplineMove(_bb, default(ISplineMove));
		}

		// Token: 0x0602922B RID: 168491 RVA: 0x0059E034 File Offset: 0x0059C234
		public static ISplineMove GetRootAsISplineMove(ByteBuffer _bb, ISplineMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602922C RID: 168492 RVA: 0x0059E051 File Offset: 0x0059C251
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602922D RID: 168493 RVA: 0x0059E060 File Offset: 0x0059C260
		public ISplineMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602922E RID: 168494 RVA: 0x0059E070 File Offset: 0x0059C270
		public IEntityStateCondition? StateConditions(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEntityStateCondition?(default(IEntityStateCondition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B528 RID: 46376
		// (get) Token: 0x0602922F RID: 168495 RVA: 0x0059E0D0 File Offset: 0x0059C2D0
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

		// Token: 0x1700B529 RID: 46377
		// (get) Token: 0x06029230 RID: 168496 RVA: 0x0059E0FC File Offset: 0x0059C2FC
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

		// Token: 0x1700B52A RID: 46378
		// (get) Token: 0x06029231 RID: 168497 RVA: 0x0059E138 File Offset: 0x0059C338
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

		// Token: 0x1700B52B RID: 46379
		// (get) Token: 0x06029232 RID: 168498 RVA: 0x0059E174 File Offset: 0x0059C374
		public bool IsCircle
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B52C RID: 46380
		// (get) Token: 0x06029233 RID: 168499 RVA: 0x0059E1B4 File Offset: 0x0059C3B4
		public bool IsLookDir
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B52D RID: 46381
		// (get) Token: 0x06029234 RID: 168500 RVA: 0x0059E1F4 File Offset: 0x0059C3F4
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

		// Token: 0x06029235 RID: 168501 RVA: 0x0059E231 File Offset: 0x0059C431
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

		// Token: 0x06029236 RID: 168502 RVA: 0x0059E26D File Offset: 0x0059C46D
		public static void StartISplineMove(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06029237 RID: 168503 RVA: 0x0059E276 File Offset: 0x0059C476
		public static void AddStateConditions(FlatBufferBuilder builder, VectorOffset stateConditionsOffset)
		{
			builder.AddOffset(0, stateConditionsOffset.Value, 0);
		}

		// Token: 0x06029238 RID: 168504 RVA: 0x0059E288 File Offset: 0x0059C488
		public static VectorOffset CreateStateConditionsVector(FlatBufferBuilder builder, Offset<IEntityStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029239 RID: 168505 RVA: 0x0059E2C8 File Offset: 0x0059C4C8
		public static VectorOffset CreateStateConditionsVectorBlock(FlatBufferBuilder builder, Offset<IEntityStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602923A RID: 168506 RVA: 0x0059E2E2 File Offset: 0x0059C4E2
		public static VectorOffset CreateStateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityStateCondition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602923B RID: 168507 RVA: 0x0059E300 File Offset: 0x0059C500
		public static VectorOffset CreateStateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityStateCondition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602923C RID: 168508 RVA: 0x0059E319 File Offset: 0x0059C519
		public static void StartStateConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602923D RID: 168509 RVA: 0x0059E324 File Offset: 0x0059C524
		public static void AddSpeed(FlatBufferBuilder builder, int speed)
		{
			builder.AddInt(1, speed, 0);
		}

		// Token: 0x0602923E RID: 168510 RVA: 0x0059E32F File Offset: 0x0059C52F
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(2, splineEntityId, 0);
		}

		// Token: 0x0602923F RID: 168511 RVA: 0x0059E33A File Offset: 0x0059C53A
		public static void AddIsCircle(FlatBufferBuilder builder, bool isCircle)
		{
			builder.AddBool(3, isCircle, false);
		}

		// Token: 0x06029240 RID: 168512 RVA: 0x0059E345 File Offset: 0x0059C545
		public static void AddIsLookDir(FlatBufferBuilder builder, bool isLookDir)
		{
			builder.AddBool(4, isLookDir, false);
		}

		// Token: 0x06029241 RID: 168513 RVA: 0x0059E350 File Offset: 0x0059C550
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06029242 RID: 168514 RVA: 0x0059E35B File Offset: 0x0059C55B
		public static Offset<ISplineMove> EndISplineMove(FlatBufferBuilder builder)
		{
			return new Offset<ISplineMove>(builder.EndTable());
		}

		// Token: 0x06029243 RID: 168515 RVA: 0x0059E368 File Offset: 0x0059C568
		public ISplineMoveT UnPack()
		{
			ISplineMoveT splineMoveT = new ISplineMoveT();
			this.UnPackTo(splineMoveT);
			return splineMoveT;
		}

		// Token: 0x06029244 RID: 168516 RVA: 0x0059E384 File Offset: 0x0059C584
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

		// Token: 0x06029245 RID: 168517 RVA: 0x0059E420 File Offset: 0x0059C620
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

		// Token: 0x0400FC69 RID: 64617
		private Table __p;
	}
}
