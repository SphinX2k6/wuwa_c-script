using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000644 RID: 1604
	[NetMessage(EMessageId.FriendRecentlyTeamUpdateNotify)]
	public sealed class FriendRecentlyTeamUpdateNotify : IMessage<FriendRecentlyTeamUpdateNotify>, IMessage, IEquatable<FriendRecentlyTeamUpdateNotify>, IDeepCloneable<FriendRecentlyTeamUpdateNotify>, IBufferMessage
	{
		// Token: 0x060093D8 RID: 37848 RVA: 0x00165804 File Offset: 0x00163A04
		[NullableContext(1)]
		public static FriendRecentlyTeamUpdateNotify Create()
		{
			return new FriendRecentlyTeamUpdateNotify();
		}

		// Token: 0x17001D65 RID: 7525
		// (get) Token: 0x060093D9 RID: 37849 RVA: 0x0016580B File Offset: 0x00163A0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D66 RID: 7526
		// (get) Token: 0x060093DA RID: 37850 RVA: 0x0016580E File Offset: 0x00163A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendRecentlyTeamUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060093DB RID: 37851 RVA: 0x00165815 File Offset: 0x00163A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRecentlyTeamUpdateNotify()
		{
		}

		// Token: 0x060093DC RID: 37852 RVA: 0x00165840 File Offset: 0x00163A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRecentlyTeamUpdateNotify(FriendRecentlyTeamUpdateNotify other) : this()
		{
			this.addInfos_ = other.addInfos_.Clone();
			this.timeUpdate_ = other.timeUpdate_.Clone();
			this.removeIds_ = other.removeIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060093DD RID: 37853 RVA: 0x00165897 File Offset: 0x00163A97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRecentlyTeamUpdateNotify Clone()
		{
			return new FriendRecentlyTeamUpdateNotify(this);
		}

		// Token: 0x17001D67 RID: 7527
		// (get) Token: 0x060093DE RID: 37854 RVA: 0x0016589F File Offset: 0x00163A9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RecentlyTeamInfo> AddInfos
		{
			get
			{
				return this.addInfos_;
			}
		}

		// Token: 0x17001D68 RID: 7528
		// (get) Token: 0x060093DF RID: 37855 RVA: 0x001658A7 File Offset: 0x00163AA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, long> TimeUpdate
		{
			get
			{
				return this.timeUpdate_;
			}
		}

		// Token: 0x17001D69 RID: 7529
		// (get) Token: 0x060093E0 RID: 37856 RVA: 0x001658AF File Offset: 0x00163AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RemoveIds
		{
			get
			{
				return this.removeIds_;
			}
		}

		// Token: 0x060093E1 RID: 37857 RVA: 0x001658B7 File Offset: 0x00163AB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendRecentlyTeamUpdateNotify);
		}

		// Token: 0x060093E2 RID: 37858 RVA: 0x001658C8 File Offset: 0x00163AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendRecentlyTeamUpdateNotify other)
		{
			return other != null && (other == this || (this.addInfos_.Equals(other.addInfos_) && this.TimeUpdate.Equals(other.TimeUpdate) && this.removeIds_.Equals(other.removeIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060093E3 RID: 37859 RVA: 0x00165930 File Offset: 0x00163B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.addInfos_.GetHashCode();
			num ^= this.TimeUpdate.GetHashCode();
			num ^= this.removeIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060093E4 RID: 37860 RVA: 0x00165980 File Offset: 0x00163B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060093E5 RID: 37861 RVA: 0x0016598D File Offset: 0x00163B8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060093E6 RID: 37862 RVA: 0x00165998 File Offset: 0x00163B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.timeUpdate_.WriteTo(ref output, FriendRecentlyTeamUpdateNotify._map_timeUpdate_codec);
			this.addInfos_.WriteTo(ref output, FriendRecentlyTeamUpdateNotify._repeated_addInfos_codec);
			this.removeIds_.WriteTo(ref output, FriendRecentlyTeamUpdateNotify._repeated_removeIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060093E7 RID: 37863 RVA: 0x001659EC File Offset: 0x00163BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.addInfos_.CalculateSize(FriendRecentlyTeamUpdateNotify._repeated_addInfos_codec);
			num += this.timeUpdate_.CalculateSize(FriendRecentlyTeamUpdateNotify._map_timeUpdate_codec);
			num += this.removeIds_.CalculateSize(FriendRecentlyTeamUpdateNotify._repeated_removeIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060093E8 RID: 37864 RVA: 0x00165A4C File Offset: 0x00163C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendRecentlyTeamUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.addInfos_.Add(other.addInfos_);
			this.timeUpdate_.MergeFrom(other.timeUpdate_);
			this.removeIds_.Add(other.removeIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060093E9 RID: 37865 RVA: 0x00165AA7 File Offset: 0x00163CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060093EA RID: 37866 RVA: 0x00165AB0 File Offset: 0x00163CB0
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
				if (num <= 42U)
				{
					if (num == 10U)
					{
						this.timeUpdate_.AddEntriesFrom(ref input, FriendRecentlyTeamUpdateNotify._map_timeUpdate_codec);
						continue;
					}
					if (num == 42U)
					{
						this.addInfos_.AddEntriesFrom(ref input, FriendRecentlyTeamUpdateNotify._repeated_addInfos_codec);
						continue;
					}
				}
				else if (num == 88U || num == 90U)
				{
					this.removeIds_.AddEntriesFrom(ref input, FriendRecentlyTeamUpdateNotify._repeated_removeIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004748 RID: 18248
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004749 RID: 18249
		public const int AddInfosFieldNumber = 5;

		// Token: 0x0400474A RID: 18250
		private static readonly FieldCodec<RecentlyTeamInfo> _repeated_addInfos_codec = FieldCodec.ForMessage<RecentlyTeamInfo>(42U, RecentlyTeamInfo.Parser);

		// Token: 0x0400474B RID: 18251
		private readonly RepeatedField<RecentlyTeamInfo> addInfos_ = new RepeatedField<RecentlyTeamInfo>();

		// Token: 0x0400474C RID: 18252
		public const int TimeUpdateFieldNumber = 1;

		// Token: 0x0400474D RID: 18253
		private static readonly MapField<int, long>.Codec _map_timeUpdate_codec = new MapField<int, long>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt64(16U, 0L), 10U);

		// Token: 0x0400474E RID: 18254
		private readonly MapField<int, long> timeUpdate_ = new MapField<int, long>();

		// Token: 0x0400474F RID: 18255
		public const int RemoveIdsFieldNumber = 11;

		// Token: 0x04004750 RID: 18256
		private static readonly FieldCodec<int> _repeated_removeIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04004751 RID: 18257
		private readonly RepeatedField<int> removeIds_ = new RepeatedField<int>();
	}
}
