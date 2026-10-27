using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007E6 RID: 2022
	[NetMessage(EMessageId.InfrManualSwitchTraceRoadRequest)]
	public sealed class InfrManualSwitchTraceRoadRequest : IMessage<InfrManualSwitchTraceRoadRequest>, IMessage, IEquatable<InfrManualSwitchTraceRoadRequest>, IDeepCloneable<InfrManualSwitchTraceRoadRequest>, IBufferMessage
	{
		// Token: 0x0600B565 RID: 46437 RVA: 0x001B13A5 File Offset: 0x001AF5A5
		[NullableContext(1)]
		public static InfrManualSwitchTraceRoadRequest Create()
		{
			return new InfrManualSwitchTraceRoadRequest();
		}

		// Token: 0x17002492 RID: 9362
		// (get) Token: 0x0600B566 RID: 46438 RVA: 0x001B13AC File Offset: 0x001AF5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002493 RID: 9363
		// (get) Token: 0x0600B567 RID: 46439 RVA: 0x001B13AF File Offset: 0x001AF5AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrManualSwitchTraceRoadRequest.Descriptor;
			}
		}

		// Token: 0x0600B568 RID: 46440 RVA: 0x001B13B6 File Offset: 0x001AF5B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrManualSwitchTraceRoadRequest()
		{
		}

		// Token: 0x0600B569 RID: 46441 RVA: 0x001B13BE File Offset: 0x001AF5BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrManualSwitchTraceRoadRequest(InfrManualSwitchTraceRoadRequest other) : this()
		{
			this.roadId_ = other.roadId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B56A RID: 46442 RVA: 0x001B13E3 File Offset: 0x001AF5E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrManualSwitchTraceRoadRequest Clone()
		{
			return new InfrManualSwitchTraceRoadRequest(this);
		}

		// Token: 0x17002494 RID: 9364
		// (get) Token: 0x0600B56B RID: 46443 RVA: 0x001B13EB File Offset: 0x001AF5EB
		// (set) Token: 0x0600B56C RID: 46444 RVA: 0x001B13F3 File Offset: 0x001AF5F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoadId
		{
			get
			{
				return this.roadId_;
			}
			set
			{
				this.roadId_ = value;
			}
		}

		// Token: 0x0600B56D RID: 46445 RVA: 0x001B13FC File Offset: 0x001AF5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrManualSwitchTraceRoadRequest);
		}

		// Token: 0x0600B56E RID: 46446 RVA: 0x001B140A File Offset: 0x001AF60A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrManualSwitchTraceRoadRequest other)
		{
			return other != null && (other == this || (this.RoadId == other.RoadId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B56F RID: 46447 RVA: 0x001B1438 File Offset: 0x001AF638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoadId != 0)
			{
				num ^= this.RoadId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B570 RID: 46448 RVA: 0x001B1477 File Offset: 0x001AF677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B571 RID: 46449 RVA: 0x001B1484 File Offset: 0x001AF684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B572 RID: 46450 RVA: 0x001B148D File Offset: 0x001AF68D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoadId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoadId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B573 RID: 46451 RVA: 0x001B14C0 File Offset: 0x001AF6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoadId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoadId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B574 RID: 46452 RVA: 0x001B14FE File Offset: 0x001AF6FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrManualSwitchTraceRoadRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoadId != 0)
			{
				this.RoadId = other.RoadId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B575 RID: 46453 RVA: 0x001B152F File Offset: 0x001AF72F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B576 RID: 46454 RVA: 0x001B1538 File Offset: 0x001AF738
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
					this.RoadId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005082 RID: 20610
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005083 RID: 20611
		public const int RoadIdFieldNumber = 2;

		// Token: 0x04005084 RID: 20612
		private int roadId_;
	}
}
