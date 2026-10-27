using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200116F RID: 4463
	[NetMessage(EMessageId.SceneItemSequenceFrameEndRequest)]
	public sealed class SceneItemSequenceFrameEndRequest : IMessage<SceneItemSequenceFrameEndRequest>, IMessage, IEquatable<SceneItemSequenceFrameEndRequest>, IDeepCloneable<SceneItemSequenceFrameEndRequest>, IBufferMessage
	{
		// Token: 0x06017CB1 RID: 97457 RVA: 0x00374C80 File Offset: 0x00372E80
		[NullableContext(1)]
		public static SceneItemSequenceFrameEndRequest Create()
		{
			return new SceneItemSequenceFrameEndRequest();
		}

		// Token: 0x17004FED RID: 20461
		// (get) Token: 0x06017CB2 RID: 97458 RVA: 0x00374C87 File Offset: 0x00372E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FEE RID: 20462
		// (get) Token: 0x06017CB3 RID: 97459 RVA: 0x00374C8A File Offset: 0x00372E8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemSequenceFrameEndRequest.Descriptor;
			}
		}

		// Token: 0x06017CB4 RID: 97460 RVA: 0x00374C91 File Offset: 0x00372E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSequenceFrameEndRequest()
		{
		}

		// Token: 0x06017CB5 RID: 97461 RVA: 0x00374CB0 File Offset: 0x00372EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSequenceFrameEndRequest(SceneItemSequenceFrameEndRequest other) : this()
		{
			this.hostPlayerId_ = other.hostPlayerId_;
			this.entityId_ = other.entityId_;
			this.seqGuid_ = other.seqGuid_;
			this.eventName_ = other.eventName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017CB6 RID: 97462 RVA: 0x00374D04 File Offset: 0x00372F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSequenceFrameEndRequest Clone()
		{
			return new SceneItemSequenceFrameEndRequest(this);
		}

		// Token: 0x17004FEF RID: 20463
		// (get) Token: 0x06017CB7 RID: 97463 RVA: 0x00374D0C File Offset: 0x00372F0C
		// (set) Token: 0x06017CB8 RID: 97464 RVA: 0x00374D14 File Offset: 0x00372F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HostPlayerId
		{
			get
			{
				return this.hostPlayerId_;
			}
			set
			{
				this.hostPlayerId_ = value;
			}
		}

		// Token: 0x17004FF0 RID: 20464
		// (get) Token: 0x06017CB9 RID: 97465 RVA: 0x00374D1D File Offset: 0x00372F1D
		// (set) Token: 0x06017CBA RID: 97466 RVA: 0x00374D25 File Offset: 0x00372F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17004FF1 RID: 20465
		// (get) Token: 0x06017CBB RID: 97467 RVA: 0x00374D2E File Offset: 0x00372F2E
		// (set) Token: 0x06017CBC RID: 97468 RVA: 0x00374D36 File Offset: 0x00372F36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SeqGuid
		{
			get
			{
				return this.seqGuid_;
			}
			set
			{
				this.seqGuid_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17004FF2 RID: 20466
		// (get) Token: 0x06017CBD RID: 97469 RVA: 0x00374D49 File Offset: 0x00372F49
		// (set) Token: 0x06017CBE RID: 97470 RVA: 0x00374D51 File Offset: 0x00372F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string EventName
		{
			get
			{
				return this.eventName_;
			}
			set
			{
				this.eventName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06017CBF RID: 97471 RVA: 0x00374D64 File Offset: 0x00372F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemSequenceFrameEndRequest);
		}

		// Token: 0x06017CC0 RID: 97472 RVA: 0x00374D74 File Offset: 0x00372F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemSequenceFrameEndRequest other)
		{
			return other != null && (other == this || (this.HostPlayerId == other.HostPlayerId && this.EntityId == other.EntityId && !(this.SeqGuid != other.SeqGuid) && !(this.EventName != other.EventName) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017CC1 RID: 97473 RVA: 0x00374DE8 File Offset: 0x00372FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HostPlayerId != 0)
			{
				num ^= this.HostPlayerId.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.SeqGuid.Length != 0)
			{
				num ^= this.SeqGuid.GetHashCode();
			}
			if (this.EventName.Length != 0)
			{
				num ^= this.EventName.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017CC2 RID: 97474 RVA: 0x00374E76 File Offset: 0x00373076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017CC3 RID: 97475 RVA: 0x00374E83 File Offset: 0x00373083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017CC4 RID: 97476 RVA: 0x00374E8C File Offset: 0x0037308C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventName.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.EventName);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.EntityId);
			}
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this.SeqGuid.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.SeqGuid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017CC5 RID: 97477 RVA: 0x00374F28 File Offset: 0x00373128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HostPlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HostPlayerId);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.SeqGuid.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SeqGuid);
			}
			if (this.EventName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.EventName);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017CC6 RID: 97478 RVA: 0x00374FB8 File Offset: 0x003731B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemSequenceFrameEndRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HostPlayerId != 0)
			{
				this.HostPlayerId = other.HostPlayerId;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.SeqGuid.Length != 0)
			{
				this.SeqGuid = other.SeqGuid;
			}
			if (other.EventName.Length != 0)
			{
				this.EventName = other.EventName;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017CC7 RID: 97479 RVA: 0x0037503A File Offset: 0x0037323A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017CC8 RID: 97480 RVA: 0x00375044 File Offset: 0x00373244
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
				if (num <= 56U)
				{
					if (num == 42U)
					{
						this.EventName = input.ReadString();
						continue;
					}
					if (num == 56U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.HostPlayerId = input.ReadInt32();
						continue;
					}
					if (num == 98U)
					{
						this.SeqGuid = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008D22 RID: 36130
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D23 RID: 36131
		public const int HostPlayerIdFieldNumber = 10;

		// Token: 0x04008D24 RID: 36132
		private int hostPlayerId_;

		// Token: 0x04008D25 RID: 36133
		public const int EntityIdFieldNumber = 7;

		// Token: 0x04008D26 RID: 36134
		private long entityId_;

		// Token: 0x04008D27 RID: 36135
		public const int SeqGuidFieldNumber = 12;

		// Token: 0x04008D28 RID: 36136
		private string seqGuid_ = "";

		// Token: 0x04008D29 RID: 36137
		public const int EventNameFieldNumber = 5;

		// Token: 0x04008D2A RID: 36138
		private string eventName_ = "";
	}
}
