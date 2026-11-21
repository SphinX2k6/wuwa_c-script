using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000225 RID: 549
	[NetMessage(EMessageId.CalabashLevelsRewardNotify)]
	public sealed class CalabashLevelsRewardNotify : IMessage<CalabashLevelsRewardNotify>, IMessage, IEquatable<CalabashLevelsRewardNotify>, IDeepCloneable<CalabashLevelsRewardNotify>, IBufferMessage
	{
		// Token: 0x06003C13 RID: 15379 RVA: 0x00095A09 File Offset: 0x00093C09
		[NullableContext(1)]
		public static CalabashLevelsRewardNotify Create()
		{
			return new CalabashLevelsRewardNotify();
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06003C14 RID: 15380 RVA: 0x00095A10 File Offset: 0x00093C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06003C15 RID: 15381 RVA: 0x00095A13 File Offset: 0x00093C13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashLevelsRewardNotify.Descriptor;
			}
		}

		// Token: 0x06003C16 RID: 15382 RVA: 0x00095A1A File Offset: 0x00093C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashLevelsRewardNotify()
		{
		}

		// Token: 0x06003C17 RID: 15383 RVA: 0x00095A2D File Offset: 0x00093C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashLevelsRewardNotify(CalabashLevelsRewardNotify other) : this()
		{
			this.rewardedLevels_ = other.rewardedLevels_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C18 RID: 15384 RVA: 0x00095A57 File Offset: 0x00093C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashLevelsRewardNotify Clone()
		{
			return new CalabashLevelsRewardNotify(this);
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06003C19 RID: 15385 RVA: 0x00095A5F File Offset: 0x00093C5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardedLevels
		{
			get
			{
				return this.rewardedLevels_;
			}
		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x00095A67 File Offset: 0x00093C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashLevelsRewardNotify);
		}

		// Token: 0x06003C1B RID: 15387 RVA: 0x00095A75 File Offset: 0x00093C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashLevelsRewardNotify other)
		{
			return other != null && (other == this || (this.rewardedLevels_.Equals(other.rewardedLevels_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003C1C RID: 15388 RVA: 0x00095AA8 File Offset: 0x00093CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rewardedLevels_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003C1D RID: 15389 RVA: 0x00095ADC File Offset: 0x00093CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003C1E RID: 15390 RVA: 0x00095AE9 File Offset: 0x00093CE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C1F RID: 15391 RVA: 0x00095AF2 File Offset: 0x00093CF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardedLevels_.WriteTo(ref output, CalabashLevelsRewardNotify._repeated_rewardedLevels_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003C20 RID: 15392 RVA: 0x00095B1C File Offset: 0x00093D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewardedLevels_.CalculateSize(CalabashLevelsRewardNotify._repeated_rewardedLevels_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003C21 RID: 15393 RVA: 0x00095B55 File Offset: 0x00093D55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashLevelsRewardNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.rewardedLevels_.Add(other.rewardedLevels_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003C22 RID: 15394 RVA: 0x00095B83 File Offset: 0x00093D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C23 RID: 15395 RVA: 0x00095B8C File Offset: 0x00093D8C
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
				if (num != 88U && num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rewardedLevels_.AddEntriesFrom(ref input, CalabashLevelsRewardNotify._repeated_rewardedLevels_codec);
				}
			}
		}

		// Token: 0x04002CA7 RID: 11431
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CA8 RID: 11432
		public const int RewardedLevelsFieldNumber = 11;

		// Token: 0x04002CA9 RID: 11433
		private static readonly FieldCodec<int> _repeated_rewardedLevels_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04002CAA RID: 11434
		private readonly RepeatedField<int> rewardedLevels_ = new RepeatedField<int>();
	}
}
