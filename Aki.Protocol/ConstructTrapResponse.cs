using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002DF RID: 735
	[NetMessage(EMessageId.ConstructTrapResponse)]
	public sealed class ConstructTrapResponse : IMessage<ConstructTrapResponse>, IMessage, IEquatable<ConstructTrapResponse>, IDeepCloneable<ConstructTrapResponse>, IBufferMessage
	{
		// Token: 0x06004AF3 RID: 19187 RVA: 0x000B6D23 File Offset: 0x000B4F23
		[NullableContext(1)]
		public static ConstructTrapResponse Create()
		{
			return new ConstructTrapResponse();
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x06004AF4 RID: 19188 RVA: 0x000B6D2A File Offset: 0x000B4F2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x06004AF5 RID: 19189 RVA: 0x000B6D2D File Offset: 0x000B4F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConstructTrapResponse.Descriptor;
			}
		}

		// Token: 0x06004AF6 RID: 19190 RVA: 0x000B6D34 File Offset: 0x000B4F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConstructTrapResponse()
		{
		}

		// Token: 0x06004AF7 RID: 19191 RVA: 0x000B6D3C File Offset: 0x000B4F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConstructTrapResponse(ConstructTrapResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004AF8 RID: 19192 RVA: 0x000B6D6D File Offset: 0x000B4F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConstructTrapResponse Clone()
		{
			return new ConstructTrapResponse(this);
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x06004AF9 RID: 19193 RVA: 0x000B6D75 File Offset: 0x000B4F75
		// (set) Token: 0x06004AFA RID: 19194 RVA: 0x000B6D7D File Offset: 0x000B4F7D
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

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06004AFB RID: 19195 RVA: 0x000B6D86 File Offset: 0x000B4F86
		// (set) Token: 0x06004AFC RID: 19196 RVA: 0x000B6D8E File Offset: 0x000B4F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06004AFD RID: 19197 RVA: 0x000B6D97 File Offset: 0x000B4F97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConstructTrapResponse);
		}

		// Token: 0x06004AFE RID: 19198 RVA: 0x000B6DA5 File Offset: 0x000B4FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConstructTrapResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004AFF RID: 19199 RVA: 0x000B6DE4 File Offset: 0x000B4FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004B00 RID: 19200 RVA: 0x000B6E42 File Offset: 0x000B5042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004B01 RID: 19201 RVA: 0x000B6E4F File Offset: 0x000B504F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B02 RID: 19202 RVA: 0x000B6E58 File Offset: 0x000B5058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B03 RID: 19203 RVA: 0x000B6EB4 File Offset: 0x000B50B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004B04 RID: 19204 RVA: 0x000B6F0C File Offset: 0x000B510C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConstructTrapResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004B05 RID: 19205 RVA: 0x000B6F5C File Offset: 0x000B515C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B06 RID: 19206 RVA: 0x000B6F68 File Offset: 0x000B5168
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
				if (num != 16U)
				{
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt64();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003097 RID: 12439
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003098 RID: 12440
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04003099 RID: 12441
		private ErrorCode errorCode_;

		// Token: 0x0400309A RID: 12442
		public const int IdFieldNumber = 3;

		// Token: 0x0400309B RID: 12443
		private long id_;
	}
}
