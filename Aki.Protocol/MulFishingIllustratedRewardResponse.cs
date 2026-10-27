using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ADD RID: 2781
	[NetMessage(EMessageId.MulFishingIllustratedRewardResponse)]
	public sealed class MulFishingIllustratedRewardResponse : IMessage<MulFishingIllustratedRewardResponse>, IMessage, IEquatable<MulFishingIllustratedRewardResponse>, IDeepCloneable<MulFishingIllustratedRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F1F7 RID: 61943 RVA: 0x002355E4 File Offset: 0x002337E4
		[NullableContext(1)]
		public static MulFishingIllustratedRewardResponse Create()
		{
			return new MulFishingIllustratedRewardResponse();
		}

		// Token: 0x17003145 RID: 12613
		// (get) Token: 0x0600F1F8 RID: 61944 RVA: 0x002355EB File Offset: 0x002337EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003146 RID: 12614
		// (get) Token: 0x0600F1F9 RID: 61945 RVA: 0x002355EE File Offset: 0x002337EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulFishingIllustratedRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F1FA RID: 61946 RVA: 0x002355F5 File Offset: 0x002337F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulFishingIllustratedRewardResponse()
		{
		}

		// Token: 0x0600F1FB RID: 61947 RVA: 0x00235608 File Offset: 0x00233808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulFishingIllustratedRewardResponse(MulFishingIllustratedRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rewardId_ = other.rewardId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F1FC RID: 61948 RVA: 0x0023563E File Offset: 0x0023383E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulFishingIllustratedRewardResponse Clone()
		{
			return new MulFishingIllustratedRewardResponse(this);
		}

		// Token: 0x17003147 RID: 12615
		// (get) Token: 0x0600F1FD RID: 61949 RVA: 0x00235646 File Offset: 0x00233846
		// (set) Token: 0x0600F1FE RID: 61950 RVA: 0x0023564E File Offset: 0x0023384E
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

		// Token: 0x17003148 RID: 12616
		// (get) Token: 0x0600F1FF RID: 61951 RVA: 0x00235657 File Offset: 0x00233857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardId
		{
			get
			{
				return this.rewardId_;
			}
		}

		// Token: 0x0600F200 RID: 61952 RVA: 0x0023565F File Offset: 0x0023385F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulFishingIllustratedRewardResponse);
		}

		// Token: 0x0600F201 RID: 61953 RVA: 0x00235670 File Offset: 0x00233870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulFishingIllustratedRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.rewardId_.Equals(other.rewardId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F202 RID: 61954 RVA: 0x002356C0 File Offset: 0x002338C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.rewardId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F203 RID: 61955 RVA: 0x00235713 File Offset: 0x00233913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F204 RID: 61956 RVA: 0x00235720 File Offset: 0x00233920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F205 RID: 61957 RVA: 0x0023572C File Offset: 0x0023392C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardId_.WriteTo(ref output, MulFishingIllustratedRewardResponse._repeated_rewardId_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F206 RID: 61958 RVA: 0x0023577C File Offset: 0x0023397C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.rewardId_.CalculateSize(MulFishingIllustratedRewardResponse._repeated_rewardId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F207 RID: 61959 RVA: 0x002357D0 File Offset: 0x002339D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulFishingIllustratedRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.rewardId_.Add(other.rewardId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F208 RID: 61960 RVA: 0x0023581D File Offset: 0x00233A1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F209 RID: 61961 RVA: 0x00235828 File Offset: 0x00233A28
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
				if (num != 24U && num != 26U)
				{
					if (num != 112U)
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
					this.rewardId_.AddEntriesFrom(ref input, MulFishingIllustratedRewardResponse._repeated_rewardId_codec);
				}
			}
		}

		// Token: 0x040061AC RID: 25004
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061AD RID: 25005
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040061AE RID: 25006
		private ErrorCode errorCode_;

		// Token: 0x040061AF RID: 25007
		public const int RewardIdFieldNumber = 3;

		// Token: 0x040061B0 RID: 25008
		private static readonly FieldCodec<int> _repeated_rewardId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040061B1 RID: 25009
		private readonly RepeatedField<int> rewardId_ = new RepeatedField<int>();
	}
}
