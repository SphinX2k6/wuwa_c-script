using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200005E RID: 94
	public sealed class AchievementGroupInfo : IMessage<AchievementGroupInfo>, IMessage, IEquatable<AchievementGroupInfo>, IDeepCloneable<AchievementGroupInfo>, IBufferMessage
	{
		// Token: 0x060015F0 RID: 5616 RVA: 0x00039F4A File Offset: 0x0003814A
		[NullableContext(1)]
		public static AchievementGroupInfo Create()
		{
			return new AchievementGroupInfo();
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060015F1 RID: 5617 RVA: 0x00039F51 File Offset: 0x00038151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AchievementGroupInfo> Parser
		{
			get
			{
				return AchievementGroupInfo._parser;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060015F2 RID: 5618 RVA: 0x00039F58 File Offset: 0x00038158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060015F3 RID: 5619 RVA: 0x00039F5B File Offset: 0x0003815B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementGroupInfo.Descriptor;
			}
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00039F62 File Offset: 0x00038162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementGroupInfo()
		{
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00039F78 File Offset: 0x00038178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementGroupInfo(AchievementGroupInfo other) : this()
		{
			this.achievementGroupEntry_ = ((other.achievementGroupEntry_ != null) ? other.achievementGroupEntry_.Clone() : null);
			this.achievementEntryList_ = other.achievementEntryList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00039FC9 File Offset: 0x000381C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementGroupInfo Clone()
		{
			return new AchievementGroupInfo(this);
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x00039FD1 File Offset: 0x000381D1
		// (set) Token: 0x060015F8 RID: 5624 RVA: 0x00039FD9 File Offset: 0x000381D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementGroupEntry AchievementGroupEntry
		{
			get
			{
				return this.achievementGroupEntry_;
			}
			set
			{
				this.achievementGroupEntry_ = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x00039FE2 File Offset: 0x000381E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AchievementEntry> AchievementEntryList
		{
			get
			{
				return this.achievementEntryList_;
			}
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00039FEA File Offset: 0x000381EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementGroupInfo);
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00039FF8 File Offset: 0x000381F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementGroupInfo other)
		{
			return other != null && (other == this || (object.Equals(this.AchievementGroupEntry, other.AchievementGroupEntry) && this.achievementEntryList_.Equals(other.achievementEntryList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x0003A04C File Offset: 0x0003824C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.achievementGroupEntry_ != null)
			{
				num ^= this.AchievementGroupEntry.GetHashCode();
			}
			num ^= this.achievementEntryList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x0003A096 File Offset: 0x00038296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x0003A0A3 File Offset: 0x000382A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x0003A0AC File Offset: 0x000382AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.achievementGroupEntry_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AchievementGroupEntry);
			}
			this.achievementEntryList_.WriteTo(ref output, AchievementGroupInfo._repeated_achievementEntryList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x0003A0FC File Offset: 0x000382FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.achievementGroupEntry_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AchievementGroupEntry);
			}
			num += this.achievementEntryList_.CalculateSize(AchievementGroupInfo._repeated_achievementEntryList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x0003A150 File Offset: 0x00038350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AchievementGroupInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.achievementGroupEntry_ != null)
			{
				if (this.achievementGroupEntry_ == null)
				{
					this.AchievementGroupEntry = new AchievementGroupEntry();
				}
				this.AchievementGroupEntry.MergeFrom(other.AchievementGroupEntry);
			}
			this.achievementEntryList_.Add(other.achievementEntryList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x0003A1B5 File Offset: 0x000383B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x0003A1C0 File Offset: 0x000383C0
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.achievementEntryList_.AddEntriesFrom(ref input, AchievementGroupInfo._repeated_achievementEntryList_codec);
					}
				}
				else
				{
					if (this.achievementGroupEntry_ == null)
					{
						this.AchievementGroupEntry = new AchievementGroupEntry();
					}
					input.ReadMessage(this.AchievementGroupEntry);
				}
			}
		}

		// Token: 0x040020C2 RID: 8386
		private static readonly MessageParser<AchievementGroupInfo> _parser = new MessageParser<AchievementGroupInfo>(() => new AchievementGroupInfo());

		// Token: 0x040020C3 RID: 8387
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020C4 RID: 8388
		public const int AchievementGroupEntryFieldNumber = 1;

		// Token: 0x040020C5 RID: 8389
		private AchievementGroupEntry achievementGroupEntry_;

		// Token: 0x040020C6 RID: 8390
		public const int AchievementEntryListFieldNumber = 2;

		// Token: 0x040020C7 RID: 8391
		private static readonly FieldCodec<AchievementEntry> _repeated_achievementEntryList_codec = FieldCodec.ForMessage<AchievementEntry>(18U, AchievementEntry.Parser);

		// Token: 0x040020C8 RID: 8392
		private readonly RepeatedField<AchievementEntry> achievementEntryList_ = new RepeatedField<AchievementEntry>();
	}
}
