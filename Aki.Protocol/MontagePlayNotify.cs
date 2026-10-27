using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A08 RID: 2568
	[NetMessage(EMessageId.MontagePlayNotify)]
	public sealed class MontagePlayNotify : IMessage<MontagePlayNotify>, IMessage, IEquatable<MontagePlayNotify>, IDeepCloneable<MontagePlayNotify>, IBufferMessage
	{
		// Token: 0x0600E0B4 RID: 57524 RVA: 0x0020EB7E File Offset: 0x0020CD7E
		[NullableContext(1)]
		public static MontagePlayNotify Create()
		{
			return new MontagePlayNotify();
		}

		// Token: 0x17002D8D RID: 11661
		// (get) Token: 0x0600E0B5 RID: 57525 RVA: 0x0020EB85 File Offset: 0x0020CD85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D8E RID: 11662
		// (get) Token: 0x0600E0B6 RID: 57526 RVA: 0x0020EB88 File Offset: 0x0020CD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MontagePlayNotify.Descriptor;
			}
		}

		// Token: 0x0600E0B7 RID: 57527 RVA: 0x0020EB8F File Offset: 0x0020CD8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontagePlayNotify()
		{
		}

		// Token: 0x0600E0B8 RID: 57528 RVA: 0x0020EB97 File Offset: 0x0020CD97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontagePlayNotify(MontagePlayNotify other) : this()
		{
			this.skillId_ = other.skillId_;
			this.montageIndex_ = other.montageIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E0B9 RID: 57529 RVA: 0x0020EBC8 File Offset: 0x0020CDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontagePlayNotify Clone()
		{
			return new MontagePlayNotify(this);
		}

		// Token: 0x17002D8F RID: 11663
		// (get) Token: 0x0600E0BA RID: 57530 RVA: 0x0020EBD0 File Offset: 0x0020CDD0
		// (set) Token: 0x0600E0BB RID: 57531 RVA: 0x0020EBD8 File Offset: 0x0020CDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x17002D90 RID: 11664
		// (get) Token: 0x0600E0BC RID: 57532 RVA: 0x0020EBE1 File Offset: 0x0020CDE1
		// (set) Token: 0x0600E0BD RID: 57533 RVA: 0x0020EBE9 File Offset: 0x0020CDE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MontageIndex
		{
			get
			{
				return this.montageIndex_;
			}
			set
			{
				this.montageIndex_ = value;
			}
		}

		// Token: 0x0600E0BE RID: 57534 RVA: 0x0020EBF2 File Offset: 0x0020CDF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MontagePlayNotify);
		}

		// Token: 0x0600E0BF RID: 57535 RVA: 0x0020EC00 File Offset: 0x0020CE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MontagePlayNotify other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.MontageIndex == other.MontageIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E0C0 RID: 57536 RVA: 0x0020EC40 File Offset: 0x0020CE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.MontageIndex != 0)
			{
				num ^= this.MontageIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E0C1 RID: 57537 RVA: 0x0020EC98 File Offset: 0x0020CE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E0C2 RID: 57538 RVA: 0x0020ECA5 File Offset: 0x0020CEA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E0C3 RID: 57539 RVA: 0x0020ECB0 File Offset: 0x0020CEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MontageIndex != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.MontageIndex);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E0C4 RID: 57540 RVA: 0x0020ED0C File Offset: 0x0020CF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this.MontageIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MontageIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E0C5 RID: 57541 RVA: 0x0020ED64 File Offset: 0x0020CF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MontagePlayNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			if (other.MontageIndex != 0)
			{
				this.MontageIndex = other.MontageIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E0C6 RID: 57542 RVA: 0x0020EDB4 File Offset: 0x0020CFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E0C7 RID: 57543 RVA: 0x0020EDC0 File Offset: 0x0020CFC0
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
				if (num != 88U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkillId = input.ReadInt64();
					}
				}
				else
				{
					this.MontageIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005C74 RID: 23668
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C75 RID: 23669
		public const int SkillIdFieldNumber = 12;

		// Token: 0x04005C76 RID: 23670
		private long skillId_;

		// Token: 0x04005C77 RID: 23671
		public const int MontageIndexFieldNumber = 11;

		// Token: 0x04005C78 RID: 23672
		private int montageIndex_;
	}
}
