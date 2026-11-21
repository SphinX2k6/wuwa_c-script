using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D3E RID: 3390
	[NetMessage(EMessageId.PinballInGameSyncPayloadResponse)]
	public sealed class PinballInGameSyncPayloadResponse : IMessage<PinballInGameSyncPayloadResponse>, IMessage, IEquatable<PinballInGameSyncPayloadResponse>, IDeepCloneable<PinballInGameSyncPayloadResponse>, IBufferMessage
	{
		// Token: 0x060124F9 RID: 75001 RVA: 0x002AC790 File Offset: 0x002AA990
		[NullableContext(1)]
		public static PinballInGameSyncPayloadResponse Create()
		{
			return new PinballInGameSyncPayloadResponse();
		}

		// Token: 0x17003CAA RID: 15530
		// (get) Token: 0x060124FA RID: 75002 RVA: 0x002AC797 File Offset: 0x002AA997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CAB RID: 15531
		// (get) Token: 0x060124FB RID: 75003 RVA: 0x002AC79A File Offset: 0x002AA99A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballInGameSyncPayloadResponse.Descriptor;
			}
		}

		// Token: 0x060124FC RID: 75004 RVA: 0x002AC7A1 File Offset: 0x002AA9A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameSyncPayloadResponse()
		{
		}

		// Token: 0x060124FD RID: 75005 RVA: 0x002AC7A9 File Offset: 0x002AA9A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameSyncPayloadResponse(PinballInGameSyncPayloadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060124FE RID: 75006 RVA: 0x002AC7CE File Offset: 0x002AA9CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameSyncPayloadResponse Clone()
		{
			return new PinballInGameSyncPayloadResponse(this);
		}

		// Token: 0x17003CAC RID: 15532
		// (get) Token: 0x060124FF RID: 75007 RVA: 0x002AC7D6 File Offset: 0x002AA9D6
		// (set) Token: 0x06012500 RID: 75008 RVA: 0x002AC7DE File Offset: 0x002AA9DE
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

		// Token: 0x06012501 RID: 75009 RVA: 0x002AC7E7 File Offset: 0x002AA9E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballInGameSyncPayloadResponse);
		}

		// Token: 0x06012502 RID: 75010 RVA: 0x002AC7F5 File Offset: 0x002AA9F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballInGameSyncPayloadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012503 RID: 75011 RVA: 0x002AC824 File Offset: 0x002AAA24
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

		// Token: 0x06012504 RID: 75012 RVA: 0x002AC869 File Offset: 0x002AAA69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012505 RID: 75013 RVA: 0x002AC876 File Offset: 0x002AAA76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012506 RID: 75014 RVA: 0x002AC87F File Offset: 0x002AAA7F
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

		// Token: 0x06012507 RID: 75015 RVA: 0x002AC8B4 File Offset: 0x002AAAB4
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

		// Token: 0x06012508 RID: 75016 RVA: 0x002AC8F2 File Offset: 0x002AAAF2
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

		// Token: 0x06012509 RID: 75017 RVA: 0x002AC923 File Offset: 0x002AAB23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601250A RID: 75018 RVA: 0x002AC92C File Offset: 0x002AAB2C
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

		// Token: 0x0400727F RID: 29311
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007280 RID: 29312
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04007281 RID: 29313
		private ErrorCode errorCode_;
	}
}
