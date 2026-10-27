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
	public sealed class CorniceMeetingData : IMessage<CorniceMeetingData>, IMessage, IEquatable<CorniceMeetingData>, IDeepCloneable<CorniceMeetingData>, IBufferMessage
	{
		// Token: 0x06004E1E RID: 19998 RVA: 0x000BDCBE File Offset: 0x000BBEBE
		[NullableContext(1)]
		public static CorniceMeetingData Create()
		{
			return new CorniceMeetingData();
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06004E1F RID: 19999 RVA: 0x000BDCC5 File Offset: 0x000BBEC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x06004E20 RID: 20000 RVA: 0x000BDCC8 File Offset: 0x000BBEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CorniceMeetingData.Descriptor;
			}
		}

		// Token: 0x06004E21 RID: 20001 RVA: 0x000BDCCF File Offset: 0x000BBECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingData()
		{
		}

		// Token: 0x06004E22 RID: 20002 RVA: 0x000BDCE2 File Offset: 0x000BBEE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingData(CorniceMeetingData other) : this()
		{
			this.questUnlockTime_ = other.questUnlockTime_;
			this.corninceDataList_ = other.corninceDataList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004E23 RID: 20003 RVA: 0x000BDD18 File Offset: 0x000BBF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingData Clone()
		{
			return new CorniceMeetingData(this);
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x06004E24 RID: 20004 RVA: 0x000BDD20 File Offset: 0x000BBF20
		// (set) Token: 0x06004E25 RID: 20005 RVA: 0x000BDD28 File Offset: 0x000BBF28
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

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x06004E26 RID: 20006 RVA: 0x000BDD31 File Offset: 0x000BBF31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, CorniceLevelPlayEnrty> CorninceDataList
		{
			get
			{
				return this.corninceDataList_;
			}
		}

		// Token: 0x06004E27 RID: 20007 RVA: 0x000BDD39 File Offset: 0x000BBF39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CorniceMeetingData);
		}

		// Token: 0x06004E28 RID: 20008 RVA: 0x000BDD48 File Offset: 0x000BBF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CorniceMeetingData other)
		{
			return other != null && (other == this || (this.QuestUnlockTime == other.QuestUnlockTime && this.CorninceDataList.Equals(other.CorninceDataList) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004E29 RID: 20009 RVA: 0x000BDD98 File Offset: 0x000BBF98
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

		// Token: 0x06004E2A RID: 20010 RVA: 0x000BDDE5 File Offset: 0x000BBFE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004E2B RID: 20011 RVA: 0x000BDDF2 File Offset: 0x000BBFF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E2C RID: 20012 RVA: 0x000BDDFC File Offset: 0x000BBFFC
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

		// Token: 0x06004E2D RID: 20013 RVA: 0x000BDE4C File Offset: 0x000BC04C
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

		// Token: 0x06004E2E RID: 20014 RVA: 0x000BDEA0 File Offset: 0x000BC0A0
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

		// Token: 0x06004E2F RID: 20015 RVA: 0x000BDEED File Offset: 0x000BC0ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E30 RID: 20016 RVA: 0x000BDEF8 File Offset: 0x000BC0F8
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

		// Token: 0x04003180 RID: 12672
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003181 RID: 12673
		public const int QuestUnlockTimeFieldNumber = 1;

		// Token: 0x04003182 RID: 12674
		private long questUnlockTime_;

		// Token: 0x04003183 RID: 12675
		public const int CorninceDataListFieldNumber = 2;

		// Token: 0x04003184 RID: 12676
		private static readonly MapField<int, CorniceLevelPlayEnrty>.Codec _map_corninceDataList_codec = new MapField<int, CorniceLevelPlayEnrty>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<CorniceLevelPlayEnrty>(18U, CorniceLevelPlayEnrty.Parser), 18U);

		// Token: 0x04003185 RID: 12677
		private readonly MapField<int, CorniceLevelPlayEnrty> corninceDataList_ = new MapField<int, CorniceLevelPlayEnrty>();
	}
}
