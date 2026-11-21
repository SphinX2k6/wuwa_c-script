using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000306 RID: 774
	[NetMessage(EMessageId.CoopSpRewardRequest)]
	public sealed class CoopSpRewardRequest : IMessage<CoopSpRewardRequest>, IMessage, IEquatable<CoopSpRewardRequest>, IDeepCloneable<CoopSpRewardRequest>, IBufferMessage
	{
		// Token: 0x06004E60 RID: 20064 RVA: 0x000BEB9D File Offset: 0x000BCD9D
		[NullableContext(1)]
		public static CoopSpRewardRequest Create()
		{
			return new CoopSpRewardRequest();
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x06004E61 RID: 20065 RVA: 0x000BEBA4 File Offset: 0x000BCDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x06004E62 RID: 20066 RVA: 0x000BEBA7 File Offset: 0x000BCDA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CoopSpRewardRequest.Descriptor;
			}
		}

		// Token: 0x06004E63 RID: 20067 RVA: 0x000BEBAE File Offset: 0x000BCDAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopSpRewardRequest()
		{
		}

		// Token: 0x06004E64 RID: 20068 RVA: 0x000BEBC1 File Offset: 0x000BCDC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopSpRewardRequest(CoopSpRewardRequest other) : this()
		{
			this.rewardIds_ = other.rewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004E65 RID: 20069 RVA: 0x000BEBEB File Offset: 0x000BCDEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopSpRewardRequest Clone()
		{
			return new CoopSpRewardRequest(this);
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06004E66 RID: 20070 RVA: 0x000BEBF3 File Offset: 0x000BCDF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIds
		{
			get
			{
				return this.rewardIds_;
			}
		}

		// Token: 0x06004E67 RID: 20071 RVA: 0x000BEBFB File Offset: 0x000BCDFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CoopSpRewardRequest);
		}

		// Token: 0x06004E68 RID: 20072 RVA: 0x000BEC09 File Offset: 0x000BCE09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CoopSpRewardRequest other)
		{
			return other != null && (other == this || (this.rewardIds_.Equals(other.rewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004E69 RID: 20073 RVA: 0x000BEC3C File Offset: 0x000BCE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rewardIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004E6A RID: 20074 RVA: 0x000BEC70 File Offset: 0x000BCE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004E6B RID: 20075 RVA: 0x000BEC7D File Offset: 0x000BCE7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E6C RID: 20076 RVA: 0x000BEC86 File Offset: 0x000BCE86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardIds_.WriteTo(ref output, CoopSpRewardRequest._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004E6D RID: 20077 RVA: 0x000BECB0 File Offset: 0x000BCEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewardIds_.CalculateSize(CoopSpRewardRequest._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004E6E RID: 20078 RVA: 0x000BECE9 File Offset: 0x000BCEE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CoopSpRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.rewardIds_.Add(other.rewardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004E6F RID: 20079 RVA: 0x000BED17 File Offset: 0x000BCF17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E70 RID: 20080 RVA: 0x000BED20 File Offset: 0x000BCF20
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rewardIds_.AddEntriesFrom(ref input, CoopSpRewardRequest._repeated_rewardIds_codec);
				}
			}
		}

		// Token: 0x040031E8 RID: 12776
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031E9 RID: 12777
		public const int RewardIdsFieldNumber = 3;

		// Token: 0x040031EA RID: 12778
		private static readonly FieldCodec<int> _repeated_rewardIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040031EB RID: 12779
		private readonly RepeatedField<int> rewardIds_ = new RepeatedField<int>();
	}
}
