using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C31 RID: 3121
	public sealed class PhantomBattleBadgeRewardInfo : IMessage<PhantomBattleBadgeRewardInfo>, IMessage, IEquatable<PhantomBattleBadgeRewardInfo>, IDeepCloneable<PhantomBattleBadgeRewardInfo>, IBufferMessage
	{
		// Token: 0x06010EE0 RID: 69344 RVA: 0x0027A9BD File Offset: 0x00278BBD
		[NullableContext(1)]
		public static PhantomBattleBadgeRewardInfo Create()
		{
			return new PhantomBattleBadgeRewardInfo();
		}

		// Token: 0x170037E8 RID: 14312
		// (get) Token: 0x06010EE1 RID: 69345 RVA: 0x0027A9C4 File Offset: 0x00278BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleBadgeRewardInfo> Parser
		{
			get
			{
				return PhantomBattleBadgeRewardInfo._parser;
			}
		}

		// Token: 0x170037E9 RID: 14313
		// (get) Token: 0x06010EE2 RID: 69346 RVA: 0x0027A9CB File Offset: 0x00278BCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037EA RID: 14314
		// (get) Token: 0x06010EE3 RID: 69347 RVA: 0x0027A9CE File Offset: 0x00278BCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBadgeRewardInfo.Descriptor;
			}
		}

		// Token: 0x06010EE4 RID: 69348 RVA: 0x0027A9D5 File Offset: 0x00278BD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeRewardInfo()
		{
		}

		// Token: 0x06010EE5 RID: 69349 RVA: 0x0027A9DD File Offset: 0x00278BDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeRewardInfo(PhantomBattleBadgeRewardInfo other) : this()
		{
			this.phantomBattleBadgeRewardId_ = other.phantomBattleBadgeRewardId_;
			this.unlockNum_ = other.unlockNum_;
			this.isRewarded_ = other.isRewarded_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010EE6 RID: 69350 RVA: 0x0027AA1A File Offset: 0x00278C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeRewardInfo Clone()
		{
			return new PhantomBattleBadgeRewardInfo(this);
		}

		// Token: 0x170037EB RID: 14315
		// (get) Token: 0x06010EE7 RID: 69351 RVA: 0x0027AA22 File Offset: 0x00278C22
		// (set) Token: 0x06010EE8 RID: 69352 RVA: 0x0027AA2A File Offset: 0x00278C2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomBattleBadgeRewardId
		{
			get
			{
				return this.phantomBattleBadgeRewardId_;
			}
			set
			{
				this.phantomBattleBadgeRewardId_ = value;
			}
		}

		// Token: 0x170037EC RID: 14316
		// (get) Token: 0x06010EE9 RID: 69353 RVA: 0x0027AA33 File Offset: 0x00278C33
		// (set) Token: 0x06010EEA RID: 69354 RVA: 0x0027AA3B File Offset: 0x00278C3B
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

		// Token: 0x170037ED RID: 14317
		// (get) Token: 0x06010EEB RID: 69355 RVA: 0x0027AA44 File Offset: 0x00278C44
		// (set) Token: 0x06010EEC RID: 69356 RVA: 0x0027AA4C File Offset: 0x00278C4C
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

		// Token: 0x06010EED RID: 69357 RVA: 0x0027AA55 File Offset: 0x00278C55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBadgeRewardInfo);
		}

		// Token: 0x06010EEE RID: 69358 RVA: 0x0027AA64 File Offset: 0x00278C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBadgeRewardInfo other)
		{
			return other != null && (other == this || (this.PhantomBattleBadgeRewardId == other.PhantomBattleBadgeRewardId && this.UnlockNum == other.UnlockNum && this.IsRewarded == other.IsRewarded && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010EEF RID: 69359 RVA: 0x0027AAC0 File Offset: 0x00278CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PhantomBattleBadgeRewardId != 0)
			{
				num ^= this.PhantomBattleBadgeRewardId.GetHashCode();
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

		// Token: 0x06010EF0 RID: 69360 RVA: 0x0027AB31 File Offset: 0x00278D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010EF1 RID: 69361 RVA: 0x0027AB3E File Offset: 0x00278D3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010EF2 RID: 69362 RVA: 0x0027AB48 File Offset: 0x00278D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PhantomBattleBadgeRewardId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PhantomBattleBadgeRewardId);
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

		// Token: 0x06010EF3 RID: 69363 RVA: 0x0027ABBC File Offset: 0x00278DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PhantomBattleBadgeRewardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomBattleBadgeRewardId);
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

		// Token: 0x06010EF4 RID: 69364 RVA: 0x0027AC20 File Offset: 0x00278E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBadgeRewardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PhantomBattleBadgeRewardId != 0)
			{
				this.PhantomBattleBadgeRewardId = other.PhantomBattleBadgeRewardId;
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

		// Token: 0x06010EF5 RID: 69365 RVA: 0x0027AC84 File Offset: 0x00278E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010EF6 RID: 69366 RVA: 0x0027AC90 File Offset: 0x00278E90
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
					this.PhantomBattleBadgeRewardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006B63 RID: 27491
		private static readonly MessageParser<PhantomBattleBadgeRewardInfo> _parser = new MessageParser<PhantomBattleBadgeRewardInfo>(() => new PhantomBattleBadgeRewardInfo());

		// Token: 0x04006B64 RID: 27492
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B65 RID: 27493
		public const int PhantomBattleBadgeRewardIdFieldNumber = 1;

		// Token: 0x04006B66 RID: 27494
		private int phantomBattleBadgeRewardId_;

		// Token: 0x04006B67 RID: 27495
		public const int UnlockNumFieldNumber = 2;

		// Token: 0x04006B68 RID: 27496
		private int unlockNum_;

		// Token: 0x04006B69 RID: 27497
		public const int IsRewardedFieldNumber = 3;

		// Token: 0x04006B6A RID: 27498
		private bool isRewarded_;
	}
}
