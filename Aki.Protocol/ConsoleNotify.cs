using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002DD RID: 733
	[NetMessage(EMessageId.ConsoleNotify)]
	public sealed class ConsoleNotify : IMessage<ConsoleNotify>, IMessage, IEquatable<ConsoleNotify>, IDeepCloneable<ConsoleNotify>, IBufferMessage
	{
		// Token: 0x06004ACB RID: 19147 RVA: 0x000B673D File Offset: 0x000B493D
		[NullableContext(1)]
		public static ConsoleNotify Create()
		{
			return new ConsoleNotify();
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06004ACC RID: 19148 RVA: 0x000B6744 File Offset: 0x000B4944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x06004ACD RID: 19149 RVA: 0x000B6747 File Offset: 0x000B4947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsoleNotify.Descriptor;
			}
		}

		// Token: 0x06004ACE RID: 19150 RVA: 0x000B674E File Offset: 0x000B494E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsoleNotify()
		{
		}

		// Token: 0x06004ACF RID: 19151 RVA: 0x000B676C File Offset: 0x000B496C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsoleNotify(ConsoleNotify other) : this()
		{
			this.type_ = other.type_;
			this.content_ = other.content_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004AD0 RID: 19152 RVA: 0x000B679D File Offset: 0x000B499D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsoleNotify Clone()
		{
			return new ConsoleNotify(this);
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x06004AD1 RID: 19153 RVA: 0x000B67A5 File Offset: 0x000B49A5
		// (set) Token: 0x06004AD2 RID: 19154 RVA: 0x000B67AD File Offset: 0x000B49AD
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

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x06004AD3 RID: 19155 RVA: 0x000B67C0 File Offset: 0x000B49C0
		// (set) Token: 0x06004AD4 RID: 19156 RVA: 0x000B67C8 File Offset: 0x000B49C8
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

		// Token: 0x06004AD5 RID: 19157 RVA: 0x000B67DB File Offset: 0x000B49DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsoleNotify);
		}

		// Token: 0x06004AD6 RID: 19158 RVA: 0x000B67EC File Offset: 0x000B49EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsoleNotify other)
		{
			return other != null && (other == this || (!(this.Type != other.Type) && !(this.Content != other.Content) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x000B6840 File Offset: 0x000B4A40
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

		// Token: 0x06004AD8 RID: 19160 RVA: 0x000B689C File Offset: 0x000B4A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004AD9 RID: 19161 RVA: 0x000B68A9 File Offset: 0x000B4AA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004ADA RID: 19162 RVA: 0x000B68B4 File Offset: 0x000B4AB4
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
				output.WriteRawTag(106);
				output.WriteString(this.Content);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004ADB RID: 19163 RVA: 0x000B6918 File Offset: 0x000B4B18
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

		// Token: 0x06004ADC RID: 19164 RVA: 0x000B6978 File Offset: 0x000B4B78
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

		// Token: 0x06004ADD RID: 19165 RVA: 0x000B69D2 File Offset: 0x000B4BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004ADE RID: 19166 RVA: 0x000B69DC File Offset: 0x000B4BDC
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
					if (num != 106U)
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

		// Token: 0x0400308D RID: 12429
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400308E RID: 12430
		public const int TypeFieldNumber = 8;

		// Token: 0x0400308F RID: 12431
		private string type_ = "";

		// Token: 0x04003090 RID: 12432
		public const int ContentFieldNumber = 13;

		// Token: 0x04003091 RID: 12433
		private string content_ = "";
	}
}
