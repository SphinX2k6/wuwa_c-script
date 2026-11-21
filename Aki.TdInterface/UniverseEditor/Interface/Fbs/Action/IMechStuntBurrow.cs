using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071AD RID: 29101
	public struct IMechStuntBurrow : IFlatbufferObject
	{
		// Token: 0x1700D52E RID: 54574
		// (get) Token: 0x060329F6 RID: 207350 RVA: 0x006D743D File Offset: 0x006D563D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060329F7 RID: 207351 RVA: 0x006D744A File Offset: 0x006D564A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060329F8 RID: 207352 RVA: 0x006D7454 File Offset: 0x006D5654
		public static IMechStuntBurrow GetRootAsIMechStuntBurrow(ByteBuffer _bb)
		{
			return IMechStuntBurrow.GetRootAsIMechStuntBurrow(_bb, default(IMechStuntBurrow));
		}

		// Token: 0x060329F9 RID: 207353 RVA: 0x006D7470 File Offset: 0x006D5670
		public static IMechStuntBurrow GetRootAsIMechStuntBurrow(ByteBuffer _bb, IMechStuntBurrow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060329FA RID: 207354 RVA: 0x006D748D File Offset: 0x006D568D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060329FB RID: 207355 RVA: 0x006D749C File Offset: 0x006D569C
		public IMechStuntBurrow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D52F RID: 54575
		// (get) Token: 0x060329FC RID: 207356 RVA: 0x006D74AC File Offset: 0x006D56AC
		public EMechStuntType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMechStuntType.Dive;
				}
				return (EMechStuntType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060329FD RID: 207357 RVA: 0x006D74E8 File Offset: 0x006D56E8
		public static Offset<IMechStuntBurrow> CreateIMechStuntBurrow(FlatBufferBuilder builder, EMechStuntType Type = EMechStuntType.Dive)
		{
			builder.StartTable(1);
			IMechStuntBurrow.AddType(builder, Type);
			return IMechStuntBurrow.EndIMechStuntBurrow(builder);
		}

		// Token: 0x060329FE RID: 207358 RVA: 0x006D74FE File Offset: 0x006D56FE
		public static void StartIMechStuntBurrow(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060329FF RID: 207359 RVA: 0x006D7507 File Offset: 0x006D5707
		public static void AddType(FlatBufferBuilder builder, EMechStuntType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032A00 RID: 207360 RVA: 0x006D7512 File Offset: 0x006D5712
		public static Offset<IMechStuntBurrow> EndIMechStuntBurrow(FlatBufferBuilder builder)
		{
			return new Offset<IMechStuntBurrow>(builder.EndTable());
		}

		// Token: 0x06032A01 RID: 207361 RVA: 0x006D7520 File Offset: 0x006D5720
		public IMechStuntBurrowT UnPack()
		{
			IMechStuntBurrowT mechStuntBurrowT = new IMechStuntBurrowT();
			this.UnPackTo(mechStuntBurrowT);
			return mechStuntBurrowT;
		}

		// Token: 0x06032A02 RID: 207362 RVA: 0x006D753B File Offset: 0x006D573B
		public void UnPackTo(IMechStuntBurrowT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032A03 RID: 207363 RVA: 0x006D754C File Offset: 0x006D574C
		public static Offset<IMechStuntBurrow> Pack(FlatBufferBuilder builder, IMechStuntBurrowT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechStuntBurrow>);
			}
			return IMechStuntBurrow.CreateIMechStuntBurrow(builder, _o.Type);
		}

		// Token: 0x040121BF RID: 74175
		private Table __p;
	}
}
