using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000458 RID: 1112
	public sealed class EntityBeamReceiveCtxPb : IMessage<EntityBeamReceiveCtxPb>, IMessage, IEquatable<EntityBeamReceiveCtxPb>, IDeepCloneable<EntityBeamReceiveCtxPb>, IBufferMessage
	{
		// Token: 0x06006AB8 RID: 27320 RVA: 0x0010272B File Offset: 0x0010092B
		[NullableContext(1)]
		public static EntityBeamReceiveCtxPb Create()
		{
			return new EntityBeamReceiveCtxPb();
		}

		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x06006AB9 RID: 27321 RVA: 0x00102732 File Offset: 0x00100932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x06006ABA RID: 27322 RVA: 0x00102735 File Offset: 0x00100935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBeamReceiveCtxPb.Descriptor;
			}
		}

		// Token: 0x06006ABB RID: 27323 RVA: 0x0010273C File Offset: 0x0010093C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBeamReceiveCtxPb()
		{
		}

		// Token: 0x06006ABC RID: 27324 RVA: 0x00102744 File Offset: 0x00100944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBeamReceiveCtxPb(EntityBeamReceiveCtxPb other) : this()
		{
			this.receiveType_ = other.receiveType_;
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006ABD RID: 27325 RVA: 0x00102790 File Offset: 0x00100990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBeamReceiveCtxPb Clone()
		{
			return new EntityBeamReceiveCtxPb(this);
		}

		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x06006ABE RID: 27326 RVA: 0x00102798 File Offset: 0x00100998
		// (set) Token: 0x06006ABF RID: 27327 RVA: 0x001027A0 File Offset: 0x001009A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBeamReceiveType ReceiveType
		{
			get
			{
				return this.receiveType_;
			}
			set
			{
				this.receiveType_ = value;
			}
		}

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x06006AC0 RID: 27328 RVA: 0x001027A9 File Offset: 0x001009A9
		// (set) Token: 0x06006AC1 RID: 27329 RVA: 0x001027B1 File Offset: 0x001009B1
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

		// Token: 0x06006AC2 RID: 27330 RVA: 0x001027BA File Offset: 0x001009BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBeamReceiveCtxPb);
		}

		// Token: 0x06006AC3 RID: 27331 RVA: 0x001027C8 File Offset: 0x001009C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBeamReceiveCtxPb other)
		{
			return other != null && (other == this || (this.ReceiveType == other.ReceiveType && object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006AC4 RID: 27332 RVA: 0x00102818 File Offset: 0x00100A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ReceiveType != EntityBeamReceiveType.BeginAction)
			{
				num ^= this.ReceiveType.GetHashCode();
			}
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006AC5 RID: 27333 RVA: 0x00102873 File Offset: 0x00100A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006AC6 RID: 27334 RVA: 0x00102880 File Offset: 0x00100A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006AC7 RID: 27335 RVA: 0x0010288C File Offset: 0x00100A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReceiveType != EntityBeamReceiveType.BeginAction)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ReceiveType);
			}
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.EntityCtx);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006AC8 RID: 27336 RVA: 0x001028E4 File Offset: 0x00100AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ReceiveType != EntityBeamReceiveType.BeginAction)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ReceiveType);
			}
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006AC9 RID: 27337 RVA: 0x0010293C File Offset: 0x00100B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityBeamReceiveCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ReceiveType != EntityBeamReceiveType.BeginAction)
			{
				this.ReceiveType = other.ReceiveType;
			}
			if (other.entityCtx_ != null)
			{
				if (this.entityCtx_ == null)
				{
					this.EntityCtx = new EntityCtxPb();
				}
				this.EntityCtx.MergeFrom(other.EntityCtx);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006ACA RID: 27338 RVA: 0x001029A4 File Offset: 0x00100BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006ACB RID: 27339 RVA: 0x001029B0 File Offset: 0x00100BB0
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.ReceiveType = (EntityBeamReceiveType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003AD5 RID: 15061
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AD6 RID: 15062
		public const int ReceiveTypeFieldNumber = 1;

		// Token: 0x04003AD7 RID: 15063
		private EntityBeamReceiveType receiveType_;

		// Token: 0x04003AD8 RID: 15064
		public const int EntityCtxFieldNumber = 2;

		// Token: 0x04003AD9 RID: 15065
		private EntityCtxPb entityCtx_;
	}
}
