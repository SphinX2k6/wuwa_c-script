using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008F5 RID: 2293
	[NetMessage(EMessageId.LevelPlayRewardNotify)]
	public sealed class LevelPlayRewardNotify : IMessage<LevelPlayRewardNotify>, IMessage, IEquatable<LevelPlayRewardNotify>, IDeepCloneable<LevelPlayRewardNotify>, IBufferMessage
	{
		// Token: 0x0600CAE2 RID: 51938 RVA: 0x001DF08F File Offset: 0x001DD28F
		[NullableContext(1)]
		public static LevelPlayRewardNotify Create()
		{
			return new LevelPlayRewardNotify();
		}

		// Token: 0x170028F1 RID: 10481
		// (get) Token: 0x0600CAE3 RID: 51939 RVA: 0x001DF096 File Offset: 0x001DD296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028F2 RID: 10482
		// (get) Token: 0x0600CAE4 RID: 51940 RVA: 0x001DF099 File Offset: 0x001DD299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayRewardNotify.Descriptor;
			}
		}

		// Token: 0x0600CAE5 RID: 51941 RVA: 0x001DF0A0 File Offset: 0x001DD2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardNotify()
		{
		}

		// Token: 0x0600CAE6 RID: 51942 RVA: 0x001DF0B3 File Offset: 0x001DD2B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardNotify(LevelPlayRewardNotify other) : this()
		{
			this.levelPlayRewards_ = other.levelPlayRewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CAE7 RID: 51943 RVA: 0x001DF0DD File Offset: 0x001DD2DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardNotify Clone()
		{
			return new LevelPlayRewardNotify(this);
		}

		// Token: 0x170028F3 RID: 10483
		// (get) Token: 0x0600CAE8 RID: 51944 RVA: 0x001DF0E5 File Offset: 0x001DD2E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LevelPlayRewardInfo> LevelPlayRewards
		{
			get
			{
				return this.levelPlayRewards_;
			}
		}

		// Token: 0x0600CAE9 RID: 51945 RVA: 0x001DF0ED File Offset: 0x001DD2ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayRewardNotify);
		}

		// Token: 0x0600CAEA RID: 51946 RVA: 0x001DF0FB File Offset: 0x001DD2FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayRewardNotify other)
		{
			return other != null && (other == this || (this.levelPlayRewards_.Equals(other.levelPlayRewards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CAEB RID: 51947 RVA: 0x001DF130 File Offset: 0x001DD330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.levelPlayRewards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CAEC RID: 51948 RVA: 0x001DF164 File Offset: 0x001DD364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CAED RID: 51949 RVA: 0x001DF171 File Offset: 0x001DD371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CAEE RID: 51950 RVA: 0x001DF17A File Offset: 0x001DD37A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.levelPlayRewards_.WriteTo(ref output, LevelPlayRewardNotify._repeated_levelPlayRewards_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CAEF RID: 51951 RVA: 0x001DF1A4 File Offset: 0x001DD3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.levelPlayRewards_.CalculateSize(LevelPlayRewardNotify._repeated_levelPlayRewards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CAF0 RID: 51952 RVA: 0x001DF1DD File Offset: 0x001DD3DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayRewardNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.levelPlayRewards_.Add(other.levelPlayRewards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CAF1 RID: 51953 RVA: 0x001DF20B File Offset: 0x001DD40B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CAF2 RID: 51954 RVA: 0x001DF214 File Offset: 0x001DD414
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
					this.levelPlayRewards_.AddEntriesFrom(ref input, LevelPlayRewardNotify._repeated_levelPlayRewards_codec);
				}
			}
		}

		// Token: 0x04005693 RID: 22163
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005694 RID: 22164
		public const int LevelPlayRewardsFieldNumber = 1;

		// Token: 0x04005695 RID: 22165
		private static readonly FieldCodec<LevelPlayRewardInfo> _repeated_levelPlayRewards_codec = FieldCodec.ForMessage<LevelPlayRewardInfo>(10U, LevelPlayRewardInfo.Parser);

		// Token: 0x04005696 RID: 22166
		private readonly RepeatedField<LevelPlayRewardInfo> levelPlayRewards_ = new RepeatedField<LevelPlayRewardInfo>();
	}
}
