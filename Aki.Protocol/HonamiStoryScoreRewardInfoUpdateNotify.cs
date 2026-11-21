using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200078B RID: 1931
	[NetMessage(EMessageId.HonamiStoryScoreRewardInfoUpdateNotify)]
	public sealed class HonamiStoryScoreRewardInfoUpdateNotify : IMessage<HonamiStoryScoreRewardInfoUpdateNotify>, IMessage, IEquatable<HonamiStoryScoreRewardInfoUpdateNotify>, IDeepCloneable<HonamiStoryScoreRewardInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600AE93 RID: 44691 RVA: 0x001A364B File Offset: 0x001A184B
		[NullableContext(1)]
		public static HonamiStoryScoreRewardInfoUpdateNotify Create()
		{
			return new HonamiStoryScoreRewardInfoUpdateNotify();
		}

		// Token: 0x17002332 RID: 9010
		// (get) Token: 0x0600AE94 RID: 44692 RVA: 0x001A3652 File Offset: 0x001A1852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002333 RID: 9011
		// (get) Token: 0x0600AE95 RID: 44693 RVA: 0x001A3655 File Offset: 0x001A1855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryScoreRewardInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600AE96 RID: 44694 RVA: 0x001A365C File Offset: 0x001A185C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryScoreRewardInfoUpdateNotify()
		{
		}

		// Token: 0x0600AE97 RID: 44695 RVA: 0x001A366F File Offset: 0x001A186F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryScoreRewardInfoUpdateNotify(HonamiStoryScoreRewardInfoUpdateNotify other) : this()
		{
			this.honamiStoryScoreRewardInfos_ = other.honamiStoryScoreRewardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE98 RID: 44696 RVA: 0x001A3699 File Offset: 0x001A1899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryScoreRewardInfoUpdateNotify Clone()
		{
			return new HonamiStoryScoreRewardInfoUpdateNotify(this);
		}

		// Token: 0x17002334 RID: 9012
		// (get) Token: 0x0600AE99 RID: 44697 RVA: 0x001A36A1 File Offset: 0x001A18A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryScoreRewardInfo> HonamiStoryScoreRewardInfos
		{
			get
			{
				return this.honamiStoryScoreRewardInfos_;
			}
		}

		// Token: 0x0600AE9A RID: 44698 RVA: 0x001A36A9 File Offset: 0x001A18A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryScoreRewardInfoUpdateNotify);
		}

		// Token: 0x0600AE9B RID: 44699 RVA: 0x001A36B7 File Offset: 0x001A18B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryScoreRewardInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.honamiStoryScoreRewardInfos_.Equals(other.honamiStoryScoreRewardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AE9C RID: 44700 RVA: 0x001A36EC File Offset: 0x001A18EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.honamiStoryScoreRewardInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AE9D RID: 44701 RVA: 0x001A3720 File Offset: 0x001A1920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AE9E RID: 44702 RVA: 0x001A372D File Offset: 0x001A192D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE9F RID: 44703 RVA: 0x001A3736 File Offset: 0x001A1936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.honamiStoryScoreRewardInfos_.WriteTo(ref output, HonamiStoryScoreRewardInfoUpdateNotify._repeated_honamiStoryScoreRewardInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AEA0 RID: 44704 RVA: 0x001A3760 File Offset: 0x001A1960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.honamiStoryScoreRewardInfos_.CalculateSize(HonamiStoryScoreRewardInfoUpdateNotify._repeated_honamiStoryScoreRewardInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AEA1 RID: 44705 RVA: 0x001A3799 File Offset: 0x001A1999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryScoreRewardInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.honamiStoryScoreRewardInfos_.Add(other.honamiStoryScoreRewardInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AEA2 RID: 44706 RVA: 0x001A37C7 File Offset: 0x001A19C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AEA3 RID: 44707 RVA: 0x001A37D0 File Offset: 0x001A19D0
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.honamiStoryScoreRewardInfos_.AddEntriesFrom(ref input, HonamiStoryScoreRewardInfoUpdateNotify._repeated_honamiStoryScoreRewardInfos_codec);
				}
			}
		}

		// Token: 0x04004F12 RID: 20242
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F13 RID: 20243
		public const int HonamiStoryScoreRewardInfosFieldNumber = 13;

		// Token: 0x04004F14 RID: 20244
		private static readonly FieldCodec<HonamiStoryScoreRewardInfo> _repeated_honamiStoryScoreRewardInfos_codec = FieldCodec.ForMessage<HonamiStoryScoreRewardInfo>(106U, HonamiStoryScoreRewardInfo.Parser);

		// Token: 0x04004F15 RID: 20245
		private readonly RepeatedField<HonamiStoryScoreRewardInfo> honamiStoryScoreRewardInfos_ = new RepeatedField<HonamiStoryScoreRewardInfo>();
	}
}
