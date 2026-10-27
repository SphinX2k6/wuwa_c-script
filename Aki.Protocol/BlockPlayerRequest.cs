using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001B3 RID: 435
	[NetMessage(EMessageId.BlockPlayerRequest)]
	public sealed class BlockPlayerRequest : IMessage<BlockPlayerRequest>, IMessage, IEquatable<BlockPlayerRequest>, IDeepCloneable<BlockPlayerRequest>, IBufferMessage
	{
		// Token: 0x06003295 RID: 12949 RVA: 0x000805D4 File Offset: 0x0007E7D4
		[NullableContext(1)]
		public static BlockPlayerRequest Create()
		{
			return new BlockPlayerRequest();
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06003296 RID: 12950 RVA: 0x000805DB File Offset: 0x0007E7DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06003297 RID: 12951 RVA: 0x000805DE File Offset: 0x0007E7DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlockPlayerRequest.Descriptor;
			}
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x000805E5 File Offset: 0x0007E7E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockPlayerRequest()
		{
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x000805ED File Offset: 0x0007E7ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockPlayerRequest(BlockPlayerRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x00080612 File Offset: 0x0007E812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockPlayerRequest Clone()
		{
			return new BlockPlayerRequest(this);
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x0600329B RID: 12955 RVA: 0x0008061A File Offset: 0x0007E81A
		// (set) Token: 0x0600329C RID: 12956 RVA: 0x00080622 File Offset: 0x0007E822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600329D RID: 12957 RVA: 0x0008062B File Offset: 0x0007E82B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlockPlayerRequest);
		}

		// Token: 0x0600329E RID: 12958 RVA: 0x00080639 File Offset: 0x0007E839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlockPlayerRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600329F RID: 12959 RVA: 0x00080668 File Offset: 0x0007E868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x000806A7 File Offset: 0x0007E8A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x000806B4 File Offset: 0x0007E8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x000806BD File Offset: 0x0007E8BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x000806F0 File Offset: 0x0007E8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x0008072E File Offset: 0x0007E92E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlockPlayerRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x0008075F File Offset: 0x0007E95F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x00080768 File Offset: 0x0007E968
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002981 RID: 10625
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002982 RID: 10626
		public const int IdFieldNumber = 11;

		// Token: 0x04002983 RID: 10627
		private int id_;
	}
}
