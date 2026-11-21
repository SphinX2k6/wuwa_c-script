using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x0200172B RID: 5931
	[NetMessage(EMessageId.AiHateNotify)]
	public sealed class AiHateNotify : IMessage<AiHateNotify>, IMessage, IEquatable<AiHateNotify>, IDeepCloneable<AiHateNotify>, IBufferMessage
	{
		// Token: 0x0601DC58 RID: 121944 RVA: 0x0045DBB7 File Offset: 0x0045BDB7
		[NullableContext(1)]
		public static AiHateNotify Create()
		{
			return new AiHateNotify();
		}

		// Token: 0x1700655C RID: 25948
		// (get) Token: 0x0601DC59 RID: 121945 RVA: 0x0045DBBE File Offset: 0x0045BDBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700655D RID: 25949
		// (get) Token: 0x0601DC5A RID: 121946 RVA: 0x0045DBC1 File Offset: 0x0045BDC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiHateNotify.Descriptor;
			}
		}

		// Token: 0x0601DC5B RID: 121947 RVA: 0x0045DBC8 File Offset: 0x0045BDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateNotify()
		{
		}

		// Token: 0x0601DC5C RID: 121948 RVA: 0x0045DBDB File Offset: 0x0045BDDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateNotify(AiHateNotify other) : this()
		{
			this.hateList_ = other.hateList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DC5D RID: 121949 RVA: 0x0045DC05 File Offset: 0x0045BE05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateNotify Clone()
		{
			return new AiHateNotify(this);
		}

		// Token: 0x1700655E RID: 25950
		// (get) Token: 0x0601DC5E RID: 121950 RVA: 0x0045DC0D File Offset: 0x0045BE0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AiHateEntity> HateList
		{
			get
			{
				return this.hateList_;
			}
		}

		// Token: 0x0601DC5F RID: 121951 RVA: 0x0045DC15 File Offset: 0x0045BE15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiHateNotify);
		}

		// Token: 0x0601DC60 RID: 121952 RVA: 0x0045DC23 File Offset: 0x0045BE23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiHateNotify other)
		{
			return other != null && (other == this || (this.hateList_.Equals(other.hateList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DC61 RID: 121953 RVA: 0x0045DC58 File Offset: 0x0045BE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hateList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DC62 RID: 121954 RVA: 0x0045DC8C File Offset: 0x0045BE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DC63 RID: 121955 RVA: 0x0045DC99 File Offset: 0x0045BE99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DC64 RID: 121956 RVA: 0x0045DCA2 File Offset: 0x0045BEA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hateList_.WriteTo(ref output, AiHateNotify._repeated_hateList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DC65 RID: 121957 RVA: 0x0045DCCC File Offset: 0x0045BECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hateList_.CalculateSize(AiHateNotify._repeated_hateList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DC66 RID: 121958 RVA: 0x0045DD05 File Offset: 0x0045BF05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiHateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.hateList_.Add(other.hateList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DC67 RID: 121959 RVA: 0x0045DD33 File Offset: 0x0045BF33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DC68 RID: 121960 RVA: 0x0045DD3C File Offset: 0x0045BF3C
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.hateList_.AddEntriesFrom(ref input, AiHateNotify._repeated_hateList_codec);
				}
			}
		}

		// Token: 0x0400C96F RID: 51567
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C970 RID: 51568
		public const int HateListFieldNumber = 4;

		// Token: 0x0400C971 RID: 51569
		private static readonly FieldCodec<AiHateEntity> _repeated_hateList_codec = FieldCodec.ForMessage<AiHateEntity>(34U, AiHateEntity.Parser);

		// Token: 0x0400C972 RID: 51570
		private readonly RepeatedField<AiHateEntity> hateList_ = new RepeatedField<AiHateEntity>();
	}
}
