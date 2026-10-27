using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DC8 RID: 3528
	[NetMessage(EMessageId.PolluteGridCellResponse)]
	public sealed class PolluteGridCellResponse : IMessage<PolluteGridCellResponse>, IMessage, IEquatable<PolluteGridCellResponse>, IDeepCloneable<PolluteGridCellResponse>, IBufferMessage
	{
		// Token: 0x06012FED RID: 77805 RVA: 0x002C4DD3 File Offset: 0x002C2FD3
		[NullableContext(1)]
		public static PolluteGridCellResponse Create()
		{
			return new PolluteGridCellResponse();
		}

		// Token: 0x17003F08 RID: 16136
		// (get) Token: 0x06012FEE RID: 77806 RVA: 0x002C4DDA File Offset: 0x002C2FDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F09 RID: 16137
		// (get) Token: 0x06012FEF RID: 77807 RVA: 0x002C4DDD File Offset: 0x002C2FDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PolluteGridCellResponse.Descriptor;
			}
		}

		// Token: 0x06012FF0 RID: 77808 RVA: 0x002C4DE4 File Offset: 0x002C2FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PolluteGridCellResponse()
		{
		}

		// Token: 0x06012FF1 RID: 77809 RVA: 0x002C4DEC File Offset: 0x002C2FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PolluteGridCellResponse(PolluteGridCellResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012FF2 RID: 77810 RVA: 0x002C4E11 File Offset: 0x002C3011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PolluteGridCellResponse Clone()
		{
			return new PolluteGridCellResponse(this);
		}

		// Token: 0x17003F0A RID: 16138
		// (get) Token: 0x06012FF3 RID: 77811 RVA: 0x002C4E19 File Offset: 0x002C3019
		// (set) Token: 0x06012FF4 RID: 77812 RVA: 0x002C4E21 File Offset: 0x002C3021
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

		// Token: 0x06012FF5 RID: 77813 RVA: 0x002C4E2A File Offset: 0x002C302A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PolluteGridCellResponse);
		}

		// Token: 0x06012FF6 RID: 77814 RVA: 0x002C4E38 File Offset: 0x002C3038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PolluteGridCellResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012FF7 RID: 77815 RVA: 0x002C4E68 File Offset: 0x002C3068
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

		// Token: 0x06012FF8 RID: 77816 RVA: 0x002C4EAD File Offset: 0x002C30AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012FF9 RID: 77817 RVA: 0x002C4EBA File Offset: 0x002C30BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012FFA RID: 77818 RVA: 0x002C4EC3 File Offset: 0x002C30C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012FFB RID: 77819 RVA: 0x002C4EF8 File Offset: 0x002C30F8
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

		// Token: 0x06012FFC RID: 77820 RVA: 0x002C4F36 File Offset: 0x002C3136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PolluteGridCellResponse other)
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

		// Token: 0x06012FFD RID: 77821 RVA: 0x002C4F67 File Offset: 0x002C3167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012FFE RID: 77822 RVA: 0x002C4F70 File Offset: 0x002C3170
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007557 RID: 30039
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007558 RID: 30040
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04007559 RID: 30041
		private ErrorCode errorCode_;
	}
}
