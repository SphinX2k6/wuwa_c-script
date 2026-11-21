using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004ABF RID: 19135
	public struct IGetAllGraduatedWeapon : IFlatbufferObject
	{
		// Token: 0x17008610 RID: 34320
		// (get) Token: 0x0601CC72 RID: 117874 RVA: 0x0040DEE9 File Offset: 0x0040C0E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CC73 RID: 117875 RVA: 0x0040DEF6 File Offset: 0x0040C0F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CC74 RID: 117876 RVA: 0x0040DF00 File Offset: 0x0040C100
		public static IGetAllGraduatedWeapon GetRootAsIGetAllGraduatedWeapon(ByteBuffer _bb)
		{
			return IGetAllGraduatedWeapon.GetRootAsIGetAllGraduatedWeapon(_bb, default(IGetAllGraduatedWeapon));
		}

		// Token: 0x0601CC75 RID: 117877 RVA: 0x0040DF1C File Offset: 0x0040C11C
		public static IGetAllGraduatedWeapon GetRootAsIGetAllGraduatedWeapon(ByteBuffer _bb, IGetAllGraduatedWeapon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CC76 RID: 117878 RVA: 0x0040DF39 File Offset: 0x0040C139
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CC77 RID: 117879 RVA: 0x0040DF48 File Offset: 0x0040C148
		public IGetAllGraduatedWeapon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008611 RID: 34321
		// (get) Token: 0x0601CC78 RID: 117880 RVA: 0x0040DF58 File Offset: 0x0040C158
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CC79 RID: 117881 RVA: 0x0040DF94 File Offset: 0x0040C194
		public static Offset<IGetAllGraduatedWeapon> CreateIGetAllGraduatedWeapon(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IGetAllGraduatedWeapon.AddType(builder, Type);
			return IGetAllGraduatedWeapon.EndIGetAllGraduatedWeapon(builder);
		}

		// Token: 0x0601CC7A RID: 117882 RVA: 0x0040DFAA File Offset: 0x0040C1AA
		public static void StartIGetAllGraduatedWeapon(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601CC7B RID: 117883 RVA: 0x0040DFB3 File Offset: 0x0040C1B3
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CC7C RID: 117884 RVA: 0x0040DFBE File Offset: 0x0040C1BE
		public static Offset<IGetAllGraduatedWeapon> EndIGetAllGraduatedWeapon(FlatBufferBuilder builder)
		{
			return new Offset<IGetAllGraduatedWeapon>(builder.EndTable());
		}

		// Token: 0x0601CC7D RID: 117885 RVA: 0x0040DFCC File Offset: 0x0040C1CC
		public IGetAllGraduatedWeaponT UnPack()
		{
			IGetAllGraduatedWeaponT getAllGraduatedWeaponT = new IGetAllGraduatedWeaponT();
			this.UnPackTo(getAllGraduatedWeaponT);
			return getAllGraduatedWeaponT;
		}

		// Token: 0x0601CC7E RID: 117886 RVA: 0x0040DFE7 File Offset: 0x0040C1E7
		public void UnPackTo(IGetAllGraduatedWeaponT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601CC7F RID: 117887 RVA: 0x0040DFF8 File Offset: 0x0040C1F8
		public static Offset<IGetAllGraduatedWeapon> Pack(FlatBufferBuilder builder, IGetAllGraduatedWeaponT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGetAllGraduatedWeapon>);
			}
			return IGetAllGraduatedWeapon.CreateIGetAllGraduatedWeapon(builder, _o.Type);
		}

		// Token: 0x0400D203 RID: 53763
		private Table __p;
	}
}
