using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001389 RID: 5001
	public sealed class TargetGearActionByHitTypeCtxPb : IMessage<TargetGearActionByHitTypeCtxPb>, IMessage, IEquatable<TargetGearActionByHitTypeCtxPb>, IDeepCloneable<TargetGearActionByHitTypeCtxPb>, IBufferMessage
	{
		// Token: 0x0601AA0A RID: 109066 RVA: 0x003E12A8 File Offset: 0x003DF4A8
		[NullableContext(1)]
		public static TargetGearActionByHitTypeCtxPb Create()
		{
			return new TargetGearActionByHitTypeCtxPb();
		}

		// Token: 0x17005A29 RID: 23081
		// (get) Token: 0x0601AA0B RID: 109067 RVA: 0x003E12AF File Offset: 0x003DF4AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A2A RID: 23082
		// (get) Token: 0x0601AA0C RID: 109068 RVA: 0x003E12B2 File Offset: 0x003DF4B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TargetGearActionByHitTypeCtxPb.Descriptor;
			}
		}

		// Token: 0x0601AA0D RID: 109069 RVA: 0x003E12B9 File Offset: 0x003DF4B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearActionByHitTypeCtxPb()
		{
		}

		// Token: 0x0601AA0E RID: 109070 RVA: 0x003E12C4 File Offset: 0x003DF4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearActionByHitTypeCtxPb(TargetGearActionByHitTypeCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AA0F RID: 109071 RVA: 0x003E1310 File Offset: 0x003DF510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearActionByHitTypeCtxPb Clone()
		{
			return new TargetGearActionByHitTypeCtxPb(this);
		}

		// Token: 0x17005A2B RID: 23083
		// (get) Token: 0x0601AA10 RID: 109072 RVA: 0x003E1318 File Offset: 0x003DF518
		// (set) Token: 0x0601AA11 RID: 109073 RVA: 0x003E1320 File Offset: 0x003DF520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCtxPb EntityCtx
		{
			get
			{
				return this.entityCtx_;
			}
			set
			{
				this.entityCtx_ = value;
			}
		}

		// Token: 0x17005A2C RID: 23084
		// (get) Token: 0x0601AA12 RID: 109074 RVA: 0x003E1329 File Offset: 0x003DF529
		// (set) Token: 0x0601AA13 RID: 109075 RVA: 0x003E1331 File Offset: 0x003DF531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x0601AA14 RID: 109076 RVA: 0x003E133A File Offset: 0x003DF53A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TargetGearActionByHitTypeCtxPb);
		}

		// Token: 0x0601AA15 RID: 109077 RVA: 0x003E1348 File Offset: 0x003DF548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TargetGearActionByHitTypeCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AA16 RID: 109078 RVA: 0x003E1398 File Offset: 0x003DF598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AA17 RID: 109079 RVA: 0x003E13ED File Offset: 0x003DF5ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AA18 RID: 109080 RVA: 0x003E13FA File Offset: 0x003DF5FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AA19 RID: 109081 RVA: 0x003E1404 File Offset: 0x003DF604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AA1A RID: 109082 RVA: 0x003E1460 File Offset: 0x003DF660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AA1B RID: 109083 RVA: 0x003E14B8 File Offset: 0x003DF6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TargetGearActionByHitTypeCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.entityCtx_ != null)
			{
				if (this.entityCtx_ == null)
				{
					this.EntityCtx = new EntityCtxPb();
				}
				this.EntityCtx.MergeFrom(other.EntityCtx);
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AA1C RID: 109084 RVA: 0x003E1520 File Offset: 0x003DF720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AA1D RID: 109085 RVA: 0x003E152C File Offset: 0x003DF72C
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					if (this.entityCtx_ == null)
					{
						this.EntityCtx = new EntityCtxPb();
					}
					input.ReadMessage(this.EntityCtx);
				}
			}
		}

		// Token: 0x04009C0A RID: 39946
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C0B RID: 39947
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04009C0C RID: 39948
		private EntityCtxPb entityCtx_;

		// Token: 0x04009C0D RID: 39949
		public const int IndexFieldNumber = 2;

		// Token: 0x04009C0E RID: 39950
		private int index_;
	}
}
