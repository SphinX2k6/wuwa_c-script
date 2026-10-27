using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F6C RID: 3948
	[NetMessage(EMessageId.RoadBookFullRewardResponse)]
	public sealed class RoadBookFullRewardResponse : IMessage<RoadBookFullRewardResponse>, IMessage, IEquatable<RoadBookFullRewardResponse>, IDeepCloneable<RoadBookFullRewardResponse>, IBufferMessage
	{
		// Token: 0x060151B9 RID: 86457 RVA: 0x0030F766 File Offset: 0x0030D966
		[NullableContext(1)]
		public static RoadBookFullRewardResponse Create()
		{
			return new RoadBookFullRewardResponse();
		}

		// Token: 0x17004635 RID: 17973
		// (get) Token: 0x060151BA RID: 86458 RVA: 0x0030F76D File Offset: 0x0030D96D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004636 RID: 17974
		// (get) Token: 0x060151BB RID: 86459 RVA: 0x0030F770 File Offset: 0x0030D970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadBookFullRewardResponse.Descriptor;
			}
		}

		// Token: 0x060151BC RID: 86460 RVA: 0x0030F777 File Offset: 0x0030D977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookFullRewardResponse()
		{
		}

		// Token: 0x060151BD RID: 86461 RVA: 0x0030F77F File Offset: 0x0030D97F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookFullRewardResponse(RoadBookFullRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060151BE RID: 86462 RVA: 0x0030F7A4 File Offset: 0x0030D9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookFullRewardResponse Clone()
		{
			return new RoadBookFullRewardResponse(this);
		}

		// Token: 0x17004637 RID: 17975
		// (get) Token: 0x060151BF RID: 86463 RVA: 0x0030F7AC File Offset: 0x0030D9AC
		// (set) Token: 0x060151C0 RID: 86464 RVA: 0x0030F7B4 File Offset: 0x0030D9B4
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

		// Token: 0x060151C1 RID: 86465 RVA: 0x0030F7BD File Offset: 0x0030D9BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadBookFullRewardResponse);
		}

		// Token: 0x060151C2 RID: 86466 RVA: 0x0030F7CB File Offset: 0x0030D9CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadBookFullRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060151C3 RID: 86467 RVA: 0x0030F7FC File Offset: 0x0030D9FC
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

		// Token: 0x060151C4 RID: 86468 RVA: 0x0030F841 File Offset: 0x0030DA41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060151C5 RID: 86469 RVA: 0x0030F84E File Offset: 0x0030DA4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060151C6 RID: 86470 RVA: 0x0030F857 File Offset: 0x0030DA57
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

		// Token: 0x060151C7 RID: 86471 RVA: 0x0030F88C File Offset: 0x0030DA8C
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

		// Token: 0x060151C8 RID: 86472 RVA: 0x0030F8CA File Offset: 0x0030DACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoadBookFullRewardResponse other)
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

		// Token: 0x060151C9 RID: 86473 RVA: 0x0030F8FB File Offset: 0x0030DAFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060151CA RID: 86474 RVA: 0x0030F904 File Offset: 0x0030DB04
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

		// Token: 0x04007F0C RID: 32524
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F0D RID: 32525
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04007F0E RID: 32526
		private ErrorCode errorCode_;
	}
}
