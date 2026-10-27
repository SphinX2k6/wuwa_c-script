using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BAA RID: 23466
	public struct IWuWaGoGear : IFlatbufferObject
	{
		// Token: 0x1700B14E RID: 45390
		// (get) Token: 0x060282E9 RID: 164585 RVA: 0x005859C8 File Offset: 0x00583BC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060282EA RID: 164586 RVA: 0x005859D5 File Offset: 0x00583BD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060282EB RID: 164587 RVA: 0x005859DC File Offset: 0x00583BDC
		public static IWuWaGoGear GetRootAsIWuWaGoGear(ByteBuffer _bb)
		{
			return IWuWaGoGear.GetRootAsIWuWaGoGear(_bb, default(IWuWaGoGear));
		}

		// Token: 0x060282EC RID: 164588 RVA: 0x005859F8 File Offset: 0x00583BF8
		public static IWuWaGoGear GetRootAsIWuWaGoGear(ByteBuffer _bb, IWuWaGoGear obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060282ED RID: 164589 RVA: 0x00585A15 File Offset: 0x00583C15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060282EE RID: 164590 RVA: 0x00585A24 File Offset: 0x00583C24
		public IWuWaGoGear __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B14F RID: 45391
		// (get) Token: 0x060282EF RID: 164591 RVA: 0x00585A34 File Offset: 0x00583C34
		public EWuWaGoEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWuWaGoEntityType.LevelCenter;
				}
				return (EWuWaGoEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060282F0 RID: 164592 RVA: 0x00585A70 File Offset: 0x00583C70
		public int GridEntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B150 RID: 45392
		// (get) Token: 0x060282F1 RID: 164593 RVA: 0x00585AB0 File Offset: 0x00583CB0
		public int GridEntityIdsLength
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

		// Token: 0x060282F2 RID: 164594 RVA: 0x00585ADB File Offset: 0x00583CDB
		public Span<int> GetGridEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060282F3 RID: 164595 RVA: 0x00585AEA File Offset: 0x00583CEA
		public int[] GetGridEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x060282F4 RID: 164596 RVA: 0x00585AF8 File Offset: 0x00583CF8
		public static Offset<IWuWaGoGear> CreateIWuWaGoGear(FlatBufferBuilder builder, EWuWaGoEntityType Type = EWuWaGoEntityType.LevelCenter, VectorOffset GridEntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IWuWaGoGear.AddGridEntityIds(builder, GridEntityIdsOffset);
			IWuWaGoGear.AddType(builder, Type);
			return IWuWaGoGear.EndIWuWaGoGear(builder);
		}

		// Token: 0x060282F5 RID: 164597 RVA: 0x00585B15 File Offset: 0x00583D15
		public static void StartIWuWaGoGear(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060282F6 RID: 164598 RVA: 0x00585B1E File Offset: 0x00583D1E
		public static void AddType(FlatBufferBuilder builder, EWuWaGoEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060282F7 RID: 164599 RVA: 0x00585B29 File Offset: 0x00583D29
		public static void AddGridEntityIds(FlatBufferBuilder builder, VectorOffset gridEntityIdsOffset)
		{
			builder.AddOffset(1, gridEntityIdsOffset.Value, 0);
		}

		// Token: 0x060282F8 RID: 164600 RVA: 0x00585B3C File Offset: 0x00583D3C
		public static VectorOffset CreateGridEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060282F9 RID: 164601 RVA: 0x00585B73 File Offset: 0x00583D73
		public static VectorOffset CreateGridEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060282FA RID: 164602 RVA: 0x00585B8D File Offset: 0x00583D8D
		public static VectorOffset CreateGridEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060282FB RID: 164603 RVA: 0x00585BAB File Offset: 0x00583DAB
		public static VectorOffset CreateGridEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060282FC RID: 164604 RVA: 0x00585BC4 File Offset: 0x00583DC4
		public static void StartGridEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060282FD RID: 164605 RVA: 0x00585BCF File Offset: 0x00583DCF
		public static Offset<IWuWaGoGear> EndIWuWaGoGear(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoGear>(builder.EndTable());
		}

		// Token: 0x060282FE RID: 164606 RVA: 0x00585BDC File Offset: 0x00583DDC
		public IWuWaGoGearT UnPack()
		{
			IWuWaGoGearT wuWaGoGearT = new IWuWaGoGearT();
			this.UnPackTo(wuWaGoGearT);
			return wuWaGoGearT;
		}

		// Token: 0x060282FF RID: 164607 RVA: 0x00585BF8 File Offset: 0x00583DF8
		public void UnPackTo(IWuWaGoGearT _o)
		{
			_o.Type = this.Type;
			_o.GridEntityIds = new List<int>();
			for (int i = 0; i < this.GridEntityIdsLength; i++)
			{
				_o.GridEntityIds.Add(this.GridEntityIds(i));
			}
		}

		// Token: 0x06028300 RID: 164608 RVA: 0x00585C40 File Offset: 0x00583E40
		public static Offset<IWuWaGoGear> Pack(FlatBufferBuilder builder, IWuWaGoGearT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoGear>);
			}
			VectorOffset gridEntityIdsOffset = default(VectorOffset);
			if (_o.GridEntityIds != null)
			{
				int[] data = _o.GridEntityIds.ToArray();
				gridEntityIdsOffset = IWuWaGoGear.CreateGridEntityIdsVector(builder, data);
			}
			return IWuWaGoGear.CreateIWuWaGoGear(builder, _o.Type, gridEntityIdsOffset);
		}

		// Token: 0x0400F31C RID: 62236
		private Table __p;
	}
}
