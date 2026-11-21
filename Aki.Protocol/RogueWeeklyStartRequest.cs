using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001039 RID: 4153
	[NetMessage(EMessageId.RogueWeeklyStartRequest)]
	public sealed class RogueWeeklyStartRequest : IMessage<RogueWeeklyStartRequest>, IMessage, IEquatable<RogueWeeklyStartRequest>, IDeepCloneable<RogueWeeklyStartRequest>, IBufferMessage
	{
		// Token: 0x06016382 RID: 91010 RVA: 0x0033ADF1 File Offset: 0x00338FF1
		[NullableContext(1)]
		public static RogueWeeklyStartRequest Create()
		{
			return new RogueWeeklyStartRequest();
		}

		// Token: 0x17004A4E RID: 19022
		// (get) Token: 0x06016383 RID: 91011 RVA: 0x0033ADF8 File Offset: 0x00338FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A4F RID: 19023
		// (get) Token: 0x06016384 RID: 91012 RVA: 0x0033ADFB File Offset: 0x00338FFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyStartRequest.Descriptor;
			}
		}

		// Token: 0x06016385 RID: 91013 RVA: 0x0033AE02 File Offset: 0x00339002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyStartRequest()
		{
		}

		// Token: 0x06016386 RID: 91014 RVA: 0x0033AE20 File Offset: 0x00339020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyStartRequest(RogueWeeklyStartRequest other) : this()
		{
			this.cycleId_ = other.cycleId_;
			this.roles_ = other.roles_.Clone();
			this.skillBranchIds_ = other.skillBranchIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016387 RID: 91015 RVA: 0x0033AE72 File Offset: 0x00339072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyStartRequest Clone()
		{
			return new RogueWeeklyStartRequest(this);
		}

		// Token: 0x17004A50 RID: 19024
		// (get) Token: 0x06016388 RID: 91016 RVA: 0x0033AE7A File Offset: 0x0033907A
		// (set) Token: 0x06016389 RID: 91017 RVA: 0x0033AE82 File Offset: 0x00339082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CycleId
		{
			get
			{
				return this.cycleId_;
			}
			set
			{
				this.cycleId_ = value;
			}
		}

		// Token: 0x17004A51 RID: 19025
		// (get) Token: 0x0601638A RID: 91018 RVA: 0x0033AE8B File Offset: 0x0033908B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Roles
		{
			get
			{
				return this.roles_;
			}
		}

		// Token: 0x17004A52 RID: 19026
		// (get) Token: 0x0601638B RID: 91019 RVA: 0x0033AE93 File Offset: 0x00339093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillBranchIds
		{
			get
			{
				return this.skillBranchIds_;
			}
		}

		// Token: 0x0601638C RID: 91020 RVA: 0x0033AE9B File Offset: 0x0033909B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyStartRequest);
		}

		// Token: 0x0601638D RID: 91021 RVA: 0x0033AEAC File Offset: 0x003390AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyStartRequest other)
		{
			return other != null && (other == this || (this.CycleId == other.CycleId && this.roles_.Equals(other.roles_) && this.skillBranchIds_.Equals(other.skillBranchIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601638E RID: 91022 RVA: 0x0033AF10 File Offset: 0x00339110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CycleId != 0)
			{
				num ^= this.CycleId.GetHashCode();
			}
			num ^= this.roles_.GetHashCode();
			num ^= this.skillBranchIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601638F RID: 91023 RVA: 0x0033AF6B File Offset: 0x0033916B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016390 RID: 91024 RVA: 0x0033AF78 File Offset: 0x00339178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016391 RID: 91025 RVA: 0x0033AF84 File Offset: 0x00339184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CycleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CycleId);
			}
			this.skillBranchIds_.WriteTo(ref output, RogueWeeklyStartRequest._repeated_skillBranchIds_codec);
			this.roles_.WriteTo(ref output, RogueWeeklyStartRequest._repeated_roles_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016392 RID: 91026 RVA: 0x0033AFE4 File Offset: 0x003391E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CycleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CycleId);
			}
			num += this.roles_.CalculateSize(RogueWeeklyStartRequest._repeated_roles_codec);
			num += this.skillBranchIds_.CalculateSize(RogueWeeklyStartRequest._repeated_skillBranchIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016393 RID: 91027 RVA: 0x0033B048 File Offset: 0x00339248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyStartRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CycleId != 0)
			{
				this.CycleId = other.CycleId;
			}
			this.roles_.Add(other.roles_);
			this.skillBranchIds_.Add(other.skillBranchIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016394 RID: 91028 RVA: 0x0033B0A6 File Offset: 0x003392A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016395 RID: 91029 RVA: 0x0033B0B0 File Offset: 0x003392B0
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
						this.CycleId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						goto IL_4A;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_4A;
					}
					if (num == 104U || num == 106U)
					{
						this.roles_.AddEntriesFrom(ref input, RogueWeeklyStartRequest._repeated_roles_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4A:
				this.skillBranchIds_.AddEntriesFrom(ref input, RogueWeeklyStartRequest._repeated_skillBranchIds_codec);
			}
		}

		// Token: 0x0400855E RID: 34142
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400855F RID: 34143
		public const int CycleIdFieldNumber = 1;

		// Token: 0x04008560 RID: 34144
		private int cycleId_;

		// Token: 0x04008561 RID: 34145
		public const int RolesFieldNumber = 13;

		// Token: 0x04008562 RID: 34146
		private static readonly FieldCodec<int> _repeated_roles_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04008563 RID: 34147
		private readonly RepeatedField<int> roles_ = new RepeatedField<int>();

		// Token: 0x04008564 RID: 34148
		public const int SkillBranchIdsFieldNumber = 2;

		// Token: 0x04008565 RID: 34149
		private static readonly FieldCodec<int> _repeated_skillBranchIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04008566 RID: 34150
		private readonly RepeatedField<int> skillBranchIds_ = new RepeatedField<int>();
	}
}
