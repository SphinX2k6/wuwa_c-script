using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000481 RID: 1153
	public sealed class EntityCtxPb : IMessage<EntityCtxPb>, IMessage, IEquatable<EntityCtxPb>, IDeepCloneable<EntityCtxPb>, IBufferMessage
	{
		// Token: 0x06006E72 RID: 28274 RVA: 0x0010F5A3 File Offset: 0x0010D7A3
		[NullableContext(1)]
		public static EntityCtxPb Create()
		{
			return new EntityCtxPb();
		}

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x06006E73 RID: 28275 RVA: 0x0010F5AA File Offset: 0x0010D7AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x06006E74 RID: 28276 RVA: 0x0010F5AD File Offset: 0x0010D7AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityCtxPb.Descriptor;
			}
		}

		// Token: 0x06006E75 RID: 28277 RVA: 0x0010F5B4 File Offset: 0x0010D7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCtxPb()
		{
		}

		// Token: 0x06006E76 RID: 28278 RVA: 0x0010F5BC File Offset: 0x0010D7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCtxPb(EntityCtxPb other) : this()
		{
			this.configId_ = other.configId_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006E77 RID: 28279 RVA: 0x0010F5ED File Offset: 0x0010D7ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCtxPb Clone()
		{
			return new EntityCtxPb(this);
		}

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x06006E78 RID: 28280 RVA: 0x0010F5F5 File Offset: 0x0010D7F5
		// (set) Token: 0x06006E79 RID: 28281 RVA: 0x0010F5FD File Offset: 0x0010D7FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x06006E7A RID: 28282 RVA: 0x0010F606 File Offset: 0x0010D806
		// (set) Token: 0x06006E7B RID: 28283 RVA: 0x0010F60E File Offset: 0x0010D80E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x06006E7C RID: 28284 RVA: 0x0010F617 File Offset: 0x0010D817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityCtxPb);
		}

		// Token: 0x06006E7D RID: 28285 RVA: 0x0010F625 File Offset: 0x0010D825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityCtxPb other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006E7E RID: 28286 RVA: 0x0010F664 File Offset: 0x0010D864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.IncId != 0L)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006E7F RID: 28287 RVA: 0x0010F6BC File Offset: 0x0010D8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006E80 RID: 28288 RVA: 0x0010F6C9 File Offset: 0x0010D8C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E81 RID: 28289 RVA: 0x0010F6D4 File Offset: 0x0010D8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.IncId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006E82 RID: 28290 RVA: 0x0010F72C File Offset: 0x0010D92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.IncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006E83 RID: 28291 RVA: 0x0010F784 File Offset: 0x0010D984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.IncId != 0L)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006E84 RID: 28292 RVA: 0x0010F7D4 File Offset: 0x0010D9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E85 RID: 28293 RVA: 0x0010F7E0 File Offset: 0x0010D9E0
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
						this.IncId = input.ReadInt64();
					}
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003BA5 RID: 15269
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BA6 RID: 15270
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04003BA7 RID: 15271
		private int configId_;

		// Token: 0x04003BA8 RID: 15272
		public const int IncIdFieldNumber = 2;

		// Token: 0x04003BA9 RID: 15273
		private long incId_;
	}
}
