using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200031D RID: 797
	[NetMessage(EMessageId.CreatStoryCharacterRequest)]
	public sealed class CreatStoryCharacterRequest : IMessage<CreatStoryCharacterRequest>, IMessage, IEquatable<CreatStoryCharacterRequest>, IDeepCloneable<CreatStoryCharacterRequest>, IBufferMessage
	{
		// Token: 0x0600508E RID: 20622 RVA: 0x000C4C6C File Offset: 0x000C2E6C
		[NullableContext(1)]
		public static CreatStoryCharacterRequest Create()
		{
			return new CreatStoryCharacterRequest();
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x0600508F RID: 20623 RVA: 0x000C4C73 File Offset: 0x000C2E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06005090 RID: 20624 RVA: 0x000C4C76 File Offset: 0x000C2E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreatStoryCharacterRequest.Descriptor;
			}
		}

		// Token: 0x06005091 RID: 20625 RVA: 0x000C4C7D File Offset: 0x000C2E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreatStoryCharacterRequest()
		{
		}

		// Token: 0x06005092 RID: 20626 RVA: 0x000C4C85 File Offset: 0x000C2E85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreatStoryCharacterRequest(CreatStoryCharacterRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005093 RID: 20627 RVA: 0x000C4C9E File Offset: 0x000C2E9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreatStoryCharacterRequest Clone()
		{
			return new CreatStoryCharacterRequest(this);
		}

		// Token: 0x06005094 RID: 20628 RVA: 0x000C4CA6 File Offset: 0x000C2EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreatStoryCharacterRequest);
		}

		// Token: 0x06005095 RID: 20629 RVA: 0x000C4CB4 File Offset: 0x000C2EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CreatStoryCharacterRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005096 RID: 20630 RVA: 0x000C4CD4 File Offset: 0x000C2ED4
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

		// Token: 0x06005097 RID: 20631 RVA: 0x000C4CFA File Offset: 0x000C2EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005098 RID: 20632 RVA: 0x000C4D07 File Offset: 0x000C2F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005099 RID: 20633 RVA: 0x000C4D10 File Offset: 0x000C2F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600509A RID: 20634 RVA: 0x000C4D28 File Offset: 0x000C2F28
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

		// Token: 0x0600509B RID: 20635 RVA: 0x000C4D4E File Offset: 0x000C2F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CreatStoryCharacterRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600509C RID: 20636 RVA: 0x000C4D6B File Offset: 0x000C2F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600509D RID: 20637 RVA: 0x000C4D74 File Offset: 0x000C2F74
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

		// Token: 0x040032C2 RID: 12994
		private UnknownFieldSet _unknownFields;
	}
}
