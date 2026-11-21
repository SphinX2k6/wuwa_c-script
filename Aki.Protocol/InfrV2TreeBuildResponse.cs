using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007F6 RID: 2038
	[NetMessage(EMessageId.InfrV2TreeBuildResponse)]
	public sealed class InfrV2TreeBuildResponse : IMessage<InfrV2TreeBuildResponse>, IMessage, IEquatable<InfrV2TreeBuildResponse>, IDeepCloneable<InfrV2TreeBuildResponse>, IBufferMessage
	{
		// Token: 0x0600B6CC RID: 46796 RVA: 0x001B4199 File Offset: 0x001B2399
		[NullableContext(1)]
		public static InfrV2TreeBuildResponse Create()
		{
			return new InfrV2TreeBuildResponse();
		}

		// Token: 0x170024D0 RID: 9424
		// (get) Token: 0x0600B6CD RID: 46797 RVA: 0x001B41A0 File Offset: 0x001B23A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024D1 RID: 9425
		// (get) Token: 0x0600B6CE RID: 46798 RVA: 0x001B41A3 File Offset: 0x001B23A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2TreeBuildResponse.Descriptor;
			}
		}

		// Token: 0x0600B6CF RID: 46799 RVA: 0x001B41AA File Offset: 0x001B23AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreeBuildResponse()
		{
		}

		// Token: 0x0600B6D0 RID: 46800 RVA: 0x001B41B2 File Offset: 0x001B23B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreeBuildResponse(InfrV2TreeBuildResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B6D1 RID: 46801 RVA: 0x001B41D7 File Offset: 0x001B23D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreeBuildResponse Clone()
		{
			return new InfrV2TreeBuildResponse(this);
		}

		// Token: 0x170024D2 RID: 9426
		// (get) Token: 0x0600B6D2 RID: 46802 RVA: 0x001B41DF File Offset: 0x001B23DF
		// (set) Token: 0x0600B6D3 RID: 46803 RVA: 0x001B41E7 File Offset: 0x001B23E7
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

		// Token: 0x0600B6D4 RID: 46804 RVA: 0x001B41F0 File Offset: 0x001B23F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2TreeBuildResponse);
		}

		// Token: 0x0600B6D5 RID: 46805 RVA: 0x001B41FE File Offset: 0x001B23FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2TreeBuildResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B6D6 RID: 46806 RVA: 0x001B422C File Offset: 0x001B242C
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

		// Token: 0x0600B6D7 RID: 46807 RVA: 0x001B4271 File Offset: 0x001B2471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B6D8 RID: 46808 RVA: 0x001B427E File Offset: 0x001B247E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B6D9 RID: 46809 RVA: 0x001B4287 File Offset: 0x001B2487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B6DA RID: 46810 RVA: 0x001B42BC File Offset: 0x001B24BC
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

		// Token: 0x0600B6DB RID: 46811 RVA: 0x001B42FA File Offset: 0x001B24FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2TreeBuildResponse other)
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

		// Token: 0x0600B6DC RID: 46812 RVA: 0x001B432B File Offset: 0x001B252B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B6DD RID: 46813 RVA: 0x001B4334 File Offset: 0x001B2534
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005124 RID: 20772
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005125 RID: 20773
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04005126 RID: 20774
		private ErrorCode errorCode_;
	}
}
