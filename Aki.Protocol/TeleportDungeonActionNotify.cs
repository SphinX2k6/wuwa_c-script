using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013A8 RID: 5032
	[NetMessage(EMessageId.TeleportDungeonActionNotify)]
	public sealed class TeleportDungeonActionNotify : IMessage<TeleportDungeonActionNotify>, IMessage, IEquatable<TeleportDungeonActionNotify>, IDeepCloneable<TeleportDungeonActionNotify>, IBufferMessage
	{
		// Token: 0x0601AC78 RID: 109688 RVA: 0x003E63E0 File Offset: 0x003E45E0
		[NullableContext(1)]
		public static TeleportDungeonActionNotify Create()
		{
			return new TeleportDungeonActionNotify();
		}

		// Token: 0x17005AA9 RID: 23209
		// (get) Token: 0x0601AC79 RID: 109689 RVA: 0x003E63E7 File Offset: 0x003E45E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AAA RID: 23210
		// (get) Token: 0x0601AC7A RID: 109690 RVA: 0x003E63EA File Offset: 0x003E45EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportDungeonActionNotify.Descriptor;
			}
		}

		// Token: 0x0601AC7B RID: 109691 RVA: 0x003E63F1 File Offset: 0x003E45F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDungeonActionNotify()
		{
		}

		// Token: 0x0601AC7C RID: 109692 RVA: 0x003E63FC File Offset: 0x003E45FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDungeonActionNotify(TeleportDungeonActionNotify other) : this()
		{
			this.hostPlayerId_ = other.hostPlayerId_;
			this.incId_ = other.incId_;
			this.dungeonId_ = other.dungeonId_;
			this.isRegroup_ = other.isRegroup_;
			this.isNeedSecondaryConfirmation_ = other.isNeedSecondaryConfirmation_;
			this.continueLastInst_ = other.continueLastInst_;
			this.transitionOption_ = ((other.transitionOption_ != null) ? other.transitionOption_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AC7D RID: 109693 RVA: 0x003E6484 File Offset: 0x003E4684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDungeonActionNotify Clone()
		{
			return new TeleportDungeonActionNotify(this);
		}

		// Token: 0x17005AAB RID: 23211
		// (get) Token: 0x0601AC7E RID: 109694 RVA: 0x003E648C File Offset: 0x003E468C
		// (set) Token: 0x0601AC7F RID: 109695 RVA: 0x003E6494 File Offset: 0x003E4694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HostPlayerId
		{
			get
			{
				return this.hostPlayerId_;
			}
			set
			{
				this.hostPlayerId_ = value;
			}
		}

		// Token: 0x17005AAC RID: 23212
		// (get) Token: 0x0601AC80 RID: 109696 RVA: 0x003E649D File Offset: 0x003E469D
		// (set) Token: 0x0601AC81 RID: 109697 RVA: 0x003E64A5 File Offset: 0x003E46A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17005AAD RID: 23213
		// (get) Token: 0x0601AC82 RID: 109698 RVA: 0x003E64AE File Offset: 0x003E46AE
		// (set) Token: 0x0601AC83 RID: 109699 RVA: 0x003E64B6 File Offset: 0x003E46B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DungeonId
		{
			get
			{
				return this.dungeonId_;
			}
			set
			{
				this.dungeonId_ = value;
			}
		}

		// Token: 0x17005AAE RID: 23214
		// (get) Token: 0x0601AC84 RID: 109700 RVA: 0x003E64BF File Offset: 0x003E46BF
		// (set) Token: 0x0601AC85 RID: 109701 RVA: 0x003E64C7 File Offset: 0x003E46C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRegroup
		{
			get
			{
				return this.isRegroup_;
			}
			set
			{
				this.isRegroup_ = value;
			}
		}

		// Token: 0x17005AAF RID: 23215
		// (get) Token: 0x0601AC86 RID: 109702 RVA: 0x003E64D0 File Offset: 0x003E46D0
		// (set) Token: 0x0601AC87 RID: 109703 RVA: 0x003E64D8 File Offset: 0x003E46D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNeedSecondaryConfirmation
		{
			get
			{
				return this.isNeedSecondaryConfirmation_;
			}
			set
			{
				this.isNeedSecondaryConfirmation_ = value;
			}
		}

		// Token: 0x17005AB0 RID: 23216
		// (get) Token: 0x0601AC88 RID: 109704 RVA: 0x003E64E1 File Offset: 0x003E46E1
		// (set) Token: 0x0601AC89 RID: 109705 RVA: 0x003E64E9 File Offset: 0x003E46E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ContinueLastInst
		{
			get
			{
				return this.continueLastInst_;
			}
			set
			{
				this.continueLastInst_ = value;
			}
		}

		// Token: 0x17005AB1 RID: 23217
		// (get) Token: 0x0601AC8A RID: 109706 RVA: 0x003E64F2 File Offset: 0x003E46F2
		// (set) Token: 0x0601AC8B RID: 109707 RVA: 0x003E64FA File Offset: 0x003E46FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionOptionPb TransitionOption
		{
			get
			{
				return this.transitionOption_;
			}
			set
			{
				this.transitionOption_ = value;
			}
		}

		// Token: 0x0601AC8C RID: 109708 RVA: 0x003E6503 File Offset: 0x003E4703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportDungeonActionNotify);
		}

		// Token: 0x0601AC8D RID: 109709 RVA: 0x003E6514 File Offset: 0x003E4714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportDungeonActionNotify other)
		{
			return other != null && (other == this || (this.HostPlayerId == other.HostPlayerId && this.IncId == other.IncId && this.DungeonId == other.DungeonId && this.IsRegroup == other.IsRegroup && this.IsNeedSecondaryConfirmation == other.IsNeedSecondaryConfirmation && this.ContinueLastInst == other.ContinueLastInst && object.Equals(this.TransitionOption, other.TransitionOption) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AC8E RID: 109710 RVA: 0x003E65B4 File Offset: 0x003E47B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HostPlayerId != 0)
			{
				num ^= this.HostPlayerId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.DungeonId != 0)
			{
				num ^= this.DungeonId.GetHashCode();
			}
			if (this.IsRegroup)
			{
				num ^= this.IsRegroup.GetHashCode();
			}
			if (this.IsNeedSecondaryConfirmation)
			{
				num ^= this.IsNeedSecondaryConfirmation.GetHashCode();
			}
			if (this.ContinueLastInst)
			{
				num ^= this.ContinueLastInst.GetHashCode();
			}
			if (this.transitionOption_ != null)
			{
				num ^= this.TransitionOption.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AC8F RID: 109711 RVA: 0x003E6686 File Offset: 0x003E4886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AC90 RID: 109712 RVA: 0x003E6693 File Offset: 0x003E4893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AC91 RID: 109713 RVA: 0x003E669C File Offset: 0x003E489C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this.IsNeedSecondaryConfirmation)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsNeedSecondaryConfirmation);
			}
			if (this.IsRegroup)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsRegroup);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.IncId);
			}
			if (this.DungeonId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.DungeonId);
			}
			if (this.transitionOption_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.TransitionOption);
			}
			if (this.ContinueLastInst)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.ContinueLastInst);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AC92 RID: 109714 RVA: 0x003E6780 File Offset: 0x003E4980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HostPlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HostPlayerId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.DungeonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DungeonId);
			}
			if (this.IsRegroup)
			{
				num += 2;
			}
			if (this.IsNeedSecondaryConfirmation)
			{
				num += 2;
			}
			if (this.ContinueLastInst)
			{
				num += 2;
			}
			if (this.transitionOption_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TransitionOption);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AC93 RID: 109715 RVA: 0x003E682C File Offset: 0x003E4A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportDungeonActionNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HostPlayerId != 0)
			{
				this.HostPlayerId = other.HostPlayerId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.DungeonId != 0)
			{
				this.DungeonId = other.DungeonId;
			}
			if (other.IsRegroup)
			{
				this.IsRegroup = other.IsRegroup;
			}
			if (other.IsNeedSecondaryConfirmation)
			{
				this.IsNeedSecondaryConfirmation = other.IsNeedSecondaryConfirmation;
			}
			if (other.ContinueLastInst)
			{
				this.ContinueLastInst = other.ContinueLastInst;
			}
			if (other.transitionOption_ != null)
			{
				if (this.transitionOption_ == null)
				{
					this.TransitionOption = new TransitionOptionPb();
				}
				this.TransitionOption.MergeFrom(other.TransitionOption);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AC94 RID: 109716 RVA: 0x003E68F8 File Offset: 0x003E4AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AC95 RID: 109717 RVA: 0x003E6904 File Offset: 0x003E4B04
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
				if (num <= 80U)
				{
					if (num == 8U)
					{
						this.HostPlayerId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.IsNeedSecondaryConfirmation = input.ReadBool();
						continue;
					}
					if (num == 80U)
					{
						this.IsRegroup = input.ReadBool();
						continue;
					}
				}
				else if (num <= 96U)
				{
					if (num == 88U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.DungeonId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						if (this.transitionOption_ == null)
						{
							this.TransitionOption = new TransitionOptionPb();
						}
						input.ReadMessage(this.TransitionOption);
						continue;
					}
					if (num == 120U)
					{
						this.ContinueLastInst = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009CB1 RID: 40113
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CB2 RID: 40114
		public const int HostPlayerIdFieldNumber = 1;

		// Token: 0x04009CB3 RID: 40115
		private int hostPlayerId_;

		// Token: 0x04009CB4 RID: 40116
		public const int IncIdFieldNumber = 11;

		// Token: 0x04009CB5 RID: 40117
		private int incId_;

		// Token: 0x04009CB6 RID: 40118
		public const int DungeonIdFieldNumber = 12;

		// Token: 0x04009CB7 RID: 40119
		private int dungeonId_;

		// Token: 0x04009CB8 RID: 40120
		public const int IsRegroupFieldNumber = 10;

		// Token: 0x04009CB9 RID: 40121
		private bool isRegroup_;

		// Token: 0x04009CBA RID: 40122
		public const int IsNeedSecondaryConfirmationFieldNumber = 6;

		// Token: 0x04009CBB RID: 40123
		private bool isNeedSecondaryConfirmation_;

		// Token: 0x04009CBC RID: 40124
		public const int ContinueLastInstFieldNumber = 15;

		// Token: 0x04009CBD RID: 40125
		private bool continueLastInst_;

		// Token: 0x04009CBE RID: 40126
		public const int TransitionOptionFieldNumber = 13;

		// Token: 0x04009CBF RID: 40127
		private TransitionOptionPb transitionOption_;
	}
}
