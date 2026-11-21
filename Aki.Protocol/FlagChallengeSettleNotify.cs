using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000588 RID: 1416
	[NetMessage(EMessageId.FlagChallengeSettleNotify)]
	public sealed class FlagChallengeSettleNotify : IMessage<FlagChallengeSettleNotify>, IMessage, IEquatable<FlagChallengeSettleNotify>, IDeepCloneable<FlagChallengeSettleNotify>, IBufferMessage
	{
		// Token: 0x06008397 RID: 33687 RVA: 0x0013D22F File Offset: 0x0013B42F
		[NullableContext(1)]
		public static FlagChallengeSettleNotify Create()
		{
			return new FlagChallengeSettleNotify();
		}

		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x06008398 RID: 33688 RVA: 0x0013D236 File Offset: 0x0013B436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x06008399 RID: 33689 RVA: 0x0013D239 File Offset: 0x0013B439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeSettleNotify.Descriptor;
			}
		}

		// Token: 0x0600839A RID: 33690 RVA: 0x0013D240 File Offset: 0x0013B440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeSettleNotify()
		{
		}

		// Token: 0x0600839B RID: 33691 RVA: 0x0013D248 File Offset: 0x0013B448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeSettleNotify(FlagChallengeSettleNotify other) : this()
		{
			this.challengeLevelId_ = other.challengeLevelId_;
			this.flagChallengePerRoleLevelInfo_ = ((other.flagChallengePerRoleLevelInfo_ != null) ? other.flagChallengePerRoleLevelInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600839C RID: 33692 RVA: 0x0013D294 File Offset: 0x0013B494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeSettleNotify Clone()
		{
			return new FlagChallengeSettleNotify(this);
		}

		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x0600839D RID: 33693 RVA: 0x0013D29C File Offset: 0x0013B49C
		// (set) Token: 0x0600839E RID: 33694 RVA: 0x0013D2A4 File Offset: 0x0013B4A4
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

		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x0600839F RID: 33695 RVA: 0x0013D2AD File Offset: 0x0013B4AD
		// (set) Token: 0x060083A0 RID: 33696 RVA: 0x0013D2B5 File Offset: 0x0013B4B5
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

		// Token: 0x060083A1 RID: 33697 RVA: 0x0013D2BE File Offset: 0x0013B4BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeSettleNotify);
		}

		// Token: 0x060083A2 RID: 33698 RVA: 0x0013D2CC File Offset: 0x0013B4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeSettleNotify other)
		{
			return other != null && (other == this || (this.ChallengeLevelId == other.ChallengeLevelId && object.Equals(this.FlagChallengePerRoleLevelInfo, other.FlagChallengePerRoleLevelInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060083A3 RID: 33699 RVA: 0x0013D31C File Offset: 0x0013B51C
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060083A4 RID: 33700 RVA: 0x0013D371 File Offset: 0x0013B571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060083A5 RID: 33701 RVA: 0x0013D37E File Offset: 0x0013B57E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060083A6 RID: 33702 RVA: 0x0013D388 File Offset: 0x0013B588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeLevelId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ChallengeLevelId);
			}
			if (this.flagChallengePerRoleLevelInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.FlagChallengePerRoleLevelInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060083A7 RID: 33703 RVA: 0x0013D3E4 File Offset: 0x0013B5E4
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060083A8 RID: 33704 RVA: 0x0013D43C File Offset: 0x0013B63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagChallengeSettleNotify other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060083A9 RID: 33705 RVA: 0x0013D4A4 File Offset: 0x0013B6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060083AA RID: 33706 RVA: 0x0013D4B0 File Offset: 0x0013B6B0
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
				if (num != 16U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.flagChallengePerRoleLevelInfo_ == null)
						{
							this.FlagChallengePerRoleLevelInfo = new FlagChallengeRoleLevelInfo();
						}
						input.ReadMessage(this.FlagChallengePerRoleLevelInfo);
					}
				}
				else
				{
					this.ChallengeLevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040041D6 RID: 16854
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041D7 RID: 16855
		public const int ChallengeLevelIdFieldNumber = 2;

		// Token: 0x040041D8 RID: 16856
		private int challengeLevelId_;

		// Token: 0x040041D9 RID: 16857
		public const int FlagChallengePerRoleLevelInfoFieldNumber = 10;

		// Token: 0x040041DA RID: 16858
		private FlagChallengeRoleLevelInfo flagChallengePerRoleLevelInfo_;
	}
}
