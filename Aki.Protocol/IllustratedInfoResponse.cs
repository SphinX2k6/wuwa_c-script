using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007C7 RID: 1991
	[NetMessage(EMessageId.IllustratedInfoResponse)]
	public sealed class IllustratedInfoResponse : IMessage<IllustratedInfoResponse>, IMessage, IEquatable<IllustratedInfoResponse>, IDeepCloneable<IllustratedInfoResponse>, IBufferMessage
	{
		// Token: 0x0600B31D RID: 45853 RVA: 0x001ACC81 File Offset: 0x001AAE81
		[NullableContext(1)]
		public static IllustratedInfoResponse Create()
		{
			return new IllustratedInfoResponse();
		}

		// Token: 0x17002426 RID: 9254
		// (get) Token: 0x0600B31E RID: 45854 RVA: 0x001ACC88 File Offset: 0x001AAE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002427 RID: 9255
		// (get) Token: 0x0600B31F RID: 45855 RVA: 0x001ACC8B File Offset: 0x001AAE8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IllustratedInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600B320 RID: 45856 RVA: 0x001ACC92 File Offset: 0x001AAE92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedInfoResponse()
		{
		}

		// Token: 0x0600B321 RID: 45857 RVA: 0x001ACCB0 File Offset: 0x001AAEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedInfoResponse(IllustratedInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this.illustratedClassList_ = other.illustratedClassList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B322 RID: 45858 RVA: 0x001ACD02 File Offset: 0x001AAF02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedInfoResponse Clone()
		{
			return new IllustratedInfoResponse(this);
		}

		// Token: 0x17002428 RID: 9256
		// (get) Token: 0x0600B323 RID: 45859 RVA: 0x001ACD0A File Offset: 0x001AAF0A
		// (set) Token: 0x0600B324 RID: 45860 RVA: 0x001ACD12 File Offset: 0x001AAF12
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

		// Token: 0x17002429 RID: 9257
		// (get) Token: 0x0600B325 RID: 45861 RVA: 0x001ACD1B File Offset: 0x001AAF1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x1700242A RID: 9258
		// (get) Token: 0x0600B326 RID: 45862 RVA: 0x001ACD23 File Offset: 0x001AAF23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<IllustratedClass> IllustratedClassList
		{
			get
			{
				return this.illustratedClassList_;
			}
		}

		// Token: 0x0600B327 RID: 45863 RVA: 0x001ACD2B File Offset: 0x001AAF2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IllustratedInfoResponse);
		}

		// Token: 0x0600B328 RID: 45864 RVA: 0x001ACD3C File Offset: 0x001AAF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IllustratedInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && this.illustratedClassList_.Equals(other.illustratedClassList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B329 RID: 45865 RVA: 0x001ACDA0 File Offset: 0x001AAFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.errorParams_.GetHashCode();
			num ^= this.illustratedClassList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B32A RID: 45866 RVA: 0x001ACE01 File Offset: 0x001AB001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B32B RID: 45867 RVA: 0x001ACE0E File Offset: 0x001AB00E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B32C RID: 45868 RVA: 0x001ACE18 File Offset: 0x001AB018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.errorParams_.WriteTo(ref output, IllustratedInfoResponse._repeated_errorParams_codec);
			this.illustratedClassList_.WriteTo(ref output, IllustratedInfoResponse._repeated_illustratedClassList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B32D RID: 45869 RVA: 0x001ACE78 File Offset: 0x001AB078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(IllustratedInfoResponse._repeated_errorParams_codec);
			num += this.illustratedClassList_.CalculateSize(IllustratedInfoResponse._repeated_illustratedClassList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B32E RID: 45870 RVA: 0x001ACEDC File Offset: 0x001AB0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IllustratedInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.errorParams_.Add(other.errorParams_);
			this.illustratedClassList_.Add(other.illustratedClassList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B32F RID: 45871 RVA: 0x001ACF3A File Offset: 0x001AB13A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B330 RID: 45872 RVA: 0x001ACF44 File Offset: 0x001AB144
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
					if (num != 98U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.illustratedClassList_.AddEntriesFrom(ref input, IllustratedInfoResponse._repeated_illustratedClassList_codec);
						}
					}
					else
					{
						this.errorParams_.AddEntriesFrom(ref input, IllustratedInfoResponse._repeated_errorParams_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004FF7 RID: 20471
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FF8 RID: 20472
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04004FF9 RID: 20473
		private ErrorCode errorCode_;

		// Token: 0x04004FFA RID: 20474
		public const int ErrorParamsFieldNumber = 12;

		// Token: 0x04004FFB RID: 20475
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(98U);

		// Token: 0x04004FFC RID: 20476
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();

		// Token: 0x04004FFD RID: 20477
		public const int IllustratedClassListFieldNumber = 13;

		// Token: 0x04004FFE RID: 20478
		private static readonly FieldCodec<IllustratedClass> _repeated_illustratedClassList_codec = FieldCodec.ForMessage<IllustratedClass>(106U, IllustratedClass.Parser);

		// Token: 0x04004FFF RID: 20479
		private readonly RepeatedField<IllustratedClass> illustratedClassList_ = new RepeatedField<IllustratedClass>();
	}
}
