using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200058A RID: 1418
	[NetMessage(EMessageId.FlagChallengeTempRoleLevelNotify)]
	public sealed class FlagChallengeTempRoleLevelNotify : IMessage<FlagChallengeTempRoleLevelNotify>, IMessage, IEquatable<FlagChallengeTempRoleLevelNotify>, IDeepCloneable<FlagChallengeTempRoleLevelNotify>, IBufferMessage
	{
		// Token: 0x060083BD RID: 33725 RVA: 0x0013D6FD File Offset: 0x0013B8FD
		[NullableContext(1)]
		public static FlagChallengeTempRoleLevelNotify Create()
		{
			return new FlagChallengeTempRoleLevelNotify();
		}

		// Token: 0x170019A6 RID: 6566
		// (get) Token: 0x060083BE RID: 33726 RVA: 0x0013D704 File Offset: 0x0013B904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019A7 RID: 6567
		// (get) Token: 0x060083BF RID: 33727 RVA: 0x0013D707 File Offset: 0x0013B907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeTempRoleLevelNotify.Descriptor;
			}
		}

		// Token: 0x060083C0 RID: 33728 RVA: 0x0013D70E File Offset: 0x0013B90E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeTempRoleLevelNotify()
		{
		}

		// Token: 0x060083C1 RID: 33729 RVA: 0x0013D718 File Offset: 0x0013B918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeTempRoleLevelNotify(FlagChallengeTempRoleLevelNotify other) : this()
		{
			this.challengeLevelId_ = other.challengeLevelId_;
			this.flagChallengeRoleLevelInfo_ = ((other.flagChallengeRoleLevelInfo_ != null) ? other.flagChallengeRoleLevelInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060083C2 RID: 33730 RVA: 0x0013D764 File Offset: 0x0013B964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeTempRoleLevelNotify Clone()
		{
			return new FlagChallengeTempRoleLevelNotify(this);
		}

		// Token: 0x170019A8 RID: 6568
		// (get) Token: 0x060083C3 RID: 33731 RVA: 0x0013D76C File Offset: 0x0013B96C
		// (set) Token: 0x060083C4 RID: 33732 RVA: 0x0013D774 File Offset: 0x0013B974
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

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x060083C5 RID: 33733 RVA: 0x0013D77D File Offset: 0x0013B97D
		// (set) Token: 0x060083C6 RID: 33734 RVA: 0x0013D785 File Offset: 0x0013B985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRoleLevelInfo FlagChallengeRoleLevelInfo
		{
			get
			{
				return this.flagChallengeRoleLevelInfo_;
			}
			set
			{
				this.flagChallengeRoleLevelInfo_ = value;
			}
		}

		// Token: 0x060083C7 RID: 33735 RVA: 0x0013D78E File Offset: 0x0013B98E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeTempRoleLevelNotify);
		}

		// Token: 0x060083C8 RID: 33736 RVA: 0x0013D79C File Offset: 0x0013B99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeTempRoleLevelNotify other)
		{
			return other != null && (other == this || (this.ChallengeLevelId == other.ChallengeLevelId && object.Equals(this.FlagChallengeRoleLevelInfo, other.FlagChallengeRoleLevelInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060083C9 RID: 33737 RVA: 0x0013D7EC File Offset: 0x0013B9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeLevelId != 0)
			{
				num ^= this.ChallengeLevelId.GetHashCode();
			}
			if (this.flagChallengeRoleLevelInfo_ != null)
			{
				num ^= this.FlagChallengeRoleLevelInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060083CA RID: 33738 RVA: 0x0013D841 File Offset: 0x0013BA41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060083CB RID: 33739 RVA: 0x0013D84E File Offset: 0x0013BA4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060083CC RID: 33740 RVA: 0x0013D858 File Offset: 0x0013BA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.flagChallengeRoleLevelInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.FlagChallengeRoleLevelInfo);
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

		// Token: 0x060083CD RID: 33741 RVA: 0x0013D8B4 File Offset: 0x0013BAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeLevelId);
			}
			if (this.flagChallengeRoleLevelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FlagChallengeRoleLevelInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060083CE RID: 33742 RVA: 0x0013D90C File Offset: 0x0013BB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagChallengeTempRoleLevelNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeLevelId != 0)
			{
				this.ChallengeLevelId = other.ChallengeLevelId;
			}
			if (other.flagChallengeRoleLevelInfo_ != null)
			{
				if (this.flagChallengeRoleLevelInfo_ == null)
				{
					this.FlagChallengeRoleLevelInfo = new FlagChallengeRoleLevelInfo();
				}
				this.FlagChallengeRoleLevelInfo.MergeFrom(other.FlagChallengeRoleLevelInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060083CF RID: 33743 RVA: 0x0013D974 File Offset: 0x0013BB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060083D0 RID: 33744 RVA: 0x0013D980 File Offset: 0x0013BB80
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
				if (num != 66U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ChallengeLevelId = input.ReadInt32();
					}
				}
				else
				{
					if (this.flagChallengeRoleLevelInfo_ == null)
					{
						this.FlagChallengeRoleLevelInfo = new FlagChallengeRoleLevelInfo();
					}
					input.ReadMessage(this.FlagChallengeRoleLevelInfo);
				}
			}
		}

		// Token: 0x040041DF RID: 16863
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041E0 RID: 16864
		public const int ChallengeLevelIdFieldNumber = 14;

		// Token: 0x040041E1 RID: 16865
		private int challengeLevelId_;

		// Token: 0x040041E2 RID: 16866
		public const int FlagChallengeRoleLevelInfoFieldNumber = 8;

		// Token: 0x040041E3 RID: 16867
		private FlagChallengeRoleLevelInfo flagChallengeRoleLevelInfo_;
	}
}
