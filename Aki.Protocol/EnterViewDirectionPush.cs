using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000444 RID: 1092
	[NetMessage(EMessageId.EnterViewDirectionPush)]
	public sealed class EnterViewDirectionPush : IMessage<EnterViewDirectionPush>, IMessage, IEquatable<EnterViewDirectionPush>, IDeepCloneable<EnterViewDirectionPush>, IBufferMessage
	{
		// Token: 0x06006904 RID: 26884 RVA: 0x000FE3B0 File Offset: 0x000FC5B0
		[NullableContext(1)]
		public static EnterViewDirectionPush Create()
		{
			return new EnterViewDirectionPush();
		}

		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x06006905 RID: 26885 RVA: 0x000FE3B7 File Offset: 0x000FC5B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x06006906 RID: 26886 RVA: 0x000FE3BA File Offset: 0x000FC5BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterViewDirectionPush.Descriptor;
			}
		}

		// Token: 0x06006907 RID: 26887 RVA: 0x000FE3C1 File Offset: 0x000FC5C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterViewDirectionPush()
		{
		}

		// Token: 0x06006908 RID: 26888 RVA: 0x000FE3C9 File Offset: 0x000FC5C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterViewDirectionPush(EnterViewDirectionPush other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006909 RID: 26889 RVA: 0x000FE3E2 File Offset: 0x000FC5E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterViewDirectionPush Clone()
		{
			return new EnterViewDirectionPush(this);
		}

		// Token: 0x0600690A RID: 26890 RVA: 0x000FE3EA File Offset: 0x000FC5EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterViewDirectionPush);
		}

		// Token: 0x0600690B RID: 26891 RVA: 0x000FE3F8 File Offset: 0x000FC5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterViewDirectionPush other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600690C RID: 26892 RVA: 0x000FE418 File Offset: 0x000FC618
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

		// Token: 0x0600690D RID: 26893 RVA: 0x000FE43E File Offset: 0x000FC63E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600690E RID: 26894 RVA: 0x000FE44B File Offset: 0x000FC64B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600690F RID: 26895 RVA: 0x000FE454 File Offset: 0x000FC654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006910 RID: 26896 RVA: 0x000FE46C File Offset: 0x000FC66C
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

		// Token: 0x06006911 RID: 26897 RVA: 0x000FE492 File Offset: 0x000FC692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterViewDirectionPush other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006912 RID: 26898 RVA: 0x000FE4AF File Offset: 0x000FC6AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006913 RID: 26899 RVA: 0x000FE4B8 File Offset: 0x000FC6B8
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

		// Token: 0x04003A43 RID: 14915
		private UnknownFieldSet _unknownFields;
	}
}
