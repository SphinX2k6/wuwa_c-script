using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000822 RID: 2082
	[NetMessage(EMessageId.InterruptSkillInDelayPush)]
	public sealed class InterruptSkillInDelayPush : IMessage<InterruptSkillInDelayPush>, IMessage, IEquatable<InterruptSkillInDelayPush>, IDeepCloneable<InterruptSkillInDelayPush>, IBufferMessage
	{
		// Token: 0x0600BA72 RID: 47730 RVA: 0x001BC81C File Offset: 0x001BAA1C
		[NullableContext(1)]
		public static InterruptSkillInDelayPush Create()
		{
			return new InterruptSkillInDelayPush();
		}

		// Token: 0x170025A1 RID: 9633
		// (get) Token: 0x0600BA73 RID: 47731 RVA: 0x001BC823 File Offset: 0x001BAA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025A2 RID: 9634
		// (get) Token: 0x0600BA74 RID: 47732 RVA: 0x001BC826 File Offset: 0x001BAA26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InterruptSkillInDelayPush.Descriptor;
			}
		}

		// Token: 0x0600BA75 RID: 47733 RVA: 0x001BC82D File Offset: 0x001BAA2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInDelayPush()
		{
		}

		// Token: 0x0600BA76 RID: 47734 RVA: 0x001BC835 File Offset: 0x001BAA35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInDelayPush(InterruptSkillInDelayPush other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BA77 RID: 47735 RVA: 0x001BC85A File Offset: 0x001BAA5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInDelayPush Clone()
		{
			return new InterruptSkillInDelayPush(this);
		}

		// Token: 0x170025A3 RID: 9635
		// (get) Token: 0x0600BA78 RID: 47736 RVA: 0x001BC862 File Offset: 0x001BAA62
		// (set) Token: 0x0600BA79 RID: 47737 RVA: 0x001BC86A File Offset: 0x001BAA6A
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

		// Token: 0x0600BA7A RID: 47738 RVA: 0x001BC873 File Offset: 0x001BAA73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InterruptSkillInDelayPush);
		}

		// Token: 0x0600BA7B RID: 47739 RVA: 0x001BC881 File Offset: 0x001BAA81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InterruptSkillInDelayPush other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BA7C RID: 47740 RVA: 0x001BC8B0 File Offset: 0x001BAAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BA7D RID: 47741 RVA: 0x001BC8EF File Offset: 0x001BAAEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BA7E RID: 47742 RVA: 0x001BC8FC File Offset: 0x001BAAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BA7F RID: 47743 RVA: 0x001BC905 File Offset: 0x001BAB05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BA80 RID: 47744 RVA: 0x001BC938 File Offset: 0x001BAB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BA81 RID: 47745 RVA: 0x001BC976 File Offset: 0x001BAB76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InterruptSkillInDelayPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BA82 RID: 47746 RVA: 0x001BC9A7 File Offset: 0x001BABA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BA83 RID: 47747 RVA: 0x001BC9B0 File Offset: 0x001BABB0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkillId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04005255 RID: 21077
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005256 RID: 21078
		public const int SkillIdFieldNumber = 5;

		// Token: 0x04005257 RID: 21079
		private long skillId_;
	}
}
