using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000C3 RID: 195
	public sealed class AdventureSilentCtx : IMessage<AdventureSilentCtx>, IMessage, IEquatable<AdventureSilentCtx>, IDeepCloneable<AdventureSilentCtx>, IBufferMessage
	{
		// Token: 0x06001F3A RID: 7994 RVA: 0x00055431 File Offset: 0x00053631
		[NullableContext(1)]
		public static AdventureSilentCtx Create()
		{
			return new AdventureSilentCtx();
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001F3B RID: 7995 RVA: 0x00055438 File Offset: 0x00053638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001F3C RID: 7996 RVA: 0x0005543B File Offset: 0x0005363B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventureSilentCtx.Descriptor;
			}
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x00055442 File Offset: 0x00053642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureSilentCtx()
		{
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x0005544A File Offset: 0x0005364A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureSilentCtx(AdventureSilentCtx other) : this()
		{
			this.adventureSilentId_ = other.adventureSilentId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x0005546F File Offset: 0x0005366F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureSilentCtx Clone()
		{
			return new AdventureSilentCtx(this);
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001F40 RID: 8000 RVA: 0x00055477 File Offset: 0x00053677
		// (set) Token: 0x06001F41 RID: 8001 RVA: 0x0005547F File Offset: 0x0005367F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AdventureSilentId
		{
			get
			{
				return this.adventureSilentId_;
			}
			set
			{
				this.adventureSilentId_ = value;
			}
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x00055488 File Offset: 0x00053688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventureSilentCtx);
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x00055496 File Offset: 0x00053696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventureSilentCtx other)
		{
			return other != null && (other == this || (this.AdventureSilentId == other.AdventureSilentId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x000554C4 File Offset: 0x000536C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AdventureSilentId != 0)
			{
				num ^= this.AdventureSilentId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x00055503 File Offset: 0x00053703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x00055510 File Offset: 0x00053710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x00055519 File Offset: 0x00053719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AdventureSilentId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AdventureSilentId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x0005554C File Offset: 0x0005374C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AdventureSilentId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AdventureSilentId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x0005558A File Offset: 0x0005378A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdventureSilentCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AdventureSilentId != 0)
			{
				this.AdventureSilentId = other.AdventureSilentId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x000555BB File Offset: 0x000537BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x000555C4 File Offset: 0x000537C4
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AdventureSilentId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040023FD RID: 9213
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023FE RID: 9214
		public const int AdventureSilentIdFieldNumber = 1;

		// Token: 0x040023FF RID: 9215
		private int adventureSilentId_;
	}
}
