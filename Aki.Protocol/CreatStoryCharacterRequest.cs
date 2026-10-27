using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000316 RID: 790
	[NetMessage(EMessageId.CreatStoryCharacterRequest)]
	public sealed class CreatStoryCharacterRequest : IMessage<CreatStoryCharacterRequest>, IMessage, IEquatable<CreatStoryCharacterRequest>, IDeepCloneable<CreatStoryCharacterRequest>, IBufferMessage
	{
		// Token: 0x06004FB5 RID: 20405 RVA: 0x000C2880 File Offset: 0x000C0A80
		[NullableContext(1)]
		public static CreatStoryCharacterRequest Create()
		{
			return new CreatStoryCharacterRequest();
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06004FB6 RID: 20406 RVA: 0x000C2887 File Offset: 0x000C0A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06004FB7 RID: 20407 RVA: 0x000C288A File Offset: 0x000C0A8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreatStoryCharacterRequest.Descriptor;
			}
		}

		// Token: 0x06004FB8 RID: 20408 RVA: 0x000C2891 File Offset: 0x000C0A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreatStoryCharacterRequest()
		{
		}

		// Token: 0x06004FB9 RID: 20409 RVA: 0x000C2899 File Offset: 0x000C0A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreatStoryCharacterRequest(CreatStoryCharacterRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004FBA RID: 20410 RVA: 0x000C28B2 File Offset: 0x000C0AB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreatStoryCharacterRequest Clone()
		{
			return new CreatStoryCharacterRequest(this);
		}

		// Token: 0x06004FBB RID: 20411 RVA: 0x000C28BA File Offset: 0x000C0ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreatStoryCharacterRequest);
		}

		// Token: 0x06004FBC RID: 20412 RVA: 0x000C28C8 File Offset: 0x000C0AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CreatStoryCharacterRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004FBD RID: 20413 RVA: 0x000C28E8 File Offset: 0x000C0AE8
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

		// Token: 0x06004FBE RID: 20414 RVA: 0x000C290E File Offset: 0x000C0B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004FBF RID: 20415 RVA: 0x000C291B File Offset: 0x000C0B1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004FC0 RID: 20416 RVA: 0x000C2924 File Offset: 0x000C0B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004FC1 RID: 20417 RVA: 0x000C293C File Offset: 0x000C0B3C
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

		// Token: 0x06004FC2 RID: 20418 RVA: 0x000C2962 File Offset: 0x000C0B62
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

		// Token: 0x06004FC3 RID: 20419 RVA: 0x000C297F File Offset: 0x000C0B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004FC4 RID: 20420 RVA: 0x000C2988 File Offset: 0x000C0B88
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

		// Token: 0x0400322B RID: 12843
		private UnknownFieldSet _unknownFields;
	}
}
