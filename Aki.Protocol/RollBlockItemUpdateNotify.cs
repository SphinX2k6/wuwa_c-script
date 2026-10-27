using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010DF RID: 4319
	[NetMessage(EMessageId.RollBlockItemUpdateNotify)]
	public sealed class RollBlockItemUpdateNotify : IMessage<RollBlockItemUpdateNotify>, IMessage, IEquatable<RollBlockItemUpdateNotify>, IDeepCloneable<RollBlockItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x060170A7 RID: 94375 RVA: 0x00358241 File Offset: 0x00356441
		[NullableContext(1)]
		public static RollBlockItemUpdateNotify Create()
		{
			return new RollBlockItemUpdateNotify();
		}

		// Token: 0x17004D30 RID: 19760
		// (get) Token: 0x060170A8 RID: 94376 RVA: 0x00358248 File Offset: 0x00356448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D31 RID: 19761
		// (get) Token: 0x060170A9 RID: 94377 RVA: 0x0035824B File Offset: 0x0035644B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060170AA RID: 94378 RVA: 0x00358252 File Offset: 0x00356452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockItemUpdateNotify()
		{
		}

		// Token: 0x060170AB RID: 94379 RVA: 0x0035825C File Offset: 0x0035645C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockItemUpdateNotify(RollBlockItemUpdateNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.component_ = ((other.component_ != null) ? other.component_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060170AC RID: 94380 RVA: 0x003582A8 File Offset: 0x003564A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockItemUpdateNotify Clone()
		{
			return new RollBlockItemUpdateNotify(this);
		}

		// Token: 0x17004D32 RID: 19762
		// (get) Token: 0x060170AD RID: 94381 RVA: 0x003582B0 File Offset: 0x003564B0
		// (set) Token: 0x060170AE RID: 94382 RVA: 0x003582B8 File Offset: 0x003564B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17004D33 RID: 19763
		// (get) Token: 0x060170AF RID: 94383 RVA: 0x003582C1 File Offset: 0x003564C1
		// (set) Token: 0x060170B0 RID: 94384 RVA: 0x003582C9 File Offset: 0x003564C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbItemComponentPb Component
		{
			get
			{
				return this.component_;
			}
			set
			{
				this.component_ = value;
			}
		}

		// Token: 0x060170B1 RID: 94385 RVA: 0x003582D2 File Offset: 0x003564D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockItemUpdateNotify);
		}

		// Token: 0x060170B2 RID: 94386 RVA: 0x003582E0 File Offset: 0x003564E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockItemUpdateNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.Component, other.Component) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060170B3 RID: 94387 RVA: 0x00358330 File Offset: 0x00356530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.component_ != null)
			{
				num ^= this.Component.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060170B4 RID: 94388 RVA: 0x00358385 File Offset: 0x00356585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060170B5 RID: 94389 RVA: 0x00358392 File Offset: 0x00356592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060170B6 RID: 94390 RVA: 0x0035839C File Offset: 0x0035659C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.component_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Component);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060170B7 RID: 94391 RVA: 0x003583F8 File Offset: 0x003565F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.component_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Component);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060170B8 RID: 94392 RVA: 0x00358450 File Offset: 0x00356650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockItemUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.component_ != null)
			{
				if (this.component_ == null)
				{
					this.Component = new RbItemComponentPb();
				}
				this.Component.MergeFrom(other.Component);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060170B9 RID: 94393 RVA: 0x003584B8 File Offset: 0x003566B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060170BA RID: 94394 RVA: 0x003584C4 File Offset: 0x003566C4
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
				if (num != 26U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					if (this.component_ == null)
					{
						this.Component = new RbItemComponentPb();
					}
					input.ReadMessage(this.Component);
				}
			}
		}

		// Token: 0x04008927 RID: 35111
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008928 RID: 35112
		public const int EntityIdFieldNumber = 10;

		// Token: 0x04008929 RID: 35113
		private long entityId_;

		// Token: 0x0400892A RID: 35114
		public const int ComponentFieldNumber = 3;

		// Token: 0x0400892B RID: 35115
		private RbItemComponentPb component_;
	}
}
