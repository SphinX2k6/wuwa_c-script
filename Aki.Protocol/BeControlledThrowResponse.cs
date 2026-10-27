using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000192 RID: 402
	[NetMessage(EMessageId.BeControlledThrowResponse)]
	public sealed class BeControlledThrowResponse : IMessage<BeControlledThrowResponse>, IMessage, IEquatable<BeControlledThrowResponse>, IDeepCloneable<BeControlledThrowResponse>, IBufferMessage
	{
		// Token: 0x06002FE9 RID: 12265 RVA: 0x0007A893 File Offset: 0x00078A93
		[NullableContext(1)]
		public static BeControlledThrowResponse Create()
		{
			return new BeControlledThrowResponse();
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06002FEA RID: 12266 RVA: 0x0007A89A File Offset: 0x00078A9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06002FEB RID: 12267 RVA: 0x0007A89D File Offset: 0x00078A9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledThrowResponse.Descriptor;
			}
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x0007A8A4 File Offset: 0x00078AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledThrowResponse()
		{
		}

		// Token: 0x06002FED RID: 12269 RVA: 0x0007A8AC File Offset: 0x00078AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledThrowResponse(BeControlledThrowResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002FEE RID: 12270 RVA: 0x0007A8D1 File Offset: 0x00078AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledThrowResponse Clone()
		{
			return new BeControlledThrowResponse(this);
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06002FEF RID: 12271 RVA: 0x0007A8D9 File Offset: 0x00078AD9
		// (set) Token: 0x06002FF0 RID: 12272 RVA: 0x0007A8E1 File Offset: 0x00078AE1
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

		// Token: 0x06002FF1 RID: 12273 RVA: 0x0007A8EA File Offset: 0x00078AEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledThrowResponse);
		}

		// Token: 0x06002FF2 RID: 12274 RVA: 0x0007A8F8 File Offset: 0x00078AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledThrowResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002FF3 RID: 12275 RVA: 0x0007A928 File Offset: 0x00078B28
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

		// Token: 0x06002FF4 RID: 12276 RVA: 0x0007A96D File Offset: 0x00078B6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002FF5 RID: 12277 RVA: 0x0007A97A File Offset: 0x00078B7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002FF6 RID: 12278 RVA: 0x0007A983 File Offset: 0x00078B83
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

		// Token: 0x06002FF7 RID: 12279 RVA: 0x0007A9B8 File Offset: 0x00078BB8
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

		// Token: 0x06002FF8 RID: 12280 RVA: 0x0007A9F6 File Offset: 0x00078BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeControlledThrowResponse other)
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

		// Token: 0x06002FF9 RID: 12281 RVA: 0x0007AA27 File Offset: 0x00078C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002FFA RID: 12282 RVA: 0x0007AA30 File Offset: 0x00078C30
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

		// Token: 0x040028D0 RID: 10448
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028D1 RID: 10449
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040028D2 RID: 10450
		private ErrorCode errorCode_;
	}
}
