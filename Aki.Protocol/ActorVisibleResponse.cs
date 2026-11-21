using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200009C RID: 156
	[NetMessage(EMessageId.ActorVisibleResponse)]
	public sealed class ActorVisibleResponse : IMessage<ActorVisibleResponse>, IMessage, IEquatable<ActorVisibleResponse>, IDeepCloneable<ActorVisibleResponse>, IBufferMessage
	{
		// Token: 0x06001C24 RID: 7204 RVA: 0x0004E68C File Offset: 0x0004C88C
		[NullableContext(1)]
		public static ActorVisibleResponse Create()
		{
			return new ActorVisibleResponse();
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06001C25 RID: 7205 RVA: 0x0004E693 File Offset: 0x0004C893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x0004E696 File Offset: 0x0004C896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActorVisibleResponse.Descriptor;
			}
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x0004E69D File Offset: 0x0004C89D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisibleResponse()
		{
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x0004E6A5 File Offset: 0x0004C8A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisibleResponse(ActorVisibleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x0004E6CA File Offset: 0x0004C8CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisibleResponse Clone()
		{
			return new ActorVisibleResponse(this);
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x0004E6D2 File Offset: 0x0004C8D2
		// (set) Token: 0x06001C2B RID: 7211 RVA: 0x0004E6DA File Offset: 0x0004C8DA
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

		// Token: 0x06001C2C RID: 7212 RVA: 0x0004E6E3 File Offset: 0x0004C8E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActorVisibleResponse);
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x0004E6F1 File Offset: 0x0004C8F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActorVisibleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x0004E720 File Offset: 0x0004C920
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

		// Token: 0x06001C2F RID: 7215 RVA: 0x0004E765 File Offset: 0x0004C965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x0004E772 File Offset: 0x0004C972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x0004E77B File Offset: 0x0004C97B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x0004E7B0 File Offset: 0x0004C9B0
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

		// Token: 0x06001C33 RID: 7219 RVA: 0x0004E7EE File Offset: 0x0004C9EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActorVisibleResponse other)
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

		// Token: 0x06001C34 RID: 7220 RVA: 0x0004E81F File Offset: 0x0004CA1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x0004E828 File Offset: 0x0004CA28
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002319 RID: 8985
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400231A RID: 8986
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x0400231B RID: 8987
		private ErrorCode errorCode_;
	}
}
