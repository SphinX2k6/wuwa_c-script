using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000550 RID: 1360
	[NetMessage(EMessageId.FishingIllustratedRewardResponse)]
	public sealed class FishingIllustratedRewardResponse : IMessage<FishingIllustratedRewardResponse>, IMessage, IEquatable<FishingIllustratedRewardResponse>, IDeepCloneable<FishingIllustratedRewardResponse>, IBufferMessage
	{
		// Token: 0x06007F4C RID: 32588 RVA: 0x0013412D File Offset: 0x0013232D
		[NullableContext(1)]
		public static FishingIllustratedRewardResponse Create()
		{
			return new FishingIllustratedRewardResponse();
		}

		// Token: 0x170018C3 RID: 6339
		// (get) Token: 0x06007F4D RID: 32589 RVA: 0x00134134 File Offset: 0x00132334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018C4 RID: 6340
		// (get) Token: 0x06007F4E RID: 32590 RVA: 0x00134137 File Offset: 0x00132337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingIllustratedRewardResponse.Descriptor;
			}
		}

		// Token: 0x06007F4F RID: 32591 RVA: 0x0013413E File Offset: 0x0013233E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardResponse()
		{
		}

		// Token: 0x06007F50 RID: 32592 RVA: 0x00134146 File Offset: 0x00132346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardResponse(FishingIllustratedRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F51 RID: 32593 RVA: 0x0013416B File Offset: 0x0013236B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardResponse Clone()
		{
			return new FishingIllustratedRewardResponse(this);
		}

		// Token: 0x170018C5 RID: 6341
		// (get) Token: 0x06007F52 RID: 32594 RVA: 0x00134173 File Offset: 0x00132373
		// (set) Token: 0x06007F53 RID: 32595 RVA: 0x0013417B File Offset: 0x0013237B
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

		// Token: 0x06007F54 RID: 32596 RVA: 0x00134184 File Offset: 0x00132384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingIllustratedRewardResponse);
		}

		// Token: 0x06007F55 RID: 32597 RVA: 0x00134192 File Offset: 0x00132392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingIllustratedRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007F56 RID: 32598 RVA: 0x001341C0 File Offset: 0x001323C0
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

		// Token: 0x06007F57 RID: 32599 RVA: 0x00134205 File Offset: 0x00132405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007F58 RID: 32600 RVA: 0x00134212 File Offset: 0x00132412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F59 RID: 32601 RVA: 0x0013421B File Offset: 0x0013241B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F5A RID: 32602 RVA: 0x00134250 File Offset: 0x00132450
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

		// Token: 0x06007F5B RID: 32603 RVA: 0x0013428E File Offset: 0x0013248E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingIllustratedRewardResponse other)
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

		// Token: 0x06007F5C RID: 32604 RVA: 0x001342BF File Offset: 0x001324BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F5D RID: 32605 RVA: 0x001342C8 File Offset: 0x001324C8
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040040AE RID: 16558
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040AF RID: 16559
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040040B0 RID: 16560
		private ErrorCode errorCode_;
	}
}
