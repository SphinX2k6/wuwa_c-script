using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000658 RID: 1624
	[NetMessage(EMessageId.FriendRecentlyTeamUpdateNotify)]
	public sealed class FriendRecentlyTeamUpdateNotify : IMessage<FriendRecentlyTeamUpdateNotify>, IMessage, IEquatable<FriendRecentlyTeamUpdateNotify>, IDeepCloneable<FriendRecentlyTeamUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600952E RID: 38190 RVA: 0x00168238 File Offset: 0x00166438
		[NullableContext(1)]
		public static FriendRecentlyTeamUpdateNotify Create()
		{
			return new FriendRecentlyTeamUpdateNotify();
		}

		// Token: 0x17001DAF RID: 7599
		// (get) Token: 0x0600952F RID: 38191 RVA: 0x0016823F File Offset: 0x0016643F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DB0 RID: 7600
		// (get) Token: 0x06009530 RID: 38192 RVA: 0x00168242 File Offset: 0x00166442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendRecentlyTeamUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06009531 RID: 38193 RVA: 0x00168249 File Offset: 0x00166449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRecentlyTeamUpdateNotify()
		{
		}

		// Token: 0x06009532 RID: 38194 RVA: 0x00168274 File Offset: 0x00166474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRecentlyTeamUpdateNotify(FriendRecentlyTeamUpdateNotify other) : this()
		{
			this.addInfos_ = other.addInfos_.Clone();
			this.timeUpdate_ = other.timeUpdate_.Clone();
			this.removeIds_ = other.removeIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009533 RID: 38195 RVA: 0x001682CB File Offset: 0x001664CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRecentlyTeamUpdateNotify Clone()
		{
			return new FriendRecentlyTeamUpdateNotify(this);
		}

		// Token: 0x17001DB1 RID: 7601
		// (get) Token: 0x06009534 RID: 38196 RVA: 0x001682D3 File Offset: 0x001664D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RecentlyTeamInfo> AddInfos
		{
			get
			{
				return this.addInfos_;
			}
		}

		// Token: 0x17001DB2 RID: 7602
		// (get) Token: 0x06009535 RID: 38197 RVA: 0x001682DB File Offset: 0x001664DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, long> TimeUpdate
		{
			get
			{
				return this.timeUpdate_;
			}
		}

		// Token: 0x17001DB3 RID: 7603
		// (get) Token: 0x06009536 RID: 38198 RVA: 0x001682E3 File Offset: 0x001664E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RemoveIds
		{
			get
			{
				return this.removeIds_;
			}
		}

		// Token: 0x06009537 RID: 38199 RVA: 0x001682EB File Offset: 0x001664EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendRecentlyTeamUpdateNotify);
		}

		// Token: 0x06009538 RID: 38200 RVA: 0x001682FC File Offset: 0x001664FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendRecentlyTeamUpdateNotify other)
		{
			return other != null && (other == this || (this.addInfos_.Equals(other.addInfos_) && this.TimeUpdate.Equals(other.TimeUpdate) && this.removeIds_.Equals(other.removeIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009539 RID: 38201 RVA: 0x00168364 File Offset: 0x00166564
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

		// Token: 0x0600953A RID: 38202 RVA: 0x001683B4 File Offset: 0x001665B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600953B RID: 38203 RVA: 0x001683C1 File Offset: 0x001665C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600953C RID: 38204 RVA: 0x001683CC File Offset: 0x001665CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.timeUpdate_.WriteTo(ref output, FriendRecentlyTeamUpdateNotify._map_timeUpdate_codec);
			this.removeIds_.WriteTo(ref output, FriendRecentlyTeamUpdateNotify._repeated_removeIds_codec);
			this.addInfos_.WriteTo(ref output, FriendRecentlyTeamUpdateNotify._repeated_addInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600953D RID: 38205 RVA: 0x00168420 File Offset: 0x00166620
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

		// Token: 0x0600953E RID: 38206 RVA: 0x00168480 File Offset: 0x00166680
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

		// Token: 0x0600953F RID: 38207 RVA: 0x001684DB File Offset: 0x001666DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009540 RID: 38208 RVA: 0x001684E4 File Offset: 0x001666E4
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
				if (num <= 96U)
				{
					if (num == 58U)
					{
						this.timeUpdate_.AddEntriesFrom(ref input, FriendRecentlyTeamUpdateNotify._map_timeUpdate_codec);
						continue;
					}
					if (num == 96U)
					{
						goto IL_4B;
					}
				}
				else
				{
					if (num == 98U)
					{
						goto IL_4B;
					}
					if (num == 114U)
					{
						this.addInfos_.AddEntriesFrom(ref input, FriendRecentlyTeamUpdateNotify._repeated_addInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4B:
				this.removeIds_.AddEntriesFrom(ref input, FriendRecentlyTeamUpdateNotify._repeated_removeIds_codec);
			}
		}

		// Token: 0x0400474F RID: 18255
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004750 RID: 18256
		public const int AddInfosFieldNumber = 14;

		// Token: 0x04004751 RID: 18257
		private static readonly FieldCodec<RecentlyTeamInfo> _repeated_addInfos_codec = FieldCodec.ForMessage<RecentlyTeamInfo>(114U, RecentlyTeamInfo.Parser);

		// Token: 0x04004752 RID: 18258
		private readonly RepeatedField<RecentlyTeamInfo> addInfos_ = new RepeatedField<RecentlyTeamInfo>();

		// Token: 0x04004753 RID: 18259
		public const int TimeUpdateFieldNumber = 7;

		// Token: 0x04004754 RID: 18260
		private static readonly MapField<int, long>.Codec _map_timeUpdate_codec = new MapField<int, long>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt64(16U, 0L), 58U);

		// Token: 0x04004755 RID: 18261
		private readonly MapField<int, long> timeUpdate_ = new MapField<int, long>();

		// Token: 0x04004756 RID: 18262
		public const int RemoveIdsFieldNumber = 12;

		// Token: 0x04004757 RID: 18263
		private static readonly FieldCodec<int> _repeated_removeIds_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04004758 RID: 18264
		private readonly RepeatedField<int> removeIds_ = new RepeatedField<int>();
	}
}
