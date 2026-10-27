using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006D6 RID: 1750
	[NetMessage(EMessageId.GiantActivityNodeActiveNotify)]
	public sealed class GiantActivityNodeActiveNotify : IMessage<GiantActivityNodeActiveNotify>, IMessage, IEquatable<GiantActivityNodeActiveNotify>, IDeepCloneable<GiantActivityNodeActiveNotify>, IBufferMessage
	{
		// Token: 0x06009FD1 RID: 40913 RVA: 0x00183253 File Offset: 0x00181453
		[NullableContext(1)]
		public static GiantActivityNodeActiveNotify Create()
		{
			return new GiantActivityNodeActiveNotify();
		}

		// Token: 0x17002018 RID: 8216
		// (get) Token: 0x06009FD2 RID: 40914 RVA: 0x0018325A File Offset: 0x0018145A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002019 RID: 8217
		// (get) Token: 0x06009FD3 RID: 40915 RVA: 0x0018325D File Offset: 0x0018145D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantActivityNodeActiveNotify.Descriptor;
			}
		}

		// Token: 0x06009FD4 RID: 40916 RVA: 0x00183264 File Offset: 0x00181464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantActivityNodeActiveNotify()
		{
		}

		// Token: 0x06009FD5 RID: 40917 RVA: 0x00183277 File Offset: 0x00181477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantActivityNodeActiveNotify(GiantActivityNodeActiveNotify other) : this()
		{
			this.activeIds_ = other.activeIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009FD6 RID: 40918 RVA: 0x001832A1 File Offset: 0x001814A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantActivityNodeActiveNotify Clone()
		{
			return new GiantActivityNodeActiveNotify(this);
		}

		// Token: 0x1700201A RID: 8218
		// (get) Token: 0x06009FD7 RID: 40919 RVA: 0x001832A9 File Offset: 0x001814A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ActiveIds
		{
			get
			{
				return this.activeIds_;
			}
		}

		// Token: 0x06009FD8 RID: 40920 RVA: 0x001832B1 File Offset: 0x001814B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantActivityNodeActiveNotify);
		}

		// Token: 0x06009FD9 RID: 40921 RVA: 0x001832BF File Offset: 0x001814BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantActivityNodeActiveNotify other)
		{
			return other != null && (other == this || (this.activeIds_.Equals(other.activeIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009FDA RID: 40922 RVA: 0x001832F4 File Offset: 0x001814F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.activeIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009FDB RID: 40923 RVA: 0x00183328 File Offset: 0x00181528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009FDC RID: 40924 RVA: 0x00183335 File Offset: 0x00181535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009FDD RID: 40925 RVA: 0x0018333E File Offset: 0x0018153E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activeIds_.WriteTo(ref output, GiantActivityNodeActiveNotify._repeated_activeIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009FDE RID: 40926 RVA: 0x00183368 File Offset: 0x00181568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activeIds_.CalculateSize(GiantActivityNodeActiveNotify._repeated_activeIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009FDF RID: 40927 RVA: 0x001833A1 File Offset: 0x001815A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantActivityNodeActiveNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.activeIds_.Add(other.activeIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009FE0 RID: 40928 RVA: 0x001833CF File Offset: 0x001815CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009FE1 RID: 40929 RVA: 0x001833D8 File Offset: 0x001815D8
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
				if (num != 120U && num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.activeIds_.AddEntriesFrom(ref input, GiantActivityNodeActiveNotify._repeated_activeIds_codec);
				}
			}
		}

		// Token: 0x04004A82 RID: 19074
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A83 RID: 19075
		public const int ActiveIdsFieldNumber = 15;

		// Token: 0x04004A84 RID: 19076
		private static readonly FieldCodec<int> _repeated_activeIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04004A85 RID: 19077
		private readonly RepeatedField<int> activeIds_ = new RepeatedField<int>();
	}
}
