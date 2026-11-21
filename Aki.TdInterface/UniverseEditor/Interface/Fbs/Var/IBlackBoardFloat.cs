using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003DF0 RID: 15856
	public struct IBlackBoardFloat : IFlatbufferObject
	{
		// Token: 0x17006B18 RID: 27416
		// (get) Token: 0x060154A3 RID: 87203 RVA: 0x003140EA File Offset: 0x003122EA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060154A4 RID: 87204 RVA: 0x003140F7 File Offset: 0x003122F7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060154A5 RID: 87205 RVA: 0x00314100 File Offset: 0x00312300
		public static IBlackBoardFloat GetRootAsIBlackBoardFloat(ByteBuffer _bb)
		{
			return IBlackBoardFloat.GetRootAsIBlackBoardFloat(_bb, default(IBlackBoardFloat));
		}

		// Token: 0x060154A6 RID: 87206 RVA: 0x0031411C File Offset: 0x0031231C
		public static IBlackBoardFloat GetRootAsIBlackBoardFloat(ByteBuffer _bb, IBlackBoardFloat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060154A7 RID: 87207 RVA: 0x00314139 File Offset: 0x00312339
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060154A8 RID: 87208 RVA: 0x00314148 File Offset: 0x00312348
		public IBlackBoardFloat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B19 RID: 27417
		// (get) Token: 0x060154A9 RID: 87209 RVA: 0x00314158 File Offset: 0x00312358
		public EBlackBoardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBlackBoardType.Boolean;
				}
				return (EBlackBoardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006B1A RID: 27418
		// (get) Token: 0x060154AA RID: 87210 RVA: 0x00314194 File Offset: 0x00312394
		public string Key
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

		// Token: 0x060154AB RID: 87211 RVA: 0x003141CB File Offset: 0x003123CB
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060154AC RID: 87212 RVA: 0x003141DA File Offset: 0x003123DA
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006B1B RID: 27419
		// (get) Token: 0x060154AD RID: 87213 RVA: 0x003141E8 File Offset: 0x003123E8
		public float Value
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060154AE RID: 87214 RVA: 0x00314228 File Offset: 0x00312428
		public static Offset<IBlackBoardFloat> CreateIBlackBoardFloat(FlatBufferBuilder builder, EBlackBoardType Type = EBlackBoardType.Boolean, StringOffset KeyOffset = default(StringOffset), float Value = 0f)
		{
			builder.StartTable(3);
			IBlackBoardFloat.AddValue(builder, Value);
			IBlackBoardFloat.AddKey(builder, KeyOffset);
			IBlackBoardFloat.AddType(builder, Type);
			return IBlackBoardFloat.EndIBlackBoardFloat(builder);
		}

		// Token: 0x060154AF RID: 87215 RVA: 0x0031424C File Offset: 0x0031244C
		public static void StartIBlackBoardFloat(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060154B0 RID: 87216 RVA: 0x00314255 File Offset: 0x00312455
		public static void AddType(FlatBufferBuilder builder, EBlackBoardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060154B1 RID: 87217 RVA: 0x00314260 File Offset: 0x00312460
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x060154B2 RID: 87218 RVA: 0x00314270 File Offset: 0x00312470
		public static void AddValue(FlatBufferBuilder builder, float value)
		{
			builder.AddFloat(2, value, 0.0);
		}

		// Token: 0x060154B3 RID: 87219 RVA: 0x00314283 File Offset: 0x00312483
		public static Offset<IBlackBoardFloat> EndIBlackBoardFloat(FlatBufferBuilder builder)
		{
			return new Offset<IBlackBoardFloat>(builder.EndTable());
		}

		// Token: 0x060154B4 RID: 87220 RVA: 0x00314290 File Offset: 0x00312490
		public IBlackBoardFloatT UnPack()
		{
			IBlackBoardFloatT blackBoardFloatT = new IBlackBoardFloatT();
			this.UnPackTo(blackBoardFloatT);
			return blackBoardFloatT;
		}

		// Token: 0x060154B5 RID: 87221 RVA: 0x003142AB File Offset: 0x003124AB
		public void UnPackTo(IBlackBoardFloatT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
			_o.Value = this.Value;
		}

		// Token: 0x060154B6 RID: 87222 RVA: 0x003142D4 File Offset: 0x003124D4
		public static Offset<IBlackBoardFloat> Pack(FlatBufferBuilder builder, IBlackBoardFloatT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlackBoardFloat>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IBlackBoardFloat.CreateIBlackBoardFloat(builder, _o.Type, keyOffset, _o.Value);
		}

		// Token: 0x0400B7A2 RID: 47010
		private Table __p;
	}
}
