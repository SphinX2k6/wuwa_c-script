using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001B5 RID: 437
	[NetMessage(EMessageId.BlockListRequest)]
	public sealed class BlockListRequest : IMessage<BlockListRequest>, IMessage, IEquatable<BlockListRequest>, IDeepCloneable<BlockListRequest>, IBufferMessage
	{
		// Token: 0x060032FE RID: 13054 RVA: 0x00081953 File Offset: 0x0007FB53
		[NullableContext(1)]
		public static BlockListRequest Create()
		{
			return new BlockListRequest();
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x060032FF RID: 13055 RVA: 0x0008195A File Offset: 0x0007FB5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06003300 RID: 13056 RVA: 0x0008195D File Offset: 0x0007FB5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlockListRequest.Descriptor;
			}
		}

		// Token: 0x06003301 RID: 13057 RVA: 0x00081964 File Offset: 0x0007FB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockListRequest()
		{
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x0008196C File Offset: 0x0007FB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockListRequest(BlockListRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x00081985 File Offset: 0x0007FB85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockListRequest Clone()
		{
			return new BlockListRequest(this);
		}

		// Token: 0x06003304 RID: 13060 RVA: 0x0008198D File Offset: 0x0007FB8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlockListRequest);
		}

		// Token: 0x06003305 RID: 13061 RVA: 0x0008199B File Offset: 0x0007FB9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlockListRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06003306 RID: 13062 RVA: 0x000819BC File Offset: 0x0007FBBC
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

		// Token: 0x06003307 RID: 13063 RVA: 0x000819E2 File Offset: 0x0007FBE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x000819EF File Offset: 0x0007FBEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x000819F8 File Offset: 0x0007FBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x00081A10 File Offset: 0x0007FC10
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

		// Token: 0x0600330B RID: 13067 RVA: 0x00081A36 File Offset: 0x0007FC36
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

		// Token: 0x0600330C RID: 13068 RVA: 0x00081A53 File Offset: 0x0007FC53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x00081A5C File Offset: 0x0007FC5C
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

		// Token: 0x040029F5 RID: 10741
		private UnknownFieldSet _unknownFields;
	}
}
