using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A1D RID: 2589
	public sealed class MotorAnimInfo : IMessage<MotorAnimInfo>, IMessage, IEquatable<MotorAnimInfo>, IDeepCloneable<MotorAnimInfo>, IBufferMessage
	{
		// Token: 0x0600E269 RID: 57961 RVA: 0x00212795 File Offset: 0x00210995
		[NullableContext(1)]
		public static MotorAnimInfo Create()
		{
			return new MotorAnimInfo();
		}

		// Token: 0x17002DEB RID: 11755
		// (get) Token: 0x0600E26A RID: 57962 RVA: 0x0021279C File Offset: 0x0021099C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorAnimInfo> Parser
		{
			get
			{
				return MotorAnimInfo._parser;
			}
		}

		// Token: 0x17002DEC RID: 11756
		// (get) Token: 0x0600E26B RID: 57963 RVA: 0x002127A3 File Offset: 0x002109A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DED RID: 11757
		// (get) Token: 0x0600E26C RID: 57964 RVA: 0x002127A6 File Offset: 0x002109A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorAnimInfo.Descriptor;
			}
		}

		// Token: 0x0600E26D RID: 57965 RVA: 0x002127AD File Offset: 0x002109AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorAnimInfo()
		{
		}

		// Token: 0x0600E26E RID: 57966 RVA: 0x002127B8 File Offset: 0x002109B8
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

		// Token: 0x0600E26F RID: 57967 RVA: 0x00212874 File Offset: 0x00210A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorAnimInfo Clone()
		{
			return new MotorAnimInfo(this);
		}

		// Token: 0x17002DEE RID: 11758
		// (get) Token: 0x0600E270 RID: 57968 RVA: 0x0021287C File Offset: 0x00210A7C
		// (set) Token: 0x0600E271 RID: 57969 RVA: 0x00212884 File Offset: 0x00210A84
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

		// Token: 0x17002DEF RID: 11759
		// (get) Token: 0x0600E272 RID: 57970 RVA: 0x0021288D File Offset: 0x00210A8D
		// (set) Token: 0x0600E273 RID: 57971 RVA: 0x00212895 File Offset: 0x00210A95
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

		// Token: 0x17002DF0 RID: 11760
		// (get) Token: 0x0600E274 RID: 57972 RVA: 0x0021289E File Offset: 0x00210A9E
		// (set) Token: 0x0600E275 RID: 57973 RVA: 0x002128A6 File Offset: 0x00210AA6
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

		// Token: 0x17002DF1 RID: 11761
		// (get) Token: 0x0600E276 RID: 57974 RVA: 0x002128AF File Offset: 0x00210AAF
		// (set) Token: 0x0600E277 RID: 57975 RVA: 0x002128B7 File Offset: 0x00210AB7
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

		// Token: 0x17002DF2 RID: 11762
		// (get) Token: 0x0600E278 RID: 57976 RVA: 0x002128C0 File Offset: 0x00210AC0
		// (set) Token: 0x0600E279 RID: 57977 RVA: 0x002128C8 File Offset: 0x00210AC8
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

		// Token: 0x17002DF3 RID: 11763
		// (get) Token: 0x0600E27A RID: 57978 RVA: 0x002128D1 File Offset: 0x00210AD1
		// (set) Token: 0x0600E27B RID: 57979 RVA: 0x002128D9 File Offset: 0x00210AD9
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

		// Token: 0x0600E27C RID: 57980 RVA: 0x002128E2 File Offset: 0x00210AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorAnimInfo);
		}

		// Token: 0x0600E27D RID: 57981 RVA: 0x002128F0 File Offset: 0x00210AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorAnimInfo other)
		{
			return other != null && (other == this || (object.Equals(this.FrontWheelInfo, other.FrontWheelInfo) && object.Equals(this.BackWheelInfo, other.BackWheelInfo) && this.IsBeingImpacted == other.IsBeingImpacted && object.Equals(this.ImpactedVelocity, other.ImpactedVelocity) && object.Equals(this.ImpactedNormal, other.ImpactedNormal) && object.Equals(this.MoveMix, other.MoveMix) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E27E RID: 57982 RVA: 0x00212994 File Offset: 0x00210B94
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

		// Token: 0x0600E27F RID: 57983 RVA: 0x00212A41 File Offset: 0x00210C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E280 RID: 57984 RVA: 0x00212A4E File Offset: 0x00210C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E281 RID: 57985 RVA: 0x00212A58 File Offset: 0x00210C58
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

		// Token: 0x0600E282 RID: 57986 RVA: 0x00212B24 File Offset: 0x00210D24
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

		// Token: 0x0600E283 RID: 57987 RVA: 0x00212BD0 File Offset: 0x00210DD0
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

		// Token: 0x0600E284 RID: 57988 RVA: 0x00212CE8 File Offset: 0x00210EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E285 RID: 57989 RVA: 0x00212CF4 File Offset: 0x00210EF4
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

		// Token: 0x04005CF4 RID: 23796
		private static readonly MessageParser<MotorAnimInfo> _parser = new MessageParser<MotorAnimInfo>(() => new MotorAnimInfo());

		// Token: 0x04005CF5 RID: 23797
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005CF6 RID: 23798
		public const int FrontWheelInfoFieldNumber = 1;

		// Token: 0x04005CF7 RID: 23799
		private MotorWheelInfo frontWheelInfo_;

		// Token: 0x04005CF8 RID: 23800
		public const int BackWheelInfoFieldNumber = 2;

		// Token: 0x04005CF9 RID: 23801
		private MotorWheelInfo backWheelInfo_;

		// Token: 0x04005CFA RID: 23802
		public const int IsBeingImpactedFieldNumber = 3;

		// Token: 0x04005CFB RID: 23803
		private bool isBeingImpacted_;

		// Token: 0x04005CFC RID: 23804
		public const int ImpactedVelocityFieldNumber = 4;

		// Token: 0x04005CFD RID: 23805
		private Vector impactedVelocity_;

		// Token: 0x04005CFE RID: 23806
		public const int ImpactedNormalFieldNumber = 5;

		// Token: 0x04005CFF RID: 23807
		private Vector impactedNormal_;

		// Token: 0x04005D00 RID: 23808
		public const int MoveMixFieldNumber = 6;

		// Token: 0x04005D01 RID: 23809
		private Vector moveMix_;
	}
}
