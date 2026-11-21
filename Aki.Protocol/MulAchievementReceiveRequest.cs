using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AC3 RID: 2755
	[NetMessage(EMessageId.MulAchievementReceiveRequest)]
	public sealed class MulAchievementReceiveRequest : IMessage<MulAchievementReceiveRequest>, IMessage, IEquatable<MulAchievementReceiveRequest>, IDeepCloneable<MulAchievementReceiveRequest>, IBufferMessage
	{
		// Token: 0x0600F031 RID: 61489 RVA: 0x00231E23 File Offset: 0x00230023
		[NullableContext(1)]
		public static MulAchievementReceiveRequest Create()
		{
			return new MulAchievementReceiveRequest();
		}

		// Token: 0x170030E6 RID: 12518
		// (get) Token: 0x0600F032 RID: 61490 RVA: 0x00231E2A File Offset: 0x0023002A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030E7 RID: 12519
		// (get) Token: 0x0600F033 RID: 61491 RVA: 0x00231E2D File Offset: 0x0023002D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulAchievementReceiveRequest.Descriptor;
			}
		}

		// Token: 0x0600F034 RID: 61492 RVA: 0x00231E34 File Offset: 0x00230034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulAchievementReceiveRequest()
		{
		}

		// Token: 0x0600F035 RID: 61493 RVA: 0x00231E52 File Offset: 0x00230052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulAchievementReceiveRequest(MulAchievementReceiveRequest other) : this()
		{
			this.achievementIds_ = other.achievementIds_.Clone();
			this.achievementGroupIds_ = other.achievementGroupIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F036 RID: 61494 RVA: 0x00231E8D File Offset: 0x0023008D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulAchievementReceiveRequest Clone()
		{
			return new MulAchievementReceiveRequest(this);
		}

		// Token: 0x170030E8 RID: 12520
		// (get) Token: 0x0600F037 RID: 61495 RVA: 0x00231E95 File Offset: 0x00230095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AchievementIds
		{
			get
			{
				return this.achievementIds_;
			}
		}

		// Token: 0x170030E9 RID: 12521
		// (get) Token: 0x0600F038 RID: 61496 RVA: 0x00231E9D File Offset: 0x0023009D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AchievementGroupIds
		{
			get
			{
				return this.achievementGroupIds_;
			}
		}

		// Token: 0x0600F039 RID: 61497 RVA: 0x00231EA5 File Offset: 0x002300A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulAchievementReceiveRequest);
		}

		// Token: 0x0600F03A RID: 61498 RVA: 0x00231EB4 File Offset: 0x002300B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulAchievementReceiveRequest other)
		{
			return other != null && (other == this || (this.achievementIds_.Equals(other.achievementIds_) && this.achievementGroupIds_.Equals(other.achievementGroupIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F03B RID: 61499 RVA: 0x00231F08 File Offset: 0x00230108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.achievementIds_.GetHashCode();
			num ^= this.achievementGroupIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F03C RID: 61500 RVA: 0x00231F4A File Offset: 0x0023014A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F03D RID: 61501 RVA: 0x00231F57 File Offset: 0x00230157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F03E RID: 61502 RVA: 0x00231F60 File Offset: 0x00230160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.achievementGroupIds_.WriteTo(ref output, MulAchievementReceiveRequest._repeated_achievementGroupIds_codec);
			this.achievementIds_.WriteTo(ref output, MulAchievementReceiveRequest._repeated_achievementIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F03F RID: 61503 RVA: 0x00231F98 File Offset: 0x00230198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.achievementIds_.CalculateSize(MulAchievementReceiveRequest._repeated_achievementIds_codec);
			num += this.achievementGroupIds_.CalculateSize(MulAchievementReceiveRequest._repeated_achievementGroupIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F040 RID: 61504 RVA: 0x00231FE4 File Offset: 0x002301E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulAchievementReceiveRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.achievementIds_.Add(other.achievementIds_);
			this.achievementGroupIds_.Add(other.achievementGroupIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F041 RID: 61505 RVA: 0x00232023 File Offset: 0x00230223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F042 RID: 61506 RVA: 0x0023202C File Offset: 0x0023022C
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
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.achievementGroupIds_.AddEntriesFrom(ref input, MulAchievementReceiveRequest._repeated_achievementGroupIds_codec);
						continue;
					}
				}
				else if (num == 40U || num == 42U)
				{
					this.achievementIds_.AddEntriesFrom(ref input, MulAchievementReceiveRequest._repeated_achievementIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006184 RID: 24964
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006185 RID: 24965
		public const int AchievementIdsFieldNumber = 5;

		// Token: 0x04006186 RID: 24966
		private static readonly FieldCodec<int> _repeated_achievementIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04006187 RID: 24967
		private readonly RepeatedField<int> achievementIds_ = new RepeatedField<int>();

		// Token: 0x04006188 RID: 24968
		public const int AchievementGroupIdsFieldNumber = 1;

		// Token: 0x04006189 RID: 24969
		private static readonly FieldCodec<int> _repeated_achievementGroupIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400618A RID: 24970
		private readonly RepeatedField<int> achievementGroupIds_ = new RepeatedField<int>();
	}
}
