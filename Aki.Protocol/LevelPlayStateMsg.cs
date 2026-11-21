using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008FA RID: 2298
	public sealed class LevelPlayStateMsg : IMessage<LevelPlayStateMsg>, IMessage, IEquatable<LevelPlayStateMsg>, IDeepCloneable<LevelPlayStateMsg>, IBufferMessage
	{
		// Token: 0x0600CB40 RID: 52032 RVA: 0x001DFB80 File Offset: 0x001DDD80
		[NullableContext(1)]
		public static LevelPlayStateMsg Create()
		{
			return new LevelPlayStateMsg();
		}

		// Token: 0x17002902 RID: 10498
		// (get) Token: 0x0600CB41 RID: 52033 RVA: 0x001DFB87 File Offset: 0x001DDD87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LevelPlayStateMsg> Parser
		{
			get
			{
				return LevelPlayStateMsg._parser;
			}
		}

		// Token: 0x17002903 RID: 10499
		// (get) Token: 0x0600CB42 RID: 52034 RVA: 0x001DFB8E File Offset: 0x001DDD8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002904 RID: 10500
		// (get) Token: 0x0600CB43 RID: 52035 RVA: 0x001DFB91 File Offset: 0x001DDD91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayStateMsg.Descriptor;
			}
		}

		// Token: 0x0600CB44 RID: 52036 RVA: 0x001DFB98 File Offset: 0x001DDD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateMsg()
		{
		}

		// Token: 0x0600CB45 RID: 52037 RVA: 0x001DFBAC File Offset: 0x001DDDAC
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

		// Token: 0x0600CB46 RID: 52038 RVA: 0x001DFC30 File Offset: 0x001DDE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateMsg Clone()
		{
			return new LevelPlayStateMsg(this);
		}

		// Token: 0x17002905 RID: 10501
		// (get) Token: 0x0600CB47 RID: 52039 RVA: 0x001DFC38 File Offset: 0x001DDE38
		// (set) Token: 0x0600CB48 RID: 52040 RVA: 0x001DFC40 File Offset: 0x001DDE40
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

		// Token: 0x17002906 RID: 10502
		// (get) Token: 0x0600CB49 RID: 52041 RVA: 0x001DFC49 File Offset: 0x001DDE49
		// (set) Token: 0x0600CB4A RID: 52042 RVA: 0x001DFC51 File Offset: 0x001DDE51
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

		// Token: 0x17002907 RID: 10503
		// (get) Token: 0x0600CB4B RID: 52043 RVA: 0x001DFC5A File Offset: 0x001DDE5A
		// (set) Token: 0x0600CB4C RID: 52044 RVA: 0x001DFC62 File Offset: 0x001DDE62
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

		// Token: 0x17002908 RID: 10504
		// (get) Token: 0x0600CB4D RID: 52045 RVA: 0x001DFC6B File Offset: 0x001DDE6B
		// (set) Token: 0x0600CB4E RID: 52046 RVA: 0x001DFC73 File Offset: 0x001DDE73
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

		// Token: 0x17002909 RID: 10505
		// (get) Token: 0x0600CB4F RID: 52047 RVA: 0x001DFC7C File Offset: 0x001DDE7C
		// (set) Token: 0x0600CB50 RID: 52048 RVA: 0x001DFC84 File Offset: 0x001DDE84
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

		// Token: 0x1700290A RID: 10506
		// (get) Token: 0x0600CB51 RID: 52049 RVA: 0x001DFC8D File Offset: 0x001DDE8D
		// (set) Token: 0x0600CB52 RID: 52050 RVA: 0x001DFC95 File Offset: 0x001DDE95
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

		// Token: 0x1700290B RID: 10507
		// (get) Token: 0x0600CB53 RID: 52051 RVA: 0x001DFCA8 File Offset: 0x001DDEA8
		// (set) Token: 0x0600CB54 RID: 52052 RVA: 0x001DFCB0 File Offset: 0x001DDEB0
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

		// Token: 0x1700290C RID: 10508
		// (get) Token: 0x0600CB55 RID: 52053 RVA: 0x001DFCB9 File Offset: 0x001DDEB9
		// (set) Token: 0x0600CB56 RID: 52054 RVA: 0x001DFCC1 File Offset: 0x001DDEC1
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

		// Token: 0x0600CB57 RID: 52055 RVA: 0x001DFCCA File Offset: 0x001DDECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayStateMsg);
		}

		// Token: 0x0600CB58 RID: 52056 RVA: 0x001DFCD8 File Offset: 0x001DDED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayStateMsg other)
		{
			return other != null && (other == this || (this.LevelPlayEntityId == other.LevelPlayEntityId && this.ExploratoryType == other.ExploratoryType && this.StateType == other.StateType && this.CompleteNumber == other.CompleteNumber && this.IsHide == other.IsHide && !(this.HideGroupInfo != other.HideGroupInfo) && this.IsUnlock == other.IsUnlock && this.LevelPlayMarkUnlock == other.LevelPlayMarkUnlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CB59 RID: 52057 RVA: 0x001DFD88 File Offset: 0x001DDF88
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

		// Token: 0x0600CB5A RID: 52058 RVA: 0x001DFE78 File Offset: 0x001DE078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CB5B RID: 52059 RVA: 0x001DFE85 File Offset: 0x001DE085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CB5C RID: 52060 RVA: 0x001DFE90 File Offset: 0x001DE090
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

		// Token: 0x0600CB5D RID: 52061 RVA: 0x001DFF98 File Offset: 0x001DE198
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

		// Token: 0x0600CB5E RID: 52062 RVA: 0x001E0060 File Offset: 0x001DE260
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

		// Token: 0x0600CB5F RID: 52063 RVA: 0x001E012D File Offset: 0x001DE32D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CB60 RID: 52064 RVA: 0x001E0138 File Offset: 0x001DE338
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

		// Token: 0x040056A9 RID: 22185
		private static readonly MessageParser<LevelPlayStateMsg> _parser = new MessageParser<LevelPlayStateMsg>(() => new LevelPlayStateMsg());

		// Token: 0x040056AA RID: 22186
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056AB RID: 22187
		public const int LevelPlayEntityIdFieldNumber = 1;

		// Token: 0x040056AC RID: 22188
		private int levelPlayEntityId_;

		// Token: 0x040056AD RID: 22189
		public const int ExploratoryTypeFieldNumber = 2;

		// Token: 0x040056AE RID: 22190
		private int exploratoryType_;

		// Token: 0x040056AF RID: 22191
		public const int StateTypeFieldNumber = 3;

		// Token: 0x040056B0 RID: 22192
		private int stateType_;

		// Token: 0x040056B1 RID: 22193
		public const int CompleteNumberFieldNumber = 4;

		// Token: 0x040056B2 RID: 22194
		private int completeNumber_;

		// Token: 0x040056B3 RID: 22195
		public const int IsHideFieldNumber = 5;

		// Token: 0x040056B4 RID: 22196
		private bool isHide_;

		// Token: 0x040056B5 RID: 22197
		public const int HideGroupInfoFieldNumber = 6;

		// Token: 0x040056B6 RID: 22198
		private string hideGroupInfo_ = "";

		// Token: 0x040056B7 RID: 22199
		public const int IsUnlockFieldNumber = 7;

		// Token: 0x040056B8 RID: 22200
		private bool isUnlock_;

		// Token: 0x040056B9 RID: 22201
		public const int LevelPlayMarkUnlockFieldNumber = 8;

		// Token: 0x040056BA RID: 22202
		private bool levelPlayMarkUnlock_;
	}
}
