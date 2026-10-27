using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200131C RID: 4892
	public sealed class TargetGearActionByHitTypeCtxPb : IMessage<TargetGearActionByHitTypeCtxPb>, IMessage, IEquatable<TargetGearActionByHitTypeCtxPb>, IDeepCloneable<TargetGearActionByHitTypeCtxPb>, IBufferMessage
	{
		// Token: 0x06019FFA RID: 106490 RVA: 0x003C6FEC File Offset: 0x003C51EC
		[NullableContext(1)]
		public static TargetGearActionByHitTypeCtxPb Create()
		{
			return new TargetGearActionByHitTypeCtxPb();
		}

		// Token: 0x170057AF RID: 22447
		// (get) Token: 0x06019FFB RID: 106491 RVA: 0x003C6FF3 File Offset: 0x003C51F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057B0 RID: 22448
		// (get) Token: 0x06019FFC RID: 106492 RVA: 0x003C6FF6 File Offset: 0x003C51F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TargetGearActionByHitTypeCtxPb.Descriptor;
			}
		}

		// Token: 0x06019FFD RID: 106493 RVA: 0x003C6FFD File Offset: 0x003C51FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearActionByHitTypeCtxPb()
		{
		}

		// Token: 0x06019FFE RID: 106494 RVA: 0x003C7008 File Offset: 0x003C5208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearActionByHitTypeCtxPb(TargetGearActionByHitTypeCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019FFF RID: 106495 RVA: 0x003C7054 File Offset: 0x003C5254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearActionByHitTypeCtxPb Clone()
		{
			return new TargetGearActionByHitTypeCtxPb(this);
		}

		// Token: 0x170057B1 RID: 22449
		// (get) Token: 0x0601A000 RID: 106496 RVA: 0x003C705C File Offset: 0x003C525C
		// (set) Token: 0x0601A001 RID: 106497 RVA: 0x003C7064 File Offset: 0x003C5264
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

		// Token: 0x170057B2 RID: 22450
		// (get) Token: 0x0601A002 RID: 106498 RVA: 0x003C706D File Offset: 0x003C526D
		// (set) Token: 0x0601A003 RID: 106499 RVA: 0x003C7075 File Offset: 0x003C5275
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

		// Token: 0x0601A004 RID: 106500 RVA: 0x003C707E File Offset: 0x003C527E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TargetGearActionByHitTypeCtxPb);
		}

		// Token: 0x0601A005 RID: 106501 RVA: 0x003C708C File Offset: 0x003C528C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TargetGearActionByHitTypeCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A006 RID: 106502 RVA: 0x003C70DC File Offset: 0x003C52DC
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

		// Token: 0x0601A007 RID: 106503 RVA: 0x003C7131 File Offset: 0x003C5331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A008 RID: 106504 RVA: 0x003C713E File Offset: 0x003C533E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A009 RID: 106505 RVA: 0x003C7148 File Offset: 0x003C5348
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

		// Token: 0x0601A00A RID: 106506 RVA: 0x003C71A4 File Offset: 0x003C53A4
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

		// Token: 0x0601A00B RID: 106507 RVA: 0x003C71FC File Offset: 0x003C53FC
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

		// Token: 0x0601A00C RID: 106508 RVA: 0x003C7264 File Offset: 0x003C5464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A00D RID: 106509 RVA: 0x003C7270 File Offset: 0x003C5470
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

		// Token: 0x040097E8 RID: 38888
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097E9 RID: 38889
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x040097EA RID: 38890
		private EntityCtxPb entityCtx_;

		// Token: 0x040097EB RID: 38891
		public const int IndexFieldNumber = 2;

		// Token: 0x040097EC RID: 38892
		private int index_;
	}
}
