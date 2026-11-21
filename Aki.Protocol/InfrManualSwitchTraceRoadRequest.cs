using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007D2 RID: 2002
	[NetMessage(EMessageId.InfrManualSwitchTraceRoadRequest)]
	public sealed class InfrManualSwitchTraceRoadRequest : IMessage<InfrManualSwitchTraceRoadRequest>, IMessage, IEquatable<InfrManualSwitchTraceRoadRequest>, IDeepCloneable<InfrManualSwitchTraceRoadRequest>, IBufferMessage
	{
		// Token: 0x0600B40F RID: 46095 RVA: 0x001AE971 File Offset: 0x001ACB71
		[NullableContext(1)]
		public static InfrManualSwitchTraceRoadRequest Create()
		{
			return new InfrManualSwitchTraceRoadRequest();
		}

		// Token: 0x17002448 RID: 9288
		// (get) Token: 0x0600B410 RID: 46096 RVA: 0x001AE978 File Offset: 0x001ACB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002449 RID: 9289
		// (get) Token: 0x0600B411 RID: 46097 RVA: 0x001AE97B File Offset: 0x001ACB7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrManualSwitchTraceRoadRequest.Descriptor;
			}
		}

		// Token: 0x0600B412 RID: 46098 RVA: 0x001AE982 File Offset: 0x001ACB82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrManualSwitchTraceRoadRequest()
		{
		}

		// Token: 0x0600B413 RID: 46099 RVA: 0x001AE98A File Offset: 0x001ACB8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrManualSwitchTraceRoadRequest(InfrManualSwitchTraceRoadRequest other) : this()
		{
			this.roadId_ = other.roadId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B414 RID: 46100 RVA: 0x001AE9AF File Offset: 0x001ACBAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrManualSwitchTraceRoadRequest Clone()
		{
			return new InfrManualSwitchTraceRoadRequest(this);
		}

		// Token: 0x1700244A RID: 9290
		// (get) Token: 0x0600B415 RID: 46101 RVA: 0x001AE9B7 File Offset: 0x001ACBB7
		// (set) Token: 0x0600B416 RID: 46102 RVA: 0x001AE9BF File Offset: 0x001ACBBF
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

		// Token: 0x0600B417 RID: 46103 RVA: 0x001AE9C8 File Offset: 0x001ACBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrManualSwitchTraceRoadRequest);
		}

		// Token: 0x0600B418 RID: 46104 RVA: 0x001AE9D6 File Offset: 0x001ACBD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrManualSwitchTraceRoadRequest other)
		{
			return other != null && (other == this || (this.RoadId == other.RoadId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B419 RID: 46105 RVA: 0x001AEA04 File Offset: 0x001ACC04
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

		// Token: 0x0600B41A RID: 46106 RVA: 0x001AEA43 File Offset: 0x001ACC43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B41B RID: 46107 RVA: 0x001AEA50 File Offset: 0x001ACC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B41C RID: 46108 RVA: 0x001AEA59 File Offset: 0x001ACC59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoadId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.RoadId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B41D RID: 46109 RVA: 0x001AEA8C File Offset: 0x001ACC8C
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

		// Token: 0x0600B41E RID: 46110 RVA: 0x001AEACA File Offset: 0x001ACCCA
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

		// Token: 0x0600B41F RID: 46111 RVA: 0x001AEAFB File Offset: 0x001ACCFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B420 RID: 46112 RVA: 0x001AEB04 File Offset: 0x001ACD04
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoadId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400507B RID: 20603
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400507C RID: 20604
		public const int RoadIdFieldNumber = 13;

		// Token: 0x0400507D RID: 20605
		private int roadId_;
	}
}
