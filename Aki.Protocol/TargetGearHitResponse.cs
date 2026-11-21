using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200138C RID: 5004
	[NetMessage(EMessageId.TargetGearHitResponse)]
	public sealed class TargetGearHitResponse : IMessage<TargetGearHitResponse>, IMessage, IEquatable<TargetGearHitResponse>, IDeepCloneable<TargetGearHitResponse>, IBufferMessage
	{
		// Token: 0x0601AA49 RID: 109129 RVA: 0x003E1C81 File Offset: 0x003DFE81
		[NullableContext(1)]
		public static TargetGearHitResponse Create()
		{
			return new TargetGearHitResponse();
		}

		// Token: 0x17005A37 RID: 23095
		// (get) Token: 0x0601AA4A RID: 109130 RVA: 0x003E1C88 File Offset: 0x003DFE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A38 RID: 23096
		// (get) Token: 0x0601AA4B RID: 109131 RVA: 0x003E1C8B File Offset: 0x003DFE8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TargetGearHitResponse.Descriptor;
			}
		}

		// Token: 0x0601AA4C RID: 109132 RVA: 0x003E1C92 File Offset: 0x003DFE92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearHitResponse()
		{
		}

		// Token: 0x0601AA4D RID: 109133 RVA: 0x003E1C9A File Offset: 0x003DFE9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearHitResponse(TargetGearHitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AA4E RID: 109134 RVA: 0x003E1CBF File Offset: 0x003DFEBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearHitResponse Clone()
		{
			return new TargetGearHitResponse(this);
		}

		// Token: 0x17005A39 RID: 23097
		// (get) Token: 0x0601AA4F RID: 109135 RVA: 0x003E1CC7 File Offset: 0x003DFEC7
		// (set) Token: 0x0601AA50 RID: 109136 RVA: 0x003E1CCF File Offset: 0x003DFECF
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

		// Token: 0x0601AA51 RID: 109137 RVA: 0x003E1CD8 File Offset: 0x003DFED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TargetGearHitResponse);
		}

		// Token: 0x0601AA52 RID: 109138 RVA: 0x003E1CE6 File Offset: 0x003DFEE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TargetGearHitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AA53 RID: 109139 RVA: 0x003E1D14 File Offset: 0x003DFF14
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

		// Token: 0x0601AA54 RID: 109140 RVA: 0x003E1D59 File Offset: 0x003DFF59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AA55 RID: 109141 RVA: 0x003E1D66 File Offset: 0x003DFF66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AA56 RID: 109142 RVA: 0x003E1D6F File Offset: 0x003DFF6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AA57 RID: 109143 RVA: 0x003E1DA0 File Offset: 0x003DFFA0
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

		// Token: 0x0601AA58 RID: 109144 RVA: 0x003E1DDE File Offset: 0x003DFFDE
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

		// Token: 0x0601AA59 RID: 109145 RVA: 0x003E1E0F File Offset: 0x003E000F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AA5A RID: 109146 RVA: 0x003E1E18 File Offset: 0x003E0018
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009C1F RID: 39967
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C20 RID: 39968
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04009C21 RID: 39969
		private ErrorCode errorCode_;
	}
}
