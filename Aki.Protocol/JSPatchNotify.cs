using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200086A RID: 2154
	[NetMessage(EMessageId.JSPatchNotify)]
	public sealed class JSPatchNotify : IMessage<JSPatchNotify>, IMessage, IEquatable<JSPatchNotify>, IDeepCloneable<JSPatchNotify>, IBufferMessage
	{
		// Token: 0x0600C031 RID: 49201 RVA: 0x001C9050 File Offset: 0x001C7250
		[NullableContext(1)]
		public static JSPatchNotify Create()
		{
			return new JSPatchNotify();
		}

		// Token: 0x170026D2 RID: 9938
		// (get) Token: 0x0600C032 RID: 49202 RVA: 0x001C9057 File Offset: 0x001C7257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026D3 RID: 9939
		// (get) Token: 0x0600C033 RID: 49203 RVA: 0x001C905A File Offset: 0x001C725A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JSPatchNotify.Descriptor;
			}
		}

		// Token: 0x0600C034 RID: 49204 RVA: 0x001C9061 File Offset: 0x001C7261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JSPatchNotify()
		{
		}

		// Token: 0x0600C035 RID: 49205 RVA: 0x001C9074 File Offset: 0x001C7274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JSPatchNotify(JSPatchNotify other) : this()
		{
			this.content_ = other.content_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C036 RID: 49206 RVA: 0x001C9099 File Offset: 0x001C7299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JSPatchNotify Clone()
		{
			return new JSPatchNotify(this);
		}

		// Token: 0x170026D4 RID: 9940
		// (get) Token: 0x0600C037 RID: 49207 RVA: 0x001C90A1 File Offset: 0x001C72A1
		// (set) Token: 0x0600C038 RID: 49208 RVA: 0x001C90A9 File Offset: 0x001C72A9
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

		// Token: 0x0600C039 RID: 49209 RVA: 0x001C90BC File Offset: 0x001C72BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JSPatchNotify);
		}

		// Token: 0x0600C03A RID: 49210 RVA: 0x001C90CA File Offset: 0x001C72CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JSPatchNotify other)
		{
			return other != null && (other == this || (!(this.Content != other.Content) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C03B RID: 49211 RVA: 0x001C9100 File Offset: 0x001C7300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600C03C RID: 49212 RVA: 0x001C9141 File Offset: 0x001C7341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C03D RID: 49213 RVA: 0x001C914E File Offset: 0x001C734E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C03E RID: 49214 RVA: 0x001C9157 File Offset: 0x001C7357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Content.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Content);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C03F RID: 49215 RVA: 0x001C9190 File Offset: 0x001C7390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600C040 RID: 49216 RVA: 0x001C91D3 File Offset: 0x001C73D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JSPatchNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Content.Length != 0)
			{
				this.Content = other.Content;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C041 RID: 49217 RVA: 0x001C9209 File Offset: 0x001C7409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C042 RID: 49218 RVA: 0x001C9214 File Offset: 0x001C7414
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Content = input.ReadString();
				}
			}
		}

		// Token: 0x040053E3 RID: 21475
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053E4 RID: 21476
		public const int ContentFieldNumber = 5;

		// Token: 0x040053E5 RID: 21477
		private string content_ = "";
	}
}
