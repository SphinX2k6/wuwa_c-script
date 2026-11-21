using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200030D RID: 781
	public sealed class CorniceMeetingData : IMessage<CorniceMeetingData>, IMessage, IEquatable<CorniceMeetingData>, IDeepCloneable<CorniceMeetingData>, IBufferMessage
	{
		// Token: 0x06004EF7 RID: 20215 RVA: 0x000C00AA File Offset: 0x000BE2AA
		[NullableContext(1)]
		public static CorniceMeetingData Create()
		{
			return new CorniceMeetingData();
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06004EF8 RID: 20216 RVA: 0x000C00B1 File Offset: 0x000BE2B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06004EF9 RID: 20217 RVA: 0x000C00B4 File Offset: 0x000BE2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CorniceMeetingData.Descriptor;
			}
		}

		// Token: 0x06004EFA RID: 20218 RVA: 0x000C00BB File Offset: 0x000BE2BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingData()
		{
		}

		// Token: 0x06004EFB RID: 20219 RVA: 0x000C00CE File Offset: 0x000BE2CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingData(CorniceMeetingData other) : this()
		{
			this.questUnlockTime_ = other.questUnlockTime_;
			this.corninceDataList_ = other.corninceDataList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004EFC RID: 20220 RVA: 0x000C0104 File Offset: 0x000BE304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingData Clone()
		{
			return new CorniceMeetingData(this);
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06004EFD RID: 20221 RVA: 0x000C010C File Offset: 0x000BE30C
		// (set) Token: 0x06004EFE RID: 20222 RVA: 0x000C0114 File Offset: 0x000BE314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long QuestUnlockTime
		{
			get
			{
				return this.questUnlockTime_;
			}
			set
			{
				this.questUnlockTime_ = value;
			}
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06004EFF RID: 20223 RVA: 0x000C011D File Offset: 0x000BE31D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, CorniceLevelPlayEnrty> CorninceDataList
		{
			get
			{
				return this.corninceDataList_;
			}
		}

		// Token: 0x06004F00 RID: 20224 RVA: 0x000C0125 File Offset: 0x000BE325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CorniceMeetingData);
		}

		// Token: 0x06004F01 RID: 20225 RVA: 0x000C0134 File Offset: 0x000BE334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CorniceMeetingData other)
		{
			return other != null && (other == this || (this.QuestUnlockTime == other.QuestUnlockTime && this.CorninceDataList.Equals(other.CorninceDataList) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004F02 RID: 20226 RVA: 0x000C0184 File Offset: 0x000BE384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestUnlockTime != 0L)
			{
				num ^= this.QuestUnlockTime.GetHashCode();
			}
			num ^= this.CorninceDataList.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004F03 RID: 20227 RVA: 0x000C01D1 File Offset: 0x000BE3D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004F04 RID: 20228 RVA: 0x000C01DE File Offset: 0x000BE3DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004F05 RID: 20229 RVA: 0x000C01E8 File Offset: 0x000BE3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestUnlockTime != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.QuestUnlockTime);
			}
			this.corninceDataList_.WriteTo(ref output, CorniceMeetingData._map_corninceDataList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004F06 RID: 20230 RVA: 0x000C0238 File Offset: 0x000BE438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestUnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.QuestUnlockTime);
			}
			num += this.corninceDataList_.CalculateSize(CorniceMeetingData._map_corninceDataList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004F07 RID: 20231 RVA: 0x000C028C File Offset: 0x000BE48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CorniceMeetingData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestUnlockTime != 0L)
			{
				this.QuestUnlockTime = other.QuestUnlockTime;
			}
			this.corninceDataList_.MergeFrom(other.corninceDataList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004F08 RID: 20232 RVA: 0x000C02D9 File Offset: 0x000BE4D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004F09 RID: 20233 RVA: 0x000C02E4 File Offset: 0x000BE4E4
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.corninceDataList_.AddEntriesFrom(ref input, CorniceMeetingData._map_corninceDataList_codec);
					}
				}
				else
				{
					this.QuestUnlockTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003217 RID: 12823
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003218 RID: 12824
		public const int QuestUnlockTimeFieldNumber = 1;

		// Token: 0x04003219 RID: 12825
		private long questUnlockTime_;

		// Token: 0x0400321A RID: 12826
		public const int CorninceDataListFieldNumber = 2;

		// Token: 0x0400321B RID: 12827
		private static readonly MapField<int, CorniceLevelPlayEnrty>.Codec _map_corninceDataList_codec = new MapField<int, CorniceLevelPlayEnrty>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<CorniceLevelPlayEnrty>(18U, CorniceLevelPlayEnrty.Parser), 18U);

		// Token: 0x0400321C RID: 12828
		private readonly MapField<int, CorniceLevelPlayEnrty> corninceDataList_ = new MapField<int, CorniceLevelPlayEnrty>();
	}
}
