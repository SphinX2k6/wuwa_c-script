using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C64 RID: 3172
	public sealed class PhantomBattleCardSkillUnlockInfo : IMessage<PhantomBattleCardSkillUnlockInfo>, IMessage, IEquatable<PhantomBattleCardSkillUnlockInfo>, IDeepCloneable<PhantomBattleCardSkillUnlockInfo>, IBufferMessage
	{
		// Token: 0x06011318 RID: 70424 RVA: 0x0028453F File Offset: 0x0028273F
		[NullableContext(1)]
		public static PhantomBattleCardSkillUnlockInfo Create()
		{
			return new PhantomBattleCardSkillUnlockInfo();
		}

		// Token: 0x170038D6 RID: 14550
		// (get) Token: 0x06011319 RID: 70425 RVA: 0x00284546 File Offset: 0x00282746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleCardSkillUnlockInfo> Parser
		{
			get
			{
				return PhantomBattleCardSkillUnlockInfo._parser;
			}
		}

		// Token: 0x170038D7 RID: 14551
		// (get) Token: 0x0601131A RID: 70426 RVA: 0x0028454D File Offset: 0x0028274D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038D8 RID: 14552
		// (get) Token: 0x0601131B RID: 70427 RVA: 0x00284550 File Offset: 0x00282750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardSkillUnlockInfo.Descriptor;
			}
		}

		// Token: 0x0601131C RID: 70428 RVA: 0x00284557 File Offset: 0x00282757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSkillUnlockInfo()
		{
		}

		// Token: 0x0601131D RID: 70429 RVA: 0x00284560 File Offset: 0x00282760
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

		// Token: 0x0601131E RID: 70430 RVA: 0x002845B4 File Offset: 0x002827B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSkillUnlockInfo Clone()
		{
			return new PhantomBattleCardSkillUnlockInfo(this);
		}

		// Token: 0x170038D9 RID: 14553
		// (get) Token: 0x0601131F RID: 70431 RVA: 0x002845BC File Offset: 0x002827BC
		// (set) Token: 0x06011320 RID: 70432 RVA: 0x002845C4 File Offset: 0x002827C4
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

		// Token: 0x170038DA RID: 14554
		// (get) Token: 0x06011321 RID: 70433 RVA: 0x002845CD File Offset: 0x002827CD
		// (set) Token: 0x06011322 RID: 70434 RVA: 0x002845D5 File Offset: 0x002827D5
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

		// Token: 0x170038DB RID: 14555
		// (get) Token: 0x06011323 RID: 70435 RVA: 0x002845DE File Offset: 0x002827DE
		// (set) Token: 0x06011324 RID: 70436 RVA: 0x002845E6 File Offset: 0x002827E6
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

		// Token: 0x170038DC RID: 14556
		// (get) Token: 0x06011325 RID: 70437 RVA: 0x002845EF File Offset: 0x002827EF
		// (set) Token: 0x06011326 RID: 70438 RVA: 0x002845F7 File Offset: 0x002827F7
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

		// Token: 0x06011327 RID: 70439 RVA: 0x00284600 File Offset: 0x00282800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardSkillUnlockInfo);
		}

		// Token: 0x06011328 RID: 70440 RVA: 0x00284610 File Offset: 0x00282810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardSkillUnlockInfo other)
		{
			return other != null && (other == this || (this.CardId == other.CardId && this.Unlock == other.Unlock && this.TargetNum == other.TargetNum && this.CurNum == other.CurNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011329 RID: 70441 RVA: 0x0028467C File Offset: 0x0028287C
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

		// Token: 0x0601132A RID: 70442 RVA: 0x00284706 File Offset: 0x00282906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601132B RID: 70443 RVA: 0x00284713 File Offset: 0x00282913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601132C RID: 70444 RVA: 0x0028471C File Offset: 0x0028291C
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

		// Token: 0x0601132D RID: 70445 RVA: 0x002847AC File Offset: 0x002829AC
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

		// Token: 0x0601132E RID: 70446 RVA: 0x00284828 File Offset: 0x00282A28
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

		// Token: 0x0601132F RID: 70447 RVA: 0x002848A0 File Offset: 0x00282AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011330 RID: 70448 RVA: 0x002848AC File Offset: 0x00282AAC
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

		// Token: 0x04006CC1 RID: 27841
		private static readonly MessageParser<PhantomBattleCardSkillUnlockInfo> _parser = new MessageParser<PhantomBattleCardSkillUnlockInfo>(() => new PhantomBattleCardSkillUnlockInfo());

		// Token: 0x04006CC2 RID: 27842
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CC3 RID: 27843
		public const int CardIdFieldNumber = 1;

		// Token: 0x04006CC4 RID: 27844
		private int cardId_;

		// Token: 0x04006CC5 RID: 27845
		public const int UnlockFieldNumber = 2;

		// Token: 0x04006CC6 RID: 27846
		private bool unlock_;

		// Token: 0x04006CC7 RID: 27847
		public const int TargetNumFieldNumber = 3;

		// Token: 0x04006CC8 RID: 27848
		private int targetNum_;

		// Token: 0x04006CC9 RID: 27849
		public const int CurNumFieldNumber = 4;

		// Token: 0x04006CCA RID: 27850
		private int curNum_;
	}
}
