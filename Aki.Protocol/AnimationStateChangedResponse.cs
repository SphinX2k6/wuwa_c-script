using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000F0 RID: 240
	[NetMessage(EMessageId.AnimationStateChangedResponse)]
	public sealed class AnimationStateChangedResponse : IMessage<AnimationStateChangedResponse>, IMessage, IEquatable<AnimationStateChangedResponse>, IDeepCloneable<AnimationStateChangedResponse>, IBufferMessage
	{
		// Token: 0x06002281 RID: 8833 RVA: 0x0005BF31 File Offset: 0x0005A131
		[NullableContext(1)]
		public static AnimationStateChangedResponse Create()
		{
			return new AnimationStateChangedResponse();
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06002282 RID: 8834 RVA: 0x0005BF38 File Offset: 0x0005A138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06002283 RID: 8835 RVA: 0x0005BF3B File Offset: 0x0005A13B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationStateChangedResponse.Descriptor;
			}
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x0005BF42 File Offset: 0x0005A142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedResponse()
		{
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x0005BF4A File Offset: 0x0005A14A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedResponse(AnimationStateChangedResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x0005BF6F File Offset: 0x0005A16F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedResponse Clone()
		{
			return new AnimationStateChangedResponse(this);
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06002287 RID: 8839 RVA: 0x0005BF77 File Offset: 0x0005A177
		// (set) Token: 0x06002288 RID: 8840 RVA: 0x0005BF7F File Offset: 0x0005A17F
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

		// Token: 0x06002289 RID: 8841 RVA: 0x0005BF88 File Offset: 0x0005A188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationStateChangedResponse);
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x0005BF96 File Offset: 0x0005A196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationStateChangedResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x0005BFC4 File Offset: 0x0005A1C4
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

		// Token: 0x0600228C RID: 8844 RVA: 0x0005C009 File Offset: 0x0005A209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x0005C016 File Offset: 0x0005A216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x0005C01F File Offset: 0x0005A21F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x0005C054 File Offset: 0x0005A254
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

		// Token: 0x06002290 RID: 8848 RVA: 0x0005C092 File Offset: 0x0005A292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimationStateChangedResponse other)
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

		// Token: 0x06002291 RID: 8849 RVA: 0x0005C0C3 File Offset: 0x0005A2C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x0005C0CC File Offset: 0x0005A2CC
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400248F RID: 9359
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002490 RID: 9360
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04002491 RID: 9361
		private ErrorCode errorCode_;
	}
}
