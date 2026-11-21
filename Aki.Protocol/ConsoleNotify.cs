using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002E4 RID: 740
	[NetMessage(EMessageId.ConsoleNotify)]
	public sealed class ConsoleNotify : IMessage<ConsoleNotify>, IMessage, IEquatable<ConsoleNotify>, IDeepCloneable<ConsoleNotify>, IBufferMessage
	{
		// Token: 0x06004BA4 RID: 19364 RVA: 0x000B8B25 File Offset: 0x000B6D25
		[NullableContext(1)]
		public static ConsoleNotify Create()
		{
			return new ConsoleNotify();
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06004BA5 RID: 19365 RVA: 0x000B8B2C File Offset: 0x000B6D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06004BA6 RID: 19366 RVA: 0x000B8B2F File Offset: 0x000B6D2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsoleNotify.Descriptor;
			}
		}

		// Token: 0x06004BA7 RID: 19367 RVA: 0x000B8B36 File Offset: 0x000B6D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsoleNotify()
		{
		}

		// Token: 0x06004BA8 RID: 19368 RVA: 0x000B8B54 File Offset: 0x000B6D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsoleNotify(ConsoleNotify other) : this()
		{
			this.type_ = other.type_;
			this.content_ = other.content_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004BA9 RID: 19369 RVA: 0x000B8B85 File Offset: 0x000B6D85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsoleNotify Clone()
		{
			return new ConsoleNotify(this);
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06004BAA RID: 19370 RVA: 0x000B8B8D File Offset: 0x000B6D8D
		// (set) Token: 0x06004BAB RID: 19371 RVA: 0x000B8B95 File Offset: 0x000B6D95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x06004BAC RID: 19372 RVA: 0x000B8BA8 File Offset: 0x000B6DA8
		// (set) Token: 0x06004BAD RID: 19373 RVA: 0x000B8BB0 File Offset: 0x000B6DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Content
		{
			get
			{
				return this.content_;
			}
			set
			{
				this.content_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06004BAE RID: 19374 RVA: 0x000B8BC3 File Offset: 0x000B6DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsoleNotify);
		}

		// Token: 0x06004BAF RID: 19375 RVA: 0x000B8BD4 File Offset: 0x000B6DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsoleNotify other)
		{
			return other != null && (other == this || (!(this.Type != other.Type) && !(this.Content != other.Content) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004BB0 RID: 19376 RVA: 0x000B8C28 File Offset: 0x000B6E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type.Length != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Content.Length != 0)
			{
				num ^= this.Content.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004BB1 RID: 19377 RVA: 0x000B8C84 File Offset: 0x000B6E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004BB2 RID: 19378 RVA: 0x000B8C91 File Offset: 0x000B6E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004BB3 RID: 19379 RVA: 0x000B8C9C File Offset: 0x000B6E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.Type);
			}
			if (this.Content.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.Content);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004BB4 RID: 19380 RVA: 0x000B8D00 File Offset: 0x000B6F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Type);
			}
			if (this.Content.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Content);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004BB5 RID: 19381 RVA: 0x000B8D60 File Offset: 0x000B6F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConsoleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type.Length != 0)
			{
				this.Type = other.Type;
			}
			if (other.Content.Length != 0)
			{
				this.Content = other.Content;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004BB6 RID: 19382 RVA: 0x000B8DBA File Offset: 0x000B6FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004BB7 RID: 19383 RVA: 0x000B8DC4 File Offset: 0x000B6FC4
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
				if (num != 66U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Content = input.ReadString();
					}
				}
				else
				{
					this.Type = input.ReadString();
				}
			}
		}

		// Token: 0x04003124 RID: 12580
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003125 RID: 12581
		public const int TypeFieldNumber = 8;

		// Token: 0x04003126 RID: 12582
		private string type_ = "";

		// Token: 0x04003127 RID: 12583
		public const int ContentFieldNumber = 10;

		// Token: 0x04003128 RID: 12584
		private string content_ = "";
	}
}
