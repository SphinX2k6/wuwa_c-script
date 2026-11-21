using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003F8 RID: 1016
	public sealed class DropComponentPb : IMessage<DropComponentPb>, IMessage, IEquatable<DropComponentPb>, IDeepCloneable<DropComponentPb>, IBufferMessage
	{
		// Token: 0x06006284 RID: 25220 RVA: 0x000ED589 File Offset: 0x000EB789
		[NullableContext(1)]
		public static DropComponentPb Create()
		{
			return new DropComponentPb();
		}

		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x06006285 RID: 25221 RVA: 0x000ED590 File Offset: 0x000EB790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x06006286 RID: 25222 RVA: 0x000ED593 File Offset: 0x000EB793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropComponentPb.Descriptor;
			}
		}

		// Token: 0x06006287 RID: 25223 RVA: 0x000ED59A File Offset: 0x000EB79A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropComponentPb()
		{
		}

		// Token: 0x06006288 RID: 25224 RVA: 0x000ED5A4 File Offset: 0x000EB7A4
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

		// Token: 0x06006289 RID: 25225 RVA: 0x000ED5F8 File Offset: 0x000EB7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropComponentPb Clone()
		{
			return new DropComponentPb(this);
		}

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x0600628A RID: 25226 RVA: 0x000ED600 File Offset: 0x000EB800
		// (set) Token: 0x0600628B RID: 25227 RVA: 0x000ED608 File Offset: 0x000EB808
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

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x0600628C RID: 25228 RVA: 0x000ED611 File Offset: 0x000EB811
		// (set) Token: 0x0600628D RID: 25229 RVA: 0x000ED619 File Offset: 0x000EB819
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

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x0600628E RID: 25230 RVA: 0x000ED622 File Offset: 0x000EB822
		// (set) Token: 0x0600628F RID: 25231 RVA: 0x000ED62A File Offset: 0x000EB82A
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

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x06006290 RID: 25232 RVA: 0x000ED633 File Offset: 0x000EB833
		// (set) Token: 0x06006291 RID: 25233 RVA: 0x000ED63B File Offset: 0x000EB83B
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

		// Token: 0x06006292 RID: 25234 RVA: 0x000ED644 File Offset: 0x000EB844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropComponentPb);
		}

		// Token: 0x06006293 RID: 25235 RVA: 0x000ED654 File Offset: 0x000EB854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropComponentPb other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ShowPlanId == other.ShowPlanId && this.ItemCount == other.ItemCount && this.EntityConfigId == other.EntityConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006294 RID: 25236 RVA: 0x000ED6C0 File Offset: 0x000EB8C0
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

		// Token: 0x06006295 RID: 25237 RVA: 0x000ED74A File Offset: 0x000EB94A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006296 RID: 25238 RVA: 0x000ED757 File Offset: 0x000EB957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006297 RID: 25239 RVA: 0x000ED760 File Offset: 0x000EB960
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

		// Token: 0x06006298 RID: 25240 RVA: 0x000ED7F0 File Offset: 0x000EB9F0
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

		// Token: 0x06006299 RID: 25241 RVA: 0x000ED878 File Offset: 0x000EBA78
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

		// Token: 0x0600629A RID: 25242 RVA: 0x000ED8F0 File Offset: 0x000EBAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600629B RID: 25243 RVA: 0x000ED8FC File Offset: 0x000EBAFC
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

		// Token: 0x0400383B RID: 14395
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400383C RID: 14396
		public const int ItemIdFieldNumber = 1;

		// Token: 0x0400383D RID: 14397
		private int itemId_;

		// Token: 0x0400383E RID: 14398
		public const int ShowPlanIdFieldNumber = 2;

		// Token: 0x0400383F RID: 14399
		private int showPlanId_;

		// Token: 0x04003840 RID: 14400
		public const int ItemCountFieldNumber = 3;

		// Token: 0x04003841 RID: 14401
		private int itemCount_;

		// Token: 0x04003842 RID: 14402
		public const int EntityConfigIdFieldNumber = 4;

		// Token: 0x04003843 RID: 14403
		private int entityConfigId_;
	}
}
