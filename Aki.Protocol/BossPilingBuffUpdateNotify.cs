using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001C6 RID: 454
	[NetMessage(EMessageId.BossPilingBuffUpdateNotify)]
	public sealed class BossPilingBuffUpdateNotify : IMessage<BossPilingBuffUpdateNotify>, IMessage, IEquatable<BossPilingBuffUpdateNotify>, IDeepCloneable<BossPilingBuffUpdateNotify>, IBufferMessage
	{
		// Token: 0x06003450 RID: 13392 RVA: 0x00084512 File Offset: 0x00082712
		[NullableContext(1)]
		public static BossPilingBuffUpdateNotify Create()
		{
			return new BossPilingBuffUpdateNotify();
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06003451 RID: 13393 RVA: 0x00084519 File Offset: 0x00082719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06003452 RID: 13394 RVA: 0x0008451C File Offset: 0x0008271C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossPilingBuffUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06003453 RID: 13395 RVA: 0x00084523 File Offset: 0x00082723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingBuffUpdateNotify()
		{
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x00084536 File Offset: 0x00082736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingBuffUpdateNotify(BossPilingBuffUpdateNotify other) : this()
		{
			this.bossPilingBuffs_ = other.bossPilingBuffs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003455 RID: 13397 RVA: 0x00084560 File Offset: 0x00082760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingBuffUpdateNotify Clone()
		{
			return new BossPilingBuffUpdateNotify(this);
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06003456 RID: 13398 RVA: 0x00084568 File Offset: 0x00082768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> BossPilingBuffs
		{
			get
			{
				return this.bossPilingBuffs_;
			}
		}

		// Token: 0x06003457 RID: 13399 RVA: 0x00084570 File Offset: 0x00082770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossPilingBuffUpdateNotify);
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x0008457E File Offset: 0x0008277E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossPilingBuffUpdateNotify other)
		{
			return other != null && (other == this || (this.BossPilingBuffs.Equals(other.BossPilingBuffs) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003459 RID: 13401 RVA: 0x000845B4 File Offset: 0x000827B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.BossPilingBuffs.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600345A RID: 13402 RVA: 0x000845E8 File Offset: 0x000827E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600345B RID: 13403 RVA: 0x000845F5 File Offset: 0x000827F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600345C RID: 13404 RVA: 0x000845FE File Offset: 0x000827FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.bossPilingBuffs_.WriteTo(ref output, BossPilingBuffUpdateNotify._map_bossPilingBuffs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600345D RID: 13405 RVA: 0x00084628 File Offset: 0x00082828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.bossPilingBuffs_.CalculateSize(BossPilingBuffUpdateNotify._map_bossPilingBuffs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x00084661 File Offset: 0x00082861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossPilingBuffUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.bossPilingBuffs_.MergeFrom(other.bossPilingBuffs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x0008468F File Offset: 0x0008288F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x00084698 File Offset: 0x00082898
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.bossPilingBuffs_.AddEntriesFrom(ref input, BossPilingBuffUpdateNotify._map_bossPilingBuffs_codec);
				}
			}
		}

		// Token: 0x04002A4E RID: 10830
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A4F RID: 10831
		public const int BossPilingBuffsFieldNumber = 13;

		// Token: 0x04002A50 RID: 10832
		private static readonly MapField<int, int>.Codec _map_bossPilingBuffs_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 106U);

		// Token: 0x04002A51 RID: 10833
		private readonly MapField<int, int> bossPilingBuffs_ = new MapField<int, int>();
	}
}
