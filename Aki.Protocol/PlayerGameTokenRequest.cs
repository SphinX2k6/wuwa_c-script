using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D8F RID: 3471
	[NetMessage(EMessageId.PlayerGameTokenRequest)]
	public sealed class PlayerGameTokenRequest : IMessage<PlayerGameTokenRequest>, IMessage, IEquatable<PlayerGameTokenRequest>, IDeepCloneable<PlayerGameTokenRequest>, IBufferMessage
	{
		// Token: 0x06012B82 RID: 76674 RVA: 0x002BB92E File Offset: 0x002B9B2E
		[NullableContext(1)]
		public static PlayerGameTokenRequest Create()
		{
			return new PlayerGameTokenRequest();
		}

		// Token: 0x17003E24 RID: 15908
		// (get) Token: 0x06012B83 RID: 76675 RVA: 0x002BB935 File Offset: 0x002B9B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E25 RID: 15909
		// (get) Token: 0x06012B84 RID: 76676 RVA: 0x002BB938 File Offset: 0x002B9B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerGameTokenRequest.Descriptor;
			}
		}

		// Token: 0x06012B85 RID: 76677 RVA: 0x002BB93F File Offset: 0x002B9B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerGameTokenRequest()
		{
		}

		// Token: 0x06012B86 RID: 76678 RVA: 0x002BB947 File Offset: 0x002B9B47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerGameTokenRequest(PlayerGameTokenRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012B87 RID: 76679 RVA: 0x002BB960 File Offset: 0x002B9B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerGameTokenRequest Clone()
		{
			return new PlayerGameTokenRequest(this);
		}

		// Token: 0x06012B88 RID: 76680 RVA: 0x002BB968 File Offset: 0x002B9B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerGameTokenRequest);
		}

		// Token: 0x06012B89 RID: 76681 RVA: 0x002BB976 File Offset: 0x002B9B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerGameTokenRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012B8A RID: 76682 RVA: 0x002BB994 File Offset: 0x002B9B94
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

		// Token: 0x06012B8B RID: 76683 RVA: 0x002BB9BA File Offset: 0x002B9BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012B8C RID: 76684 RVA: 0x002BB9C7 File Offset: 0x002B9BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012B8D RID: 76685 RVA: 0x002BB9D0 File Offset: 0x002B9BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012B8E RID: 76686 RVA: 0x002BB9E8 File Offset: 0x002B9BE8
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

		// Token: 0x06012B8F RID: 76687 RVA: 0x002BBA0E File Offset: 0x002B9C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerGameTokenRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012B90 RID: 76688 RVA: 0x002BBA2B File Offset: 0x002B9C2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012B91 RID: 76689 RVA: 0x002BBA34 File Offset: 0x002B9C34
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

		// Token: 0x04007428 RID: 29736
		private UnknownFieldSet _unknownFields;
	}
}
