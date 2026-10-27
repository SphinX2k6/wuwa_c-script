using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AE7 RID: 2791
	[NetMessage(EMessageId.MulRoguelikeWriteCatRewardResponse)]
	public sealed class MulRoguelikeWriteCatRewardResponse : IMessage<MulRoguelikeWriteCatRewardResponse>, IMessage, IEquatable<MulRoguelikeWriteCatRewardResponse>, IDeepCloneable<MulRoguelikeWriteCatRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F2B9 RID: 62137 RVA: 0x00236E57 File Offset: 0x00235057
		[NullableContext(1)]
		public static MulRoguelikeWriteCatRewardResponse Create()
		{
			return new MulRoguelikeWriteCatRewardResponse();
		}

		// Token: 0x1700316A RID: 12650
		// (get) Token: 0x0600F2BA RID: 62138 RVA: 0x00236E5E File Offset: 0x0023505E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700316B RID: 12651
		// (get) Token: 0x0600F2BB RID: 62139 RVA: 0x00236E61 File Offset: 0x00235061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulRoguelikeWriteCatRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F2BC RID: 62140 RVA: 0x00236E68 File Offset: 0x00235068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulRoguelikeWriteCatRewardResponse()
		{
		}

		// Token: 0x0600F2BD RID: 62141 RVA: 0x00236E7B File Offset: 0x0023507B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulRoguelikeWriteCatRewardResponse(MulRoguelikeWriteCatRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.index_ = other.index_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F2BE RID: 62142 RVA: 0x00236EB1 File Offset: 0x002350B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulRoguelikeWriteCatRewardResponse Clone()
		{
			return new MulRoguelikeWriteCatRewardResponse(this);
		}

		// Token: 0x1700316C RID: 12652
		// (get) Token: 0x0600F2BF RID: 62143 RVA: 0x00236EB9 File Offset: 0x002350B9
		// (set) Token: 0x0600F2C0 RID: 62144 RVA: 0x00236EC1 File Offset: 0x002350C1
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

		// Token: 0x1700316D RID: 12653
		// (get) Token: 0x0600F2C1 RID: 62145 RVA: 0x00236ECA File Offset: 0x002350CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Index
		{
			get
			{
				return this.index_;
			}
		}

		// Token: 0x0600F2C2 RID: 62146 RVA: 0x00236ED2 File Offset: 0x002350D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulRoguelikeWriteCatRewardResponse);
		}

		// Token: 0x0600F2C3 RID: 62147 RVA: 0x00236EE0 File Offset: 0x002350E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulRoguelikeWriteCatRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.index_.Equals(other.index_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F2C4 RID: 62148 RVA: 0x00236F30 File Offset: 0x00235130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.index_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F2C5 RID: 62149 RVA: 0x00236F83 File Offset: 0x00235183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F2C6 RID: 62150 RVA: 0x00236F90 File Offset: 0x00235190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F2C7 RID: 62151 RVA: 0x00236F9C File Offset: 0x0023519C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.index_.WriteTo(ref output, MulRoguelikeWriteCatRewardResponse._repeated_index_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F2C8 RID: 62152 RVA: 0x00236FEC File Offset: 0x002351EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.index_.CalculateSize(MulRoguelikeWriteCatRewardResponse._repeated_index_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F2C9 RID: 62153 RVA: 0x00237040 File Offset: 0x00235240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulRoguelikeWriteCatRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.index_.Add(other.index_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F2CA RID: 62154 RVA: 0x0023708D File Offset: 0x0023528D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F2CB RID: 62155 RVA: 0x00237098 File Offset: 0x00235298
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
				if (num != 32U && num != 34U)
				{
					if (num != 80U)
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
					this.index_.AddEntriesFrom(ref input, MulRoguelikeWriteCatRewardResponse._repeated_index_codec);
				}
			}
		}

		// Token: 0x040061E2 RID: 25058
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061E3 RID: 25059
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040061E4 RID: 25060
		private ErrorCode errorCode_;

		// Token: 0x040061E5 RID: 25061
		public const int IndexFieldNumber = 4;

		// Token: 0x040061E6 RID: 25062
		private static readonly FieldCodec<int> _repeated_index_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040061E7 RID: 25063
		private readonly RepeatedField<int> index_ = new RepeatedField<int>();
	}
}
