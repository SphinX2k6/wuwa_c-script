using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C47 RID: 3143
	public sealed class PhantomBattleCardRewardInfo : IMessage<PhantomBattleCardRewardInfo>, IMessage, IEquatable<PhantomBattleCardRewardInfo>, IDeepCloneable<PhantomBattleCardRewardInfo>, IBufferMessage
	{
		// Token: 0x0601110C RID: 69900 RVA: 0x00280308 File Offset: 0x0027E508
		[NullableContext(1)]
		public static PhantomBattleCardRewardInfo Create()
		{
			return new PhantomBattleCardRewardInfo();
		}

		// Token: 0x17003867 RID: 14439
		// (get) Token: 0x0601110D RID: 69901 RVA: 0x0028030F File Offset: 0x0027E50F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleCardRewardInfo> Parser
		{
			get
			{
				return PhantomBattleCardRewardInfo._parser;
			}
		}

		// Token: 0x17003868 RID: 14440
		// (get) Token: 0x0601110E RID: 69902 RVA: 0x00280316 File Offset: 0x0027E516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003869 RID: 14441
		// (get) Token: 0x0601110F RID: 69903 RVA: 0x00280319 File Offset: 0x0027E519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardRewardInfo.Descriptor;
			}
		}

		// Token: 0x06011110 RID: 69904 RVA: 0x00280320 File Offset: 0x0027E520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRewardInfo()
		{
		}

		// Token: 0x06011111 RID: 69905 RVA: 0x00280328 File Offset: 0x0027E528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRewardInfo(PhantomBattleCardRewardInfo other) : this()
		{
			this.phantomBattleCardRewardId_ = other.phantomBattleCardRewardId_;
			this.unlockNum_ = other.unlockNum_;
			this.isRewarded_ = other.isRewarded_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011112 RID: 69906 RVA: 0x00280365 File Offset: 0x0027E565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRewardInfo Clone()
		{
			return new PhantomBattleCardRewardInfo(this);
		}

		// Token: 0x1700386A RID: 14442
		// (get) Token: 0x06011113 RID: 69907 RVA: 0x0028036D File Offset: 0x0027E56D
		// (set) Token: 0x06011114 RID: 69908 RVA: 0x00280375 File Offset: 0x0027E575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomBattleCardRewardId
		{
			get
			{
				return this.phantomBattleCardRewardId_;
			}
			set
			{
				this.phantomBattleCardRewardId_ = value;
			}
		}

		// Token: 0x1700386B RID: 14443
		// (get) Token: 0x06011115 RID: 69909 RVA: 0x0028037E File Offset: 0x0027E57E
		// (set) Token: 0x06011116 RID: 69910 RVA: 0x00280386 File Offset: 0x0027E586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnlockNum
		{
			get
			{
				return this.unlockNum_;
			}
			set
			{
				this.unlockNum_ = value;
			}
		}

		// Token: 0x1700386C RID: 14444
		// (get) Token: 0x06011117 RID: 69911 RVA: 0x0028038F File Offset: 0x0027E58F
		// (set) Token: 0x06011118 RID: 69912 RVA: 0x00280397 File Offset: 0x0027E597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRewarded
		{
			get
			{
				return this.isRewarded_;
			}
			set
			{
				this.isRewarded_ = value;
			}
		}

		// Token: 0x06011119 RID: 69913 RVA: 0x002803A0 File Offset: 0x0027E5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardRewardInfo);
		}

		// Token: 0x0601111A RID: 69914 RVA: 0x002803B0 File Offset: 0x0027E5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardRewardInfo other)
		{
			return other != null && (other == this || (this.PhantomBattleCardRewardId == other.PhantomBattleCardRewardId && this.UnlockNum == other.UnlockNum && this.IsRewarded == other.IsRewarded && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601111B RID: 69915 RVA: 0x0028040C File Offset: 0x0027E60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PhantomBattleCardRewardId != 0)
			{
				num ^= this.PhantomBattleCardRewardId.GetHashCode();
			}
			if (this.UnlockNum != 0)
			{
				num ^= this.UnlockNum.GetHashCode();
			}
			if (this.IsRewarded)
			{
				num ^= this.IsRewarded.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601111C RID: 69916 RVA: 0x0028047D File Offset: 0x0027E67D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601111D RID: 69917 RVA: 0x0028048A File Offset: 0x0027E68A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601111E RID: 69918 RVA: 0x00280494 File Offset: 0x0027E694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PhantomBattleCardRewardId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PhantomBattleCardRewardId);
			}
			if (this.UnlockNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.UnlockNum);
			}
			if (this.IsRewarded)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsRewarded);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601111F RID: 69919 RVA: 0x00280508 File Offset: 0x0027E708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PhantomBattleCardRewardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomBattleCardRewardId);
			}
			if (this.UnlockNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnlockNum);
			}
			if (this.IsRewarded)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011120 RID: 69920 RVA: 0x0028056C File Offset: 0x0027E76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardRewardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PhantomBattleCardRewardId != 0)
			{
				this.PhantomBattleCardRewardId = other.PhantomBattleCardRewardId;
			}
			if (other.UnlockNum != 0)
			{
				this.UnlockNum = other.UnlockNum;
			}
			if (other.IsRewarded)
			{
				this.IsRewarded = other.IsRewarded;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011121 RID: 69921 RVA: 0x002805D0 File Offset: 0x0027E7D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011122 RID: 69922 RVA: 0x002805DC File Offset: 0x0027E7DC
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsRewarded = input.ReadBool();
						}
					}
					else
					{
						this.UnlockNum = input.ReadInt32();
					}
				}
				else
				{
					this.PhantomBattleCardRewardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006C85 RID: 27781
		private static readonly MessageParser<PhantomBattleCardRewardInfo> _parser = new MessageParser<PhantomBattleCardRewardInfo>(() => new PhantomBattleCardRewardInfo());

		// Token: 0x04006C86 RID: 27782
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C87 RID: 27783
		public const int PhantomBattleCardRewardIdFieldNumber = 1;

		// Token: 0x04006C88 RID: 27784
		private int phantomBattleCardRewardId_;

		// Token: 0x04006C89 RID: 27785
		public const int UnlockNumFieldNumber = 2;

		// Token: 0x04006C8A RID: 27786
		private int unlockNum_;

		// Token: 0x04006C8B RID: 27787
		public const int IsRewardedFieldNumber = 3;

		// Token: 0x04006C8C RID: 27788
		private bool isRewarded_;
	}
}
