using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000039 RID: 57
	[NetMessage(EMessageId.AbyssRankListRequest)]
	public sealed class AbyssRankListRequest : IMessage<AbyssRankListRequest>, IMessage, IEquatable<AbyssRankListRequest>, IDeepCloneable<AbyssRankListRequest>, IBufferMessage
	{
		// Token: 0x06001330 RID: 4912 RVA: 0x000343F0 File Offset: 0x000325F0
		[NullableContext(1)]
		public static AbyssRankListRequest Create()
		{
			return new AbyssRankListRequest();
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x000343F7 File Offset: 0x000325F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x000343FA File Offset: 0x000325FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssRankListRequest.Descriptor;
			}
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x00034401 File Offset: 0x00032601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRankListRequest()
		{
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x00034409 File Offset: 0x00032609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRankListRequest(AbyssRankListRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x0003442E File Offset: 0x0003262E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRankListRequest Clone()
		{
			return new AbyssRankListRequest(this);
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x00034436 File Offset: 0x00032636
		// (set) Token: 0x06001337 RID: 4919 RVA: 0x0003443E File Offset: 0x0003263E
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

		// Token: 0x06001338 RID: 4920 RVA: 0x00034447 File Offset: 0x00032647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssRankListRequest);
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00034455 File Offset: 0x00032655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssRankListRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x00034484 File Offset: 0x00032684
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

		// Token: 0x0600133B RID: 4923 RVA: 0x000344C3 File Offset: 0x000326C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x000344D0 File Offset: 0x000326D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x000344D9 File Offset: 0x000326D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x0003450C File Offset: 0x0003270C
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

		// Token: 0x0600133F RID: 4927 RVA: 0x0003454A File Offset: 0x0003274A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssRankListRequest other)
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

		// Token: 0x06001340 RID: 4928 RVA: 0x0003457B File Offset: 0x0003277B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x00034584 File Offset: 0x00032784
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002049 RID: 8265
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400204A RID: 8266
		public const int IdFieldNumber = 12;

		// Token: 0x0400204B RID: 8267
		private int id_;
	}
}
