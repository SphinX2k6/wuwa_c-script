using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F2A RID: 3882
	[NetMessage(EMessageId.ResonantChainOptionalLimitResponse)]
	public sealed class ResonantChainOptionalLimitResponse : IMessage<ResonantChainOptionalLimitResponse>, IMessage, IEquatable<ResonantChainOptionalLimitResponse>, IDeepCloneable<ResonantChainOptionalLimitResponse>, IBufferMessage
	{
		// Token: 0x06014C58 RID: 85080 RVA: 0x00303726 File Offset: 0x00301926
		[NullableContext(1)]
		public static ResonantChainOptionalLimitResponse Create()
		{
			return new ResonantChainOptionalLimitResponse();
		}

		// Token: 0x17004507 RID: 17671
		// (get) Token: 0x06014C59 RID: 85081 RVA: 0x0030372D File Offset: 0x0030192D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004508 RID: 17672
		// (get) Token: 0x06014C5A RID: 85082 RVA: 0x00303730 File Offset: 0x00301930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResonantChainOptionalLimitResponse.Descriptor;
			}
		}

		// Token: 0x06014C5B RID: 85083 RVA: 0x00303737 File Offset: 0x00301937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainOptionalLimitResponse()
		{
		}

		// Token: 0x06014C5C RID: 85084 RVA: 0x0030374A File Offset: 0x0030194A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainOptionalLimitResponse(ResonantChainOptionalLimitResponse other) : this()
		{
			this.limit_ = other.limit_;
			this.infos_ = other.infos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014C5D RID: 85085 RVA: 0x00303780 File Offset: 0x00301980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainOptionalLimitResponse Clone()
		{
			return new ResonantChainOptionalLimitResponse(this);
		}

		// Token: 0x17004509 RID: 17673
		// (get) Token: 0x06014C5E RID: 85086 RVA: 0x00303788 File Offset: 0x00301988
		// (set) Token: 0x06014C5F RID: 85087 RVA: 0x00303790 File Offset: 0x00301990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Limit
		{
			get
			{
				return this.limit_;
			}
			set
			{
				this.limit_ = value;
			}
		}

		// Token: 0x1700450A RID: 17674
		// (get) Token: 0x06014C60 RID: 85088 RVA: 0x00303799 File Offset: 0x00301999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ResonantChainOptionalLimitInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x06014C61 RID: 85089 RVA: 0x003037A1 File Offset: 0x003019A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResonantChainOptionalLimitResponse);
		}

		// Token: 0x06014C62 RID: 85090 RVA: 0x003037B0 File Offset: 0x003019B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResonantChainOptionalLimitResponse other)
		{
			return other != null && (other == this || (this.Limit == other.Limit && this.infos_.Equals(other.infos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014C63 RID: 85091 RVA: 0x00303800 File Offset: 0x00301A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Limit != 0)
			{
				num ^= this.Limit.GetHashCode();
			}
			num ^= this.infos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014C64 RID: 85092 RVA: 0x0030384D File Offset: 0x00301A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014C65 RID: 85093 RVA: 0x0030385A File Offset: 0x00301A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014C66 RID: 85094 RVA: 0x00303864 File Offset: 0x00301A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.infos_.WriteTo(ref output, ResonantChainOptionalLimitResponse._repeated_infos_codec);
			if (this.Limit != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Limit);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014C67 RID: 85095 RVA: 0x003038B4 File Offset: 0x00301AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Limit != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Limit);
			}
			num += this.infos_.CalculateSize(ResonantChainOptionalLimitResponse._repeated_infos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014C68 RID: 85096 RVA: 0x00303908 File Offset: 0x00301B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ResonantChainOptionalLimitResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Limit != 0)
			{
				this.Limit = other.Limit;
			}
			this.infos_.Add(other.infos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014C69 RID: 85097 RVA: 0x00303955 File Offset: 0x00301B55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014C6A RID: 85098 RVA: 0x00303960 File Offset: 0x00301B60
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
				if (num != 82U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Limit = input.ReadInt32();
					}
				}
				else
				{
					this.infos_.AddEntriesFrom(ref input, ResonantChainOptionalLimitResponse._repeated_infos_codec);
				}
			}
		}

		// Token: 0x04007D61 RID: 32097
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D62 RID: 32098
		public const int LimitFieldNumber = 14;

		// Token: 0x04007D63 RID: 32099
		private int limit_;

		// Token: 0x04007D64 RID: 32100
		public const int InfosFieldNumber = 10;

		// Token: 0x04007D65 RID: 32101
		private static readonly FieldCodec<ResonantChainOptionalLimitInfo> _repeated_infos_codec = FieldCodec.ForMessage<ResonantChainOptionalLimitInfo>(82U, ResonantChainOptionalLimitInfo.Parser);

		// Token: 0x04007D66 RID: 32102
		private readonly RepeatedField<ResonantChainOptionalLimitInfo> infos_ = new RepeatedField<ResonantChainOptionalLimitInfo>();
	}
}
