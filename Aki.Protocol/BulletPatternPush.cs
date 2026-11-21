using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000218 RID: 536
	[NetMessage(EMessageId.BulletPatternPush)]
	public sealed class BulletPatternPush : IMessage<BulletPatternPush>, IMessage, IEquatable<BulletPatternPush>, IDeepCloneable<BulletPatternPush>, IBufferMessage
	{
		// Token: 0x06003AFA RID: 15098 RVA: 0x00093188 File Offset: 0x00091388
		[NullableContext(1)]
		public static BulletPatternPush Create()
		{
			return new BulletPatternPush();
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06003AFB RID: 15099 RVA: 0x0009318F File Offset: 0x0009138F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06003AFC RID: 15100 RVA: 0x00093192 File Offset: 0x00091392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BulletPatternPush.Descriptor;
			}
		}

		// Token: 0x06003AFD RID: 15101 RVA: 0x00093199 File Offset: 0x00091399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletPatternPush()
		{
		}

		// Token: 0x06003AFE RID: 15102 RVA: 0x000931A1 File Offset: 0x000913A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletPatternPush(BulletPatternPush other) : this()
		{
			this.bulletPatternHandleId_ = other.bulletPatternHandleId_;
			this.bulletPatternId_ = other.bulletPatternId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003AFF RID: 15103 RVA: 0x000931D2 File Offset: 0x000913D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletPatternPush Clone()
		{
			return new BulletPatternPush(this);
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06003B00 RID: 15104 RVA: 0x000931DA File Offset: 0x000913DA
		// (set) Token: 0x06003B01 RID: 15105 RVA: 0x000931E2 File Offset: 0x000913E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BulletPatternHandleId
		{
			get
			{
				return this.bulletPatternHandleId_;
			}
			set
			{
				this.bulletPatternHandleId_ = value;
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06003B02 RID: 15106 RVA: 0x000931EB File Offset: 0x000913EB
		// (set) Token: 0x06003B03 RID: 15107 RVA: 0x000931F3 File Offset: 0x000913F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BulletPatternId
		{
			get
			{
				return this.bulletPatternId_;
			}
			set
			{
				this.bulletPatternId_ = value;
			}
		}

		// Token: 0x06003B04 RID: 15108 RVA: 0x000931FC File Offset: 0x000913FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BulletPatternPush);
		}

		// Token: 0x06003B05 RID: 15109 RVA: 0x0009320A File Offset: 0x0009140A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BulletPatternPush other)
		{
			return other != null && (other == this || (this.BulletPatternHandleId == other.BulletPatternHandleId && this.BulletPatternId == other.BulletPatternId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003B06 RID: 15110 RVA: 0x00093248 File Offset: 0x00091448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BulletPatternHandleId != 0L)
			{
				num ^= this.BulletPatternHandleId.GetHashCode();
			}
			if (this.BulletPatternId != 0)
			{
				num ^= this.BulletPatternId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003B07 RID: 15111 RVA: 0x000932A0 File Offset: 0x000914A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003B08 RID: 15112 RVA: 0x000932AD File Offset: 0x000914AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B09 RID: 15113 RVA: 0x000932B8 File Offset: 0x000914B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BulletPatternId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BulletPatternId);
			}
			if (this.BulletPatternHandleId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.BulletPatternHandleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003B0A RID: 15114 RVA: 0x00093314 File Offset: 0x00091514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BulletPatternHandleId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BulletPatternHandleId);
			}
			if (this.BulletPatternId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BulletPatternId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003B0B RID: 15115 RVA: 0x0009336C File Offset: 0x0009156C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BulletPatternPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BulletPatternHandleId != 0L)
			{
				this.BulletPatternHandleId = other.BulletPatternHandleId;
			}
			if (other.BulletPatternId != 0)
			{
				this.BulletPatternId = other.BulletPatternId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003B0C RID: 15116 RVA: 0x000933BC File Offset: 0x000915BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B0D RID: 15117 RVA: 0x000933C8 File Offset: 0x000915C8
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
				if (num != 24U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BulletPatternHandleId = input.ReadInt64();
					}
				}
				else
				{
					this.BulletPatternId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002C4B RID: 11339
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C4C RID: 11340
		public const int BulletPatternHandleIdFieldNumber = 5;

		// Token: 0x04002C4D RID: 11341
		private long bulletPatternHandleId_;

		// Token: 0x04002C4E RID: 11342
		public const int BulletPatternIdFieldNumber = 3;

		// Token: 0x04002C4F RID: 11343
		private int bulletPatternId_;
	}
}
