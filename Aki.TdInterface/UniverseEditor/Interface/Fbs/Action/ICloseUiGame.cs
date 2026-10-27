using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006442 RID: 25666
	public struct ICloseUiGame : IFlatbufferObject
	{
		// Token: 0x1700BF1A RID: 48922
		// (get) Token: 0x0602C6C0 RID: 181952 RVA: 0x0061822A File Offset: 0x0061642A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C6C1 RID: 181953 RVA: 0x00618237 File Offset: 0x00616437
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C6C2 RID: 181954 RVA: 0x00618240 File Offset: 0x00616440
		public static ICloseUiGame GetRootAsICloseUiGame(ByteBuffer _bb)
		{
			return ICloseUiGame.GetRootAsICloseUiGame(_bb, default(ICloseUiGame));
		}

		// Token: 0x0602C6C3 RID: 181955 RVA: 0x0061825C File Offset: 0x0061645C
		public static ICloseUiGame GetRootAsICloseUiGame(ByteBuffer _bb, ICloseUiGame obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C6C4 RID: 181956 RVA: 0x00618279 File Offset: 0x00616479
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C6C5 RID: 181957 RVA: 0x00618288 File Offset: 0x00616488
		public ICloseUiGame __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF1B RID: 48923
		// (get) Token: 0x0602C6C6 RID: 181958 RVA: 0x00618298 File Offset: 0x00616498
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C6C7 RID: 181959 RVA: 0x006182D4 File Offset: 0x006164D4
		public static Offset<ICloseUiGame> CreateICloseUiGame(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher)
		{
			builder.StartTable(1);
			ICloseUiGame.AddType(builder, Type);
			return ICloseUiGame.EndICloseUiGame(builder);
		}

		// Token: 0x0602C6C8 RID: 181960 RVA: 0x006182EA File Offset: 0x006164EA
		public static void StartICloseUiGame(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C6C9 RID: 181961 RVA: 0x006182F3 File Offset: 0x006164F3
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C6CA RID: 181962 RVA: 0x006182FE File Offset: 0x006164FE
		public static Offset<ICloseUiGame> EndICloseUiGame(FlatBufferBuilder builder)
		{
			return new Offset<ICloseUiGame>(builder.EndTable());
		}

		// Token: 0x0602C6CB RID: 181963 RVA: 0x0061830C File Offset: 0x0061650C
		public ICloseUiGameT UnPack()
		{
			ICloseUiGameT closeUiGameT = new ICloseUiGameT();
			this.UnPackTo(closeUiGameT);
			return closeUiGameT;
		}

		// Token: 0x0602C6CC RID: 181964 RVA: 0x00618327 File Offset: 0x00616527
		public void UnPackTo(ICloseUiGameT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C6CD RID: 181965 RVA: 0x00618338 File Offset: 0x00616538
		public static Offset<ICloseUiGame> Pack(FlatBufferBuilder builder, ICloseUiGameT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseUiGame>);
			}
			return ICloseUiGame.CreateICloseUiGame(builder, _o.Type);
		}

		// Token: 0x04010A3D RID: 68157
		private Table __p;
	}
}
