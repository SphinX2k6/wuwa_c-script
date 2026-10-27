using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200545E RID: 21598
	public struct IInteractPlayerDiractionToNpc : IFlatbufferObject
	{
		// Token: 0x17009F0A RID: 40714
		// (get) Token: 0x06023883 RID: 145539 RVA: 0x004EA578 File Offset: 0x004E8778
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023884 RID: 145540 RVA: 0x004EA585 File Offset: 0x004E8785
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023885 RID: 145541 RVA: 0x004EA58C File Offset: 0x004E878C
		public static IInteractPlayerDiractionToNpc GetRootAsIInteractPlayerDiractionToNpc(ByteBuffer _bb)
		{
			return IInteractPlayerDiractionToNpc.GetRootAsIInteractPlayerDiractionToNpc(_bb, default(IInteractPlayerDiractionToNpc));
		}

		// Token: 0x06023886 RID: 145542 RVA: 0x004EA5A8 File Offset: 0x004E87A8
		public static IInteractPlayerDiractionToNpc GetRootAsIInteractPlayerDiractionToNpc(ByteBuffer _bb, IInteractPlayerDiractionToNpc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023887 RID: 145543 RVA: 0x004EA5C5 File Offset: 0x004E87C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023888 RID: 145544 RVA: 0x004EA5D4 File Offset: 0x004E87D4
		public IInteractPlayerDiractionToNpc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F0B RID: 40715
		// (get) Token: 0x06023889 RID: 145545 RVA: 0x004EA5E4 File Offset: 0x004E87E4
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

		// Token: 0x0602388A RID: 145546 RVA: 0x004EA620 File Offset: 0x004E8820
		public static Offset<IInteractPlayerDiractionToNpc> CreateIInteractPlayerDiractionToNpc(FlatBufferBuilder builder, EInteractPlayerDiractionType Type = EInteractPlayerDiractionType.Npc)
		{
			builder.StartTable(1);
			IInteractPlayerDiractionToNpc.AddType(builder, Type);
			return IInteractPlayerDiractionToNpc.EndIInteractPlayerDiractionToNpc(builder);
		}

		// Token: 0x0602388B RID: 145547 RVA: 0x004EA636 File Offset: 0x004E8836
		public static void StartIInteractPlayerDiractionToNpc(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602388C RID: 145548 RVA: 0x004EA63F File Offset: 0x004E883F
		public static void AddType(FlatBufferBuilder builder, EInteractPlayerDiractionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602388D RID: 145549 RVA: 0x004EA64A File Offset: 0x004E884A
		public static Offset<IInteractPlayerDiractionToNpc> EndIInteractPlayerDiractionToNpc(FlatBufferBuilder builder)
		{
			return new Offset<IInteractPlayerDiractionToNpc>(builder.EndTable());
		}

		// Token: 0x0602388E RID: 145550 RVA: 0x004EA658 File Offset: 0x004E8858
		public IInteractPlayerDiractionToNpcT UnPack()
		{
			IInteractPlayerDiractionToNpcT interactPlayerDiractionToNpcT = new IInteractPlayerDiractionToNpcT();
			this.UnPackTo(interactPlayerDiractionToNpcT);
			return interactPlayerDiractionToNpcT;
		}

		// Token: 0x0602388F RID: 145551 RVA: 0x004EA673 File Offset: 0x004E8873
		public void UnPackTo(IInteractPlayerDiractionToNpcT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023890 RID: 145552 RVA: 0x004EA684 File Offset: 0x004E8884
		public static Offset<IInteractPlayerDiractionToNpc> Pack(FlatBufferBuilder builder, IInteractPlayerDiractionToNpcT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractPlayerDiractionToNpc>);
			}
			return IInteractPlayerDiractionToNpc.CreateIInteractPlayerDiractionToNpc(builder, _o.Type);
		}

		// Token: 0x0400E6D8 RID: 59096
		private Table __p;
	}
}
