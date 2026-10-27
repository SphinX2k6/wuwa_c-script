using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AD5 RID: 2773
	[NetMessage(EMessageId.MulAchievementReceiveResponse)]
	public sealed class MulAchievementReceiveResponse : IMessage<MulAchievementReceiveResponse>, IMessage, IEquatable<MulAchievementReceiveResponse>, IDeepCloneable<MulAchievementReceiveResponse>, IBufferMessage
	{
		// Token: 0x0600F15E RID: 61790 RVA: 0x002342C4 File Offset: 0x002324C4
		[NullableContext(1)]
		public static MulAchievementReceiveResponse Create()
		{
			return new MulAchievementReceiveResponse();
		}

		// Token: 0x17003128 RID: 12584
		// (get) Token: 0x0600F15F RID: 61791 RVA: 0x002342CB File Offset: 0x002324CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003129 RID: 12585
		// (get) Token: 0x0600F160 RID: 61792 RVA: 0x002342CE File Offset: 0x002324CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulAchievementReceiveResponse.Descriptor;
			}
		}

		// Token: 0x0600F161 RID: 61793 RVA: 0x002342D5 File Offset: 0x002324D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulAchievementReceiveResponse()
		{
		}

		// Token: 0x0600F162 RID: 61794 RVA: 0x002342F4 File Offset: 0x002324F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulAchievementReceiveResponse(MulAchievementReceiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.achievementIds_ = other.achievementIds_.Clone();
			this.achievementGroupIds_ = other.achievementGroupIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F163 RID: 61795 RVA: 0x00234346 File Offset: 0x00232546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulAchievementReceiveResponse Clone()
		{
			return new MulAchievementReceiveResponse(this);
		}

		// Token: 0x1700312A RID: 12586
		// (get) Token: 0x0600F164 RID: 61796 RVA: 0x0023434E File Offset: 0x0023254E
		// (set) Token: 0x0600F165 RID: 61797 RVA: 0x00234356 File Offset: 0x00232556
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

		// Token: 0x1700312B RID: 12587
		// (get) Token: 0x0600F166 RID: 61798 RVA: 0x0023435F File Offset: 0x0023255F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AchievementIds
		{
			get
			{
				return this.achievementIds_;
			}
		}

		// Token: 0x1700312C RID: 12588
		// (get) Token: 0x0600F167 RID: 61799 RVA: 0x00234367 File Offset: 0x00232567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AchievementGroupIds
		{
			get
			{
				return this.achievementGroupIds_;
			}
		}

		// Token: 0x0600F168 RID: 61800 RVA: 0x0023436F File Offset: 0x0023256F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulAchievementReceiveResponse);
		}

		// Token: 0x0600F169 RID: 61801 RVA: 0x00234380 File Offset: 0x00232580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulAchievementReceiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.achievementIds_.Equals(other.achievementIds_) && this.achievementGroupIds_.Equals(other.achievementGroupIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F16A RID: 61802 RVA: 0x002343E4 File Offset: 0x002325E4
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

		// Token: 0x0600F16B RID: 61803 RVA: 0x00234445 File Offset: 0x00232645
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F16C RID: 61804 RVA: 0x00234452 File Offset: 0x00232652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F16D RID: 61805 RVA: 0x0023445C File Offset: 0x0023265C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.achievementIds_.WriteTo(ref output, MulAchievementReceiveResponse._repeated_achievementIds_codec);
			this.achievementGroupIds_.WriteTo(ref output, MulAchievementReceiveResponse._repeated_achievementGroupIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F16E RID: 61806 RVA: 0x002344BC File Offset: 0x002326BC
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

		// Token: 0x0600F16F RID: 61807 RVA: 0x00234520 File Offset: 0x00232720
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

		// Token: 0x0600F170 RID: 61808 RVA: 0x0023457E File Offset: 0x0023277E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F171 RID: 61809 RVA: 0x00234588 File Offset: 0x00232788
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
				if (num <= 40U)
				{
					if (num == 24U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 40U)
					{
						goto IL_4B;
					}
				}
				else
				{
					if (num == 42U)
					{
						goto IL_4B;
					}
					if (num == 120U || num == 122U)
					{
						this.achievementGroupIds_.AddEntriesFrom(ref input, MulAchievementReceiveResponse._repeated_achievementGroupIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4B:
				this.achievementIds_.AddEntriesFrom(ref input, MulAchievementReceiveResponse._repeated_achievementIds_codec);
			}
		}

		// Token: 0x04006182 RID: 24962
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006183 RID: 24963
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04006184 RID: 24964
		private ErrorCode errorCode_;

		// Token: 0x04006185 RID: 24965
		public const int AchievementIdsFieldNumber = 5;

		// Token: 0x04006186 RID: 24966
		private static readonly FieldCodec<int> _repeated_achievementIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04006187 RID: 24967
		private readonly RepeatedField<int> achievementIds_ = new RepeatedField<int>();

		// Token: 0x04006188 RID: 24968
		public const int AchievementGroupIdsFieldNumber = 15;

		// Token: 0x04006189 RID: 24969
		private static readonly FieldCodec<int> _repeated_achievementGroupIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x0400618A RID: 24970
		private readonly RepeatedField<int> achievementGroupIds_ = new RepeatedField<int>();
	}
}
