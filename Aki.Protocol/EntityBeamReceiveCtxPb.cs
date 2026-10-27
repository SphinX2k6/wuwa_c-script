using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200046F RID: 1135
	public sealed class EntityBeamReceiveCtxPb : IMessage<EntityBeamReceiveCtxPb>, IMessage, IEquatable<EntityBeamReceiveCtxPb>, IDeepCloneable<EntityBeamReceiveCtxPb>, IBufferMessage
	{
		// Token: 0x06006C46 RID: 27718 RVA: 0x0010579F File Offset: 0x0010399F
		[NullableContext(1)]
		public static EntityBeamReceiveCtxPb Create()
		{
			return new EntityBeamReceiveCtxPb();
		}

		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x06006C47 RID: 27719 RVA: 0x001057A6 File Offset: 0x001039A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x06006C48 RID: 27720 RVA: 0x001057A9 File Offset: 0x001039A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBeamReceiveCtxPb.Descriptor;
			}
		}

		// Token: 0x06006C49 RID: 27721 RVA: 0x001057B0 File Offset: 0x001039B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBeamReceiveCtxPb()
		{
		}

		// Token: 0x06006C4A RID: 27722 RVA: 0x001057B8 File Offset: 0x001039B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBeamReceiveCtxPb(EntityBeamReceiveCtxPb other) : this()
		{
			this.receiveType_ = other.receiveType_;
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006C4B RID: 27723 RVA: 0x00105804 File Offset: 0x00103A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBeamReceiveCtxPb Clone()
		{
			return new EntityBeamReceiveCtxPb(this);
		}

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x06006C4C RID: 27724 RVA: 0x0010580C File Offset: 0x00103A0C
		// (set) Token: 0x06006C4D RID: 27725 RVA: 0x00105814 File Offset: 0x00103A14
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

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x06006C4E RID: 27726 RVA: 0x0010581D File Offset: 0x00103A1D
		// (set) Token: 0x06006C4F RID: 27727 RVA: 0x00105825 File Offset: 0x00103A25
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

		// Token: 0x06006C50 RID: 27728 RVA: 0x0010582E File Offset: 0x00103A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBeamReceiveCtxPb);
		}

		// Token: 0x06006C51 RID: 27729 RVA: 0x0010583C File Offset: 0x00103A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBeamReceiveCtxPb other)
		{
			return other != null && (other == this || (this.ReceiveType == other.ReceiveType && object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006C52 RID: 27730 RVA: 0x0010588C File Offset: 0x00103A8C
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

		// Token: 0x06006C53 RID: 27731 RVA: 0x001058E7 File Offset: 0x00103AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006C54 RID: 27732 RVA: 0x001058F4 File Offset: 0x00103AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006C55 RID: 27733 RVA: 0x00105900 File Offset: 0x00103B00
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

		// Token: 0x06006C56 RID: 27734 RVA: 0x00105958 File Offset: 0x00103B58
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

		// Token: 0x06006C57 RID: 27735 RVA: 0x001059B0 File Offset: 0x00103BB0
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

		// Token: 0x06006C58 RID: 27736 RVA: 0x00105A18 File Offset: 0x00103C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006C59 RID: 27737 RVA: 0x00105A24 File Offset: 0x00103C24
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

		// Token: 0x04003AE7 RID: 15079
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AE8 RID: 15080
		public const int ReceiveTypeFieldNumber = 1;

		// Token: 0x04003AE9 RID: 15081
		private EntityBeamReceiveType receiveType_;

		// Token: 0x04003AEA RID: 15082
		public const int EntityCtxFieldNumber = 2;

		// Token: 0x04003AEB RID: 15083
		private EntityCtxPb entityCtx_;
	}
}
