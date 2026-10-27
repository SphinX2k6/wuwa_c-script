using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000596 RID: 1430
	[NetMessage(EMessageId.FlagChallengeInstNotify)]
	public sealed class FlagChallengeInstNotify : IMessage<FlagChallengeInstNotify>, IMessage, IEquatable<FlagChallengeInstNotify>, IDeepCloneable<FlagChallengeInstNotify>, IBufferMessage
	{
		// Token: 0x0600846F RID: 33903 RVA: 0x0013EA64 File Offset: 0x0013CC64
		[NullableContext(1)]
		public static FlagChallengeInstNotify Create()
		{
			return new FlagChallengeInstNotify();
		}

		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x06008470 RID: 33904 RVA: 0x0013EA6B File Offset: 0x0013CC6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x06008471 RID: 33905 RVA: 0x0013EA6E File Offset: 0x0013CC6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeInstNotify.Descriptor;
			}
		}

		// Token: 0x06008472 RID: 33906 RVA: 0x0013EA75 File Offset: 0x0013CC75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeInstNotify()
		{
		}

		// Token: 0x06008473 RID: 33907 RVA: 0x0013EA80 File Offset: 0x0013CC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeInstNotify(FlagChallengeInstNotify other) : this()
		{
			this.challengeLevelId_ = other.challengeLevelId_;
			this.flagChallengePerRoleLevelInfo_ = ((other.flagChallengePerRoleLevelInfo_ != null) ? other.flagChallengePerRoleLevelInfo_.Clone() : null);
			this.flagChallengeTempRoleLevelInfo_ = ((other.flagChallengeTempRoleLevelInfo_ != null) ? other.flagChallengeTempRoleLevelInfo_.Clone() : null);
			this.boxExp_ = other.boxExp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008474 RID: 33908 RVA: 0x0013EAF4 File Offset: 0x0013CCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeInstNotify Clone()
		{
			return new FlagChallengeInstNotify(this);
		}

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x06008475 RID: 33909 RVA: 0x0013EAFC File Offset: 0x0013CCFC
		// (set) Token: 0x06008476 RID: 33910 RVA: 0x0013EB04 File Offset: 0x0013CD04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeLevelId
		{
			get
			{
				return this.challengeLevelId_;
			}
			set
			{
				this.challengeLevelId_ = value;
			}
		}

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x06008477 RID: 33911 RVA: 0x0013EB0D File Offset: 0x0013CD0D
		// (set) Token: 0x06008478 RID: 33912 RVA: 0x0013EB15 File Offset: 0x0013CD15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRoleLevelInfo FlagChallengePerRoleLevelInfo
		{
			get
			{
				return this.flagChallengePerRoleLevelInfo_;
			}
			set
			{
				this.flagChallengePerRoleLevelInfo_ = value;
			}
		}

		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x06008479 RID: 33913 RVA: 0x0013EB1E File Offset: 0x0013CD1E
		// (set) Token: 0x0600847A RID: 33914 RVA: 0x0013EB26 File Offset: 0x0013CD26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRoleLevelInfo FlagChallengeTempRoleLevelInfo
		{
			get
			{
				return this.flagChallengeTempRoleLevelInfo_;
			}
			set
			{
				this.flagChallengeTempRoleLevelInfo_ = value;
			}
		}

		// Token: 0x170019D3 RID: 6611
		// (get) Token: 0x0600847B RID: 33915 RVA: 0x0013EB2F File Offset: 0x0013CD2F
		// (set) Token: 0x0600847C RID: 33916 RVA: 0x0013EB37 File Offset: 0x0013CD37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BoxExp
		{
			get
			{
				return this.boxExp_;
			}
			set
			{
				this.boxExp_ = value;
			}
		}

		// Token: 0x0600847D RID: 33917 RVA: 0x0013EB40 File Offset: 0x0013CD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeInstNotify);
		}

		// Token: 0x0600847E RID: 33918 RVA: 0x0013EB50 File Offset: 0x0013CD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeInstNotify other)
		{
			return other != null && (other == this || (this.ChallengeLevelId == other.ChallengeLevelId && object.Equals(this.FlagChallengePerRoleLevelInfo, other.FlagChallengePerRoleLevelInfo) && object.Equals(this.FlagChallengeTempRoleLevelInfo, other.FlagChallengeTempRoleLevelInfo) && this.BoxExp == other.BoxExp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600847F RID: 33919 RVA: 0x0013EBC4 File Offset: 0x0013CDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeLevelId != 0)
			{
				num ^= this.ChallengeLevelId.GetHashCode();
			}
			if (this.flagChallengePerRoleLevelInfo_ != null)
			{
				num ^= this.FlagChallengePerRoleLevelInfo.GetHashCode();
			}
			if (this.flagChallengeTempRoleLevelInfo_ != null)
			{
				num ^= this.FlagChallengeTempRoleLevelInfo.GetHashCode();
			}
			if (this.BoxExp != 0)
			{
				num ^= this.BoxExp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008480 RID: 33920 RVA: 0x0013EC48 File Offset: 0x0013CE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008481 RID: 33921 RVA: 0x0013EC55 File Offset: 0x0013CE55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008482 RID: 33922 RVA: 0x0013EC60 File Offset: 0x0013CE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.flagChallengePerRoleLevelInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.FlagChallengePerRoleLevelInfo);
			}
			if (this.flagChallengeTempRoleLevelInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.FlagChallengeTempRoleLevelInfo);
			}
			if (this.BoxExp != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.BoxExp);
			}
			if (this.ChallengeLevelId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ChallengeLevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008483 RID: 33923 RVA: 0x0013ECF4 File Offset: 0x0013CEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeLevelId);
			}
			if (this.flagChallengePerRoleLevelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FlagChallengePerRoleLevelInfo);
			}
			if (this.flagChallengeTempRoleLevelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FlagChallengeTempRoleLevelInfo);
			}
			if (this.BoxExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BoxExp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008484 RID: 33924 RVA: 0x0013ED7C File Offset: 0x0013CF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagChallengeInstNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeLevelId != 0)
			{
				this.ChallengeLevelId = other.ChallengeLevelId;
			}
			if (other.flagChallengePerRoleLevelInfo_ != null)
			{
				if (this.flagChallengePerRoleLevelInfo_ == null)
				{
					this.FlagChallengePerRoleLevelInfo = new FlagChallengeRoleLevelInfo();
				}
				this.FlagChallengePerRoleLevelInfo.MergeFrom(other.FlagChallengePerRoleLevelInfo);
			}
			if (other.flagChallengeTempRoleLevelInfo_ != null)
			{
				if (this.flagChallengeTempRoleLevelInfo_ == null)
				{
					this.FlagChallengeTempRoleLevelInfo = new FlagChallengeRoleLevelInfo();
				}
				this.FlagChallengeTempRoleLevelInfo.MergeFrom(other.FlagChallengeTempRoleLevelInfo);
			}
			if (other.BoxExp != 0)
			{
				this.BoxExp = other.BoxExp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008485 RID: 33925 RVA: 0x0013EE24 File Offset: 0x0013D024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008486 RID: 33926 RVA: 0x0013EE30 File Offset: 0x0013D030
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
				if (num <= 42U)
				{
					if (num == 18U)
					{
						if (this.flagChallengePerRoleLevelInfo_ == null)
						{
							this.FlagChallengePerRoleLevelInfo = new FlagChallengeRoleLevelInfo();
						}
						input.ReadMessage(this.FlagChallengePerRoleLevelInfo);
						continue;
					}
					if (num == 42U)
					{
						if (this.flagChallengeTempRoleLevelInfo_ == null)
						{
							this.FlagChallengeTempRoleLevelInfo = new FlagChallengeRoleLevelInfo();
						}
						input.ReadMessage(this.FlagChallengeTempRoleLevelInfo);
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.BoxExp = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.ChallengeLevelId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040041B8 RID: 16824
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041B9 RID: 16825
		public const int ChallengeLevelIdFieldNumber = 14;

		// Token: 0x040041BA RID: 16826
		private int challengeLevelId_;

		// Token: 0x040041BB RID: 16827
		public const int FlagChallengePerRoleLevelInfoFieldNumber = 2;

		// Token: 0x040041BC RID: 16828
		private FlagChallengeRoleLevelInfo flagChallengePerRoleLevelInfo_;

		// Token: 0x040041BD RID: 16829
		public const int FlagChallengeTempRoleLevelInfoFieldNumber = 5;

		// Token: 0x040041BE RID: 16830
		private FlagChallengeRoleLevelInfo flagChallengeTempRoleLevelInfo_;

		// Token: 0x040041BF RID: 16831
		public const int BoxExpFieldNumber = 6;

		// Token: 0x040041C0 RID: 16832
		private int boxExp_;
	}
}
