using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DC9 RID: 3529
	public sealed class PopularEntrie : IMessage<PopularEntrie>, IMessage, IEquatable<PopularEntrie>, IDeepCloneable<PopularEntrie>, IBufferMessage
	{
		// Token: 0x06012FFF RID: 77823 RVA: 0x002C4FB5 File Offset: 0x002C31B5
		[NullableContext(1)]
		public static PopularEntrie Create()
		{
			return new PopularEntrie();
		}

		// Token: 0x17003F0B RID: 16139
		// (get) Token: 0x06013000 RID: 77824 RVA: 0x002C4FBC File Offset: 0x002C31BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F0C RID: 16140
		// (get) Token: 0x06013001 RID: 77825 RVA: 0x002C4FBF File Offset: 0x002C31BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PopularEntrie.Descriptor;
			}
		}

		// Token: 0x06013002 RID: 77826 RVA: 0x002C4FC6 File Offset: 0x002C31C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PopularEntrie()
		{
		}

		// Token: 0x06013003 RID: 77827 RVA: 0x002C4FDC File Offset: 0x002C31DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PopularEntrie(PopularEntrie other) : this()
		{
			this.instId_ = other.instId_;
			this.entries_ = other.entries_.Clone();
			this.seasonId_ = other.seasonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013004 RID: 77828 RVA: 0x002C5029 File Offset: 0x002C3229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PopularEntrie Clone()
		{
			return new PopularEntrie(this);
		}

		// Token: 0x17003F0D RID: 16141
		// (get) Token: 0x06013005 RID: 77829 RVA: 0x002C5031 File Offset: 0x002C3231
		// (set) Token: 0x06013006 RID: 77830 RVA: 0x002C5039 File Offset: 0x002C3239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17003F0E RID: 16142
		// (get) Token: 0x06013007 RID: 77831 RVA: 0x002C5042 File Offset: 0x002C3242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Entries
		{
			get
			{
				return this.entries_;
			}
		}

		// Token: 0x17003F0F RID: 16143
		// (get) Token: 0x06013008 RID: 77832 RVA: 0x002C504A File Offset: 0x002C324A
		// (set) Token: 0x06013009 RID: 77833 RVA: 0x002C5052 File Offset: 0x002C3252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SeasonId
		{
			get
			{
				return this.seasonId_;
			}
			set
			{
				this.seasonId_ = value;
			}
		}

		// Token: 0x0601300A RID: 77834 RVA: 0x002C505B File Offset: 0x002C325B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PopularEntrie);
		}

		// Token: 0x0601300B RID: 77835 RVA: 0x002C506C File Offset: 0x002C326C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PopularEntrie other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.entries_.Equals(other.entries_) && this.SeasonId == other.SeasonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601300C RID: 77836 RVA: 0x002C50CC File Offset: 0x002C32CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			num ^= this.entries_.GetHashCode();
			if (this.SeasonId != 0)
			{
				num ^= this.SeasonId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601300D RID: 77837 RVA: 0x002C5132 File Offset: 0x002C3332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601300E RID: 77838 RVA: 0x002C513F File Offset: 0x002C333F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601300F RID: 77839 RVA: 0x002C5148 File Offset: 0x002C3348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			this.entries_.WriteTo(ref output, PopularEntrie._repeated_entries_codec);
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SeasonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013010 RID: 77840 RVA: 0x002C51B4 File Offset: 0x002C33B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			num += this.entries_.CalculateSize(PopularEntrie._repeated_entries_codec);
			if (this.SeasonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeasonId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013011 RID: 77841 RVA: 0x002C5220 File Offset: 0x002C3420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PopularEntrie other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this.entries_.Add(other.entries_);
			if (other.SeasonId != 0)
			{
				this.SeasonId = other.SeasonId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013012 RID: 77842 RVA: 0x002C5281 File Offset: 0x002C3481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013013 RID: 77843 RVA: 0x002C528C File Offset: 0x002C348C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						goto IL_45;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_45;
					}
					if (num == 24U)
					{
						this.SeasonId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_45:
				this.entries_.AddEntriesFrom(ref input, PopularEntrie._repeated_entries_codec);
			}
		}

		// Token: 0x0400755A RID: 30042
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400755B RID: 30043
		public const int InstIdFieldNumber = 1;

		// Token: 0x0400755C RID: 30044
		private int instId_;

		// Token: 0x0400755D RID: 30045
		public const int EntriesFieldNumber = 2;

		// Token: 0x0400755E RID: 30046
		private static readonly FieldCodec<int> _repeated_entries_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400755F RID: 30047
		private readonly RepeatedField<int> entries_ = new RepeatedField<int>();

		// Token: 0x04007560 RID: 30048
		public const int SeasonIdFieldNumber = 3;

		// Token: 0x04007561 RID: 30049
		private int seasonId_;
	}
}
