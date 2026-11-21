using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AD4 RID: 2772
	[NetMessage(EMessageId.MulPhantomBattleMasterLevelRewardResponse)]
	public sealed class MulPhantomBattleMasterLevelRewardResponse : IMessage<MulPhantomBattleMasterLevelRewardResponse>, IMessage, IEquatable<MulPhantomBattleMasterLevelRewardResponse>, IDeepCloneable<MulPhantomBattleMasterLevelRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F177 RID: 61815 RVA: 0x002346F3 File Offset: 0x002328F3
		[NullableContext(1)]
		public static MulPhantomBattleMasterLevelRewardResponse Create()
		{
			return new MulPhantomBattleMasterLevelRewardResponse();
		}

		// Token: 0x17003124 RID: 12580
		// (get) Token: 0x0600F178 RID: 61816 RVA: 0x002346FA File Offset: 0x002328FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003125 RID: 12581
		// (get) Token: 0x0600F179 RID: 61817 RVA: 0x002346FD File Offset: 0x002328FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulPhantomBattleMasterLevelRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F17A RID: 61818 RVA: 0x00234704 File Offset: 0x00232904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulPhantomBattleMasterLevelRewardResponse()
		{
		}

		// Token: 0x0600F17B RID: 61819 RVA: 0x00234717 File Offset: 0x00232917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulPhantomBattleMasterLevelRewardResponse(MulPhantomBattleMasterLevelRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomBattleMasterLevelId_ = other.phantomBattleMasterLevelId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F17C RID: 61820 RVA: 0x0023474D File Offset: 0x0023294D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulPhantomBattleMasterLevelRewardResponse Clone()
		{
			return new MulPhantomBattleMasterLevelRewardResponse(this);
		}

		// Token: 0x17003126 RID: 12582
		// (get) Token: 0x0600F17D RID: 61821 RVA: 0x00234755 File Offset: 0x00232955
		// (set) Token: 0x0600F17E RID: 61822 RVA: 0x0023475D File Offset: 0x0023295D
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

		// Token: 0x17003127 RID: 12583
		// (get) Token: 0x0600F17F RID: 61823 RVA: 0x00234766 File Offset: 0x00232966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PhantomBattleMasterLevelId
		{
			get
			{
				return this.phantomBattleMasterLevelId_;
			}
		}

		// Token: 0x0600F180 RID: 61824 RVA: 0x0023476E File Offset: 0x0023296E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulPhantomBattleMasterLevelRewardResponse);
		}

		// Token: 0x0600F181 RID: 61825 RVA: 0x0023477C File Offset: 0x0023297C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulPhantomBattleMasterLevelRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.phantomBattleMasterLevelId_.Equals(other.phantomBattleMasterLevelId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F182 RID: 61826 RVA: 0x002347CC File Offset: 0x002329CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.phantomBattleMasterLevelId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F183 RID: 61827 RVA: 0x0023481F File Offset: 0x00232A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F184 RID: 61828 RVA: 0x0023482C File Offset: 0x00232A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F185 RID: 61829 RVA: 0x00234838 File Offset: 0x00232A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleMasterLevelId_.WriteTo(ref output, MulPhantomBattleMasterLevelRewardResponse._repeated_phantomBattleMasterLevelId_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F186 RID: 61830 RVA: 0x00234888 File Offset: 0x00232A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.phantomBattleMasterLevelId_.CalculateSize(MulPhantomBattleMasterLevelRewardResponse._repeated_phantomBattleMasterLevelId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F187 RID: 61831 RVA: 0x002348DC File Offset: 0x00232ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulPhantomBattleMasterLevelRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.phantomBattleMasterLevelId_.Add(other.phantomBattleMasterLevelId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F188 RID: 61832 RVA: 0x00234929 File Offset: 0x00232B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F189 RID: 61833 RVA: 0x00234934 File Offset: 0x00232B34
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
				if (num != 40U && num != 42U)
				{
					if (num != 56U)
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
					this.phantomBattleMasterLevelId_.AddEntriesFrom(ref input, MulPhantomBattleMasterLevelRewardResponse._repeated_phantomBattleMasterLevelId_codec);
				}
			}
		}

		// Token: 0x040061DF RID: 25055
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061E0 RID: 25056
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040061E1 RID: 25057
		private ErrorCode errorCode_;

		// Token: 0x040061E2 RID: 25058
		public const int PhantomBattleMasterLevelIdFieldNumber = 5;

		// Token: 0x040061E3 RID: 25059
		private static readonly FieldCodec<int> _repeated_phantomBattleMasterLevelId_codec = FieldCodec.ForInt32(42U);

		// Token: 0x040061E4 RID: 25060
		private readonly RepeatedField<int> phantomBattleMasterLevelId_ = new RepeatedField<int>();
	}
}
