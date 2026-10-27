using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FBC RID: 4028
	[NetMessage(EMessageId.RoguelikeStartResponse)]
	public sealed class RoguelikeStartResponse : IMessage<RoguelikeStartResponse>, IMessage, IEquatable<RoguelikeStartResponse>, IDeepCloneable<RoguelikeStartResponse>, IBufferMessage
	{
		// Token: 0x06015895 RID: 88213 RVA: 0x003204DE File Offset: 0x0031E6DE
		[NullableContext(1)]
		public static RoguelikeStartResponse Create()
		{
			return new RoguelikeStartResponse();
		}

		// Token: 0x170047CF RID: 18383
		// (get) Token: 0x06015896 RID: 88214 RVA: 0x003204E5 File Offset: 0x0031E6E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047D0 RID: 18384
		// (get) Token: 0x06015897 RID: 88215 RVA: 0x003204E8 File Offset: 0x0031E6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeStartResponse.Descriptor;
			}
		}

		// Token: 0x06015898 RID: 88216 RVA: 0x003204EF File Offset: 0x0031E6EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeStartResponse()
		{
		}

		// Token: 0x06015899 RID: 88217 RVA: 0x003204F7 File Offset: 0x0031E6F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeStartResponse(RoguelikeStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601589A RID: 88218 RVA: 0x0032051C File Offset: 0x0031E71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeStartResponse Clone()
		{
			return new RoguelikeStartResponse(this);
		}

		// Token: 0x170047D1 RID: 18385
		// (get) Token: 0x0601589B RID: 88219 RVA: 0x00320524 File Offset: 0x0031E724
		// (set) Token: 0x0601589C RID: 88220 RVA: 0x0032052C File Offset: 0x0031E72C
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

		// Token: 0x0601589D RID: 88221 RVA: 0x00320535 File Offset: 0x0031E735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeStartResponse);
		}

		// Token: 0x0601589E RID: 88222 RVA: 0x00320543 File Offset: 0x0031E743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601589F RID: 88223 RVA: 0x00320574 File Offset: 0x0031E774
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

		// Token: 0x060158A0 RID: 88224 RVA: 0x003205B9 File Offset: 0x0031E7B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060158A1 RID: 88225 RVA: 0x003205C6 File Offset: 0x0031E7C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060158A2 RID: 88226 RVA: 0x003205CF File Offset: 0x0031E7CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060158A3 RID: 88227 RVA: 0x00320604 File Offset: 0x0031E804
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

		// Token: 0x060158A4 RID: 88228 RVA: 0x00320642 File Offset: 0x0031E842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeStartResponse other)
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

		// Token: 0x060158A5 RID: 88229 RVA: 0x00320673 File Offset: 0x0031E873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060158A6 RID: 88230 RVA: 0x0032067C File Offset: 0x0031E87C
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400816D RID: 33133
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400816E RID: 33134
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x0400816F RID: 33135
		private ErrorCode errorCode_;
	}
}
