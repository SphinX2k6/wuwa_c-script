using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070B2 RID: 28850
	public struct ILiftMoveTypeCircular : IFlatbufferObject
	{
		// Token: 0x1700D35A RID: 54106
		// (get) Token: 0x06032189 RID: 205193 RVA: 0x006C7C31 File Offset: 0x006C5E31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603218A RID: 205194 RVA: 0x006C7C3E File Offset: 0x006C5E3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603218B RID: 205195 RVA: 0x006C7C48 File Offset: 0x006C5E48
		public static ILiftMoveTypeCircular GetRootAsILiftMoveTypeCircular(ByteBuffer _bb)
		{
			return ILiftMoveTypeCircular.GetRootAsILiftMoveTypeCircular(_bb, default(ILiftMoveTypeCircular));
		}

		// Token: 0x0603218C RID: 205196 RVA: 0x006C7C64 File Offset: 0x006C5E64
		public static ILiftMoveTypeCircular GetRootAsILiftMoveTypeCircular(ByteBuffer _bb, ILiftMoveTypeCircular obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603218D RID: 205197 RVA: 0x006C7C81 File Offset: 0x006C5E81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603218E RID: 205198 RVA: 0x006C7C90 File Offset: 0x006C5E90
		public ILiftMoveTypeCircular __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D35B RID: 54107
		// (get) Token: 0x0603218F RID: 205199 RVA: 0x006C7CA0 File Offset: 0x006C5EA0
		public ELiftMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiftMoveType.Default;
				}
				return (ELiftMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032190 RID: 205200 RVA: 0x006C7CDC File Offset: 0x006C5EDC
		public static Offset<ILiftMoveTypeCircular> CreateILiftMoveTypeCircular(FlatBufferBuilder builder, ELiftMoveType Type = ELiftMoveType.Default)
		{
			builder.StartTable(1);
			ILiftMoveTypeCircular.AddType(builder, Type);
			return ILiftMoveTypeCircular.EndILiftMoveTypeCircular(builder);
		}

		// Token: 0x06032191 RID: 205201 RVA: 0x006C7CF2 File Offset: 0x006C5EF2
		public static void StartILiftMoveTypeCircular(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032192 RID: 205202 RVA: 0x006C7CFB File Offset: 0x006C5EFB
		public static void AddType(FlatBufferBuilder builder, ELiftMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032193 RID: 205203 RVA: 0x006C7D06 File Offset: 0x006C5F06
		public static Offset<ILiftMoveTypeCircular> EndILiftMoveTypeCircular(FlatBufferBuilder builder)
		{
			return new Offset<ILiftMoveTypeCircular>(builder.EndTable());
		}

		// Token: 0x06032194 RID: 205204 RVA: 0x006C7D14 File Offset: 0x006C5F14
		public ILiftMoveTypeCircularT UnPack()
		{
			ILiftMoveTypeCircularT liftMoveTypeCircularT = new ILiftMoveTypeCircularT();
			this.UnPackTo(liftMoveTypeCircularT);
			return liftMoveTypeCircularT;
		}

		// Token: 0x06032195 RID: 205205 RVA: 0x006C7D2F File Offset: 0x006C5F2F
		public void UnPackTo(ILiftMoveTypeCircularT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032196 RID: 205206 RVA: 0x006C7D40 File Offset: 0x006C5F40
		public static Offset<ILiftMoveTypeCircular> Pack(FlatBufferBuilder builder, ILiftMoveTypeCircularT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiftMoveTypeCircular>);
			}
			return ILiftMoveTypeCircular.CreateILiftMoveTypeCircular(builder, _o.Type);
		}

		// Token: 0x0401206C RID: 73836
		private Table __p;
	}
}
