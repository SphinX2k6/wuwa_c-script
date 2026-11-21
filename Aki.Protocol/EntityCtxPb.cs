using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200046A RID: 1130
	public sealed class EntityCtxPb : IMessage<EntityCtxPb>, IMessage, IEquatable<EntityCtxPb>, IDeepCloneable<EntityCtxPb>, IBufferMessage
	{
		// Token: 0x06006CE4 RID: 27876 RVA: 0x0010C52F File Offset: 0x0010A72F
		[NullableContext(1)]
		public static EntityCtxPb Create()
		{
			return new EntityCtxPb();
		}

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x06006CE5 RID: 27877 RVA: 0x0010C536 File Offset: 0x0010A736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x06006CE6 RID: 27878 RVA: 0x0010C539 File Offset: 0x0010A739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityCtxPb.Descriptor;
			}
		}

		// Token: 0x06006CE7 RID: 27879 RVA: 0x0010C540 File Offset: 0x0010A740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCtxPb()
		{
		}

		// Token: 0x06006CE8 RID: 27880 RVA: 0x0010C548 File Offset: 0x0010A748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCtxPb(EntityCtxPb other) : this()
		{
			this.configId_ = other.configId_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006CE9 RID: 27881 RVA: 0x0010C579 File Offset: 0x0010A779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCtxPb Clone()
		{
			return new EntityCtxPb(this);
		}

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x06006CEA RID: 27882 RVA: 0x0010C581 File Offset: 0x0010A781
		// (set) Token: 0x06006CEB RID: 27883 RVA: 0x0010C589 File Offset: 0x0010A789
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

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x06006CEC RID: 27884 RVA: 0x0010C592 File Offset: 0x0010A792
		// (set) Token: 0x06006CED RID: 27885 RVA: 0x0010C59A File Offset: 0x0010A79A
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

		// Token: 0x06006CEE RID: 27886 RVA: 0x0010C5A3 File Offset: 0x0010A7A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityCtxPb);
		}

		// Token: 0x06006CEF RID: 27887 RVA: 0x0010C5B1 File Offset: 0x0010A7B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityCtxPb other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006CF0 RID: 27888 RVA: 0x0010C5F0 File Offset: 0x0010A7F0
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

		// Token: 0x06006CF1 RID: 27889 RVA: 0x0010C648 File Offset: 0x0010A848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006CF2 RID: 27890 RVA: 0x0010C655 File Offset: 0x0010A855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006CF3 RID: 27891 RVA: 0x0010C660 File Offset: 0x0010A860
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

		// Token: 0x06006CF4 RID: 27892 RVA: 0x0010C6B8 File Offset: 0x0010A8B8
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

		// Token: 0x06006CF5 RID: 27893 RVA: 0x0010C710 File Offset: 0x0010A910
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

		// Token: 0x06006CF6 RID: 27894 RVA: 0x0010C760 File Offset: 0x0010A960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006CF7 RID: 27895 RVA: 0x0010C76C File Offset: 0x0010A96C
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

		// Token: 0x04003B93 RID: 15251
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B94 RID: 15252
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04003B95 RID: 15253
		private int configId_;

		// Token: 0x04003B96 RID: 15254
		public const int IncIdFieldNumber = 2;

		// Token: 0x04003B97 RID: 15255
		private long incId_;
	}
}
