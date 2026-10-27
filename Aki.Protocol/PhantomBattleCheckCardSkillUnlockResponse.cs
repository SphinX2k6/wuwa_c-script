using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C6E RID: 3182
	[NetMessage(EMessageId.PhantomBattleCheckCardSkillUnlockResponse)]
	public sealed class PhantomBattleCheckCardSkillUnlockResponse : IMessage<PhantomBattleCheckCardSkillUnlockResponse>, IMessage, IEquatable<PhantomBattleCheckCardSkillUnlockResponse>, IDeepCloneable<PhantomBattleCheckCardSkillUnlockResponse>, IBufferMessage
	{
		// Token: 0x06011402 RID: 70658 RVA: 0x002869A1 File Offset: 0x00284BA1
		[NullableContext(1)]
		public static PhantomBattleCheckCardSkillUnlockResponse Create()
		{
			return new PhantomBattleCheckCardSkillUnlockResponse();
		}

		// Token: 0x17003910 RID: 14608
		// (get) Token: 0x06011403 RID: 70659 RVA: 0x002869A8 File Offset: 0x00284BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003911 RID: 14609
		// (get) Token: 0x06011404 RID: 70660 RVA: 0x002869AB File Offset: 0x00284BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCheckCardSkillUnlockResponse.Descriptor;
			}
		}

		// Token: 0x06011405 RID: 70661 RVA: 0x002869B2 File Offset: 0x00284BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCheckCardSkillUnlockResponse()
		{
		}

		// Token: 0x06011406 RID: 70662 RVA: 0x002869C8 File Offset: 0x00284BC8
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

		// Token: 0x06011407 RID: 70663 RVA: 0x00286A2D File Offset: 0x00284C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCheckCardSkillUnlockResponse Clone()
		{
			return new PhantomBattleCheckCardSkillUnlockResponse(this);
		}

		// Token: 0x17003912 RID: 14610
		// (get) Token: 0x06011408 RID: 70664 RVA: 0x00286A35 File Offset: 0x00284C35
		// (set) Token: 0x06011409 RID: 70665 RVA: 0x00286A3D File Offset: 0x00284C3D
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

		// Token: 0x17003913 RID: 14611
		// (get) Token: 0x0601140A RID: 70666 RVA: 0x00286A46 File Offset: 0x00284C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CardConfig
		{
			get
			{
				return this.cardConfig_;
			}
		}

		// Token: 0x17003914 RID: 14612
		// (get) Token: 0x0601140B RID: 70667 RVA: 0x00286A4E File Offset: 0x00284C4E
		// (set) Token: 0x0601140C RID: 70668 RVA: 0x00286A56 File Offset: 0x00284C56
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

		// Token: 0x17003915 RID: 14613
		// (get) Token: 0x0601140D RID: 70669 RVA: 0x00286A5F File Offset: 0x00284C5F
		// (set) Token: 0x0601140E RID: 70670 RVA: 0x00286A67 File Offset: 0x00284C67
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

		// Token: 0x17003916 RID: 14614
		// (get) Token: 0x0601140F RID: 70671 RVA: 0x00286A70 File Offset: 0x00284C70
		// (set) Token: 0x06011410 RID: 70672 RVA: 0x00286A78 File Offset: 0x00284C78
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

		// Token: 0x06011411 RID: 70673 RVA: 0x00286A81 File Offset: 0x00284C81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCheckCardSkillUnlockResponse);
		}

		// Token: 0x06011412 RID: 70674 RVA: 0x00286A90 File Offset: 0x00284C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCheckCardSkillUnlockResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.cardConfig_.Equals(other.cardConfig_) && this.IsUnlock == other.IsUnlock && this.CurNum == other.CurNum && this.TargetNum == other.TargetNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011413 RID: 70675 RVA: 0x00286B10 File Offset: 0x00284D10
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

		// Token: 0x06011414 RID: 70676 RVA: 0x00286BAE File Offset: 0x00284DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011415 RID: 70677 RVA: 0x00286BBB File Offset: 0x00284DBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011416 RID: 70678 RVA: 0x00286BC4 File Offset: 0x00284DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.cardConfig_.WriteTo(ref output, PhantomBattleCheckCardSkillUnlockResponse._repeated_cardConfig_codec);
			if (this.IsUnlock)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsUnlock);
			}
			if (this.CurNum != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CurNum);
			}
			if (this.TargetNum != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.TargetNum);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011417 RID: 70679 RVA: 0x00286C68 File Offset: 0x00284E68
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

		// Token: 0x06011418 RID: 70680 RVA: 0x00286CF8 File Offset: 0x00284EF8
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

		// Token: 0x06011419 RID: 70681 RVA: 0x00286D81 File Offset: 0x00284F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601141A RID: 70682 RVA: 0x00286D8C File Offset: 0x00284F8C
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
				if (num <= 56U)
				{
					if (num == 24U || num == 26U)
					{
						this.cardConfig_.AddEntriesFrom(ref input, PhantomBattleCheckCardSkillUnlockResponse._repeated_cardConfig_codec);
						continue;
					}
					if (num == 56U)
					{
						this.IsUnlock = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.CurNum = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.TargetNum = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006D1C RID: 27932
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D1D RID: 27933
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04006D1E RID: 27934
		private ErrorCode errorCode_;

		// Token: 0x04006D1F RID: 27935
		public const int CardConfigFieldNumber = 3;

		// Token: 0x04006D20 RID: 27936
		private static readonly FieldCodec<int> _repeated_cardConfig_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04006D21 RID: 27937
		private readonly RepeatedField<int> cardConfig_ = new RepeatedField<int>();

		// Token: 0x04006D22 RID: 27938
		public const int IsUnlockFieldNumber = 7;

		// Token: 0x04006D23 RID: 27939
		private bool isUnlock_;

		// Token: 0x04006D24 RID: 27940
		public const int CurNumFieldNumber = 8;

		// Token: 0x04006D25 RID: 27941
		private int curNum_;

		// Token: 0x04006D26 RID: 27942
		public const int TargetNumFieldNumber = 12;

		// Token: 0x04006D27 RID: 27943
		private int targetNum_;
	}
}
