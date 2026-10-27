using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BA6 RID: 27558
	public struct INightmareLordTip : IFlatbufferObject
	{
		// Token: 0x1700CCCF RID: 52431
		// (get) Token: 0x06030667 RID: 198247 RVA: 0x00692E44 File Offset: 0x00691044
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030668 RID: 198248 RVA: 0x00692E51 File Offset: 0x00691051
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030669 RID: 198249 RVA: 0x00692E58 File Offset: 0x00691058
		public static INightmareLordTip GetRootAsINightmareLordTip(ByteBuffer _bb)
		{
			return INightmareLordTip.GetRootAsINightmareLordTip(_bb, default(INightmareLordTip));
		}

		// Token: 0x0603066A RID: 198250 RVA: 0x00692E74 File Offset: 0x00691074
		public static INightmareLordTip GetRootAsINightmareLordTip(ByteBuffer _bb, INightmareLordTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603066B RID: 198251 RVA: 0x00692E91 File Offset: 0x00691091
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603066C RID: 198252 RVA: 0x00692EA0 File Offset: 0x006910A0
		public INightmareLordTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCD0 RID: 52432
		// (get) Token: 0x0603066D RID: 198253 RVA: 0x00692EB0 File Offset: 0x006910B0
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CCD1 RID: 52433
		// (get) Token: 0x0603066E RID: 198254 RVA: 0x00692EEC File Offset: 0x006910EC
		public string TidMainText
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

		// Token: 0x0603066F RID: 198255 RVA: 0x00692F23 File Offset: 0x00691123
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06030670 RID: 198256 RVA: 0x00692F32 File Offset: 0x00691132
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700CCD2 RID: 52434
		// (get) Token: 0x06030671 RID: 198257 RVA: 0x00692F40 File Offset: 0x00691140
		public string TidSubText
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

		// Token: 0x06030672 RID: 198258 RVA: 0x00692F77 File Offset: 0x00691177
		public Span<byte> GetTidSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06030673 RID: 198259 RVA: 0x00692F86 File Offset: 0x00691186
		public byte[] GetTidSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06030674 RID: 198260 RVA: 0x00692F94 File Offset: 0x00691194
		public static Offset<INightmareLordTip> CreateINightmareLordTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset), StringOffset TidSubTextOffset = default(StringOffset))
		{
			builder.StartTable(3);
			INightmareLordTip.AddTidSubText(builder, TidSubTextOffset);
			INightmareLordTip.AddTidMainText(builder, TidMainTextOffset);
			INightmareLordTip.AddType(builder, Type);
			return INightmareLordTip.EndINightmareLordTip(builder);
		}

		// Token: 0x06030675 RID: 198261 RVA: 0x00692FB8 File Offset: 0x006911B8
		public static void StartINightmareLordTip(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06030676 RID: 198262 RVA: 0x00692FC1 File Offset: 0x006911C1
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030677 RID: 198263 RVA: 0x00692FCC File Offset: 0x006911CC
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x06030678 RID: 198264 RVA: 0x00692FDC File Offset: 0x006911DC
		public static void AddTidSubText(FlatBufferBuilder builder, StringOffset tidSubTextOffset)
		{
			builder.AddOffset(2, tidSubTextOffset.Value, 0);
		}

		// Token: 0x06030679 RID: 198265 RVA: 0x00692FEC File Offset: 0x006911EC
		public static Offset<INightmareLordTip> EndINightmareLordTip(FlatBufferBuilder builder)
		{
			return new Offset<INightmareLordTip>(builder.EndTable());
		}

		// Token: 0x0603067A RID: 198266 RVA: 0x00692FFC File Offset: 0x006911FC
		public INightmareLordTipT UnPack()
		{
			INightmareLordTipT nightmareLordTipT = new INightmareLordTipT();
			this.UnPackTo(nightmareLordTipT);
			return nightmareLordTipT;
		}

		// Token: 0x0603067B RID: 198267 RVA: 0x00693017 File Offset: 0x00691217
		public void UnPackTo(INightmareLordTipT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
			_o.TidSubText = this.TidSubText;
		}

		// Token: 0x0603067C RID: 198268 RVA: 0x00693040 File Offset: 0x00691240
		public static Offset<INightmareLordTip> Pack(FlatBufferBuilder builder, INightmareLordTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<INightmareLordTip>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			StringOffset tidSubTextOffset = (_o.TidSubText == null) ? default(StringOffset) : builder.CreateString(_o.TidSubText);
			return INightmareLordTip.CreateINightmareLordTip(builder, _o.Type, tidMainTextOffset, tidSubTextOffset);
		}

		// Token: 0x04011476 RID: 70774
		private Table __p;
	}
}
