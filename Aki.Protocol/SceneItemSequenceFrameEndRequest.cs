using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011A9 RID: 4521
	[NetMessage(EMessageId.SceneItemSequenceFrameEndRequest)]
	public sealed class SceneItemSequenceFrameEndRequest : IMessage<SceneItemSequenceFrameEndRequest>, IMessage, IEquatable<SceneItemSequenceFrameEndRequest>, IDeepCloneable<SceneItemSequenceFrameEndRequest>, IBufferMessage
	{
		// Token: 0x06018252 RID: 98898 RVA: 0x00383FCC File Offset: 0x003821CC
		[NullableContext(1)]
		public static SceneItemSequenceFrameEndRequest Create()
		{
			return new SceneItemSequenceFrameEndRequest();
		}

		// Token: 0x17005159 RID: 20825
		// (get) Token: 0x06018253 RID: 98899 RVA: 0x00383FD3 File Offset: 0x003821D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700515A RID: 20826
		// (get) Token: 0x06018254 RID: 98900 RVA: 0x00383FD6 File Offset: 0x003821D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemSequenceFrameEndRequest.Descriptor;
			}
		}

		// Token: 0x06018255 RID: 98901 RVA: 0x00383FDD File Offset: 0x003821DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSequenceFrameEndRequest()
		{
		}

		// Token: 0x06018256 RID: 98902 RVA: 0x00383FFC File Offset: 0x003821FC
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

		// Token: 0x06018257 RID: 98903 RVA: 0x00384050 File Offset: 0x00382250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSequenceFrameEndRequest Clone()
		{
			return new SceneItemSequenceFrameEndRequest(this);
		}

		// Token: 0x1700515B RID: 20827
		// (get) Token: 0x06018258 RID: 98904 RVA: 0x00384058 File Offset: 0x00382258
		// (set) Token: 0x06018259 RID: 98905 RVA: 0x00384060 File Offset: 0x00382260
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

		// Token: 0x1700515C RID: 20828
		// (get) Token: 0x0601825A RID: 98906 RVA: 0x00384069 File Offset: 0x00382269
		// (set) Token: 0x0601825B RID: 98907 RVA: 0x00384071 File Offset: 0x00382271
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

		// Token: 0x1700515D RID: 20829
		// (get) Token: 0x0601825C RID: 98908 RVA: 0x0038407A File Offset: 0x0038227A
		// (set) Token: 0x0601825D RID: 98909 RVA: 0x00384082 File Offset: 0x00382282
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

		// Token: 0x1700515E RID: 20830
		// (get) Token: 0x0601825E RID: 98910 RVA: 0x00384095 File Offset: 0x00382295
		// (set) Token: 0x0601825F RID: 98911 RVA: 0x0038409D File Offset: 0x0038229D
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

		// Token: 0x06018260 RID: 98912 RVA: 0x003840B0 File Offset: 0x003822B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemSequenceFrameEndRequest);
		}

		// Token: 0x06018261 RID: 98913 RVA: 0x003840C0 File Offset: 0x003822C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemSequenceFrameEndRequest other)
		{
			return other != null && (other == this || (this.HostPlayerId == other.HostPlayerId && this.EntityId == other.EntityId && !(this.SeqGuid != other.SeqGuid) && !(this.EventName != other.EventName) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018262 RID: 98914 RVA: 0x00384134 File Offset: 0x00382334
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

		// Token: 0x06018263 RID: 98915 RVA: 0x003841C2 File Offset: 0x003823C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018264 RID: 98916 RVA: 0x003841CF File Offset: 0x003823CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018265 RID: 98917 RVA: 0x003841D8 File Offset: 0x003823D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this.EventName.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.EventName);
			}
			if (this.SeqGuid.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.SeqGuid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018266 RID: 98918 RVA: 0x00384274 File Offset: 0x00382474
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

		// Token: 0x06018267 RID: 98919 RVA: 0x00384304 File Offset: 0x00382504
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

		// Token: 0x06018268 RID: 98920 RVA: 0x00384386 File Offset: 0x00382586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018269 RID: 98921 RVA: 0x00384390 File Offset: 0x00382590
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 24U)
					{
						this.HostPlayerId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 42U)
					{
						this.EventName = input.ReadString();
						continue;
					}
					if (num == 114U)
					{
						this.SeqGuid = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008FB5 RID: 36789
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FB6 RID: 36790
		public const int HostPlayerIdFieldNumber = 3;

		// Token: 0x04008FB7 RID: 36791
		private int hostPlayerId_;

		// Token: 0x04008FB8 RID: 36792
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04008FB9 RID: 36793
		private long entityId_;

		// Token: 0x04008FBA RID: 36794
		public const int SeqGuidFieldNumber = 14;

		// Token: 0x04008FBB RID: 36795
		private string seqGuid_ = "";

		// Token: 0x04008FBC RID: 36796
		public const int EventNameFieldNumber = 5;

		// Token: 0x04008FBD RID: 36797
		private string eventName_ = "";
	}
}
