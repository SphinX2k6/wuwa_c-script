using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200039C RID: 924
	[NetMessage(EMessageId.DarkTideBagUpdateNotify)]
	public sealed class DarkTideBagUpdateNotify : IMessage<DarkTideBagUpdateNotify>, IMessage, IEquatable<DarkTideBagUpdateNotify>, IDeepCloneable<DarkTideBagUpdateNotify>, IBufferMessage
	{
		// Token: 0x06005B17 RID: 23319 RVA: 0x000DD9A1 File Offset: 0x000DBBA1
		[NullableContext(1)]
		public static DarkTideBagUpdateNotify Create()
		{
			return new DarkTideBagUpdateNotify();
		}

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x06005B18 RID: 23320 RVA: 0x000DD9A8 File Offset: 0x000DBBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x06005B19 RID: 23321 RVA: 0x000DD9AB File Offset: 0x000DBBAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideBagUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06005B1A RID: 23322 RVA: 0x000DD9B2 File Offset: 0x000DBBB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideBagUpdateNotify()
		{
		}

		// Token: 0x06005B1B RID: 23323 RVA: 0x000DD9C5 File Offset: 0x000DBBC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideBagUpdateNotify(DarkTideBagUpdateNotify other) : this()
		{
			this.bag_ = other.bag_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B1C RID: 23324 RVA: 0x000DD9EF File Offset: 0x000DBBEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideBagUpdateNotify Clone()
		{
			return new DarkTideBagUpdateNotify(this);
		}

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x06005B1D RID: 23325 RVA: 0x000DD9F7 File Offset: 0x000DBBF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DarkTideBagInfo> Bag
		{
			get
			{
				return this.bag_;
			}
		}

		// Token: 0x06005B1E RID: 23326 RVA: 0x000DD9FF File Offset: 0x000DBBFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideBagUpdateNotify);
		}

		// Token: 0x06005B1F RID: 23327 RVA: 0x000DDA0D File Offset: 0x000DBC0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideBagUpdateNotify other)
		{
			return other != null && (other == this || (this.bag_.Equals(other.bag_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005B20 RID: 23328 RVA: 0x000DDA40 File Offset: 0x000DBC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.bag_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005B21 RID: 23329 RVA: 0x000DDA74 File Offset: 0x000DBC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005B22 RID: 23330 RVA: 0x000DDA81 File Offset: 0x000DBC81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B23 RID: 23331 RVA: 0x000DDA8A File Offset: 0x000DBC8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.bag_.WriteTo(ref output, DarkTideBagUpdateNotify._repeated_bag_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B24 RID: 23332 RVA: 0x000DDAB4 File Offset: 0x000DBCB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.bag_.CalculateSize(DarkTideBagUpdateNotify._repeated_bag_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005B25 RID: 23333 RVA: 0x000DDAED File Offset: 0x000DBCED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideBagUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.bag_.Add(other.bag_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005B26 RID: 23334 RVA: 0x000DDB1B File Offset: 0x000DBD1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B27 RID: 23335 RVA: 0x000DDB24 File Offset: 0x000DBD24
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.bag_.AddEntriesFrom(ref input, DarkTideBagUpdateNotify._repeated_bag_codec);
				}
			}
		}

		// Token: 0x040035E9 RID: 13801
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035EA RID: 13802
		public const int BagFieldNumber = 12;

		// Token: 0x040035EB RID: 13803
		private static readonly FieldCodec<DarkTideBagInfo> _repeated_bag_codec = FieldCodec.ForMessage<DarkTideBagInfo>(98U, DarkTideBagInfo.Parser);

		// Token: 0x040035EC RID: 13804
		private readonly RepeatedField<DarkTideBagInfo> bag_ = new RepeatedField<DarkTideBagInfo>();
	}
}
