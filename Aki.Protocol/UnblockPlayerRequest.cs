using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014F4 RID: 5364
	[NetMessage(EMessageId.UnblockPlayerRequest)]
	public sealed class UnblockPlayerRequest : IMessage<UnblockPlayerRequest>, IMessage, IEquatable<UnblockPlayerRequest>, IDeepCloneable<UnblockPlayerRequest>, IBufferMessage
	{
		// Token: 0x0601C702 RID: 116482 RVA: 0x0041FF4F File Offset: 0x0041E14F
		[NullableContext(1)]
		public static UnblockPlayerRequest Create()
		{
			return new UnblockPlayerRequest();
		}

		// Token: 0x1700603D RID: 24637
		// (get) Token: 0x0601C703 RID: 116483 RVA: 0x0041FF56 File Offset: 0x0041E156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700603E RID: 24638
		// (get) Token: 0x0601C704 RID: 116484 RVA: 0x0041FF59 File Offset: 0x0041E159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnblockPlayerRequest.Descriptor;
			}
		}

		// Token: 0x0601C705 RID: 116485 RVA: 0x0041FF60 File Offset: 0x0041E160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnblockPlayerRequest()
		{
		}

		// Token: 0x0601C706 RID: 116486 RVA: 0x0041FF68 File Offset: 0x0041E168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnblockPlayerRequest(UnblockPlayerRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C707 RID: 116487 RVA: 0x0041FF8D File Offset: 0x0041E18D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnblockPlayerRequest Clone()
		{
			return new UnblockPlayerRequest(this);
		}

		// Token: 0x1700603F RID: 24639
		// (get) Token: 0x0601C708 RID: 116488 RVA: 0x0041FF95 File Offset: 0x0041E195
		// (set) Token: 0x0601C709 RID: 116489 RVA: 0x0041FF9D File Offset: 0x0041E19D
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

		// Token: 0x0601C70A RID: 116490 RVA: 0x0041FFA6 File Offset: 0x0041E1A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnblockPlayerRequest);
		}

		// Token: 0x0601C70B RID: 116491 RVA: 0x0041FFB4 File Offset: 0x0041E1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnblockPlayerRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C70C RID: 116492 RVA: 0x0041FFE4 File Offset: 0x0041E1E4
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

		// Token: 0x0601C70D RID: 116493 RVA: 0x00420023 File Offset: 0x0041E223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C70E RID: 116494 RVA: 0x00420030 File Offset: 0x0041E230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C70F RID: 116495 RVA: 0x00420039 File Offset: 0x0041E239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C710 RID: 116496 RVA: 0x0042006C File Offset: 0x0041E26C
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

		// Token: 0x0601C711 RID: 116497 RVA: 0x004200AA File Offset: 0x0041E2AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnblockPlayerRequest other)
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

		// Token: 0x0601C712 RID: 116498 RVA: 0x004200DB File Offset: 0x0041E2DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C713 RID: 116499 RVA: 0x004200E4 File Offset: 0x0041E2E4
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A42B RID: 42027
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A42C RID: 42028
		public const int IdFieldNumber = 6;

		// Token: 0x0400A42D RID: 42029
		private int id_;
	}
}
