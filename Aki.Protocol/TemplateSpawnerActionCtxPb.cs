using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001348 RID: 4936
	public sealed class TemplateSpawnerActionCtxPb : IMessage<TemplateSpawnerActionCtxPb>, IMessage, IEquatable<TemplateSpawnerActionCtxPb>, IDeepCloneable<TemplateSpawnerActionCtxPb>, IBufferMessage
	{
		// Token: 0x0601A398 RID: 107416 RVA: 0x003CF48F File Offset: 0x003CD68F
		[NullableContext(1)]
		public static TemplateSpawnerActionCtxPb Create()
		{
			return new TemplateSpawnerActionCtxPb();
		}

		// Token: 0x17005878 RID: 22648
		// (get) Token: 0x0601A399 RID: 107417 RVA: 0x003CF496 File Offset: 0x003CD696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005879 RID: 22649
		// (get) Token: 0x0601A39A RID: 107418 RVA: 0x003CF499 File Offset: 0x003CD699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TemplateSpawnerActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0601A39B RID: 107419 RVA: 0x003CF4A0 File Offset: 0x003CD6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemplateSpawnerActionCtxPb()
		{
		}

		// Token: 0x0601A39C RID: 107420 RVA: 0x003CF4A8 File Offset: 0x003CD6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemplateSpawnerActionCtxPb(TemplateSpawnerActionCtxPb other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.destroyType_ = other.destroyType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A39D RID: 107421 RVA: 0x003CF500 File Offset: 0x003CD700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemplateSpawnerActionCtxPb Clone()
		{
			return new TemplateSpawnerActionCtxPb(this);
		}

		// Token: 0x1700587A RID: 22650
		// (get) Token: 0x0601A39E RID: 107422 RVA: 0x003CF508 File Offset: 0x003CD708
		// (set) Token: 0x0601A39F RID: 107423 RVA: 0x003CF510 File Offset: 0x003CD710
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

		// Token: 0x1700587B RID: 22651
		// (get) Token: 0x0601A3A0 RID: 107424 RVA: 0x003CF519 File Offset: 0x003CD719
		// (set) Token: 0x0601A3A1 RID: 107425 RVA: 0x003CF531 File Offset: 0x003CD731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DestroyType
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.destroyType_;
				}
				return TemplateSpawnerActionCtxPb.DestroyTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.destroyType_ = value;
			}
		}

		// Token: 0x1700587C RID: 22652
		// (get) Token: 0x0601A3A2 RID: 107426 RVA: 0x003CF548 File Offset: 0x003CD748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDestroyType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0601A3A3 RID: 107427 RVA: 0x003CF555 File Offset: 0x003CD755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDestroyType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0601A3A4 RID: 107428 RVA: 0x003CF566 File Offset: 0x003CD766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TemplateSpawnerActionCtxPb);
		}

		// Token: 0x0601A3A5 RID: 107429 RVA: 0x003CF574 File Offset: 0x003CD774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TemplateSpawnerActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.DestroyType == other.DestroyType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A3A6 RID: 107430 RVA: 0x003CF5C4 File Offset: 0x003CD7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this.HasDestroyType)
			{
				num ^= this.DestroyType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A3A7 RID: 107431 RVA: 0x003CF619 File Offset: 0x003CD819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A3A8 RID: 107432 RVA: 0x003CF626 File Offset: 0x003CD826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A3A9 RID: 107433 RVA: 0x003CF630 File Offset: 0x003CD830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.HasDestroyType)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DestroyType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A3AA RID: 107434 RVA: 0x003CF68C File Offset: 0x003CD88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this.HasDestroyType)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DestroyType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A3AB RID: 107435 RVA: 0x003CF6E4 File Offset: 0x003CD8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TemplateSpawnerActionCtxPb other)
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
			if (other.HasDestroyType)
			{
				this.DestroyType = other.DestroyType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A3AC RID: 107436 RVA: 0x003CF74C File Offset: 0x003CD94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A3AD RID: 107437 RVA: 0x003CF758 File Offset: 0x003CD958
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
						this.DestroyType = input.ReadInt32();
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

		// Token: 0x040098FF RID: 39167
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009900 RID: 39168
		private int _hasBits0;

		// Token: 0x04009901 RID: 39169
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04009902 RID: 39170
		private EntityCtxPb entityCtx_;

		// Token: 0x04009903 RID: 39171
		public const int DestroyTypeFieldNumber = 2;

		// Token: 0x04009904 RID: 39172
		private static readonly int DestroyTypeDefaultValue;

		// Token: 0x04009905 RID: 39173
		private int destroyType_;
	}
}
