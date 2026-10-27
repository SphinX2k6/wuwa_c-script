using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005461 RID: 21601
	public struct IInteractPlayerDiractionType : IFlatbufferObject
	{
		// Token: 0x17009F0D RID: 40717
		// (get) Token: 0x06023895 RID: 145557 RVA: 0x004EA6ED File Offset: 0x004E88ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023896 RID: 145558 RVA: 0x004EA6FA File Offset: 0x004E88FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023897 RID: 145559 RVA: 0x004EA704 File Offset: 0x004E8904
		public static IInteractPlayerDiractionType GetRootAsIInteractPlayerDiractionType(ByteBuffer _bb)
		{
			return IInteractPlayerDiractionType.GetRootAsIInteractPlayerDiractionType(_bb, default(IInteractPlayerDiractionType));
		}

		// Token: 0x06023898 RID: 145560 RVA: 0x004EA720 File Offset: 0x004E8920
		public static IInteractPlayerDiractionType GetRootAsIInteractPlayerDiractionType(ByteBuffer _bb, IInteractPlayerDiractionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023899 RID: 145561 RVA: 0x004EA73D File Offset: 0x004E893D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602389A RID: 145562 RVA: 0x004EA74C File Offset: 0x004E894C
		public IInteractPlayerDiractionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F0E RID: 40718
		// (get) Token: 0x0602389B RID: 145563 RVA: 0x004EA75C File Offset: 0x004E895C
		public EInteractPlayerDiractionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractPlayerDiractionType.Npc;
				}
				return (EInteractPlayerDiractionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602389C RID: 145564 RVA: 0x004EA798 File Offset: 0x004E8998
		public static Offset<IInteractPlayerDiractionType> CreateIInteractPlayerDiractionType(FlatBufferBuilder builder, EInteractPlayerDiractionType Type = EInteractPlayerDiractionType.Npc)
		{
			builder.StartTable(1);
			IInteractPlayerDiractionType.AddType(builder, Type);
			return IInteractPlayerDiractionType.EndIInteractPlayerDiractionType(builder);
		}

		// Token: 0x0602389D RID: 145565 RVA: 0x004EA7AE File Offset: 0x004E89AE
		public static void StartIInteractPlayerDiractionType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602389E RID: 145566 RVA: 0x004EA7B7 File Offset: 0x004E89B7
		public static void AddType(FlatBufferBuilder builder, EInteractPlayerDiractionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602389F RID: 145567 RVA: 0x004EA7C2 File Offset: 0x004E89C2
		public static Offset<IInteractPlayerDiractionType> EndIInteractPlayerDiractionType(FlatBufferBuilder builder)
		{
			return new Offset<IInteractPlayerDiractionType>(builder.EndTable());
		}

		// Token: 0x060238A0 RID: 145568 RVA: 0x004EA7D0 File Offset: 0x004E89D0
		public IInteractPlayerDiractionTypeT UnPack()
		{
			IInteractPlayerDiractionTypeT interactPlayerDiractionTypeT = new IInteractPlayerDiractionTypeT();
			this.UnPackTo(interactPlayerDiractionTypeT);
			return interactPlayerDiractionTypeT;
		}

		// Token: 0x060238A1 RID: 145569 RVA: 0x004EA7EB File Offset: 0x004E89EB
		public void UnPackTo(IInteractPlayerDiractionTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060238A2 RID: 145570 RVA: 0x004EA7FC File Offset: 0x004E89FC
		public static Offset<IInteractPlayerDiractionType> Pack(FlatBufferBuilder builder, IInteractPlayerDiractionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractPlayerDiractionType>);
			}
			return IInteractPlayerDiractionType.CreateIInteractPlayerDiractionType(builder, _o.Type);
		}

		// Token: 0x0400E6DA RID: 59098
		private Table __p;
	}
}
