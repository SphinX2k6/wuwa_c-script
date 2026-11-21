using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012A9 RID: 4777
	public sealed class SolarSchoolExamResult : IMessage<SolarSchoolExamResult>, IMessage, IEquatable<SolarSchoolExamResult>, IDeepCloneable<SolarSchoolExamResult>, IBufferMessage
	{
		// Token: 0x060197FA RID: 104442 RVA: 0x003B8431 File Offset: 0x003B6631
		[NullableContext(1)]
		public static SolarSchoolExamResult Create()
		{
			return new SolarSchoolExamResult();
		}

		// Token: 0x17005649 RID: 22089
		// (get) Token: 0x060197FB RID: 104443 RVA: 0x003B8438 File Offset: 0x003B6638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SolarSchoolExamResult> Parser
		{
			get
			{
				return SolarSchoolExamResult._parser;
			}
		}

		// Token: 0x1700564A RID: 22090
		// (get) Token: 0x060197FC RID: 104444 RVA: 0x003B843F File Offset: 0x003B663F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700564B RID: 22091
		// (get) Token: 0x060197FD RID: 104445 RVA: 0x003B8442 File Offset: 0x003B6642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolExamResult.Descriptor;
			}
		}

		// Token: 0x060197FE RID: 104446 RVA: 0x003B8449 File Offset: 0x003B6649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolExamResult()
		{
		}

		// Token: 0x060197FF RID: 104447 RVA: 0x003B8454 File Offset: 0x003B6654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolExamResult(SolarSchoolExamResult other) : this()
		{
			this.id_ = other.id_;
			this.score_ = other.score_;
			this.rank_ = other.rank_;
			this.published_ = other.published_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019800 RID: 104448 RVA: 0x003B84A8 File Offset: 0x003B66A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolExamResult Clone()
		{
			return new SolarSchoolExamResult(this);
		}

		// Token: 0x1700564C RID: 22092
		// (get) Token: 0x06019801 RID: 104449 RVA: 0x003B84B0 File Offset: 0x003B66B0
		// (set) Token: 0x06019802 RID: 104450 RVA: 0x003B84B8 File Offset: 0x003B66B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700564D RID: 22093
		// (get) Token: 0x06019803 RID: 104451 RVA: 0x003B84C1 File Offset: 0x003B66C1
		// (set) Token: 0x06019804 RID: 104452 RVA: 0x003B84C9 File Offset: 0x003B66C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x1700564E RID: 22094
		// (get) Token: 0x06019805 RID: 104453 RVA: 0x003B84D2 File Offset: 0x003B66D2
		// (set) Token: 0x06019806 RID: 104454 RVA: 0x003B84DA File Offset: 0x003B66DA
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

		// Token: 0x1700564F RID: 22095
		// (get) Token: 0x06019807 RID: 104455 RVA: 0x003B84E3 File Offset: 0x003B66E3
		// (set) Token: 0x06019808 RID: 104456 RVA: 0x003B84EB File Offset: 0x003B66EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Published
		{
			get
			{
				return this.published_;
			}
			set
			{
				this.published_ = value;
			}
		}

		// Token: 0x06019809 RID: 104457 RVA: 0x003B84F4 File Offset: 0x003B66F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolExamResult);
		}

		// Token: 0x0601980A RID: 104458 RVA: 0x003B8504 File Offset: 0x003B6704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolExamResult other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Score == other.Score && this.Rank == other.Rank && this.Published == other.Published && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601980B RID: 104459 RVA: 0x003B8570 File Offset: 0x003B6770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this.Rank != 0)
			{
				num ^= this.Rank.GetHashCode();
			}
			if (this.Published)
			{
				num ^= this.Published.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601980C RID: 104460 RVA: 0x003B85FA File Offset: 0x003B67FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601980D RID: 104461 RVA: 0x003B8607 File Offset: 0x003B6807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601980E RID: 104462 RVA: 0x003B8610 File Offset: 0x003B6810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Score);
			}
			if (this.Rank != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Rank);
			}
			if (this.Published)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Published);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601980F RID: 104463 RVA: 0x003B86A0 File Offset: 0x003B68A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this.Rank != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Rank);
			}
			if (this.Published)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019810 RID: 104464 RVA: 0x003B871C File Offset: 0x003B691C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolExamResult other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			if (other.Rank != 0)
			{
				this.Rank = other.Rank;
			}
			if (other.Published)
			{
				this.Published = other.Published;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019811 RID: 104465 RVA: 0x003B8794 File Offset: 0x003B6994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019812 RID: 104466 RVA: 0x003B87A0 File Offset: 0x003B69A0
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
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Rank = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Published = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040096B2 RID: 38578
		private static readonly MessageParser<SolarSchoolExamResult> _parser = new MessageParser<SolarSchoolExamResult>(() => new SolarSchoolExamResult());

		// Token: 0x040096B3 RID: 38579
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096B4 RID: 38580
		public const int IdFieldNumber = 1;

		// Token: 0x040096B5 RID: 38581
		private int id_;

		// Token: 0x040096B6 RID: 38582
		public const int ScoreFieldNumber = 2;

		// Token: 0x040096B7 RID: 38583
		private int score_;

		// Token: 0x040096B8 RID: 38584
		public const int RankFieldNumber = 3;

		// Token: 0x040096B9 RID: 38585
		private int rank_;

		// Token: 0x040096BA RID: 38586
		public const int PublishedFieldNumber = 4;

		// Token: 0x040096BB RID: 38587
		private bool published_;
	}
}
