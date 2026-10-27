using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A6F RID: 19055
	public struct ICheckHookLockPointCondition : IFlatbufferObject
	{
		// Token: 0x170089FF RID: 35327
		// (get) Token: 0x0601DDB4 RID: 122292 RVA: 0x00431C08 File Offset: 0x0042FE08
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DDB5 RID: 122293 RVA: 0x00431C15 File Offset: 0x0042FE15
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DDB6 RID: 122294 RVA: 0x00431C1C File Offset: 0x0042FE1C
		public static ICheckHookLockPointCondition GetRootAsICheckHookLockPointCondition(ByteBuffer _bb)
		{
			return ICheckHookLockPointCondition.GetRootAsICheckHookLockPointCondition(_bb, default(ICheckHookLockPointCondition));
		}

		// Token: 0x0601DDB7 RID: 122295 RVA: 0x00431C38 File Offset: 0x0042FE38
		public static ICheckHookLockPointCondition GetRootAsICheckHookLockPointCondition(ByteBuffer _bb, ICheckHookLockPointCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DDB8 RID: 122296 RVA: 0x00431C55 File Offset: 0x0042FE55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DDB9 RID: 122297 RVA: 0x00431C64 File Offset: 0x0042FE64
		public ICheckHookLockPointCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A00 RID: 35328
		// (get) Token: 0x0601DDBA RID: 122298 RVA: 0x00431C74 File Offset: 0x0042FE74
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DDBB RID: 122299 RVA: 0x00431CB0 File Offset: 0x0042FEB0
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008A01 RID: 35329
		// (get) Token: 0x0601DDBC RID: 122300 RVA: 0x00431CF0 File Offset: 0x0042FEF0
		public int EntityIdsLength
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

		// Token: 0x0601DDBD RID: 122301 RVA: 0x00431D1B File Offset: 0x0042FF1B
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601DDBE RID: 122302 RVA: 0x00431D2A File Offset: 0x0042FF2A
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17008A02 RID: 35330
		// (get) Token: 0x0601DDBF RID: 122303 RVA: 0x00431D38 File Offset: 0x0042FF38
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DDC0 RID: 122304 RVA: 0x00431D74 File Offset: 0x0042FF74
		public static Offset<ICheckHookLockPointCondition> CreateICheckHookLockPointCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, VectorOffset EntityIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			ICheckHookLockPointCondition.AddEntityIds(builder, EntityIdsOffset);
			ICheckHookLockPointCondition.AddNullMask(builder, NullMask);
			ICheckHookLockPointCondition.AddType(builder, Type);
			return ICheckHookLockPointCondition.EndICheckHookLockPointCondition(builder);
		}

		// Token: 0x0601DDC1 RID: 122305 RVA: 0x00431D98 File Offset: 0x0042FF98
		public static void StartICheckHookLockPointCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DDC2 RID: 122306 RVA: 0x00431DA1 File Offset: 0x0042FFA1
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DDC3 RID: 122307 RVA: 0x00431DAC File Offset: 0x0042FFAC
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x0601DDC4 RID: 122308 RVA: 0x00431DBC File Offset: 0x0042FFBC
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DDC5 RID: 122309 RVA: 0x00431DF3 File Offset: 0x0042FFF3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DDC6 RID: 122310 RVA: 0x00431E0D File Offset: 0x0043000D
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DDC7 RID: 122311 RVA: 0x00431E2B File Offset: 0x0043002B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DDC8 RID: 122312 RVA: 0x00431E44 File Offset: 0x00430044
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DDC9 RID: 122313 RVA: 0x00431E4F File Offset: 0x0043004F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601DDCA RID: 122314 RVA: 0x00431E5A File Offset: 0x0043005A
		public static Offset<ICheckHookLockPointCondition> EndICheckHookLockPointCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHookLockPointCondition>(builder.EndTable());
		}

		// Token: 0x0601DDCB RID: 122315 RVA: 0x00431E68 File Offset: 0x00430068
		public ICheckHookLockPointConditionT UnPack()
		{
			ICheckHookLockPointConditionT checkHookLockPointConditionT = new ICheckHookLockPointConditionT();
			this.UnPackTo(checkHookLockPointConditionT);
			return checkHookLockPointConditionT;
		}

		// Token: 0x0601DDCC RID: 122316 RVA: 0x00431E84 File Offset: 0x00430084
		public void UnPackTo(ICheckHookLockPointConditionT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601DDCD RID: 122317 RVA: 0x00431ED8 File Offset: 0x004300D8
		public static Offset<ICheckHookLockPointCondition> Pack(FlatBufferBuilder builder, ICheckHookLockPointConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHookLockPointCondition>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = ICheckHookLockPointCondition.CreateEntityIdsVector(builder, data);
			}
			return ICheckHookLockPointCondition.CreateICheckHookLockPointCondition(builder, _o.Type, entityIdsOffset, _o.NullMask);
		}

		// Token: 0x0400D2D5 RID: 53973
		private Table __p;
	}
}
