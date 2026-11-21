using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FBD RID: 4029
	[NetMessage(EMessageId.RoguelikeWriteCatRewardResponse)]
	public sealed class RoguelikeWriteCatRewardResponse : IMessage<RoguelikeWriteCatRewardResponse>, IMessage, IEquatable<RoguelikeWriteCatRewardResponse>, IDeepCloneable<RoguelikeWriteCatRewardResponse>, IBufferMessage
	{
		// Token: 0x0601590F RID: 88335 RVA: 0x00321F24 File Offset: 0x00320124
		[NullableContext(1)]
		public static RoguelikeWriteCatRewardResponse Create()
		{
			return new RoguelikeWriteCatRewardResponse();
		}

		// Token: 0x170047F0 RID: 18416
		// (get) Token: 0x06015910 RID: 88336 RVA: 0x00321F2B File Offset: 0x0032012B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047F1 RID: 18417
		// (get) Token: 0x06015911 RID: 88337 RVA: 0x00321F2E File Offset: 0x0032012E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeWriteCatRewardResponse.Descriptor;
			}
		}

		// Token: 0x06015912 RID: 88338 RVA: 0x00321F35 File Offset: 0x00320135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatRewardResponse()
		{
		}

		// Token: 0x06015913 RID: 88339 RVA: 0x00321F3D File Offset: 0x0032013D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatRewardResponse(RoguelikeWriteCatRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015914 RID: 88340 RVA: 0x00321F62 File Offset: 0x00320162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatRewardResponse Clone()
		{
			return new RoguelikeWriteCatRewardResponse(this);
		}

		// Token: 0x170047F2 RID: 18418
		// (get) Token: 0x06015915 RID: 88341 RVA: 0x00321F6A File Offset: 0x0032016A
		// (set) Token: 0x06015916 RID: 88342 RVA: 0x00321F72 File Offset: 0x00320172
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

		// Token: 0x06015917 RID: 88343 RVA: 0x00321F7B File Offset: 0x0032017B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeWriteCatRewardResponse);
		}

		// Token: 0x06015918 RID: 88344 RVA: 0x00321F89 File Offset: 0x00320189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeWriteCatRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015919 RID: 88345 RVA: 0x00321FB8 File Offset: 0x003201B8
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

		// Token: 0x0601591A RID: 88346 RVA: 0x00321FFD File Offset: 0x003201FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601591B RID: 88347 RVA: 0x0032200A File Offset: 0x0032020A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601591C RID: 88348 RVA: 0x00322013 File Offset: 0x00320213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601591D RID: 88349 RVA: 0x00322048 File Offset: 0x00320248
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

		// Token: 0x0601591E RID: 88350 RVA: 0x00322086 File Offset: 0x00320286
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

		// Token: 0x0601591F RID: 88351 RVA: 0x003220B7 File Offset: 0x003202B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015920 RID: 88352 RVA: 0x003220C0 File Offset: 0x003202C0
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008201 RID: 33281
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008202 RID: 33282
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04008203 RID: 33283
		private ErrorCode errorCode_;
	}
}
