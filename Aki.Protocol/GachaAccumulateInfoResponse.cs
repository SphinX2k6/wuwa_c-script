using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000676 RID: 1654
	[NetMessage(EMessageId.GachaAccumulateInfoResponse)]
	public sealed class GachaAccumulateInfoResponse : IMessage<GachaAccumulateInfoResponse>, IMessage, IEquatable<GachaAccumulateInfoResponse>, IDeepCloneable<GachaAccumulateInfoResponse>, IBufferMessage
	{
		// Token: 0x060097DD RID: 38877 RVA: 0x0016E4E1 File Offset: 0x0016C6E1
		[NullableContext(1)]
		public static GachaAccumulateInfoResponse Create()
		{
			return new GachaAccumulateInfoResponse();
		}

		// Token: 0x17001E3E RID: 7742
		// (get) Token: 0x060097DE RID: 38878 RVA: 0x0016E4E8 File Offset: 0x0016C6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E3F RID: 7743
		// (get) Token: 0x060097DF RID: 38879 RVA: 0x0016E4EB File Offset: 0x0016C6EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaAccumulateInfoResponse.Descriptor;
			}
		}

		// Token: 0x060097E0 RID: 38880 RVA: 0x0016E4F2 File Offset: 0x0016C6F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfoResponse()
		{
		}

		// Token: 0x060097E1 RID: 38881 RVA: 0x0016E4FC File Offset: 0x0016C6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfoResponse(GachaAccumulateInfoResponse other) : this()
		{
			this.gachaAccumulateInfo_ = ((other.gachaAccumulateInfo_ != null) ? other.gachaAccumulateInfo_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060097E2 RID: 38882 RVA: 0x0016E548 File Offset: 0x0016C748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfoResponse Clone()
		{
			return new GachaAccumulateInfoResponse(this);
		}

		// Token: 0x17001E40 RID: 7744
		// (get) Token: 0x060097E3 RID: 38883 RVA: 0x0016E550 File Offset: 0x0016C750
		// (set) Token: 0x060097E4 RID: 38884 RVA: 0x0016E558 File Offset: 0x0016C758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfo GachaAccumulateInfo
		{
			get
			{
				return this.gachaAccumulateInfo_;
			}
			set
			{
				this.gachaAccumulateInfo_ = value;
			}
		}

		// Token: 0x17001E41 RID: 7745
		// (get) Token: 0x060097E5 RID: 38885 RVA: 0x0016E561 File Offset: 0x0016C761
		// (set) Token: 0x060097E6 RID: 38886 RVA: 0x0016E569 File Offset: 0x0016C769
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

		// Token: 0x060097E7 RID: 38887 RVA: 0x0016E572 File Offset: 0x0016C772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaAccumulateInfoResponse);
		}

		// Token: 0x060097E8 RID: 38888 RVA: 0x0016E580 File Offset: 0x0016C780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaAccumulateInfoResponse other)
		{
			return other != null && (other == this || (object.Equals(this.GachaAccumulateInfo, other.GachaAccumulateInfo) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060097E9 RID: 38889 RVA: 0x0016E5D0 File Offset: 0x0016C7D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gachaAccumulateInfo_ != null)
			{
				num ^= this.GachaAccumulateInfo.GetHashCode();
			}
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

		// Token: 0x060097EA RID: 38890 RVA: 0x0016E62B File Offset: 0x0016C82B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060097EB RID: 38891 RVA: 0x0016E638 File Offset: 0x0016C838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060097EC RID: 38892 RVA: 0x0016E644 File Offset: 0x0016C844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.gachaAccumulateInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.GachaAccumulateInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060097ED RID: 38893 RVA: 0x0016E6A0 File Offset: 0x0016C8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gachaAccumulateInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GachaAccumulateInfo);
			}
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

		// Token: 0x060097EE RID: 38894 RVA: 0x0016E6F8 File Offset: 0x0016C8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaAccumulateInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gachaAccumulateInfo_ != null)
			{
				if (this.gachaAccumulateInfo_ == null)
				{
					this.GachaAccumulateInfo = new GachaAccumulateInfo();
				}
				this.GachaAccumulateInfo.MergeFrom(other.GachaAccumulateInfo);
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060097EF RID: 38895 RVA: 0x0016E760 File Offset: 0x0016C960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060097F0 RID: 38896 RVA: 0x0016E76C File Offset: 0x0016C96C
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
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.gachaAccumulateInfo_ == null)
						{
							this.GachaAccumulateInfo = new GachaAccumulateInfo();
						}
						input.ReadMessage(this.GachaAccumulateInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004873 RID: 18547
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004874 RID: 18548
		public const int GachaAccumulateInfoFieldNumber = 12;

		// Token: 0x04004875 RID: 18549
		private GachaAccumulateInfo gachaAccumulateInfo_;

		// Token: 0x04004876 RID: 18550
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04004877 RID: 18551
		private ErrorCode errorCode_;
	}
}
