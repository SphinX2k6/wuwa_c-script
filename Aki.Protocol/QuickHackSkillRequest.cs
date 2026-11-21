using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E28 RID: 3624
	[NetMessage(EMessageId.QuickHackSkillRequest)]
	public sealed class QuickHackSkillRequest : IMessage<QuickHackSkillRequest>, IMessage, IEquatable<QuickHackSkillRequest>, IDeepCloneable<QuickHackSkillRequest>, IBufferMessage
	{
		// Token: 0x060137B8 RID: 79800 RVA: 0x002D53A2 File Offset: 0x002D35A2
		[NullableContext(1)]
		public static QuickHackSkillRequest Create()
		{
			return new QuickHackSkillRequest();
		}

		// Token: 0x1700409B RID: 16539
		// (get) Token: 0x060137B9 RID: 79801 RVA: 0x002D53A9 File Offset: 0x002D35A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700409C RID: 16540
		// (get) Token: 0x060137BA RID: 79802 RVA: 0x002D53AC File Offset: 0x002D35AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuickHackSkillRequest.Descriptor;
			}
		}

		// Token: 0x060137BB RID: 79803 RVA: 0x002D53B3 File Offset: 0x002D35B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackSkillRequest()
		{
		}

		// Token: 0x060137BC RID: 79804 RVA: 0x002D53BB File Offset: 0x002D35BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackSkillRequest(QuickHackSkillRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060137BD RID: 79805 RVA: 0x002D53EC File Offset: 0x002D35EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackSkillRequest Clone()
		{
			return new QuickHackSkillRequest(this);
		}

		// Token: 0x1700409D RID: 16541
		// (get) Token: 0x060137BE RID: 79806 RVA: 0x002D53F4 File Offset: 0x002D35F4
		// (set) Token: 0x060137BF RID: 79807 RVA: 0x002D53FC File Offset: 0x002D35FC
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

		// Token: 0x1700409E RID: 16542
		// (get) Token: 0x060137C0 RID: 79808 RVA: 0x002D5405 File Offset: 0x002D3605
		// (set) Token: 0x060137C1 RID: 79809 RVA: 0x002D540D File Offset: 0x002D360D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
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

		// Token: 0x060137C2 RID: 79810 RVA: 0x002D5416 File Offset: 0x002D3616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuickHackSkillRequest);
		}

		// Token: 0x060137C3 RID: 79811 RVA: 0x002D5424 File Offset: 0x002D3624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuickHackSkillRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060137C4 RID: 79812 RVA: 0x002D5464 File Offset: 0x002D3664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060137C5 RID: 79813 RVA: 0x002D54BC File Offset: 0x002D36BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060137C6 RID: 79814 RVA: 0x002D54C9 File Offset: 0x002D36C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060137C7 RID: 79815 RVA: 0x002D54D4 File Offset: 0x002D36D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SkillId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060137C8 RID: 79816 RVA: 0x002D5530 File Offset: 0x002D3730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060137C9 RID: 79817 RVA: 0x002D5588 File Offset: 0x002D3788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuickHackSkillRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060137CA RID: 79818 RVA: 0x002D55D8 File Offset: 0x002D37D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060137CB RID: 79819 RVA: 0x002D55E4 File Offset: 0x002D37E4
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
				if (num != 56U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.SkillId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040077BF RID: 30655
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077C0 RID: 30656
		public const int EntityIdFieldNumber = 15;

		// Token: 0x040077C1 RID: 30657
		private long entityId_;

		// Token: 0x040077C2 RID: 30658
		public const int SkillIdFieldNumber = 7;

		// Token: 0x040077C3 RID: 30659
		private int skillId_;
	}
}
