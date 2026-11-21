using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DBE RID: 3518
	[NetMessage(EMessageId.PreheatSignRewardRequest)]
	public sealed class PreheatSignRewardRequest : IMessage<PreheatSignRewardRequest>, IMessage, IEquatable<PreheatSignRewardRequest>, IDeepCloneable<PreheatSignRewardRequest>, IBufferMessage
	{
		// Token: 0x06012F82 RID: 77698 RVA: 0x002C4756 File Offset: 0x002C2956
		[NullableContext(1)]
		public static PreheatSignRewardRequest Create()
		{
			return new PreheatSignRewardRequest();
		}

		// Token: 0x17003EF7 RID: 16119
		// (get) Token: 0x06012F83 RID: 77699 RVA: 0x002C475D File Offset: 0x002C295D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EF8 RID: 16120
		// (get) Token: 0x06012F84 RID: 77700 RVA: 0x002C4760 File Offset: 0x002C2960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PreheatSignRewardRequest.Descriptor;
			}
		}

		// Token: 0x06012F85 RID: 77701 RVA: 0x002C4767 File Offset: 0x002C2967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignRewardRequest()
		{
		}

		// Token: 0x06012F86 RID: 77702 RVA: 0x002C476F File Offset: 0x002C296F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignRewardRequest(PreheatSignRewardRequest other) : this()
		{
			this.preheatNodeId_ = other.preheatNodeId_;
			this.answerStatus_ = other.answerStatus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012F87 RID: 77703 RVA: 0x002C47A0 File Offset: 0x002C29A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignRewardRequest Clone()
		{
			return new PreheatSignRewardRequest(this);
		}

		// Token: 0x17003EF9 RID: 16121
		// (get) Token: 0x06012F88 RID: 77704 RVA: 0x002C47A8 File Offset: 0x002C29A8
		// (set) Token: 0x06012F89 RID: 77705 RVA: 0x002C47B0 File Offset: 0x002C29B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PreheatNodeId
		{
			get
			{
				return this.preheatNodeId_;
			}
			set
			{
				this.preheatNodeId_ = value;
			}
		}

		// Token: 0x17003EFA RID: 16122
		// (get) Token: 0x06012F8A RID: 77706 RVA: 0x002C47B9 File Offset: 0x002C29B9
		// (set) Token: 0x06012F8B RID: 77707 RVA: 0x002C47C1 File Offset: 0x002C29C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AnswerStatus
		{
			get
			{
				return this.answerStatus_;
			}
			set
			{
				this.answerStatus_ = value;
			}
		}

		// Token: 0x06012F8C RID: 77708 RVA: 0x002C47CA File Offset: 0x002C29CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PreheatSignRewardRequest);
		}

		// Token: 0x06012F8D RID: 77709 RVA: 0x002C47D8 File Offset: 0x002C29D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PreheatSignRewardRequest other)
		{
			return other != null && (other == this || (this.PreheatNodeId == other.PreheatNodeId && this.AnswerStatus == other.AnswerStatus && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012F8E RID: 77710 RVA: 0x002C4818 File Offset: 0x002C2A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PreheatNodeId != 0)
			{
				num ^= this.PreheatNodeId.GetHashCode();
			}
			if (this.AnswerStatus)
			{
				num ^= this.AnswerStatus.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012F8F RID: 77711 RVA: 0x002C4870 File Offset: 0x002C2A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012F90 RID: 77712 RVA: 0x002C487D File Offset: 0x002C2A7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012F91 RID: 77713 RVA: 0x002C4888 File Offset: 0x002C2A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AnswerStatus)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.AnswerStatus);
			}
			if (this.PreheatNodeId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PreheatNodeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012F92 RID: 77714 RVA: 0x002C48E4 File Offset: 0x002C2AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PreheatNodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PreheatNodeId);
			}
			if (this.AnswerStatus)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012F93 RID: 77715 RVA: 0x002C4930 File Offset: 0x002C2B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PreheatSignRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PreheatNodeId != 0)
			{
				this.PreheatNodeId = other.PreheatNodeId;
			}
			if (other.AnswerStatus)
			{
				this.AnswerStatus = other.AnswerStatus;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012F94 RID: 77716 RVA: 0x002C4980 File Offset: 0x002C2B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012F95 RID: 77717 RVA: 0x002C498C File Offset: 0x002C2B8C
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PreheatNodeId = input.ReadInt32();
					}
				}
				else
				{
					this.AnswerStatus = input.ReadBool();
				}
			}
		}

		// Token: 0x040075A2 RID: 30114
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075A3 RID: 30115
		public const int PreheatNodeIdFieldNumber = 13;

		// Token: 0x040075A4 RID: 30116
		private int preheatNodeId_;

		// Token: 0x040075A5 RID: 30117
		public const int AnswerStatusFieldNumber = 7;

		// Token: 0x040075A6 RID: 30118
		private bool answerStatus_;
	}
}
