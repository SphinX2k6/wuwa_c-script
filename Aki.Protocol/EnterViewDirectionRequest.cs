using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000445 RID: 1093
	[NetMessage(EMessageId.EnterViewDirectionRequest)]
	public sealed class EnterViewDirectionRequest : IMessage<EnterViewDirectionRequest>, IMessage, IEquatable<EnterViewDirectionRequest>, IDeepCloneable<EnterViewDirectionRequest>, IBufferMessage
	{
		// Token: 0x06006914 RID: 26900 RVA: 0x000FE4EA File Offset: 0x000FC6EA
		[NullableContext(1)]
		public static EnterViewDirectionRequest Create()
		{
			return new EnterViewDirectionRequest();
		}

		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x06006915 RID: 26901 RVA: 0x000FE4F1 File Offset: 0x000FC6F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x06006916 RID: 26902 RVA: 0x000FE4F4 File Offset: 0x000FC6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterViewDirectionRequest.Descriptor;
			}
		}

		// Token: 0x06006917 RID: 26903 RVA: 0x000FE4FB File Offset: 0x000FC6FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterViewDirectionRequest()
		{
		}

		// Token: 0x06006918 RID: 26904 RVA: 0x000FE503 File Offset: 0x000FC703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterViewDirectionRequest(EnterViewDirectionRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006919 RID: 26905 RVA: 0x000FE51C File Offset: 0x000FC71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterViewDirectionRequest Clone()
		{
			return new EnterViewDirectionRequest(this);
		}

		// Token: 0x0600691A RID: 26906 RVA: 0x000FE524 File Offset: 0x000FC724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterViewDirectionRequest);
		}

		// Token: 0x0600691B RID: 26907 RVA: 0x000FE532 File Offset: 0x000FC732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterViewDirectionRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600691C RID: 26908 RVA: 0x000FE550 File Offset: 0x000FC750
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

		// Token: 0x0600691D RID: 26909 RVA: 0x000FE576 File Offset: 0x000FC776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600691E RID: 26910 RVA: 0x000FE583 File Offset: 0x000FC783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600691F RID: 26911 RVA: 0x000FE58C File Offset: 0x000FC78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006920 RID: 26912 RVA: 0x000FE5A4 File Offset: 0x000FC7A4
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

		// Token: 0x06006921 RID: 26913 RVA: 0x000FE5CA File Offset: 0x000FC7CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterViewDirectionRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006922 RID: 26914 RVA: 0x000FE5E7 File Offset: 0x000FC7E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006923 RID: 26915 RVA: 0x000FE5F0 File Offset: 0x000FC7F0
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

		// Token: 0x04003A44 RID: 14916
		private UnknownFieldSet _unknownFields;
	}
}
