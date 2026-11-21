using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C54 RID: 3156
	public sealed class PhantomBattleCardSkillUnlockInfo : IMessage<PhantomBattleCardSkillUnlockInfo>, IMessage, IEquatable<PhantomBattleCardSkillUnlockInfo>, IDeepCloneable<PhantomBattleCardSkillUnlockInfo>, IBufferMessage
	{
		// Token: 0x06011218 RID: 70168 RVA: 0x002827CE File Offset: 0x002809CE
		[NullableContext(1)]
		public static PhantomBattleCardSkillUnlockInfo Create()
		{
			return new PhantomBattleCardSkillUnlockInfo();
		}

		// Token: 0x1700389F RID: 14495
		// (get) Token: 0x06011219 RID: 70169 RVA: 0x002827D5 File Offset: 0x002809D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleCardSkillUnlockInfo> Parser
		{
			get
			{
				return PhantomBattleCardSkillUnlockInfo._parser;
			}
		}

		// Token: 0x170038A0 RID: 14496
		// (get) Token: 0x0601121A RID: 70170 RVA: 0x002827DC File Offset: 0x002809DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038A1 RID: 14497
		// (get) Token: 0x0601121B RID: 70171 RVA: 0x002827DF File Offset: 0x002809DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardSkillUnlockInfo.Descriptor;
			}
		}

		// Token: 0x0601121C RID: 70172 RVA: 0x002827E6 File Offset: 0x002809E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSkillUnlockInfo()
		{
		}

		// Token: 0x0601121D RID: 70173 RVA: 0x002827F0 File Offset: 0x002809F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSkillUnlockInfo(PhantomBattleCardSkillUnlockInfo other) : this()
		{
			this.cardId_ = other.cardId_;
			this.unlock_ = other.unlock_;
			this.targetNum_ = other.targetNum_;
			this.curNum_ = other.curNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601121E RID: 70174 RVA: 0x00282844 File Offset: 0x00280A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSkillUnlockInfo Clone()
		{
			return new PhantomBattleCardSkillUnlockInfo(this);
		}

		// Token: 0x170038A2 RID: 14498
		// (get) Token: 0x0601121F RID: 70175 RVA: 0x0028284C File Offset: 0x00280A4C
		// (set) Token: 0x06011220 RID: 70176 RVA: 0x00282854 File Offset: 0x00280A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardId
		{
			get
			{
				return this.cardId_;
			}
			set
			{
				this.cardId_ = value;
			}
		}

		// Token: 0x170038A3 RID: 14499
		// (get) Token: 0x06011221 RID: 70177 RVA: 0x0028285D File Offset: 0x00280A5D
		// (set) Token: 0x06011222 RID: 70178 RVA: 0x00282865 File Offset: 0x00280A65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Unlock
		{
			get
			{
				return this.unlock_;
			}
			set
			{
				this.unlock_ = value;
			}
		}

		// Token: 0x170038A4 RID: 14500
		// (get) Token: 0x06011223 RID: 70179 RVA: 0x0028286E File Offset: 0x00280A6E
		// (set) Token: 0x06011224 RID: 70180 RVA: 0x00282876 File Offset: 0x00280A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetNum
		{
			get
			{
				return this.targetNum_;
			}
			set
			{
				this.targetNum_ = value;
			}
		}

		// Token: 0x170038A5 RID: 14501
		// (get) Token: 0x06011225 RID: 70181 RVA: 0x0028287F File Offset: 0x00280A7F
		// (set) Token: 0x06011226 RID: 70182 RVA: 0x00282887 File Offset: 0x00280A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurNum
		{
			get
			{
				return this.curNum_;
			}
			set
			{
				this.curNum_ = value;
			}
		}

		// Token: 0x06011227 RID: 70183 RVA: 0x00282890 File Offset: 0x00280A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardSkillUnlockInfo);
		}

		// Token: 0x06011228 RID: 70184 RVA: 0x002828A0 File Offset: 0x00280AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardSkillUnlockInfo other)
		{
			return other != null && (other == this || (this.CardId == other.CardId && this.Unlock == other.Unlock && this.TargetNum == other.TargetNum && this.CurNum == other.CurNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011229 RID: 70185 RVA: 0x0028290C File Offset: 0x00280B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CardId != 0)
			{
				num ^= this.CardId.GetHashCode();
			}
			if (this.Unlock)
			{
				num ^= this.Unlock.GetHashCode();
			}
			if (this.TargetNum != 0)
			{
				num ^= this.TargetNum.GetHashCode();
			}
			if (this.CurNum != 0)
			{
				num ^= this.CurNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601122A RID: 70186 RVA: 0x00282996 File Offset: 0x00280B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601122B RID: 70187 RVA: 0x002829A3 File Offset: 0x00280BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601122C RID: 70188 RVA: 0x002829AC File Offset: 0x00280BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CardId);
			}
			if (this.Unlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Unlock);
			}
			if (this.TargetNum != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TargetNum);
			}
			if (this.CurNum != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CurNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601122D RID: 70189 RVA: 0x00282A3C File Offset: 0x00280C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardId);
			}
			if (this.Unlock)
			{
				num += 2;
			}
			if (this.TargetNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetNum);
			}
			if (this.CurNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601122E RID: 70190 RVA: 0x00282AB8 File Offset: 0x00280CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardSkillUnlockInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CardId != 0)
			{
				this.CardId = other.CardId;
			}
			if (other.Unlock)
			{
				this.Unlock = other.Unlock;
			}
			if (other.TargetNum != 0)
			{
				this.TargetNum = other.TargetNum;
			}
			if (other.CurNum != 0)
			{
				this.CurNum = other.CurNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601122F RID: 70191 RVA: 0x00282B30 File Offset: 0x00280D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011230 RID: 70192 RVA: 0x00282B3C File Offset: 0x00280D3C
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
						this.CardId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Unlock = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.TargetNum = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.CurNum = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006CD5 RID: 27861
		private static readonly MessageParser<PhantomBattleCardSkillUnlockInfo> _parser = new MessageParser<PhantomBattleCardSkillUnlockInfo>(() => new PhantomBattleCardSkillUnlockInfo());

		// Token: 0x04006CD6 RID: 27862
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CD7 RID: 27863
		public const int CardIdFieldNumber = 1;

		// Token: 0x04006CD8 RID: 27864
		private int cardId_;

		// Token: 0x04006CD9 RID: 27865
		public const int UnlockFieldNumber = 2;

		// Token: 0x04006CDA RID: 27866
		private bool unlock_;

		// Token: 0x04006CDB RID: 27867
		public const int TargetNumFieldNumber = 3;

		// Token: 0x04006CDC RID: 27868
		private int targetNum_;

		// Token: 0x04006CDD RID: 27869
		public const int CurNumFieldNumber = 4;

		// Token: 0x04006CDE RID: 27870
		private int curNum_;
	}
}
