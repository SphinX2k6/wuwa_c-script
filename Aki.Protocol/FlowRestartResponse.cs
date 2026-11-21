using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005EC RID: 1516
	[NetMessage(EMessageId.FlowRestartResponse)]
	public sealed class FlowRestartResponse : IMessage<FlowRestartResponse>, IMessage, IEquatable<FlowRestartResponse>, IDeepCloneable<FlowRestartResponse>, IBufferMessage
	{
		// Token: 0x06008CBF RID: 36031 RVA: 0x00155BF1 File Offset: 0x00153DF1
		[NullableContext(1)]
		public static FlowRestartResponse Create()
		{
			return new FlowRestartResponse();
		}

		// Token: 0x17001BE4 RID: 7140
		// (get) Token: 0x06008CC0 RID: 36032 RVA: 0x00155BF8 File Offset: 0x00153DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BE5 RID: 7141
		// (get) Token: 0x06008CC1 RID: 36033 RVA: 0x00155BFB File Offset: 0x00153DFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowRestartResponse.Descriptor;
			}
		}

		// Token: 0x06008CC2 RID: 36034 RVA: 0x00155C02 File Offset: 0x00153E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowRestartResponse()
		{
		}

		// Token: 0x06008CC3 RID: 36035 RVA: 0x00155C0A File Offset: 0x00153E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowRestartResponse(FlowRestartResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008CC4 RID: 36036 RVA: 0x00155C2F File Offset: 0x00153E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowRestartResponse Clone()
		{
			return new FlowRestartResponse(this);
		}

		// Token: 0x17001BE6 RID: 7142
		// (get) Token: 0x06008CC5 RID: 36037 RVA: 0x00155C37 File Offset: 0x00153E37
		// (set) Token: 0x06008CC6 RID: 36038 RVA: 0x00155C3F File Offset: 0x00153E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x06008CC7 RID: 36039 RVA: 0x00155C48 File Offset: 0x00153E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowRestartResponse);
		}

		// Token: 0x06008CC8 RID: 36040 RVA: 0x00155C56 File Offset: 0x00153E56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowRestartResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008CC9 RID: 36041 RVA: 0x00155C84 File Offset: 0x00153E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008CCA RID: 36042 RVA: 0x00155CC9 File Offset: 0x00153EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008CCB RID: 36043 RVA: 0x00155CD6 File Offset: 0x00153ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008CCC RID: 36044 RVA: 0x00155CDF File Offset: 0x00153EDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008CCD RID: 36045 RVA: 0x00155D10 File Offset: 0x00153F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008CCE RID: 36046 RVA: 0x00155D4E File Offset: 0x00153F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowRestartResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008CCF RID: 36047 RVA: 0x00155D7F File Offset: 0x00153F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008CD0 RID: 36048 RVA: 0x00155D88 File Offset: 0x00153F88
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
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004535 RID: 17717
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004536 RID: 17718
		public const int CodeFieldNumber = 1;

		// Token: 0x04004537 RID: 17719
		private ErrorCode code_;
	}
}
