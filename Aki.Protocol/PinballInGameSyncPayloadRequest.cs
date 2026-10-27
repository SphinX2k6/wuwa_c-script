using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D4D RID: 3405
	[NetMessage(EMessageId.PinballInGameSyncPayloadRequest)]
	public sealed class PinballInGameSyncPayloadRequest : IMessage<PinballInGameSyncPayloadRequest>, IMessage, IEquatable<PinballInGameSyncPayloadRequest>, IDeepCloneable<PinballInGameSyncPayloadRequest>, IBufferMessage
	{
		// Token: 0x060125E3 RID: 75235 RVA: 0x002AE18B File Offset: 0x002AC38B
		[NullableContext(1)]
		public static PinballInGameSyncPayloadRequest Create()
		{
			return new PinballInGameSyncPayloadRequest();
		}

		// Token: 0x17003CDC RID: 15580
		// (get) Token: 0x060125E4 RID: 75236 RVA: 0x002AE192 File Offset: 0x002AC392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CDD RID: 15581
		// (get) Token: 0x060125E5 RID: 75237 RVA: 0x002AE195 File Offset: 0x002AC395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballInGameSyncPayloadRequest.Descriptor;
			}
		}

		// Token: 0x060125E6 RID: 75238 RVA: 0x002AE19C File Offset: 0x002AC39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameSyncPayloadRequest()
		{
		}

		// Token: 0x060125E7 RID: 75239 RVA: 0x002AE1A4 File Offset: 0x002AC3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameSyncPayloadRequest(PinballInGameSyncPayloadRequest other) : this()
		{
			this.payload_ = ((other.payload_ != null) ? other.payload_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060125E8 RID: 75240 RVA: 0x002AE1D9 File Offset: 0x002AC3D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameSyncPayloadRequest Clone()
		{
			return new PinballInGameSyncPayloadRequest(this);
		}

		// Token: 0x17003CDE RID: 15582
		// (get) Token: 0x060125E9 RID: 75241 RVA: 0x002AE1E1 File Offset: 0x002AC3E1
		// (set) Token: 0x060125EA RID: 75242 RVA: 0x002AE1E9 File Offset: 0x002AC3E9
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

		// Token: 0x060125EB RID: 75243 RVA: 0x002AE1F2 File Offset: 0x002AC3F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballInGameSyncPayloadRequest);
		}

		// Token: 0x060125EC RID: 75244 RVA: 0x002AE200 File Offset: 0x002AC400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballInGameSyncPayloadRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Payload, other.Payload) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060125ED RID: 75245 RVA: 0x002AE234 File Offset: 0x002AC434
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

		// Token: 0x060125EE RID: 75246 RVA: 0x002AE270 File Offset: 0x002AC470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060125EF RID: 75247 RVA: 0x002AE27D File Offset: 0x002AC47D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060125F0 RID: 75248 RVA: 0x002AE286 File Offset: 0x002AC486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.payload_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Payload);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060125F1 RID: 75249 RVA: 0x002AE2B8 File Offset: 0x002AC4B8
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

		// Token: 0x060125F2 RID: 75250 RVA: 0x002AE2F8 File Offset: 0x002AC4F8
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

		// Token: 0x060125F3 RID: 75251 RVA: 0x002AE34C File Offset: 0x002AC54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060125F4 RID: 75252 RVA: 0x002AE358 File Offset: 0x002AC558
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
				if (num != 90U)
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

		// Token: 0x04007264 RID: 29284
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007265 RID: 29285
		public const int PayloadFieldNumber = 11;

		// Token: 0x04007266 RID: 29286
		private PinballSettlePayload payload_;
	}
}
