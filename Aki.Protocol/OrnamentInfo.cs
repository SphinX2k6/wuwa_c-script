using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BA1 RID: 2977
	public sealed class OrnamentInfo : IMessage<OrnamentInfo>, IMessage, IEquatable<OrnamentInfo>, IDeepCloneable<OrnamentInfo>, IBufferMessage
	{
		// Token: 0x060102A3 RID: 66211 RVA: 0x0025C931 File Offset: 0x0025AB31
		[NullableContext(1)]
		public static OrnamentInfo Create()
		{
			return new OrnamentInfo();
		}

		// Token: 0x17003501 RID: 13569
		// (get) Token: 0x060102A4 RID: 66212 RVA: 0x0025C938 File Offset: 0x0025AB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003502 RID: 13570
		// (get) Token: 0x060102A5 RID: 66213 RVA: 0x0025C93B File Offset: 0x0025AB3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrnamentInfo.Descriptor;
			}
		}

		// Token: 0x060102A6 RID: 66214 RVA: 0x0025C942 File Offset: 0x0025AB42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentInfo()
		{
		}

		// Token: 0x060102A7 RID: 66215 RVA: 0x0025C96C File Offset: 0x0025AB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentInfo(OrnamentInfo other) : this()
		{
			this.unlockOrnamentIds_ = other.unlockOrnamentIds_.Clone();
			this.ornamentDressInfos_ = other.ornamentDressInfos_.Clone();
			this.redPointOrnamentIds_ = other.redPointOrnamentIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060102A8 RID: 66216 RVA: 0x0025C9C3 File Offset: 0x0025ABC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentInfo Clone()
		{
			return new OrnamentInfo(this);
		}

		// Token: 0x17003503 RID: 13571
		// (get) Token: 0x060102A9 RID: 66217 RVA: 0x0025C9CB File Offset: 0x0025ABCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockOrnamentIds
		{
			get
			{
				return this.unlockOrnamentIds_;
			}
		}

		// Token: 0x17003504 RID: 13572
		// (get) Token: 0x060102AA RID: 66218 RVA: 0x0025C9D3 File Offset: 0x0025ABD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OrnamentDressInfo> OrnamentDressInfos
		{
			get
			{
				return this.ornamentDressInfos_;
			}
		}

		// Token: 0x17003505 RID: 13573
		// (get) Token: 0x060102AB RID: 66219 RVA: 0x0025C9DB File Offset: 0x0025ABDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RedPointOrnamentIds
		{
			get
			{
				return this.redPointOrnamentIds_;
			}
		}

		// Token: 0x060102AC RID: 66220 RVA: 0x0025C9E3 File Offset: 0x0025ABE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrnamentInfo);
		}

		// Token: 0x060102AD RID: 66221 RVA: 0x0025C9F4 File Offset: 0x0025ABF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrnamentInfo other)
		{
			return other != null && (other == this || (this.unlockOrnamentIds_.Equals(other.unlockOrnamentIds_) && this.ornamentDressInfos_.Equals(other.ornamentDressInfos_) && this.redPointOrnamentIds_.Equals(other.redPointOrnamentIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060102AE RID: 66222 RVA: 0x0025CA5C File Offset: 0x0025AC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockOrnamentIds_.GetHashCode();
			num ^= this.ornamentDressInfos_.GetHashCode();
			num ^= this.redPointOrnamentIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060102AF RID: 66223 RVA: 0x0025CAAC File Offset: 0x0025ACAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060102B0 RID: 66224 RVA: 0x0025CAB9 File Offset: 0x0025ACB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060102B1 RID: 66225 RVA: 0x0025CAC4 File Offset: 0x0025ACC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockOrnamentIds_.WriteTo(ref output, OrnamentInfo._repeated_unlockOrnamentIds_codec);
			this.ornamentDressInfos_.WriteTo(ref output, OrnamentInfo._repeated_ornamentDressInfos_codec);
			this.redPointOrnamentIds_.WriteTo(ref output, OrnamentInfo._repeated_redPointOrnamentIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060102B2 RID: 66226 RVA: 0x0025CB18 File Offset: 0x0025AD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockOrnamentIds_.CalculateSize(OrnamentInfo._repeated_unlockOrnamentIds_codec);
			num += this.ornamentDressInfos_.CalculateSize(OrnamentInfo._repeated_ornamentDressInfos_codec);
			num += this.redPointOrnamentIds_.CalculateSize(OrnamentInfo._repeated_redPointOrnamentIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060102B3 RID: 66227 RVA: 0x0025CB78 File Offset: 0x0025AD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OrnamentInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockOrnamentIds_.Add(other.unlockOrnamentIds_);
			this.ornamentDressInfos_.Add(other.ornamentDressInfos_);
			this.redPointOrnamentIds_.Add(other.redPointOrnamentIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060102B4 RID: 66228 RVA: 0x0025CBD3 File Offset: 0x0025ADD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060102B5 RID: 66229 RVA: 0x0025CBDC File Offset: 0x0025ADDC
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
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.unlockOrnamentIds_.AddEntriesFrom(ref input, OrnamentInfo._repeated_unlockOrnamentIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 18U)
					{
						this.ornamentDressInfos_.AddEntriesFrom(ref input, OrnamentInfo._repeated_ornamentDressInfos_codec);
						continue;
					}
					if (num == 24U || num == 26U)
					{
						this.redPointOrnamentIds_.AddEntriesFrom(ref input, OrnamentInfo._repeated_redPointOrnamentIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006760 RID: 26464
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006761 RID: 26465
		public const int UnlockOrnamentIdsFieldNumber = 1;

		// Token: 0x04006762 RID: 26466
		private static readonly FieldCodec<int> _repeated_unlockOrnamentIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04006763 RID: 26467
		private readonly RepeatedField<int> unlockOrnamentIds_ = new RepeatedField<int>();

		// Token: 0x04006764 RID: 26468
		public const int OrnamentDressInfosFieldNumber = 2;

		// Token: 0x04006765 RID: 26469
		private static readonly FieldCodec<OrnamentDressInfo> _repeated_ornamentDressInfos_codec = FieldCodec.ForMessage<OrnamentDressInfo>(18U, OrnamentDressInfo.Parser);

		// Token: 0x04006766 RID: 26470
		private readonly RepeatedField<OrnamentDressInfo> ornamentDressInfos_ = new RepeatedField<OrnamentDressInfo>();

		// Token: 0x04006767 RID: 26471
		public const int RedPointOrnamentIdsFieldNumber = 3;

		// Token: 0x04006768 RID: 26472
		private static readonly FieldCodec<int> _repeated_redPointOrnamentIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04006769 RID: 26473
		private readonly RepeatedField<int> redPointOrnamentIds_ = new RepeatedField<int>();
	}
}
