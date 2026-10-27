using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FCD RID: 4045
	[NetMessage(EMessageId.RoguelikeWriteCatRewardResponse)]
	public sealed class RoguelikeWriteCatRewardResponse : IMessage<RoguelikeWriteCatRewardResponse>, IMessage, IEquatable<RoguelikeWriteCatRewardResponse>, IDeepCloneable<RoguelikeWriteCatRewardResponse>, IBufferMessage
	{
		// Token: 0x060159F4 RID: 88564 RVA: 0x003235D8 File Offset: 0x003217D8
		[NullableContext(1)]
		public static RoguelikeWriteCatRewardResponse Create()
		{
			return new RoguelikeWriteCatRewardResponse();
		}

		// Token: 0x1700481A RID: 18458
		// (get) Token: 0x060159F5 RID: 88565 RVA: 0x003235DF File Offset: 0x003217DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700481B RID: 18459
		// (get) Token: 0x060159F6 RID: 88566 RVA: 0x003235E2 File Offset: 0x003217E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeWriteCatRewardResponse.Descriptor;
			}
		}

		// Token: 0x060159F7 RID: 88567 RVA: 0x003235E9 File Offset: 0x003217E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatRewardResponse()
		{
		}

		// Token: 0x060159F8 RID: 88568 RVA: 0x003235F1 File Offset: 0x003217F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatRewardResponse(RoguelikeWriteCatRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060159F9 RID: 88569 RVA: 0x00323616 File Offset: 0x00321816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatRewardResponse Clone()
		{
			return new RoguelikeWriteCatRewardResponse(this);
		}

		// Token: 0x1700481C RID: 18460
		// (get) Token: 0x060159FA RID: 88570 RVA: 0x0032361E File Offset: 0x0032181E
		// (set) Token: 0x060159FB RID: 88571 RVA: 0x00323626 File Offset: 0x00321826
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

		// Token: 0x060159FC RID: 88572 RVA: 0x0032362F File Offset: 0x0032182F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeWriteCatRewardResponse);
		}

		// Token: 0x060159FD RID: 88573 RVA: 0x0032363D File Offset: 0x0032183D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeWriteCatRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060159FE RID: 88574 RVA: 0x0032366C File Offset: 0x0032186C
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

		// Token: 0x060159FF RID: 88575 RVA: 0x003236B1 File Offset: 0x003218B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015A00 RID: 88576 RVA: 0x003236BE File Offset: 0x003218BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015A01 RID: 88577 RVA: 0x003236C7 File Offset: 0x003218C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015A02 RID: 88578 RVA: 0x003236FC File Offset: 0x003218FC
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

		// Token: 0x06015A03 RID: 88579 RVA: 0x0032373A File Offset: 0x0032193A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeWriteCatRewardResponse other)
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

		// Token: 0x06015A04 RID: 88580 RVA: 0x0032376B File Offset: 0x0032196B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015A05 RID: 88581 RVA: 0x00323774 File Offset: 0x00321974
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040081D7 RID: 33239
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081D8 RID: 33240
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040081D9 RID: 33241
		private ErrorCode errorCode_;
	}
}
