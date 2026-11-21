using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000217 RID: 535
	[NetMessage(EMessageId.BulletPatternNotify)]
	public sealed class BulletPatternNotify : IMessage<BulletPatternNotify>, IMessage, IEquatable<BulletPatternNotify>, IDeepCloneable<BulletPatternNotify>, IBufferMessage
	{
		// Token: 0x06003AE6 RID: 15078 RVA: 0x00092EEF File Offset: 0x000910EF
		[NullableContext(1)]
		public static BulletPatternNotify Create()
		{
			return new BulletPatternNotify();
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06003AE7 RID: 15079 RVA: 0x00092EF6 File Offset: 0x000910F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06003AE8 RID: 15080 RVA: 0x00092EF9 File Offset: 0x000910F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BulletPatternNotify.Descriptor;
			}
		}

		// Token: 0x06003AE9 RID: 15081 RVA: 0x00092F00 File Offset: 0x00091100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletPatternNotify()
		{
		}

		// Token: 0x06003AEA RID: 15082 RVA: 0x00092F08 File Offset: 0x00091108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletPatternNotify(BulletPatternNotify other) : this()
		{
			this.bulletPatternHandleId_ = other.bulletPatternHandleId_;
			this.bulletPatternId_ = other.bulletPatternId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003AEB RID: 15083 RVA: 0x00092F39 File Offset: 0x00091139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletPatternNotify Clone()
		{
			return new BulletPatternNotify(this);
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06003AEC RID: 15084 RVA: 0x00092F41 File Offset: 0x00091141
		// (set) Token: 0x06003AED RID: 15085 RVA: 0x00092F49 File Offset: 0x00091149
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

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06003AEE RID: 15086 RVA: 0x00092F52 File Offset: 0x00091152
		// (set) Token: 0x06003AEF RID: 15087 RVA: 0x00092F5A File Offset: 0x0009115A
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

		// Token: 0x06003AF0 RID: 15088 RVA: 0x00092F63 File Offset: 0x00091163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BulletPatternNotify);
		}

		// Token: 0x06003AF1 RID: 15089 RVA: 0x00092F71 File Offset: 0x00091171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BulletPatternNotify other)
		{
			return other != null && (other == this || (this.BulletPatternHandleId == other.BulletPatternHandleId && this.BulletPatternId == other.BulletPatternId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003AF2 RID: 15090 RVA: 0x00092FB0 File Offset: 0x000911B0
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

		// Token: 0x06003AF3 RID: 15091 RVA: 0x00093008 File Offset: 0x00091208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003AF4 RID: 15092 RVA: 0x00093015 File Offset: 0x00091215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003AF5 RID: 15093 RVA: 0x00093020 File Offset: 0x00091220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BulletPatternId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.BulletPatternId);
			}
			if (this.BulletPatternHandleId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.BulletPatternHandleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003AF6 RID: 15094 RVA: 0x0009307C File Offset: 0x0009127C
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

		// Token: 0x06003AF7 RID: 15095 RVA: 0x000930D4 File Offset: 0x000912D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BulletPatternNotify other)
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

		// Token: 0x06003AF8 RID: 15096 RVA: 0x00093124 File Offset: 0x00091324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003AF9 RID: 15097 RVA: 0x00093130 File Offset: 0x00091330
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
				if (num != 48U)
				{
					if (num != 72U)
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

		// Token: 0x04002C46 RID: 11334
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C47 RID: 11335
		public const int BulletPatternHandleIdFieldNumber = 9;

		// Token: 0x04002C48 RID: 11336
		private long bulletPatternHandleId_;

		// Token: 0x04002C49 RID: 11337
		public const int BulletPatternIdFieldNumber = 6;

		// Token: 0x04002C4A RID: 11338
		private int bulletPatternId_;
	}
}
