using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200042E RID: 1070
	public sealed class EnergyInfo : IMessage<EnergyInfo>, IMessage, IEquatable<EnergyInfo>, IDeepCloneable<EnergyInfo>, IBufferMessage
	{
		// Token: 0x06006705 RID: 26373 RVA: 0x000F8245 File Offset: 0x000F6445
		[NullableContext(1)]
		public static EnergyInfo Create()
		{
			return new EnergyInfo();
		}

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x06006706 RID: 26374 RVA: 0x000F824C File Offset: 0x000F644C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnergyInfo> Parser
		{
			get
			{
				return EnergyInfo._parser;
			}
		}

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x06006707 RID: 26375 RVA: 0x000F8253 File Offset: 0x000F6453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x06006708 RID: 26376 RVA: 0x000F8256 File Offset: 0x000F6456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnergyInfo.Descriptor;
			}
		}

		// Token: 0x06006709 RID: 26377 RVA: 0x000F825D File Offset: 0x000F645D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnergyInfo()
		{
		}

		// Token: 0x0600670A RID: 26378 RVA: 0x000F8265 File Offset: 0x000F6465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnergyInfo(EnergyInfo other) : this()
		{
			this.energyCount_ = other.energyCount_;
			this.lastRenewEnergyTime_ = other.lastRenewEnergyTime_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600670B RID: 26379 RVA: 0x000F82A2 File Offset: 0x000F64A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnergyInfo Clone()
		{
			return new EnergyInfo(this);
		}

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x0600670C RID: 26380 RVA: 0x000F82AA File Offset: 0x000F64AA
		// (set) Token: 0x0600670D RID: 26381 RVA: 0x000F82B2 File Offset: 0x000F64B2
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

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x0600670E RID: 26382 RVA: 0x000F82BB File Offset: 0x000F64BB
		// (set) Token: 0x0600670F RID: 26383 RVA: 0x000F82C3 File Offset: 0x000F64C3
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

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x06006710 RID: 26384 RVA: 0x000F82CC File Offset: 0x000F64CC
		// (set) Token: 0x06006711 RID: 26385 RVA: 0x000F82D4 File Offset: 0x000F64D4
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

		// Token: 0x06006712 RID: 26386 RVA: 0x000F82DD File Offset: 0x000F64DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnergyInfo);
		}

		// Token: 0x06006713 RID: 26387 RVA: 0x000F82EC File Offset: 0x000F64EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnergyInfo other)
		{
			return other != null && (other == this || (this.EnergyCount == other.EnergyCount && this.LastRenewEnergyTime == other.LastRenewEnergyTime && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006714 RID: 26388 RVA: 0x000F8348 File Offset: 0x000F6548
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

		// Token: 0x06006715 RID: 26389 RVA: 0x000F83B9 File Offset: 0x000F65B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006716 RID: 26390 RVA: 0x000F83C6 File Offset: 0x000F65C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006717 RID: 26391 RVA: 0x000F83D0 File Offset: 0x000F65D0
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

		// Token: 0x06006718 RID: 26392 RVA: 0x000F8444 File Offset: 0x000F6644
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

		// Token: 0x06006719 RID: 26393 RVA: 0x000F84B4 File Offset: 0x000F66B4
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

		// Token: 0x0600671A RID: 26394 RVA: 0x000F8518 File Offset: 0x000F6718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600671B RID: 26395 RVA: 0x000F8524 File Offset: 0x000F6724
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

		// Token: 0x040039AD RID: 14765
		private static readonly MessageParser<EnergyInfo> _parser = new MessageParser<EnergyInfo>(() => new EnergyInfo());

		// Token: 0x040039AE RID: 14766
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039AF RID: 14767
		public const int EnergyCountFieldNumber = 1;

		// Token: 0x040039B0 RID: 14768
		private int energyCount_;

		// Token: 0x040039B1 RID: 14769
		public const int LastRenewEnergyTimeFieldNumber = 2;

		// Token: 0x040039B2 RID: 14770
		private int lastRenewEnergyTime_;

		// Token: 0x040039B3 RID: 14771
		public const int IdFieldNumber = 3;

		// Token: 0x040039B4 RID: 14772
		private int id_;
	}
}
