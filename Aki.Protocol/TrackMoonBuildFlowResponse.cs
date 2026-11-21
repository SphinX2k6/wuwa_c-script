using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001451 RID: 5201
	[NetMessage(EMessageId.TrackMoonBuildFlowResponse)]
	public sealed class TrackMoonBuildFlowResponse : IMessage<TrackMoonBuildFlowResponse>, IMessage, IEquatable<TrackMoonBuildFlowResponse>, IDeepCloneable<TrackMoonBuildFlowResponse>, IBufferMessage
	{
		// Token: 0x0601B9FA RID: 113146 RVA: 0x00403549 File Offset: 0x00401749
		[NullableContext(1)]
		public static TrackMoonBuildFlowResponse Create()
		{
			return new TrackMoonBuildFlowResponse();
		}

		// Token: 0x17005D7D RID: 23933
		// (get) Token: 0x0601B9FB RID: 113147 RVA: 0x00403550 File Offset: 0x00401750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D7E RID: 23934
		// (get) Token: 0x0601B9FC RID: 113148 RVA: 0x00403553 File Offset: 0x00401753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonBuildFlowResponse.Descriptor;
			}
		}

		// Token: 0x0601B9FD RID: 113149 RVA: 0x0040355A File Offset: 0x0040175A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonBuildFlowResponse()
		{
		}

		// Token: 0x0601B9FE RID: 113150 RVA: 0x00403562 File Offset: 0x00401762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonBuildFlowResponse(TrackMoonBuildFlowResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B9FF RID: 113151 RVA: 0x00403587 File Offset: 0x00401787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonBuildFlowResponse Clone()
		{
			return new TrackMoonBuildFlowResponse(this);
		}

		// Token: 0x17005D7F RID: 23935
		// (get) Token: 0x0601BA00 RID: 113152 RVA: 0x0040358F File Offset: 0x0040178F
		// (set) Token: 0x0601BA01 RID: 113153 RVA: 0x00403597 File Offset: 0x00401797
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

		// Token: 0x0601BA02 RID: 113154 RVA: 0x004035A0 File Offset: 0x004017A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonBuildFlowResponse);
		}

		// Token: 0x0601BA03 RID: 113155 RVA: 0x004035AE File Offset: 0x004017AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonBuildFlowResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BA04 RID: 113156 RVA: 0x004035DC File Offset: 0x004017DC
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

		// Token: 0x0601BA05 RID: 113157 RVA: 0x00403621 File Offset: 0x00401821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BA06 RID: 113158 RVA: 0x0040362E File Offset: 0x0040182E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BA07 RID: 113159 RVA: 0x00403637 File Offset: 0x00401837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BA08 RID: 113160 RVA: 0x0040366C File Offset: 0x0040186C
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

		// Token: 0x0601BA09 RID: 113161 RVA: 0x004036AA File Offset: 0x004018AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonBuildFlowResponse other)
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

		// Token: 0x0601BA0A RID: 113162 RVA: 0x004036DB File Offset: 0x004018DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BA0B RID: 113163 RVA: 0x004036E4 File Offset: 0x004018E4
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A082 RID: 41090
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A083 RID: 41091
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x0400A084 RID: 41092
		private ErrorCode errorCode_;
	}
}
