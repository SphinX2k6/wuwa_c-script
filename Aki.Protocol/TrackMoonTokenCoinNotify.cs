using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001463 RID: 5219
	[NetMessage(EMessageId.TrackMoonTokenCoinNotify)]
	public sealed class TrackMoonTokenCoinNotify : IMessage<TrackMoonTokenCoinNotify>, IMessage, IEquatable<TrackMoonTokenCoinNotify>, IDeepCloneable<TrackMoonTokenCoinNotify>, IBufferMessage
	{
		// Token: 0x0601BB4E RID: 113486 RVA: 0x00405D49 File Offset: 0x00403F49
		[NullableContext(1)]
		public static TrackMoonTokenCoinNotify Create()
		{
			return new TrackMoonTokenCoinNotify();
		}

		// Token: 0x17005DBB RID: 23995
		// (get) Token: 0x0601BB4F RID: 113487 RVA: 0x00405D50 File Offset: 0x00403F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DBC RID: 23996
		// (get) Token: 0x0601BB50 RID: 113488 RVA: 0x00405D53 File Offset: 0x00403F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonTokenCoinNotify.Descriptor;
			}
		}

		// Token: 0x0601BB51 RID: 113489 RVA: 0x00405D5A File Offset: 0x00403F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTokenCoinNotify()
		{
		}

		// Token: 0x0601BB52 RID: 113490 RVA: 0x00405D62 File Offset: 0x00403F62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTokenCoinNotify(TrackMoonTokenCoinNotify other) : this()
		{
			this.tokenCoin_ = other.tokenCoin_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BB53 RID: 113491 RVA: 0x00405D87 File Offset: 0x00403F87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTokenCoinNotify Clone()
		{
			return new TrackMoonTokenCoinNotify(this);
		}

		// Token: 0x17005DBD RID: 23997
		// (get) Token: 0x0601BB54 RID: 113492 RVA: 0x00405D8F File Offset: 0x00403F8F
		// (set) Token: 0x0601BB55 RID: 113493 RVA: 0x00405D97 File Offset: 0x00403F97
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

		// Token: 0x0601BB56 RID: 113494 RVA: 0x00405DA0 File Offset: 0x00403FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonTokenCoinNotify);
		}

		// Token: 0x0601BB57 RID: 113495 RVA: 0x00405DAE File Offset: 0x00403FAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonTokenCoinNotify other)
		{
			return other != null && (other == this || (this.TokenCoin == other.TokenCoin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BB58 RID: 113496 RVA: 0x00405DDC File Offset: 0x00403FDC
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

		// Token: 0x0601BB59 RID: 113497 RVA: 0x00405E1B File Offset: 0x0040401B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BB5A RID: 113498 RVA: 0x00405E28 File Offset: 0x00404028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BB5B RID: 113499 RVA: 0x00405E31 File Offset: 0x00404031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TokenCoin != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TokenCoin);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BB5C RID: 113500 RVA: 0x00405E64 File Offset: 0x00404064
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

		// Token: 0x0601BB5D RID: 113501 RVA: 0x00405EA2 File Offset: 0x004040A2
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

		// Token: 0x0601BB5E RID: 113502 RVA: 0x00405ED3 File Offset: 0x004040D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BB5F RID: 113503 RVA: 0x00405EDC File Offset: 0x004040DC
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TokenCoin = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A0CF RID: 41167
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0D0 RID: 41168
		public const int TokenCoinFieldNumber = 5;

		// Token: 0x0400A0D1 RID: 41169
		private int tokenCoin_;
	}
}
