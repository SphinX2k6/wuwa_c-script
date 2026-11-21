using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059E4 RID: 23012
	public struct IInteractPlayerDiractionToNpc : IFlatbufferObject
	{
		// Token: 0x1700A744 RID: 42820
		// (get) Token: 0x0602593B RID: 153915 RVA: 0x005275EC File Offset: 0x005257EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602593C RID: 153916 RVA: 0x005275F9 File Offset: 0x005257F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602593D RID: 153917 RVA: 0x00527600 File Offset: 0x00525800
		public static IInteractPlayerDiractionToNpc GetRootAsIInteractPlayerDiractionToNpc(ByteBuffer _bb)
		{
			return IInteractPlayerDiractionToNpc.GetRootAsIInteractPlayerDiractionToNpc(_bb, default(IInteractPlayerDiractionToNpc));
		}

		// Token: 0x0602593E RID: 153918 RVA: 0x0052761C File Offset: 0x0052581C
		public static IInteractPlayerDiractionToNpc GetRootAsIInteractPlayerDiractionToNpc(ByteBuffer _bb, IInteractPlayerDiractionToNpc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602593F RID: 153919 RVA: 0x00527639 File Offset: 0x00525839
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025940 RID: 153920 RVA: 0x00527648 File Offset: 0x00525848
		public IInteractPlayerDiractionToNpc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A745 RID: 42821
		// (get) Token: 0x06025941 RID: 153921 RVA: 0x00527658 File Offset: 0x00525858
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

		// Token: 0x06025942 RID: 153922 RVA: 0x00527694 File Offset: 0x00525894
		public static Offset<IInteractPlayerDiractionToNpc> CreateIInteractPlayerDiractionToNpc(FlatBufferBuilder builder, EInteractPlayerDiractionType Type = EInteractPlayerDiractionType.Npc)
		{
			builder.StartTable(1);
			IInteractPlayerDiractionToNpc.AddType(builder, Type);
			return IInteractPlayerDiractionToNpc.EndIInteractPlayerDiractionToNpc(builder);
		}

		// Token: 0x06025943 RID: 153923 RVA: 0x005276AA File Offset: 0x005258AA
		public static void StartIInteractPlayerDiractionToNpc(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025944 RID: 153924 RVA: 0x005276B3 File Offset: 0x005258B3
		public static void AddType(FlatBufferBuilder builder, EInteractPlayerDiractionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025945 RID: 153925 RVA: 0x005276BE File Offset: 0x005258BE
		public static Offset<IInteractPlayerDiractionToNpc> EndIInteractPlayerDiractionToNpc(FlatBufferBuilder builder)
		{
			return new Offset<IInteractPlayerDiractionToNpc>(builder.EndTable());
		}

		// Token: 0x06025946 RID: 153926 RVA: 0x005276CC File Offset: 0x005258CC
		public IInteractPlayerDiractionToNpcT UnPack()
		{
			IInteractPlayerDiractionToNpcT interactPlayerDiractionToNpcT = new IInteractPlayerDiractionToNpcT();
			this.UnPackTo(interactPlayerDiractionToNpcT);
			return interactPlayerDiractionToNpcT;
		}

		// Token: 0x06025947 RID: 153927 RVA: 0x005276E7 File Offset: 0x005258E7
		public void UnPackTo(IInteractPlayerDiractionToNpcT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025948 RID: 153928 RVA: 0x005276F8 File Offset: 0x005258F8
		public static Offset<IInteractPlayerDiractionToNpc> Pack(FlatBufferBuilder builder, IInteractPlayerDiractionToNpcT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractPlayerDiractionToNpc>);
			}
			return IInteractPlayerDiractionToNpc.CreateIInteractPlayerDiractionToNpc(builder, _o.Type);
		}

		// Token: 0x0400F309 RID: 62217
		private Table __p;
	}
}
