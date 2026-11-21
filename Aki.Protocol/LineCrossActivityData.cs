using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000910 RID: 2320
	public sealed class LineCrossActivityData : IMessage<LineCrossActivityData>, IMessage, IEquatable<LineCrossActivityData>, IDeepCloneable<LineCrossActivityData>, IBufferMessage
	{
		// Token: 0x0600CD14 RID: 52500 RVA: 0x001E3E32 File Offset: 0x001E2032
		[NullableContext(1)]
		public static LineCrossActivityData Create()
		{
			return new LineCrossActivityData();
		}

		// Token: 0x17002968 RID: 10600
		// (get) Token: 0x0600CD15 RID: 52501 RVA: 0x001E3E39 File Offset: 0x001E2039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002969 RID: 10601
		// (get) Token: 0x0600CD16 RID: 52502 RVA: 0x001E3E3C File Offset: 0x001E203C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LineCrossActivityData.Descriptor;
			}
		}

		// Token: 0x0600CD17 RID: 52503 RVA: 0x001E3E43 File Offset: 0x001E2043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossActivityData()
		{
		}

		// Token: 0x0600CD18 RID: 52504 RVA: 0x001E3E56 File Offset: 0x001E2056
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossActivityData(LineCrossActivityData other) : this()
		{
			this.challenges_ = other.challenges_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CD19 RID: 52505 RVA: 0x001E3E80 File Offset: 0x001E2080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossActivityData Clone()
		{
			return new LineCrossActivityData(this);
		}

		// Token: 0x1700296A RID: 10602
		// (get) Token: 0x0600CD1A RID: 52506 RVA: 0x001E3E88 File Offset: 0x001E2088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LineCrossChallengeData> Challenges
		{
			get
			{
				return this.challenges_;
			}
		}

		// Token: 0x0600CD1B RID: 52507 RVA: 0x001E3E90 File Offset: 0x001E2090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LineCrossActivityData);
		}

		// Token: 0x0600CD1C RID: 52508 RVA: 0x001E3E9E File Offset: 0x001E209E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LineCrossActivityData other)
		{
			return other != null && (other == this || (this.challenges_.Equals(other.challenges_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CD1D RID: 52509 RVA: 0x001E3ED4 File Offset: 0x001E20D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.challenges_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CD1E RID: 52510 RVA: 0x001E3F08 File Offset: 0x001E2108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CD1F RID: 52511 RVA: 0x001E3F15 File Offset: 0x001E2115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CD20 RID: 52512 RVA: 0x001E3F1E File Offset: 0x001E211E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.challenges_.WriteTo(ref output, LineCrossActivityData._repeated_challenges_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CD21 RID: 52513 RVA: 0x001E3F48 File Offset: 0x001E2148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.challenges_.CalculateSize(LineCrossActivityData._repeated_challenges_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CD22 RID: 52514 RVA: 0x001E3F81 File Offset: 0x001E2181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LineCrossActivityData other)
		{
			if (other == null)
			{
				return;
			}
			this.challenges_.Add(other.challenges_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CD23 RID: 52515 RVA: 0x001E3FAF File Offset: 0x001E21AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CD24 RID: 52516 RVA: 0x001E3FB8 File Offset: 0x001E21B8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.challenges_.AddEntriesFrom(ref input, LineCrossActivityData._repeated_challenges_codec);
				}
			}
		}

		// Token: 0x04005733 RID: 22323
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005734 RID: 22324
		public const int ChallengesFieldNumber = 1;

		// Token: 0x04005735 RID: 22325
		private static readonly FieldCodec<LineCrossChallengeData> _repeated_challenges_codec = FieldCodec.ForMessage<LineCrossChallengeData>(10U, LineCrossChallengeData.Parser);

		// Token: 0x04005736 RID: 22326
		private readonly RepeatedField<LineCrossChallengeData> challenges_ = new RepeatedField<LineCrossChallengeData>();
	}
}
