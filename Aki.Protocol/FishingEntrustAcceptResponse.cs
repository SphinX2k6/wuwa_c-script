using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200053C RID: 1340
	[NetMessage(EMessageId.FishingEntrustAcceptResponse)]
	public sealed class FishingEntrustAcceptResponse : IMessage<FishingEntrustAcceptResponse>, IMessage, IEquatable<FishingEntrustAcceptResponse>, IDeepCloneable<FishingEntrustAcceptResponse>, IBufferMessage
	{
		// Token: 0x06007DC3 RID: 32195 RVA: 0x00130F60 File Offset: 0x0012F160
		[NullableContext(1)]
		public static FishingEntrustAcceptResponse Create()
		{
			return new FishingEntrustAcceptResponse();
		}

		// Token: 0x17001875 RID: 6261
		// (get) Token: 0x06007DC4 RID: 32196 RVA: 0x00130F67 File Offset: 0x0012F167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001876 RID: 6262
		// (get) Token: 0x06007DC5 RID: 32197 RVA: 0x00130F6A File Offset: 0x0012F16A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingEntrustAcceptResponse.Descriptor;
			}
		}

		// Token: 0x06007DC6 RID: 32198 RVA: 0x00130F71 File Offset: 0x0012F171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustAcceptResponse()
		{
		}

		// Token: 0x06007DC7 RID: 32199 RVA: 0x00130F79 File Offset: 0x0012F179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustAcceptResponse(FishingEntrustAcceptResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007DC8 RID: 32200 RVA: 0x00130F9E File Offset: 0x0012F19E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustAcceptResponse Clone()
		{
			return new FishingEntrustAcceptResponse(this);
		}

		// Token: 0x17001877 RID: 6263
		// (get) Token: 0x06007DC9 RID: 32201 RVA: 0x00130FA6 File Offset: 0x0012F1A6
		// (set) Token: 0x06007DCA RID: 32202 RVA: 0x00130FAE File Offset: 0x0012F1AE
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

		// Token: 0x06007DCB RID: 32203 RVA: 0x00130FB7 File Offset: 0x0012F1B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingEntrustAcceptResponse);
		}

		// Token: 0x06007DCC RID: 32204 RVA: 0x00130FC5 File Offset: 0x0012F1C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingEntrustAcceptResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007DCD RID: 32205 RVA: 0x00130FF4 File Offset: 0x0012F1F4
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

		// Token: 0x06007DCE RID: 32206 RVA: 0x00131039 File Offset: 0x0012F239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007DCF RID: 32207 RVA: 0x00131046 File Offset: 0x0012F246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007DD0 RID: 32208 RVA: 0x0013104F File Offset: 0x0012F24F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007DD1 RID: 32209 RVA: 0x00131084 File Offset: 0x0012F284
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

		// Token: 0x06007DD2 RID: 32210 RVA: 0x001310C2 File Offset: 0x0012F2C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingEntrustAcceptResponse other)
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

		// Token: 0x06007DD3 RID: 32211 RVA: 0x001310F3 File Offset: 0x0012F2F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007DD4 RID: 32212 RVA: 0x001310FC File Offset: 0x0012F2FC
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004048 RID: 16456
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004049 RID: 16457
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400404A RID: 16458
		private ErrorCode errorCode_;
	}
}
