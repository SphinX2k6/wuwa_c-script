using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200090B RID: 2315
	public sealed class LevelPlayStateMsg : IMessage<LevelPlayStateMsg>, IMessage, IEquatable<LevelPlayStateMsg>, IDeepCloneable<LevelPlayStateMsg>, IBufferMessage
	{
		// Token: 0x0600CC5C RID: 52316 RVA: 0x001E1E58 File Offset: 0x001E0058
		[NullableContext(1)]
		public static LevelPlayStateMsg Create()
		{
			return new LevelPlayStateMsg();
		}

		// Token: 0x17002941 RID: 10561
		// (get) Token: 0x0600CC5D RID: 52317 RVA: 0x001E1E5F File Offset: 0x001E005F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LevelPlayStateMsg> Parser
		{
			get
			{
				return LevelPlayStateMsg._parser;
			}
		}

		// Token: 0x17002942 RID: 10562
		// (get) Token: 0x0600CC5E RID: 52318 RVA: 0x001E1E66 File Offset: 0x001E0066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002943 RID: 10563
		// (get) Token: 0x0600CC5F RID: 52319 RVA: 0x001E1E69 File Offset: 0x001E0069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayStateMsg.Descriptor;
			}
		}

		// Token: 0x0600CC60 RID: 52320 RVA: 0x001E1E70 File Offset: 0x001E0070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateMsg()
		{
		}

		// Token: 0x0600CC61 RID: 52321 RVA: 0x001E1E84 File Offset: 0x001E0084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateMsg(LevelPlayStateMsg other) : this()
		{
			this.levelPlayEntityId_ = other.levelPlayEntityId_;
			this.exploratoryType_ = other.exploratoryType_;
			this.stateType_ = other.stateType_;
			this.completeNumber_ = other.completeNumber_;
			this.isHide_ = other.isHide_;
			this.hideGroupInfo_ = other.hideGroupInfo_;
			this.isUnlock_ = other.isUnlock_;
			this.levelPlayMarkUnlock_ = other.levelPlayMarkUnlock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CC62 RID: 52322 RVA: 0x001E1F08 File Offset: 0x001E0108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateMsg Clone()
		{
			return new LevelPlayStateMsg(this);
		}

		// Token: 0x17002944 RID: 10564
		// (get) Token: 0x0600CC63 RID: 52323 RVA: 0x001E1F10 File Offset: 0x001E0110
		// (set) Token: 0x0600CC64 RID: 52324 RVA: 0x001E1F18 File Offset: 0x001E0118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelPlayEntityId
		{
			get
			{
				return this.levelPlayEntityId_;
			}
			set
			{
				this.levelPlayEntityId_ = value;
			}
		}

		// Token: 0x17002945 RID: 10565
		// (get) Token: 0x0600CC65 RID: 52325 RVA: 0x001E1F21 File Offset: 0x001E0121
		// (set) Token: 0x0600CC66 RID: 52326 RVA: 0x001E1F29 File Offset: 0x001E0129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExploratoryType
		{
			get
			{
				return this.exploratoryType_;
			}
			set
			{
				this.exploratoryType_ = value;
			}
		}

		// Token: 0x17002946 RID: 10566
		// (get) Token: 0x0600CC67 RID: 52327 RVA: 0x001E1F32 File Offset: 0x001E0132
		// (set) Token: 0x0600CC68 RID: 52328 RVA: 0x001E1F3A File Offset: 0x001E013A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StateType
		{
			get
			{
				return this.stateType_;
			}
			set
			{
				this.stateType_ = value;
			}
		}

		// Token: 0x17002947 RID: 10567
		// (get) Token: 0x0600CC69 RID: 52329 RVA: 0x001E1F43 File Offset: 0x001E0143
		// (set) Token: 0x0600CC6A RID: 52330 RVA: 0x001E1F4B File Offset: 0x001E014B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CompleteNumber
		{
			get
			{
				return this.completeNumber_;
			}
			set
			{
				this.completeNumber_ = value;
			}
		}

		// Token: 0x17002948 RID: 10568
		// (get) Token: 0x0600CC6B RID: 52331 RVA: 0x001E1F54 File Offset: 0x001E0154
		// (set) Token: 0x0600CC6C RID: 52332 RVA: 0x001E1F5C File Offset: 0x001E015C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsHide
		{
			get
			{
				return this.isHide_;
			}
			set
			{
				this.isHide_ = value;
			}
		}

		// Token: 0x17002949 RID: 10569
		// (get) Token: 0x0600CC6D RID: 52333 RVA: 0x001E1F65 File Offset: 0x001E0165
		// (set) Token: 0x0600CC6E RID: 52334 RVA: 0x001E1F6D File Offset: 0x001E016D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string HideGroupInfo
		{
			get
			{
				return this.hideGroupInfo_;
			}
			set
			{
				this.hideGroupInfo_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700294A RID: 10570
		// (get) Token: 0x0600CC6F RID: 52335 RVA: 0x001E1F80 File Offset: 0x001E0180
		// (set) Token: 0x0600CC70 RID: 52336 RVA: 0x001E1F88 File Offset: 0x001E0188
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

		// Token: 0x1700294B RID: 10571
		// (get) Token: 0x0600CC71 RID: 52337 RVA: 0x001E1F91 File Offset: 0x001E0191
		// (set) Token: 0x0600CC72 RID: 52338 RVA: 0x001E1F99 File Offset: 0x001E0199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LevelPlayMarkUnlock
		{
			get
			{
				return this.levelPlayMarkUnlock_;
			}
			set
			{
				this.levelPlayMarkUnlock_ = value;
			}
		}

		// Token: 0x0600CC73 RID: 52339 RVA: 0x001E1FA2 File Offset: 0x001E01A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayStateMsg);
		}

		// Token: 0x0600CC74 RID: 52340 RVA: 0x001E1FB0 File Offset: 0x001E01B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayStateMsg other)
		{
			return other != null && (other == this || (this.LevelPlayEntityId == other.LevelPlayEntityId && this.ExploratoryType == other.ExploratoryType && this.StateType == other.StateType && this.CompleteNumber == other.CompleteNumber && this.IsHide == other.IsHide && !(this.HideGroupInfo != other.HideGroupInfo) && this.IsUnlock == other.IsUnlock && this.LevelPlayMarkUnlock == other.LevelPlayMarkUnlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CC75 RID: 52341 RVA: 0x001E2060 File Offset: 0x001E0260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelPlayEntityId != 0)
			{
				num ^= this.LevelPlayEntityId.GetHashCode();
			}
			if (this.ExploratoryType != 0)
			{
				num ^= this.ExploratoryType.GetHashCode();
			}
			if (this.StateType != 0)
			{
				num ^= this.StateType.GetHashCode();
			}
			if (this.CompleteNumber != 0)
			{
				num ^= this.CompleteNumber.GetHashCode();
			}
			if (this.IsHide)
			{
				num ^= this.IsHide.GetHashCode();
			}
			if (this.HideGroupInfo.Length != 0)
			{
				num ^= this.HideGroupInfo.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this.LevelPlayMarkUnlock)
			{
				num ^= this.LevelPlayMarkUnlock.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CC76 RID: 52342 RVA: 0x001E2150 File Offset: 0x001E0350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CC77 RID: 52343 RVA: 0x001E215D File Offset: 0x001E035D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CC78 RID: 52344 RVA: 0x001E2168 File Offset: 0x001E0368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelPlayEntityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelPlayEntityId);
			}
			if (this.ExploratoryType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ExploratoryType);
			}
			if (this.StateType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.StateType);
			}
			if (this.CompleteNumber != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CompleteNumber);
			}
			if (this.IsHide)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsHide);
			}
			if (this.HideGroupInfo.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.HideGroupInfo);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsUnlock);
			}
			if (this.LevelPlayMarkUnlock)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.LevelPlayMarkUnlock);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CC79 RID: 52345 RVA: 0x001E2270 File Offset: 0x001E0470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelPlayEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelPlayEntityId);
			}
			if (this.ExploratoryType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExploratoryType);
			}
			if (this.StateType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StateType);
			}
			if (this.CompleteNumber != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CompleteNumber);
			}
			if (this.IsHide)
			{
				num += 2;
			}
			if (this.HideGroupInfo.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HideGroupInfo);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this.LevelPlayMarkUnlock)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CC7A RID: 52346 RVA: 0x001E2338 File Offset: 0x001E0538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayStateMsg other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelPlayEntityId != 0)
			{
				this.LevelPlayEntityId = other.LevelPlayEntityId;
			}
			if (other.ExploratoryType != 0)
			{
				this.ExploratoryType = other.ExploratoryType;
			}
			if (other.StateType != 0)
			{
				this.StateType = other.StateType;
			}
			if (other.CompleteNumber != 0)
			{
				this.CompleteNumber = other.CompleteNumber;
			}
			if (other.IsHide)
			{
				this.IsHide = other.IsHide;
			}
			if (other.HideGroupInfo.Length != 0)
			{
				this.HideGroupInfo = other.HideGroupInfo;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			if (other.LevelPlayMarkUnlock)
			{
				this.LevelPlayMarkUnlock = other.LevelPlayMarkUnlock;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CC7B RID: 52347 RVA: 0x001E2405 File Offset: 0x001E0605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CC7C RID: 52348 RVA: 0x001E2410 File Offset: 0x001E0610
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
				if (num <= 32U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.LevelPlayEntityId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.ExploratoryType = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.StateType = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.CompleteNumber = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 50U)
				{
					if (num == 40U)
					{
						this.IsHide = input.ReadBool();
						continue;
					}
					if (num == 50U)
					{
						this.HideGroupInfo = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.IsUnlock = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						this.LevelPlayMarkUnlock = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040056A2 RID: 22178
		private static readonly MessageParser<LevelPlayStateMsg> _parser = new MessageParser<LevelPlayStateMsg>(() => new LevelPlayStateMsg());

		// Token: 0x040056A3 RID: 22179
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056A4 RID: 22180
		public const int LevelPlayEntityIdFieldNumber = 1;

		// Token: 0x040056A5 RID: 22181
		private int levelPlayEntityId_;

		// Token: 0x040056A6 RID: 22182
		public const int ExploratoryTypeFieldNumber = 2;

		// Token: 0x040056A7 RID: 22183
		private int exploratoryType_;

		// Token: 0x040056A8 RID: 22184
		public const int StateTypeFieldNumber = 3;

		// Token: 0x040056A9 RID: 22185
		private int stateType_;

		// Token: 0x040056AA RID: 22186
		public const int CompleteNumberFieldNumber = 4;

		// Token: 0x040056AB RID: 22187
		private int completeNumber_;

		// Token: 0x040056AC RID: 22188
		public const int IsHideFieldNumber = 5;

		// Token: 0x040056AD RID: 22189
		private bool isHide_;

		// Token: 0x040056AE RID: 22190
		public const int HideGroupInfoFieldNumber = 6;

		// Token: 0x040056AF RID: 22191
		private string hideGroupInfo_ = "";

		// Token: 0x040056B0 RID: 22192
		public const int IsUnlockFieldNumber = 7;

		// Token: 0x040056B1 RID: 22193
		private bool isUnlock_;

		// Token: 0x040056B2 RID: 22194
		public const int LevelPlayMarkUnlockFieldNumber = 8;

		// Token: 0x040056B3 RID: 22195
		private bool levelPlayMarkUnlock_;
	}
}
