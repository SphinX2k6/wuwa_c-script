using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007E5 RID: 2021
	[NetMessage(EMessageId.InfrManualCancelTraceRoadResponse)]
	public sealed class InfrManualCancelTraceRoadResponse : IMessage<InfrManualCancelTraceRoadResponse>, IMessage, IEquatable<InfrManualCancelTraceRoadResponse>, IDeepCloneable<InfrManualCancelTraceRoadResponse>, IBufferMessage
	{
		// Token: 0x0600B553 RID: 46419 RVA: 0x001B11C2 File Offset: 0x001AF3C2
		[NullableContext(1)]
		public static InfrManualCancelTraceRoadResponse Create()
		{
			return new InfrManualCancelTraceRoadResponse();
		}

		// Token: 0x1700248F RID: 9359
		// (get) Token: 0x0600B554 RID: 46420 RVA: 0x001B11C9 File Offset: 0x001AF3C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002490 RID: 9360
		// (get) Token: 0x0600B555 RID: 46421 RVA: 0x001B11CC File Offset: 0x001AF3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrManualCancelTraceRoadResponse.Descriptor;
			}
		}

		// Token: 0x0600B556 RID: 46422 RVA: 0x001B11D3 File Offset: 0x001AF3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrManualCancelTraceRoadResponse()
		{
		}

		// Token: 0x0600B557 RID: 46423 RVA: 0x001B11DB File Offset: 0x001AF3DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrManualCancelTraceRoadResponse(InfrManualCancelTraceRoadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B558 RID: 46424 RVA: 0x001B1200 File Offset: 0x001AF400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrManualCancelTraceRoadResponse Clone()
		{
			return new InfrManualCancelTraceRoadResponse(this);
		}

		// Token: 0x17002491 RID: 9361
		// (get) Token: 0x0600B559 RID: 46425 RVA: 0x001B1208 File Offset: 0x001AF408
		// (set) Token: 0x0600B55A RID: 46426 RVA: 0x001B1210 File Offset: 0x001AF410
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

		// Token: 0x0600B55B RID: 46427 RVA: 0x001B1219 File Offset: 0x001AF419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrManualCancelTraceRoadResponse);
		}

		// Token: 0x0600B55C RID: 46428 RVA: 0x001B1227 File Offset: 0x001AF427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrManualCancelTraceRoadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B55D RID: 46429 RVA: 0x001B1258 File Offset: 0x001AF458
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

		// Token: 0x0600B55E RID: 46430 RVA: 0x001B129D File Offset: 0x001AF49D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B55F RID: 46431 RVA: 0x001B12AA File Offset: 0x001AF4AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B560 RID: 46432 RVA: 0x001B12B3 File Offset: 0x001AF4B3
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

		// Token: 0x0600B561 RID: 46433 RVA: 0x001B12E8 File Offset: 0x001AF4E8
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

		// Token: 0x0600B562 RID: 46434 RVA: 0x001B1326 File Offset: 0x001AF526
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

		// Token: 0x0600B563 RID: 46435 RVA: 0x001B1357 File Offset: 0x001AF557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B564 RID: 46436 RVA: 0x001B1360 File Offset: 0x001AF560
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

		// Token: 0x0400507F RID: 20607
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005080 RID: 20608
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04005081 RID: 20609
		private ErrorCode errorCode_;
	}
}
