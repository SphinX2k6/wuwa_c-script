using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000757 RID: 1879
	public sealed class HoldHandComponentPb : IMessage<HoldHandComponentPb>, IMessage, IEquatable<HoldHandComponentPb>, IDeepCloneable<HoldHandComponentPb>, IBufferMessage
	{
		// Token: 0x0600AA20 RID: 43552 RVA: 0x001995AF File Offset: 0x001977AF
		[NullableContext(1)]
		public static HoldHandComponentPb Create()
		{
			return new HoldHandComponentPb();
		}

		// Token: 0x17002240 RID: 8768
		// (get) Token: 0x0600AA21 RID: 43553 RVA: 0x001995B6 File Offset: 0x001977B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002241 RID: 8769
		// (get) Token: 0x0600AA22 RID: 43554 RVA: 0x001995B9 File Offset: 0x001977B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HoldHandComponentPb.Descriptor;
			}
		}

		// Token: 0x0600AA23 RID: 43555 RVA: 0x001995C0 File Offset: 0x001977C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldHandComponentPb()
		{
		}

		// Token: 0x0600AA24 RID: 43556 RVA: 0x001995C8 File Offset: 0x001977C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldHandComponentPb(HoldHandComponentPb other) : this()
		{
			this.targetEntityId_ = other.targetEntityId_;
			this.handType_ = other.handType_;
			this.isFollow_ = other.isFollow_;
			this.actionType_ = other.actionType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AA25 RID: 43557 RVA: 0x0019961C File Offset: 0x0019781C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldHandComponentPb Clone()
		{
			return new HoldHandComponentPb(this);
		}

		// Token: 0x17002242 RID: 8770
		// (get) Token: 0x0600AA26 RID: 43558 RVA: 0x00199624 File Offset: 0x00197824
		// (set) Token: 0x0600AA27 RID: 43559 RVA: 0x0019962C File Offset: 0x0019782C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetEntityId
		{
			get
			{
				return this.targetEntityId_;
			}
			set
			{
				this.targetEntityId_ = value;
			}
		}

		// Token: 0x17002243 RID: 8771
		// (get) Token: 0x0600AA28 RID: 43560 RVA: 0x00199635 File Offset: 0x00197835
		// (set) Token: 0x0600AA29 RID: 43561 RVA: 0x0019963D File Offset: 0x0019783D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandType
		{
			get
			{
				return this.handType_;
			}
			set
			{
				this.handType_ = value;
			}
		}

		// Token: 0x17002244 RID: 8772
		// (get) Token: 0x0600AA2A RID: 43562 RVA: 0x00199646 File Offset: 0x00197846
		// (set) Token: 0x0600AA2B RID: 43563 RVA: 0x0019964E File Offset: 0x0019784E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFollow
		{
			get
			{
				return this.isFollow_;
			}
			set
			{
				this.isFollow_ = value;
			}
		}

		// Token: 0x17002245 RID: 8773
		// (get) Token: 0x0600AA2C RID: 43564 RVA: 0x00199657 File Offset: 0x00197857
		// (set) Token: 0x0600AA2D RID: 43565 RVA: 0x0019965F File Offset: 0x0019785F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActionType
		{
			get
			{
				return this.actionType_;
			}
			set
			{
				this.actionType_ = value;
			}
		}

		// Token: 0x0600AA2E RID: 43566 RVA: 0x00199668 File Offset: 0x00197868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HoldHandComponentPb);
		}

		// Token: 0x0600AA2F RID: 43567 RVA: 0x00199678 File Offset: 0x00197878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HoldHandComponentPb other)
		{
			return other != null && (other == this || (this.TargetEntityId == other.TargetEntityId && this.HandType == other.HandType && this.IsFollow == other.IsFollow && this.ActionType == other.ActionType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AA30 RID: 43568 RVA: 0x001996E4 File Offset: 0x001978E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetEntityId != 0L)
			{
				num ^= this.TargetEntityId.GetHashCode();
			}
			if (this.HandType != 0)
			{
				num ^= this.HandType.GetHashCode();
			}
			if (this.IsFollow)
			{
				num ^= this.IsFollow.GetHashCode();
			}
			if (this.ActionType != 0)
			{
				num ^= this.ActionType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AA31 RID: 43569 RVA: 0x0019976E File Offset: 0x0019796E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AA32 RID: 43570 RVA: 0x0019977B File Offset: 0x0019797B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA33 RID: 43571 RVA: 0x00199784 File Offset: 0x00197984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this.HandType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HandType);
			}
			if (this.IsFollow)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsFollow);
			}
			if (this.ActionType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActionType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA34 RID: 43572 RVA: 0x00199814 File Offset: 0x00197A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetEntityId);
			}
			if (this.HandType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandType);
			}
			if (this.IsFollow)
			{
				num += 2;
			}
			if (this.ActionType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActionType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AA35 RID: 43573 RVA: 0x00199890 File Offset: 0x00197A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HoldHandComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetEntityId != 0L)
			{
				this.TargetEntityId = other.TargetEntityId;
			}
			if (other.HandType != 0)
			{
				this.HandType = other.HandType;
			}
			if (other.IsFollow)
			{
				this.IsFollow = other.IsFollow;
			}
			if (other.ActionType != 0)
			{
				this.ActionType = other.ActionType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AA36 RID: 43574 RVA: 0x00199908 File Offset: 0x00197B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA37 RID: 43575 RVA: 0x00199914 File Offset: 0x00197B14
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
						this.TargetEntityId = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.HandType = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.IsFollow = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.ActionType = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004D5F RID: 19807
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D60 RID: 19808
		public const int TargetEntityIdFieldNumber = 1;

		// Token: 0x04004D61 RID: 19809
		private long targetEntityId_;

		// Token: 0x04004D62 RID: 19810
		public const int HandTypeFieldNumber = 2;

		// Token: 0x04004D63 RID: 19811
		private int handType_;

		// Token: 0x04004D64 RID: 19812
		public const int IsFollowFieldNumber = 3;

		// Token: 0x04004D65 RID: 19813
		private bool isFollow_;

		// Token: 0x04004D66 RID: 19814
		public const int ActionTypeFieldNumber = 4;

		// Token: 0x04004D67 RID: 19815
		private int actionType_;
	}
}
