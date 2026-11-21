using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AC4 RID: 2756
	[NetMessage(EMessageId.MulAchievementReceiveResponse)]
	public sealed class MulAchievementReceiveResponse : IMessage<MulAchievementReceiveResponse>, IMessage, IEquatable<MulAchievementReceiveResponse>, IDeepCloneable<MulAchievementReceiveResponse>, IBufferMessage
	{
		// Token: 0x0600F044 RID: 61508 RVA: 0x002320B8 File Offset: 0x002302B8
		[NullableContext(1)]
		public static MulAchievementReceiveResponse Create()
		{
			return new MulAchievementReceiveResponse();
		}

		// Token: 0x170030EA RID: 12522
		// (get) Token: 0x0600F045 RID: 61509 RVA: 0x002320BF File Offset: 0x002302BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030EB RID: 12523
		// (get) Token: 0x0600F046 RID: 61510 RVA: 0x002320C2 File Offset: 0x002302C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulAchievementReceiveResponse.Descriptor;
			}
		}

		// Token: 0x0600F047 RID: 61511 RVA: 0x002320C9 File Offset: 0x002302C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulAchievementReceiveResponse()
		{
		}

		// Token: 0x0600F048 RID: 61512 RVA: 0x002320E8 File Offset: 0x002302E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulAchievementReceiveResponse(MulAchievementReceiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.achievementIds_ = other.achievementIds_.Clone();
			this.achievementGroupIds_ = other.achievementGroupIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F049 RID: 61513 RVA: 0x0023213A File Offset: 0x0023033A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulAchievementReceiveResponse Clone()
		{
			return new MulAchievementReceiveResponse(this);
		}

		// Token: 0x170030EC RID: 12524
		// (get) Token: 0x0600F04A RID: 61514 RVA: 0x00232142 File Offset: 0x00230342
		// (set) Token: 0x0600F04B RID: 61515 RVA: 0x0023214A File Offset: 0x0023034A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170030ED RID: 12525
		// (get) Token: 0x0600F04C RID: 61516 RVA: 0x00232153 File Offset: 0x00230353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AchievementIds
		{
			get
			{
				return this.achievementIds_;
			}
		}

		// Token: 0x170030EE RID: 12526
		// (get) Token: 0x0600F04D RID: 61517 RVA: 0x0023215B File Offset: 0x0023035B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AchievementGroupIds
		{
			get
			{
				return this.achievementGroupIds_;
			}
		}

		// Token: 0x0600F04E RID: 61518 RVA: 0x00232163 File Offset: 0x00230363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulAchievementReceiveResponse);
		}

		// Token: 0x0600F04F RID: 61519 RVA: 0x00232174 File Offset: 0x00230374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulAchievementReceiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.achievementIds_.Equals(other.achievementIds_) && this.achievementGroupIds_.Equals(other.achievementGroupIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F050 RID: 61520 RVA: 0x002321D8 File Offset: 0x002303D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.achievementIds_.GetHashCode();
			num ^= this.achievementGroupIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F051 RID: 61521 RVA: 0x00232239 File Offset: 0x00230439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F052 RID: 61522 RVA: 0x00232246 File Offset: 0x00230446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F053 RID: 61523 RVA: 0x00232250 File Offset: 0x00230450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.achievementIds_.WriteTo(ref output, MulAchievementReceiveResponse._repeated_achievementIds_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.achievementGroupIds_.WriteTo(ref output, MulAchievementReceiveResponse._repeated_achievementGroupIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F054 RID: 61524 RVA: 0x002322B0 File Offset: 0x002304B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.achievementIds_.CalculateSize(MulAchievementReceiveResponse._repeated_achievementIds_codec);
			num += this.achievementGroupIds_.CalculateSize(MulAchievementReceiveResponse._repeated_achievementGroupIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F055 RID: 61525 RVA: 0x00232314 File Offset: 0x00230514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulAchievementReceiveResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.achievementIds_.Add(other.achievementIds_);
			this.achievementGroupIds_.Add(other.achievementGroupIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F056 RID: 61526 RVA: 0x00232372 File Offset: 0x00230572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F057 RID: 61527 RVA: 0x0023237C File Offset: 0x0023057C
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
				if (num <= 50U)
				{
					if (num == 48U || num == 50U)
					{
						this.achievementIds_.AddEntriesFrom(ref input, MulAchievementReceiveResponse._repeated_achievementIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 96U || num == 98U)
					{
						this.achievementGroupIds_.AddEntriesFrom(ref input, MulAchievementReceiveResponse._repeated_achievementGroupIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400618B RID: 24971
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400618C RID: 24972
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400618D RID: 24973
		private ErrorCode errorCode_;

		// Token: 0x0400618E RID: 24974
		public const int AchievementIdsFieldNumber = 6;

		// Token: 0x0400618F RID: 24975
		private static readonly FieldCodec<int> _repeated_achievementIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04006190 RID: 24976
		private readonly RepeatedField<int> achievementIds_ = new RepeatedField<int>();

		// Token: 0x04006191 RID: 24977
		public const int AchievementGroupIdsFieldNumber = 12;

		// Token: 0x04006192 RID: 24978
		private static readonly FieldCodec<int> _repeated_achievementGroupIds_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04006193 RID: 24979
		private readonly RepeatedField<int> achievementGroupIds_ = new RepeatedField<int>();
	}
}
