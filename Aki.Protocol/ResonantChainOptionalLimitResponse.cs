using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F1A RID: 3866
	[NetMessage(EMessageId.ResonantChainOptionalLimitResponse)]
	public sealed class ResonantChainOptionalLimitResponse : IMessage<ResonantChainOptionalLimitResponse>, IMessage, IEquatable<ResonantChainOptionalLimitResponse>, IDeepCloneable<ResonantChainOptionalLimitResponse>, IBufferMessage
	{
		// Token: 0x06014B73 RID: 84851 RVA: 0x0030206A File Offset: 0x0030026A
		[NullableContext(1)]
		public static ResonantChainOptionalLimitResponse Create()
		{
			return new ResonantChainOptionalLimitResponse();
		}

		// Token: 0x170044DD RID: 17629
		// (get) Token: 0x06014B74 RID: 84852 RVA: 0x00302071 File Offset: 0x00300271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044DE RID: 17630
		// (get) Token: 0x06014B75 RID: 84853 RVA: 0x00302074 File Offset: 0x00300274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResonantChainOptionalLimitResponse.Descriptor;
			}
		}

		// Token: 0x06014B76 RID: 84854 RVA: 0x0030207B File Offset: 0x0030027B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainOptionalLimitResponse()
		{
		}

		// Token: 0x06014B77 RID: 84855 RVA: 0x0030208E File Offset: 0x0030028E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainOptionalLimitResponse(ResonantChainOptionalLimitResponse other) : this()
		{
			this.limit_ = other.limit_;
			this.infos_ = other.infos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014B78 RID: 84856 RVA: 0x003020C4 File Offset: 0x003002C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainOptionalLimitResponse Clone()
		{
			return new ResonantChainOptionalLimitResponse(this);
		}

		// Token: 0x170044DF RID: 17631
		// (get) Token: 0x06014B79 RID: 84857 RVA: 0x003020CC File Offset: 0x003002CC
		// (set) Token: 0x06014B7A RID: 84858 RVA: 0x003020D4 File Offset: 0x003002D4
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

		// Token: 0x170044E0 RID: 17632
		// (get) Token: 0x06014B7B RID: 84859 RVA: 0x003020DD File Offset: 0x003002DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ResonantChainOptionalLimitInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x06014B7C RID: 84860 RVA: 0x003020E5 File Offset: 0x003002E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResonantChainOptionalLimitResponse);
		}

		// Token: 0x06014B7D RID: 84861 RVA: 0x003020F4 File Offset: 0x003002F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResonantChainOptionalLimitResponse other)
		{
			return other != null && (other == this || (this.Limit == other.Limit && this.infos_.Equals(other.infos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014B7E RID: 84862 RVA: 0x00302144 File Offset: 0x00300344
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

		// Token: 0x06014B7F RID: 84863 RVA: 0x00302191 File Offset: 0x00300391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014B80 RID: 84864 RVA: 0x0030219E File Offset: 0x0030039E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014B81 RID: 84865 RVA: 0x003021A8 File Offset: 0x003003A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Limit != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Limit);
			}
			this.infos_.WriteTo(ref output, ResonantChainOptionalLimitResponse._repeated_infos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014B82 RID: 84866 RVA: 0x003021F8 File Offset: 0x003003F8
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

		// Token: 0x06014B83 RID: 84867 RVA: 0x0030224C File Offset: 0x0030044C
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

		// Token: 0x06014B84 RID: 84868 RVA: 0x00302299 File Offset: 0x00300499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014B85 RID: 84869 RVA: 0x003022A4 File Offset: 0x003004A4
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
				if (num != 64U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.infos_.AddEntriesFrom(ref input, ResonantChainOptionalLimitResponse._repeated_infos_codec);
					}
				}
				else
				{
					this.Limit = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007D8B RID: 32139
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D8C RID: 32140
		public const int LimitFieldNumber = 8;

		// Token: 0x04007D8D RID: 32141
		private int limit_;

		// Token: 0x04007D8E RID: 32142
		public const int InfosFieldNumber = 14;

		// Token: 0x04007D8F RID: 32143
		private static readonly FieldCodec<ResonantChainOptionalLimitInfo> _repeated_infos_codec = FieldCodec.ForMessage<ResonantChainOptionalLimitInfo>(114U, ResonantChainOptionalLimitInfo.Parser);

		// Token: 0x04007D90 RID: 32144
		private readonly RepeatedField<ResonantChainOptionalLimitInfo> infos_ = new RepeatedField<ResonantChainOptionalLimitInfo>();
	}
}
