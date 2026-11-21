using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BA6 RID: 2982
	public sealed class ParkourActivity : IMessage<ParkourActivity>, IMessage, IEquatable<ParkourActivity>, IDeepCloneable<ParkourActivity>, IBufferMessage
	{
		// Token: 0x060102FF RID: 66303 RVA: 0x0025D4A1 File Offset: 0x0025B6A1
		[NullableContext(1)]
		public static ParkourActivity Create()
		{
			return new ParkourActivity();
		}

		// Token: 0x17003512 RID: 13586
		// (get) Token: 0x06010300 RID: 66304 RVA: 0x0025D4A8 File Offset: 0x0025B6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003513 RID: 13587
		// (get) Token: 0x06010301 RID: 66305 RVA: 0x0025D4AB File Offset: 0x0025B6AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParkourActivity.Descriptor;
			}
		}

		// Token: 0x06010302 RID: 66306 RVA: 0x0025D4B2 File Offset: 0x0025B6B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourActivity()
		{
		}

		// Token: 0x06010303 RID: 66307 RVA: 0x0025D4C5 File Offset: 0x0025B6C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourActivity(ParkourActivity other) : this()
		{
			this.challenges_ = other.challenges_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010304 RID: 66308 RVA: 0x0025D4EF File Offset: 0x0025B6EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourActivity Clone()
		{
			return new ParkourActivity(this);
		}

		// Token: 0x17003514 RID: 13588
		// (get) Token: 0x06010305 RID: 66309 RVA: 0x0025D4F7 File Offset: 0x0025B6F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ParkourActivityChallenge> Challenges
		{
			get
			{
				return this.challenges_;
			}
		}

		// Token: 0x06010306 RID: 66310 RVA: 0x0025D4FF File Offset: 0x0025B6FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParkourActivity);
		}

		// Token: 0x06010307 RID: 66311 RVA: 0x0025D50D File Offset: 0x0025B70D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ParkourActivity other)
		{
			return other != null && (other == this || (this.challenges_.Equals(other.challenges_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010308 RID: 66312 RVA: 0x0025D540 File Offset: 0x0025B740
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

		// Token: 0x06010309 RID: 66313 RVA: 0x0025D574 File Offset: 0x0025B774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601030A RID: 66314 RVA: 0x0025D581 File Offset: 0x0025B781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601030B RID: 66315 RVA: 0x0025D58A File Offset: 0x0025B78A
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

		// Token: 0x0601030C RID: 66316 RVA: 0x0025D5B4 File Offset: 0x0025B7B4
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

		// Token: 0x0601030D RID: 66317 RVA: 0x0025D5ED File Offset: 0x0025B7ED
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

		// Token: 0x0601030E RID: 66318 RVA: 0x0025D61B File Offset: 0x0025B81B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601030F RID: 66319 RVA: 0x0025D624 File Offset: 0x0025B824
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

		// Token: 0x04006778 RID: 26488
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006779 RID: 26489
		public const int ChallengesFieldNumber = 1;

		// Token: 0x0400677A RID: 26490
		private static readonly FieldCodec<ParkourActivityChallenge> _repeated_challenges_codec = FieldCodec.ForMessage<ParkourActivityChallenge>(10U, ParkourActivityChallenge.Parser);

		// Token: 0x0400677B RID: 26491
		private readonly RepeatedField<ParkourActivityChallenge> challenges_ = new RepeatedField<ParkourActivityChallenge>();
	}
}
