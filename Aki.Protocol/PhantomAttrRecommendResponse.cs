using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C19 RID: 3097
	[NetMessage(EMessageId.PhantomAttrRecommendResponse)]
	public sealed class PhantomAttrRecommendResponse : IMessage<PhantomAttrRecommendResponse>, IMessage, IEquatable<PhantomAttrRecommendResponse>, IDeepCloneable<PhantomAttrRecommendResponse>, IBufferMessage
	{
		// Token: 0x06010CFB RID: 68859 RVA: 0x0027645D File Offset: 0x0027465D
		[NullableContext(1)]
		public static PhantomAttrRecommendResponse Create()
		{
			return new PhantomAttrRecommendResponse();
		}

		// Token: 0x1700377E RID: 14206
		// (get) Token: 0x06010CFC RID: 68860 RVA: 0x00276464 File Offset: 0x00274664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700377F RID: 14207
		// (get) Token: 0x06010CFD RID: 68861 RVA: 0x00276467 File Offset: 0x00274667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomAttrRecommendResponse.Descriptor;
			}
		}

		// Token: 0x06010CFE RID: 68862 RVA: 0x0027646E File Offset: 0x0027466E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAttrRecommendResponse()
		{
		}

		// Token: 0x06010CFF RID: 68863 RVA: 0x00276481 File Offset: 0x00274681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAttrRecommendResponse(PhantomAttrRecommendResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.costPhantomAttrRecommendInfos_ = other.costPhantomAttrRecommendInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010D00 RID: 68864 RVA: 0x002764B7 File Offset: 0x002746B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAttrRecommendResponse Clone()
		{
			return new PhantomAttrRecommendResponse(this);
		}

		// Token: 0x17003780 RID: 14208
		// (get) Token: 0x06010D01 RID: 68865 RVA: 0x002764BF File Offset: 0x002746BF
		// (set) Token: 0x06010D02 RID: 68866 RVA: 0x002764C7 File Offset: 0x002746C7
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

		// Token: 0x17003781 RID: 14209
		// (get) Token: 0x06010D03 RID: 68867 RVA: 0x002764D0 File Offset: 0x002746D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CostPhantomAttrRecommendInfo> CostPhantomAttrRecommendInfos
		{
			get
			{
				return this.costPhantomAttrRecommendInfos_;
			}
		}

		// Token: 0x06010D04 RID: 68868 RVA: 0x002764D8 File Offset: 0x002746D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomAttrRecommendResponse);
		}

		// Token: 0x06010D05 RID: 68869 RVA: 0x002764E8 File Offset: 0x002746E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomAttrRecommendResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.costPhantomAttrRecommendInfos_.Equals(other.costPhantomAttrRecommendInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010D06 RID: 68870 RVA: 0x00276538 File Offset: 0x00274738
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

		// Token: 0x06010D07 RID: 68871 RVA: 0x0027658B File Offset: 0x0027478B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010D08 RID: 68872 RVA: 0x00276598 File Offset: 0x00274798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010D09 RID: 68873 RVA: 0x002765A4 File Offset: 0x002747A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.costPhantomAttrRecommendInfos_.WriteTo(ref output, PhantomAttrRecommendResponse._repeated_costPhantomAttrRecommendInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010D0A RID: 68874 RVA: 0x002765F4 File Offset: 0x002747F4
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

		// Token: 0x06010D0B RID: 68875 RVA: 0x00276648 File Offset: 0x00274848
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

		// Token: 0x06010D0C RID: 68876 RVA: 0x00276695 File Offset: 0x00274895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010D0D RID: 68877 RVA: 0x002766A0 File Offset: 0x002748A0
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
				if (num != 50U)
				{
					if (num != 64U)
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

		// Token: 0x04006ABD RID: 27325
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006ABE RID: 27326
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04006ABF RID: 27327
		private ErrorCode errorCode_;

		// Token: 0x04006AC0 RID: 27328
		public const int CostPhantomAttrRecommendInfosFieldNumber = 6;

		// Token: 0x04006AC1 RID: 27329
		private static readonly FieldCodec<CostPhantomAttrRecommendInfo> _repeated_costPhantomAttrRecommendInfos_codec = FieldCodec.ForMessage<CostPhantomAttrRecommendInfo>(50U, CostPhantomAttrRecommendInfo.Parser);

		// Token: 0x04006AC2 RID: 27330
		private readonly RepeatedField<CostPhantomAttrRecommendInfo> costPhantomAttrRecommendInfos_ = new RepeatedField<CostPhantomAttrRecommendInfo>();
	}
}
