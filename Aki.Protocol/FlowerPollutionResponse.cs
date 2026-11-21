using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005E7 RID: 1511
	[NetMessage(EMessageId.FlowerPollutionResponse)]
	public sealed class FlowerPollutionResponse : IMessage<FlowerPollutionResponse>, IMessage, IEquatable<FlowerPollutionResponse>, IDeepCloneable<FlowerPollutionResponse>, IBufferMessage
	{
		// Token: 0x06008C5C RID: 35932 RVA: 0x00155041 File Offset: 0x00153241
		[NullableContext(1)]
		public static FlowerPollutionResponse Create()
		{
			return new FlowerPollutionResponse();
		}

		// Token: 0x17001BD0 RID: 7120
		// (get) Token: 0x06008C5D RID: 35933 RVA: 0x00155048 File Offset: 0x00153248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BD1 RID: 7121
		// (get) Token: 0x06008C5E RID: 35934 RVA: 0x0015504B File Offset: 0x0015324B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowerPollutionResponse.Descriptor;
			}
		}

		// Token: 0x06008C5F RID: 35935 RVA: 0x00155052 File Offset: 0x00153252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowerPollutionResponse()
		{
		}

		// Token: 0x06008C60 RID: 35936 RVA: 0x0015505A File Offset: 0x0015325A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowerPollutionResponse(FlowerPollutionResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008C61 RID: 35937 RVA: 0x0015507F File Offset: 0x0015327F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowerPollutionResponse Clone()
		{
			return new FlowerPollutionResponse(this);
		}

		// Token: 0x17001BD2 RID: 7122
		// (get) Token: 0x06008C62 RID: 35938 RVA: 0x00155087 File Offset: 0x00153287
		// (set) Token: 0x06008C63 RID: 35939 RVA: 0x0015508F File Offset: 0x0015328F
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

		// Token: 0x06008C64 RID: 35940 RVA: 0x00155098 File Offset: 0x00153298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowerPollutionResponse);
		}

		// Token: 0x06008C65 RID: 35941 RVA: 0x001550A6 File Offset: 0x001532A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowerPollutionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008C66 RID: 35942 RVA: 0x001550D4 File Offset: 0x001532D4
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

		// Token: 0x06008C67 RID: 35943 RVA: 0x00155119 File Offset: 0x00153319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008C68 RID: 35944 RVA: 0x00155126 File Offset: 0x00153326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C69 RID: 35945 RVA: 0x0015512F File Offset: 0x0015332F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008C6A RID: 35946 RVA: 0x00155164 File Offset: 0x00153364
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

		// Token: 0x06008C6B RID: 35947 RVA: 0x001551A2 File Offset: 0x001533A2
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

		// Token: 0x06008C6C RID: 35948 RVA: 0x001551D3 File Offset: 0x001533D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C6D RID: 35949 RVA: 0x001551DC File Offset: 0x001533DC
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400451D RID: 17693
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400451E RID: 17694
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400451F RID: 17695
		private ErrorCode errorCode_;
	}
}
