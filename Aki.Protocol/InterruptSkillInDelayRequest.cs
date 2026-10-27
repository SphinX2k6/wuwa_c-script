using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000837 RID: 2103
	[NetMessage(EMessageId.InterruptSkillInDelayRequest)]
	public sealed class InterruptSkillInDelayRequest : IMessage<InterruptSkillInDelayRequest>, IMessage, IEquatable<InterruptSkillInDelayRequest>, IDeepCloneable<InterruptSkillInDelayRequest>, IBufferMessage
	{
		// Token: 0x0600BBDA RID: 48090 RVA: 0x001BF431 File Offset: 0x001BD631
		[NullableContext(1)]
		public static InterruptSkillInDelayRequest Create()
		{
			return new InterruptSkillInDelayRequest();
		}

		// Token: 0x170025EE RID: 9710
		// (get) Token: 0x0600BBDB RID: 48091 RVA: 0x001BF438 File Offset: 0x001BD638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025EF RID: 9711
		// (get) Token: 0x0600BBDC RID: 48092 RVA: 0x001BF43B File Offset: 0x001BD63B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InterruptSkillInDelayRequest.Descriptor;
			}
		}

		// Token: 0x0600BBDD RID: 48093 RVA: 0x001BF442 File Offset: 0x001BD642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInDelayRequest()
		{
		}

		// Token: 0x0600BBDE RID: 48094 RVA: 0x001BF44A File Offset: 0x001BD64A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInDelayRequest(InterruptSkillInDelayRequest other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BBDF RID: 48095 RVA: 0x001BF46F File Offset: 0x001BD66F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInDelayRequest Clone()
		{
			return new InterruptSkillInDelayRequest(this);
		}

		// Token: 0x170025F0 RID: 9712
		// (get) Token: 0x0600BBE0 RID: 48096 RVA: 0x001BF477 File Offset: 0x001BD677
		// (set) Token: 0x0600BBE1 RID: 48097 RVA: 0x001BF47F File Offset: 0x001BD67F
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

		// Token: 0x0600BBE2 RID: 48098 RVA: 0x001BF488 File Offset: 0x001BD688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InterruptSkillInDelayRequest);
		}

		// Token: 0x0600BBE3 RID: 48099 RVA: 0x001BF496 File Offset: 0x001BD696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InterruptSkillInDelayRequest other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BBE4 RID: 48100 RVA: 0x001BF4C4 File Offset: 0x001BD6C4
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

		// Token: 0x0600BBE5 RID: 48101 RVA: 0x001BF503 File Offset: 0x001BD703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BBE6 RID: 48102 RVA: 0x001BF510 File Offset: 0x001BD710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BBE7 RID: 48103 RVA: 0x001BF519 File Offset: 0x001BD719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BBE8 RID: 48104 RVA: 0x001BF54C File Offset: 0x001BD74C
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

		// Token: 0x0600BBE9 RID: 48105 RVA: 0x001BF58A File Offset: 0x001BD78A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InterruptSkillInDelayRequest other)
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

		// Token: 0x0600BBEA RID: 48106 RVA: 0x001BF5BB File Offset: 0x001BD7BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BBEB RID: 48107 RVA: 0x001BF5C4 File Offset: 0x001BD7C4
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkillId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400525F RID: 21087
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005260 RID: 21088
		public const int SkillIdFieldNumber = 14;

		// Token: 0x04005261 RID: 21089
		private long skillId_;
	}
}
