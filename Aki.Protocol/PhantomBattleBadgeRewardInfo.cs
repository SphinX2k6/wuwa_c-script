using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C21 RID: 3105
	public sealed class PhantomBattleBadgeRewardInfo : IMessage<PhantomBattleBadgeRewardInfo>, IMessage, IEquatable<PhantomBattleBadgeRewardInfo>, IDeepCloneable<PhantomBattleBadgeRewardInfo>, IBufferMessage
	{
		// Token: 0x06010DE0 RID: 69088 RVA: 0x00278C59 File Offset: 0x00276E59
		[NullableContext(1)]
		public static PhantomBattleBadgeRewardInfo Create()
		{
			return new PhantomBattleBadgeRewardInfo();
		}

		// Token: 0x170037B1 RID: 14257
		// (get) Token: 0x06010DE1 RID: 69089 RVA: 0x00278C60 File Offset: 0x00276E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleBadgeRewardInfo> Parser
		{
			get
			{
				return PhantomBattleBadgeRewardInfo._parser;
			}
		}

		// Token: 0x170037B2 RID: 14258
		// (get) Token: 0x06010DE2 RID: 69090 RVA: 0x00278C67 File Offset: 0x00276E67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037B3 RID: 14259
		// (get) Token: 0x06010DE3 RID: 69091 RVA: 0x00278C6A File Offset: 0x00276E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBadgeRewardInfo.Descriptor;
			}
		}

		// Token: 0x06010DE4 RID: 69092 RVA: 0x00278C71 File Offset: 0x00276E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeRewardInfo()
		{
		}

		// Token: 0x06010DE5 RID: 69093 RVA: 0x00278C79 File Offset: 0x00276E79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeRewardInfo(PhantomBattleBadgeRewardInfo other) : this()
		{
			this.phantomBattleBadgeRewardId_ = other.phantomBattleBadgeRewardId_;
			this.unlockNum_ = other.unlockNum_;
			this.isRewarded_ = other.isRewarded_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010DE6 RID: 69094 RVA: 0x00278CB6 File Offset: 0x00276EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeRewardInfo Clone()
		{
			return new PhantomBattleBadgeRewardInfo(this);
		}

		// Token: 0x170037B4 RID: 14260
		// (get) Token: 0x06010DE7 RID: 69095 RVA: 0x00278CBE File Offset: 0x00276EBE
		// (set) Token: 0x06010DE8 RID: 69096 RVA: 0x00278CC6 File Offset: 0x00276EC6
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

		// Token: 0x170037B5 RID: 14261
		// (get) Token: 0x06010DE9 RID: 69097 RVA: 0x00278CCF File Offset: 0x00276ECF
		// (set) Token: 0x06010DEA RID: 69098 RVA: 0x00278CD7 File Offset: 0x00276ED7
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

		// Token: 0x170037B6 RID: 14262
		// (get) Token: 0x06010DEB RID: 69099 RVA: 0x00278CE0 File Offset: 0x00276EE0
		// (set) Token: 0x06010DEC RID: 69100 RVA: 0x00278CE8 File Offset: 0x00276EE8
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

		// Token: 0x06010DED RID: 69101 RVA: 0x00278CF1 File Offset: 0x00276EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBadgeRewardInfo);
		}

		// Token: 0x06010DEE RID: 69102 RVA: 0x00278D00 File Offset: 0x00276F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBadgeRewardInfo other)
		{
			return other != null && (other == this || (this.PhantomBattleBadgeRewardId == other.PhantomBattleBadgeRewardId && this.UnlockNum == other.UnlockNum && this.IsRewarded == other.IsRewarded && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010DEF RID: 69103 RVA: 0x00278D5C File Offset: 0x00276F5C
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

		// Token: 0x06010DF0 RID: 69104 RVA: 0x00278DCD File Offset: 0x00276FCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010DF1 RID: 69105 RVA: 0x00278DDA File Offset: 0x00276FDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010DF2 RID: 69106 RVA: 0x00278DE4 File Offset: 0x00276FE4
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

		// Token: 0x06010DF3 RID: 69107 RVA: 0x00278E58 File Offset: 0x00277058
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

		// Token: 0x06010DF4 RID: 69108 RVA: 0x00278EBC File Offset: 0x002770BC
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

		// Token: 0x06010DF5 RID: 69109 RVA: 0x00278F20 File Offset: 0x00277120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010DF6 RID: 69110 RVA: 0x00278F2C File Offset: 0x0027712C
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

		// Token: 0x04006B77 RID: 27511
		private static readonly MessageParser<PhantomBattleBadgeRewardInfo> _parser = new MessageParser<PhantomBattleBadgeRewardInfo>(() => new PhantomBattleBadgeRewardInfo());

		// Token: 0x04006B78 RID: 27512
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B79 RID: 27513
		public const int PhantomBattleBadgeRewardIdFieldNumber = 1;

		// Token: 0x04006B7A RID: 27514
		private int phantomBattleBadgeRewardId_;

		// Token: 0x04006B7B RID: 27515
		public const int UnlockNumFieldNumber = 2;

		// Token: 0x04006B7C RID: 27516
		private int unlockNum_;

		// Token: 0x04006B7D RID: 27517
		public const int IsRewardedFieldNumber = 3;

		// Token: 0x04006B7E RID: 27518
		private bool isRewarded_;
	}
}
