using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013F0 RID: 5104
	[NetMessage(EMessageId.TrackMoonTokenCoinNotify)]
	public sealed class TrackMoonTokenCoinNotify : IMessage<TrackMoonTokenCoinNotify>, IMessage, IEquatable<TrackMoonTokenCoinNotify>, IDeepCloneable<TrackMoonTokenCoinNotify>, IBufferMessage
	{
		// Token: 0x0601B0C3 RID: 110787 RVA: 0x003EAA75 File Offset: 0x003E8C75
		[NullableContext(1)]
		public static TrackMoonTokenCoinNotify Create()
		{
			return new TrackMoonTokenCoinNotify();
		}

		// Token: 0x17005B26 RID: 23334
		// (get) Token: 0x0601B0C4 RID: 110788 RVA: 0x003EAA7C File Offset: 0x003E8C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B27 RID: 23335
		// (get) Token: 0x0601B0C5 RID: 110789 RVA: 0x003EAA7F File Offset: 0x003E8C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonTokenCoinNotify.Descriptor;
			}
		}

		// Token: 0x0601B0C6 RID: 110790 RVA: 0x003EAA86 File Offset: 0x003E8C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTokenCoinNotify()
		{
		}

		// Token: 0x0601B0C7 RID: 110791 RVA: 0x003EAA8E File Offset: 0x003E8C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTokenCoinNotify(TrackMoonTokenCoinNotify other) : this()
		{
			this.tokenCoin_ = other.tokenCoin_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B0C8 RID: 110792 RVA: 0x003EAAB3 File Offset: 0x003E8CB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTokenCoinNotify Clone()
		{
			return new TrackMoonTokenCoinNotify(this);
		}

		// Token: 0x17005B28 RID: 23336
		// (get) Token: 0x0601B0C9 RID: 110793 RVA: 0x003EAABB File Offset: 0x003E8CBB
		// (set) Token: 0x0601B0CA RID: 110794 RVA: 0x003EAAC3 File Offset: 0x003E8CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TokenCoin
		{
			get
			{
				return this.tokenCoin_;
			}
			set
			{
				this.tokenCoin_ = value;
			}
		}

		// Token: 0x0601B0CB RID: 110795 RVA: 0x003EAACC File Offset: 0x003E8CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonTokenCoinNotify);
		}

		// Token: 0x0601B0CC RID: 110796 RVA: 0x003EAADA File Offset: 0x003E8CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonTokenCoinNotify other)
		{
			return other != null && (other == this || (this.TokenCoin == other.TokenCoin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B0CD RID: 110797 RVA: 0x003EAB08 File Offset: 0x003E8D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TokenCoin != 0)
			{
				num ^= this.TokenCoin.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B0CE RID: 110798 RVA: 0x003EAB47 File Offset: 0x003E8D47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B0CF RID: 110799 RVA: 0x003EAB54 File Offset: 0x003E8D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B0D0 RID: 110800 RVA: 0x003EAB5D File Offset: 0x003E8D5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TokenCoin != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TokenCoin);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B0D1 RID: 110801 RVA: 0x003EAB90 File Offset: 0x003E8D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TokenCoin != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TokenCoin);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B0D2 RID: 110802 RVA: 0x003EABCE File Offset: 0x003E8DCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonTokenCoinNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TokenCoin != 0)
			{
				this.TokenCoin = other.TokenCoin;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B0D3 RID: 110803 RVA: 0x003EABFF File Offset: 0x003E8DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B0D4 RID: 110804 RVA: 0x003EAC08 File Offset: 0x003E8E08
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
					this.TokenCoin = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009C88 RID: 40072
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C89 RID: 40073
		public const int TokenCoinFieldNumber = 3;

		// Token: 0x04009C8A RID: 40074
		private int tokenCoin_;
	}
}
