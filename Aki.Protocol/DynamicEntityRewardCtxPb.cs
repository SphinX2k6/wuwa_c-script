using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000405 RID: 1029
	public sealed class DynamicEntityRewardCtxPb : IMessage<DynamicEntityRewardCtxPb>, IMessage, IEquatable<DynamicEntityRewardCtxPb>, IDeepCloneable<DynamicEntityRewardCtxPb>, IBufferMessage
	{
		// Token: 0x060063AC RID: 25516 RVA: 0x000F08D1 File Offset: 0x000EEAD1
		[NullableContext(1)]
		public static DynamicEntityRewardCtxPb Create()
		{
			return new DynamicEntityRewardCtxPb();
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x060063AD RID: 25517 RVA: 0x000F08D8 File Offset: 0x000EEAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x060063AE RID: 25518 RVA: 0x000F08DB File Offset: 0x000EEADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DynamicEntityRewardCtxPb.Descriptor;
			}
		}

		// Token: 0x060063AF RID: 25519 RVA: 0x000F08E2 File Offset: 0x000EEAE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicEntityRewardCtxPb()
		{
		}

		// Token: 0x060063B0 RID: 25520 RVA: 0x000F08EA File Offset: 0x000EEAEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicEntityRewardCtxPb(DynamicEntityRewardCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060063B1 RID: 25521 RVA: 0x000F091F File Offset: 0x000EEB1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicEntityRewardCtxPb Clone()
		{
			return new DynamicEntityRewardCtxPb(this);
		}

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x060063B2 RID: 25522 RVA: 0x000F0927 File Offset: 0x000EEB27
		// (set) Token: 0x060063B3 RID: 25523 RVA: 0x000F092F File Offset: 0x000EEB2F
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

		// Token: 0x060063B4 RID: 25524 RVA: 0x000F0938 File Offset: 0x000EEB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DynamicEntityRewardCtxPb);
		}

		// Token: 0x060063B5 RID: 25525 RVA: 0x000F0946 File Offset: 0x000EEB46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DynamicEntityRewardCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060063B6 RID: 25526 RVA: 0x000F097C File Offset: 0x000EEB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x060063B7 RID: 25527 RVA: 0x000F09B8 File Offset: 0x000EEBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060063B8 RID: 25528 RVA: 0x000F09C5 File Offset: 0x000EEBC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060063B9 RID: 25529 RVA: 0x000F09CE File Offset: 0x000EEBCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060063BA RID: 25530 RVA: 0x000F0A00 File Offset: 0x000EEC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x060063BB RID: 25531 RVA: 0x000F0A40 File Offset: 0x000EEC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DynamicEntityRewardCtxPb other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060063BC RID: 25532 RVA: 0x000F0A94 File Offset: 0x000EEC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060063BD RID: 25533 RVA: 0x000F0AA0 File Offset: 0x000EECA0
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
		}

		// Token: 0x040038B7 RID: 14519
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038B8 RID: 14520
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x040038B9 RID: 14521
		private EntityCtxPb entityCtx_;
	}
}
