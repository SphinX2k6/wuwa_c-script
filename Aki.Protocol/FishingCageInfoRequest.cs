using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000537 RID: 1335
	[NetMessage(EMessageId.FishingCageInfoRequest)]
	public sealed class FishingCageInfoRequest : IMessage<FishingCageInfoRequest>, IMessage, IEquatable<FishingCageInfoRequest>, IDeepCloneable<FishingCageInfoRequest>, IBufferMessage
	{
		// Token: 0x06007D5F RID: 32095 RVA: 0x00130161 File Offset: 0x0012E361
		[NullableContext(1)]
		public static FishingCageInfoRequest Create()
		{
			return new FishingCageInfoRequest();
		}

		// Token: 0x17001860 RID: 6240
		// (get) Token: 0x06007D60 RID: 32096 RVA: 0x00130168 File Offset: 0x0012E368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001861 RID: 6241
		// (get) Token: 0x06007D61 RID: 32097 RVA: 0x0013016B File Offset: 0x0012E36B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingCageInfoRequest.Descriptor;
			}
		}

		// Token: 0x06007D62 RID: 32098 RVA: 0x00130172 File Offset: 0x0012E372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCageInfoRequest()
		{
		}

		// Token: 0x06007D63 RID: 32099 RVA: 0x0013017A File Offset: 0x0012E37A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCageInfoRequest(FishingCageInfoRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007D64 RID: 32100 RVA: 0x0013019F File Offset: 0x0012E39F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCageInfoRequest Clone()
		{
			return new FishingCageInfoRequest(this);
		}

		// Token: 0x17001862 RID: 6242
		// (get) Token: 0x06007D65 RID: 32101 RVA: 0x001301A7 File Offset: 0x0012E3A7
		// (set) Token: 0x06007D66 RID: 32102 RVA: 0x001301AF File Offset: 0x0012E3AF
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

		// Token: 0x06007D67 RID: 32103 RVA: 0x001301B8 File Offset: 0x0012E3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingCageInfoRequest);
		}

		// Token: 0x06007D68 RID: 32104 RVA: 0x001301C6 File Offset: 0x0012E3C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingCageInfoRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007D69 RID: 32105 RVA: 0x001301F4 File Offset: 0x0012E3F4
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

		// Token: 0x06007D6A RID: 32106 RVA: 0x00130233 File Offset: 0x0012E433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007D6B RID: 32107 RVA: 0x00130240 File Offset: 0x0012E440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D6C RID: 32108 RVA: 0x00130249 File Offset: 0x0012E449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007D6D RID: 32109 RVA: 0x0013027C File Offset: 0x0012E47C
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

		// Token: 0x06007D6E RID: 32110 RVA: 0x001302BA File Offset: 0x0012E4BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingCageInfoRequest other)
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

		// Token: 0x06007D6F RID: 32111 RVA: 0x001302EB File Offset: 0x0012E4EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D70 RID: 32112 RVA: 0x001302F4 File Offset: 0x0012E4F4
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400402A RID: 16426
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400402B RID: 16427
		public const int IdFieldNumber = 8;

		// Token: 0x0400402C RID: 16428
		private int id_;
	}
}
