using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010D7 RID: 4311
	public sealed class RoleTowerRankEntry : IMessage<RoleTowerRankEntry>, IMessage, IEquatable<RoleTowerRankEntry>, IDeepCloneable<RoleTowerRankEntry>, IBufferMessage
	{
		// Token: 0x060170BA RID: 94394 RVA: 0x0035A4E2 File Offset: 0x003586E2
		[NullableContext(1)]
		public static RoleTowerRankEntry Create()
		{
			return new RoleTowerRankEntry();
		}

		// Token: 0x17004D59 RID: 19801
		// (get) Token: 0x060170BB RID: 94395 RVA: 0x0035A4E9 File Offset: 0x003586E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleTowerRankEntry> Parser
		{
			get
			{
				return RoleTowerRankEntry._parser;
			}
		}

		// Token: 0x17004D5A RID: 19802
		// (get) Token: 0x060170BC RID: 94396 RVA: 0x0035A4F0 File Offset: 0x003586F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D5B RID: 19803
		// (get) Token: 0x060170BD RID: 94397 RVA: 0x0035A4F3 File Offset: 0x003586F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerRankEntry.Descriptor;
			}
		}

		// Token: 0x060170BE RID: 94398 RVA: 0x0035A4FA File Offset: 0x003586FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankEntry()
		{
		}

		// Token: 0x060170BF RID: 94399 RVA: 0x0035A518 File Offset: 0x00358718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankEntry(RoleTowerRankEntry other) : this()
		{
			this.playerId_ = other.playerId_;
			this.name_ = other.name_;
			this.rank_ = other.rank_;
			this.rankPercent_ = other.rankPercent_;
			this.record_ = ((other.record_ != null) ? other.record_.Clone() : null);
			this.remark_ = other.remark_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060170C0 RID: 94400 RVA: 0x0035A594 File Offset: 0x00358794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankEntry Clone()
		{
			return new RoleTowerRankEntry(this);
		}

		// Token: 0x17004D5C RID: 19804
		// (get) Token: 0x060170C1 RID: 94401 RVA: 0x0035A59C File Offset: 0x0035879C
		// (set) Token: 0x060170C2 RID: 94402 RVA: 0x0035A5A4 File Offset: 0x003587A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17004D5D RID: 19805
		// (get) Token: 0x060170C3 RID: 94403 RVA: 0x0035A5AD File Offset: 0x003587AD
		// (set) Token: 0x060170C4 RID: 94404 RVA: 0x0035A5B5 File Offset: 0x003587B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17004D5E RID: 19806
		// (get) Token: 0x060170C5 RID: 94405 RVA: 0x0035A5C8 File Offset: 0x003587C8
		// (set) Token: 0x060170C6 RID: 94406 RVA: 0x0035A5D0 File Offset: 0x003587D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Rank
		{
			get
			{
				return this.rank_;
			}
			set
			{
				this.rank_ = value;
			}
		}

		// Token: 0x17004D5F RID: 19807
		// (get) Token: 0x060170C7 RID: 94407 RVA: 0x0035A5D9 File Offset: 0x003587D9
		// (set) Token: 0x060170C8 RID: 94408 RVA: 0x0035A5E1 File Offset: 0x003587E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RankPercent
		{
			get
			{
				return this.rankPercent_;
			}
			set
			{
				this.rankPercent_ = value;
			}
		}

		// Token: 0x17004D60 RID: 19808
		// (get) Token: 0x060170C9 RID: 94409 RVA: 0x0035A5EA File Offset: 0x003587EA
		// (set) Token: 0x060170CA RID: 94410 RVA: 0x0035A5F2 File Offset: 0x003587F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerBestRecord Record
		{
			get
			{
				return this.record_;
			}
			set
			{
				this.record_ = value;
			}
		}

		// Token: 0x17004D61 RID: 19809
		// (get) Token: 0x060170CB RID: 94411 RVA: 0x0035A5FB File Offset: 0x003587FB
		// (set) Token: 0x060170CC RID: 94412 RVA: 0x0035A603 File Offset: 0x00358803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Remark
		{
			get
			{
				return this.remark_;
			}
			set
			{
				this.remark_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060170CD RID: 94413 RVA: 0x0035A616 File Offset: 0x00358816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerRankEntry);
		}

		// Token: 0x060170CE RID: 94414 RVA: 0x0035A624 File Offset: 0x00358824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerRankEntry other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && !(this.Name != other.Name) && this.Rank == other.Rank && this.RankPercent == other.RankPercent && object.Equals(this.Record, other.Record) && !(this.Remark != other.Remark) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060170CF RID: 94415 RVA: 0x0035A6BC File Offset: 0x003588BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Rank != 0)
			{
				num ^= this.Rank.GetHashCode();
			}
			if (this.RankPercent != 0)
			{
				num ^= this.RankPercent.GetHashCode();
			}
			if (this.record_ != null)
			{
				num ^= this.Record.GetHashCode();
			}
			if (this.Remark.Length != 0)
			{
				num ^= this.Remark.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060170D0 RID: 94416 RVA: 0x0035A779 File Offset: 0x00358979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060170D1 RID: 94417 RVA: 0x0035A786 File Offset: 0x00358986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060170D2 RID: 94418 RVA: 0x0035A790 File Offset: 0x00358990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			if (this.Rank != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Rank);
			}
			if (this.RankPercent != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RankPercent);
			}
			if (this.record_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Record);
			}
			if (this.Remark.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Remark);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060170D3 RID: 94419 RVA: 0x0035A864 File Offset: 0x00358A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.Rank != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Rank);
			}
			if (this.RankPercent != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RankPercent);
			}
			if (this.record_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Record);
			}
			if (this.Remark.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Remark);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060170D4 RID: 94420 RVA: 0x0035A924 File Offset: 0x00358B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerRankEntry other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Rank != 0)
			{
				this.Rank = other.Rank;
			}
			if (other.RankPercent != 0)
			{
				this.RankPercent = other.RankPercent;
			}
			if (other.record_ != null)
			{
				if (this.record_ == null)
				{
					this.Record = new RoleTowerBestRecord();
				}
				this.Record.MergeFrom(other.Record);
			}
			if (other.Remark.Length != 0)
			{
				this.Remark = other.Remark;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060170D5 RID: 94421 RVA: 0x0035A9E6 File Offset: 0x00358BE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060170D6 RID: 94422 RVA: 0x0035A9F0 File Offset: 0x00358BF0
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.Name = input.ReadString();
						continue;
					}
					if (num == 24U)
					{
						this.Rank = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.RankPercent = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						if (this.record_ == null)
						{
							this.Record = new RoleTowerBestRecord();
						}
						input.ReadMessage(this.Record);
						continue;
					}
					if (num == 50U)
					{
						this.Remark = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040089F5 RID: 35317
		private static readonly MessageParser<RoleTowerRankEntry> _parser = new MessageParser<RoleTowerRankEntry>(() => new RoleTowerRankEntry());

		// Token: 0x040089F6 RID: 35318
		private UnknownFieldSet _unknownFields;

		// Token: 0x040089F7 RID: 35319
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x040089F8 RID: 35320
		private int playerId_;

		// Token: 0x040089F9 RID: 35321
		public const int NameFieldNumber = 2;

		// Token: 0x040089FA RID: 35322
		private string name_ = "";

		// Token: 0x040089FB RID: 35323
		public const int RankFieldNumber = 3;

		// Token: 0x040089FC RID: 35324
		private int rank_;

		// Token: 0x040089FD RID: 35325
		public const int RankPercentFieldNumber = 4;

		// Token: 0x040089FE RID: 35326
		private int rankPercent_;

		// Token: 0x040089FF RID: 35327
		public const int RecordFieldNumber = 5;

		// Token: 0x04008A00 RID: 35328
		private RoleTowerBestRecord record_;

		// Token: 0x04008A01 RID: 35329
		public const int RemarkFieldNumber = 6;

		// Token: 0x04008A02 RID: 35330
		private string remark_ = "";
	}
}
