using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200131D RID: 4893
	public sealed class TargetGearHitPartCtxPb : IMessage<TargetGearHitPartCtxPb>, IMessage, IEquatable<TargetGearHitPartCtxPb>, IDeepCloneable<TargetGearHitPartCtxPb>, IBufferMessage
	{
		// Token: 0x0601A00E RID: 106510 RVA: 0x003C72DB File Offset: 0x003C54DB
		[NullableContext(1)]
		public static TargetGearHitPartCtxPb Create()
		{
			return new TargetGearHitPartCtxPb();
		}

		// Token: 0x170057B3 RID: 22451
		// (get) Token: 0x0601A00F RID: 106511 RVA: 0x003C72E2 File Offset: 0x003C54E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057B4 RID: 22452
		// (get) Token: 0x0601A010 RID: 106512 RVA: 0x003C72E5 File Offset: 0x003C54E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TargetGearHitPartCtxPb.Descriptor;
			}
		}

		// Token: 0x0601A011 RID: 106513 RVA: 0x003C72EC File Offset: 0x003C54EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearHitPartCtxPb()
		{
		}

		// Token: 0x0601A012 RID: 106514 RVA: 0x003C72F4 File Offset: 0x003C54F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearHitPartCtxPb(TargetGearHitPartCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.hitPartIndex_ = other.hitPartIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A013 RID: 106515 RVA: 0x003C7340 File Offset: 0x003C5540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearHitPartCtxPb Clone()
		{
			return new TargetGearHitPartCtxPb(this);
		}

		// Token: 0x170057B5 RID: 22453
		// (get) Token: 0x0601A014 RID: 106516 RVA: 0x003C7348 File Offset: 0x003C5548
		// (set) Token: 0x0601A015 RID: 106517 RVA: 0x003C7350 File Offset: 0x003C5550
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

		// Token: 0x170057B6 RID: 22454
		// (get) Token: 0x0601A016 RID: 106518 RVA: 0x003C7359 File Offset: 0x003C5559
		// (set) Token: 0x0601A017 RID: 106519 RVA: 0x003C7361 File Offset: 0x003C5561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HitPartIndex
		{
			get
			{
				return this.hitPartIndex_;
			}
			set
			{
				this.hitPartIndex_ = value;
			}
		}

		// Token: 0x0601A018 RID: 106520 RVA: 0x003C736A File Offset: 0x003C556A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TargetGearHitPartCtxPb);
		}

		// Token: 0x0601A019 RID: 106521 RVA: 0x003C7378 File Offset: 0x003C5578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TargetGearHitPartCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.HitPartIndex == other.HitPartIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A01A RID: 106522 RVA: 0x003C73C8 File Offset: 0x003C55C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this.HitPartIndex != 0)
			{
				num ^= this.HitPartIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A01B RID: 106523 RVA: 0x003C741D File Offset: 0x003C561D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A01C RID: 106524 RVA: 0x003C742A File Offset: 0x003C562A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A01D RID: 106525 RVA: 0x003C7434 File Offset: 0x003C5634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.HitPartIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HitPartIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A01E RID: 106526 RVA: 0x003C7490 File Offset: 0x003C5690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this.HitPartIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HitPartIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A01F RID: 106527 RVA: 0x003C74E8 File Offset: 0x003C56E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TargetGearHitPartCtxPb other)
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
			if (other.HitPartIndex != 0)
			{
				this.HitPartIndex = other.HitPartIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A020 RID: 106528 RVA: 0x003C7550 File Offset: 0x003C5750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A021 RID: 106529 RVA: 0x003C755C File Offset: 0x003C575C
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
						this.HitPartIndex = input.ReadInt32();
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

		// Token: 0x040097ED RID: 38893
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097EE RID: 38894
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x040097EF RID: 38895
		private EntityCtxPb entityCtx_;

		// Token: 0x040097F0 RID: 38896
		public const int HitPartIndexFieldNumber = 2;

		// Token: 0x040097F1 RID: 38897
		private int hitPartIndex_;
	}
}
