using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001B7 RID: 439
	[NetMessage(EMessageId.BlockPlayerRequest)]
	public sealed class BlockPlayerRequest : IMessage<BlockPlayerRequest>, IMessage, IEquatable<BlockPlayerRequest>, IDeepCloneable<BlockPlayerRequest>, IBufferMessage
	{
		// Token: 0x06003322 RID: 13090 RVA: 0x00081D40 File Offset: 0x0007FF40
		[NullableContext(1)]
		public static BlockPlayerRequest Create()
		{
			return new BlockPlayerRequest();
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06003323 RID: 13091 RVA: 0x00081D47 File Offset: 0x0007FF47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06003324 RID: 13092 RVA: 0x00081D4A File Offset: 0x0007FF4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlockPlayerRequest.Descriptor;
			}
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x00081D51 File Offset: 0x0007FF51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockPlayerRequest()
		{
		}

		// Token: 0x06003326 RID: 13094 RVA: 0x00081D59 File Offset: 0x0007FF59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockPlayerRequest(BlockPlayerRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x00081D7E File Offset: 0x0007FF7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockPlayerRequest Clone()
		{
			return new BlockPlayerRequest(this);
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06003328 RID: 13096 RVA: 0x00081D86 File Offset: 0x0007FF86
		// (set) Token: 0x06003329 RID: 13097 RVA: 0x00081D8E File Offset: 0x0007FF8E
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

		// Token: 0x0600332A RID: 13098 RVA: 0x00081D97 File Offset: 0x0007FF97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlockPlayerRequest);
		}

		// Token: 0x0600332B RID: 13099 RVA: 0x00081DA5 File Offset: 0x0007FFA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlockPlayerRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600332C RID: 13100 RVA: 0x00081DD4 File Offset: 0x0007FFD4
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

		// Token: 0x0600332D RID: 13101 RVA: 0x00081E13 File Offset: 0x00080013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600332E RID: 13102 RVA: 0x00081E20 File Offset: 0x00080020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600332F RID: 13103 RVA: 0x00081E29 File Offset: 0x00080029
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

		// Token: 0x06003330 RID: 13104 RVA: 0x00081E5C File Offset: 0x0008005C
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

		// Token: 0x06003331 RID: 13105 RVA: 0x00081E9A File Offset: 0x0008009A
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

		// Token: 0x06003332 RID: 13106 RVA: 0x00081ECB File Offset: 0x000800CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x00081ED4 File Offset: 0x000800D4
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

		// Token: 0x040029FC RID: 10748
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029FD RID: 10749
		public const int IdFieldNumber = 11;

		// Token: 0x040029FE RID: 10750
		private int id_;
	}
}
