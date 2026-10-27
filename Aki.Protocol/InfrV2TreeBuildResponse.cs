using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200080A RID: 2058
	[NetMessage(EMessageId.InfrV2TreeBuildResponse)]
	public sealed class InfrV2TreeBuildResponse : IMessage<InfrV2TreeBuildResponse>, IMessage, IEquatable<InfrV2TreeBuildResponse>, IDeepCloneable<InfrV2TreeBuildResponse>, IBufferMessage
	{
		// Token: 0x0600B822 RID: 47138 RVA: 0x001B6BD8 File Offset: 0x001B4DD8
		[NullableContext(1)]
		public static InfrV2TreeBuildResponse Create()
		{
			return new InfrV2TreeBuildResponse();
		}

		// Token: 0x1700251A RID: 9498
		// (get) Token: 0x0600B823 RID: 47139 RVA: 0x001B6BDF File Offset: 0x001B4DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700251B RID: 9499
		// (get) Token: 0x0600B824 RID: 47140 RVA: 0x001B6BE2 File Offset: 0x001B4DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2TreeBuildResponse.Descriptor;
			}
		}

		// Token: 0x0600B825 RID: 47141 RVA: 0x001B6BE9 File Offset: 0x001B4DE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreeBuildResponse()
		{
		}

		// Token: 0x0600B826 RID: 47142 RVA: 0x001B6BF1 File Offset: 0x001B4DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreeBuildResponse(InfrV2TreeBuildResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B827 RID: 47143 RVA: 0x001B6C16 File Offset: 0x001B4E16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreeBuildResponse Clone()
		{
			return new InfrV2TreeBuildResponse(this);
		}

		// Token: 0x1700251C RID: 9500
		// (get) Token: 0x0600B828 RID: 47144 RVA: 0x001B6C1E File Offset: 0x001B4E1E
		// (set) Token: 0x0600B829 RID: 47145 RVA: 0x001B6C26 File Offset: 0x001B4E26
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

		// Token: 0x0600B82A RID: 47146 RVA: 0x001B6C2F File Offset: 0x001B4E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2TreeBuildResponse);
		}

		// Token: 0x0600B82B RID: 47147 RVA: 0x001B6C3D File Offset: 0x001B4E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2TreeBuildResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B82C RID: 47148 RVA: 0x001B6C6C File Offset: 0x001B4E6C
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

		// Token: 0x0600B82D RID: 47149 RVA: 0x001B6CB1 File Offset: 0x001B4EB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B82E RID: 47150 RVA: 0x001B6CBE File Offset: 0x001B4EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B82F RID: 47151 RVA: 0x001B6CC7 File Offset: 0x001B4EC7
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

		// Token: 0x0600B830 RID: 47152 RVA: 0x001B6CFC File Offset: 0x001B4EFC
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

		// Token: 0x0600B831 RID: 47153 RVA: 0x001B6D3A File Offset: 0x001B4F3A
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

		// Token: 0x0600B832 RID: 47154 RVA: 0x001B6D6B File Offset: 0x001B4F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B833 RID: 47155 RVA: 0x001B6D74 File Offset: 0x001B4F74
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

		// Token: 0x0400512B RID: 20779
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400512C RID: 20780
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x0400512D RID: 20781
		private ErrorCode errorCode_;
	}
}
