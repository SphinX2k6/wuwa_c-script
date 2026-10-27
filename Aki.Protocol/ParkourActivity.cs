using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BB6 RID: 2998
	public sealed class ParkourActivity : IMessage<ParkourActivity>, IMessage, IEquatable<ParkourActivity>, IDeepCloneable<ParkourActivity>, IBufferMessage
	{
		// Token: 0x06010403 RID: 66563 RVA: 0x0025F355 File Offset: 0x0025D555
		[NullableContext(1)]
		public static ParkourActivity Create()
		{
			return new ParkourActivity();
		}

		// Token: 0x1700354B RID: 13643
		// (get) Token: 0x06010404 RID: 66564 RVA: 0x0025F35C File Offset: 0x0025D55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700354C RID: 13644
		// (get) Token: 0x06010405 RID: 66565 RVA: 0x0025F35F File Offset: 0x0025D55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParkourActivity.Descriptor;
			}
		}

		// Token: 0x06010406 RID: 66566 RVA: 0x0025F366 File Offset: 0x0025D566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourActivity()
		{
		}

		// Token: 0x06010407 RID: 66567 RVA: 0x0025F379 File Offset: 0x0025D579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourActivity(ParkourActivity other) : this()
		{
			this.challenges_ = other.challenges_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010408 RID: 66568 RVA: 0x0025F3A3 File Offset: 0x0025D5A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourActivity Clone()
		{
			return new ParkourActivity(this);
		}

		// Token: 0x1700354D RID: 13645
		// (get) Token: 0x06010409 RID: 66569 RVA: 0x0025F3AB File Offset: 0x0025D5AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ParkourActivityChallenge> Challenges
		{
			get
			{
				return this.challenges_;
			}
		}

		// Token: 0x0601040A RID: 66570 RVA: 0x0025F3B3 File Offset: 0x0025D5B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParkourActivity);
		}

		// Token: 0x0601040B RID: 66571 RVA: 0x0025F3C1 File Offset: 0x0025D5C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ParkourActivity other)
		{
			return other != null && (other == this || (this.challenges_.Equals(other.challenges_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601040C RID: 66572 RVA: 0x0025F3F4 File Offset: 0x0025D5F4
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

		// Token: 0x0601040D RID: 66573 RVA: 0x0025F428 File Offset: 0x0025D628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601040E RID: 66574 RVA: 0x0025F435 File Offset: 0x0025D635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601040F RID: 66575 RVA: 0x0025F43E File Offset: 0x0025D63E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.challenges_.WriteTo(ref output, ParkourActivity._repeated_challenges_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010410 RID: 66576 RVA: 0x0025F468 File Offset: 0x0025D668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.challenges_.CalculateSize(ParkourActivity._repeated_challenges_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010411 RID: 66577 RVA: 0x0025F4A1 File Offset: 0x0025D6A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ParkourActivity other)
		{
			if (other == null)
			{
				return;
			}
			this.challenges_.Add(other.challenges_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010412 RID: 66578 RVA: 0x0025F4CF File Offset: 0x0025D6CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010413 RID: 66579 RVA: 0x0025F4D8 File Offset: 0x0025D6D8
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
					this.challenges_.AddEntriesFrom(ref input, ParkourActivity._repeated_challenges_codec);
				}
			}
		}

		// Token: 0x04006768 RID: 26472
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006769 RID: 26473
		public const int ChallengesFieldNumber = 1;

		// Token: 0x0400676A RID: 26474
		private static readonly FieldCodec<ParkourActivityChallenge> _repeated_challenges_codec = FieldCodec.ForMessage<ParkourActivityChallenge>(10U, ParkourActivityChallenge.Parser);

		// Token: 0x0400676B RID: 26475
		private readonly RepeatedField<ParkourActivityChallenge> challenges_ = new RepeatedField<ParkourActivityChallenge>();
	}
}
