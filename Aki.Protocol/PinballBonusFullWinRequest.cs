using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D40 RID: 3392
	[NetMessage(EMessageId.PinballBonusFullWinRequest)]
	public sealed class PinballBonusFullWinRequest : IMessage<PinballBonusFullWinRequest>, IMessage, IEquatable<PinballBonusFullWinRequest>, IDeepCloneable<PinballBonusFullWinRequest>, IBufferMessage
	{
		// Token: 0x060124DC RID: 74972 RVA: 0x002ABEB1 File Offset: 0x002AA0B1
		[NullableContext(1)]
		public static PinballBonusFullWinRequest Create()
		{
			return new PinballBonusFullWinRequest();
		}

		// Token: 0x17003CA6 RID: 15526
		// (get) Token: 0x060124DD RID: 74973 RVA: 0x002ABEB8 File Offset: 0x002AA0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CA7 RID: 15527
		// (get) Token: 0x060124DE RID: 74974 RVA: 0x002ABEBB File Offset: 0x002AA0BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballBonusFullWinRequest.Descriptor;
			}
		}

		// Token: 0x060124DF RID: 74975 RVA: 0x002ABEC2 File Offset: 0x002AA0C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballBonusFullWinRequest()
		{
		}

		// Token: 0x060124E0 RID: 74976 RVA: 0x002ABECA File Offset: 0x002AA0CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballBonusFullWinRequest(PinballBonusFullWinRequest other) : this()
		{
			this.payload_ = ((other.payload_ != null) ? other.payload_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060124E1 RID: 74977 RVA: 0x002ABEFF File Offset: 0x002AA0FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballBonusFullWinRequest Clone()
		{
			return new PinballBonusFullWinRequest(this);
		}

		// Token: 0x17003CA8 RID: 15528
		// (get) Token: 0x060124E2 RID: 74978 RVA: 0x002ABF07 File Offset: 0x002AA107
		// (set) Token: 0x060124E3 RID: 74979 RVA: 0x002ABF0F File Offset: 0x002AA10F
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

		// Token: 0x060124E4 RID: 74980 RVA: 0x002ABF18 File Offset: 0x002AA118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballBonusFullWinRequest);
		}

		// Token: 0x060124E5 RID: 74981 RVA: 0x002ABF26 File Offset: 0x002AA126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballBonusFullWinRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Payload, other.Payload) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060124E6 RID: 74982 RVA: 0x002ABF5C File Offset: 0x002AA15C
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

		// Token: 0x060124E7 RID: 74983 RVA: 0x002ABF98 File Offset: 0x002AA198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060124E8 RID: 74984 RVA: 0x002ABFA5 File Offset: 0x002AA1A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060124E9 RID: 74985 RVA: 0x002ABFAE File Offset: 0x002AA1AE
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

		// Token: 0x060124EA RID: 74986 RVA: 0x002ABFE0 File Offset: 0x002AA1E0
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

		// Token: 0x060124EB RID: 74987 RVA: 0x002AC020 File Offset: 0x002AA220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballBonusFullWinRequest other)
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

		// Token: 0x060124EC RID: 74988 RVA: 0x002AC074 File Offset: 0x002AA274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060124ED RID: 74989 RVA: 0x002AC080 File Offset: 0x002AA280
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

		// Token: 0x0400721F RID: 29215
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007220 RID: 29216
		public const int PayloadFieldNumber = 5;

		// Token: 0x04007221 RID: 29217
		private PinballSettlePayload payload_;
	}
}
