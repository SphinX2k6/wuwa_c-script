using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000571 RID: 1393
	[NetMessage(EMessageId.FishingPortUpdateNotify)]
	public sealed class FishingPortUpdateNotify : IMessage<FishingPortUpdateNotify>, IMessage, IEquatable<FishingPortUpdateNotify>, IDeepCloneable<FishingPortUpdateNotify>, IBufferMessage
	{
		// Token: 0x060081AD RID: 33197 RVA: 0x001393B5 File Offset: 0x001375B5
		[NullableContext(1)]
		public static FishingPortUpdateNotify Create()
		{
			return new FishingPortUpdateNotify();
		}

		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x060081AE RID: 33198 RVA: 0x001393BC File Offset: 0x001375BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x060081AF RID: 33199 RVA: 0x001393BF File Offset: 0x001375BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingPortUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060081B0 RID: 33200 RVA: 0x001393C6 File Offset: 0x001375C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPortUpdateNotify()
		{
		}

		// Token: 0x060081B1 RID: 33201 RVA: 0x001393CE File Offset: 0x001375CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPortUpdateNotify(FishingPortUpdateNotify other) : this()
		{
			this.isInPort_ = other.isInPort_;
			this.portId_ = other.portId_;
			this.lastPortId_ = other.lastPortId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060081B2 RID: 33202 RVA: 0x0013940B File Offset: 0x0013760B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPortUpdateNotify Clone()
		{
			return new FishingPortUpdateNotify(this);
		}

		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x060081B3 RID: 33203 RVA: 0x00139413 File Offset: 0x00137613
		// (set) Token: 0x060081B4 RID: 33204 RVA: 0x0013941B File Offset: 0x0013761B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsInPort
		{
			get
			{
				return this.isInPort_;
			}
			set
			{
				this.isInPort_ = value;
			}
		}

		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x060081B5 RID: 33205 RVA: 0x00139424 File Offset: 0x00137624
		// (set) Token: 0x060081B6 RID: 33206 RVA: 0x0013942C File Offset: 0x0013762C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PortId
		{
			get
			{
				return this.portId_;
			}
			set
			{
				this.portId_ = value;
			}
		}

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x060081B7 RID: 33207 RVA: 0x00139435 File Offset: 0x00137635
		// (set) Token: 0x060081B8 RID: 33208 RVA: 0x0013943D File Offset: 0x0013763D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastPortId
		{
			get
			{
				return this.lastPortId_;
			}
			set
			{
				this.lastPortId_ = value;
			}
		}

		// Token: 0x060081B9 RID: 33209 RVA: 0x00139446 File Offset: 0x00137646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingPortUpdateNotify);
		}

		// Token: 0x060081BA RID: 33210 RVA: 0x00139454 File Offset: 0x00137654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingPortUpdateNotify other)
		{
			return other != null && (other == this || (this.IsInPort == other.IsInPort && this.PortId == other.PortId && this.LastPortId == other.LastPortId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060081BB RID: 33211 RVA: 0x001394B0 File Offset: 0x001376B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsInPort)
			{
				num ^= this.IsInPort.GetHashCode();
			}
			if (this.PortId != 0)
			{
				num ^= this.PortId.GetHashCode();
			}
			if (this.LastPortId != 0)
			{
				num ^= this.LastPortId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060081BC RID: 33212 RVA: 0x00139521 File Offset: 0x00137721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060081BD RID: 33213 RVA: 0x0013952E File Offset: 0x0013772E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060081BE RID: 33214 RVA: 0x00139538 File Offset: 0x00137738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsInPort)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsInPort);
			}
			if (this.PortId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.PortId);
			}
			if (this.LastPortId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.LastPortId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060081BF RID: 33215 RVA: 0x001395B0 File Offset: 0x001377B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsInPort)
			{
				num += 2;
			}
			if (this.PortId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PortId);
			}
			if (this.LastPortId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastPortId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060081C0 RID: 33216 RVA: 0x00139614 File Offset: 0x00137814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingPortUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsInPort)
			{
				this.IsInPort = other.IsInPort;
			}
			if (other.PortId != 0)
			{
				this.PortId = other.PortId;
			}
			if (other.LastPortId != 0)
			{
				this.LastPortId = other.LastPortId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060081C1 RID: 33217 RVA: 0x00139678 File Offset: 0x00137878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060081C2 RID: 33218 RVA: 0x00139684 File Offset: 0x00137884
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
					if (num != 72U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.LastPortId = input.ReadInt32();
						}
					}
					else
					{
						this.PortId = input.ReadInt32();
					}
				}
				else
				{
					this.IsInPort = input.ReadBool();
				}
			}
		}

		// Token: 0x04004113 RID: 16659
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004114 RID: 16660
		public const int IsInPortFieldNumber = 2;

		// Token: 0x04004115 RID: 16661
		private bool isInPort_;

		// Token: 0x04004116 RID: 16662
		public const int PortIdFieldNumber = 9;

		// Token: 0x04004117 RID: 16663
		private int portId_;

		// Token: 0x04004118 RID: 16664
		public const int LastPortIdFieldNumber = 14;

		// Token: 0x04004119 RID: 16665
		private int lastPortId_;
	}
}
