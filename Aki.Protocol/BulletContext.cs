using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000216 RID: 534
	public sealed class BulletContext : IMessage<BulletContext>, IMessage, IEquatable<BulletContext>, IDeepCloneable<BulletContext>, IBufferMessage
	{
		// Token: 0x06003AD2 RID: 15058 RVA: 0x00092C00 File Offset: 0x00090E00
		[NullableContext(1)]
		public static BulletContext Create()
		{
			return new BulletContext();
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06003AD3 RID: 15059 RVA: 0x00092C07 File Offset: 0x00090E07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06003AD4 RID: 15060 RVA: 0x00092C0A File Offset: 0x00090E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BulletContext.Descriptor;
			}
		}

		// Token: 0x06003AD5 RID: 15061 RVA: 0x00092C11 File Offset: 0x00090E11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletContext()
		{
		}

		// Token: 0x06003AD6 RID: 15062 RVA: 0x00092C1C File Offset: 0x00090E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletContext(BulletContext other) : this()
		{
			this.handle_ = ((other.handle_ != null) ? other.handle_.Clone() : null);
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003AD7 RID: 15063 RVA: 0x00092C68 File Offset: 0x00090E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletContext Clone()
		{
			return new BulletContext(this);
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06003AD8 RID: 15064 RVA: 0x00092C70 File Offset: 0x00090E70
		// (set) Token: 0x06003AD9 RID: 15065 RVA: 0x00092C78 File Offset: 0x00090E78
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

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06003ADA RID: 15066 RVA: 0x00092C81 File Offset: 0x00090E81
		// (set) Token: 0x06003ADB RID: 15067 RVA: 0x00092C89 File Offset: 0x00090E89
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

		// Token: 0x06003ADC RID: 15068 RVA: 0x00092C92 File Offset: 0x00090E92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BulletContext);
		}

		// Token: 0x06003ADD RID: 15069 RVA: 0x00092CA0 File Offset: 0x00090EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BulletContext other)
		{
			return other != null && (other == this || (object.Equals(this.Handle, other.Handle) && this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003ADE RID: 15070 RVA: 0x00092CF0 File Offset: 0x00090EF0
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

		// Token: 0x06003ADF RID: 15071 RVA: 0x00092D45 File Offset: 0x00090F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003AE0 RID: 15072 RVA: 0x00092D52 File Offset: 0x00090F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003AE1 RID: 15073 RVA: 0x00092D5C File Offset: 0x00090F5C
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

		// Token: 0x06003AE2 RID: 15074 RVA: 0x00092DB8 File Offset: 0x00090FB8
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

		// Token: 0x06003AE3 RID: 15075 RVA: 0x00092E10 File Offset: 0x00091010
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

		// Token: 0x06003AE4 RID: 15076 RVA: 0x00092E78 File Offset: 0x00091078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003AE5 RID: 15077 RVA: 0x00092E84 File Offset: 0x00091084
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

		// Token: 0x04002C41 RID: 11329
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C42 RID: 11330
		public const int HandleFieldNumber = 1;

		// Token: 0x04002C43 RID: 11331
		private ActiveBulletHandle handle_;

		// Token: 0x04002C44 RID: 11332
		public const int ContextIdFieldNumber = 2;

		// Token: 0x04002C45 RID: 11333
		private long contextId_;
	}
}
