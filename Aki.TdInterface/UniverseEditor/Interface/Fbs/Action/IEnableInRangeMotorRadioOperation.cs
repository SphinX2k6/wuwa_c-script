using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CDD RID: 27869
	public struct IEnableInRangeMotorRadioOperation : IFlatbufferObject
	{
		// Token: 0x1700CC65 RID: 52325
		// (get) Token: 0x0603009A RID: 196762 RVA: 0x006893E3 File Offset: 0x006875E3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603009B RID: 196763 RVA: 0x006893F0 File Offset: 0x006875F0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603009C RID: 196764 RVA: 0x006893F8 File Offset: 0x006875F8
		public static IEnableInRangeMotorRadioOperation GetRootAsIEnableInRangeMotorRadioOperation(ByteBuffer _bb)
		{
			return IEnableInRangeMotorRadioOperation.GetRootAsIEnableInRangeMotorRadioOperation(_bb, default(IEnableInRangeMotorRadioOperation));
		}

		// Token: 0x0603009D RID: 196765 RVA: 0x00689414 File Offset: 0x00687614
		public static IEnableInRangeMotorRadioOperation GetRootAsIEnableInRangeMotorRadioOperation(ByteBuffer _bb, IEnableInRangeMotorRadioOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603009E RID: 196766 RVA: 0x00689431 File Offset: 0x00687631
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603009F RID: 196767 RVA: 0x00689440 File Offset: 0x00687640
		public IEnableInRangeMotorRadioOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC66 RID: 52326
		// (get) Token: 0x060300A0 RID: 196768 RVA: 0x00689450 File Offset: 0x00687650
		public EMotorRadioOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorRadioOperationType.EnableAll;
				}
				return (EMotorRadioOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CC67 RID: 52327
		// (get) Token: 0x060300A1 RID: 196769 RVA: 0x0068948C File Offset: 0x0068768C
		public string RangeKey
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

		// Token: 0x060300A2 RID: 196770 RVA: 0x006894C3 File Offset: 0x006876C3
		public Span<byte> GetRangeKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060300A3 RID: 196771 RVA: 0x006894D2 File Offset: 0x006876D2
		public byte[] GetRangeKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060300A4 RID: 196772 RVA: 0x006894E0 File Offset: 0x006876E0
		public static Offset<IEnableInRangeMotorRadioOperation> CreateIEnableInRangeMotorRadioOperation(FlatBufferBuilder builder, EMotorRadioOperationType Type = EMotorRadioOperationType.EnableAll, StringOffset RangeKeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IEnableInRangeMotorRadioOperation.AddRangeKey(builder, RangeKeyOffset);
			IEnableInRangeMotorRadioOperation.AddType(builder, Type);
			return IEnableInRangeMotorRadioOperation.EndIEnableInRangeMotorRadioOperation(builder);
		}

		// Token: 0x060300A5 RID: 196773 RVA: 0x006894FD File Offset: 0x006876FD
		public static void StartIEnableInRangeMotorRadioOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060300A6 RID: 196774 RVA: 0x00689506 File Offset: 0x00687706
		public static void AddType(FlatBufferBuilder builder, EMotorRadioOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060300A7 RID: 196775 RVA: 0x00689511 File Offset: 0x00687711
		public static void AddRangeKey(FlatBufferBuilder builder, StringOffset rangeKeyOffset)
		{
			builder.AddOffset(1, rangeKeyOffset.Value, 0);
		}

		// Token: 0x060300A8 RID: 196776 RVA: 0x00689521 File Offset: 0x00687721
		public static Offset<IEnableInRangeMotorRadioOperation> EndIEnableInRangeMotorRadioOperation(FlatBufferBuilder builder)
		{
			return new Offset<IEnableInRangeMotorRadioOperation>(builder.EndTable());
		}

		// Token: 0x060300A9 RID: 196777 RVA: 0x00689530 File Offset: 0x00687730
		public IEnableInRangeMotorRadioOperationT UnPack()
		{
			IEnableInRangeMotorRadioOperationT enableInRangeMotorRadioOperationT = new IEnableInRangeMotorRadioOperationT();
			this.UnPackTo(enableInRangeMotorRadioOperationT);
			return enableInRangeMotorRadioOperationT;
		}

		// Token: 0x060300AA RID: 196778 RVA: 0x0068954B File Offset: 0x0068774B
		public void UnPackTo(IEnableInRangeMotorRadioOperationT _o)
		{
			_o.Type = this.Type;
			_o.RangeKey = this.RangeKey;
		}

		// Token: 0x060300AB RID: 196779 RVA: 0x00689568 File Offset: 0x00687768
		public static Offset<IEnableInRangeMotorRadioOperation> Pack(FlatBufferBuilder builder, IEnableInRangeMotorRadioOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableInRangeMotorRadioOperation>);
			}
			StringOffset rangeKeyOffset = (_o.RangeKey == null) ? default(StringOffset) : builder.CreateString(_o.RangeKey);
			return IEnableInRangeMotorRadioOperation.CreateIEnableInRangeMotorRadioOperation(builder, _o.Type, rangeKeyOffset);
		}

		// Token: 0x04011B2E RID: 72494
		private Table __p;
	}
}
