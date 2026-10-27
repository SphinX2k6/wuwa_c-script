using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200679B RID: 26523
	public struct IFaithJump : IFlatbufferObject
	{
		// Token: 0x1700C4E3 RID: 50403
		// (get) Token: 0x0602E26C RID: 189036 RVA: 0x0064DC10 File Offset: 0x0064BE10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E26D RID: 189037 RVA: 0x0064DC1D File Offset: 0x0064BE1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E26E RID: 189038 RVA: 0x0064DC24 File Offset: 0x0064BE24
		public static IFaithJump GetRootAsIFaithJump(ByteBuffer _bb)
		{
			return IFaithJump.GetRootAsIFaithJump(_bb, default(IFaithJump));
		}

		// Token: 0x0602E26F RID: 189039 RVA: 0x0064DC40 File Offset: 0x0064BE40
		public static IFaithJump GetRootAsIFaithJump(ByteBuffer _bb, IFaithJump obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E270 RID: 189040 RVA: 0x0064DC5D File Offset: 0x0064BE5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E271 RID: 189041 RVA: 0x0064DC6C File Offset: 0x0064BE6C
		public IFaithJump __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4E4 RID: 50404
		// (get) Token: 0x0602E272 RID: 189042 RVA: 0x0064DC7C File Offset: 0x0064BE7C
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E273 RID: 189043 RVA: 0x0064DCB8 File Offset: 0x0064BEB8
		public static Offset<IFaithJump> CreateIFaithJump(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IFaithJump.AddType(builder, Type);
			return IFaithJump.EndIFaithJump(builder);
		}

		// Token: 0x0602E274 RID: 189044 RVA: 0x0064DCCE File Offset: 0x0064BECE
		public static void StartIFaithJump(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E275 RID: 189045 RVA: 0x0064DCD7 File Offset: 0x0064BED7
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E276 RID: 189046 RVA: 0x0064DCE2 File Offset: 0x0064BEE2
		public static Offset<IFaithJump> EndIFaithJump(FlatBufferBuilder builder)
		{
			return new Offset<IFaithJump>(builder.EndTable());
		}

		// Token: 0x0602E277 RID: 189047 RVA: 0x0064DCF0 File Offset: 0x0064BEF0
		public IFaithJumpT UnPack()
		{
			IFaithJumpT faithJumpT = new IFaithJumpT();
			this.UnPackTo(faithJumpT);
			return faithJumpT;
		}

		// Token: 0x0602E278 RID: 189048 RVA: 0x0064DD0B File Offset: 0x0064BF0B
		public void UnPackTo(IFaithJumpT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E279 RID: 189049 RVA: 0x0064DD1C File Offset: 0x0064BF1C
		public static Offset<IFaithJump> Pack(FlatBufferBuilder builder, IFaithJumpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFaithJump>);
			}
			return IFaithJump.CreateIFaithJump(builder, _o.Type);
		}

		// Token: 0x04010EAA RID: 69290
		private Table __p;
	}
}
