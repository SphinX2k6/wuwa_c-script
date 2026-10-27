using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006534 RID: 25908
	public struct IDaolingAuthentication : IFlatbufferObject
	{
		// Token: 0x1700C098 RID: 49304
		// (get) Token: 0x0602CF1B RID: 184091 RVA: 0x0062BD6A File Offset: 0x00629F6A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CF1C RID: 184092 RVA: 0x0062BD77 File Offset: 0x00629F77
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CF1D RID: 184093 RVA: 0x0062BD80 File Offset: 0x00629F80
		public static IDaolingAuthentication GetRootAsIDaolingAuthentication(ByteBuffer _bb)
		{
			return IDaolingAuthentication.GetRootAsIDaolingAuthentication(_bb, default(IDaolingAuthentication));
		}

		// Token: 0x0602CF1E RID: 184094 RVA: 0x0062BD9C File Offset: 0x00629F9C
		public static IDaolingAuthentication GetRootAsIDaolingAuthentication(ByteBuffer _bb, IDaolingAuthentication obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CF1F RID: 184095 RVA: 0x0062BDB9 File Offset: 0x00629FB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CF20 RID: 184096 RVA: 0x0062BDC8 File Offset: 0x00629FC8
		public IDaolingAuthentication __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C099 RID: 49305
		// (get) Token: 0x0602CF21 RID: 184097 RVA: 0x0062BDD8 File Offset: 0x00629FD8
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

		// Token: 0x0602CF22 RID: 184098 RVA: 0x0062BE14 File Offset: 0x0062A014
		public static Offset<IDaolingAuthentication> CreateIDaolingAuthentication(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher)
		{
			builder.StartTable(1);
			IDaolingAuthentication.AddType(builder, Type);
			return IDaolingAuthentication.EndIDaolingAuthentication(builder);
		}

		// Token: 0x0602CF23 RID: 184099 RVA: 0x0062BE2A File Offset: 0x0062A02A
		public static void StartIDaolingAuthentication(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CF24 RID: 184100 RVA: 0x0062BE33 File Offset: 0x0062A033
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CF25 RID: 184101 RVA: 0x0062BE3E File Offset: 0x0062A03E
		public static Offset<IDaolingAuthentication> EndIDaolingAuthentication(FlatBufferBuilder builder)
		{
			return new Offset<IDaolingAuthentication>(builder.EndTable());
		}

		// Token: 0x0602CF26 RID: 184102 RVA: 0x0062BE4C File Offset: 0x0062A04C
		public IDaolingAuthenticationT UnPack()
		{
			IDaolingAuthenticationT daolingAuthenticationT = new IDaolingAuthenticationT();
			this.UnPackTo(daolingAuthenticationT);
			return daolingAuthenticationT;
		}

		// Token: 0x0602CF27 RID: 184103 RVA: 0x0062BE67 File Offset: 0x0062A067
		public void UnPackTo(IDaolingAuthenticationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CF28 RID: 184104 RVA: 0x0062BE78 File Offset: 0x0062A078
		public static Offset<IDaolingAuthentication> Pack(FlatBufferBuilder builder, IDaolingAuthenticationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDaolingAuthentication>);
			}
			return IDaolingAuthentication.CreateIDaolingAuthentication(builder, _o.Type);
		}

		// Token: 0x04010B7C RID: 68476
		private Table __p;
	}
}
