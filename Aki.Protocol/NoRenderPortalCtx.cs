using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B5A RID: 2906
	public sealed class NoRenderPortalCtx : IMessage<NoRenderPortalCtx>, IMessage, IEquatable<NoRenderPortalCtx>, IDeepCloneable<NoRenderPortalCtx>, IBufferMessage
	{
		// Token: 0x0600FBE4 RID: 64484 RVA: 0x0024B19C File Offset: 0x0024939C
		[NullableContext(1)]
		public static NoRenderPortalCtx Create()
		{
			return new NoRenderPortalCtx();
		}

		// Token: 0x1700335B RID: 13147
		// (get) Token: 0x0600FBE5 RID: 64485 RVA: 0x0024B1A3 File Offset: 0x002493A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700335C RID: 13148
		// (get) Token: 0x0600FBE6 RID: 64486 RVA: 0x0024B1A6 File Offset: 0x002493A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NoRenderPortalCtx.Descriptor;
			}
		}

		// Token: 0x0600FBE7 RID: 64487 RVA: 0x0024B1AD File Offset: 0x002493AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NoRenderPortalCtx()
		{
		}

		// Token: 0x0600FBE8 RID: 64488 RVA: 0x0024B1B5 File Offset: 0x002493B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NoRenderPortalCtx(NoRenderPortalCtx other) : this()
		{
			this.entityId_ = other.entityId_;
			this.entityConfigId_ = other.entityConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FBE9 RID: 64489 RVA: 0x0024B1E6 File Offset: 0x002493E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NoRenderPortalCtx Clone()
		{
			return new NoRenderPortalCtx(this);
		}

		// Token: 0x1700335D RID: 13149
		// (get) Token: 0x0600FBEA RID: 64490 RVA: 0x0024B1EE File Offset: 0x002493EE
		// (set) Token: 0x0600FBEB RID: 64491 RVA: 0x0024B1F6 File Offset: 0x002493F6
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

		// Token: 0x1700335E RID: 13150
		// (get) Token: 0x0600FBEC RID: 64492 RVA: 0x0024B1FF File Offset: 0x002493FF
		// (set) Token: 0x0600FBED RID: 64493 RVA: 0x0024B207 File Offset: 0x00249407
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

		// Token: 0x0600FBEE RID: 64494 RVA: 0x0024B210 File Offset: 0x00249410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NoRenderPortalCtx);
		}

		// Token: 0x0600FBEF RID: 64495 RVA: 0x0024B21E File Offset: 0x0024941E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NoRenderPortalCtx other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.EntityConfigId == other.EntityConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FBF0 RID: 64496 RVA: 0x0024B25C File Offset: 0x0024945C
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

		// Token: 0x0600FBF1 RID: 64497 RVA: 0x0024B2B4 File Offset: 0x002494B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FBF2 RID: 64498 RVA: 0x0024B2C1 File Offset: 0x002494C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FBF3 RID: 64499 RVA: 0x0024B2CC File Offset: 0x002494CC
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

		// Token: 0x0600FBF4 RID: 64500 RVA: 0x0024B324 File Offset: 0x00249524
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

		// Token: 0x0600FBF5 RID: 64501 RVA: 0x0024B37C File Offset: 0x0024957C
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

		// Token: 0x0600FBF6 RID: 64502 RVA: 0x0024B3CC File Offset: 0x002495CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FBF7 RID: 64503 RVA: 0x0024B3D8 File Offset: 0x002495D8
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

		// Token: 0x040064A2 RID: 25762
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064A3 RID: 25763
		public const int EntityIdFieldNumber = 1;

		// Token: 0x040064A4 RID: 25764
		private long entityId_;

		// Token: 0x040064A5 RID: 25765
		public const int EntityConfigIdFieldNumber = 2;

		// Token: 0x040064A6 RID: 25766
		private int entityConfigId_;
	}
}
