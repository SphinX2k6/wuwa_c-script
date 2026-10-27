using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200040F RID: 1039
	public sealed class DropComponentPb : IMessage<DropComponentPb>, IMessage, IEquatable<DropComponentPb>, IDeepCloneable<DropComponentPb>, IBufferMessage
	{
		// Token: 0x06006414 RID: 25620 RVA: 0x000F0701 File Offset: 0x000EE901
		[NullableContext(1)]
		public static DropComponentPb Create()
		{
			return new DropComponentPb();
		}

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x06006415 RID: 25621 RVA: 0x000F0708 File Offset: 0x000EE908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x06006416 RID: 25622 RVA: 0x000F070B File Offset: 0x000EE90B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropComponentPb.Descriptor;
			}
		}

		// Token: 0x06006417 RID: 25623 RVA: 0x000F0712 File Offset: 0x000EE912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropComponentPb()
		{
		}

		// Token: 0x06006418 RID: 25624 RVA: 0x000F071C File Offset: 0x000EE91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropComponentPb(DropComponentPb other) : this()
		{
			this.itemId_ = other.itemId_;
			this.showPlanId_ = other.showPlanId_;
			this.itemCount_ = other.itemCount_;
			this.entityConfigId_ = other.entityConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006419 RID: 25625 RVA: 0x000F0770 File Offset: 0x000EE970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropComponentPb Clone()
		{
			return new DropComponentPb(this);
		}

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x0600641A RID: 25626 RVA: 0x000F0778 File Offset: 0x000EE978
		// (set) Token: 0x0600641B RID: 25627 RVA: 0x000F0780 File Offset: 0x000EE980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x0600641C RID: 25628 RVA: 0x000F0789 File Offset: 0x000EE989
		// (set) Token: 0x0600641D RID: 25629 RVA: 0x000F0791 File Offset: 0x000EE991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShowPlanId
		{
			get
			{
				return this.showPlanId_;
			}
			set
			{
				this.showPlanId_ = value;
			}
		}

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x0600641E RID: 25630 RVA: 0x000F079A File Offset: 0x000EE99A
		// (set) Token: 0x0600641F RID: 25631 RVA: 0x000F07A2 File Offset: 0x000EE9A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemCount
		{
			get
			{
				return this.itemCount_;
			}
			set
			{
				this.itemCount_ = value;
			}
		}

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x06006420 RID: 25632 RVA: 0x000F07AB File Offset: 0x000EE9AB
		// (set) Token: 0x06006421 RID: 25633 RVA: 0x000F07B3 File Offset: 0x000EE9B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfigId
		{
			get
			{
				return this.entityConfigId_;
			}
			set
			{
				this.entityConfigId_ = value;
			}
		}

		// Token: 0x06006422 RID: 25634 RVA: 0x000F07BC File Offset: 0x000EE9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropComponentPb);
		}

		// Token: 0x06006423 RID: 25635 RVA: 0x000F07CC File Offset: 0x000EE9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropComponentPb other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ShowPlanId == other.ShowPlanId && this.ItemCount == other.ItemCount && this.EntityConfigId == other.EntityConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006424 RID: 25636 RVA: 0x000F0838 File Offset: 0x000EEA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ShowPlanId != 0)
			{
				num ^= this.ShowPlanId.GetHashCode();
			}
			if (this.ItemCount != 0)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			if (this.EntityConfigId != 0)
			{
				num ^= this.EntityConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006425 RID: 25637 RVA: 0x000F08C2 File Offset: 0x000EEAC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006426 RID: 25638 RVA: 0x000F08CF File Offset: 0x000EEACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006427 RID: 25639 RVA: 0x000F08D8 File Offset: 0x000EEAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.ShowPlanId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ShowPlanId);
			}
			if (this.ItemCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ItemCount);
			}
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006428 RID: 25640 RVA: 0x000F0968 File Offset: 0x000EEB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ShowPlanId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShowPlanId);
			}
			if (this.ItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemCount);
			}
			if (this.EntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006429 RID: 25641 RVA: 0x000F09F0 File Offset: 0x000EEBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DropComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ShowPlanId != 0)
			{
				this.ShowPlanId = other.ShowPlanId;
			}
			if (other.ItemCount != 0)
			{
				this.ItemCount = other.ItemCount;
			}
			if (other.EntityConfigId != 0)
			{
				this.EntityConfigId = other.EntityConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600642A RID: 25642 RVA: 0x000F0A68 File Offset: 0x000EEC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600642B RID: 25643 RVA: 0x000F0A74 File Offset: 0x000EEC74
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
						this.ItemId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ShowPlanId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.ItemCount = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.EntityConfigId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400384E RID: 14414
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400384F RID: 14415
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04003850 RID: 14416
		private int itemId_;

		// Token: 0x04003851 RID: 14417
		public const int ShowPlanIdFieldNumber = 2;

		// Token: 0x04003852 RID: 14418
		private int showPlanId_;

		// Token: 0x04003853 RID: 14419
		public const int ItemCountFieldNumber = 3;

		// Token: 0x04003854 RID: 14420
		private int itemCount_;

		// Token: 0x04003855 RID: 14421
		public const int EntityConfigIdFieldNumber = 4;

		// Token: 0x04003856 RID: 14422
		private int entityConfigId_;
	}
}
