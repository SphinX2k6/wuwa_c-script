using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FC8 RID: 4040
	[NetMessage(EMessageId.RogueResEndingRewardResponse)]
	public sealed class RogueResEndingRewardResponse : IMessage<RogueResEndingRewardResponse>, IMessage, IEquatable<RogueResEndingRewardResponse>, IDeepCloneable<RogueResEndingRewardResponse>, IBufferMessage
	{
		// Token: 0x060159F3 RID: 88563 RVA: 0x00323EF0 File Offset: 0x003220F0
		[NullableContext(1)]
		public static RogueResEndingRewardResponse Create()
		{
			return new RogueResEndingRewardResponse();
		}

		// Token: 0x17004820 RID: 18464
		// (get) Token: 0x060159F4 RID: 88564 RVA: 0x00323EF7 File Offset: 0x003220F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004821 RID: 18465
		// (get) Token: 0x060159F5 RID: 88565 RVA: 0x00323EFA File Offset: 0x003220FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResEndingRewardResponse.Descriptor;
			}
		}

		// Token: 0x060159F6 RID: 88566 RVA: 0x00323F01 File Offset: 0x00322101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResEndingRewardResponse()
		{
		}

		// Token: 0x060159F7 RID: 88567 RVA: 0x00323F09 File Offset: 0x00322109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResEndingRewardResponse(RogueResEndingRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060159F8 RID: 88568 RVA: 0x00323F2E File Offset: 0x0032212E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResEndingRewardResponse Clone()
		{
			return new RogueResEndingRewardResponse(this);
		}

		// Token: 0x17004822 RID: 18466
		// (get) Token: 0x060159F9 RID: 88569 RVA: 0x00323F36 File Offset: 0x00322136
		// (set) Token: 0x060159FA RID: 88570 RVA: 0x00323F3E File Offset: 0x0032213E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x060159FB RID: 88571 RVA: 0x00323F47 File Offset: 0x00322147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResEndingRewardResponse);
		}

		// Token: 0x060159FC RID: 88572 RVA: 0x00323F55 File Offset: 0x00322155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResEndingRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060159FD RID: 88573 RVA: 0x00323F84 File Offset: 0x00322184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060159FE RID: 88574 RVA: 0x00323FC9 File Offset: 0x003221C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060159FF RID: 88575 RVA: 0x00323FD6 File Offset: 0x003221D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015A00 RID: 88576 RVA: 0x00323FDF File Offset: 0x003221DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015A01 RID: 88577 RVA: 0x00324014 File Offset: 0x00322214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015A02 RID: 88578 RVA: 0x00324052 File Offset: 0x00322252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResEndingRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015A03 RID: 88579 RVA: 0x00324083 File Offset: 0x00322283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015A04 RID: 88580 RVA: 0x0032408C File Offset: 0x0032228C
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008244 RID: 33348
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008245 RID: 33349
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04008246 RID: 33350
		private ErrorCode errorCode_;
	}
}
