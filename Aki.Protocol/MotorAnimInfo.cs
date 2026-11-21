using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A0C RID: 2572
	public sealed class MotorAnimInfo : IMessage<MotorAnimInfo>, IMessage, IEquatable<MotorAnimInfo>, IDeepCloneable<MotorAnimInfo>, IBufferMessage
	{
		// Token: 0x0600E14F RID: 57679 RVA: 0x002105A1 File Offset: 0x0020E7A1
		[NullableContext(1)]
		public static MotorAnimInfo Create()
		{
			return new MotorAnimInfo();
		}

		// Token: 0x17002DAD RID: 11693
		// (get) Token: 0x0600E150 RID: 57680 RVA: 0x002105A8 File Offset: 0x0020E7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorAnimInfo> Parser
		{
			get
			{
				return MotorAnimInfo._parser;
			}
		}

		// Token: 0x17002DAE RID: 11694
		// (get) Token: 0x0600E151 RID: 57681 RVA: 0x002105AF File Offset: 0x0020E7AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DAF RID: 11695
		// (get) Token: 0x0600E152 RID: 57682 RVA: 0x002105B2 File Offset: 0x0020E7B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorAnimInfo.Descriptor;
			}
		}

		// Token: 0x0600E153 RID: 57683 RVA: 0x002105B9 File Offset: 0x0020E7B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorAnimInfo()
		{
		}

		// Token: 0x0600E154 RID: 57684 RVA: 0x002105C4 File Offset: 0x0020E7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorAnimInfo(MotorAnimInfo other) : this()
		{
			this.frontWheelInfo_ = ((other.frontWheelInfo_ != null) ? other.frontWheelInfo_.Clone() : null);
			this.backWheelInfo_ = ((other.backWheelInfo_ != null) ? other.backWheelInfo_.Clone() : null);
			this.isBeingImpacted_ = other.isBeingImpacted_;
			this.impactedVelocity_ = ((other.impactedVelocity_ != null) ? other.impactedVelocity_.Clone() : null);
			this.impactedNormal_ = ((other.impactedNormal_ != null) ? other.impactedNormal_.Clone() : null);
			this.moveMix_ = ((other.moveMix_ != null) ? other.moveMix_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E155 RID: 57685 RVA: 0x00210680 File Offset: 0x0020E880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorAnimInfo Clone()
		{
			return new MotorAnimInfo(this);
		}

		// Token: 0x17002DB0 RID: 11696
		// (get) Token: 0x0600E156 RID: 57686 RVA: 0x00210688 File Offset: 0x0020E888
		// (set) Token: 0x0600E157 RID: 57687 RVA: 0x00210690 File Offset: 0x0020E890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorWheelInfo FrontWheelInfo
		{
			get
			{
				return this.frontWheelInfo_;
			}
			set
			{
				this.frontWheelInfo_ = value;
			}
		}

		// Token: 0x17002DB1 RID: 11697
		// (get) Token: 0x0600E158 RID: 57688 RVA: 0x00210699 File Offset: 0x0020E899
		// (set) Token: 0x0600E159 RID: 57689 RVA: 0x002106A1 File Offset: 0x0020E8A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorWheelInfo BackWheelInfo
		{
			get
			{
				return this.backWheelInfo_;
			}
			set
			{
				this.backWheelInfo_ = value;
			}
		}

		// Token: 0x17002DB2 RID: 11698
		// (get) Token: 0x0600E15A RID: 57690 RVA: 0x002106AA File Offset: 0x0020E8AA
		// (set) Token: 0x0600E15B RID: 57691 RVA: 0x002106B2 File Offset: 0x0020E8B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsBeingImpacted
		{
			get
			{
				return this.isBeingImpacted_;
			}
			set
			{
				this.isBeingImpacted_ = value;
			}
		}

		// Token: 0x17002DB3 RID: 11699
		// (get) Token: 0x0600E15C RID: 57692 RVA: 0x002106BB File Offset: 0x0020E8BB
		// (set) Token: 0x0600E15D RID: 57693 RVA: 0x002106C3 File Offset: 0x0020E8C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector ImpactedVelocity
		{
			get
			{
				return this.impactedVelocity_;
			}
			set
			{
				this.impactedVelocity_ = value;
			}
		}

		// Token: 0x17002DB4 RID: 11700
		// (get) Token: 0x0600E15E RID: 57694 RVA: 0x002106CC File Offset: 0x0020E8CC
		// (set) Token: 0x0600E15F RID: 57695 RVA: 0x002106D4 File Offset: 0x0020E8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector ImpactedNormal
		{
			get
			{
				return this.impactedNormal_;
			}
			set
			{
				this.impactedNormal_ = value;
			}
		}

		// Token: 0x17002DB5 RID: 11701
		// (get) Token: 0x0600E160 RID: 57696 RVA: 0x002106DD File Offset: 0x0020E8DD
		// (set) Token: 0x0600E161 RID: 57697 RVA: 0x002106E5 File Offset: 0x0020E8E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector MoveMix
		{
			get
			{
				return this.moveMix_;
			}
			set
			{
				this.moveMix_ = value;
			}
		}

		// Token: 0x0600E162 RID: 57698 RVA: 0x002106EE File Offset: 0x0020E8EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorAnimInfo);
		}

		// Token: 0x0600E163 RID: 57699 RVA: 0x002106FC File Offset: 0x0020E8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorAnimInfo other)
		{
			return other != null && (other == this || (object.Equals(this.FrontWheelInfo, other.FrontWheelInfo) && object.Equals(this.BackWheelInfo, other.BackWheelInfo) && this.IsBeingImpacted == other.IsBeingImpacted && object.Equals(this.ImpactedVelocity, other.ImpactedVelocity) && object.Equals(this.ImpactedNormal, other.ImpactedNormal) && object.Equals(this.MoveMix, other.MoveMix) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E164 RID: 57700 RVA: 0x002107A0 File Offset: 0x0020E9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.frontWheelInfo_ != null)
			{
				num ^= this.FrontWheelInfo.GetHashCode();
			}
			if (this.backWheelInfo_ != null)
			{
				num ^= this.BackWheelInfo.GetHashCode();
			}
			if (this.IsBeingImpacted)
			{
				num ^= this.IsBeingImpacted.GetHashCode();
			}
			if (this.impactedVelocity_ != null)
			{
				num ^= this.ImpactedVelocity.GetHashCode();
			}
			if (this.impactedNormal_ != null)
			{
				num ^= this.ImpactedNormal.GetHashCode();
			}
			if (this.moveMix_ != null)
			{
				num ^= this.MoveMix.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E165 RID: 57701 RVA: 0x0021084D File Offset: 0x0020EA4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E166 RID: 57702 RVA: 0x0021085A File Offset: 0x0020EA5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E167 RID: 57703 RVA: 0x00210864 File Offset: 0x0020EA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.frontWheelInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.FrontWheelInfo);
			}
			if (this.backWheelInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.BackWheelInfo);
			}
			if (this.IsBeingImpacted)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsBeingImpacted);
			}
			if (this.impactedVelocity_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ImpactedVelocity);
			}
			if (this.impactedNormal_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ImpactedNormal);
			}
			if (this.moveMix_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.MoveMix);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E168 RID: 57704 RVA: 0x00210930 File Offset: 0x0020EB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.frontWheelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FrontWheelInfo);
			}
			if (this.backWheelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BackWheelInfo);
			}
			if (this.IsBeingImpacted)
			{
				num += 2;
			}
			if (this.impactedVelocity_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ImpactedVelocity);
			}
			if (this.impactedNormal_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ImpactedNormal);
			}
			if (this.moveMix_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MoveMix);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E169 RID: 57705 RVA: 0x002109DC File Offset: 0x0020EBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorAnimInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.frontWheelInfo_ != null)
			{
				if (this.frontWheelInfo_ == null)
				{
					this.FrontWheelInfo = new MotorWheelInfo();
				}
				this.FrontWheelInfo.MergeFrom(other.FrontWheelInfo);
			}
			if (other.backWheelInfo_ != null)
			{
				if (this.backWheelInfo_ == null)
				{
					this.BackWheelInfo = new MotorWheelInfo();
				}
				this.BackWheelInfo.MergeFrom(other.BackWheelInfo);
			}
			if (other.IsBeingImpacted)
			{
				this.IsBeingImpacted = other.IsBeingImpacted;
			}
			if (other.impactedVelocity_ != null)
			{
				if (this.impactedVelocity_ == null)
				{
					this.ImpactedVelocity = new Vector();
				}
				this.ImpactedVelocity.MergeFrom(other.ImpactedVelocity);
			}
			if (other.impactedNormal_ != null)
			{
				if (this.impactedNormal_ == null)
				{
					this.ImpactedNormal = new Vector();
				}
				this.ImpactedNormal.MergeFrom(other.ImpactedNormal);
			}
			if (other.moveMix_ != null)
			{
				if (this.moveMix_ == null)
				{
					this.MoveMix = new Vector();
				}
				this.MoveMix.MergeFrom(other.MoveMix);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E16A RID: 57706 RVA: 0x00210AF4 File Offset: 0x0020ECF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E16B RID: 57707 RVA: 0x00210B00 File Offset: 0x0020ED00
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
				if (num <= 24U)
				{
					if (num == 10U)
					{
						if (this.frontWheelInfo_ == null)
						{
							this.FrontWheelInfo = new MotorWheelInfo();
						}
						input.ReadMessage(this.FrontWheelInfo);
						continue;
					}
					if (num == 18U)
					{
						if (this.backWheelInfo_ == null)
						{
							this.BackWheelInfo = new MotorWheelInfo();
						}
						input.ReadMessage(this.BackWheelInfo);
						continue;
					}
					if (num == 24U)
					{
						this.IsBeingImpacted = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						if (this.impactedVelocity_ == null)
						{
							this.ImpactedVelocity = new Vector();
						}
						input.ReadMessage(this.ImpactedVelocity);
						continue;
					}
					if (num == 42U)
					{
						if (this.impactedNormal_ == null)
						{
							this.ImpactedNormal = new Vector();
						}
						input.ReadMessage(this.ImpactedNormal);
						continue;
					}
					if (num == 50U)
					{
						if (this.moveMix_ == null)
						{
							this.MoveMix = new Vector();
						}
						input.ReadMessage(this.MoveMix);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005CFD RID: 23805
		private static readonly MessageParser<MotorAnimInfo> _parser = new MessageParser<MotorAnimInfo>(() => new MotorAnimInfo());

		// Token: 0x04005CFE RID: 23806
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005CFF RID: 23807
		public const int FrontWheelInfoFieldNumber = 1;

		// Token: 0x04005D00 RID: 23808
		private MotorWheelInfo frontWheelInfo_;

		// Token: 0x04005D01 RID: 23809
		public const int BackWheelInfoFieldNumber = 2;

		// Token: 0x04005D02 RID: 23810
		private MotorWheelInfo backWheelInfo_;

		// Token: 0x04005D03 RID: 23811
		public const int IsBeingImpactedFieldNumber = 3;

		// Token: 0x04005D04 RID: 23812
		private bool isBeingImpacted_;

		// Token: 0x04005D05 RID: 23813
		public const int ImpactedVelocityFieldNumber = 4;

		// Token: 0x04005D06 RID: 23814
		private Vector impactedVelocity_;

		// Token: 0x04005D07 RID: 23815
		public const int ImpactedNormalFieldNumber = 5;

		// Token: 0x04005D08 RID: 23816
		private Vector impactedNormal_;

		// Token: 0x04005D09 RID: 23817
		public const int MoveMixFieldNumber = 6;

		// Token: 0x04005D0A RID: 23818
		private Vector moveMix_;
	}
}
