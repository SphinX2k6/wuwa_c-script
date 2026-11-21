using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011AB RID: 4523
	[NetMessage(EMessageId.SceneItemSequenceFrameStartRequest)]
	public sealed class SceneItemSequenceFrameStartRequest : IMessage<SceneItemSequenceFrameStartRequest>, IMessage, IEquatable<SceneItemSequenceFrameStartRequest>, IDeepCloneable<SceneItemSequenceFrameStartRequest>, IBufferMessage
	{
		// Token: 0x0601827C RID: 98940 RVA: 0x003845F5 File Offset: 0x003827F5
		[NullableContext(1)]
		public static SceneItemSequenceFrameStartRequest Create()
		{
			return new SceneItemSequenceFrameStartRequest();
		}

		// Token: 0x17005162 RID: 20834
		// (get) Token: 0x0601827D RID: 98941 RVA: 0x003845FC File Offset: 0x003827FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005163 RID: 20835
		// (get) Token: 0x0601827E RID: 98942 RVA: 0x003845FF File Offset: 0x003827FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemSequenceFrameStartRequest.Descriptor;
			}
		}

		// Token: 0x0601827F RID: 98943 RVA: 0x00384606 File Offset: 0x00382806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSequenceFrameStartRequest()
		{
		}

		// Token: 0x06018280 RID: 98944 RVA: 0x00384624 File Offset: 0x00382824
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

		// Token: 0x06018281 RID: 98945 RVA: 0x00384678 File Offset: 0x00382878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSequenceFrameStartRequest Clone()
		{
			return new SceneItemSequenceFrameStartRequest(this);
		}

		// Token: 0x17005164 RID: 20836
		// (get) Token: 0x06018282 RID: 98946 RVA: 0x00384680 File Offset: 0x00382880
		// (set) Token: 0x06018283 RID: 98947 RVA: 0x00384688 File Offset: 0x00382888
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

		// Token: 0x17005165 RID: 20837
		// (get) Token: 0x06018284 RID: 98948 RVA: 0x00384691 File Offset: 0x00382891
		// (set) Token: 0x06018285 RID: 98949 RVA: 0x00384699 File Offset: 0x00382899
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

		// Token: 0x17005166 RID: 20838
		// (get) Token: 0x06018286 RID: 98950 RVA: 0x003846A2 File Offset: 0x003828A2
		// (set) Token: 0x06018287 RID: 98951 RVA: 0x003846AA File Offset: 0x003828AA
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

		// Token: 0x17005167 RID: 20839
		// (get) Token: 0x06018288 RID: 98952 RVA: 0x003846BD File Offset: 0x003828BD
		// (set) Token: 0x06018289 RID: 98953 RVA: 0x003846C5 File Offset: 0x003828C5
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

		// Token: 0x0601828A RID: 98954 RVA: 0x003846D8 File Offset: 0x003828D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemSequenceFrameStartRequest);
		}

		// Token: 0x0601828B RID: 98955 RVA: 0x003846E8 File Offset: 0x003828E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemSequenceFrameStartRequest other)
		{
			return other != null && (other == this || (this.HostPlayerId == other.HostPlayerId && this.EntityId == other.EntityId && !(this.SeqGuid != other.SeqGuid) && !(this.EventName != other.EventName) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601828C RID: 98956 RVA: 0x0038475C File Offset: 0x0038295C
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

		// Token: 0x0601828D RID: 98957 RVA: 0x003847EA File Offset: 0x003829EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601828E RID: 98958 RVA: 0x003847F7 File Offset: 0x003829F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601828F RID: 98959 RVA: 0x00384800 File Offset: 0x00382A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SeqGuid.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.SeqGuid);
			}
			if (this.EventName.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.EventName);
			}
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018290 RID: 98960 RVA: 0x0038489C File Offset: 0x00382A9C
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

		// Token: 0x06018291 RID: 98961 RVA: 0x0038492C File Offset: 0x00382B2C
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

		// Token: 0x06018292 RID: 98962 RVA: 0x003849AE File Offset: 0x00382BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018293 RID: 98963 RVA: 0x003849B8 File Offset: 0x00382BB8
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
				if (num <= 26U)
				{
					if (num == 10U)
					{
						this.SeqGuid = input.ReadString();
						continue;
					}
					if (num == 26U)
					{
						this.EventName = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.HostPlayerId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008FC1 RID: 36801
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FC2 RID: 36802
		public const int HostPlayerIdFieldNumber = 4;

		// Token: 0x04008FC3 RID: 36803
		private int hostPlayerId_;

		// Token: 0x04008FC4 RID: 36804
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04008FC5 RID: 36805
		private long entityId_;

		// Token: 0x04008FC6 RID: 36806
		public const int SeqGuidFieldNumber = 1;

		// Token: 0x04008FC7 RID: 36807
		private string seqGuid_ = "";

		// Token: 0x04008FC8 RID: 36808
		public const int EventNameFieldNumber = 3;

		// Token: 0x04008FC9 RID: 36809
		private string eventName_ = "";
	}
}
