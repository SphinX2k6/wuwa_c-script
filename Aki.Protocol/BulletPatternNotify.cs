using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000212 RID: 530
	[NetMessage(EMessageId.BulletPatternNotify)]
	public sealed class BulletPatternNotify : IMessage<BulletPatternNotify>, IMessage, IEquatable<BulletPatternNotify>, IDeepCloneable<BulletPatternNotify>, IBufferMessage
	{
		// Token: 0x06003A41 RID: 14913 RVA: 0x000912DB File Offset: 0x0008F4DB
		[NullableContext(1)]
		public static BulletPatternNotify Create()
		{
			return new BulletPatternNotify();
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06003A42 RID: 14914 RVA: 0x000912E2 File Offset: 0x0008F4E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06003A43 RID: 14915 RVA: 0x000912E5 File Offset: 0x0008F4E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BulletPatternNotify.Descriptor;
			}
		}

		// Token: 0x06003A44 RID: 14916 RVA: 0x000912EC File Offset: 0x0008F4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletPatternNotify()
		{
		}

		// Token: 0x06003A45 RID: 14917 RVA: 0x000912F4 File Offset: 0x0008F4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletPatternNotify(BulletPatternNotify other) : this()
		{
			this.bulletPatternHandleId_ = other.bulletPatternHandleId_;
			this.bulletPatternId_ = other.bulletPatternId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A46 RID: 14918 RVA: 0x00091325 File Offset: 0x0008F525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletPatternNotify Clone()
		{
			return new BulletPatternNotify(this);
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06003A47 RID: 14919 RVA: 0x0009132D File Offset: 0x0008F52D
		// (set) Token: 0x06003A48 RID: 14920 RVA: 0x00091335 File Offset: 0x0008F535
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

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06003A49 RID: 14921 RVA: 0x0009133E File Offset: 0x0008F53E
		// (set) Token: 0x06003A4A RID: 14922 RVA: 0x00091346 File Offset: 0x0008F546
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

		// Token: 0x06003A4B RID: 14923 RVA: 0x0009134F File Offset: 0x0008F54F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BulletPatternNotify);
		}

		// Token: 0x06003A4C RID: 14924 RVA: 0x0009135D File Offset: 0x0008F55D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BulletPatternNotify other)
		{
			return other != null && (other == this || (this.BulletPatternHandleId == other.BulletPatternHandleId && this.BulletPatternId == other.BulletPatternId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003A4D RID: 14925 RVA: 0x0009139C File Offset: 0x0008F59C
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

		// Token: 0x06003A4E RID: 14926 RVA: 0x000913F4 File Offset: 0x0008F5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003A4F RID: 14927 RVA: 0x00091401 File Offset: 0x0008F601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A50 RID: 14928 RVA: 0x0009140C File Offset: 0x0008F60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BulletPatternHandleId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.BulletPatternHandleId);
			}
			if (this.BulletPatternId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.BulletPatternId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A51 RID: 14929 RVA: 0x00091468 File Offset: 0x0008F668
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

		// Token: 0x06003A52 RID: 14930 RVA: 0x000914C0 File Offset: 0x0008F6C0
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

		// Token: 0x06003A53 RID: 14931 RVA: 0x00091510 File Offset: 0x0008F710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A54 RID: 14932 RVA: 0x0009151C File Offset: 0x0008F71C
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
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BulletPatternId = input.ReadInt32();
					}
				}
				else
				{
					this.BulletPatternHandleId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002BC4 RID: 11204
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BC5 RID: 11205
		public const int BulletPatternHandleIdFieldNumber = 6;

		// Token: 0x04002BC6 RID: 11206
		private long bulletPatternHandleId_;

		// Token: 0x04002BC7 RID: 11207
		public const int BulletPatternIdFieldNumber = 11;

		// Token: 0x04002BC8 RID: 11208
		private int bulletPatternId_;
	}
}
