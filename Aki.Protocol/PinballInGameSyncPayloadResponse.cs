using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D4E RID: 3406
	[NetMessage(EMessageId.PinballInGameSyncPayloadResponse)]
	public sealed class PinballInGameSyncPayloadResponse : IMessage<PinballInGameSyncPayloadResponse>, IMessage, IEquatable<PinballInGameSyncPayloadResponse>, IDeepCloneable<PinballInGameSyncPayloadResponse>, IBufferMessage
	{
		// Token: 0x060125F5 RID: 75253 RVA: 0x002AE3B0 File Offset: 0x002AC5B0
		[NullableContext(1)]
		public static PinballInGameSyncPayloadResponse Create()
		{
			return new PinballInGameSyncPayloadResponse();
		}

		// Token: 0x17003CDF RID: 15583
		// (get) Token: 0x060125F6 RID: 75254 RVA: 0x002AE3B7 File Offset: 0x002AC5B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CE0 RID: 15584
		// (get) Token: 0x060125F7 RID: 75255 RVA: 0x002AE3BA File Offset: 0x002AC5BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballInGameSyncPayloadResponse.Descriptor;
			}
		}

		// Token: 0x060125F8 RID: 75256 RVA: 0x002AE3C1 File Offset: 0x002AC5C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameSyncPayloadResponse()
		{
		}

		// Token: 0x060125F9 RID: 75257 RVA: 0x002AE3C9 File Offset: 0x002AC5C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameSyncPayloadResponse(PinballInGameSyncPayloadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060125FA RID: 75258 RVA: 0x002AE3EE File Offset: 0x002AC5EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameSyncPayloadResponse Clone()
		{
			return new PinballInGameSyncPayloadResponse(this);
		}

		// Token: 0x17003CE1 RID: 15585
		// (get) Token: 0x060125FB RID: 75259 RVA: 0x002AE3F6 File Offset: 0x002AC5F6
		// (set) Token: 0x060125FC RID: 75260 RVA: 0x002AE3FE File Offset: 0x002AC5FE
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

		// Token: 0x060125FD RID: 75261 RVA: 0x002AE407 File Offset: 0x002AC607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballInGameSyncPayloadResponse);
		}

		// Token: 0x060125FE RID: 75262 RVA: 0x002AE415 File Offset: 0x002AC615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballInGameSyncPayloadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060125FF RID: 75263 RVA: 0x002AE444 File Offset: 0x002AC644
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

		// Token: 0x06012600 RID: 75264 RVA: 0x002AE489 File Offset: 0x002AC689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012601 RID: 75265 RVA: 0x002AE496 File Offset: 0x002AC696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012602 RID: 75266 RVA: 0x002AE49F File Offset: 0x002AC69F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012603 RID: 75267 RVA: 0x002AE4D4 File Offset: 0x002AC6D4
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

		// Token: 0x06012604 RID: 75268 RVA: 0x002AE512 File Offset: 0x002AC712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballInGameSyncPayloadResponse other)
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

		// Token: 0x06012605 RID: 75269 RVA: 0x002AE543 File Offset: 0x002AC743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012606 RID: 75270 RVA: 0x002AE54C File Offset: 0x002AC74C
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007267 RID: 29287
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007268 RID: 29288
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04007269 RID: 29289
		private ErrorCode errorCode_;
	}
}
