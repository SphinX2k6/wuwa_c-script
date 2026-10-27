using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014BA RID: 5306
	[NetMessage(EMessageId.UseSkillRequest)]
	public sealed class UseSkillRequest : IMessage<UseSkillRequest>, IMessage, IEquatable<UseSkillRequest>, IDeepCloneable<UseSkillRequest>, IBufferMessage
	{
		// Token: 0x0601C0F9 RID: 114937 RVA: 0x0040E79C File Offset: 0x0040C99C
		[NullableContext(1)]
		public static UseSkillRequest Create()
		{
			return new UseSkillRequest();
		}

		// Token: 0x17005E95 RID: 24213
		// (get) Token: 0x0601C0FA RID: 114938 RVA: 0x0040E7A3 File Offset: 0x0040C9A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E96 RID: 24214
		// (get) Token: 0x0601C0FB RID: 114939 RVA: 0x0040E7A6 File Offset: 0x0040C9A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseSkillRequest.Descriptor;
			}
		}

		// Token: 0x0601C0FC RID: 114940 RVA: 0x0040E7AD File Offset: 0x0040C9AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillRequest()
		{
		}

		// Token: 0x0601C0FD RID: 114941 RVA: 0x0040E7C0 File Offset: 0x0040C9C0
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

		// Token: 0x0601C0FE RID: 114942 RVA: 0x0040E839 File Offset: 0x0040CA39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillRequest Clone()
		{
			return new UseSkillRequest(this);
		}

		// Token: 0x17005E97 RID: 24215
		// (get) Token: 0x0601C0FF RID: 114943 RVA: 0x0040E841 File Offset: 0x0040CA41
		// (set) Token: 0x0601C100 RID: 114944 RVA: 0x0040E849 File Offset: 0x0040CA49
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

		// Token: 0x17005E98 RID: 24216
		// (get) Token: 0x0601C101 RID: 114945 RVA: 0x0040E852 File Offset: 0x0040CA52
		// (set) Token: 0x0601C102 RID: 114946 RVA: 0x0040E85A File Offset: 0x0040CA5A
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

		// Token: 0x17005E99 RID: 24217
		// (get) Token: 0x0601C103 RID: 114947 RVA: 0x0040E863 File Offset: 0x0040CA63
		// (set) Token: 0x0601C104 RID: 114948 RVA: 0x0040E86B File Offset: 0x0040CA6B
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

		// Token: 0x17005E9A RID: 24218
		// (get) Token: 0x0601C105 RID: 114949 RVA: 0x0040E874 File Offset: 0x0040CA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BattleFlags
		{
			get
			{
				return this.battleFlags_;
			}
		}

		// Token: 0x0601C106 RID: 114950 RVA: 0x0040E87C File Offset: 0x0040CA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseSkillRequest);
		}

		// Token: 0x0601C107 RID: 114951 RVA: 0x0040E88C File Offset: 0x0040CA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseSkillRequest other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.UseSkillInfo, other.UseSkillInfo) && this.SkillSingleId == other.SkillSingleId && this.battleFlags_.Equals(other.battleFlags_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C108 RID: 114952 RVA: 0x0040E904 File Offset: 0x0040CB04
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

		// Token: 0x0601C109 RID: 114953 RVA: 0x0040E97D File Offset: 0x0040CB7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C10A RID: 114954 RVA: 0x0040E98A File Offset: 0x0040CB8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C10B RID: 114955 RVA: 0x0040E994 File Offset: 0x0040CB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.battleFlags_.WriteTo(ref output, UseSkillRequest._repeated_battleFlags_codec);
			if (this.SkillSingleId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SkillSingleId);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.useSkillInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.UseSkillInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C10C RID: 114956 RVA: 0x0040EA1C File Offset: 0x0040CC1C
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

		// Token: 0x0601C10D RID: 114957 RVA: 0x0040EAA0 File Offset: 0x0040CCA0
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

		// Token: 0x0601C10E RID: 114958 RVA: 0x0040EB45 File Offset: 0x0040CD45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C10F RID: 114959 RVA: 0x0040EB50 File Offset: 0x0040CD50
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
						this.battleFlags_.AddEntriesFrom(ref input, UseSkillRequest._repeated_battleFlags_codec);
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.SkillSingleId = input.ReadInt32();
						continue;
					}
					if (num == 106U)
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
						continue;
					}
					if (num == 122U)
					{
						if (this.useSkillInfo_ == null)
						{
							this.UseSkillInfo = new UseSkillInformation();
						}
						input.ReadMessage(this.UseSkillInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A126 RID: 41254
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A127 RID: 41255
		public const int CombatCommonFieldNumber = 13;

		// Token: 0x0400A128 RID: 41256
		private CombatCommon combatCommon_;

		// Token: 0x0400A129 RID: 41257
		public const int UseSkillInfoFieldNumber = 15;

		// Token: 0x0400A12A RID: 41258
		private UseSkillInformation useSkillInfo_;

		// Token: 0x0400A12B RID: 41259
		public const int SkillSingleIdFieldNumber = 5;

		// Token: 0x0400A12C RID: 41260
		private int skillSingleId_;

		// Token: 0x0400A12D RID: 41261
		public const int BattleFlagsFieldNumber = 1;

		// Token: 0x0400A12E RID: 41262
		private static readonly FieldCodec<int> _repeated_battleFlags_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400A12F RID: 41263
		private readonly RepeatedField<int> battleFlags_ = new RepeatedField<int>();
	}
}
