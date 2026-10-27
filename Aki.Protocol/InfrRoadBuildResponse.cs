using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007EE RID: 2030
	[NetMessage(EMessageId.InfrRoadBuildResponse)]
	public sealed class InfrRoadBuildResponse : IMessage<InfrRoadBuildResponse>, IMessage, IEquatable<InfrRoadBuildResponse>, IDeepCloneable<InfrRoadBuildResponse>, IBufferMessage
	{
		// Token: 0x0600B60B RID: 46603 RVA: 0x001B29E5 File Offset: 0x001B0BE5
		[NullableContext(1)]
		public static InfrRoadBuildResponse Create()
		{
			return new InfrRoadBuildResponse();
		}

		// Token: 0x170024B5 RID: 9397
		// (get) Token: 0x0600B60C RID: 46604 RVA: 0x001B29EC File Offset: 0x001B0BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024B6 RID: 9398
		// (get) Token: 0x0600B60D RID: 46605 RVA: 0x001B29EF File Offset: 0x001B0BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrRoadBuildResponse.Descriptor;
			}
		}

		// Token: 0x0600B60E RID: 46606 RVA: 0x001B29F6 File Offset: 0x001B0BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadBuildResponse()
		{
		}

		// Token: 0x0600B60F RID: 46607 RVA: 0x001B29FE File Offset: 0x001B0BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadBuildResponse(InfrRoadBuildResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B610 RID: 46608 RVA: 0x001B2A23 File Offset: 0x001B0C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadBuildResponse Clone()
		{
			return new InfrRoadBuildResponse(this);
		}

		// Token: 0x170024B7 RID: 9399
		// (get) Token: 0x0600B611 RID: 46609 RVA: 0x001B2A2B File Offset: 0x001B0C2B
		// (set) Token: 0x0600B612 RID: 46610 RVA: 0x001B2A33 File Offset: 0x001B0C33
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

		// Token: 0x0600B613 RID: 46611 RVA: 0x001B2A3C File Offset: 0x001B0C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrRoadBuildResponse);
		}

		// Token: 0x0600B614 RID: 46612 RVA: 0x001B2A4A File Offset: 0x001B0C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrRoadBuildResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B615 RID: 46613 RVA: 0x001B2A78 File Offset: 0x001B0C78
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

		// Token: 0x0600B616 RID: 46614 RVA: 0x001B2ABD File Offset: 0x001B0CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B617 RID: 46615 RVA: 0x001B2ACA File Offset: 0x001B0CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B618 RID: 46616 RVA: 0x001B2AD3 File Offset: 0x001B0CD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B619 RID: 46617 RVA: 0x001B2B08 File Offset: 0x001B0D08
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

		// Token: 0x0600B61A RID: 46618 RVA: 0x001B2B46 File Offset: 0x001B0D46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrRoadBuildResponse other)
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

		// Token: 0x0600B61B RID: 46619 RVA: 0x001B2B77 File Offset: 0x001B0D77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B61C RID: 46620 RVA: 0x001B2B80 File Offset: 0x001B0D80
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040050AF RID: 20655
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050B0 RID: 20656
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040050B1 RID: 20657
		private ErrorCode errorCode_;
	}
}
