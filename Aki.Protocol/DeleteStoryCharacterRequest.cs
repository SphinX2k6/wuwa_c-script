using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003AA RID: 938
	[NetMessage(EMessageId.DeleteStoryCharacterRequest)]
	public sealed class DeleteStoryCharacterRequest : IMessage<DeleteStoryCharacterRequest>, IMessage, IEquatable<DeleteStoryCharacterRequest>, IDeepCloneable<DeleteStoryCharacterRequest>, IBufferMessage
	{
		// Token: 0x06005C73 RID: 23667 RVA: 0x000E0C3C File Offset: 0x000DEE3C
		[NullableContext(1)]
		public static DeleteStoryCharacterRequest Create()
		{
			return new DeleteStoryCharacterRequest();
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x06005C74 RID: 23668 RVA: 0x000E0C43 File Offset: 0x000DEE43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x06005C75 RID: 23669 RVA: 0x000E0C46 File Offset: 0x000DEE46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeleteStoryCharacterRequest.Descriptor;
			}
		}

		// Token: 0x06005C76 RID: 23670 RVA: 0x000E0C4D File Offset: 0x000DEE4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteStoryCharacterRequest()
		{
		}

		// Token: 0x06005C77 RID: 23671 RVA: 0x000E0C55 File Offset: 0x000DEE55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteStoryCharacterRequest(DeleteStoryCharacterRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C78 RID: 23672 RVA: 0x000E0C6E File Offset: 0x000DEE6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteStoryCharacterRequest Clone()
		{
			return new DeleteStoryCharacterRequest(this);
		}

		// Token: 0x06005C79 RID: 23673 RVA: 0x000E0C76 File Offset: 0x000DEE76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeleteStoryCharacterRequest);
		}

		// Token: 0x06005C7A RID: 23674 RVA: 0x000E0C84 File Offset: 0x000DEE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeleteStoryCharacterRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005C7B RID: 23675 RVA: 0x000E0CA4 File Offset: 0x000DEEA4
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

		// Token: 0x06005C7C RID: 23676 RVA: 0x000E0CCA File Offset: 0x000DEECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005C7D RID: 23677 RVA: 0x000E0CD7 File Offset: 0x000DEED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C7E RID: 23678 RVA: 0x000E0CE0 File Offset: 0x000DEEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C7F RID: 23679 RVA: 0x000E0CF8 File Offset: 0x000DEEF8
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

		// Token: 0x06005C80 RID: 23680 RVA: 0x000E0D1E File Offset: 0x000DEF1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeleteStoryCharacterRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005C81 RID: 23681 RVA: 0x000E0D3B File Offset: 0x000DEF3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C82 RID: 23682 RVA: 0x000E0D44 File Offset: 0x000DEF44
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

		// Token: 0x0400369E RID: 13982
		private UnknownFieldSet _unknownFields;
	}
}
