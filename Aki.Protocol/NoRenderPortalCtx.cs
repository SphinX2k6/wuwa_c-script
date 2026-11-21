using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B49 RID: 2889
	public sealed class NoRenderPortalCtx : IMessage<NoRenderPortalCtx>, IMessage, IEquatable<NoRenderPortalCtx>, IDeepCloneable<NoRenderPortalCtx>, IBufferMessage
	{
		// Token: 0x0600FACA RID: 64202 RVA: 0x00248F88 File Offset: 0x00247188
		[NullableContext(1)]
		public static NoRenderPortalCtx Create()
		{
			return new NoRenderPortalCtx();
		}

		// Token: 0x1700331D RID: 13085
		// (get) Token: 0x0600FACB RID: 64203 RVA: 0x00248F8F File Offset: 0x0024718F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700331E RID: 13086
		// (get) Token: 0x0600FACC RID: 64204 RVA: 0x00248F92 File Offset: 0x00247192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NoRenderPortalCtx.Descriptor;
			}
		}

		// Token: 0x0600FACD RID: 64205 RVA: 0x00248F99 File Offset: 0x00247199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NoRenderPortalCtx()
		{
		}

		// Token: 0x0600FACE RID: 64206 RVA: 0x00248FA1 File Offset: 0x002471A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NoRenderPortalCtx(NoRenderPortalCtx other) : this()
		{
			this.entityId_ = other.entityId_;
			this.entityConfigId_ = other.entityConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FACF RID: 64207 RVA: 0x00248FD2 File Offset: 0x002471D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NoRenderPortalCtx Clone()
		{
			return new NoRenderPortalCtx(this);
		}

		// Token: 0x1700331F RID: 13087
		// (get) Token: 0x0600FAD0 RID: 64208 RVA: 0x00248FDA File Offset: 0x002471DA
		// (set) Token: 0x0600FAD1 RID: 64209 RVA: 0x00248FE2 File Offset: 0x002471E2
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

		// Token: 0x17003320 RID: 13088
		// (get) Token: 0x0600FAD2 RID: 64210 RVA: 0x00248FEB File Offset: 0x002471EB
		// (set) Token: 0x0600FAD3 RID: 64211 RVA: 0x00248FF3 File Offset: 0x002471F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfigId
		{
			get
			{
				return this.entityConfigId_;
			}
			set
			{
				this.entityConfigId_ = value;
			}
		}

		// Token: 0x0600FAD4 RID: 64212 RVA: 0x00248FFC File Offset: 0x002471FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NoRenderPortalCtx);
		}

		// Token: 0x0600FAD5 RID: 64213 RVA: 0x0024900A File Offset: 0x0024720A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NoRenderPortalCtx other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.EntityConfigId == other.EntityConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FAD6 RID: 64214 RVA: 0x00249048 File Offset: 0x00247248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.EntityConfigId != 0)
			{
				num ^= this.EntityConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FAD7 RID: 64215 RVA: 0x002490A0 File Offset: 0x002472A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FAD8 RID: 64216 RVA: 0x002490AD File Offset: 0x002472AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FAD9 RID: 64217 RVA: 0x002490B8 File Offset: 0x002472B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FADA RID: 64218 RVA: 0x00249110 File Offset: 0x00247310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.EntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FADB RID: 64219 RVA: 0x00249168 File Offset: 0x00247368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NoRenderPortalCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.EntityConfigId != 0)
			{
				this.EntityConfigId = other.EntityConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FADC RID: 64220 RVA: 0x002491B8 File Offset: 0x002473B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FADD RID: 64221 RVA: 0x002491C4 File Offset: 0x002473C4
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityConfigId = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040064AB RID: 25771
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064AC RID: 25772
		public const int EntityIdFieldNumber = 1;

		// Token: 0x040064AD RID: 25773
		private long entityId_;

		// Token: 0x040064AE RID: 25774
		public const int EntityConfigIdFieldNumber = 2;

		// Token: 0x040064AF RID: 25775
		private int entityConfigId_;
	}
}
