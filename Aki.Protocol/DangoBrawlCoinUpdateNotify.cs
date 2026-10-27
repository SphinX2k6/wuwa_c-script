using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200033D RID: 829
	[NetMessage(EMessageId.DangoBrawlCoinUpdateNotify)]
	public sealed class DangoBrawlCoinUpdateNotify : IMessage<DangoBrawlCoinUpdateNotify>, IMessage, IEquatable<DangoBrawlCoinUpdateNotify>, IDeepCloneable<DangoBrawlCoinUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600531F RID: 21279 RVA: 0x000CAC3D File Offset: 0x000C8E3D
		[NullableContext(1)]
		public static DangoBrawlCoinUpdateNotify Create()
		{
			return new DangoBrawlCoinUpdateNotify();
		}

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06005320 RID: 21280 RVA: 0x000CAC44 File Offset: 0x000C8E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x06005321 RID: 21281 RVA: 0x000CAC47 File Offset: 0x000C8E47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlCoinUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06005322 RID: 21282 RVA: 0x000CAC4E File Offset: 0x000C8E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlCoinUpdateNotify()
		{
		}

		// Token: 0x06005323 RID: 21283 RVA: 0x000CAC56 File Offset: 0x000C8E56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlCoinUpdateNotify(DangoBrawlCoinUpdateNotify other) : this()
		{
			this.coin_ = other.coin_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005324 RID: 21284 RVA: 0x000CAC7B File Offset: 0x000C8E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlCoinUpdateNotify Clone()
		{
			return new DangoBrawlCoinUpdateNotify(this);
		}

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06005325 RID: 21285 RVA: 0x000CAC83 File Offset: 0x000C8E83
		// (set) Token: 0x06005326 RID: 21286 RVA: 0x000CAC8B File Offset: 0x000C8E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Coin
		{
			get
			{
				return this.coin_;
			}
			set
			{
				this.coin_ = value;
			}
		}

		// Token: 0x06005327 RID: 21287 RVA: 0x000CAC94 File Offset: 0x000C8E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlCoinUpdateNotify);
		}

		// Token: 0x06005328 RID: 21288 RVA: 0x000CACA2 File Offset: 0x000C8EA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlCoinUpdateNotify other)
		{
			return other != null && (other == this || (this.Coin == other.Coin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005329 RID: 21289 RVA: 0x000CACD0 File Offset: 0x000C8ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Coin != 0)
			{
				num ^= this.Coin.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600532A RID: 21290 RVA: 0x000CAD0F File Offset: 0x000C8F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600532B RID: 21291 RVA: 0x000CAD1C File Offset: 0x000C8F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600532C RID: 21292 RVA: 0x000CAD25 File Offset: 0x000C8F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Coin != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Coin);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600532D RID: 21293 RVA: 0x000CAD58 File Offset: 0x000C8F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Coin != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Coin);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600532E RID: 21294 RVA: 0x000CAD96 File Offset: 0x000C8F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlCoinUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Coin != 0)
			{
				this.Coin = other.Coin;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600532F RID: 21295 RVA: 0x000CADC7 File Offset: 0x000C8FC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005330 RID: 21296 RVA: 0x000CADD0 File Offset: 0x000C8FD0
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
					this.Coin = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003363 RID: 13155
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003364 RID: 13156
		public const int CoinFieldNumber = 12;

		// Token: 0x04003365 RID: 13157
		private int coin_;
	}
}
