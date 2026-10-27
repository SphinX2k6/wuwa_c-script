using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000445 RID: 1093
	public sealed class EnergyInfo : IMessage<EnergyInfo>, IMessage, IEquatable<EnergyInfo>, IDeepCloneable<EnergyInfo>, IBufferMessage
	{
		// Token: 0x06006895 RID: 26773 RVA: 0x000FB3D2 File Offset: 0x000F95D2
		[NullableContext(1)]
		public static EnergyInfo Create()
		{
			return new EnergyInfo();
		}

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x06006896 RID: 26774 RVA: 0x000FB3D9 File Offset: 0x000F95D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnergyInfo> Parser
		{
			get
			{
				return EnergyInfo._parser;
			}
		}

		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x06006897 RID: 26775 RVA: 0x000FB3E0 File Offset: 0x000F95E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x06006898 RID: 26776 RVA: 0x000FB3E3 File Offset: 0x000F95E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnergyInfo.Descriptor;
			}
		}

		// Token: 0x06006899 RID: 26777 RVA: 0x000FB3EA File Offset: 0x000F95EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnergyInfo()
		{
		}

		// Token: 0x0600689A RID: 26778 RVA: 0x000FB3F2 File Offset: 0x000F95F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnergyInfo(EnergyInfo other) : this()
		{
			this.energyCount_ = other.energyCount_;
			this.lastRenewEnergyTime_ = other.lastRenewEnergyTime_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600689B RID: 26779 RVA: 0x000FB42F File Offset: 0x000F962F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnergyInfo Clone()
		{
			return new EnergyInfo(this);
		}

		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x0600689C RID: 26780 RVA: 0x000FB437 File Offset: 0x000F9637
		// (set) Token: 0x0600689D RID: 26781 RVA: 0x000FB43F File Offset: 0x000F963F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EnergyCount
		{
			get
			{
				return this.energyCount_;
			}
			set
			{
				this.energyCount_ = value;
			}
		}

		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x0600689E RID: 26782 RVA: 0x000FB448 File Offset: 0x000F9648
		// (set) Token: 0x0600689F RID: 26783 RVA: 0x000FB450 File Offset: 0x000F9650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastRenewEnergyTime
		{
			get
			{
				return this.lastRenewEnergyTime_;
			}
			set
			{
				this.lastRenewEnergyTime_ = value;
			}
		}

		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x060068A0 RID: 26784 RVA: 0x000FB459 File Offset: 0x000F9659
		// (set) Token: 0x060068A1 RID: 26785 RVA: 0x000FB461 File Offset: 0x000F9661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x060068A2 RID: 26786 RVA: 0x000FB46A File Offset: 0x000F966A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnergyInfo);
		}

		// Token: 0x060068A3 RID: 26787 RVA: 0x000FB478 File Offset: 0x000F9678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnergyInfo other)
		{
			return other != null && (other == this || (this.EnergyCount == other.EnergyCount && this.LastRenewEnergyTime == other.LastRenewEnergyTime && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060068A4 RID: 26788 RVA: 0x000FB4D4 File Offset: 0x000F96D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EnergyCount != 0)
			{
				num ^= this.EnergyCount.GetHashCode();
			}
			if (this.LastRenewEnergyTime != 0)
			{
				num ^= this.LastRenewEnergyTime.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060068A5 RID: 26789 RVA: 0x000FB545 File Offset: 0x000F9745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060068A6 RID: 26790 RVA: 0x000FB552 File Offset: 0x000F9752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060068A7 RID: 26791 RVA: 0x000FB55C File Offset: 0x000F975C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EnergyCount != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EnergyCount);
			}
			if (this.LastRenewEnergyTime != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LastRenewEnergyTime);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060068A8 RID: 26792 RVA: 0x000FB5D0 File Offset: 0x000F97D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EnergyCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EnergyCount);
			}
			if (this.LastRenewEnergyTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastRenewEnergyTime);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060068A9 RID: 26793 RVA: 0x000FB640 File Offset: 0x000F9840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnergyInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EnergyCount != 0)
			{
				this.EnergyCount = other.EnergyCount;
			}
			if (other.LastRenewEnergyTime != 0)
			{
				this.LastRenewEnergyTime = other.LastRenewEnergyTime;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060068AA RID: 26794 RVA: 0x000FB6A4 File Offset: 0x000F98A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060068AB RID: 26795 RVA: 0x000FB6B0 File Offset: 0x000F98B0
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Id = input.ReadInt32();
						}
					}
					else
					{
						this.LastRenewEnergyTime = input.ReadInt32();
					}
				}
				else
				{
					this.EnergyCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x040039C0 RID: 14784
		private static readonly MessageParser<EnergyInfo> _parser = new MessageParser<EnergyInfo>(() => new EnergyInfo());

		// Token: 0x040039C1 RID: 14785
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039C2 RID: 14786
		public const int EnergyCountFieldNumber = 1;

		// Token: 0x040039C3 RID: 14787
		private int energyCount_;

		// Token: 0x040039C4 RID: 14788
		public const int LastRenewEnergyTimeFieldNumber = 2;

		// Token: 0x040039C5 RID: 14789
		private int lastRenewEnergyTime_;

		// Token: 0x040039C6 RID: 14790
		public const int IdFieldNumber = 3;

		// Token: 0x040039C7 RID: 14791
		private int id_;
	}
}
