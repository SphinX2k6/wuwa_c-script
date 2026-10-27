using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001B1 RID: 433
	[NetMessage(EMessageId.BlockListRequest)]
	public sealed class BlockListRequest : IMessage<BlockListRequest>, IMessage, IEquatable<BlockListRequest>, IDeepCloneable<BlockListRequest>, IBufferMessage
	{
		// Token: 0x06003271 RID: 12913 RVA: 0x000801E7 File Offset: 0x0007E3E7
		[NullableContext(1)]
		public static BlockListRequest Create()
		{
			return new BlockListRequest();
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06003272 RID: 12914 RVA: 0x000801EE File Offset: 0x0007E3EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06003273 RID: 12915 RVA: 0x000801F1 File Offset: 0x0007E3F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlockListRequest.Descriptor;
			}
		}

		// Token: 0x06003274 RID: 12916 RVA: 0x000801F8 File Offset: 0x0007E3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockListRequest()
		{
		}

		// Token: 0x06003275 RID: 12917 RVA: 0x00080200 File Offset: 0x0007E400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockListRequest(BlockListRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003276 RID: 12918 RVA: 0x00080219 File Offset: 0x0007E419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockListRequest Clone()
		{
			return new BlockListRequest(this);
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x00080221 File Offset: 0x0007E421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlockListRequest);
		}

		// Token: 0x06003278 RID: 12920 RVA: 0x0008022F File Offset: 0x0007E42F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlockListRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06003279 RID: 12921 RVA: 0x00080250 File Offset: 0x0007E450
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

		// Token: 0x0600327A RID: 12922 RVA: 0x00080276 File Offset: 0x0007E476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600327B RID: 12923 RVA: 0x00080283 File Offset: 0x0007E483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600327C RID: 12924 RVA: 0x0008028C File Offset: 0x0007E48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600327D RID: 12925 RVA: 0x000802A4 File Offset: 0x0007E4A4
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

		// Token: 0x0600327E RID: 12926 RVA: 0x000802CA File Offset: 0x0007E4CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlockListRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600327F RID: 12927 RVA: 0x000802E7 File Offset: 0x0007E4E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003280 RID: 12928 RVA: 0x000802F0 File Offset: 0x0007E4F0
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

		// Token: 0x0400297A RID: 10618
		private UnknownFieldSet _unknownFields;
	}
}
