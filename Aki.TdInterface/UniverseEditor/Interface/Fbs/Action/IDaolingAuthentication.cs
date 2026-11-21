using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BA2 RID: 27554
	public struct IDaolingAuthentication : IFlatbufferObject
	{
		// Token: 0x1700CA2A RID: 51754
		// (get) Token: 0x0602F6B9 RID: 194233 RVA: 0x00678216 File Offset: 0x00676416
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F6BA RID: 194234 RVA: 0x00678223 File Offset: 0x00676423
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F6BB RID: 194235 RVA: 0x0067822C File Offset: 0x0067642C
		public static IDaolingAuthentication GetRootAsIDaolingAuthentication(ByteBuffer _bb)
		{
			return IDaolingAuthentication.GetRootAsIDaolingAuthentication(_bb, default(IDaolingAuthentication));
		}

		// Token: 0x0602F6BC RID: 194236 RVA: 0x00678248 File Offset: 0x00676448
		public static IDaolingAuthentication GetRootAsIDaolingAuthentication(ByteBuffer _bb, IDaolingAuthentication obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F6BD RID: 194237 RVA: 0x00678265 File Offset: 0x00676465
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F6BE RID: 194238 RVA: 0x00678274 File Offset: 0x00676474
		public IDaolingAuthentication __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA2B RID: 51755
		// (get) Token: 0x0602F6BF RID: 194239 RVA: 0x00678284 File Offset: 0x00676484
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

		// Token: 0x0602F6C0 RID: 194240 RVA: 0x006782C0 File Offset: 0x006764C0
		public static Offset<IDaolingAuthentication> CreateIDaolingAuthentication(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher)
		{
			builder.StartTable(1);
			IDaolingAuthentication.AddType(builder, Type);
			return IDaolingAuthentication.EndIDaolingAuthentication(builder);
		}

		// Token: 0x0602F6C1 RID: 194241 RVA: 0x006782D6 File Offset: 0x006764D6
		public static void StartIDaolingAuthentication(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F6C2 RID: 194242 RVA: 0x006782DF File Offset: 0x006764DF
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F6C3 RID: 194243 RVA: 0x006782EA File Offset: 0x006764EA
		public static Offset<IDaolingAuthentication> EndIDaolingAuthentication(FlatBufferBuilder builder)
		{
			return new Offset<IDaolingAuthentication>(builder.EndTable());
		}

		// Token: 0x0602F6C4 RID: 194244 RVA: 0x006782F8 File Offset: 0x006764F8
		public IDaolingAuthenticationT UnPack()
		{
			IDaolingAuthenticationT daolingAuthenticationT = new IDaolingAuthenticationT();
			this.UnPackTo(daolingAuthenticationT);
			return daolingAuthenticationT;
		}

		// Token: 0x0602F6C5 RID: 194245 RVA: 0x00678313 File Offset: 0x00676513
		public void UnPackTo(IDaolingAuthenticationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F6C6 RID: 194246 RVA: 0x00678324 File Offset: 0x00676524
		public static Offset<IDaolingAuthentication> Pack(FlatBufferBuilder builder, IDaolingAuthenticationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDaolingAuthentication>);
			}
			return IDaolingAuthentication.CreateIDaolingAuthentication(builder, _o.Type);
		}

		// Token: 0x04011995 RID: 72085
		private Table __p;
	}
}
