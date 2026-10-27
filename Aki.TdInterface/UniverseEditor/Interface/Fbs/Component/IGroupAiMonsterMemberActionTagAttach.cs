using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005344 RID: 21316
	public struct IGroupAiMonsterMemberActionTagAttach : IFlatbufferObject
	{
		// Token: 0x17009C93 RID: 40083
		// (get) Token: 0x06022DBC RID: 142780 RVA: 0x004D449E File Offset: 0x004D269E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022DBD RID: 142781 RVA: 0x004D44AB File Offset: 0x004D26AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022DBE RID: 142782 RVA: 0x004D44B4 File Offset: 0x004D26B4
		public static IGroupAiMonsterMemberActionTagAttach GetRootAsIGroupAiMonsterMemberActionTagAttach(ByteBuffer _bb)
		{
			return IGroupAiMonsterMemberActionTagAttach.GetRootAsIGroupAiMonsterMemberActionTagAttach(_bb, default(IGroupAiMonsterMemberActionTagAttach));
		}

		// Token: 0x06022DBF RID: 142783 RVA: 0x004D44D0 File Offset: 0x004D26D0
		public static IGroupAiMonsterMemberActionTagAttach GetRootAsIGroupAiMonsterMemberActionTagAttach(ByteBuffer _bb, IGroupAiMonsterMemberActionTagAttach obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022DC0 RID: 142784 RVA: 0x004D44ED File Offset: 0x004D26ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022DC1 RID: 142785 RVA: 0x004D44FC File Offset: 0x004D26FC
		public IGroupAiMonsterMemberActionTagAttach __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C94 RID: 40084
		// (get) Token: 0x06022DC2 RID: 142786 RVA: 0x004D450C File Offset: 0x004D270C
		public string ActionTag
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022DC3 RID: 142787 RVA: 0x004D4543 File Offset: 0x004D2743
		public Span<byte> GetActionTagBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06022DC4 RID: 142788 RVA: 0x004D4552 File Offset: 0x004D2752
		public byte[] GetActionTagArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009C95 RID: 40085
		// (get) Token: 0x06022DC5 RID: 142789 RVA: 0x004D4560 File Offset: 0x004D2760
		public int AttachEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009C96 RID: 40086
		// (get) Token: 0x06022DC6 RID: 142790 RVA: 0x004D459C File Offset: 0x004D279C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022DC7 RID: 142791 RVA: 0x004D45D8 File Offset: 0x004D27D8
		public static Offset<IGroupAiMonsterMemberActionTagAttach> CreateIGroupAiMonsterMemberActionTagAttach(FlatBufferBuilder builder, StringOffset ActionTagOffset = default(StringOffset), int AttachEntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IGroupAiMonsterMemberActionTagAttach.AddAttachEntityId(builder, AttachEntityId);
			IGroupAiMonsterMemberActionTagAttach.AddActionTag(builder, ActionTagOffset);
			IGroupAiMonsterMemberActionTagAttach.AddNullMask(builder, NullMask);
			return IGroupAiMonsterMemberActionTagAttach.EndIGroupAiMonsterMemberActionTagAttach(builder);
		}

		// Token: 0x06022DC8 RID: 142792 RVA: 0x004D45FC File Offset: 0x004D27FC
		public static void StartIGroupAiMonsterMemberActionTagAttach(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022DC9 RID: 142793 RVA: 0x004D4605 File Offset: 0x004D2805
		public static void AddActionTag(FlatBufferBuilder builder, StringOffset actionTagOffset)
		{
			builder.AddOffset(0, actionTagOffset.Value, 0);
		}

		// Token: 0x06022DCA RID: 142794 RVA: 0x004D4615 File Offset: 0x004D2815
		public static void AddAttachEntityId(FlatBufferBuilder builder, int attachEntityId)
		{
			builder.AddInt(1, attachEntityId, 0);
		}

		// Token: 0x06022DCB RID: 142795 RVA: 0x004D4620 File Offset: 0x004D2820
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06022DCC RID: 142796 RVA: 0x004D462B File Offset: 0x004D282B
		public static Offset<IGroupAiMonsterMemberActionTagAttach> EndIGroupAiMonsterMemberActionTagAttach(FlatBufferBuilder builder)
		{
			return new Offset<IGroupAiMonsterMemberActionTagAttach>(builder.EndTable());
		}

		// Token: 0x06022DCD RID: 142797 RVA: 0x004D4638 File Offset: 0x004D2838
		public IGroupAiMonsterMemberActionTagAttachT UnPack()
		{
			IGroupAiMonsterMemberActionTagAttachT groupAiMonsterMemberActionTagAttachT = new IGroupAiMonsterMemberActionTagAttachT();
			this.UnPackTo(groupAiMonsterMemberActionTagAttachT);
			return groupAiMonsterMemberActionTagAttachT;
		}

		// Token: 0x06022DCE RID: 142798 RVA: 0x004D4653 File Offset: 0x004D2853
		public void UnPackTo(IGroupAiMonsterMemberActionTagAttachT _o)
		{
			_o.ActionTag = this.ActionTag;
			_o.AttachEntityId = this.AttachEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022DCF RID: 142799 RVA: 0x004D467C File Offset: 0x004D287C
		public static Offset<IGroupAiMonsterMemberActionTagAttach> Pack(FlatBufferBuilder builder, IGroupAiMonsterMemberActionTagAttachT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupAiMonsterMemberActionTagAttach>);
			}
			StringOffset actionTagOffset = (_o.ActionTag == null) ? default(StringOffset) : builder.CreateString(_o.ActionTag);
			return IGroupAiMonsterMemberActionTagAttach.CreateIGroupAiMonsterMemberActionTagAttach(builder, actionTagOffset, _o.AttachEntityId, _o.NullMask);
		}

		// Token: 0x0400E510 RID: 58640
		private Table __p;
	}
}
