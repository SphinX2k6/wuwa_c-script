using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003A9 RID: 937
	[NetMessage(EMessageId.DarkTideItemMarkUpdateNotify)]
	public sealed class DarkTideItemMarkUpdateNotify : IMessage<DarkTideItemMarkUpdateNotify>, IMessage, IEquatable<DarkTideItemMarkUpdateNotify>, IDeepCloneable<DarkTideItemMarkUpdateNotify>, IBufferMessage
	{
		// Token: 0x06005C1B RID: 23579 RVA: 0x000DFC2D File Offset: 0x000DDE2D
		[NullableContext(1)]
		public static DarkTideItemMarkUpdateNotify Create()
		{
			return new DarkTideItemMarkUpdateNotify();
		}

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x06005C1C RID: 23580 RVA: 0x000DFC34 File Offset: 0x000DDE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x06005C1D RID: 23581 RVA: 0x000DFC37 File Offset: 0x000DDE37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideItemMarkUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06005C1E RID: 23582 RVA: 0x000DFC3E File Offset: 0x000DDE3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideItemMarkUpdateNotify()
		{
		}

		// Token: 0x06005C1F RID: 23583 RVA: 0x000DFC48 File Offset: 0x000DDE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideItemMarkUpdateNotify(DarkTideItemMarkUpdateNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.entityIncId_ = other.entityIncId_;
			this.configId_ = other.configId_;
			this.isCancel_ = other.isCancel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C20 RID: 23584 RVA: 0x000DFC9C File Offset: 0x000DDE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideItemMarkUpdateNotify Clone()
		{
			return new DarkTideItemMarkUpdateNotify(this);
		}

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x06005C21 RID: 23585 RVA: 0x000DFCA4 File Offset: 0x000DDEA4
		// (set) Token: 0x06005C22 RID: 23586 RVA: 0x000DFCAC File Offset: 0x000DDEAC
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

		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x06005C23 RID: 23587 RVA: 0x000DFCB5 File Offset: 0x000DDEB5
		// (set) Token: 0x06005C24 RID: 23588 RVA: 0x000DFCBD File Offset: 0x000DDEBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityIncId
		{
			get
			{
				return this.entityIncId_;
			}
			set
			{
				this.entityIncId_ = value;
			}
		}

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x06005C25 RID: 23589 RVA: 0x000DFCC6 File Offset: 0x000DDEC6
		// (set) Token: 0x06005C26 RID: 23590 RVA: 0x000DFCCE File Offset: 0x000DDECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x06005C27 RID: 23591 RVA: 0x000DFCD7 File Offset: 0x000DDED7
		// (set) Token: 0x06005C28 RID: 23592 RVA: 0x000DFCDF File Offset: 0x000DDEDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCancel
		{
			get
			{
				return this.isCancel_;
			}
			set
			{
				this.isCancel_ = value;
			}
		}

		// Token: 0x06005C29 RID: 23593 RVA: 0x000DFCE8 File Offset: 0x000DDEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideItemMarkUpdateNotify);
		}

		// Token: 0x06005C2A RID: 23594 RVA: 0x000DFCF8 File Offset: 0x000DDEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideItemMarkUpdateNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.EntityIncId == other.EntityIncId && this.ConfigId == other.ConfigId && this.IsCancel == other.IsCancel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005C2B RID: 23595 RVA: 0x000DFD64 File Offset: 0x000DDF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.EntityIncId != 0L)
			{
				num ^= this.EntityIncId.GetHashCode();
			}
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.IsCancel)
			{
				num ^= this.IsCancel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005C2C RID: 23596 RVA: 0x000DFDEE File Offset: 0x000DDFEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005C2D RID: 23597 RVA: 0x000DFDFB File Offset: 0x000DDFFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C2E RID: 23598 RVA: 0x000DFE04 File Offset: 0x000DE004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityIncId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerId);
			}
			if (this.IsCancel)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsCancel);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C2F RID: 23599 RVA: 0x000DFE98 File Offset: 0x000DE098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.EntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityIncId);
			}
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.IsCancel)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005C30 RID: 23600 RVA: 0x000DFF14 File Offset: 0x000DE114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideItemMarkUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.EntityIncId != 0L)
			{
				this.EntityIncId = other.EntityIncId;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.IsCancel)
			{
				this.IsCancel = other.IsCancel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005C31 RID: 23601 RVA: 0x000DFF8C File Offset: 0x000DE18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C32 RID: 23602 RVA: 0x000DFF98 File Offset: 0x000DE198
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
						this.EntityIncId = input.ReadInt64();
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
					if (num == 40U)
					{
						this.IsCancel = input.ReadBool();
						continue;
					}
					if (num == 88U)
					{
						this.ConfigId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400362C RID: 13868
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400362D RID: 13869
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x0400362E RID: 13870
		private int playerId_;

		// Token: 0x0400362F RID: 13871
		public const int EntityIncIdFieldNumber = 2;

		// Token: 0x04003630 RID: 13872
		private long entityIncId_;

		// Token: 0x04003631 RID: 13873
		public const int ConfigIdFieldNumber = 11;

		// Token: 0x04003632 RID: 13874
		private int configId_;

		// Token: 0x04003633 RID: 13875
		public const int IsCancelFieldNumber = 5;

		// Token: 0x04003634 RID: 13876
		private bool isCancel_;
	}
}
