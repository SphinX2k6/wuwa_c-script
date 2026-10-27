using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001171 RID: 4465
	[NetMessage(EMessageId.SceneItemSequenceFrameStartRequest)]
	public sealed class SceneItemSequenceFrameStartRequest : IMessage<SceneItemSequenceFrameStartRequest>, IMessage, IEquatable<SceneItemSequenceFrameStartRequest>, IDeepCloneable<SceneItemSequenceFrameStartRequest>, IBufferMessage
	{
		// Token: 0x06017CDB RID: 97499 RVA: 0x003752A9 File Offset: 0x003734A9
		[NullableContext(1)]
		public static SceneItemSequenceFrameStartRequest Create()
		{
			return new SceneItemSequenceFrameStartRequest();
		}

		// Token: 0x17004FF6 RID: 20470
		// (get) Token: 0x06017CDC RID: 97500 RVA: 0x003752B0 File Offset: 0x003734B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FF7 RID: 20471
		// (get) Token: 0x06017CDD RID: 97501 RVA: 0x003752B3 File Offset: 0x003734B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemSequenceFrameStartRequest.Descriptor;
			}
		}

		// Token: 0x06017CDE RID: 97502 RVA: 0x003752BA File Offset: 0x003734BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSequenceFrameStartRequest()
		{
		}

		// Token: 0x06017CDF RID: 97503 RVA: 0x003752D8 File Offset: 0x003734D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSequenceFrameStartRequest(SceneItemSequenceFrameStartRequest other) : this()
		{
			this.hostPlayerId_ = other.hostPlayerId_;
			this.entityId_ = other.entityId_;
			this.seqGuid_ = other.seqGuid_;
			this.eventName_ = other.eventName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017CE0 RID: 97504 RVA: 0x0037532C File Offset: 0x0037352C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSequenceFrameStartRequest Clone()
		{
			return new SceneItemSequenceFrameStartRequest(this);
		}

		// Token: 0x17004FF8 RID: 20472
		// (get) Token: 0x06017CE1 RID: 97505 RVA: 0x00375334 File Offset: 0x00373534
		// (set) Token: 0x06017CE2 RID: 97506 RVA: 0x0037533C File Offset: 0x0037353C
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

		// Token: 0x17004FF9 RID: 20473
		// (get) Token: 0x06017CE3 RID: 97507 RVA: 0x00375345 File Offset: 0x00373545
		// (set) Token: 0x06017CE4 RID: 97508 RVA: 0x0037534D File Offset: 0x0037354D
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

		// Token: 0x17004FFA RID: 20474
		// (get) Token: 0x06017CE5 RID: 97509 RVA: 0x00375356 File Offset: 0x00373556
		// (set) Token: 0x06017CE6 RID: 97510 RVA: 0x0037535E File Offset: 0x0037355E
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

		// Token: 0x17004FFB RID: 20475
		// (get) Token: 0x06017CE7 RID: 97511 RVA: 0x00375371 File Offset: 0x00373571
		// (set) Token: 0x06017CE8 RID: 97512 RVA: 0x00375379 File Offset: 0x00373579
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

		// Token: 0x06017CE9 RID: 97513 RVA: 0x0037538C File Offset: 0x0037358C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemSequenceFrameStartRequest);
		}

		// Token: 0x06017CEA RID: 97514 RVA: 0x0037539C File Offset: 0x0037359C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemSequenceFrameStartRequest other)
		{
			return other != null && (other == this || (this.HostPlayerId == other.HostPlayerId && this.EntityId == other.EntityId && !(this.SeqGuid != other.SeqGuid) && !(this.EventName != other.EventName) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017CEB RID: 97515 RVA: 0x00375410 File Offset: 0x00373610
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

		// Token: 0x06017CEC RID: 97516 RVA: 0x0037549E File Offset: 0x0037369E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017CED RID: 97517 RVA: 0x003754AB File Offset: 0x003736AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017CEE RID: 97518 RVA: 0x003754B4 File Offset: 0x003736B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			if (this.EventName.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.EventName);
			}
			if (this.SeqGuid.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.SeqGuid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017CEF RID: 97519 RVA: 0x00375550 File Offset: 0x00373750
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

		// Token: 0x06017CF0 RID: 97520 RVA: 0x003755E0 File Offset: 0x003737E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemSequenceFrameStartRequest other)
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

		// Token: 0x06017CF1 RID: 97521 RVA: 0x00375662 File Offset: 0x00373862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017CF2 RID: 97522 RVA: 0x0037566C File Offset: 0x0037386C
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
				if (num <= 48U)
				{
					if (num == 24U)
					{
						this.HostPlayerId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.EventName = input.ReadString();
						continue;
					}
					if (num == 82U)
					{
						this.SeqGuid = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008D2E RID: 36142
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D2F RID: 36143
		public const int HostPlayerIdFieldNumber = 3;

		// Token: 0x04008D30 RID: 36144
		private int hostPlayerId_;

		// Token: 0x04008D31 RID: 36145
		public const int EntityIdFieldNumber = 6;

		// Token: 0x04008D32 RID: 36146
		private long entityId_;

		// Token: 0x04008D33 RID: 36147
		public const int SeqGuidFieldNumber = 10;

		// Token: 0x04008D34 RID: 36148
		private string seqGuid_ = "";

		// Token: 0x04008D35 RID: 36149
		public const int EventNameFieldNumber = 9;

		// Token: 0x04008D36 RID: 36150
		private string eventName_ = "";
	}
}
