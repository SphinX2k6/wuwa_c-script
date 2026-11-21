using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058CA RID: 22730
	public struct IGroupAiMonsterMemberActionTagAttach : IFlatbufferObject
	{
		// Token: 0x1700A4CB RID: 42187
		// (get) Token: 0x06024E70 RID: 151152 RVA: 0x00511372 File Offset: 0x0050F572
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024E71 RID: 151153 RVA: 0x0051137F File Offset: 0x0050F57F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024E72 RID: 151154 RVA: 0x00511388 File Offset: 0x0050F588
		public static IGroupAiMonsterMemberActionTagAttach GetRootAsIGroupAiMonsterMemberActionTagAttach(ByteBuffer _bb)
		{
			return IGroupAiMonsterMemberActionTagAttach.GetRootAsIGroupAiMonsterMemberActionTagAttach(_bb, default(IGroupAiMonsterMemberActionTagAttach));
		}

		// Token: 0x06024E73 RID: 151155 RVA: 0x005113A4 File Offset: 0x0050F5A4
		public static IGroupAiMonsterMemberActionTagAttach GetRootAsIGroupAiMonsterMemberActionTagAttach(ByteBuffer _bb, IGroupAiMonsterMemberActionTagAttach obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024E74 RID: 151156 RVA: 0x005113C1 File Offset: 0x0050F5C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024E75 RID: 151157 RVA: 0x005113D0 File Offset: 0x0050F5D0
		public IGroupAiMonsterMemberActionTagAttach __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4CC RID: 42188
		// (get) Token: 0x06024E76 RID: 151158 RVA: 0x005113E0 File Offset: 0x0050F5E0
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

		// Token: 0x06024E77 RID: 151159 RVA: 0x00511417 File Offset: 0x0050F617
		public Span<byte> GetActionTagBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06024E78 RID: 151160 RVA: 0x00511426 File Offset: 0x0050F626
		public byte[] GetActionTagArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A4CD RID: 42189
		// (get) Token: 0x06024E79 RID: 151161 RVA: 0x00511434 File Offset: 0x0050F634
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

		// Token: 0x1700A4CE RID: 42190
		// (get) Token: 0x06024E7A RID: 151162 RVA: 0x00511470 File Offset: 0x0050F670
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

		// Token: 0x06024E7B RID: 151163 RVA: 0x005114AC File Offset: 0x0050F6AC
		public static Offset<IGroupAiMonsterMemberActionTagAttach> CreateIGroupAiMonsterMemberActionTagAttach(FlatBufferBuilder builder, StringOffset ActionTagOffset = default(StringOffset), int AttachEntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IGroupAiMonsterMemberActionTagAttach.AddAttachEntityId(builder, AttachEntityId);
			IGroupAiMonsterMemberActionTagAttach.AddActionTag(builder, ActionTagOffset);
			IGroupAiMonsterMemberActionTagAttach.AddNullMask(builder, NullMask);
			return IGroupAiMonsterMemberActionTagAttach.EndIGroupAiMonsterMemberActionTagAttach(builder);
		}

		// Token: 0x06024E7C RID: 151164 RVA: 0x005114D0 File Offset: 0x0050F6D0
		public static void StartIGroupAiMonsterMemberActionTagAttach(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024E7D RID: 151165 RVA: 0x005114D9 File Offset: 0x0050F6D9
		public static void AddActionTag(FlatBufferBuilder builder, StringOffset actionTagOffset)
		{
			builder.AddOffset(0, actionTagOffset.Value, 0);
		}

		// Token: 0x06024E7E RID: 151166 RVA: 0x005114E9 File Offset: 0x0050F6E9
		public static void AddAttachEntityId(FlatBufferBuilder builder, int attachEntityId)
		{
			builder.AddInt(1, attachEntityId, 0);
		}

		// Token: 0x06024E7F RID: 151167 RVA: 0x005114F4 File Offset: 0x0050F6F4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06024E80 RID: 151168 RVA: 0x005114FF File Offset: 0x0050F6FF
		public static Offset<IGroupAiMonsterMemberActionTagAttach> EndIGroupAiMonsterMemberActionTagAttach(FlatBufferBuilder builder)
		{
			return new Offset<IGroupAiMonsterMemberActionTagAttach>(builder.EndTable());
		}

		// Token: 0x06024E81 RID: 151169 RVA: 0x0051150C File Offset: 0x0050F70C
		public IGroupAiMonsterMemberActionTagAttachT UnPack()
		{
			IGroupAiMonsterMemberActionTagAttachT groupAiMonsterMemberActionTagAttachT = new IGroupAiMonsterMemberActionTagAttachT();
			this.UnPackTo(groupAiMonsterMemberActionTagAttachT);
			return groupAiMonsterMemberActionTagAttachT;
		}

		// Token: 0x06024E82 RID: 151170 RVA: 0x00511527 File Offset: 0x0050F727
		public void UnPackTo(IGroupAiMonsterMemberActionTagAttachT _o)
		{
			_o.ActionTag = this.ActionTag;
			_o.AttachEntityId = this.AttachEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024E83 RID: 151171 RVA: 0x00511550 File Offset: 0x0050F750
		public static Offset<IGroupAiMonsterMemberActionTagAttach> Pack(FlatBufferBuilder builder, IGroupAiMonsterMemberActionTagAttachT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupAiMonsterMemberActionTagAttach>);
			}
			StringOffset actionTagOffset = (_o.ActionTag == null) ? default(StringOffset) : builder.CreateString(_o.ActionTag);
			return IGroupAiMonsterMemberActionTagAttach.CreateIGroupAiMonsterMemberActionTagAttach(builder, actionTagOffset, _o.AttachEntityId, _o.NullMask);
		}

		// Token: 0x0400F140 RID: 61760
		private Table __p;
	}
}
