using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EF8 RID: 20216
	public struct IBatchBulletCasterComponent : IFlatbufferObject
	{
		// Token: 0x17009170 RID: 37232
		// (get) Token: 0x0601FED0 RID: 130768 RVA: 0x004717FF File Offset: 0x0046F9FF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FED1 RID: 130769 RVA: 0x0047180C File Offset: 0x0046FA0C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FED2 RID: 130770 RVA: 0x00471814 File Offset: 0x0046FA14
		public static IBatchBulletCasterComponent GetRootAsIBatchBulletCasterComponent(ByteBuffer _bb)
		{
			return IBatchBulletCasterComponent.GetRootAsIBatchBulletCasterComponent(_bb, default(IBatchBulletCasterComponent));
		}

		// Token: 0x0601FED3 RID: 130771 RVA: 0x00471830 File Offset: 0x0046FA30
		public static IBatchBulletCasterComponent GetRootAsIBatchBulletCasterComponent(ByteBuffer _bb, IBatchBulletCasterComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FED4 RID: 130772 RVA: 0x0047184D File Offset: 0x0046FA4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FED5 RID: 130773 RVA: 0x0047185C File Offset: 0x0046FA5C
		public IBatchBulletCasterComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009171 RID: 37233
		// (get) Token: 0x0601FED6 RID: 130774 RVA: 0x0047186C File Offset: 0x0046FA6C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009172 RID: 37234
		// (get) Token: 0x0601FED7 RID: 130775 RVA: 0x004718AC File Offset: 0x0046FAAC
		public string WarningEffect
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FED8 RID: 130776 RVA: 0x004718E3 File Offset: 0x0046FAE3
		public Span<byte> GetWarningEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601FED9 RID: 130777 RVA: 0x004718F2 File Offset: 0x0046FAF2
		public byte[] GetWarningEffectArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009173 RID: 37235
		// (get) Token: 0x0601FEDA RID: 130778 RVA: 0x00471900 File Offset: 0x0046FB00
		public EBatchBulletMovementType MovementType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EBatchBulletMovementType.Sprint;
				}
				return (EBatchBulletMovementType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FEDB RID: 130779 RVA: 0x0047193C File Offset: 0x0046FB3C
		public IPosRot? BulletList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IPosRot?(default(IPosRot).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009174 RID: 37236
		// (get) Token: 0x0601FEDC RID: 130780 RVA: 0x004719A0 File Offset: 0x0046FBA0
		public int BulletListLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601FEDD RID: 130781 RVA: 0x004719CC File Offset: 0x0046FBCC
		public IBatchBulletItem? BatchList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IBatchBulletItem?(default(IBatchBulletItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009175 RID: 37237
		// (get) Token: 0x0601FEDE RID: 130782 RVA: 0x00471A30 File Offset: 0x0046FC30
		public int BatchListLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009176 RID: 37238
		// (get) Token: 0x0601FEDF RID: 130783 RVA: 0x00471A5C File Offset: 0x0046FC5C
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

		// Token: 0x0601FEE0 RID: 130784 RVA: 0x00471A99 File Offset: 0x0046FC99
		public static Offset<IBatchBulletCasterComponent> CreateIBatchBulletCasterComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset WarningEffectOffset = default(StringOffset), EBatchBulletMovementType MovementType = EBatchBulletMovementType.Sprint, VectorOffset BulletListOffset = default(VectorOffset), VectorOffset BatchListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IBatchBulletCasterComponent.AddBatchList(builder, BatchListOffset);
			IBatchBulletCasterComponent.AddBulletList(builder, BulletListOffset);
			IBatchBulletCasterComponent.AddWarningEffect(builder, WarningEffectOffset);
			IBatchBulletCasterComponent.AddNullMask(builder, NullMask);
			IBatchBulletCasterComponent.AddMovementType(builder, MovementType);
			IBatchBulletCasterComponent.AddDisabled(builder, Disabled);
			return IBatchBulletCasterComponent.EndIBatchBulletCasterComponent(builder);
		}

		// Token: 0x0601FEE1 RID: 130785 RVA: 0x00471AD5 File Offset: 0x0046FCD5
		public static void StartIBatchBulletCasterComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601FEE2 RID: 130786 RVA: 0x00471ADE File Offset: 0x0046FCDE
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0601FEE3 RID: 130787 RVA: 0x00471AE9 File Offset: 0x0046FCE9
		public static void AddWarningEffect(FlatBufferBuilder builder, StringOffset warningEffectOffset)
		{
			builder.AddOffset(1, warningEffectOffset.Value, 0);
		}

		// Token: 0x0601FEE4 RID: 130788 RVA: 0x00471AF9 File Offset: 0x0046FCF9
		public static void AddMovementType(FlatBufferBuilder builder, EBatchBulletMovementType movementType)
		{
			builder.AddByte(2, (byte)movementType, 0);
		}

		// Token: 0x0601FEE5 RID: 130789 RVA: 0x00471B04 File Offset: 0x0046FD04
		public static void AddBulletList(FlatBufferBuilder builder, VectorOffset bulletListOffset)
		{
			builder.AddOffset(3, bulletListOffset.Value, 0);
		}

		// Token: 0x0601FEE6 RID: 130790 RVA: 0x00471B14 File Offset: 0x0046FD14
		public static VectorOffset CreateBulletListVector(FlatBufferBuilder builder, Offset<IPosRot>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FEE7 RID: 130791 RVA: 0x00471B54 File Offset: 0x0046FD54
		public static VectorOffset CreateBulletListVectorBlock(FlatBufferBuilder builder, Offset<IPosRot>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPosRot>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FEE8 RID: 130792 RVA: 0x00471B6E File Offset: 0x0046FD6E
		public static VectorOffset CreateBulletListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPosRot>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPosRot>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FEE9 RID: 130793 RVA: 0x00471B8C File Offset: 0x0046FD8C
		public static VectorOffset CreateBulletListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPosRot>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FEEA RID: 130794 RVA: 0x00471BA5 File Offset: 0x0046FDA5
		public static void StartBulletListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601FEEB RID: 130795 RVA: 0x00471BB0 File Offset: 0x0046FDB0
		public static void AddBatchList(FlatBufferBuilder builder, VectorOffset batchListOffset)
		{
			builder.AddOffset(4, batchListOffset.Value, 0);
		}

		// Token: 0x0601FEEC RID: 130796 RVA: 0x00471BC0 File Offset: 0x0046FDC0
		public static VectorOffset CreateBatchListVector(FlatBufferBuilder builder, Offset<IBatchBulletItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FEED RID: 130797 RVA: 0x00471C00 File Offset: 0x0046FE00
		public static VectorOffset CreateBatchListVectorBlock(FlatBufferBuilder builder, Offset<IBatchBulletItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IBatchBulletItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FEEE RID: 130798 RVA: 0x00471C1A File Offset: 0x0046FE1A
		public static VectorOffset CreateBatchListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IBatchBulletItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IBatchBulletItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FEEF RID: 130799 RVA: 0x00471C38 File Offset: 0x0046FE38
		public static VectorOffset CreateBatchListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IBatchBulletItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FEF0 RID: 130800 RVA: 0x00471C51 File Offset: 0x0046FE51
		public static void StartBatchListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601FEF1 RID: 130801 RVA: 0x00471C5C File Offset: 0x0046FE5C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601FEF2 RID: 130802 RVA: 0x00471C67 File Offset: 0x0046FE67
		public static Offset<IBatchBulletCasterComponent> EndIBatchBulletCasterComponent(FlatBufferBuilder builder)
		{
			return new Offset<IBatchBulletCasterComponent>(builder.EndTable());
		}

		// Token: 0x0601FEF3 RID: 130803 RVA: 0x00471C74 File Offset: 0x0046FE74
		public IBatchBulletCasterComponentT UnPack()
		{
			IBatchBulletCasterComponentT batchBulletCasterComponentT = new IBatchBulletCasterComponentT();
			this.UnPackTo(batchBulletCasterComponentT);
			return batchBulletCasterComponentT;
		}

		// Token: 0x0601FEF4 RID: 130804 RVA: 0x00471C90 File Offset: 0x0046FE90
		public void UnPackTo(IBatchBulletCasterComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.WarningEffect = this.WarningEffect;
			_o.MovementType = this.MovementType;
			_o.BulletList = new List<IPosRotT>();
			for (int i = 0; i < this.BulletListLength; i++)
			{
				_o.BulletList.Add((this.BulletList(i) != null) ? this.BulletList(i).Value.UnPack() : null);
			}
			_o.BatchList = new List<IBatchBulletItemT>();
			for (int j = 0; j < this.BatchListLength; j++)
			{
				_o.BatchList.Add((this.BatchList(j) != null) ? this.BatchList(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601FEF5 RID: 130805 RVA: 0x00471D74 File Offset: 0x0046FF74
		public static Offset<IBatchBulletCasterComponent> Pack(FlatBufferBuilder builder, IBatchBulletCasterComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBatchBulletCasterComponent>);
			}
			StringOffset warningEffectOffset = (_o.WarningEffect == null) ? default(StringOffset) : builder.CreateString(_o.WarningEffect);
			VectorOffset bulletListOffset = default(VectorOffset);
			if (_o.BulletList != null)
			{
				Offset<IPosRot>[] array = new Offset<IPosRot>[_o.BulletList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IPosRot.Pack(builder, _o.BulletList[i]);
				}
				bulletListOffset = IBatchBulletCasterComponent.CreateBulletListVector(builder, array);
			}
			VectorOffset batchListOffset = default(VectorOffset);
			if (_o.BatchList != null)
			{
				Offset<IBatchBulletItem>[] array2 = new Offset<IBatchBulletItem>[_o.BatchList.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IBatchBulletItem.Pack(builder, _o.BatchList[j]);
				}
				batchListOffset = IBatchBulletCasterComponent.CreateBatchListVector(builder, array2);
			}
			return IBatchBulletCasterComponent.CreateIBatchBulletCasterComponent(builder, _o.Disabled, warningEffectOffset, _o.MovementType, bulletListOffset, batchListOffset, _o.NullMask);
		}

		// Token: 0x0400DD2D RID: 56621
		private Table __p;
	}
}
