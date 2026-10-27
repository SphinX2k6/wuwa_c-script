using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001049 RID: 4169
	[NetMessage(EMessageId.RogueWeeklyStartRequest)]
	public sealed class RogueWeeklyStartRequest : IMessage<RogueWeeklyStartRequest>, IMessage, IEquatable<RogueWeeklyStartRequest>, IDeepCloneable<RogueWeeklyStartRequest>, IBufferMessage
	{
		// Token: 0x06016467 RID: 91239 RVA: 0x0033C4BC File Offset: 0x0033A6BC
		[NullableContext(1)]
		public static RogueWeeklyStartRequest Create()
		{
			return new RogueWeeklyStartRequest();
		}

		// Token: 0x17004A78 RID: 19064
		// (get) Token: 0x06016468 RID: 91240 RVA: 0x0033C4C3 File Offset: 0x0033A6C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A79 RID: 19065
		// (get) Token: 0x06016469 RID: 91241 RVA: 0x0033C4C6 File Offset: 0x0033A6C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyStartRequest.Descriptor;
			}
		}

		// Token: 0x0601646A RID: 91242 RVA: 0x0033C4CD File Offset: 0x0033A6CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyStartRequest()
		{
		}

		// Token: 0x0601646B RID: 91243 RVA: 0x0033C4EC File Offset: 0x0033A6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyStartRequest(RogueWeeklyStartRequest other) : this()
		{
			this.cycleId_ = other.cycleId_;
			this.roles_ = other.roles_.Clone();
			this.skillBranchIds_ = other.skillBranchIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601646C RID: 91244 RVA: 0x0033C53E File Offset: 0x0033A73E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyStartRequest Clone()
		{
			return new RogueWeeklyStartRequest(this);
		}

		// Token: 0x17004A7A RID: 19066
		// (get) Token: 0x0601646D RID: 91245 RVA: 0x0033C546 File Offset: 0x0033A746
		// (set) Token: 0x0601646E RID: 91246 RVA: 0x0033C54E File Offset: 0x0033A74E
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

		// Token: 0x17004A7B RID: 19067
		// (get) Token: 0x0601646F RID: 91247 RVA: 0x0033C557 File Offset: 0x0033A757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Roles
		{
			get
			{
				return this.roles_;
			}
		}

		// Token: 0x17004A7C RID: 19068
		// (get) Token: 0x06016470 RID: 91248 RVA: 0x0033C55F File Offset: 0x0033A75F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillBranchIds
		{
			get
			{
				return this.skillBranchIds_;
			}
		}

		// Token: 0x06016471 RID: 91249 RVA: 0x0033C567 File Offset: 0x0033A767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyStartRequest);
		}

		// Token: 0x06016472 RID: 91250 RVA: 0x0033C578 File Offset: 0x0033A778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyStartRequest other)
		{
			return other != null && (other == this || (this.CycleId == other.CycleId && this.roles_.Equals(other.roles_) && this.skillBranchIds_.Equals(other.skillBranchIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016473 RID: 91251 RVA: 0x0033C5DC File Offset: 0x0033A7DC
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

		// Token: 0x06016474 RID: 91252 RVA: 0x0033C637 File Offset: 0x0033A837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016475 RID: 91253 RVA: 0x0033C644 File Offset: 0x0033A844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016476 RID: 91254 RVA: 0x0033C650 File Offset: 0x0033A850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CycleId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.CycleId);
			}
			this.skillBranchIds_.WriteTo(ref output, RogueWeeklyStartRequest._repeated_skillBranchIds_codec);
			this.roles_.WriteTo(ref output, RogueWeeklyStartRequest._repeated_roles_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016477 RID: 91255 RVA: 0x0033C6B0 File Offset: 0x0033A8B0
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

		// Token: 0x06016478 RID: 91256 RVA: 0x0033C714 File Offset: 0x0033A914
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

		// Token: 0x06016479 RID: 91257 RVA: 0x0033C772 File Offset: 0x0033A972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601647A RID: 91258 RVA: 0x0033C77C File Offset: 0x0033A97C
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
				if (num <= 72U)
				{
					if (num == 56U)
					{
						this.CycleId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						goto IL_4B;
					}
				}
				else
				{
					if (num == 74U)
					{
						goto IL_4B;
					}
					if (num == 112U || num == 114U)
					{
						this.roles_.AddEntriesFrom(ref input, RogueWeeklyStartRequest._repeated_roles_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4B:
				this.skillBranchIds_.AddEntriesFrom(ref input, RogueWeeklyStartRequest._repeated_skillBranchIds_codec);
			}
		}

		// Token: 0x04008534 RID: 34100
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008535 RID: 34101
		public const int CycleIdFieldNumber = 7;

		// Token: 0x04008536 RID: 34102
		private int cycleId_;

		// Token: 0x04008537 RID: 34103
		public const int RolesFieldNumber = 14;

		// Token: 0x04008538 RID: 34104
		private static readonly FieldCodec<int> _repeated_roles_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04008539 RID: 34105
		private readonly RepeatedField<int> roles_ = new RepeatedField<int>();

		// Token: 0x0400853A RID: 34106
		public const int SkillBranchIdsFieldNumber = 9;

		// Token: 0x0400853B RID: 34107
		private static readonly FieldCodec<int> _repeated_skillBranchIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x0400853C RID: 34108
		private readonly RepeatedField<int> skillBranchIds_ = new RepeatedField<int>();
	}
}
