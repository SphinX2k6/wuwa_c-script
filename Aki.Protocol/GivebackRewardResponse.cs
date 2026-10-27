using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006F5 RID: 1781
	[NetMessage(EMessageId.GivebackRewardResponse)]
	public sealed class GivebackRewardResponse : IMessage<GivebackRewardResponse>, IMessage, IEquatable<GivebackRewardResponse>, IDeepCloneable<GivebackRewardResponse>, IBufferMessage
	{
		// Token: 0x0600A251 RID: 41553 RVA: 0x00188A7C File Offset: 0x00186C7C
		[NullableContext(1)]
		public static GivebackRewardResponse Create()
		{
			return new GivebackRewardResponse();
		}

		// Token: 0x170020A1 RID: 8353
		// (get) Token: 0x0600A252 RID: 41554 RVA: 0x00188A83 File Offset: 0x00186C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020A2 RID: 8354
		// (get) Token: 0x0600A253 RID: 41555 RVA: 0x00188A86 File Offset: 0x00186C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GivebackRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600A254 RID: 41556 RVA: 0x00188A8D File Offset: 0x00186C8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackRewardResponse()
		{
		}

		// Token: 0x0600A255 RID: 41557 RVA: 0x00188A95 File Offset: 0x00186C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackRewardResponse(GivebackRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A256 RID: 41558 RVA: 0x00188ABA File Offset: 0x00186CBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackRewardResponse Clone()
		{
			return new GivebackRewardResponse(this);
		}

		// Token: 0x170020A3 RID: 8355
		// (get) Token: 0x0600A257 RID: 41559 RVA: 0x00188AC2 File Offset: 0x00186CC2
		// (set) Token: 0x0600A258 RID: 41560 RVA: 0x00188ACA File Offset: 0x00186CCA
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

		// Token: 0x0600A259 RID: 41561 RVA: 0x00188AD3 File Offset: 0x00186CD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GivebackRewardResponse);
		}

		// Token: 0x0600A25A RID: 41562 RVA: 0x00188AE1 File Offset: 0x00186CE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GivebackRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A25B RID: 41563 RVA: 0x00188B10 File Offset: 0x00186D10
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

		// Token: 0x0600A25C RID: 41564 RVA: 0x00188B55 File Offset: 0x00186D55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A25D RID: 41565 RVA: 0x00188B62 File Offset: 0x00186D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A25E RID: 41566 RVA: 0x00188B6B File Offset: 0x00186D6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A25F RID: 41567 RVA: 0x00188BA0 File Offset: 0x00186DA0
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

		// Token: 0x0600A260 RID: 41568 RVA: 0x00188BDE File Offset: 0x00186DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GivebackRewardResponse other)
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

		// Token: 0x0600A261 RID: 41569 RVA: 0x00188C0F File Offset: 0x00186E0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A262 RID: 41570 RVA: 0x00188C18 File Offset: 0x00186E18
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004B43 RID: 19267
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B44 RID: 19268
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04004B45 RID: 19269
		private ErrorCode errorCode_;
	}
}
