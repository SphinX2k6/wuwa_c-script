using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007E7 RID: 2023
	[NetMessage(EMessageId.InfrManualSwitchTraceRoadResponse)]
	public sealed class InfrManualSwitchTraceRoadResponse : IMessage<InfrManualSwitchTraceRoadResponse>, IMessage, IEquatable<InfrManualSwitchTraceRoadResponse>, IDeepCloneable<InfrManualSwitchTraceRoadResponse>, IBufferMessage
	{
		// Token: 0x0600B577 RID: 46455 RVA: 0x001B157D File Offset: 0x001AF77D
		[NullableContext(1)]
		public static InfrManualSwitchTraceRoadResponse Create()
		{
			return new InfrManualSwitchTraceRoadResponse();
		}

		// Token: 0x17002495 RID: 9365
		// (get) Token: 0x0600B578 RID: 46456 RVA: 0x001B1584 File Offset: 0x001AF784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002496 RID: 9366
		// (get) Token: 0x0600B579 RID: 46457 RVA: 0x001B1587 File Offset: 0x001AF787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrManualSwitchTraceRoadResponse.Descriptor;
			}
		}

		// Token: 0x0600B57A RID: 46458 RVA: 0x001B158E File Offset: 0x001AF78E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrManualSwitchTraceRoadResponse()
		{
		}

		// Token: 0x0600B57B RID: 46459 RVA: 0x001B1596 File Offset: 0x001AF796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrManualSwitchTraceRoadResponse(InfrManualSwitchTraceRoadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B57C RID: 46460 RVA: 0x001B15BB File Offset: 0x001AF7BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrManualSwitchTraceRoadResponse Clone()
		{
			return new InfrManualSwitchTraceRoadResponse(this);
		}

		// Token: 0x17002497 RID: 9367
		// (get) Token: 0x0600B57D RID: 46461 RVA: 0x001B15C3 File Offset: 0x001AF7C3
		// (set) Token: 0x0600B57E RID: 46462 RVA: 0x001B15CB File Offset: 0x001AF7CB
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

		// Token: 0x0600B57F RID: 46463 RVA: 0x001B15D4 File Offset: 0x001AF7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrManualSwitchTraceRoadResponse);
		}

		// Token: 0x0600B580 RID: 46464 RVA: 0x001B15E2 File Offset: 0x001AF7E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrManualSwitchTraceRoadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B581 RID: 46465 RVA: 0x001B1610 File Offset: 0x001AF810
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

		// Token: 0x0600B582 RID: 46466 RVA: 0x001B1655 File Offset: 0x001AF855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B583 RID: 46467 RVA: 0x001B1662 File Offset: 0x001AF862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B584 RID: 46468 RVA: 0x001B166B File Offset: 0x001AF86B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B585 RID: 46469 RVA: 0x001B16A0 File Offset: 0x001AF8A0
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

		// Token: 0x0600B586 RID: 46470 RVA: 0x001B16DE File Offset: 0x001AF8DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrManualSwitchTraceRoadResponse other)
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

		// Token: 0x0600B587 RID: 46471 RVA: 0x001B170F File Offset: 0x001AF90F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B588 RID: 46472 RVA: 0x001B1718 File Offset: 0x001AF918
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005085 RID: 20613
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005086 RID: 20614
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04005087 RID: 20615
		private ErrorCode errorCode_;
	}
}
