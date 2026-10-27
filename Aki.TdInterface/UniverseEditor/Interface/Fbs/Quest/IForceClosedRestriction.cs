using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E6F RID: 15983
	public struct IForceClosedRestriction : IFlatbufferObject
	{
		// Token: 0x17006ED2 RID: 28370
		// (get) Token: 0x06016825 RID: 92197 RVA: 0x00340D90 File Offset: 0x0033EF90
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016826 RID: 92198 RVA: 0x00340D9D File Offset: 0x0033EF9D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016827 RID: 92199 RVA: 0x00340DA4 File Offset: 0x0033EFA4
		public static IForceClosedRestriction GetRootAsIForceClosedRestriction(ByteBuffer _bb)
		{
			return IForceClosedRestriction.GetRootAsIForceClosedRestriction(_bb, default(IForceClosedRestriction));
		}

		// Token: 0x06016828 RID: 92200 RVA: 0x00340DC0 File Offset: 0x0033EFC0
		public static IForceClosedRestriction GetRootAsIForceClosedRestriction(ByteBuffer _bb, IForceClosedRestriction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016829 RID: 92201 RVA: 0x00340DDD File Offset: 0x0033EFDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601682A RID: 92202 RVA: 0x00340DEC File Offset: 0x0033EFEC
		public IForceClosedRestriction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006ED3 RID: 28371
		// (get) Token: 0x0601682B RID: 92203 RVA: 0x00340DFC File Offset: 0x0033EFFC
		public IVectorInfo? RangeCenter
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006ED4 RID: 28372
		// (get) Token: 0x0601682C RID: 92204 RVA: 0x00340E5C File Offset: 0x0033F05C
		public int RangeRadius
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

		// Token: 0x0601682D RID: 92205 RVA: 0x00340E98 File Offset: 0x0033F098
		public int RangeEntities(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006ED5 RID: 28373
		// (get) Token: 0x0601682E RID: 92206 RVA: 0x00340ED8 File Offset: 0x0033F0D8
		public int RangeEntitiesLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601682F RID: 92207 RVA: 0x00340F03 File Offset: 0x0033F103
		public Span<int> GetRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06016830 RID: 92208 RVA: 0x00340F12 File Offset: 0x0033F112
		public int[] GetRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x17006ED6 RID: 28374
		// (get) Token: 0x06016831 RID: 92209 RVA: 0x00340F20 File Offset: 0x0033F120
		public Aki.UniverseEditor.Interface.Fbs.Action.IPosA? FailedReturnPos
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new Aki.UniverseEditor.Interface.Fbs.Action.IPosA?(default(Aki.UniverseEditor.Interface.Fbs.Action.IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006ED7 RID: 28375
		// (get) Token: 0x06016832 RID: 92210 RVA: 0x00340F80 File Offset: 0x0033F180
		public int FailedReturnPosEntityId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006ED8 RID: 28376
		// (get) Token: 0x06016833 RID: 92211 RVA: 0x00340FC0 File Offset: 0x0033F1C0
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

		// Token: 0x06016834 RID: 92212 RVA: 0x00340FFD File Offset: 0x0033F1FD
		public static Offset<IForceClosedRestriction> CreateIForceClosedRestriction(FlatBufferBuilder builder, Offset<IVectorInfo> RangeCenterOffset = default(Offset<IVectorInfo>), int RangeRadius = 0, VectorOffset RangeEntitiesOffset = default(VectorOffset), Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA> FailedReturnPosOffset = default(Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA>), int FailedReturnPosEntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(6);
			IForceClosedRestriction.AddFailedReturnPosEntityId(builder, FailedReturnPosEntityId);
			IForceClosedRestriction.AddFailedReturnPos(builder, FailedReturnPosOffset);
			IForceClosedRestriction.AddRangeEntities(builder, RangeEntitiesOffset);
			IForceClosedRestriction.AddRangeRadius(builder, RangeRadius);
			IForceClosedRestriction.AddRangeCenter(builder, RangeCenterOffset);
			IForceClosedRestriction.AddNullMask(builder, NullMask);
			return IForceClosedRestriction.EndIForceClosedRestriction(builder);
		}

		// Token: 0x06016835 RID: 92213 RVA: 0x00341039 File Offset: 0x0033F239
		public static void StartIForceClosedRestriction(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06016836 RID: 92214 RVA: 0x00341042 File Offset: 0x0033F242
		public static void AddRangeCenter(FlatBufferBuilder builder, Offset<IVectorInfo> rangeCenterOffset)
		{
			builder.AddOffset(0, rangeCenterOffset.Value, 0);
		}

		// Token: 0x06016837 RID: 92215 RVA: 0x00341052 File Offset: 0x0033F252
		public static void AddRangeRadius(FlatBufferBuilder builder, int rangeRadius)
		{
			builder.AddInt(1, rangeRadius, 0);
		}

		// Token: 0x06016838 RID: 92216 RVA: 0x0034105D File Offset: 0x0033F25D
		public static void AddRangeEntities(FlatBufferBuilder builder, VectorOffset rangeEntitiesOffset)
		{
			builder.AddOffset(2, rangeEntitiesOffset.Value, 0);
		}

		// Token: 0x06016839 RID: 92217 RVA: 0x00341070 File Offset: 0x0033F270
		public static VectorOffset CreateRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601683A RID: 92218 RVA: 0x003410A7 File Offset: 0x0033F2A7
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601683B RID: 92219 RVA: 0x003410C1 File Offset: 0x0033F2C1
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601683C RID: 92220 RVA: 0x003410DF File Offset: 0x0033F2DF
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601683D RID: 92221 RVA: 0x003410F8 File Offset: 0x0033F2F8
		public static void StartRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601683E RID: 92222 RVA: 0x00341103 File Offset: 0x0033F303
		public static void AddFailedReturnPos(FlatBufferBuilder builder, Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA> failedReturnPosOffset)
		{
			builder.AddOffset(3, failedReturnPosOffset.Value, 0);
		}

		// Token: 0x0601683F RID: 92223 RVA: 0x00341113 File Offset: 0x0033F313
		public static void AddFailedReturnPosEntityId(FlatBufferBuilder builder, int failedReturnPosEntityId)
		{
			builder.AddInt(4, failedReturnPosEntityId, 0);
		}

		// Token: 0x06016840 RID: 92224 RVA: 0x0034111E File Offset: 0x0033F31E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06016841 RID: 92225 RVA: 0x00341129 File Offset: 0x0033F329
		public static Offset<IForceClosedRestriction> EndIForceClosedRestriction(FlatBufferBuilder builder)
		{
			return new Offset<IForceClosedRestriction>(builder.EndTable());
		}

		// Token: 0x06016842 RID: 92226 RVA: 0x00341138 File Offset: 0x0033F338
		public IForceClosedRestrictionT UnPack()
		{
			IForceClosedRestrictionT forceClosedRestrictionT = new IForceClosedRestrictionT();
			this.UnPackTo(forceClosedRestrictionT);
			return forceClosedRestrictionT;
		}

		// Token: 0x06016843 RID: 92227 RVA: 0x00341154 File Offset: 0x0033F354
		public void UnPackTo(IForceClosedRestrictionT _o)
		{
			_o.RangeCenter = ((this.RangeCenter != null) ? this.RangeCenter.Value.UnPack() : null);
			_o.RangeRadius = this.RangeRadius;
			_o.RangeEntities = new List<int>();
			for (int i = 0; i < this.RangeEntitiesLength; i++)
			{
				_o.RangeEntities.Add(this.RangeEntities(i));
			}
			_o.FailedReturnPos = ((this.FailedReturnPos != null) ? this.FailedReturnPos.Value.UnPack() : null);
			_o.FailedReturnPosEntityId = this.FailedReturnPosEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016844 RID: 92228 RVA: 0x00341214 File Offset: 0x0033F414
		public static Offset<IForceClosedRestriction> Pack(FlatBufferBuilder builder, IForceClosedRestrictionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IForceClosedRestriction>);
			}
			Offset<IVectorInfo> rangeCenterOffset = (_o.RangeCenter == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.RangeCenter);
			VectorOffset rangeEntitiesOffset = default(VectorOffset);
			if (_o.RangeEntities != null)
			{
				int[] data = _o.RangeEntities.ToArray();
				rangeEntitiesOffset = IForceClosedRestriction.CreateRangeEntitiesVector(builder, data);
			}
			Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA> failedReturnPosOffset = (_o.FailedReturnPos == null) ? default(Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA>) : Aki.UniverseEditor.Interface.Fbs.Action.IPosA.Pack(builder, _o.FailedReturnPos);
			return IForceClosedRestriction.CreateIForceClosedRestriction(builder, rangeCenterOffset, _o.RangeRadius, rangeEntitiesOffset, failedReturnPosOffset, _o.FailedReturnPosEntityId, _o.NullMask);
		}

		// Token: 0x0400B823 RID: 47139
		private Table __p;
	}
}
