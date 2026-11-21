using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200053F RID: 1343
	[NetMessage(EMessageId.FishingEntrustRefreshRequest)]
	public sealed class FishingEntrustRefreshRequest : IMessage<FishingEntrustRefreshRequest>, IMessage, IEquatable<FishingEntrustRefreshRequest>, IDeepCloneable<FishingEntrustRefreshRequest>, IBufferMessage
	{
		// Token: 0x06007DFB RID: 32251 RVA: 0x001315CD File Offset: 0x0012F7CD
		[NullableContext(1)]
		public static FishingEntrustRefreshRequest Create()
		{
			return new FishingEntrustRefreshRequest();
		}

		// Token: 0x1700187F RID: 6271
		// (get) Token: 0x06007DFC RID: 32252 RVA: 0x001315D4 File Offset: 0x0012F7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001880 RID: 6272
		// (get) Token: 0x06007DFD RID: 32253 RVA: 0x001315D7 File Offset: 0x0012F7D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingEntrustRefreshRequest.Descriptor;
			}
		}

		// Token: 0x06007DFE RID: 32254 RVA: 0x001315DE File Offset: 0x0012F7DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustRefreshRequest()
		{
		}

		// Token: 0x06007DFF RID: 32255 RVA: 0x001315E6 File Offset: 0x0012F7E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustRefreshRequest(FishingEntrustRefreshRequest other) : this()
		{
			this.entrustId_ = other.entrustId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E00 RID: 32256 RVA: 0x0013160B File Offset: 0x0012F80B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustRefreshRequest Clone()
		{
			return new FishingEntrustRefreshRequest(this);
		}

		// Token: 0x17001881 RID: 6273
		// (get) Token: 0x06007E01 RID: 32257 RVA: 0x00131613 File Offset: 0x0012F813
		// (set) Token: 0x06007E02 RID: 32258 RVA: 0x0013161B File Offset: 0x0012F81B
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

		// Token: 0x06007E03 RID: 32259 RVA: 0x00131624 File Offset: 0x0012F824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingEntrustRefreshRequest);
		}

		// Token: 0x06007E04 RID: 32260 RVA: 0x00131632 File Offset: 0x0012F832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingEntrustRefreshRequest other)
		{
			return other != null && (other == this || (this.EntrustId == other.EntrustId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007E05 RID: 32261 RVA: 0x00131660 File Offset: 0x0012F860
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

		// Token: 0x06007E06 RID: 32262 RVA: 0x0013169F File Offset: 0x0012F89F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007E07 RID: 32263 RVA: 0x001316AC File Offset: 0x0012F8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E08 RID: 32264 RVA: 0x001316B5 File Offset: 0x0012F8B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntrustId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.EntrustId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E09 RID: 32265 RVA: 0x001316E8 File Offset: 0x0012F8E8
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

		// Token: 0x06007E0A RID: 32266 RVA: 0x00131726 File Offset: 0x0012F926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingEntrustRefreshRequest other)
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

		// Token: 0x06007E0B RID: 32267 RVA: 0x00131757 File Offset: 0x0012F957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E0C RID: 32268 RVA: 0x00131760 File Offset: 0x0012F960
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntrustId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004054 RID: 16468
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004055 RID: 16469
		public const int EntrustIdFieldNumber = 7;

		// Token: 0x04004056 RID: 16470
		private int entrustId_;
	}
}
