using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005FC RID: 1532
	[NetMessage(EMessageId.FlowerPollutionResponse)]
	public sealed class FlowerPollutionResponse : IMessage<FlowerPollutionResponse>, IMessage, IEquatable<FlowerPollutionResponse>, IDeepCloneable<FlowerPollutionResponse>, IBufferMessage
	{
		// Token: 0x06008DC4 RID: 36292 RVA: 0x00157C41 File Offset: 0x00155E41
		[NullableContext(1)]
		public static FlowerPollutionResponse Create()
		{
			return new FlowerPollutionResponse();
		}

		// Token: 0x17001C1D RID: 7197
		// (get) Token: 0x06008DC5 RID: 36293 RVA: 0x00157C48 File Offset: 0x00155E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C1E RID: 7198
		// (get) Token: 0x06008DC6 RID: 36294 RVA: 0x00157C4B File Offset: 0x00155E4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowerPollutionResponse.Descriptor;
			}
		}

		// Token: 0x06008DC7 RID: 36295 RVA: 0x00157C52 File Offset: 0x00155E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowerPollutionResponse()
		{
		}

		// Token: 0x06008DC8 RID: 36296 RVA: 0x00157C5A File Offset: 0x00155E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowerPollutionResponse(FlowerPollutionResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008DC9 RID: 36297 RVA: 0x00157C7F File Offset: 0x00155E7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowerPollutionResponse Clone()
		{
			return new FlowerPollutionResponse(this);
		}

		// Token: 0x17001C1F RID: 7199
		// (get) Token: 0x06008DCA RID: 36298 RVA: 0x00157C87 File Offset: 0x00155E87
		// (set) Token: 0x06008DCB RID: 36299 RVA: 0x00157C8F File Offset: 0x00155E8F
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

		// Token: 0x06008DCC RID: 36300 RVA: 0x00157C98 File Offset: 0x00155E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowerPollutionResponse);
		}

		// Token: 0x06008DCD RID: 36301 RVA: 0x00157CA6 File Offset: 0x00155EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowerPollutionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008DCE RID: 36302 RVA: 0x00157CD4 File Offset: 0x00155ED4
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

		// Token: 0x06008DCF RID: 36303 RVA: 0x00157D19 File Offset: 0x00155F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008DD0 RID: 36304 RVA: 0x00157D26 File Offset: 0x00155F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008DD1 RID: 36305 RVA: 0x00157D2F File Offset: 0x00155F2F
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

		// Token: 0x06008DD2 RID: 36306 RVA: 0x00157D64 File Offset: 0x00155F64
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

		// Token: 0x06008DD3 RID: 36307 RVA: 0x00157DA2 File Offset: 0x00155FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowerPollutionResponse other)
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

		// Token: 0x06008DD4 RID: 36308 RVA: 0x00157DD3 File Offset: 0x00155FD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008DD5 RID: 36309 RVA: 0x00157DDC File Offset: 0x00155FDC
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

		// Token: 0x04004527 RID: 17703
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004528 RID: 17704
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04004529 RID: 17705
		private ErrorCode errorCode_;
	}
}
