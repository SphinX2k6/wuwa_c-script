using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E38 RID: 3640
	[NetMessage(EMessageId.QuickHackSkillRequest)]
	public sealed class QuickHackSkillRequest : IMessage<QuickHackSkillRequest>, IMessage, IEquatable<QuickHackSkillRequest>, IDeepCloneable<QuickHackSkillRequest>, IBufferMessage
	{
		// Token: 0x0601389D RID: 80029 RVA: 0x002D6A62 File Offset: 0x002D4C62
		[NullableContext(1)]
		public static QuickHackSkillRequest Create()
		{
			return new QuickHackSkillRequest();
		}

		// Token: 0x170040C5 RID: 16581
		// (get) Token: 0x0601389E RID: 80030 RVA: 0x002D6A69 File Offset: 0x002D4C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040C6 RID: 16582
		// (get) Token: 0x0601389F RID: 80031 RVA: 0x002D6A6C File Offset: 0x002D4C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuickHackSkillRequest.Descriptor;
			}
		}

		// Token: 0x060138A0 RID: 80032 RVA: 0x002D6A73 File Offset: 0x002D4C73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackSkillRequest()
		{
		}

		// Token: 0x060138A1 RID: 80033 RVA: 0x002D6A7B File Offset: 0x002D4C7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackSkillRequest(QuickHackSkillRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060138A2 RID: 80034 RVA: 0x002D6AAC File Offset: 0x002D4CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackSkillRequest Clone()
		{
			return new QuickHackSkillRequest(this);
		}

		// Token: 0x170040C7 RID: 16583
		// (get) Token: 0x060138A3 RID: 80035 RVA: 0x002D6AB4 File Offset: 0x002D4CB4
		// (set) Token: 0x060138A4 RID: 80036 RVA: 0x002D6ABC File Offset: 0x002D4CBC
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

		// Token: 0x170040C8 RID: 16584
		// (get) Token: 0x060138A5 RID: 80037 RVA: 0x002D6AC5 File Offset: 0x002D4CC5
		// (set) Token: 0x060138A6 RID: 80038 RVA: 0x002D6ACD File Offset: 0x002D4CCD
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

		// Token: 0x060138A7 RID: 80039 RVA: 0x002D6AD6 File Offset: 0x002D4CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuickHackSkillRequest);
		}

		// Token: 0x060138A8 RID: 80040 RVA: 0x002D6AE4 File Offset: 0x002D4CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuickHackSkillRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060138A9 RID: 80041 RVA: 0x002D6B24 File Offset: 0x002D4D24
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

		// Token: 0x060138AA RID: 80042 RVA: 0x002D6B7C File Offset: 0x002D4D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060138AB RID: 80043 RVA: 0x002D6B89 File Offset: 0x002D4D89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060138AC RID: 80044 RVA: 0x002D6B94 File Offset: 0x002D4D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060138AD RID: 80045 RVA: 0x002D6BF0 File Offset: 0x002D4DF0
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

		// Token: 0x060138AE RID: 80046 RVA: 0x002D6C48 File Offset: 0x002D4E48
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

		// Token: 0x060138AF RID: 80047 RVA: 0x002D6C98 File Offset: 0x002D4E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060138B0 RID: 80048 RVA: 0x002D6CA4 File Offset: 0x002D4EA4
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
				if (num != 40U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkillId = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007795 RID: 30613
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007796 RID: 30614
		public const int EntityIdFieldNumber = 5;

		// Token: 0x04007797 RID: 30615
		private long entityId_;

		// Token: 0x04007798 RID: 30616
		public const int SkillIdFieldNumber = 14;

		// Token: 0x04007799 RID: 30617
		private int skillId_;
	}
}
