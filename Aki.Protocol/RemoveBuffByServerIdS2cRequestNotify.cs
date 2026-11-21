using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EE2 RID: 3810
	[NetMessage(EMessageId.RemoveBuffByServerIdS2cRequestNotify)]
	public sealed class RemoveBuffByServerIdS2cRequestNotify : IMessage<RemoveBuffByServerIdS2cRequestNotify>, IMessage, IEquatable<RemoveBuffByServerIdS2cRequestNotify>, IDeepCloneable<RemoveBuffByServerIdS2cRequestNotify>, IBufferMessage
	{
		// Token: 0x0601471F RID: 83743 RVA: 0x002F923D File Offset: 0x002F743D
		[NullableContext(1)]
		public static RemoveBuffByServerIdS2cRequestNotify Create()
		{
			return new RemoveBuffByServerIdS2cRequestNotify();
		}

		// Token: 0x17004403 RID: 17411
		// (get) Token: 0x06014720 RID: 83744 RVA: 0x002F9244 File Offset: 0x002F7444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004404 RID: 17412
		// (get) Token: 0x06014721 RID: 83745 RVA: 0x002F9247 File Offset: 0x002F7447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveBuffByServerIdS2cRequestNotify.Descriptor;
			}
		}

		// Token: 0x06014722 RID: 83746 RVA: 0x002F924E File Offset: 0x002F744E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffByServerIdS2cRequestNotify()
		{
		}

		// Token: 0x06014723 RID: 83747 RVA: 0x002F9258 File Offset: 0x002F7458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffByServerIdS2cRequestNotify(RemoveBuffByServerIdS2cRequestNotify other) : this()
		{
			this.serverId_ = other.serverId_;
			this.stackCount_ = other.stackCount_;
			this.reason_ = other.reason_;
			this.instigatorId_ = other.instigatorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014724 RID: 83748 RVA: 0x002F92AC File Offset: 0x002F74AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffByServerIdS2cRequestNotify Clone()
		{
			return new RemoveBuffByServerIdS2cRequestNotify(this);
		}

		// Token: 0x17004405 RID: 17413
		// (get) Token: 0x06014725 RID: 83749 RVA: 0x002F92B4 File Offset: 0x002F74B4
		// (set) Token: 0x06014726 RID: 83750 RVA: 0x002F92BC File Offset: 0x002F74BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ServerId
		{
			get
			{
				return this.serverId_;
			}
			set
			{
				this.serverId_ = value;
			}
		}

		// Token: 0x17004406 RID: 17414
		// (get) Token: 0x06014727 RID: 83751 RVA: 0x002F92C5 File Offset: 0x002F74C5
		// (set) Token: 0x06014728 RID: 83752 RVA: 0x002F92CD File Offset: 0x002F74CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StackCount
		{
			get
			{
				return this.stackCount_;
			}
			set
			{
				this.stackCount_ = value;
			}
		}

		// Token: 0x17004407 RID: 17415
		// (get) Token: 0x06014729 RID: 83753 RVA: 0x002F92D6 File Offset: 0x002F74D6
		// (set) Token: 0x0601472A RID: 83754 RVA: 0x002F92DE File Offset: 0x002F74DE
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

		// Token: 0x17004408 RID: 17416
		// (get) Token: 0x0601472B RID: 83755 RVA: 0x002F92E7 File Offset: 0x002F74E7
		// (set) Token: 0x0601472C RID: 83756 RVA: 0x002F92EF File Offset: 0x002F74EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long InstigatorId
		{
			get
			{
				return this.instigatorId_;
			}
			set
			{
				this.instigatorId_ = value;
			}
		}

		// Token: 0x0601472D RID: 83757 RVA: 0x002F92F8 File Offset: 0x002F74F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveBuffByServerIdS2cRequestNotify);
		}

		// Token: 0x0601472E RID: 83758 RVA: 0x002F9308 File Offset: 0x002F7508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveBuffByServerIdS2cRequestNotify other)
		{
			return other != null && (other == this || (this.ServerId == other.ServerId && this.StackCount == other.StackCount && this.Reason == other.Reason && this.InstigatorId == other.InstigatorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601472F RID: 83759 RVA: 0x002F9374 File Offset: 0x002F7574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ServerId != 0)
			{
				num ^= this.ServerId.GetHashCode();
			}
			if (this.StackCount != 0)
			{
				num ^= this.StackCount.GetHashCode();
			}
			if (this.Reason != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.InstigatorId != 0L)
			{
				num ^= this.InstigatorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014730 RID: 83760 RVA: 0x002F93FE File Offset: 0x002F75FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014731 RID: 83761 RVA: 0x002F940B File Offset: 0x002F760B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014732 RID: 83762 RVA: 0x002F9414 File Offset: 0x002F7614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Reason);
			}
			if (this.StackCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.StackCount);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.InstigatorId);
			}
			if (this.ServerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ServerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014733 RID: 83763 RVA: 0x002F94A8 File Offset: 0x002F76A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ServerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ServerId);
			}
			if (this.StackCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StackCount);
			}
			if (this.Reason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reason);
			}
			if (this.InstigatorId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InstigatorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014734 RID: 83764 RVA: 0x002F9530 File Offset: 0x002F7730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveBuffByServerIdS2cRequestNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ServerId != 0)
			{
				this.ServerId = other.ServerId;
			}
			if (other.StackCount != 0)
			{
				this.StackCount = other.StackCount;
			}
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			if (other.InstigatorId != 0L)
			{
				this.InstigatorId = other.InstigatorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014735 RID: 83765 RVA: 0x002F95A8 File Offset: 0x002F77A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014736 RID: 83766 RVA: 0x002F95B4 File Offset: 0x002F77B4
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
					if (num == 16U)
					{
						this.Reason = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.StackCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.InstigatorId = input.ReadInt64();
						continue;
					}
					if (num == 88U)
					{
						this.ServerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007C7A RID: 31866
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C7B RID: 31867
		public const int ServerIdFieldNumber = 11;

		// Token: 0x04007C7C RID: 31868
		private int serverId_;

		// Token: 0x04007C7D RID: 31869
		public const int StackCountFieldNumber = 3;

		// Token: 0x04007C7E RID: 31870
		private int stackCount_;

		// Token: 0x04007C7F RID: 31871
		public const int ReasonFieldNumber = 2;

		// Token: 0x04007C80 RID: 31872
		private int reason_;

		// Token: 0x04007C81 RID: 31873
		public const int InstigatorIdFieldNumber = 7;

		// Token: 0x04007C82 RID: 31874
		private long instigatorId_;
	}
}
