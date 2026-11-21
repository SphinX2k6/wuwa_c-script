using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004CD RID: 1229
	[NetMessage(EMessageId.ExchangeSharedInfoNotify)]
	public sealed class ExchangeSharedInfoNotify : IMessage<ExchangeSharedInfoNotify>, IMessage, IEquatable<ExchangeSharedInfoNotify>, IDeepCloneable<ExchangeSharedInfoNotify>, IBufferMessage
	{
		// Token: 0x0600750D RID: 29965 RVA: 0x0011EDA2 File Offset: 0x0011CFA2
		[NullableContext(1)]
		public static ExchangeSharedInfoNotify Create()
		{
			return new ExchangeSharedInfoNotify();
		}

		// Token: 0x170016AD RID: 5805
		// (get) Token: 0x0600750E RID: 29966 RVA: 0x0011EDA9 File Offset: 0x0011CFA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016AE RID: 5806
		// (get) Token: 0x0600750F RID: 29967 RVA: 0x0011EDAC File Offset: 0x0011CFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExchangeSharedInfoNotify.Descriptor;
			}
		}

		// Token: 0x06007510 RID: 29968 RVA: 0x0011EDB3 File Offset: 0x0011CFB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeSharedInfoNotify()
		{
		}

		// Token: 0x06007511 RID: 29969 RVA: 0x0011EDC6 File Offset: 0x0011CFC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeSharedInfoNotify(ExchangeSharedInfoNotify other) : this()
		{
			this.sharedUpdateDict_ = other.sharedUpdateDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007512 RID: 29970 RVA: 0x0011EDF0 File Offset: 0x0011CFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeSharedInfoNotify Clone()
		{
			return new ExchangeSharedInfoNotify(this);
		}

		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x06007513 RID: 29971 RVA: 0x0011EDF8 File Offset: 0x0011CFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> SharedUpdateDict
		{
			get
			{
				return this.sharedUpdateDict_;
			}
		}

		// Token: 0x06007514 RID: 29972 RVA: 0x0011EE00 File Offset: 0x0011D000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExchangeSharedInfoNotify);
		}

		// Token: 0x06007515 RID: 29973 RVA: 0x0011EE0E File Offset: 0x0011D00E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExchangeSharedInfoNotify other)
		{
			return other != null && (other == this || (this.SharedUpdateDict.Equals(other.SharedUpdateDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007516 RID: 29974 RVA: 0x0011EE44 File Offset: 0x0011D044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.SharedUpdateDict.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007517 RID: 29975 RVA: 0x0011EE78 File Offset: 0x0011D078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007518 RID: 29976 RVA: 0x0011EE85 File Offset: 0x0011D085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007519 RID: 29977 RVA: 0x0011EE8E File Offset: 0x0011D08E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.sharedUpdateDict_.WriteTo(ref output, ExchangeSharedInfoNotify._map_sharedUpdateDict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600751A RID: 29978 RVA: 0x0011EEB8 File Offset: 0x0011D0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.sharedUpdateDict_.CalculateSize(ExchangeSharedInfoNotify._map_sharedUpdateDict_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600751B RID: 29979 RVA: 0x0011EEF1 File Offset: 0x0011D0F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExchangeSharedInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.sharedUpdateDict_.MergeFrom(other.sharedUpdateDict_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600751C RID: 29980 RVA: 0x0011EF1F File Offset: 0x0011D11F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600751D RID: 29981 RVA: 0x0011EF28 File Offset: 0x0011D128
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.sharedUpdateDict_.AddEntriesFrom(ref input, ExchangeSharedInfoNotify._map_sharedUpdateDict_codec);
				}
			}
		}

		// Token: 0x04003DED RID: 15853
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DEE RID: 15854
		public const int SharedUpdateDictFieldNumber = 9;

		// Token: 0x04003DEF RID: 15855
		private static readonly MapField<int, int>.Codec _map_sharedUpdateDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 74U);

		// Token: 0x04003DF0 RID: 15856
		private readonly MapField<int, int> sharedUpdateDict_ = new MapField<int, int>();
	}
}
