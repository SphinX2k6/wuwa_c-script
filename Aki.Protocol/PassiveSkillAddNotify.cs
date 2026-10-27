using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BCB RID: 3019
	[NetMessage(EMessageId.PassiveSkillAddNotify)]
	public sealed class PassiveSkillAddNotify : IMessage<PassiveSkillAddNotify>, IMessage, IEquatable<PassiveSkillAddNotify>, IDeepCloneable<PassiveSkillAddNotify>, IBufferMessage
	{
		// Token: 0x060105AD RID: 66989 RVA: 0x00262B19 File Offset: 0x00260D19
		[NullableContext(1)]
		public static PassiveSkillAddNotify Create()
		{
			return new PassiveSkillAddNotify();
		}

		// Token: 0x170035A3 RID: 13731
		// (get) Token: 0x060105AE RID: 66990 RVA: 0x00262B20 File Offset: 0x00260D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035A4 RID: 13732
		// (get) Token: 0x060105AF RID: 66991 RVA: 0x00262B23 File Offset: 0x00260D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillAddNotify.Descriptor;
			}
		}

		// Token: 0x060105B0 RID: 66992 RVA: 0x00262B2A File Offset: 0x00260D2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddNotify()
		{
		}

		// Token: 0x060105B1 RID: 66993 RVA: 0x00262B3D File Offset: 0x00260D3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddNotify(PassiveSkillAddNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.passiveSkillItemPbList_ = other.passiveSkillItemPbList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060105B2 RID: 66994 RVA: 0x00262B73 File Offset: 0x00260D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddNotify Clone()
		{
			return new PassiveSkillAddNotify(this);
		}

		// Token: 0x170035A5 RID: 13733
		// (get) Token: 0x060105B3 RID: 66995 RVA: 0x00262B7B File Offset: 0x00260D7B
		// (set) Token: 0x060105B4 RID: 66996 RVA: 0x00262B83 File Offset: 0x00260D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170035A6 RID: 13734
		// (get) Token: 0x060105B5 RID: 66997 RVA: 0x00262B8C File Offset: 0x00260D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PassiveSkillItemPb> PassiveSkillItemPbList
		{
			get
			{
				return this.passiveSkillItemPbList_;
			}
		}

		// Token: 0x060105B6 RID: 66998 RVA: 0x00262B94 File Offset: 0x00260D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillAddNotify);
		}

		// Token: 0x060105B7 RID: 66999 RVA: 0x00262BA4 File Offset: 0x00260DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillAddNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.passiveSkillItemPbList_.Equals(other.passiveSkillItemPbList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060105B8 RID: 67000 RVA: 0x00262BF4 File Offset: 0x00260DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.passiveSkillItemPbList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060105B9 RID: 67001 RVA: 0x00262C41 File Offset: 0x00260E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060105BA RID: 67002 RVA: 0x00262C4E File Offset: 0x00260E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060105BB RID: 67003 RVA: 0x00262C58 File Offset: 0x00260E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			this.passiveSkillItemPbList_.WriteTo(ref output, PassiveSkillAddNotify._repeated_passiveSkillItemPbList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060105BC RID: 67004 RVA: 0x00262CA8 File Offset: 0x00260EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.passiveSkillItemPbList_.CalculateSize(PassiveSkillAddNotify._repeated_passiveSkillItemPbList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060105BD RID: 67005 RVA: 0x00262CFC File Offset: 0x00260EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PassiveSkillAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.passiveSkillItemPbList_.Add(other.passiveSkillItemPbList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060105BE RID: 67006 RVA: 0x00262D49 File Offset: 0x00260F49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060105BF RID: 67007 RVA: 0x00262D54 File Offset: 0x00260F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 8U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.passiveSkillItemPbList_.AddEntriesFrom(ref input, PassiveSkillAddNotify._repeated_passiveSkillItemPbList_codec);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040067DE RID: 26590
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067DF RID: 26591
		public const int EntityIdFieldNumber = 1;

		// Token: 0x040067E0 RID: 26592
		private long entityId_;

		// Token: 0x040067E1 RID: 26593
		public const int PassiveSkillItemPbListFieldNumber = 11;

		// Token: 0x040067E2 RID: 26594
		private static readonly FieldCodec<PassiveSkillItemPb> _repeated_passiveSkillItemPbList_codec = FieldCodec.ForMessage<PassiveSkillItemPb>(90U, PassiveSkillItemPb.Parser);

		// Token: 0x040067E3 RID: 26595
		private readonly RepeatedField<PassiveSkillItemPb> passiveSkillItemPbList_ = new RepeatedField<PassiveSkillItemPb>();
	}
}
