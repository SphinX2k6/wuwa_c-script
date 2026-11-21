using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200138A RID: 5002
	public sealed class TargetGearHitPartCtxPb : IMessage<TargetGearHitPartCtxPb>, IMessage, IEquatable<TargetGearHitPartCtxPb>, IDeepCloneable<TargetGearHitPartCtxPb>, IBufferMessage
	{
		// Token: 0x0601AA1E RID: 109086 RVA: 0x003E1597 File Offset: 0x003DF797
		[NullableContext(1)]
		public static TargetGearHitPartCtxPb Create()
		{
			return new TargetGearHitPartCtxPb();
		}

		// Token: 0x17005A2D RID: 23085
		// (get) Token: 0x0601AA1F RID: 109087 RVA: 0x003E159E File Offset: 0x003DF79E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A2E RID: 23086
		// (get) Token: 0x0601AA20 RID: 109088 RVA: 0x003E15A1 File Offset: 0x003DF7A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TargetGearHitPartCtxPb.Descriptor;
			}
		}

		// Token: 0x0601AA21 RID: 109089 RVA: 0x003E15A8 File Offset: 0x003DF7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearHitPartCtxPb()
		{
		}

		// Token: 0x0601AA22 RID: 109090 RVA: 0x003E15B0 File Offset: 0x003DF7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearHitPartCtxPb(TargetGearHitPartCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.hitPartIndex_ = other.hitPartIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AA23 RID: 109091 RVA: 0x003E15FC File Offset: 0x003DF7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearHitPartCtxPb Clone()
		{
			return new TargetGearHitPartCtxPb(this);
		}

		// Token: 0x17005A2F RID: 23087
		// (get) Token: 0x0601AA24 RID: 109092 RVA: 0x003E1604 File Offset: 0x003DF804
		// (set) Token: 0x0601AA25 RID: 109093 RVA: 0x003E160C File Offset: 0x003DF80C
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

		// Token: 0x17005A30 RID: 23088
		// (get) Token: 0x0601AA26 RID: 109094 RVA: 0x003E1615 File Offset: 0x003DF815
		// (set) Token: 0x0601AA27 RID: 109095 RVA: 0x003E161D File Offset: 0x003DF81D
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

		// Token: 0x0601AA28 RID: 109096 RVA: 0x003E1626 File Offset: 0x003DF826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TargetGearHitPartCtxPb);
		}

		// Token: 0x0601AA29 RID: 109097 RVA: 0x003E1634 File Offset: 0x003DF834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TargetGearHitPartCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.HitPartIndex == other.HitPartIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AA2A RID: 109098 RVA: 0x003E1684 File Offset: 0x003DF884
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

		// Token: 0x0601AA2B RID: 109099 RVA: 0x003E16D9 File Offset: 0x003DF8D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AA2C RID: 109100 RVA: 0x003E16E6 File Offset: 0x003DF8E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AA2D RID: 109101 RVA: 0x003E16F0 File Offset: 0x003DF8F0
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

		// Token: 0x0601AA2E RID: 109102 RVA: 0x003E174C File Offset: 0x003DF94C
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

		// Token: 0x0601AA2F RID: 109103 RVA: 0x003E17A4 File Offset: 0x003DF9A4
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

		// Token: 0x0601AA30 RID: 109104 RVA: 0x003E180C File Offset: 0x003DFA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AA31 RID: 109105 RVA: 0x003E1818 File Offset: 0x003DFA18
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

		// Token: 0x04009C0F RID: 39951
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C10 RID: 39952
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04009C11 RID: 39953
		private EntityCtxPb entityCtx_;

		// Token: 0x04009C12 RID: 39954
		public const int HitPartIndexFieldNumber = 2;

		// Token: 0x04009C13 RID: 39955
		private int hitPartIndex_;
	}
}
