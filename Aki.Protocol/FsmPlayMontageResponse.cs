using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200065B RID: 1627
	[NetMessage(EMessageId.FsmPlayMontageResponse)]
	public sealed class FsmPlayMontageResponse : IMessage<FsmPlayMontageResponse>, IMessage, IEquatable<FsmPlayMontageResponse>, IDeepCloneable<FsmPlayMontageResponse>, IBufferMessage
	{
		// Token: 0x060095BB RID: 38331 RVA: 0x00169D1B File Offset: 0x00167F1B
		[NullableContext(1)]
		public static FsmPlayMontageResponse Create()
		{
			return new FsmPlayMontageResponse();
		}

		// Token: 0x17001DCE RID: 7630
		// (get) Token: 0x060095BC RID: 38332 RVA: 0x00169D22 File Offset: 0x00167F22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DCF RID: 7631
		// (get) Token: 0x060095BD RID: 38333 RVA: 0x00169D25 File Offset: 0x00167F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmPlayMontageResponse.Descriptor;
			}
		}

		// Token: 0x060095BE RID: 38334 RVA: 0x00169D2C File Offset: 0x00167F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmPlayMontageResponse()
		{
		}

		// Token: 0x060095BF RID: 38335 RVA: 0x00169D34 File Offset: 0x00167F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmPlayMontageResponse(FsmPlayMontageResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060095C0 RID: 38336 RVA: 0x00169D59 File Offset: 0x00167F59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmPlayMontageResponse Clone()
		{
			return new FsmPlayMontageResponse(this);
		}

		// Token: 0x17001DD0 RID: 7632
		// (get) Token: 0x060095C1 RID: 38337 RVA: 0x00169D61 File Offset: 0x00167F61
		// (set) Token: 0x060095C2 RID: 38338 RVA: 0x00169D69 File Offset: 0x00167F69
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

		// Token: 0x060095C3 RID: 38339 RVA: 0x00169D72 File Offset: 0x00167F72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmPlayMontageResponse);
		}

		// Token: 0x060095C4 RID: 38340 RVA: 0x00169D80 File Offset: 0x00167F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmPlayMontageResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060095C5 RID: 38341 RVA: 0x00169DB0 File Offset: 0x00167FB0
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

		// Token: 0x060095C6 RID: 38342 RVA: 0x00169DF5 File Offset: 0x00167FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060095C7 RID: 38343 RVA: 0x00169E02 File Offset: 0x00168002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060095C8 RID: 38344 RVA: 0x00169E0B File Offset: 0x0016800B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060095C9 RID: 38345 RVA: 0x00169E40 File Offset: 0x00168040
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

		// Token: 0x060095CA RID: 38346 RVA: 0x00169E7E File Offset: 0x0016807E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FsmPlayMontageResponse other)
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

		// Token: 0x060095CB RID: 38347 RVA: 0x00169EAF File Offset: 0x001680AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060095CC RID: 38348 RVA: 0x00169EB8 File Offset: 0x001680B8
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040047DD RID: 18397
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047DE RID: 18398
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040047DF RID: 18399
		private ErrorCode errorCode_;
	}
}
