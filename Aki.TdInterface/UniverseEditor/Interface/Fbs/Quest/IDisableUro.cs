using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DD9 RID: 15833
	public struct IDisableUro : IFlatbufferObject
	{
		// Token: 0x17006D55 RID: 27989
		// (get) Token: 0x060161BF RID: 90559 RVA: 0x00332147 File Offset: 0x00330347
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060161C0 RID: 90560 RVA: 0x00332154 File Offset: 0x00330354
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060161C1 RID: 90561 RVA: 0x0033215C File Offset: 0x0033035C
		public static IDisableUro GetRootAsIDisableUro(ByteBuffer _bb)
		{
			return IDisableUro.GetRootAsIDisableUro(_bb, default(IDisableUro));
		}

		// Token: 0x060161C2 RID: 90562 RVA: 0x00332178 File Offset: 0x00330378
		public static IDisableUro GetRootAsIDisableUro(ByteBuffer _bb, IDisableUro obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060161C3 RID: 90563 RVA: 0x00332195 File Offset: 0x00330395
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060161C4 RID: 90564 RVA: 0x003321A4 File Offset: 0x003303A4
		public IDisableUro __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D56 RID: 27990
		// (get) Token: 0x060161C5 RID: 90565 RVA: 0x003321B4 File Offset: 0x003303B4
		public ELogicProgramSpecialProcess Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELogicProgramSpecialProcess.DisableURO;
				}
				return (ELogicProgramSpecialProcess)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060161C6 RID: 90566 RVA: 0x003321F0 File Offset: 0x003303F0
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006D57 RID: 27991
		// (get) Token: 0x060161C7 RID: 90567 RVA: 0x00332230 File Offset: 0x00330430
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

		// Token: 0x060161C8 RID: 90568 RVA: 0x0033225B File Offset: 0x0033045B
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060161C9 RID: 90569 RVA: 0x0033226A File Offset: 0x0033046A
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x060161CA RID: 90570 RVA: 0x00332278 File Offset: 0x00330478
		public static Offset<IDisableUro> CreateIDisableUro(FlatBufferBuilder builder, ELogicProgramSpecialProcess Type = ELogicProgramSpecialProcess.DisableURO, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IDisableUro.AddEntityIds(builder, EntityIdsOffset);
			IDisableUro.AddType(builder, Type);
			return IDisableUro.EndIDisableUro(builder);
		}

		// Token: 0x060161CB RID: 90571 RVA: 0x00332295 File Offset: 0x00330495
		public static void StartIDisableUro(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060161CC RID: 90572 RVA: 0x0033229E File Offset: 0x0033049E
		public static void AddType(FlatBufferBuilder builder, ELogicProgramSpecialProcess type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060161CD RID: 90573 RVA: 0x003322A9 File Offset: 0x003304A9
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x060161CE RID: 90574 RVA: 0x003322BC File Offset: 0x003304BC
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060161CF RID: 90575 RVA: 0x003322F3 File Offset: 0x003304F3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060161D0 RID: 90576 RVA: 0x0033230D File Offset: 0x0033050D
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060161D1 RID: 90577 RVA: 0x0033232B File Offset: 0x0033052B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060161D2 RID: 90578 RVA: 0x00332344 File Offset: 0x00330544
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060161D3 RID: 90579 RVA: 0x0033234F File Offset: 0x0033054F
		public static Offset<IDisableUro> EndIDisableUro(FlatBufferBuilder builder)
		{
			return new Offset<IDisableUro>(builder.EndTable());
		}

		// Token: 0x060161D4 RID: 90580 RVA: 0x0033235C File Offset: 0x0033055C
		public IDisableUroT UnPack()
		{
			IDisableUroT disableUroT = new IDisableUroT();
			this.UnPackTo(disableUroT);
			return disableUroT;
		}

		// Token: 0x060161D5 RID: 90581 RVA: 0x00332378 File Offset: 0x00330578
		public void UnPackTo(IDisableUroT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x060161D6 RID: 90582 RVA: 0x003323C0 File Offset: 0x003305C0
		public static Offset<IDisableUro> Pack(FlatBufferBuilder builder, IDisableUroT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableUro>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IDisableUro.CreateEntityIdsVector(builder, data);
			}
			return IDisableUro.CreateIDisableUro(builder, _o.Type, entityIdsOffset);
		}

		// Token: 0x0400B720 RID: 46880
		private Table __p;
	}
}
