using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200131F RID: 4895
	[NetMessage(EMessageId.TargetGearHitResponse)]
	public sealed class TargetGearHitResponse : IMessage<TargetGearHitResponse>, IMessage, IEquatable<TargetGearHitResponse>, IDeepCloneable<TargetGearHitResponse>, IBufferMessage
	{
		// Token: 0x0601A039 RID: 106553 RVA: 0x003C79C5 File Offset: 0x003C5BC5
		[NullableContext(1)]
		public static TargetGearHitResponse Create()
		{
			return new TargetGearHitResponse();
		}

		// Token: 0x170057BD RID: 22461
		// (get) Token: 0x0601A03A RID: 106554 RVA: 0x003C79CC File Offset: 0x003C5BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057BE RID: 22462
		// (get) Token: 0x0601A03B RID: 106555 RVA: 0x003C79CF File Offset: 0x003C5BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TargetGearHitResponse.Descriptor;
			}
		}

		// Token: 0x0601A03C RID: 106556 RVA: 0x003C79D6 File Offset: 0x003C5BD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearHitResponse()
		{
		}

		// Token: 0x0601A03D RID: 106557 RVA: 0x003C79DE File Offset: 0x003C5BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearHitResponse(TargetGearHitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A03E RID: 106558 RVA: 0x003C7A03 File Offset: 0x003C5C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearHitResponse Clone()
		{
			return new TargetGearHitResponse(this);
		}

		// Token: 0x170057BF RID: 22463
		// (get) Token: 0x0601A03F RID: 106559 RVA: 0x003C7A0B File Offset: 0x003C5C0B
		// (set) Token: 0x0601A040 RID: 106560 RVA: 0x003C7A13 File Offset: 0x003C5C13
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

		// Token: 0x0601A041 RID: 106561 RVA: 0x003C7A1C File Offset: 0x003C5C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TargetGearHitResponse);
		}

		// Token: 0x0601A042 RID: 106562 RVA: 0x003C7A2A File Offset: 0x003C5C2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TargetGearHitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A043 RID: 106563 RVA: 0x003C7A58 File Offset: 0x003C5C58
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

		// Token: 0x0601A044 RID: 106564 RVA: 0x003C7A9D File Offset: 0x003C5C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A045 RID: 106565 RVA: 0x003C7AAA File Offset: 0x003C5CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A046 RID: 106566 RVA: 0x003C7AB3 File Offset: 0x003C5CB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A047 RID: 106567 RVA: 0x003C7AE8 File Offset: 0x003C5CE8
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

		// Token: 0x0601A048 RID: 106568 RVA: 0x003C7B26 File Offset: 0x003C5D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TargetGearHitResponse other)
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

		// Token: 0x0601A049 RID: 106569 RVA: 0x003C7B57 File Offset: 0x003C5D57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A04A RID: 106570 RVA: 0x003C7B60 File Offset: 0x003C5D60
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040097FD RID: 38909
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097FE RID: 38910
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040097FF RID: 38911
		private ErrorCode errorCode_;
	}
}
