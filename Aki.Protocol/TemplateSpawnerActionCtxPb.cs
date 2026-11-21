using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013BB RID: 5051
	public sealed class TemplateSpawnerActionCtxPb : IMessage<TemplateSpawnerActionCtxPb>, IMessage, IEquatable<TemplateSpawnerActionCtxPb>, IDeepCloneable<TemplateSpawnerActionCtxPb>, IBufferMessage
	{
		// Token: 0x0601AE1F RID: 110111 RVA: 0x003EA5BE File Offset: 0x003E87BE
		[NullableContext(1)]
		public static TemplateSpawnerActionCtxPb Create()
		{
			return new TemplateSpawnerActionCtxPb();
		}

		// Token: 0x17005B0B RID: 23307
		// (get) Token: 0x0601AE20 RID: 110112 RVA: 0x003EA5C5 File Offset: 0x003E87C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B0C RID: 23308
		// (get) Token: 0x0601AE21 RID: 110113 RVA: 0x003EA5C8 File Offset: 0x003E87C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TemplateSpawnerActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0601AE22 RID: 110114 RVA: 0x003EA5CF File Offset: 0x003E87CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemplateSpawnerActionCtxPb()
		{
		}

		// Token: 0x0601AE23 RID: 110115 RVA: 0x003EA5D8 File Offset: 0x003E87D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemplateSpawnerActionCtxPb(TemplateSpawnerActionCtxPb other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.destroyType_ = other.destroyType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AE24 RID: 110116 RVA: 0x003EA630 File Offset: 0x003E8830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemplateSpawnerActionCtxPb Clone()
		{
			return new TemplateSpawnerActionCtxPb(this);
		}

		// Token: 0x17005B0D RID: 23309
		// (get) Token: 0x0601AE25 RID: 110117 RVA: 0x003EA638 File Offset: 0x003E8838
		// (set) Token: 0x0601AE26 RID: 110118 RVA: 0x003EA640 File Offset: 0x003E8840
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

		// Token: 0x17005B0E RID: 23310
		// (get) Token: 0x0601AE27 RID: 110119 RVA: 0x003EA649 File Offset: 0x003E8849
		// (set) Token: 0x0601AE28 RID: 110120 RVA: 0x003EA661 File Offset: 0x003E8861
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

		// Token: 0x17005B0F RID: 23311
		// (get) Token: 0x0601AE29 RID: 110121 RVA: 0x003EA678 File Offset: 0x003E8878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDestroyType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0601AE2A RID: 110122 RVA: 0x003EA685 File Offset: 0x003E8885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDestroyType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0601AE2B RID: 110123 RVA: 0x003EA696 File Offset: 0x003E8896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TemplateSpawnerActionCtxPb);
		}

		// Token: 0x0601AE2C RID: 110124 RVA: 0x003EA6A4 File Offset: 0x003E88A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TemplateSpawnerActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.DestroyType == other.DestroyType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AE2D RID: 110125 RVA: 0x003EA6F4 File Offset: 0x003E88F4
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

		// Token: 0x0601AE2E RID: 110126 RVA: 0x003EA749 File Offset: 0x003E8949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AE2F RID: 110127 RVA: 0x003EA756 File Offset: 0x003E8956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AE30 RID: 110128 RVA: 0x003EA760 File Offset: 0x003E8960
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

		// Token: 0x0601AE31 RID: 110129 RVA: 0x003EA7BC File Offset: 0x003E89BC
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

		// Token: 0x0601AE32 RID: 110130 RVA: 0x003EA814 File Offset: 0x003E8A14
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

		// Token: 0x0601AE33 RID: 110131 RVA: 0x003EA87C File Offset: 0x003E8A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AE34 RID: 110132 RVA: 0x003EA888 File Offset: 0x003E8A88
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

		// Token: 0x04009D41 RID: 40257
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D42 RID: 40258
		private int _hasBits0;

		// Token: 0x04009D43 RID: 40259
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04009D44 RID: 40260
		private EntityCtxPb entityCtx_;

		// Token: 0x04009D45 RID: 40261
		public const int DestroyTypeFieldNumber = 2;

		// Token: 0x04009D46 RID: 40262
		private static readonly int DestroyTypeDefaultValue;

		// Token: 0x04009D47 RID: 40263
		private int destroyType_;
	}
}
