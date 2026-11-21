using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001530 RID: 5424
	[NetMessage(EMessageId.UseSkillRequest)]
	public sealed class UseSkillRequest : IMessage<UseSkillRequest>, IMessage, IEquatable<UseSkillRequest>, IDeepCloneable<UseSkillRequest>, IBufferMessage
	{
		// Token: 0x0601CBC0 RID: 117696 RVA: 0x0042A254 File Offset: 0x00428454
		[NullableContext(1)]
		public static UseSkillRequest Create()
		{
			return new UseSkillRequest();
		}

		// Token: 0x17006136 RID: 24886
		// (get) Token: 0x0601CBC1 RID: 117697 RVA: 0x0042A25B File Offset: 0x0042845B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006137 RID: 24887
		// (get) Token: 0x0601CBC2 RID: 117698 RVA: 0x0042A25E File Offset: 0x0042845E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseSkillRequest.Descriptor;
			}
		}

		// Token: 0x0601CBC3 RID: 117699 RVA: 0x0042A265 File Offset: 0x00428465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillRequest()
		{
		}

		// Token: 0x0601CBC4 RID: 117700 RVA: 0x0042A278 File Offset: 0x00428478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillRequest(UseSkillRequest other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.useSkillInfo_ = ((other.useSkillInfo_ != null) ? other.useSkillInfo_.Clone() : null);
			this.skillSingleId_ = other.skillSingleId_;
			this.battleFlags_ = other.battleFlags_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CBC5 RID: 117701 RVA: 0x0042A2F1 File Offset: 0x004284F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillRequest Clone()
		{
			return new UseSkillRequest(this);
		}

		// Token: 0x17006138 RID: 24888
		// (get) Token: 0x0601CBC6 RID: 117702 RVA: 0x0042A2F9 File Offset: 0x004284F9
		// (set) Token: 0x0601CBC7 RID: 117703 RVA: 0x0042A301 File Offset: 0x00428501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon CombatCommon
		{
			get
			{
				return this.combatCommon_;
			}
			set
			{
				this.combatCommon_ = value;
			}
		}

		// Token: 0x17006139 RID: 24889
		// (get) Token: 0x0601CBC8 RID: 117704 RVA: 0x0042A30A File Offset: 0x0042850A
		// (set) Token: 0x0601CBC9 RID: 117705 RVA: 0x0042A312 File Offset: 0x00428512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillInformation UseSkillInfo
		{
			get
			{
				return this.useSkillInfo_;
			}
			set
			{
				this.useSkillInfo_ = value;
			}
		}

		// Token: 0x1700613A RID: 24890
		// (get) Token: 0x0601CBCA RID: 117706 RVA: 0x0042A31B File Offset: 0x0042851B
		// (set) Token: 0x0601CBCB RID: 117707 RVA: 0x0042A323 File Offset: 0x00428523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillSingleId
		{
			get
			{
				return this.skillSingleId_;
			}
			set
			{
				this.skillSingleId_ = value;
			}
		}

		// Token: 0x1700613B RID: 24891
		// (get) Token: 0x0601CBCC RID: 117708 RVA: 0x0042A32C File Offset: 0x0042852C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BattleFlags
		{
			get
			{
				return this.battleFlags_;
			}
		}

		// Token: 0x0601CBCD RID: 117709 RVA: 0x0042A334 File Offset: 0x00428534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseSkillRequest);
		}

		// Token: 0x0601CBCE RID: 117710 RVA: 0x0042A344 File Offset: 0x00428544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseSkillRequest other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.UseSkillInfo, other.UseSkillInfo) && this.SkillSingleId == other.SkillSingleId && this.battleFlags_.Equals(other.battleFlags_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CBCF RID: 117711 RVA: 0x0042A3BC File Offset: 0x004285BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this.useSkillInfo_ != null)
			{
				num ^= this.UseSkillInfo.GetHashCode();
			}
			if (this.SkillSingleId != 0)
			{
				num ^= this.SkillSingleId.GetHashCode();
			}
			num ^= this.battleFlags_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CBD0 RID: 117712 RVA: 0x0042A435 File Offset: 0x00428635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CBD1 RID: 117713 RVA: 0x0042A442 File Offset: 0x00428642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CBD2 RID: 117714 RVA: 0x0042A44C File Offset: 0x0042864C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.battleFlags_.WriteTo(ref output, UseSkillRequest._repeated_battleFlags_codec);
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.useSkillInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.UseSkillInfo);
			}
			if (this.SkillSingleId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SkillSingleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CBD3 RID: 117715 RVA: 0x0042A4D4 File Offset: 0x004286D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this.useSkillInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UseSkillInfo);
			}
			if (this.SkillSingleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillSingleId);
			}
			num += this.battleFlags_.CalculateSize(UseSkillRequest._repeated_battleFlags_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CBD4 RID: 117716 RVA: 0x0042A558 File Offset: 0x00428758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UseSkillRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.combatCommon_ != null)
			{
				if (this.combatCommon_ == null)
				{
					this.CombatCommon = new CombatCommon();
				}
				this.CombatCommon.MergeFrom(other.CombatCommon);
			}
			if (other.useSkillInfo_ != null)
			{
				if (this.useSkillInfo_ == null)
				{
					this.UseSkillInfo = new UseSkillInformation();
				}
				this.UseSkillInfo.MergeFrom(other.UseSkillInfo);
			}
			if (other.SkillSingleId != 0)
			{
				this.SkillSingleId = other.SkillSingleId;
			}
			this.battleFlags_.Add(other.battleFlags_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CBD5 RID: 117717 RVA: 0x0042A5FD File Offset: 0x004287FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CBD6 RID: 117718 RVA: 0x0042A608 File Offset: 0x00428808
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
				if (num <= 18U)
				{
					if (num == 16U || num == 18U)
					{
						this.battleFlags_.AddEntriesFrom(ref input, UseSkillRequest._repeated_battleFlags_codec);
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
						continue;
					}
					if (num == 58U)
					{
						if (this.useSkillInfo_ == null)
						{
							this.UseSkillInfo = new UseSkillInformation();
						}
						input.ReadMessage(this.UseSkillInfo);
						continue;
					}
					if (num == 64U)
					{
						this.SkillSingleId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A57F RID: 42367
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A580 RID: 42368
		public const int CombatCommonFieldNumber = 3;

		// Token: 0x0400A581 RID: 42369
		private CombatCommon combatCommon_;

		// Token: 0x0400A582 RID: 42370
		public const int UseSkillInfoFieldNumber = 7;

		// Token: 0x0400A583 RID: 42371
		private UseSkillInformation useSkillInfo_;

		// Token: 0x0400A584 RID: 42372
		public const int SkillSingleIdFieldNumber = 8;

		// Token: 0x0400A585 RID: 42373
		private int skillSingleId_;

		// Token: 0x0400A586 RID: 42374
		public const int BattleFlagsFieldNumber = 2;

		// Token: 0x0400A587 RID: 42375
		private static readonly FieldCodec<int> _repeated_battleFlags_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400A588 RID: 42376
		private readonly RepeatedField<int> battleFlags_ = new RepeatedField<int>();
	}
}
