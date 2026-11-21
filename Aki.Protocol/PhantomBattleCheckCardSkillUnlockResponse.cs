using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C5E RID: 3166
	[NetMessage(EMessageId.PhantomBattleCheckCardSkillUnlockResponse)]
	public sealed class PhantomBattleCheckCardSkillUnlockResponse : IMessage<PhantomBattleCheckCardSkillUnlockResponse>, IMessage, IEquatable<PhantomBattleCheckCardSkillUnlockResponse>, IDeepCloneable<PhantomBattleCheckCardSkillUnlockResponse>, IBufferMessage
	{
		// Token: 0x06011302 RID: 70402 RVA: 0x00284C31 File Offset: 0x00282E31
		[NullableContext(1)]
		public static PhantomBattleCheckCardSkillUnlockResponse Create()
		{
			return new PhantomBattleCheckCardSkillUnlockResponse();
		}

		// Token: 0x170038D9 RID: 14553
		// (get) Token: 0x06011303 RID: 70403 RVA: 0x00284C38 File Offset: 0x00282E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038DA RID: 14554
		// (get) Token: 0x06011304 RID: 70404 RVA: 0x00284C3B File Offset: 0x00282E3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCheckCardSkillUnlockResponse.Descriptor;
			}
		}

		// Token: 0x06011305 RID: 70405 RVA: 0x00284C42 File Offset: 0x00282E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCheckCardSkillUnlockResponse()
		{
		}

		// Token: 0x06011306 RID: 70406 RVA: 0x00284C58 File Offset: 0x00282E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCheckCardSkillUnlockResponse(PhantomBattleCheckCardSkillUnlockResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.cardConfig_ = other.cardConfig_.Clone();
			this.isUnlock_ = other.isUnlock_;
			this.curNum_ = other.curNum_;
			this.targetNum_ = other.targetNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011307 RID: 70407 RVA: 0x00284CBD File Offset: 0x00282EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCheckCardSkillUnlockResponse Clone()
		{
			return new PhantomBattleCheckCardSkillUnlockResponse(this);
		}

		// Token: 0x170038DB RID: 14555
		// (get) Token: 0x06011308 RID: 70408 RVA: 0x00284CC5 File Offset: 0x00282EC5
		// (set) Token: 0x06011309 RID: 70409 RVA: 0x00284CCD File Offset: 0x00282ECD
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

		// Token: 0x170038DC RID: 14556
		// (get) Token: 0x0601130A RID: 70410 RVA: 0x00284CD6 File Offset: 0x00282ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CardConfig
		{
			get
			{
				return this.cardConfig_;
			}
		}

		// Token: 0x170038DD RID: 14557
		// (get) Token: 0x0601130B RID: 70411 RVA: 0x00284CDE File Offset: 0x00282EDE
		// (set) Token: 0x0601130C RID: 70412 RVA: 0x00284CE6 File Offset: 0x00282EE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlock
		{
			get
			{
				return this.isUnlock_;
			}
			set
			{
				this.isUnlock_ = value;
			}
		}

		// Token: 0x170038DE RID: 14558
		// (get) Token: 0x0601130D RID: 70413 RVA: 0x00284CEF File Offset: 0x00282EEF
		// (set) Token: 0x0601130E RID: 70414 RVA: 0x00284CF7 File Offset: 0x00282EF7
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

		// Token: 0x170038DF RID: 14559
		// (get) Token: 0x0601130F RID: 70415 RVA: 0x00284D00 File Offset: 0x00282F00
		// (set) Token: 0x06011310 RID: 70416 RVA: 0x00284D08 File Offset: 0x00282F08
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

		// Token: 0x06011311 RID: 70417 RVA: 0x00284D11 File Offset: 0x00282F11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCheckCardSkillUnlockResponse);
		}

		// Token: 0x06011312 RID: 70418 RVA: 0x00284D20 File Offset: 0x00282F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCheckCardSkillUnlockResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.cardConfig_.Equals(other.cardConfig_) && this.IsUnlock == other.IsUnlock && this.CurNum == other.CurNum && this.TargetNum == other.TargetNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011313 RID: 70419 RVA: 0x00284DA0 File Offset: 0x00282FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.cardConfig_.GetHashCode();
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this.CurNum != 0)
			{
				num ^= this.CurNum.GetHashCode();
			}
			if (this.TargetNum != 0)
			{
				num ^= this.TargetNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011314 RID: 70420 RVA: 0x00284E3E File Offset: 0x0028303E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011315 RID: 70421 RVA: 0x00284E4B File Offset: 0x0028304B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011316 RID: 70422 RVA: 0x00284E54 File Offset: 0x00283054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TargetNum);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsUnlock);
			}
			this.cardConfig_.WriteTo(ref output, PhantomBattleCheckCardSkillUnlockResponse._repeated_cardConfig_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.CurNum != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.CurNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011317 RID: 70423 RVA: 0x00284EF8 File Offset: 0x002830F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.cardConfig_.CalculateSize(PhantomBattleCheckCardSkillUnlockResponse._repeated_cardConfig_codec);
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this.CurNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurNum);
			}
			if (this.TargetNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011318 RID: 70424 RVA: 0x00284F88 File Offset: 0x00283188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCheckCardSkillUnlockResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.cardConfig_.Add(other.cardConfig_);
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			if (other.CurNum != 0)
			{
				this.CurNum = other.CurNum;
			}
			if (other.TargetNum != 0)
			{
				this.TargetNum = other.TargetNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011319 RID: 70425 RVA: 0x00285011 File Offset: 0x00283211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601131A RID: 70426 RVA: 0x0028501C File Offset: 0x0028321C
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
				if (num <= 64U)
				{
					if (num == 16U)
					{
						this.TargetNum = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.IsUnlock = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						goto IL_61;
					}
				}
				else
				{
					if (num == 66U)
					{
						goto IL_61;
					}
					if (num == 104U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 120U)
					{
						this.CurNum = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_61:
				this.cardConfig_.AddEntriesFrom(ref input, PhantomBattleCheckCardSkillUnlockResponse._repeated_cardConfig_codec);
			}
		}

		// Token: 0x04006D30 RID: 27952
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D31 RID: 27953
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04006D32 RID: 27954
		private ErrorCode errorCode_;

		// Token: 0x04006D33 RID: 27955
		public const int CardConfigFieldNumber = 8;

		// Token: 0x04006D34 RID: 27956
		private static readonly FieldCodec<int> _repeated_cardConfig_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04006D35 RID: 27957
		private readonly RepeatedField<int> cardConfig_ = new RepeatedField<int>();

		// Token: 0x04006D36 RID: 27958
		public const int IsUnlockFieldNumber = 6;

		// Token: 0x04006D37 RID: 27959
		private bool isUnlock_;

		// Token: 0x04006D38 RID: 27960
		public const int CurNumFieldNumber = 15;

		// Token: 0x04006D39 RID: 27961
		private int curNum_;

		// Token: 0x04006D3A RID: 27962
		public const int TargetNumFieldNumber = 2;

		// Token: 0x04006D3B RID: 27963
		private int targetNum_;
	}
}
