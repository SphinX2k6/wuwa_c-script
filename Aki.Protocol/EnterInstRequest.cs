using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200043E RID: 1086
	[NetMessage(EMessageId.EnterInstRequest)]
	public sealed class EnterInstRequest : IMessage<EnterInstRequest>, IMessage, IEquatable<EnterInstRequest>, IDeepCloneable<EnterInstRequest>, IBufferMessage
	{
		// Token: 0x06006889 RID: 26761 RVA: 0x000FD234 File Offset: 0x000FB434
		[NullableContext(1)]
		public static EnterInstRequest Create()
		{
			return new EnterInstRequest();
		}

		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x0600688A RID: 26762 RVA: 0x000FD23B File Offset: 0x000FB43B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x0600688B RID: 26763 RVA: 0x000FD23E File Offset: 0x000FB43E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterInstRequest.Descriptor;
			}
		}

		// Token: 0x0600688C RID: 26764 RVA: 0x000FD245 File Offset: 0x000FB445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterInstRequest()
		{
		}

		// Token: 0x0600688D RID: 26765 RVA: 0x000FD264 File Offset: 0x000FB464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterInstRequest(EnterInstRequest other) : this()
		{
			this.instanceId_ = other.instanceId_;
			this.roleIds_ = other.roleIds_.Clone();
			this.entranceId_ = other.entranceId_;
			this.posEntityId_ = other.posEntityId_;
			this.transitionOption_ = ((other.transitionOption_ != null) ? other.transitionOption_.Clone() : null);
			this.towerDefencePhantomId_ = other.towerDefencePhantomId_.Clone();
			this.enterInstContext_ = ((other.enterInstContext_ != null) ? other.enterInstContext_.Clone() : null);
			this.continueLastInst_ = other.continueLastInst_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600688E RID: 26766 RVA: 0x000FD312 File Offset: 0x000FB512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterInstRequest Clone()
		{
			return new EnterInstRequest(this);
		}

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x0600688F RID: 26767 RVA: 0x000FD31A File Offset: 0x000FB51A
		// (set) Token: 0x06006890 RID: 26768 RVA: 0x000FD322 File Offset: 0x000FB522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstanceId
		{
			get
			{
				return this.instanceId_;
			}
			set
			{
				this.instanceId_ = value;
			}
		}

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x06006891 RID: 26769 RVA: 0x000FD32B File Offset: 0x000FB52B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x06006892 RID: 26770 RVA: 0x000FD333 File Offset: 0x000FB533
		// (set) Token: 0x06006893 RID: 26771 RVA: 0x000FD33B File Offset: 0x000FB53B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntranceId
		{
			get
			{
				return this.entranceId_;
			}
			set
			{
				this.entranceId_ = value;
			}
		}

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x06006894 RID: 26772 RVA: 0x000FD344 File Offset: 0x000FB544
		// (set) Token: 0x06006895 RID: 26773 RVA: 0x000FD34C File Offset: 0x000FB54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PosEntityId
		{
			get
			{
				return this.posEntityId_;
			}
			set
			{
				this.posEntityId_ = value;
			}
		}

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x06006896 RID: 26774 RVA: 0x000FD355 File Offset: 0x000FB555
		// (set) Token: 0x06006897 RID: 26775 RVA: 0x000FD35D File Offset: 0x000FB55D
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

		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x06006898 RID: 26776 RVA: 0x000FD366 File Offset: 0x000FB566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TowerDefencePhantomId
		{
			get
			{
				return this.towerDefencePhantomId_;
			}
		}

		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x06006899 RID: 26777 RVA: 0x000FD36E File Offset: 0x000FB56E
		// (set) Token: 0x0600689A RID: 26778 RVA: 0x000FD376 File Offset: 0x000FB576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterInstContext EnterInstContext
		{
			get
			{
				return this.enterInstContext_;
			}
			set
			{
				this.enterInstContext_ = value;
			}
		}

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x0600689B RID: 26779 RVA: 0x000FD37F File Offset: 0x000FB57F
		// (set) Token: 0x0600689C RID: 26780 RVA: 0x000FD387 File Offset: 0x000FB587
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

		// Token: 0x0600689D RID: 26781 RVA: 0x000FD390 File Offset: 0x000FB590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterInstRequest);
		}

		// Token: 0x0600689E RID: 26782 RVA: 0x000FD3A0 File Offset: 0x000FB5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterInstRequest other)
		{
			return other != null && (other == this || (this.InstanceId == other.InstanceId && this.roleIds_.Equals(other.roleIds_) && this.EntranceId == other.EntranceId && this.PosEntityId == other.PosEntityId && object.Equals(this.TransitionOption, other.TransitionOption) && this.towerDefencePhantomId_.Equals(other.towerDefencePhantomId_) && object.Equals(this.EnterInstContext, other.EnterInstContext) && this.ContinueLastInst == other.ContinueLastInst && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600689F RID: 26783 RVA: 0x000FD460 File Offset: 0x000FB660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstanceId != 0)
			{
				num ^= this.InstanceId.GetHashCode();
			}
			num ^= this.roleIds_.GetHashCode();
			if (this.EntranceId != 0)
			{
				num ^= this.EntranceId.GetHashCode();
			}
			if (this.PosEntityId != 0)
			{
				num ^= this.PosEntityId.GetHashCode();
			}
			if (this.transitionOption_ != null)
			{
				num ^= this.TransitionOption.GetHashCode();
			}
			num ^= this.towerDefencePhantomId_.GetHashCode();
			if (this.enterInstContext_ != null)
			{
				num ^= this.EnterInstContext.GetHashCode();
			}
			if (this.ContinueLastInst)
			{
				num ^= this.ContinueLastInst.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060068A0 RID: 26784 RVA: 0x000FD532 File Offset: 0x000FB732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060068A1 RID: 26785 RVA: 0x000FD53F File Offset: 0x000FB73F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060068A2 RID: 26786 RVA: 0x000FD548 File Offset: 0x000FB748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ContinueLastInst)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.ContinueLastInst);
			}
			this.roleIds_.WriteTo(ref output, EnterInstRequest._repeated_roleIds_codec);
			if (this.EntranceId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.EntranceId);
			}
			if (this.enterInstContext_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.EnterInstContext);
			}
			if (this.InstanceId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.InstanceId);
			}
			if (this.PosEntityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PosEntityId);
			}
			this.towerDefencePhantomId_.WriteTo(ref output, EnterInstRequest._repeated_towerDefencePhantomId_codec);
			if (this.transitionOption_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.TransitionOption);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060068A3 RID: 26787 RVA: 0x000FD634 File Offset: 0x000FB834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstanceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstanceId);
			}
			num += this.roleIds_.CalculateSize(EnterInstRequest._repeated_roleIds_codec);
			if (this.EntranceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntranceId);
			}
			if (this.PosEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PosEntityId);
			}
			if (this.transitionOption_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TransitionOption);
			}
			num += this.towerDefencePhantomId_.CalculateSize(EnterInstRequest._repeated_towerDefencePhantomId_codec);
			if (this.enterInstContext_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EnterInstContext);
			}
			if (this.ContinueLastInst)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060068A4 RID: 26788 RVA: 0x000FD704 File Offset: 0x000FB904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterInstRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstanceId != 0)
			{
				this.InstanceId = other.InstanceId;
			}
			this.roleIds_.Add(other.roleIds_);
			if (other.EntranceId != 0)
			{
				this.EntranceId = other.EntranceId;
			}
			if (other.PosEntityId != 0)
			{
				this.PosEntityId = other.PosEntityId;
			}
			if (other.transitionOption_ != null)
			{
				if (this.transitionOption_ == null)
				{
					this.TransitionOption = new TransitionOptionPb();
				}
				this.TransitionOption.MergeFrom(other.TransitionOption);
			}
			this.towerDefencePhantomId_.Add(other.towerDefencePhantomId_);
			if (other.enterInstContext_ != null)
			{
				if (this.enterInstContext_ == null)
				{
					this.EnterInstContext = new EnterInstContext();
				}
				this.EnterInstContext.MergeFrom(other.EnterInstContext);
			}
			if (other.ContinueLastInst)
			{
				this.ContinueLastInst = other.ContinueLastInst;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060068A5 RID: 26789 RVA: 0x000FD7F6 File Offset: 0x000FB9F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060068A6 RID: 26790 RVA: 0x000FD800 File Offset: 0x000FBA00
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
				if (num <= 58U)
				{
					if (num <= 40U)
					{
						if (num == 16U)
						{
							this.ContinueLastInst = input.ReadBool();
							continue;
						}
						if (num != 40U)
						{
							goto IL_62;
						}
					}
					else if (num != 42U)
					{
						if (num == 48U)
						{
							this.EntranceId = input.ReadInt32();
							continue;
						}
						if (num != 58U)
						{
							goto IL_62;
						}
						if (this.enterInstContext_ == null)
						{
							this.EnterInstContext = new EnterInstContext();
						}
						input.ReadMessage(this.EnterInstContext);
						continue;
					}
					this.roleIds_.AddEntriesFrom(ref input, EnterInstRequest._repeated_roleIds_codec);
					continue;
				}
				if (num <= 104U)
				{
					if (num == 96U)
					{
						this.InstanceId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.PosEntityId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U || num == 114U)
					{
						this.towerDefencePhantomId_.AddEntriesFrom(ref input, EnterInstRequest._repeated_towerDefencePhantomId_codec);
						continue;
					}
					if (num == 122U)
					{
						if (this.transitionOption_ == null)
						{
							this.TransitionOption = new TransitionOptionPb();
						}
						input.ReadMessage(this.TransitionOption);
						continue;
					}
				}
				IL_62:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003A1F RID: 14879
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A20 RID: 14880
		public const int InstanceIdFieldNumber = 12;

		// Token: 0x04003A21 RID: 14881
		private int instanceId_;

		// Token: 0x04003A22 RID: 14882
		public const int RoleIdsFieldNumber = 5;

		// Token: 0x04003A23 RID: 14883
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04003A24 RID: 14884
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();

		// Token: 0x04003A25 RID: 14885
		public const int EntranceIdFieldNumber = 6;

		// Token: 0x04003A26 RID: 14886
		private int entranceId_;

		// Token: 0x04003A27 RID: 14887
		public const int PosEntityIdFieldNumber = 13;

		// Token: 0x04003A28 RID: 14888
		private int posEntityId_;

		// Token: 0x04003A29 RID: 14889
		public const int TransitionOptionFieldNumber = 15;

		// Token: 0x04003A2A RID: 14890
		private TransitionOptionPb transitionOption_;

		// Token: 0x04003A2B RID: 14891
		public const int TowerDefencePhantomIdFieldNumber = 14;

		// Token: 0x04003A2C RID: 14892
		private static readonly FieldCodec<int> _repeated_towerDefencePhantomId_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04003A2D RID: 14893
		private readonly RepeatedField<int> towerDefencePhantomId_ = new RepeatedField<int>();

		// Token: 0x04003A2E RID: 14894
		public const int EnterInstContextFieldNumber = 7;

		// Token: 0x04003A2F RID: 14895
		private EnterInstContext enterInstContext_;

		// Token: 0x04003A30 RID: 14896
		public const int ContinueLastInstFieldNumber = 2;

		// Token: 0x04003A31 RID: 14897
		private bool continueLastInst_;
	}
}
