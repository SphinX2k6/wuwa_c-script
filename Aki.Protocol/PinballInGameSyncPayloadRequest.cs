using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D3D RID: 3389
	[NetMessage(EMessageId.PinballInGameSyncPayloadRequest)]
	public sealed class PinballInGameSyncPayloadRequest : IMessage<PinballInGameSyncPayloadRequest>, IMessage, IEquatable<PinballInGameSyncPayloadRequest>, IDeepCloneable<PinballInGameSyncPayloadRequest>, IBufferMessage
	{
		// Token: 0x060124E7 RID: 74983 RVA: 0x002AC56B File Offset: 0x002AA76B
		[NullableContext(1)]
		public static PinballInGameSyncPayloadRequest Create()
		{
			return new PinballInGameSyncPayloadRequest();
		}

		// Token: 0x17003CA7 RID: 15527
		// (get) Token: 0x060124E8 RID: 74984 RVA: 0x002AC572 File Offset: 0x002AA772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CA8 RID: 15528
		// (get) Token: 0x060124E9 RID: 74985 RVA: 0x002AC575 File Offset: 0x002AA775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballInGameSyncPayloadRequest.Descriptor;
			}
		}

		// Token: 0x060124EA RID: 74986 RVA: 0x002AC57C File Offset: 0x002AA77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameSyncPayloadRequest()
		{
		}

		// Token: 0x060124EB RID: 74987 RVA: 0x002AC584 File Offset: 0x002AA784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameSyncPayloadRequest(PinballInGameSyncPayloadRequest other) : this()
		{
			this.payload_ = ((other.payload_ != null) ? other.payload_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060124EC RID: 74988 RVA: 0x002AC5B9 File Offset: 0x002AA7B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameSyncPayloadRequest Clone()
		{
			return new PinballInGameSyncPayloadRequest(this);
		}

		// Token: 0x17003CA9 RID: 15529
		// (get) Token: 0x060124ED RID: 74989 RVA: 0x002AC5C1 File Offset: 0x002AA7C1
		// (set) Token: 0x060124EE RID: 74990 RVA: 0x002AC5C9 File Offset: 0x002AA7C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSettlePayload Payload
		{
			get
			{
				return this.payload_;
			}
			set
			{
				this.payload_ = value;
			}
		}

		// Token: 0x060124EF RID: 74991 RVA: 0x002AC5D2 File Offset: 0x002AA7D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballInGameSyncPayloadRequest);
		}

		// Token: 0x060124F0 RID: 74992 RVA: 0x002AC5E0 File Offset: 0x002AA7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballInGameSyncPayloadRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Payload, other.Payload) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060124F1 RID: 74993 RVA: 0x002AC614 File Offset: 0x002AA814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.payload_ != null)
			{
				num ^= this.Payload.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060124F2 RID: 74994 RVA: 0x002AC650 File Offset: 0x002AA850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060124F3 RID: 74995 RVA: 0x002AC65D File Offset: 0x002AA85D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060124F4 RID: 74996 RVA: 0x002AC666 File Offset: 0x002AA866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.payload_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Payload);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060124F5 RID: 74997 RVA: 0x002AC698 File Offset: 0x002AA898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.payload_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Payload);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060124F6 RID: 74998 RVA: 0x002AC6D8 File Offset: 0x002AA8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballInGameSyncPayloadRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.payload_ != null)
			{
				if (this.payload_ == null)
				{
					this.Payload = new PinballSettlePayload();
				}
				this.Payload.MergeFrom(other.Payload);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060124F7 RID: 74999 RVA: 0x002AC72C File Offset: 0x002AA92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060124F8 RID: 75000 RVA: 0x002AC738 File Offset: 0x002AA938
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.payload_ == null)
					{
						this.Payload = new PinballSettlePayload();
					}
					input.ReadMessage(this.Payload);
				}
			}
		}

		// Token: 0x0400727C RID: 29308
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400727D RID: 29309
		public const int PayloadFieldNumber = 5;

		// Token: 0x0400727E RID: 29310
		private PinballSettlePayload payload_;
	}
}
