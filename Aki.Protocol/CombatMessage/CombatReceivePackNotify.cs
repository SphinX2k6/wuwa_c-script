using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x02001706 RID: 5894
	[NetMessage(EMessageId.CombatReceivePackNotify)]
	public sealed class CombatReceivePackNotify : IMessage<CombatReceivePackNotify>, IMessage, IEquatable<CombatReceivePackNotify>, IDeepCloneable<CombatReceivePackNotify>, IBufferMessage
	{
		// Token: 0x0601D844 RID: 120900 RVA: 0x0044CDE9 File Offset: 0x0044AFE9
		[NullableContext(1)]
		public static CombatReceivePackNotify Create()
		{
			return new CombatReceivePackNotify();
		}

		// Token: 0x17006426 RID: 25638
		// (get) Token: 0x0601D845 RID: 120901 RVA: 0x0044CDF0 File Offset: 0x0044AFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006427 RID: 25639
		// (get) Token: 0x0601D846 RID: 120902 RVA: 0x0044CDF3 File Offset: 0x0044AFF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatReceivePackNotify.Descriptor;
			}
		}

		// Token: 0x0601D847 RID: 120903 RVA: 0x0044CDFA File Offset: 0x0044AFFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatReceivePackNotify()
		{
		}

		// Token: 0x0601D848 RID: 120904 RVA: 0x0044CE0D File Offset: 0x0044B00D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatReceivePackNotify(CombatReceivePackNotify other) : this()
		{
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D849 RID: 120905 RVA: 0x0044CE37 File Offset: 0x0044B037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatReceivePackNotify Clone()
		{
			return new CombatReceivePackNotify(this);
		}

		// Token: 0x17006428 RID: 25640
		// (get) Token: 0x0601D84A RID: 120906 RVA: 0x0044CE3F File Offset: 0x0044B03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CombatReceiveData> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x0601D84B RID: 120907 RVA: 0x0044CE47 File Offset: 0x0044B047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatReceivePackNotify);
		}

		// Token: 0x0601D84C RID: 120908 RVA: 0x0044CE55 File Offset: 0x0044B055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatReceivePackNotify other)
		{
			return other != null && (other == this || (this.data_.Equals(other.data_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D84D RID: 120909 RVA: 0x0044CE88 File Offset: 0x0044B088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.data_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D84E RID: 120910 RVA: 0x0044CEBC File Offset: 0x0044B0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D84F RID: 120911 RVA: 0x0044CEC9 File Offset: 0x0044B0C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D850 RID: 120912 RVA: 0x0044CED2 File Offset: 0x0044B0D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.data_.WriteTo(ref output, CombatReceivePackNotify._repeated_data_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D851 RID: 120913 RVA: 0x0044CEFC File Offset: 0x0044B0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.data_.CalculateSize(CombatReceivePackNotify._repeated_data_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D852 RID: 120914 RVA: 0x0044CF35 File Offset: 0x0044B135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatReceivePackNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.data_.Add(other.data_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D853 RID: 120915 RVA: 0x0044CF63 File Offset: 0x0044B163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D854 RID: 120916 RVA: 0x0044CF6C File Offset: 0x0044B16C
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
					this.data_.AddEntriesFrom(ref input, CombatReceivePackNotify._repeated_data_codec);
				}
			}
		}

		// Token: 0x0400C7E3 RID: 51171
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C7E4 RID: 51172
		public const int DataFieldNumber = 4;

		// Token: 0x0400C7E5 RID: 51173
		private static readonly FieldCodec<CombatReceiveData> _repeated_data_codec = FieldCodec.ForMessage<CombatReceiveData>(34U, CombatReceiveData.Parser);

		// Token: 0x0400C7E6 RID: 51174
		private readonly RepeatedField<CombatReceiveData> data_ = new RepeatedField<CombatReceiveData>();
	}
}
