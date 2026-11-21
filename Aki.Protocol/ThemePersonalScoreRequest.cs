using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013CD RID: 5069
	[NetMessage(EMessageId.ThemePersonalScoreRequest)]
	public sealed class ThemePersonalScoreRequest : IMessage<ThemePersonalScoreRequest>, IMessage, IEquatable<ThemePersonalScoreRequest>, IDeepCloneable<ThemePersonalScoreRequest>, IBufferMessage
	{
		// Token: 0x0601AFA4 RID: 110500 RVA: 0x003EE018 File Offset: 0x003EC218
		[NullableContext(1)]
		public static ThemePersonalScoreRequest Create()
		{
			return new ThemePersonalScoreRequest();
		}

		// Token: 0x17005B63 RID: 23395
		// (get) Token: 0x0601AFA5 RID: 110501 RVA: 0x003EE01F File Offset: 0x003EC21F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B64 RID: 23396
		// (get) Token: 0x0601AFA6 RID: 110502 RVA: 0x003EE022 File Offset: 0x003EC222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThemePersonalScoreRequest.Descriptor;
			}
		}

		// Token: 0x0601AFA7 RID: 110503 RVA: 0x003EE029 File Offset: 0x003EC229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemePersonalScoreRequest()
		{
		}

		// Token: 0x0601AFA8 RID: 110504 RVA: 0x003EE03C File Offset: 0x003EC23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemePersonalScoreRequest(ThemePersonalScoreRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AFA9 RID: 110505 RVA: 0x003EE066 File Offset: 0x003EC266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemePersonalScoreRequest Clone()
		{
			return new ThemePersonalScoreRequest(this);
		}

		// Token: 0x17005B65 RID: 23397
		// (get) Token: 0x0601AFAA RID: 110506 RVA: 0x003EE06E File Offset: 0x003EC26E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601AFAB RID: 110507 RVA: 0x003EE076 File Offset: 0x003EC276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThemePersonalScoreRequest);
		}

		// Token: 0x0601AFAC RID: 110508 RVA: 0x003EE084 File Offset: 0x003EC284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThemePersonalScoreRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AFAD RID: 110509 RVA: 0x003EE0B8 File Offset: 0x003EC2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AFAE RID: 110510 RVA: 0x003EE0EC File Offset: 0x003EC2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AFAF RID: 110511 RVA: 0x003EE0F9 File Offset: 0x003EC2F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AFB0 RID: 110512 RVA: 0x003EE102 File Offset: 0x003EC302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, ThemePersonalScoreRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AFB1 RID: 110513 RVA: 0x003EE12C File Offset: 0x003EC32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(ThemePersonalScoreRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AFB2 RID: 110514 RVA: 0x003EE165 File Offset: 0x003EC365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThemePersonalScoreRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AFB3 RID: 110515 RVA: 0x003EE193 File Offset: 0x003EC393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AFB4 RID: 110516 RVA: 0x003EE19C File Offset: 0x003EC39C
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
				if (num != 80U && num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, ThemePersonalScoreRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04009DBC RID: 40380
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DBD RID: 40381
		public const int IdsFieldNumber = 10;

		// Token: 0x04009DBE RID: 40382
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04009DBF RID: 40383
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
