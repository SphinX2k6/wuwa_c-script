using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007F6 RID: 2038
	public sealed class InfrV2FirePb : IMessage<InfrV2FirePb>, IMessage, IEquatable<InfrV2FirePb>, IDeepCloneable<InfrV2FirePb>, IBufferMessage
	{
		// Token: 0x0600B6A6 RID: 46758 RVA: 0x001B3D64 File Offset: 0x001B1F64
		[NullableContext(1)]
		public static InfrV2FirePb Create()
		{
			return new InfrV2FirePb();
		}

		// Token: 0x170024D3 RID: 9427
		// (get) Token: 0x0600B6A7 RID: 46759 RVA: 0x001B3D6B File Offset: 0x001B1F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024D4 RID: 9428
		// (get) Token: 0x0600B6A8 RID: 46760 RVA: 0x001B3D6E File Offset: 0x001B1F6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2FirePb.Descriptor;
			}
		}

		// Token: 0x0600B6A9 RID: 46761 RVA: 0x001B3D75 File Offset: 0x001B1F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2FirePb()
		{
		}

		// Token: 0x0600B6AA RID: 46762 RVA: 0x001B3D80 File Offset: 0x001B1F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2FirePb(InfrV2FirePb other) : this()
		{
			this.fireExp_ = other.fireExp_;
			this.fireLevel_ = other.fireLevel_;
			this.fireLevelReachTime_ = other.fireLevelReachTime_;
			this.fireStatus_ = other.fireStatus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B6AB RID: 46763 RVA: 0x001B3DD4 File Offset: 0x001B1FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2FirePb Clone()
		{
			return new InfrV2FirePb(this);
		}

		// Token: 0x170024D5 RID: 9429
		// (get) Token: 0x0600B6AC RID: 46764 RVA: 0x001B3DDC File Offset: 0x001B1FDC
		// (set) Token: 0x0600B6AD RID: 46765 RVA: 0x001B3DE4 File Offset: 0x001B1FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FireExp
		{
			get
			{
				return this.fireExp_;
			}
			set
			{
				this.fireExp_ = value;
			}
		}

		// Token: 0x170024D6 RID: 9430
		// (get) Token: 0x0600B6AE RID: 46766 RVA: 0x001B3DED File Offset: 0x001B1FED
		// (set) Token: 0x0600B6AF RID: 46767 RVA: 0x001B3DF5 File Offset: 0x001B1FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FireLevel
		{
			get
			{
				return this.fireLevel_;
			}
			set
			{
				this.fireLevel_ = value;
			}
		}

		// Token: 0x170024D7 RID: 9431
		// (get) Token: 0x0600B6B0 RID: 46768 RVA: 0x001B3DFE File Offset: 0x001B1FFE
		// (set) Token: 0x0600B6B1 RID: 46769 RVA: 0x001B3E06 File Offset: 0x001B2006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FireLevelReachTime
		{
			get
			{
				return this.fireLevelReachTime_;
			}
			set
			{
				this.fireLevelReachTime_ = value;
			}
		}

		// Token: 0x170024D8 RID: 9432
		// (get) Token: 0x0600B6B2 RID: 46770 RVA: 0x001B3E0F File Offset: 0x001B200F
		// (set) Token: 0x0600B6B3 RID: 46771 RVA: 0x001B3E17 File Offset: 0x001B2017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2StatusPb FireStatus
		{
			get
			{
				return this.fireStatus_;
			}
			set
			{
				this.fireStatus_ = value;
			}
		}

		// Token: 0x0600B6B4 RID: 46772 RVA: 0x001B3E20 File Offset: 0x001B2020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2FirePb);
		}

		// Token: 0x0600B6B5 RID: 46773 RVA: 0x001B3E30 File Offset: 0x001B2030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2FirePb other)
		{
			return other != null && (other == this || (this.FireExp == other.FireExp && this.FireLevel == other.FireLevel && this.FireLevelReachTime == other.FireLevelReachTime && this.FireStatus == other.FireStatus && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B6B6 RID: 46774 RVA: 0x001B3E9C File Offset: 0x001B209C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FireExp != 0L)
			{
				num ^= this.FireExp.GetHashCode();
			}
			if (this.FireLevel != 0)
			{
				num ^= this.FireLevel.GetHashCode();
			}
			if (this.FireLevelReachTime != 0L)
			{
				num ^= this.FireLevelReachTime.GetHashCode();
			}
			if (this.FireStatus != InfrV2StatusPb.InfrV2StatusLock)
			{
				num ^= this.FireStatus.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B6B7 RID: 46775 RVA: 0x001B3F2C File Offset: 0x001B212C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B6B8 RID: 46776 RVA: 0x001B3F39 File Offset: 0x001B2139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B6B9 RID: 46777 RVA: 0x001B3F44 File Offset: 0x001B2144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FireExp != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.FireExp);
			}
			if (this.FireLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FireLevel);
			}
			if (this.FireLevelReachTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.FireLevelReachTime);
			}
			if (this.FireStatus != InfrV2StatusPb.InfrV2StatusLock)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.FireStatus);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B6BA RID: 46778 RVA: 0x001B3FD4 File Offset: 0x001B21D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FireExp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FireExp);
			}
			if (this.FireLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FireLevel);
			}
			if (this.FireLevelReachTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FireLevelReachTime);
			}
			if (this.FireStatus != InfrV2StatusPb.InfrV2StatusLock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.FireStatus);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B6BB RID: 46779 RVA: 0x001B405C File Offset: 0x001B225C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2FirePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FireExp != 0L)
			{
				this.FireExp = other.FireExp;
			}
			if (other.FireLevel != 0)
			{
				this.FireLevel = other.FireLevel;
			}
			if (other.FireLevelReachTime != 0L)
			{
				this.FireLevelReachTime = other.FireLevelReachTime;
			}
			if (other.FireStatus != InfrV2StatusPb.InfrV2StatusLock)
			{
				this.FireStatus = other.FireStatus;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B6BC RID: 46780 RVA: 0x001B40D4 File Offset: 0x001B22D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B6BD RID: 46781 RVA: 0x001B40E0 File Offset: 0x001B22E0
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.FireExp = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.FireLevel = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.FireLevelReachTime = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.FireStatus = (InfrV2StatusPb)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040050D5 RID: 20693
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050D6 RID: 20694
		public const int FireExpFieldNumber = 1;

		// Token: 0x040050D7 RID: 20695
		private long fireExp_;

		// Token: 0x040050D8 RID: 20696
		public const int FireLevelFieldNumber = 2;

		// Token: 0x040050D9 RID: 20697
		private int fireLevel_;

		// Token: 0x040050DA RID: 20698
		public const int FireLevelReachTimeFieldNumber = 3;

		// Token: 0x040050DB RID: 20699
		private long fireLevelReachTime_;

		// Token: 0x040050DC RID: 20700
		public const int FireStatusFieldNumber = 4;

		// Token: 0x040050DD RID: 20701
		private InfrV2StatusPb fireStatus_;
	}
}
