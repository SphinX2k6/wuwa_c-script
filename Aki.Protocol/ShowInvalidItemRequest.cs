using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001210 RID: 4624
	[NetMessage(EMessageId.ShowInvalidItemRequest)]
	public sealed class ShowInvalidItemRequest : IMessage<ShowInvalidItemRequest>, IMessage, IEquatable<ShowInvalidItemRequest>, IDeepCloneable<ShowInvalidItemRequest>, IBufferMessage
	{
		// Token: 0x06018A4E RID: 100942 RVA: 0x0039566D File Offset: 0x0039386D
		[NullableContext(1)]
		public static ShowInvalidItemRequest Create()
		{
			return new ShowInvalidItemRequest();
		}

		// Token: 0x17005307 RID: 21255
		// (get) Token: 0x06018A4F RID: 100943 RVA: 0x00395674 File Offset: 0x00393874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005308 RID: 21256
		// (get) Token: 0x06018A50 RID: 100944 RVA: 0x00395677 File Offset: 0x00393877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShowInvalidItemRequest.Descriptor;
			}
		}

		// Token: 0x06018A51 RID: 100945 RVA: 0x0039567E File Offset: 0x0039387E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowInvalidItemRequest()
		{
		}

		// Token: 0x06018A52 RID: 100946 RVA: 0x00395686 File Offset: 0x00393886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowInvalidItemRequest(ShowInvalidItemRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018A53 RID: 100947 RVA: 0x0039569F File Offset: 0x0039389F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowInvalidItemRequest Clone()
		{
			return new ShowInvalidItemRequest(this);
		}

		// Token: 0x06018A54 RID: 100948 RVA: 0x003956A7 File Offset: 0x003938A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShowInvalidItemRequest);
		}

		// Token: 0x06018A55 RID: 100949 RVA: 0x003956B5 File Offset: 0x003938B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShowInvalidItemRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06018A56 RID: 100950 RVA: 0x003956D4 File Offset: 0x003938D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018A57 RID: 100951 RVA: 0x003956FA File Offset: 0x003938FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018A58 RID: 100952 RVA: 0x00395707 File Offset: 0x00393907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018A59 RID: 100953 RVA: 0x00395710 File Offset: 0x00393910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018A5A RID: 100954 RVA: 0x00395728 File Offset: 0x00393928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018A5B RID: 100955 RVA: 0x0039574E File Offset: 0x0039394E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShowInvalidItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018A5C RID: 100956 RVA: 0x0039576B File Offset: 0x0039396B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018A5D RID: 100957 RVA: 0x00395774 File Offset: 0x00393974
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009196 RID: 37270
		private UnknownFieldSet _unknownFields;
	}
}
