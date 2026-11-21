using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000743 RID: 1859
	public sealed class HoldHandComponentPb : IMessage<HoldHandComponentPb>, IMessage, IEquatable<HoldHandComponentPb>, IDeepCloneable<HoldHandComponentPb>, IBufferMessage
	{
		// Token: 0x0600A8CA RID: 43210 RVA: 0x00196B87 File Offset: 0x00194D87
		[NullableContext(1)]
		public static HoldHandComponentPb Create()
		{
			return new HoldHandComponentPb();
		}

		// Token: 0x170021F6 RID: 8694
		// (get) Token: 0x0600A8CB RID: 43211 RVA: 0x00196B8E File Offset: 0x00194D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021F7 RID: 8695
		// (get) Token: 0x0600A8CC RID: 43212 RVA: 0x00196B91 File Offset: 0x00194D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HoldHandComponentPb.Descriptor;
			}
		}

		// Token: 0x0600A8CD RID: 43213 RVA: 0x00196B98 File Offset: 0x00194D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldHandComponentPb()
		{
		}

		// Token: 0x0600A8CE RID: 43214 RVA: 0x00196BA0 File Offset: 0x00194DA0
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

		// Token: 0x0600A8CF RID: 43215 RVA: 0x00196BF4 File Offset: 0x00194DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldHandComponentPb Clone()
		{
			return new HoldHandComponentPb(this);
		}

		// Token: 0x170021F8 RID: 8696
		// (get) Token: 0x0600A8D0 RID: 43216 RVA: 0x00196BFC File Offset: 0x00194DFC
		// (set) Token: 0x0600A8D1 RID: 43217 RVA: 0x00196C04 File Offset: 0x00194E04
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

		// Token: 0x170021F9 RID: 8697
		// (get) Token: 0x0600A8D2 RID: 43218 RVA: 0x00196C0D File Offset: 0x00194E0D
		// (set) Token: 0x0600A8D3 RID: 43219 RVA: 0x00196C15 File Offset: 0x00194E15
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

		// Token: 0x170021FA RID: 8698
		// (get) Token: 0x0600A8D4 RID: 43220 RVA: 0x00196C1E File Offset: 0x00194E1E
		// (set) Token: 0x0600A8D5 RID: 43221 RVA: 0x00196C26 File Offset: 0x00194E26
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

		// Token: 0x170021FB RID: 8699
		// (get) Token: 0x0600A8D6 RID: 43222 RVA: 0x00196C2F File Offset: 0x00194E2F
		// (set) Token: 0x0600A8D7 RID: 43223 RVA: 0x00196C37 File Offset: 0x00194E37
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

		// Token: 0x0600A8D8 RID: 43224 RVA: 0x00196C40 File Offset: 0x00194E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HoldHandComponentPb);
		}

		// Token: 0x0600A8D9 RID: 43225 RVA: 0x00196C50 File Offset: 0x00194E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HoldHandComponentPb other)
		{
			return other != null && (other == this || (this.TargetEntityId == other.TargetEntityId && this.HandType == other.HandType && this.IsFollow == other.IsFollow && this.ActionType == other.ActionType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A8DA RID: 43226 RVA: 0x00196CBC File Offset: 0x00194EBC
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

		// Token: 0x0600A8DB RID: 43227 RVA: 0x00196D46 File Offset: 0x00194F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A8DC RID: 43228 RVA: 0x00196D53 File Offset: 0x00194F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A8DD RID: 43229 RVA: 0x00196D5C File Offset: 0x00194F5C
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

		// Token: 0x0600A8DE RID: 43230 RVA: 0x00196DEC File Offset: 0x00194FEC
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

		// Token: 0x0600A8DF RID: 43231 RVA: 0x00196E68 File Offset: 0x00195068
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

		// Token: 0x0600A8E0 RID: 43232 RVA: 0x00196EE0 File Offset: 0x001950E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A8E1 RID: 43233 RVA: 0x00196EEC File Offset: 0x001950EC
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

		// Token: 0x04004D58 RID: 19800
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D59 RID: 19801
		public const int TargetEntityIdFieldNumber = 1;

		// Token: 0x04004D5A RID: 19802
		private long targetEntityId_;

		// Token: 0x04004D5B RID: 19803
		public const int HandTypeFieldNumber = 2;

		// Token: 0x04004D5C RID: 19804
		private int handType_;

		// Token: 0x04004D5D RID: 19805
		public const int IsFollowFieldNumber = 3;

		// Token: 0x04004D5E RID: 19806
		private bool isFollow_;

		// Token: 0x04004D5F RID: 19807
		public const int ActionTypeFieldNumber = 4;

		// Token: 0x04004D60 RID: 19808
		private int actionType_;
	}
}
