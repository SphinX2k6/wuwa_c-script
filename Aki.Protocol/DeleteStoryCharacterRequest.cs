using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003C1 RID: 961
	[NetMessage(EMessageId.DeleteStoryCharacterRequest)]
	public sealed class DeleteStoryCharacterRequest : IMessage<DeleteStoryCharacterRequest>, IMessage, IEquatable<DeleteStoryCharacterRequest>, IDeepCloneable<DeleteStoryCharacterRequest>, IBufferMessage
	{
		// Token: 0x06005E03 RID: 24067 RVA: 0x000E3DC0 File Offset: 0x000E1FC0
		[NullableContext(1)]
		public static DeleteStoryCharacterRequest Create()
		{
			return new DeleteStoryCharacterRequest();
		}

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x06005E04 RID: 24068 RVA: 0x000E3DC7 File Offset: 0x000E1FC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x06005E05 RID: 24069 RVA: 0x000E3DCA File Offset: 0x000E1FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeleteStoryCharacterRequest.Descriptor;
			}
		}

		// Token: 0x06005E06 RID: 24070 RVA: 0x000E3DD1 File Offset: 0x000E1FD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteStoryCharacterRequest()
		{
		}

		// Token: 0x06005E07 RID: 24071 RVA: 0x000E3DD9 File Offset: 0x000E1FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteStoryCharacterRequest(DeleteStoryCharacterRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E08 RID: 24072 RVA: 0x000E3DF2 File Offset: 0x000E1FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteStoryCharacterRequest Clone()
		{
			return new DeleteStoryCharacterRequest(this);
		}

		// Token: 0x06005E09 RID: 24073 RVA: 0x000E3DFA File Offset: 0x000E1FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeleteStoryCharacterRequest);
		}

		// Token: 0x06005E0A RID: 24074 RVA: 0x000E3E08 File Offset: 0x000E2008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeleteStoryCharacterRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005E0B RID: 24075 RVA: 0x000E3E28 File Offset: 0x000E2028
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

		// Token: 0x06005E0C RID: 24076 RVA: 0x000E3E4E File Offset: 0x000E204E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005E0D RID: 24077 RVA: 0x000E3E5B File Offset: 0x000E205B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E0E RID: 24078 RVA: 0x000E3E64 File Offset: 0x000E2064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005E0F RID: 24079 RVA: 0x000E3E7C File Offset: 0x000E207C
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

		// Token: 0x06005E10 RID: 24080 RVA: 0x000E3EA2 File Offset: 0x000E20A2
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

		// Token: 0x06005E11 RID: 24081 RVA: 0x000E3EBF File Offset: 0x000E20BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E12 RID: 24082 RVA: 0x000E3EC8 File Offset: 0x000E20C8
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

		// Token: 0x040036B1 RID: 14001
		private UnknownFieldSet _unknownFields;
	}
}
