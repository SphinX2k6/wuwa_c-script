using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054B7 RID: 21687
	public struct IChargeSlashControl : IFlatbufferObject
	{
		// Token: 0x17009AA6 RID: 39590
		// (get) Token: 0x0602229F RID: 139935 RVA: 0x004B5847 File Offset: 0x004B3A47
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060222A0 RID: 139936 RVA: 0x004B5854 File Offset: 0x004B3A54
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060222A1 RID: 139937 RVA: 0x004B585C File Offset: 0x004B3A5C
		public static IChargeSlashControl GetRootAsIChargeSlashControl(ByteBuffer _bb)
		{
			return IChargeSlashControl.GetRootAsIChargeSlashControl(_bb, default(IChargeSlashControl));
		}

		// Token: 0x060222A2 RID: 139938 RVA: 0x004B5878 File Offset: 0x004B3A78
		public static IChargeSlashControl GetRootAsIChargeSlashControl(ByteBuffer _bb, IChargeSlashControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060222A3 RID: 139939 RVA: 0x004B5895 File Offset: 0x004B3A95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060222A4 RID: 139940 RVA: 0x004B58A4 File Offset: 0x004B3AA4
		public IChargeSlashControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009AA7 RID: 39591
		// (get) Token: 0x060222A5 RID: 139941 RVA: 0x004B58B4 File Offset: 0x004B3AB4
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

		// Token: 0x17009AA8 RID: 39592
		// (get) Token: 0x060222A6 RID: 139942 RVA: 0x004B58F0 File Offset: 0x004B3AF0
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

		// Token: 0x17009AA9 RID: 39593
		// (get) Token: 0x060222A7 RID: 139943 RVA: 0x004B592C File Offset: 0x004B3B2C
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

		// Token: 0x060222A8 RID: 139944 RVA: 0x004B5963 File Offset: 0x004B3B63
		public Span<byte> GetUpCurvePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060222A9 RID: 139945 RVA: 0x004B5972 File Offset: 0x004B3B72
		public byte[] GetUpCurvePathArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060222AA RID: 139946 RVA: 0x004B5980 File Offset: 0x004B3B80
		public static Offset<IChargeSlashControl> CreateIChargeSlashControl(FlatBufferBuilder builder, ECurveControlType Type = ECurveControlType.ChargeSlash, int UpHeight = 0, StringOffset UpCurvePathOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IChargeSlashControl.AddUpCurvePath(builder, UpCurvePathOffset);
			IChargeSlashControl.AddUpHeight(builder, UpHeight);
			IChargeSlashControl.AddType(builder, Type);
			return IChargeSlashControl.EndIChargeSlashControl(builder);
		}

		// Token: 0x060222AB RID: 139947 RVA: 0x004B59A4 File Offset: 0x004B3BA4
		public static void StartIChargeSlashControl(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060222AC RID: 139948 RVA: 0x004B59AD File Offset: 0x004B3BAD
		public static void AddType(FlatBufferBuilder builder, ECurveControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060222AD RID: 139949 RVA: 0x004B59B8 File Offset: 0x004B3BB8
		public static void AddUpHeight(FlatBufferBuilder builder, int upHeight)
		{
			builder.AddInt(1, upHeight, 0);
		}

		// Token: 0x060222AE RID: 139950 RVA: 0x004B59C3 File Offset: 0x004B3BC3
		public static void AddUpCurvePath(FlatBufferBuilder builder, StringOffset upCurvePathOffset)
		{
			builder.AddOffset(2, upCurvePathOffset.Value, 0);
		}

		// Token: 0x060222AF RID: 139951 RVA: 0x004B59D3 File Offset: 0x004B3BD3
		public static Offset<IChargeSlashControl> EndIChargeSlashControl(FlatBufferBuilder builder)
		{
			return new Offset<IChargeSlashControl>(builder.EndTable());
		}

		// Token: 0x060222B0 RID: 139952 RVA: 0x004B59E0 File Offset: 0x004B3BE0
		public IChargeSlashControlT UnPack()
		{
			IChargeSlashControlT chargeSlashControlT = new IChargeSlashControlT();
			this.UnPackTo(chargeSlashControlT);
			return chargeSlashControlT;
		}

		// Token: 0x060222B1 RID: 139953 RVA: 0x004B59FB File Offset: 0x004B3BFB
		public void UnPackTo(IChargeSlashControlT _o)
		{
			_o.Type = this.Type;
			_o.UpHeight = this.UpHeight;
			_o.UpCurvePath = this.UpCurvePath;
		}

		// Token: 0x060222B2 RID: 139954 RVA: 0x004B5A24 File Offset: 0x004B3C24
		public static Offset<IChargeSlashControl> Pack(FlatBufferBuilder builder, IChargeSlashControlT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChargeSlashControl>);
			}
			StringOffset upCurvePathOffset = (_o.UpCurvePath == null) ? default(StringOffset) : builder.CreateString(_o.UpCurvePath);
			return IChargeSlashControl.CreateIChargeSlashControl(builder, _o.Type, _o.UpHeight, upCurvePathOffset);
		}

		// Token: 0x0400E9E3 RID: 59875
		private Table __p;
	}
}
