using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C09 RID: 3081
	[NetMessage(EMessageId.PhantomAttrRecommendResponse)]
	public sealed class PhantomAttrRecommendResponse : IMessage<PhantomAttrRecommendResponse>, IMessage, IEquatable<PhantomAttrRecommendResponse>, IDeepCloneable<PhantomAttrRecommendResponse>, IBufferMessage
	{
		// Token: 0x06010BFB RID: 68603 RVA: 0x002746F9 File Offset: 0x002728F9
		[NullableContext(1)]
		public static PhantomAttrRecommendResponse Create()
		{
			return new PhantomAttrRecommendResponse();
		}

		// Token: 0x17003747 RID: 14151
		// (get) Token: 0x06010BFC RID: 68604 RVA: 0x00274700 File Offset: 0x00272900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003748 RID: 14152
		// (get) Token: 0x06010BFD RID: 68605 RVA: 0x00274703 File Offset: 0x00272903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomAttrRecommendResponse.Descriptor;
			}
		}

		// Token: 0x06010BFE RID: 68606 RVA: 0x0027470A File Offset: 0x0027290A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAttrRecommendResponse()
		{
		}

		// Token: 0x06010BFF RID: 68607 RVA: 0x0027471D File Offset: 0x0027291D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAttrRecommendResponse(PhantomAttrRecommendResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.costPhantomAttrRecommendInfos_ = other.costPhantomAttrRecommendInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010C00 RID: 68608 RVA: 0x00274753 File Offset: 0x00272953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAttrRecommendResponse Clone()
		{
			return new PhantomAttrRecommendResponse(this);
		}

		// Token: 0x17003749 RID: 14153
		// (get) Token: 0x06010C01 RID: 68609 RVA: 0x0027475B File Offset: 0x0027295B
		// (set) Token: 0x06010C02 RID: 68610 RVA: 0x00274763 File Offset: 0x00272963
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

		// Token: 0x1700374A RID: 14154
		// (get) Token: 0x06010C03 RID: 68611 RVA: 0x0027476C File Offset: 0x0027296C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CostPhantomAttrRecommendInfo> CostPhantomAttrRecommendInfos
		{
			get
			{
				return this.costPhantomAttrRecommendInfos_;
			}
		}

		// Token: 0x06010C04 RID: 68612 RVA: 0x00274774 File Offset: 0x00272974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomAttrRecommendResponse);
		}

		// Token: 0x06010C05 RID: 68613 RVA: 0x00274784 File Offset: 0x00272984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomAttrRecommendResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.costPhantomAttrRecommendInfos_.Equals(other.costPhantomAttrRecommendInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010C06 RID: 68614 RVA: 0x002747D4 File Offset: 0x002729D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.costPhantomAttrRecommendInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010C07 RID: 68615 RVA: 0x00274827 File Offset: 0x00272A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010C08 RID: 68616 RVA: 0x00274834 File Offset: 0x00272A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010C09 RID: 68617 RVA: 0x00274840 File Offset: 0x00272A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.costPhantomAttrRecommendInfos_.WriteTo(ref output, PhantomAttrRecommendResponse._repeated_costPhantomAttrRecommendInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010C0A RID: 68618 RVA: 0x00274890 File Offset: 0x00272A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.costPhantomAttrRecommendInfos_.CalculateSize(PhantomAttrRecommendResponse._repeated_costPhantomAttrRecommendInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010C0B RID: 68619 RVA: 0x002748E4 File Offset: 0x00272AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomAttrRecommendResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.costPhantomAttrRecommendInfos_.Add(other.costPhantomAttrRecommendInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010C0C RID: 68620 RVA: 0x00274931 File Offset: 0x00272B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010C0D RID: 68621 RVA: 0x0027493C File Offset: 0x00272B3C
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.costPhantomAttrRecommendInfos_.AddEntriesFrom(ref input, PhantomAttrRecommendResponse._repeated_costPhantomAttrRecommendInfos_codec);
				}
			}
		}

		// Token: 0x04006AD1 RID: 27345
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006AD2 RID: 27346
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04006AD3 RID: 27347
		private ErrorCode errorCode_;

		// Token: 0x04006AD4 RID: 27348
		public const int CostPhantomAttrRecommendInfosFieldNumber = 5;

		// Token: 0x04006AD5 RID: 27349
		private static readonly FieldCodec<CostPhantomAttrRecommendInfo> _repeated_costPhantomAttrRecommendInfos_codec = FieldCodec.ForMessage<CostPhantomAttrRecommendInfo>(42U, CostPhantomAttrRecommendInfo.Parser);

		// Token: 0x04006AD6 RID: 27350
		private readonly RepeatedField<CostPhantomAttrRecommendInfo> costPhantomAttrRecommendInfos_ = new RepeatedField<CostPhantomAttrRecommendInfo>();
	}
}
