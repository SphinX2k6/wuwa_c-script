using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007D1 RID: 2001
	[NetMessage(EMessageId.InfrManualCancelTraceRoadResponse)]
	public sealed class InfrManualCancelTraceRoadResponse : IMessage<InfrManualCancelTraceRoadResponse>, IMessage, IEquatable<InfrManualCancelTraceRoadResponse>, IDeepCloneable<InfrManualCancelTraceRoadResponse>, IBufferMessage
	{
		// Token: 0x0600B3FD RID: 46077 RVA: 0x001AE78E File Offset: 0x001AC98E
		[NullableContext(1)]
		public static InfrManualCancelTraceRoadResponse Create()
		{
			return new InfrManualCancelTraceRoadResponse();
		}

		// Token: 0x17002445 RID: 9285
		// (get) Token: 0x0600B3FE RID: 46078 RVA: 0x001AE795 File Offset: 0x001AC995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002446 RID: 9286
		// (get) Token: 0x0600B3FF RID: 46079 RVA: 0x001AE798 File Offset: 0x001AC998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrManualCancelTraceRoadResponse.Descriptor;
			}
		}

		// Token: 0x0600B400 RID: 46080 RVA: 0x001AE79F File Offset: 0x001AC99F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrManualCancelTraceRoadResponse()
		{
		}

		// Token: 0x0600B401 RID: 46081 RVA: 0x001AE7A7 File Offset: 0x001AC9A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrManualCancelTraceRoadResponse(InfrManualCancelTraceRoadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B402 RID: 46082 RVA: 0x001AE7CC File Offset: 0x001AC9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrManualCancelTraceRoadResponse Clone()
		{
			return new InfrManualCancelTraceRoadResponse(this);
		}

		// Token: 0x17002447 RID: 9287
		// (get) Token: 0x0600B403 RID: 46083 RVA: 0x001AE7D4 File Offset: 0x001AC9D4
		// (set) Token: 0x0600B404 RID: 46084 RVA: 0x001AE7DC File Offset: 0x001AC9DC
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

		// Token: 0x0600B405 RID: 46085 RVA: 0x001AE7E5 File Offset: 0x001AC9E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrManualCancelTraceRoadResponse);
		}

		// Token: 0x0600B406 RID: 46086 RVA: 0x001AE7F3 File Offset: 0x001AC9F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrManualCancelTraceRoadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B407 RID: 46087 RVA: 0x001AE824 File Offset: 0x001ACA24
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

		// Token: 0x0600B408 RID: 46088 RVA: 0x001AE869 File Offset: 0x001ACA69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B409 RID: 46089 RVA: 0x001AE876 File Offset: 0x001ACA76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B40A RID: 46090 RVA: 0x001AE87F File Offset: 0x001ACA7F
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

		// Token: 0x0600B40B RID: 46091 RVA: 0x001AE8B4 File Offset: 0x001ACAB4
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

		// Token: 0x0600B40C RID: 46092 RVA: 0x001AE8F2 File Offset: 0x001ACAF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrManualCancelTraceRoadResponse other)
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

		// Token: 0x0600B40D RID: 46093 RVA: 0x001AE923 File Offset: 0x001ACB23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B40E RID: 46094 RVA: 0x001AE92C File Offset: 0x001ACB2C
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

		// Token: 0x04005078 RID: 20600
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005079 RID: 20601
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x0400507A RID: 20602
		private ErrorCode errorCode_;
	}
}
