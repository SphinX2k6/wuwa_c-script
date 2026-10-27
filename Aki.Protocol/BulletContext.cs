using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000211 RID: 529
	public sealed class BulletContext : IMessage<BulletContext>, IMessage, IEquatable<BulletContext>, IDeepCloneable<BulletContext>, IBufferMessage
	{
		// Token: 0x06003A2D RID: 14893 RVA: 0x00090FEC File Offset: 0x0008F1EC
		[NullableContext(1)]
		public static BulletContext Create()
		{
			return new BulletContext();
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06003A2E RID: 14894 RVA: 0x00090FF3 File Offset: 0x0008F1F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06003A2F RID: 14895 RVA: 0x00090FF6 File Offset: 0x0008F1F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BulletContext.Descriptor;
			}
		}

		// Token: 0x06003A30 RID: 14896 RVA: 0x00090FFD File Offset: 0x0008F1FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletContext()
		{
		}

		// Token: 0x06003A31 RID: 14897 RVA: 0x00091008 File Offset: 0x0008F208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletContext(BulletContext other) : this()
		{
			this.handle_ = ((other.handle_ != null) ? other.handle_.Clone() : null);
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A32 RID: 14898 RVA: 0x00091054 File Offset: 0x0008F254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletContext Clone()
		{
			return new BulletContext(this);
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06003A33 RID: 14899 RVA: 0x0009105C File Offset: 0x0008F25C
		// (set) Token: 0x06003A34 RID: 14900 RVA: 0x00091064 File Offset: 0x0008F264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActiveBulletHandle Handle
		{
			get
			{
				return this.handle_;
			}
			set
			{
				this.handle_ = value;
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06003A35 RID: 14901 RVA: 0x0009106D File Offset: 0x0008F26D
		// (set) Token: 0x06003A36 RID: 14902 RVA: 0x00091075 File Offset: 0x0008F275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ContextId
		{
			get
			{
				return this.contextId_;
			}
			set
			{
				this.contextId_ = value;
			}
		}

		// Token: 0x06003A37 RID: 14903 RVA: 0x0009107E File Offset: 0x0008F27E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BulletContext);
		}

		// Token: 0x06003A38 RID: 14904 RVA: 0x0009108C File Offset: 0x0008F28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BulletContext other)
		{
			return other != null && (other == this || (object.Equals(this.Handle, other.Handle) && this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003A39 RID: 14905 RVA: 0x000910DC File Offset: 0x0008F2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.handle_ != null)
			{
				num ^= this.Handle.GetHashCode();
			}
			if (this.ContextId != 0L)
			{
				num ^= this.ContextId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003A3A RID: 14906 RVA: 0x00091131 File Offset: 0x0008F331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003A3B RID: 14907 RVA: 0x0009113E File Offset: 0x0008F33E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A3C RID: 14908 RVA: 0x00091148 File Offset: 0x0008F348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.handle_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Handle);
			}
			if (this.ContextId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A3D RID: 14909 RVA: 0x000911A4 File Offset: 0x0008F3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.handle_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Handle);
			}
			if (this.ContextId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003A3E RID: 14910 RVA: 0x000911FC File Offset: 0x0008F3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BulletContext other)
		{
			if (other == null)
			{
				return;
			}
			if (other.handle_ != null)
			{
				if (this.handle_ == null)
				{
					this.Handle = new ActiveBulletHandle();
				}
				this.Handle.MergeFrom(other.Handle);
			}
			if (other.ContextId != 0L)
			{
				this.ContextId = other.ContextId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003A3F RID: 14911 RVA: 0x00091264 File Offset: 0x0008F464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A40 RID: 14912 RVA: 0x00091270 File Offset: 0x0008F470
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
						this.ContextId = input.ReadInt64();
					}
				}
				else
				{
					if (this.handle_ == null)
					{
						this.Handle = new ActiveBulletHandle();
					}
					input.ReadMessage(this.Handle);
				}
			}
		}

		// Token: 0x04002BBF RID: 11199
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BC0 RID: 11200
		public const int HandleFieldNumber = 1;

		// Token: 0x04002BC1 RID: 11201
		private ActiveBulletHandle handle_;

		// Token: 0x04002BC2 RID: 11202
		public const int ContextIdFieldNumber = 2;

		// Token: 0x04002BC3 RID: 11203
		private long contextId_;
	}
}
