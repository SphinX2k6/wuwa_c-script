using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004657 RID: 18007
	public struct IGetAllGraduatedWeapon : IFlatbufferObject
	{
		// Token: 0x17007FCF RID: 32719
		// (get) Token: 0x0601B49D RID: 111773 RVA: 0x003E1C4D File Offset: 0x003DFE4D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B49E RID: 111774 RVA: 0x003E1C5A File Offset: 0x003DFE5A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B49F RID: 111775 RVA: 0x003E1C64 File Offset: 0x003DFE64
		public static IGetAllGraduatedWeapon GetRootAsIGetAllGraduatedWeapon(ByteBuffer _bb)
		{
			return IGetAllGraduatedWeapon.GetRootAsIGetAllGraduatedWeapon(_bb, default(IGetAllGraduatedWeapon));
		}

		// Token: 0x0601B4A0 RID: 111776 RVA: 0x003E1C80 File Offset: 0x003DFE80
		public static IGetAllGraduatedWeapon GetRootAsIGetAllGraduatedWeapon(ByteBuffer _bb, IGetAllGraduatedWeapon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B4A1 RID: 111777 RVA: 0x003E1C9D File Offset: 0x003DFE9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B4A2 RID: 111778 RVA: 0x003E1CAC File Offset: 0x003DFEAC
		public IGetAllGraduatedWeapon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007FD0 RID: 32720
		// (get) Token: 0x0601B4A3 RID: 111779 RVA: 0x003E1CBC File Offset: 0x003DFEBC
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

		// Token: 0x0601B4A4 RID: 111780 RVA: 0x003E1CF8 File Offset: 0x003DFEF8
		public static Offset<IGetAllGraduatedWeapon> CreateIGetAllGraduatedWeapon(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IGetAllGraduatedWeapon.AddType(builder, Type);
			return IGetAllGraduatedWeapon.EndIGetAllGraduatedWeapon(builder);
		}

		// Token: 0x0601B4A5 RID: 111781 RVA: 0x003E1D0E File Offset: 0x003DFF0E
		public static void StartIGetAllGraduatedWeapon(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B4A6 RID: 111782 RVA: 0x003E1D17 File Offset: 0x003DFF17
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B4A7 RID: 111783 RVA: 0x003E1D22 File Offset: 0x003DFF22
		public static Offset<IGetAllGraduatedWeapon> EndIGetAllGraduatedWeapon(FlatBufferBuilder builder)
		{
			return new Offset<IGetAllGraduatedWeapon>(builder.EndTable());
		}

		// Token: 0x0601B4A8 RID: 111784 RVA: 0x003E1D30 File Offset: 0x003DFF30
		public IGetAllGraduatedWeaponT UnPack()
		{
			IGetAllGraduatedWeaponT getAllGraduatedWeaponT = new IGetAllGraduatedWeaponT();
			this.UnPackTo(getAllGraduatedWeaponT);
			return getAllGraduatedWeaponT;
		}

		// Token: 0x0601B4A9 RID: 111785 RVA: 0x003E1D4B File Offset: 0x003DFF4B
		public void UnPackTo(IGetAllGraduatedWeaponT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B4AA RID: 111786 RVA: 0x003E1D5C File Offset: 0x003DFF5C
		public static Offset<IGetAllGraduatedWeapon> Pack(FlatBufferBuilder builder, IGetAllGraduatedWeaponT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGetAllGraduatedWeapon>);
			}
			return IGetAllGraduatedWeapon.CreateIGetAllGraduatedWeapon(builder, _o.Type);
		}

		// Token: 0x0400C7D4 RID: 51156
		private Table __p;
	}
}
