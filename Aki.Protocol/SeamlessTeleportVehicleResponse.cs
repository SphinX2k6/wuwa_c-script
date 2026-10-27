using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011A9 RID: 4521
	[NetMessage(EMessageId.SeamlessTeleportVehicleResponse)]
	public sealed class SeamlessTeleportVehicleResponse : IMessage<SeamlessTeleportVehicleResponse>, IMessage, IEquatable<SeamlessTeleportVehicleResponse>, IDeepCloneable<SeamlessTeleportVehicleResponse>, IBufferMessage
	{
		// Token: 0x06018170 RID: 98672 RVA: 0x0037FA08 File Offset: 0x0037DC08
		[NullableContext(1)]
		public static SeamlessTeleportVehicleResponse Create()
		{
			return new SeamlessTeleportVehicleResponse();
		}

		// Token: 0x170050F8 RID: 20728
		// (get) Token: 0x06018171 RID: 98673 RVA: 0x0037FA0F File Offset: 0x0037DC0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050F9 RID: 20729
		// (get) Token: 0x06018172 RID: 98674 RVA: 0x0037FA12 File Offset: 0x0037DC12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SeamlessTeleportVehicleResponse.Descriptor;
			}
		}

		// Token: 0x06018173 RID: 98675 RVA: 0x0037FA19 File Offset: 0x0037DC19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportVehicleResponse()
		{
		}

		// Token: 0x06018174 RID: 98676 RVA: 0x0037FA21 File Offset: 0x0037DC21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportVehicleResponse(SeamlessTeleportVehicleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018175 RID: 98677 RVA: 0x0037FA46 File Offset: 0x0037DC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportVehicleResponse Clone()
		{
			return new SeamlessTeleportVehicleResponse(this);
		}

		// Token: 0x170050FA RID: 20730
		// (get) Token: 0x06018176 RID: 98678 RVA: 0x0037FA4E File Offset: 0x0037DC4E
		// (set) Token: 0x06018177 RID: 98679 RVA: 0x0037FA56 File Offset: 0x0037DC56
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

		// Token: 0x06018178 RID: 98680 RVA: 0x0037FA5F File Offset: 0x0037DC5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SeamlessTeleportVehicleResponse);
		}

		// Token: 0x06018179 RID: 98681 RVA: 0x0037FA6D File Offset: 0x0037DC6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SeamlessTeleportVehicleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601817A RID: 98682 RVA: 0x0037FA9C File Offset: 0x0037DC9C
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

		// Token: 0x0601817B RID: 98683 RVA: 0x0037FAE1 File Offset: 0x0037DCE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601817C RID: 98684 RVA: 0x0037FAEE File Offset: 0x0037DCEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601817D RID: 98685 RVA: 0x0037FAF7 File Offset: 0x0037DCF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601817E RID: 98686 RVA: 0x0037FB2C File Offset: 0x0037DD2C
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

		// Token: 0x0601817F RID: 98687 RVA: 0x0037FB6A File Offset: 0x0037DD6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SeamlessTeleportVehicleResponse other)
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

		// Token: 0x06018180 RID: 98688 RVA: 0x0037FB9B File Offset: 0x0037DD9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018181 RID: 98689 RVA: 0x0037FBA4 File Offset: 0x0037DDA4
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008E94 RID: 36500
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E95 RID: 36501
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04008E96 RID: 36502
		private ErrorCode errorCode_;
	}
}
