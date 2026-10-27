using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013D4 RID: 5076
	[NetMessage(EMessageId.TraceMoonPhaseRewardResponse)]
	public sealed class TraceMoonPhaseRewardResponse : IMessage<TraceMoonPhaseRewardResponse>, IMessage, IEquatable<TraceMoonPhaseRewardResponse>, IDeepCloneable<TraceMoonPhaseRewardResponse>, IBufferMessage
	{
		// Token: 0x0601AEB1 RID: 110257 RVA: 0x003E6C51 File Offset: 0x003E4E51
		[NullableContext(1)]
		public static TraceMoonPhaseRewardResponse Create()
		{
			return new TraceMoonPhaseRewardResponse();
		}

		// Token: 0x17005AC5 RID: 23237
		// (get) Token: 0x0601AEB2 RID: 110258 RVA: 0x003E6C58 File Offset: 0x003E4E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AC6 RID: 23238
		// (get) Token: 0x0601AEB3 RID: 110259 RVA: 0x003E6C5B File Offset: 0x003E4E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TraceMoonPhaseRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601AEB4 RID: 110260 RVA: 0x003E6C62 File Offset: 0x003E4E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceMoonPhaseRewardResponse()
		{
		}

		// Token: 0x0601AEB5 RID: 110261 RVA: 0x003E6C6A File Offset: 0x003E4E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceMoonPhaseRewardResponse(TraceMoonPhaseRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AEB6 RID: 110262 RVA: 0x003E6C8F File Offset: 0x003E4E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceMoonPhaseRewardResponse Clone()
		{
			return new TraceMoonPhaseRewardResponse(this);
		}

		// Token: 0x17005AC7 RID: 23239
		// (get) Token: 0x0601AEB7 RID: 110263 RVA: 0x003E6C97 File Offset: 0x003E4E97
		// (set) Token: 0x0601AEB8 RID: 110264 RVA: 0x003E6C9F File Offset: 0x003E4E9F
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

		// Token: 0x0601AEB9 RID: 110265 RVA: 0x003E6CA8 File Offset: 0x003E4EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TraceMoonPhaseRewardResponse);
		}

		// Token: 0x0601AEBA RID: 110266 RVA: 0x003E6CB6 File Offset: 0x003E4EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TraceMoonPhaseRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AEBB RID: 110267 RVA: 0x003E6CE4 File Offset: 0x003E4EE4
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

		// Token: 0x0601AEBC RID: 110268 RVA: 0x003E6D29 File Offset: 0x003E4F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AEBD RID: 110269 RVA: 0x003E6D36 File Offset: 0x003E4F36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AEBE RID: 110270 RVA: 0x003E6D3F File Offset: 0x003E4F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AEBF RID: 110271 RVA: 0x003E6D74 File Offset: 0x003E4F74
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

		// Token: 0x0601AEC0 RID: 110272 RVA: 0x003E6DB2 File Offset: 0x003E4FB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TraceMoonPhaseRewardResponse other)
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

		// Token: 0x0601AEC1 RID: 110273 RVA: 0x003E6DE3 File Offset: 0x003E4FE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AEC2 RID: 110274 RVA: 0x003E6DEC File Offset: 0x003E4FEC
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009C13 RID: 39955
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C14 RID: 39956
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04009C15 RID: 39957
		private ErrorCode errorCode_;
	}
}
