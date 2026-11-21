using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000453 RID: 1107
	public sealed class EntityAfterConditionActionCtxPb : IMessage<EntityAfterConditionActionCtxPb>, IMessage, IEquatable<EntityAfterConditionActionCtxPb>, IDeepCloneable<EntityAfterConditionActionCtxPb>, IBufferMessage
	{
		// Token: 0x06006A38 RID: 27192 RVA: 0x00100EA1 File Offset: 0x000FF0A1
		[NullableContext(1)]
		public static EntityAfterConditionActionCtxPb Create()
		{
			return new EntityAfterConditionActionCtxPb();
		}

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x06006A39 RID: 27193 RVA: 0x00100EA8 File Offset: 0x000FF0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x06006A3A RID: 27194 RVA: 0x00100EAB File Offset: 0x000FF0AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityAfterConditionActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06006A3B RID: 27195 RVA: 0x00100EB2 File Offset: 0x000FF0B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAfterConditionActionCtxPb()
		{
		}

		// Token: 0x06006A3C RID: 27196 RVA: 0x00100EBC File Offset: 0x000FF0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAfterConditionActionCtxPb(EntityAfterConditionActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.preConditionListeningIndex_ = other.preConditionListeningIndex_;
			this.afterConditionActionIndex_ = other.afterConditionActionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A3D RID: 27197 RVA: 0x00100F14 File Offset: 0x000FF114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAfterConditionActionCtxPb Clone()
		{
			return new EntityAfterConditionActionCtxPb(this);
		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x06006A3E RID: 27198 RVA: 0x00100F1C File Offset: 0x000FF11C
		// (set) Token: 0x06006A3F RID: 27199 RVA: 0x00100F24 File Offset: 0x000FF124
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

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x06006A40 RID: 27200 RVA: 0x00100F2D File Offset: 0x000FF12D
		// (set) Token: 0x06006A41 RID: 27201 RVA: 0x00100F35 File Offset: 0x000FF135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PreConditionListeningIndex
		{
			get
			{
				return this.preConditionListeningIndex_;
			}
			set
			{
				this.preConditionListeningIndex_ = value;
			}
		}

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x06006A42 RID: 27202 RVA: 0x00100F3E File Offset: 0x000FF13E
		// (set) Token: 0x06006A43 RID: 27203 RVA: 0x00100F46 File Offset: 0x000FF146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AfterConditionActionIndex
		{
			get
			{
				return this.afterConditionActionIndex_;
			}
			set
			{
				this.afterConditionActionIndex_ = value;
			}
		}

		// Token: 0x06006A44 RID: 27204 RVA: 0x00100F4F File Offset: 0x000FF14F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityAfterConditionActionCtxPb);
		}

		// Token: 0x06006A45 RID: 27205 RVA: 0x00100F60 File Offset: 0x000FF160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityAfterConditionActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.PreConditionListeningIndex == other.PreConditionListeningIndex && this.AfterConditionActionIndex == other.AfterConditionActionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006A46 RID: 27206 RVA: 0x00100FC0 File Offset: 0x000FF1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this.PreConditionListeningIndex != 0)
			{
				num ^= this.PreConditionListeningIndex.GetHashCode();
			}
			if (this.AfterConditionActionIndex != 0)
			{
				num ^= this.AfterConditionActionIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006A47 RID: 27207 RVA: 0x0010102E File Offset: 0x000FF22E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006A48 RID: 27208 RVA: 0x0010103B File Offset: 0x000FF23B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A49 RID: 27209 RVA: 0x00101044 File Offset: 0x000FF244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.PreConditionListeningIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PreConditionListeningIndex);
			}
			if (this.AfterConditionActionIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.AfterConditionActionIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A4A RID: 27210 RVA: 0x001010BC File Offset: 0x000FF2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this.PreConditionListeningIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PreConditionListeningIndex);
			}
			if (this.AfterConditionActionIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AfterConditionActionIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006A4B RID: 27211 RVA: 0x0010112C File Offset: 0x000FF32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityAfterConditionActionCtxPb other)
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
			if (other.PreConditionListeningIndex != 0)
			{
				this.PreConditionListeningIndex = other.PreConditionListeningIndex;
			}
			if (other.AfterConditionActionIndex != 0)
			{
				this.AfterConditionActionIndex = other.AfterConditionActionIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006A4C RID: 27212 RVA: 0x001011A8 File Offset: 0x000FF3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A4D RID: 27213 RVA: 0x001011B4 File Offset: 0x000FF3B4
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.AfterConditionActionIndex = input.ReadInt32();
						}
					}
					else
					{
						this.PreConditionListeningIndex = input.ReadInt32();
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

		// Token: 0x04003A9C RID: 15004
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A9D RID: 15005
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04003A9E RID: 15006
		private EntityCtxPb entityCtx_;

		// Token: 0x04003A9F RID: 15007
		public const int PreConditionListeningIndexFieldNumber = 2;

		// Token: 0x04003AA0 RID: 15008
		private int preConditionListeningIndex_;

		// Token: 0x04003AA1 RID: 15009
		public const int AfterConditionActionIndexFieldNumber = 3;

		// Token: 0x04003AA2 RID: 15010
		private int afterConditionActionIndex_;
	}
}
