using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DB8 RID: 3512
	public sealed class PopularEntrie : IMessage<PopularEntrie>, IMessage, IEquatable<PopularEntrie>, IDeepCloneable<PopularEntrie>, IBufferMessage
	{
		// Token: 0x06012EEF RID: 77551 RVA: 0x002C3105 File Offset: 0x002C1305
		[NullableContext(1)]
		public static PopularEntrie Create()
		{
			return new PopularEntrie();
		}

		// Token: 0x17003ED2 RID: 16082
		// (get) Token: 0x06012EF0 RID: 77552 RVA: 0x002C310C File Offset: 0x002C130C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003ED3 RID: 16083
		// (get) Token: 0x06012EF1 RID: 77553 RVA: 0x002C310F File Offset: 0x002C130F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PopularEntrie.Descriptor;
			}
		}

		// Token: 0x06012EF2 RID: 77554 RVA: 0x002C3116 File Offset: 0x002C1316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PopularEntrie()
		{
		}

		// Token: 0x06012EF3 RID: 77555 RVA: 0x002C312C File Offset: 0x002C132C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PopularEntrie(PopularEntrie other) : this()
		{
			this.instId_ = other.instId_;
			this.entries_ = other.entries_.Clone();
			this.seasonId_ = other.seasonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012EF4 RID: 77556 RVA: 0x002C3179 File Offset: 0x002C1379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PopularEntrie Clone()
		{
			return new PopularEntrie(this);
		}

		// Token: 0x17003ED4 RID: 16084
		// (get) Token: 0x06012EF5 RID: 77557 RVA: 0x002C3181 File Offset: 0x002C1381
		// (set) Token: 0x06012EF6 RID: 77558 RVA: 0x002C3189 File Offset: 0x002C1389
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

		// Token: 0x17003ED5 RID: 16085
		// (get) Token: 0x06012EF7 RID: 77559 RVA: 0x002C3192 File Offset: 0x002C1392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Entries
		{
			get
			{
				return this.entries_;
			}
		}

		// Token: 0x17003ED6 RID: 16086
		// (get) Token: 0x06012EF8 RID: 77560 RVA: 0x002C319A File Offset: 0x002C139A
		// (set) Token: 0x06012EF9 RID: 77561 RVA: 0x002C31A2 File Offset: 0x002C13A2
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

		// Token: 0x06012EFA RID: 77562 RVA: 0x002C31AB File Offset: 0x002C13AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PopularEntrie);
		}

		// Token: 0x06012EFB RID: 77563 RVA: 0x002C31BC File Offset: 0x002C13BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PopularEntrie other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.entries_.Equals(other.entries_) && this.SeasonId == other.SeasonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012EFC RID: 77564 RVA: 0x002C321C File Offset: 0x002C141C
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

		// Token: 0x06012EFD RID: 77565 RVA: 0x002C3282 File Offset: 0x002C1482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012EFE RID: 77566 RVA: 0x002C328F File Offset: 0x002C148F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012EFF RID: 77567 RVA: 0x002C3298 File Offset: 0x002C1498
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

		// Token: 0x06012F00 RID: 77568 RVA: 0x002C3304 File Offset: 0x002C1504
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

		// Token: 0x06012F01 RID: 77569 RVA: 0x002C3370 File Offset: 0x002C1570
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

		// Token: 0x06012F02 RID: 77570 RVA: 0x002C33D1 File Offset: 0x002C15D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012F03 RID: 77571 RVA: 0x002C33DC File Offset: 0x002C15DC
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

		// Token: 0x0400756D RID: 30061
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400756E RID: 30062
		public const int InstIdFieldNumber = 1;

		// Token: 0x0400756F RID: 30063
		private int instId_;

		// Token: 0x04007570 RID: 30064
		public const int EntriesFieldNumber = 2;

		// Token: 0x04007571 RID: 30065
		private static readonly FieldCodec<int> _repeated_entries_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04007572 RID: 30066
		private readonly RepeatedField<int> entries_ = new RepeatedField<int>();

		// Token: 0x04007573 RID: 30067
		public const int SeasonIdFieldNumber = 3;

		// Token: 0x04007574 RID: 30068
		private int seasonId_;
	}
}
