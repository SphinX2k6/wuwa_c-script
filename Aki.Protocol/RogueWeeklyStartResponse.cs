using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200104A RID: 4170
	[NetMessage(EMessageId.RogueWeeklyStartResponse)]
	public sealed class RogueWeeklyStartResponse : IMessage<RogueWeeklyStartResponse>, IMessage, IEquatable<RogueWeeklyStartResponse>, IDeepCloneable<RogueWeeklyStartResponse>, IBufferMessage
	{
		// Token: 0x0601647C RID: 91260 RVA: 0x0033C81C File Offset: 0x0033AA1C
		[NullableContext(1)]
		public static RogueWeeklyStartResponse Create()
		{
			return new RogueWeeklyStartResponse();
		}

		// Token: 0x17004A7D RID: 19069
		// (get) Token: 0x0601647D RID: 91261 RVA: 0x0033C823 File Offset: 0x0033AA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A7E RID: 19070
		// (get) Token: 0x0601647E RID: 91262 RVA: 0x0033C826 File Offset: 0x0033AA26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyStartResponse.Descriptor;
			}
		}

		// Token: 0x0601647F RID: 91263 RVA: 0x0033C82D File Offset: 0x0033AA2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyStartResponse()
		{
		}

		// Token: 0x06016480 RID: 91264 RVA: 0x0033C835 File Offset: 0x0033AA35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyStartResponse(RogueWeeklyStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016481 RID: 91265 RVA: 0x0033C85A File Offset: 0x0033AA5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyStartResponse Clone()
		{
			return new RogueWeeklyStartResponse(this);
		}

		// Token: 0x17004A7F RID: 19071
		// (get) Token: 0x06016482 RID: 91266 RVA: 0x0033C862 File Offset: 0x0033AA62
		// (set) Token: 0x06016483 RID: 91267 RVA: 0x0033C86A File Offset: 0x0033AA6A
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

		// Token: 0x06016484 RID: 91268 RVA: 0x0033C873 File Offset: 0x0033AA73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyStartResponse);
		}

		// Token: 0x06016485 RID: 91269 RVA: 0x0033C881 File Offset: 0x0033AA81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016486 RID: 91270 RVA: 0x0033C8B0 File Offset: 0x0033AAB0
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

		// Token: 0x06016487 RID: 91271 RVA: 0x0033C8F5 File Offset: 0x0033AAF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016488 RID: 91272 RVA: 0x0033C902 File Offset: 0x0033AB02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016489 RID: 91273 RVA: 0x0033C90B File Offset: 0x0033AB0B
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

		// Token: 0x0601648A RID: 91274 RVA: 0x0033C940 File Offset: 0x0033AB40
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

		// Token: 0x0601648B RID: 91275 RVA: 0x0033C97E File Offset: 0x0033AB7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyStartResponse other)
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

		// Token: 0x0601648C RID: 91276 RVA: 0x0033C9AF File Offset: 0x0033ABAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601648D RID: 91277 RVA: 0x0033C9B8 File Offset: 0x0033ABB8
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

		// Token: 0x0400853D RID: 34109
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400853E RID: 34110
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400853F RID: 34111
		private ErrorCode errorCode_;
	}
}
