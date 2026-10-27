using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200120D RID: 4621
	[NetMessage(EMessageId.ShortMessageUpdateNotify)]
	public sealed class ShortMessageUpdateNotify : IMessage<ShortMessageUpdateNotify>, IMessage, IEquatable<ShortMessageUpdateNotify>, IDeepCloneable<ShortMessageUpdateNotify>, IBufferMessage
	{
		// Token: 0x06018A10 RID: 100880 RVA: 0x00394D41 File Offset: 0x00392F41
		[NullableContext(1)]
		public static ShortMessageUpdateNotify Create()
		{
			return new ShortMessageUpdateNotify();
		}

		// Token: 0x170052F9 RID: 21241
		// (get) Token: 0x06018A11 RID: 100881 RVA: 0x00394D48 File Offset: 0x00392F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052FA RID: 21242
		// (get) Token: 0x06018A12 RID: 100882 RVA: 0x00394D4B File Offset: 0x00392F4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06018A13 RID: 100883 RVA: 0x00394D52 File Offset: 0x00392F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageUpdateNotify()
		{
		}

		// Token: 0x06018A14 RID: 100884 RVA: 0x00394D7C File Offset: 0x00392F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageUpdateNotify(ShortMessageUpdateNotify other) : this()
		{
			this.adds_ = other.adds_.Clone();
			this.removes_ = other.removes_.Clone();
			this.reason_ = other.reason_;
			this.newPartnerChange_ = other.newPartnerChange_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018A15 RID: 100885 RVA: 0x00394DDF File Offset: 0x00392FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageUpdateNotify Clone()
		{
			return new ShortMessageUpdateNotify(this);
		}

		// Token: 0x170052FB RID: 21243
		// (get) Token: 0x06018A16 RID: 100886 RVA: 0x00394DE7 File Offset: 0x00392FE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ShortMessageInfo> Adds
		{
			get
			{
				return this.adds_;
			}
		}

		// Token: 0x170052FC RID: 21244
		// (get) Token: 0x06018A17 RID: 100887 RVA: 0x00394DEF File Offset: 0x00392FEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Removes
		{
			get
			{
				return this.removes_;
			}
		}

		// Token: 0x170052FD RID: 21245
		// (get) Token: 0x06018A18 RID: 100888 RVA: 0x00394DF7 File Offset: 0x00392FF7
		// (set) Token: 0x06018A19 RID: 100889 RVA: 0x00394DFF File Offset: 0x00392FFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x170052FE RID: 21246
		// (get) Token: 0x06018A1A RID: 100890 RVA: 0x00394E08 File Offset: 0x00393008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> NewPartnerChange
		{
			get
			{
				return this.newPartnerChange_;
			}
		}

		// Token: 0x06018A1B RID: 100891 RVA: 0x00394E10 File Offset: 0x00393010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageUpdateNotify);
		}

		// Token: 0x06018A1C RID: 100892 RVA: 0x00394E20 File Offset: 0x00393020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageUpdateNotify other)
		{
			return other != null && (other == this || (this.adds_.Equals(other.adds_) && this.removes_.Equals(other.removes_) && this.Reason == other.Reason && this.newPartnerChange_.Equals(other.newPartnerChange_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018A1D RID: 100893 RVA: 0x00394E98 File Offset: 0x00393098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.adds_.GetHashCode();
			num ^= this.removes_.GetHashCode();
			if (this.Reason != ChangeReason.None)
			{
				num ^= this.Reason.GetHashCode();
			}
			num ^= this.newPartnerChange_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018A1E RID: 100894 RVA: 0x00394F07 File Offset: 0x00393107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018A1F RID: 100895 RVA: 0x00394F14 File Offset: 0x00393114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018A20 RID: 100896 RVA: 0x00394F20 File Offset: 0x00393120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.adds_.WriteTo(ref output, ShortMessageUpdateNotify._repeated_adds_codec);
			this.removes_.WriteTo(ref output, ShortMessageUpdateNotify._repeated_removes_codec);
			this.newPartnerChange_.WriteTo(ref output, ShortMessageUpdateNotify._repeated_newPartnerChange_codec);
			if (this.Reason != ChangeReason.None)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018A21 RID: 100897 RVA: 0x00394F90 File Offset: 0x00393190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.adds_.CalculateSize(ShortMessageUpdateNotify._repeated_adds_codec);
			num += this.removes_.CalculateSize(ShortMessageUpdateNotify._repeated_removes_codec);
			if (this.Reason != ChangeReason.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			num += this.newPartnerChange_.CalculateSize(ShortMessageUpdateNotify._repeated_newPartnerChange_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018A22 RID: 100898 RVA: 0x00395008 File Offset: 0x00393208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.adds_.Add(other.adds_);
			this.removes_.Add(other.removes_);
			if (other.Reason != ChangeReason.None)
			{
				this.Reason = other.Reason;
			}
			this.newPartnerChange_.Add(other.newPartnerChange_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018A23 RID: 100899 RVA: 0x00395077 File Offset: 0x00393277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018A24 RID: 100900 RVA: 0x00395080 File Offset: 0x00393280
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
				if (num <= 34U)
				{
					if (num == 26U)
					{
						this.adds_.AddEntriesFrom(ref input, ShortMessageUpdateNotify._repeated_adds_codec);
						continue;
					}
					if (num == 32U || num == 34U)
					{
						this.removes_.AddEntriesFrom(ref input, ShortMessageUpdateNotify._repeated_removes_codec);
						continue;
					}
				}
				else
				{
					if (num == 72U || num == 74U)
					{
						this.newPartnerChange_.AddEntriesFrom(ref input, ShortMessageUpdateNotify._repeated_newPartnerChange_codec);
						continue;
					}
					if (num == 112U)
					{
						this.Reason = (ChangeReason)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009180 RID: 37248
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009181 RID: 37249
		public const int AddsFieldNumber = 3;

		// Token: 0x04009182 RID: 37250
		private static readonly FieldCodec<ShortMessageInfo> _repeated_adds_codec = FieldCodec.ForMessage<ShortMessageInfo>(26U, ShortMessageInfo.Parser);

		// Token: 0x04009183 RID: 37251
		private readonly RepeatedField<ShortMessageInfo> adds_ = new RepeatedField<ShortMessageInfo>();

		// Token: 0x04009184 RID: 37252
		public const int RemovesFieldNumber = 4;

		// Token: 0x04009185 RID: 37253
		private static readonly FieldCodec<int> _repeated_removes_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04009186 RID: 37254
		private readonly RepeatedField<int> removes_ = new RepeatedField<int>();

		// Token: 0x04009187 RID: 37255
		public const int ReasonFieldNumber = 14;

		// Token: 0x04009188 RID: 37256
		private ChangeReason reason_;

		// Token: 0x04009189 RID: 37257
		public const int NewPartnerChangeFieldNumber = 9;

		// Token: 0x0400918A RID: 37258
		private static readonly FieldCodec<int> _repeated_newPartnerChange_codec = FieldCodec.ForInt32(74U);

		// Token: 0x0400918B RID: 37259
		private readonly RepeatedField<int> newPartnerChange_ = new RepeatedField<int>();
	}
}
