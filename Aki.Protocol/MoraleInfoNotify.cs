using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A17 RID: 2583
	[NetMessage(EMessageId.MoraleInfoNotify)]
	public sealed class MoraleInfoNotify : IMessage<MoraleInfoNotify>, IMessage, IEquatable<MoraleInfoNotify>, IDeepCloneable<MoraleInfoNotify>, IBufferMessage
	{
		// Token: 0x0600E1E6 RID: 57830 RVA: 0x0021149F File Offset: 0x0020F69F
		[NullableContext(1)]
		public static MoraleInfoNotify Create()
		{
			return new MoraleInfoNotify();
		}

		// Token: 0x17002DCD RID: 11725
		// (get) Token: 0x0600E1E7 RID: 57831 RVA: 0x002114A6 File Offset: 0x0020F6A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DCE RID: 11726
		// (get) Token: 0x0600E1E8 RID: 57832 RVA: 0x002114A9 File Offset: 0x0020F6A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoraleInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600E1E9 RID: 57833 RVA: 0x002114B0 File Offset: 0x0020F6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleInfoNotify()
		{
		}

		// Token: 0x0600E1EA RID: 57834 RVA: 0x002114B8 File Offset: 0x0020F6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleInfoNotify(MoraleInfoNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.isStart_ = other.isStart_;
			this.moraleConfigId_ = other.moraleConfigId_;
			this.indomitableLevel_ = other.indomitableLevel_;
			this.keepMoraleLevel_ = other.keepMoraleLevel_;
			this.keepMoraleExp_ = other.keepMoraleExp_;
			this.tempMoraleLevel_ = other.tempMoraleLevel_;
			this.tempMoraleExp_ = other.tempMoraleExp_;
			this.expRatio_ = other.expRatio_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E1EB RID: 57835 RVA: 0x00211554 File Offset: 0x0020F754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleInfoNotify Clone()
		{
			return new MoraleInfoNotify(this);
		}

		// Token: 0x17002DCF RID: 11727
		// (get) Token: 0x0600E1EC RID: 57836 RVA: 0x0021155C File Offset: 0x0020F75C
		// (set) Token: 0x0600E1ED RID: 57837 RVA: 0x00211564 File Offset: 0x0020F764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17002DD0 RID: 11728
		// (get) Token: 0x0600E1EE RID: 57838 RVA: 0x0021156D File Offset: 0x0020F76D
		// (set) Token: 0x0600E1EF RID: 57839 RVA: 0x00211575 File Offset: 0x0020F775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsStart
		{
			get
			{
				return this.isStart_;
			}
			set
			{
				this.isStart_ = value;
			}
		}

		// Token: 0x17002DD1 RID: 11729
		// (get) Token: 0x0600E1F0 RID: 57840 RVA: 0x0021157E File Offset: 0x0020F77E
		// (set) Token: 0x0600E1F1 RID: 57841 RVA: 0x00211586 File Offset: 0x0020F786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MoraleConfigId
		{
			get
			{
				return this.moraleConfigId_;
			}
			set
			{
				this.moraleConfigId_ = value;
			}
		}

		// Token: 0x17002DD2 RID: 11730
		// (get) Token: 0x0600E1F2 RID: 57842 RVA: 0x0021158F File Offset: 0x0020F78F
		// (set) Token: 0x0600E1F3 RID: 57843 RVA: 0x00211597 File Offset: 0x0020F797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IndomitableLevel
		{
			get
			{
				return this.indomitableLevel_;
			}
			set
			{
				this.indomitableLevel_ = value;
			}
		}

		// Token: 0x17002DD3 RID: 11731
		// (get) Token: 0x0600E1F4 RID: 57844 RVA: 0x002115A0 File Offset: 0x0020F7A0
		// (set) Token: 0x0600E1F5 RID: 57845 RVA: 0x002115A8 File Offset: 0x0020F7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int KeepMoraleLevel
		{
			get
			{
				return this.keepMoraleLevel_;
			}
			set
			{
				this.keepMoraleLevel_ = value;
			}
		}

		// Token: 0x17002DD4 RID: 11732
		// (get) Token: 0x0600E1F6 RID: 57846 RVA: 0x002115B1 File Offset: 0x0020F7B1
		// (set) Token: 0x0600E1F7 RID: 57847 RVA: 0x002115B9 File Offset: 0x0020F7B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int KeepMoraleExp
		{
			get
			{
				return this.keepMoraleExp_;
			}
			set
			{
				this.keepMoraleExp_ = value;
			}
		}

		// Token: 0x17002DD5 RID: 11733
		// (get) Token: 0x0600E1F8 RID: 57848 RVA: 0x002115C2 File Offset: 0x0020F7C2
		// (set) Token: 0x0600E1F9 RID: 57849 RVA: 0x002115CA File Offset: 0x0020F7CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TempMoraleLevel
		{
			get
			{
				return this.tempMoraleLevel_;
			}
			set
			{
				this.tempMoraleLevel_ = value;
			}
		}

		// Token: 0x17002DD6 RID: 11734
		// (get) Token: 0x0600E1FA RID: 57850 RVA: 0x002115D3 File Offset: 0x0020F7D3
		// (set) Token: 0x0600E1FB RID: 57851 RVA: 0x002115DB File Offset: 0x0020F7DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TempMoraleExp
		{
			get
			{
				return this.tempMoraleExp_;
			}
			set
			{
				this.tempMoraleExp_ = value;
			}
		}

		// Token: 0x17002DD7 RID: 11735
		// (get) Token: 0x0600E1FC RID: 57852 RVA: 0x002115E4 File Offset: 0x0020F7E4
		// (set) Token: 0x0600E1FD RID: 57853 RVA: 0x002115EC File Offset: 0x0020F7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExpRatio
		{
			get
			{
				return this.expRatio_;
			}
			set
			{
				this.expRatio_ = value;
			}
		}

		// Token: 0x17002DD8 RID: 11736
		// (get) Token: 0x0600E1FE RID: 57854 RVA: 0x002115F5 File Offset: 0x0020F7F5
		// (set) Token: 0x0600E1FF RID: 57855 RVA: 0x002115FD File Offset: 0x0020F7FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x0600E200 RID: 57856 RVA: 0x00211606 File Offset: 0x0020F806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoraleInfoNotify);
		}

		// Token: 0x0600E201 RID: 57857 RVA: 0x00211614 File Offset: 0x0020F814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoraleInfoNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IsStart == other.IsStart && this.MoraleConfigId == other.MoraleConfigId && this.IndomitableLevel == other.IndomitableLevel && this.KeepMoraleLevel == other.KeepMoraleLevel && this.KeepMoraleExp == other.KeepMoraleExp && this.TempMoraleLevel == other.TempMoraleLevel && this.TempMoraleExp == other.TempMoraleExp && this.ExpRatio == other.ExpRatio && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E202 RID: 57858 RVA: 0x002116E0 File Offset: 0x0020F8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.IsStart)
			{
				num ^= this.IsStart.GetHashCode();
			}
			if (this.MoraleConfigId != 0)
			{
				num ^= this.MoraleConfigId.GetHashCode();
			}
			if (this.IndomitableLevel != 0)
			{
				num ^= this.IndomitableLevel.GetHashCode();
			}
			if (this.KeepMoraleLevel != 0)
			{
				num ^= this.KeepMoraleLevel.GetHashCode();
			}
			if (this.KeepMoraleExp != 0)
			{
				num ^= this.KeepMoraleExp.GetHashCode();
			}
			if (this.TempMoraleLevel != 0)
			{
				num ^= this.TempMoraleLevel.GetHashCode();
			}
			if (this.TempMoraleExp != 0)
			{
				num ^= this.TempMoraleExp.GetHashCode();
			}
			if (this.ExpRatio != 0)
			{
				num ^= this.ExpRatio.GetHashCode();
			}
			if (this.Reason != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E203 RID: 57859 RVA: 0x00211800 File Offset: 0x0020FA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E204 RID: 57860 RVA: 0x0021180D File Offset: 0x0020FA0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E205 RID: 57861 RVA: 0x00211818 File Offset: 0x0020FA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KeepMoraleLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.KeepMoraleLevel);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Reason != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Reason);
			}
			if (this.TempMoraleLevel != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TempMoraleLevel);
			}
			if (this.MoraleConfigId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.MoraleConfigId);
			}
			if (this.IsStart)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsStart);
			}
			if (this.KeepMoraleExp != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.KeepMoraleExp);
			}
			if (this.TempMoraleExp != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.TempMoraleExp);
			}
			if (this.ExpRatio != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ExpRatio);
			}
			if (this.IndomitableLevel != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.IndomitableLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E206 RID: 57862 RVA: 0x00211954 File Offset: 0x0020FB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.IsStart)
			{
				num += 2;
			}
			if (this.MoraleConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MoraleConfigId);
			}
			if (this.IndomitableLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IndomitableLevel);
			}
			if (this.KeepMoraleLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.KeepMoraleLevel);
			}
			if (this.KeepMoraleExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.KeepMoraleExp);
			}
			if (this.TempMoraleLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TempMoraleLevel);
			}
			if (this.TempMoraleExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TempMoraleExp);
			}
			if (this.ExpRatio != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExpRatio);
			}
			if (this.Reason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E207 RID: 57863 RVA: 0x00211A60 File Offset: 0x0020FC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoraleInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.IsStart)
			{
				this.IsStart = other.IsStart;
			}
			if (other.MoraleConfigId != 0)
			{
				this.MoraleConfigId = other.MoraleConfigId;
			}
			if (other.IndomitableLevel != 0)
			{
				this.IndomitableLevel = other.IndomitableLevel;
			}
			if (other.KeepMoraleLevel != 0)
			{
				this.KeepMoraleLevel = other.KeepMoraleLevel;
			}
			if (other.KeepMoraleExp != 0)
			{
				this.KeepMoraleExp = other.KeepMoraleExp;
			}
			if (other.TempMoraleLevel != 0)
			{
				this.TempMoraleLevel = other.TempMoraleLevel;
			}
			if (other.TempMoraleExp != 0)
			{
				this.TempMoraleExp = other.TempMoraleExp;
			}
			if (other.ExpRatio != 0)
			{
				this.ExpRatio = other.ExpRatio;
			}
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E208 RID: 57864 RVA: 0x00211B50 File Offset: 0x0020FD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E209 RID: 57865 RVA: 0x00211B5C File Offset: 0x0020FD5C
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
					if (num <= 24U)
					{
						if (num == 16U)
						{
							this.KeepMoraleLevel = input.ReadInt32();
							continue;
						}
						if (num == 24U)
						{
							this.PlayerId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.Reason = input.ReadInt32();
							continue;
						}
						if (num == 48U)
						{
							this.TempMoraleLevel = input.ReadInt32();
							continue;
						}
						if (num == 56U)
						{
							this.MoraleConfigId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 80U)
					{
						this.IsStart = input.ReadBool();
						continue;
					}
					if (num == 88U)
					{
						this.KeepMoraleExp = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.TempMoraleExp = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.ExpRatio = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.IndomitableLevel = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005CC9 RID: 23753
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005CCA RID: 23754
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x04005CCB RID: 23755
		private int playerId_;

		// Token: 0x04005CCC RID: 23756
		public const int IsStartFieldNumber = 10;

		// Token: 0x04005CCD RID: 23757
		private bool isStart_;

		// Token: 0x04005CCE RID: 23758
		public const int MoraleConfigIdFieldNumber = 7;

		// Token: 0x04005CCF RID: 23759
		private int moraleConfigId_;

		// Token: 0x04005CD0 RID: 23760
		public const int IndomitableLevelFieldNumber = 15;

		// Token: 0x04005CD1 RID: 23761
		private int indomitableLevel_;

		// Token: 0x04005CD2 RID: 23762
		public const int KeepMoraleLevelFieldNumber = 2;

		// Token: 0x04005CD3 RID: 23763
		private int keepMoraleLevel_;

		// Token: 0x04005CD4 RID: 23764
		public const int KeepMoraleExpFieldNumber = 11;

		// Token: 0x04005CD5 RID: 23765
		private int keepMoraleExp_;

		// Token: 0x04005CD6 RID: 23766
		public const int TempMoraleLevelFieldNumber = 6;

		// Token: 0x04005CD7 RID: 23767
		private int tempMoraleLevel_;

		// Token: 0x04005CD8 RID: 23768
		public const int TempMoraleExpFieldNumber = 13;

		// Token: 0x04005CD9 RID: 23769
		private int tempMoraleExp_;

		// Token: 0x04005CDA RID: 23770
		public const int ExpRatioFieldNumber = 14;

		// Token: 0x04005CDB RID: 23771
		private int expRatio_;

		// Token: 0x04005CDC RID: 23772
		public const int ReasonFieldNumber = 4;

		// Token: 0x04005CDD RID: 23773
		private int reason_;
	}
}
