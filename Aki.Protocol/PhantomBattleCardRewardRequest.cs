using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C49 RID: 3145
	[NetMessage(EMessageId.PhantomBattleCardRewardRequest)]
	public sealed class PhantomBattleCardRewardRequest : IMessage<PhantomBattleCardRewardRequest>, IMessage, IEquatable<PhantomBattleCardRewardRequest>, IDeepCloneable<PhantomBattleCardRewardRequest>, IBufferMessage
	{
		// Token: 0x06011136 RID: 69942 RVA: 0x00280845 File Offset: 0x0027EA45
		[NullableContext(1)]
		public static PhantomBattleCardRewardRequest Create()
		{
			return new PhantomBattleCardRewardRequest();
		}

		// Token: 0x17003870 RID: 14448
		// (get) Token: 0x06011137 RID: 69943 RVA: 0x0028084C File Offset: 0x0027EA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003871 RID: 14449
		// (get) Token: 0x06011138 RID: 69944 RVA: 0x0028084F File Offset: 0x0027EA4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardRewardRequest.Descriptor;
			}
		}

		// Token: 0x06011139 RID: 69945 RVA: 0x00280856 File Offset: 0x0027EA56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRewardRequest()
		{
		}

		// Token: 0x0601113A RID: 69946 RVA: 0x00280869 File Offset: 0x0027EA69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRewardRequest(PhantomBattleCardRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.cardRewardId_ = other.cardRewardId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601113B RID: 69947 RVA: 0x0028089F File Offset: 0x0027EA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRewardRequest Clone()
		{
			return new PhantomBattleCardRewardRequest(this);
		}

		// Token: 0x17003872 RID: 14450
		// (get) Token: 0x0601113C RID: 69948 RVA: 0x002808A7 File Offset: 0x0027EAA7
		// (set) Token: 0x0601113D RID: 69949 RVA: 0x002808AF File Offset: 0x0027EAAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17003873 RID: 14451
		// (get) Token: 0x0601113E RID: 69950 RVA: 0x002808B8 File Offset: 0x0027EAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CardRewardId
		{
			get
			{
				return this.cardRewardId_;
			}
		}

		// Token: 0x0601113F RID: 69951 RVA: 0x002808C0 File Offset: 0x0027EAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardRewardRequest);
		}

		// Token: 0x06011140 RID: 69952 RVA: 0x002808D0 File Offset: 0x0027EAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.cardRewardId_.Equals(other.cardRewardId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011141 RID: 69953 RVA: 0x00280920 File Offset: 0x0027EB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.cardRewardId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011142 RID: 69954 RVA: 0x0028096D File Offset: 0x0027EB6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011143 RID: 69955 RVA: 0x0028097A File Offset: 0x0027EB7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011144 RID: 69956 RVA: 0x00280984 File Offset: 0x0027EB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			this.cardRewardId_.WriteTo(ref output, PhantomBattleCardRewardRequest._repeated_cardRewardId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011145 RID: 69957 RVA: 0x002809D4 File Offset: 0x0027EBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.cardRewardId_.CalculateSize(PhantomBattleCardRewardRequest._repeated_cardRewardId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011146 RID: 69958 RVA: 0x00280A28 File Offset: 0x0027EC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.cardRewardId_.Add(other.cardRewardId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011147 RID: 69959 RVA: 0x00280A75 File Offset: 0x0027EC75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011148 RID: 69960 RVA: 0x00280A80 File Offset: 0x0027EC80
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
				if (num != 56U)
				{
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.cardRewardId_.AddEntriesFrom(ref input, PhantomBattleCardRewardRequest._repeated_cardRewardId_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006C91 RID: 27793
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C92 RID: 27794
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x04006C93 RID: 27795
		private int activityId_;

		// Token: 0x04006C94 RID: 27796
		public const int CardRewardIdFieldNumber = 13;

		// Token: 0x04006C95 RID: 27797
		private static readonly FieldCodec<int> _repeated_cardRewardId_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04006C96 RID: 27798
		private readonly RepeatedField<int> cardRewardId_ = new RepeatedField<int>();
	}
}
