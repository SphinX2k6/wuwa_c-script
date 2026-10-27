using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F88 RID: 20360
	public struct IChargeSlashControl : IFlatbufferObject
	{
		// Token: 0x1700932D RID: 37677
		// (get) Token: 0x0602054D RID: 132429 RVA: 0x0047F857 File Offset: 0x0047DA57
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602054E RID: 132430 RVA: 0x0047F864 File Offset: 0x0047DA64
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602054F RID: 132431 RVA: 0x0047F86C File Offset: 0x0047DA6C
		public static IChargeSlashControl GetRootAsIChargeSlashControl(ByteBuffer _bb)
		{
			return IChargeSlashControl.GetRootAsIChargeSlashControl(_bb, default(IChargeSlashControl));
		}

		// Token: 0x06020550 RID: 132432 RVA: 0x0047F888 File Offset: 0x0047DA88
		public static IChargeSlashControl GetRootAsIChargeSlashControl(ByteBuffer _bb, IChargeSlashControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020551 RID: 132433 RVA: 0x0047F8A5 File Offset: 0x0047DAA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020552 RID: 132434 RVA: 0x0047F8B4 File Offset: 0x0047DAB4
		public IChargeSlashControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700932E RID: 37678
		// (get) Token: 0x06020553 RID: 132435 RVA: 0x0047F8C4 File Offset: 0x0047DAC4
		public ECurveControlType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECurveControlType.ChargeSlash;
				}
				return (ECurveControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700932F RID: 37679
		// (get) Token: 0x06020554 RID: 132436 RVA: 0x0047F900 File Offset: 0x0047DB00
		public int UpHeight
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

		// Token: 0x17009330 RID: 37680
		// (get) Token: 0x06020555 RID: 132437 RVA: 0x0047F93C File Offset: 0x0047DB3C
		public string UpCurvePath
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020556 RID: 132438 RVA: 0x0047F973 File Offset: 0x0047DB73
		public Span<byte> GetUpCurvePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06020557 RID: 132439 RVA: 0x0047F982 File Offset: 0x0047DB82
		public byte[] GetUpCurvePathArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06020558 RID: 132440 RVA: 0x0047F990 File Offset: 0x0047DB90
		public static Offset<IChargeSlashControl> CreateIChargeSlashControl(FlatBufferBuilder builder, ECurveControlType Type = ECurveControlType.ChargeSlash, int UpHeight = 0, StringOffset UpCurvePathOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IChargeSlashControl.AddUpCurvePath(builder, UpCurvePathOffset);
			IChargeSlashControl.AddUpHeight(builder, UpHeight);
			IChargeSlashControl.AddType(builder, Type);
			return IChargeSlashControl.EndIChargeSlashControl(builder);
		}

		// Token: 0x06020559 RID: 132441 RVA: 0x0047F9B4 File Offset: 0x0047DBB4
		public static void StartIChargeSlashControl(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602055A RID: 132442 RVA: 0x0047F9BD File Offset: 0x0047DBBD
		public static void AddType(FlatBufferBuilder builder, ECurveControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602055B RID: 132443 RVA: 0x0047F9C8 File Offset: 0x0047DBC8
		public static void AddUpHeight(FlatBufferBuilder builder, int upHeight)
		{
			builder.AddInt(1, upHeight, 0);
		}

		// Token: 0x0602055C RID: 132444 RVA: 0x0047F9D3 File Offset: 0x0047DBD3
		public static void AddUpCurvePath(FlatBufferBuilder builder, StringOffset upCurvePathOffset)
		{
			builder.AddOffset(2, upCurvePathOffset.Value, 0);
		}

		// Token: 0x0602055D RID: 132445 RVA: 0x0047F9E3 File Offset: 0x0047DBE3
		public static Offset<IChargeSlashControl> EndIChargeSlashControl(FlatBufferBuilder builder)
		{
			return new Offset<IChargeSlashControl>(builder.EndTable());
		}

		// Token: 0x0602055E RID: 132446 RVA: 0x0047F9F0 File Offset: 0x0047DBF0
		public IChargeSlashControlT UnPack()
		{
			IChargeSlashControlT chargeSlashControlT = new IChargeSlashControlT();
			this.UnPackTo(chargeSlashControlT);
			return chargeSlashControlT;
		}

		// Token: 0x0602055F RID: 132447 RVA: 0x0047FA0B File Offset: 0x0047DC0B
		public void UnPackTo(IChargeSlashControlT _o)
		{
			_o.Type = this.Type;
			_o.UpHeight = this.UpHeight;
			_o.UpCurvePath = this.UpCurvePath;
		}

		// Token: 0x06020560 RID: 132448 RVA: 0x0047FA34 File Offset: 0x0047DC34
		public static Offset<IChargeSlashControl> Pack(FlatBufferBuilder builder, IChargeSlashControlT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChargeSlashControl>);
			}
			StringOffset upCurvePathOffset = (_o.UpCurvePath == null) ? default(StringOffset) : builder.CreateString(_o.UpCurvePath);
			return IChargeSlashControl.CreateIChargeSlashControl(builder, _o.Type, _o.UpHeight, upCurvePathOffset);
		}

		// Token: 0x0400DE39 RID: 56889
		private Table __p;
	}
}
