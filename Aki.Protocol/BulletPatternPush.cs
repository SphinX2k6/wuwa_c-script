using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000213 RID: 531
	[NetMessage(EMessageId.BulletPatternPush)]
	public sealed class BulletPatternPush : IMessage<BulletPatternPush>, IMessage, IEquatable<BulletPatternPush>, IDeepCloneable<BulletPatternPush>, IBufferMessage
	{
		// Token: 0x06003A55 RID: 14933 RVA: 0x00091574 File Offset: 0x0008F774
		[NullableContext(1)]
		public static BulletPatternPush Create()
		{
			return new BulletPatternPush();
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06003A56 RID: 14934 RVA: 0x0009157B File Offset: 0x0008F77B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06003A57 RID: 14935 RVA: 0x0009157E File Offset: 0x0008F77E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BulletPatternPush.Descriptor;
			}
		}

		// Token: 0x06003A58 RID: 14936 RVA: 0x00091585 File Offset: 0x0008F785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletPatternPush()
		{
		}

		// Token: 0x06003A59 RID: 14937 RVA: 0x0009158D File Offset: 0x0008F78D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletPatternPush(BulletPatternPush other) : this()
		{
			this.bulletPatternHandleId_ = other.bulletPatternHandleId_;
			this.bulletPatternId_ = other.bulletPatternId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A5A RID: 14938 RVA: 0x000915BE File Offset: 0x0008F7BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletPatternPush Clone()
		{
			return new BulletPatternPush(this);
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06003A5B RID: 14939 RVA: 0x000915C6 File Offset: 0x0008F7C6
		// (set) Token: 0x06003A5C RID: 14940 RVA: 0x000915CE File Offset: 0x0008F7CE
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

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06003A5D RID: 14941 RVA: 0x000915D7 File Offset: 0x0008F7D7
		// (set) Token: 0x06003A5E RID: 14942 RVA: 0x000915DF File Offset: 0x0008F7DF
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

		// Token: 0x06003A5F RID: 14943 RVA: 0x000915E8 File Offset: 0x0008F7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BulletPatternPush);
		}

		// Token: 0x06003A60 RID: 14944 RVA: 0x000915F6 File Offset: 0x0008F7F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BulletPatternPush other)
		{
			return other != null && (other == this || (this.BulletPatternHandleId == other.BulletPatternHandleId && this.BulletPatternId == other.BulletPatternId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003A61 RID: 14945 RVA: 0x00091634 File Offset: 0x0008F834
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

		// Token: 0x06003A62 RID: 14946 RVA: 0x0009168C File Offset: 0x0008F88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003A63 RID: 14947 RVA: 0x00091699 File Offset: 0x0008F899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A64 RID: 14948 RVA: 0x000916A4 File Offset: 0x0008F8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BulletPatternId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BulletPatternId);
			}
			if (this.BulletPatternHandleId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.BulletPatternHandleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A65 RID: 14949 RVA: 0x000916FC File Offset: 0x0008F8FC
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

		// Token: 0x06003A66 RID: 14950 RVA: 0x00091754 File Offset: 0x0008F954
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

		// Token: 0x06003A67 RID: 14951 RVA: 0x000917A4 File Offset: 0x0008F9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A68 RID: 14952 RVA: 0x000917B0 File Offset: 0x0008F9B0
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
					if (num != 24U)
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

		// Token: 0x04002BC9 RID: 11209
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BCA RID: 11210
		public const int BulletPatternHandleIdFieldNumber = 3;

		// Token: 0x04002BCB RID: 11211
		private long bulletPatternHandleId_;

		// Token: 0x04002BCC RID: 11212
		public const int BulletPatternIdFieldNumber = 1;

		// Token: 0x04002BCD RID: 11213
		private int bulletPatternId_;
	}
}
