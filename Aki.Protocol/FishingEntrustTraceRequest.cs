using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000556 RID: 1366
	[NetMessage(EMessageId.FishingEntrustTraceRequest)]
	public sealed class FishingEntrustTraceRequest : IMessage<FishingEntrustTraceRequest>, IMessage, IEquatable<FishingEntrustTraceRequest>, IDeepCloneable<FishingEntrustTraceRequest>, IBufferMessage
	{
		// Token: 0x06007F89 RID: 32649 RVA: 0x00134644 File Offset: 0x00132844
		[NullableContext(1)]
		public static FishingEntrustTraceRequest Create()
		{
			return new FishingEntrustTraceRequest();
		}

		// Token: 0x170018D3 RID: 6355
		// (get) Token: 0x06007F8A RID: 32650 RVA: 0x0013464B File Offset: 0x0013284B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018D4 RID: 6356
		// (get) Token: 0x06007F8B RID: 32651 RVA: 0x0013464E File Offset: 0x0013284E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingEntrustTraceRequest.Descriptor;
			}
		}

		// Token: 0x06007F8C RID: 32652 RVA: 0x00134655 File Offset: 0x00132855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustTraceRequest()
		{
		}

		// Token: 0x06007F8D RID: 32653 RVA: 0x0013465D File Offset: 0x0013285D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustTraceRequest(FishingEntrustTraceRequest other) : this()
		{
			this.entrustId_ = other.entrustId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F8E RID: 32654 RVA: 0x00134682 File Offset: 0x00132882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustTraceRequest Clone()
		{
			return new FishingEntrustTraceRequest(this);
		}

		// Token: 0x170018D5 RID: 6357
		// (get) Token: 0x06007F8F RID: 32655 RVA: 0x0013468A File Offset: 0x0013288A
		// (set) Token: 0x06007F90 RID: 32656 RVA: 0x00134692 File Offset: 0x00132892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntrustId
		{
			get
			{
				return this.entrustId_;
			}
			set
			{
				this.entrustId_ = value;
			}
		}

		// Token: 0x06007F91 RID: 32657 RVA: 0x0013469B File Offset: 0x0013289B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingEntrustTraceRequest);
		}

		// Token: 0x06007F92 RID: 32658 RVA: 0x001346A9 File Offset: 0x001328A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingEntrustTraceRequest other)
		{
			return other != null && (other == this || (this.EntrustId == other.EntrustId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007F93 RID: 32659 RVA: 0x001346D8 File Offset: 0x001328D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntrustId != 0)
			{
				num ^= this.EntrustId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007F94 RID: 32660 RVA: 0x00134717 File Offset: 0x00132917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007F95 RID: 32661 RVA: 0x00134724 File Offset: 0x00132924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F96 RID: 32662 RVA: 0x0013472D File Offset: 0x0013292D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntrustId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.EntrustId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F97 RID: 32663 RVA: 0x00134760 File Offset: 0x00132960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntrustId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntrustId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007F98 RID: 32664 RVA: 0x0013479E File Offset: 0x0013299E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingEntrustTraceRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntrustId != 0)
			{
				this.EntrustId = other.EntrustId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007F99 RID: 32665 RVA: 0x001347CF File Offset: 0x001329CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F9A RID: 32666 RVA: 0x001347D8 File Offset: 0x001329D8
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntrustId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004066 RID: 16486
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004067 RID: 16487
		public const int EntrustIdFieldNumber = 3;

		// Token: 0x04004068 RID: 16488
		private int entrustId_;
	}
}
