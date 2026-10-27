using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000455 RID: 1109
	[NetMessage(EMessageId.EnterInstRequest)]
	public sealed class EnterInstRequest : IMessage<EnterInstRequest>, IMessage, IEquatable<EnterInstRequest>, IDeepCloneable<EnterInstRequest>, IBufferMessage
	{
		// Token: 0x06006A17 RID: 27159 RVA: 0x0010029E File Offset: 0x000FE49E
		[NullableContext(1)]
		public static EnterInstRequest Create()
		{
			return new EnterInstRequest();
		}

		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x06006A18 RID: 27160 RVA: 0x001002A5 File Offset: 0x000FE4A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x06006A19 RID: 27161 RVA: 0x001002A8 File Offset: 0x000FE4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterInstRequest.Descriptor;
			}
		}

		// Token: 0x06006A1A RID: 27162 RVA: 0x001002AF File Offset: 0x000FE4AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterInstRequest()
		{
		}

		// Token: 0x06006A1B RID: 27163 RVA: 0x001002D0 File Offset: 0x000FE4D0
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

		// Token: 0x06006A1C RID: 27164 RVA: 0x0010037E File Offset: 0x000FE57E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterInstRequest Clone()
		{
			return new EnterInstRequest(this);
		}

		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x06006A1D RID: 27165 RVA: 0x00100386 File Offset: 0x000FE586
		// (set) Token: 0x06006A1E RID: 27166 RVA: 0x0010038E File Offset: 0x000FE58E
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

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x06006A1F RID: 27167 RVA: 0x00100397 File Offset: 0x000FE597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x06006A20 RID: 27168 RVA: 0x0010039F File Offset: 0x000FE59F
		// (set) Token: 0x06006A21 RID: 27169 RVA: 0x001003A7 File Offset: 0x000FE5A7
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

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x06006A22 RID: 27170 RVA: 0x001003B0 File Offset: 0x000FE5B0
		// (set) Token: 0x06006A23 RID: 27171 RVA: 0x001003B8 File Offset: 0x000FE5B8
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

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x06006A24 RID: 27172 RVA: 0x001003C1 File Offset: 0x000FE5C1
		// (set) Token: 0x06006A25 RID: 27173 RVA: 0x001003C9 File Offset: 0x000FE5C9
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

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x06006A26 RID: 27174 RVA: 0x001003D2 File Offset: 0x000FE5D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TowerDefencePhantomId
		{
			get
			{
				return this.towerDefencePhantomId_;
			}
		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x06006A27 RID: 27175 RVA: 0x001003DA File Offset: 0x000FE5DA
		// (set) Token: 0x06006A28 RID: 27176 RVA: 0x001003E2 File Offset: 0x000FE5E2
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

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x06006A29 RID: 27177 RVA: 0x001003EB File Offset: 0x000FE5EB
		// (set) Token: 0x06006A2A RID: 27178 RVA: 0x001003F3 File Offset: 0x000FE5F3
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

		// Token: 0x06006A2B RID: 27179 RVA: 0x001003FC File Offset: 0x000FE5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterInstRequest);
		}

		// Token: 0x06006A2C RID: 27180 RVA: 0x0010040C File Offset: 0x000FE60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterInstRequest other)
		{
			return other != null && (other == this || (this.InstanceId == other.InstanceId && this.roleIds_.Equals(other.roleIds_) && this.EntranceId == other.EntranceId && this.PosEntityId == other.PosEntityId && object.Equals(this.TransitionOption, other.TransitionOption) && this.towerDefencePhantomId_.Equals(other.towerDefencePhantomId_) && object.Equals(this.EnterInstContext, other.EnterInstContext) && this.ContinueLastInst == other.ContinueLastInst && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006A2D RID: 27181 RVA: 0x001004CC File Offset: 0x000FE6CC
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

		// Token: 0x06006A2E RID: 27182 RVA: 0x0010059E File Offset: 0x000FE79E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006A2F RID: 27183 RVA: 0x001005AB File Offset: 0x000FE7AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A30 RID: 27184 RVA: 0x001005B4 File Offset: 0x000FE7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.enterInstContext_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.EnterInstContext);
			}
			this.towerDefencePhantomId_.WriteTo(ref output, EnterInstRequest._repeated_towerDefencePhantomId_codec);
			if (this.PosEntityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PosEntityId);
			}
			if (this.ContinueLastInst)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.ContinueLastInst);
			}
			this.roleIds_.WriteTo(ref output, EnterInstRequest._repeated_roleIds_codec);
			if (this.InstanceId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.InstanceId);
			}
			if (this.transitionOption_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.TransitionOption);
			}
			if (this.EntranceId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.EntranceId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A31 RID: 27185 RVA: 0x001006A0 File Offset: 0x000FE8A0
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

		// Token: 0x06006A32 RID: 27186 RVA: 0x00100770 File Offset: 0x000FE970
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

		// Token: 0x06006A33 RID: 27187 RVA: 0x00100862 File Offset: 0x000FEA62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A34 RID: 27188 RVA: 0x0010086C File Offset: 0x000FEA6C
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
				if (num <= 56U)
				{
					if (num <= 32U)
					{
						if (num == 26U)
						{
							if (this.enterInstContext_ == null)
							{
								this.EnterInstContext = new EnterInstContext();
							}
							input.ReadMessage(this.EnterInstContext);
							continue;
						}
						if (num != 32U)
						{
							goto IL_6B;
						}
					}
					else if (num != 34U)
					{
						if (num == 48U)
						{
							this.PosEntityId = input.ReadInt32();
							continue;
						}
						if (num != 56U)
						{
							goto IL_6B;
						}
						this.ContinueLastInst = input.ReadBool();
						continue;
					}
					this.towerDefencePhantomId_.AddEntriesFrom(ref input, EnterInstRequest._repeated_towerDefencePhantomId_codec);
					continue;
				}
				if (num <= 66U)
				{
					if (num == 64U || num == 66U)
					{
						this.roleIds_.AddEntriesFrom(ref input, EnterInstRequest._repeated_roleIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.InstanceId = input.ReadInt32();
						continue;
					}
					if (num == 114U)
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
						this.EntranceId = input.ReadInt32();
						continue;
					}
				}
				IL_6B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003A31 RID: 14897
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A32 RID: 14898
		public const int InstanceIdFieldNumber = 10;

		// Token: 0x04003A33 RID: 14899
		private int instanceId_;

		// Token: 0x04003A34 RID: 14900
		public const int RoleIdsFieldNumber = 8;

		// Token: 0x04003A35 RID: 14901
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04003A36 RID: 14902
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();

		// Token: 0x04003A37 RID: 14903
		public const int EntranceIdFieldNumber = 15;

		// Token: 0x04003A38 RID: 14904
		private int entranceId_;

		// Token: 0x04003A39 RID: 14905
		public const int PosEntityIdFieldNumber = 6;

		// Token: 0x04003A3A RID: 14906
		private int posEntityId_;

		// Token: 0x04003A3B RID: 14907
		public const int TransitionOptionFieldNumber = 14;

		// Token: 0x04003A3C RID: 14908
		private TransitionOptionPb transitionOption_;

		// Token: 0x04003A3D RID: 14909
		public const int TowerDefencePhantomIdFieldNumber = 4;

		// Token: 0x04003A3E RID: 14910
		private static readonly FieldCodec<int> _repeated_towerDefencePhantomId_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04003A3F RID: 14911
		private readonly RepeatedField<int> towerDefencePhantomId_ = new RepeatedField<int>();

		// Token: 0x04003A40 RID: 14912
		public const int EnterInstContextFieldNumber = 3;

		// Token: 0x04003A41 RID: 14913
		private EnterInstContext enterInstContext_;

		// Token: 0x04003A42 RID: 14914
		public const int ContinueLastInstFieldNumber = 7;

		// Token: 0x04003A43 RID: 14915
		private bool continueLastInst_;
	}
}
