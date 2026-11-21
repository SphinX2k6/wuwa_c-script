using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006D5 RID: 1749
	[NetMessage(EMessageId.GiantSystemInfoNotify)]
	public sealed class GiantSystemInfoNotify : IMessage<GiantSystemInfoNotify>, IMessage, IEquatable<GiantSystemInfoNotify>, IDeepCloneable<GiantSystemInfoNotify>, IBufferMessage
	{
		// Token: 0x0600A000 RID: 40960 RVA: 0x00183CA0 File Offset: 0x00181EA0
		[NullableContext(1)]
		public static GiantSystemInfoNotify Create()
		{
			return new GiantSystemInfoNotify();
		}

		// Token: 0x1700201F RID: 8223
		// (get) Token: 0x0600A001 RID: 40961 RVA: 0x00183CA7 File Offset: 0x00181EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002020 RID: 8224
		// (get) Token: 0x0600A002 RID: 40962 RVA: 0x00183CAA File Offset: 0x00181EAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantSystemInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600A003 RID: 40963 RVA: 0x00183CB1 File Offset: 0x00181EB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantSystemInfoNotify()
		{
		}

		// Token: 0x0600A004 RID: 40964 RVA: 0x00183CDC File Offset: 0x00181EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantSystemInfoNotify(GiantSystemInfoNotify other) : this()
		{
			this.disableGiantModel_ = other.disableGiantModel_;
			this.giantIdleType_ = other.giantIdleType_;
			this.giantEcoInfos_ = other.giantEcoInfos_.Clone();
			this.unlockItemIds_ = other.unlockItemIds_.Clone();
			this.giantItemAccessPbs_ = other.giantItemAccessPbs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A005 RID: 40965 RVA: 0x00183D4B File Offset: 0x00181F4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantSystemInfoNotify Clone()
		{
			return new GiantSystemInfoNotify(this);
		}

		// Token: 0x17002021 RID: 8225
		// (get) Token: 0x0600A006 RID: 40966 RVA: 0x00183D53 File Offset: 0x00181F53
		// (set) Token: 0x0600A007 RID: 40967 RVA: 0x00183D5B File Offset: 0x00181F5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DisableGiantModel
		{
			get
			{
				return this.disableGiantModel_;
			}
			set
			{
				this.disableGiantModel_ = value;
			}
		}

		// Token: 0x17002022 RID: 8226
		// (get) Token: 0x0600A008 RID: 40968 RVA: 0x00183D64 File Offset: 0x00181F64
		// (set) Token: 0x0600A009 RID: 40969 RVA: 0x00183D6C File Offset: 0x00181F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantIdleNetType GiantIdleType
		{
			get
			{
				return this.giantIdleType_;
			}
			set
			{
				this.giantIdleType_ = value;
			}
		}

		// Token: 0x17002023 RID: 8227
		// (get) Token: 0x0600A00A RID: 40970 RVA: 0x00183D75 File Offset: 0x00181F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GiantEcoInfoPb> GiantEcoInfos
		{
			get
			{
				return this.giantEcoInfos_;
			}
		}

		// Token: 0x17002024 RID: 8228
		// (get) Token: 0x0600A00B RID: 40971 RVA: 0x00183D7D File Offset: 0x00181F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockItemIds
		{
			get
			{
				return this.unlockItemIds_;
			}
		}

		// Token: 0x17002025 RID: 8229
		// (get) Token: 0x0600A00C RID: 40972 RVA: 0x00183D85 File Offset: 0x00181F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GiantItemAccessPb> GiantItemAccessPbs
		{
			get
			{
				return this.giantItemAccessPbs_;
			}
		}

		// Token: 0x0600A00D RID: 40973 RVA: 0x00183D8D File Offset: 0x00181F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantSystemInfoNotify);
		}

		// Token: 0x0600A00E RID: 40974 RVA: 0x00183D9C File Offset: 0x00181F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantSystemInfoNotify other)
		{
			return other != null && (other == this || (this.DisableGiantModel == other.DisableGiantModel && this.GiantIdleType == other.GiantIdleType && this.giantEcoInfos_.Equals(other.giantEcoInfos_) && this.unlockItemIds_.Equals(other.unlockItemIds_) && this.giantItemAccessPbs_.Equals(other.giantItemAccessPbs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A00F RID: 40975 RVA: 0x00183E24 File Offset: 0x00182024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DisableGiantModel)
			{
				num ^= this.DisableGiantModel.GetHashCode();
			}
			if (this.GiantIdleType != GiantIdleNetType.Common)
			{
				num ^= this.GiantIdleType.GetHashCode();
			}
			num ^= this.giantEcoInfos_.GetHashCode();
			num ^= this.unlockItemIds_.GetHashCode();
			num ^= this.giantItemAccessPbs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A010 RID: 40976 RVA: 0x00183EAC File Offset: 0x001820AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A011 RID: 40977 RVA: 0x00183EB9 File Offset: 0x001820B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A012 RID: 40978 RVA: 0x00183EC4 File Offset: 0x001820C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.giantItemAccessPbs_.WriteTo(ref output, GiantSystemInfoNotify._repeated_giantItemAccessPbs_codec);
			this.unlockItemIds_.WriteTo(ref output, GiantSystemInfoNotify._repeated_unlockItemIds_codec);
			if (this.DisableGiantModel)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.DisableGiantModel);
			}
			this.giantEcoInfos_.WriteTo(ref output, GiantSystemInfoNotify._repeated_giantEcoInfos_codec);
			if (this.GiantIdleType != GiantIdleNetType.Common)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.GiantIdleType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A013 RID: 40979 RVA: 0x00183F50 File Offset: 0x00182150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DisableGiantModel)
			{
				num += 2;
			}
			if (this.GiantIdleType != GiantIdleNetType.Common)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.GiantIdleType);
			}
			num += this.giantEcoInfos_.CalculateSize(GiantSystemInfoNotify._repeated_giantEcoInfos_codec);
			num += this.unlockItemIds_.CalculateSize(GiantSystemInfoNotify._repeated_unlockItemIds_codec);
			num += this.giantItemAccessPbs_.CalculateSize(GiantSystemInfoNotify._repeated_giantItemAccessPbs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A014 RID: 40980 RVA: 0x00183FD4 File Offset: 0x001821D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantSystemInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DisableGiantModel)
			{
				this.DisableGiantModel = other.DisableGiantModel;
			}
			if (other.GiantIdleType != GiantIdleNetType.Common)
			{
				this.GiantIdleType = other.GiantIdleType;
			}
			this.giantEcoInfos_.Add(other.giantEcoInfos_);
			this.unlockItemIds_.Add(other.unlockItemIds_);
			this.giantItemAccessPbs_.Add(other.giantItemAccessPbs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A015 RID: 40981 RVA: 0x00184057 File Offset: 0x00182257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A016 RID: 40982 RVA: 0x00184060 File Offset: 0x00182260
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
				if (num <= 42U)
				{
					if (num == 34U)
					{
						this.giantItemAccessPbs_.AddEntriesFrom(ref input, GiantSystemInfoNotify._repeated_giantItemAccessPbs_codec);
						continue;
					}
					if (num == 40U || num == 42U)
					{
						this.unlockItemIds_.AddEntriesFrom(ref input, GiantSystemInfoNotify._repeated_unlockItemIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.DisableGiantModel = input.ReadBool();
						continue;
					}
					if (num == 98U)
					{
						this.giantEcoInfos_.AddEntriesFrom(ref input, GiantSystemInfoNotify._repeated_giantEcoInfos_codec);
						continue;
					}
					if (num == 104U)
					{
						this.GiantIdleType = (GiantIdleNetType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004AE8 RID: 19176
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AE9 RID: 19177
		public const int DisableGiantModelFieldNumber = 11;

		// Token: 0x04004AEA RID: 19178
		private bool disableGiantModel_;

		// Token: 0x04004AEB RID: 19179
		public const int GiantIdleTypeFieldNumber = 13;

		// Token: 0x04004AEC RID: 19180
		private GiantIdleNetType giantIdleType_;

		// Token: 0x04004AED RID: 19181
		public const int GiantEcoInfosFieldNumber = 12;

		// Token: 0x04004AEE RID: 19182
		private static readonly FieldCodec<GiantEcoInfoPb> _repeated_giantEcoInfos_codec = FieldCodec.ForMessage<GiantEcoInfoPb>(98U, GiantEcoInfoPb.Parser);

		// Token: 0x04004AEF RID: 19183
		private readonly RepeatedField<GiantEcoInfoPb> giantEcoInfos_ = new RepeatedField<GiantEcoInfoPb>();

		// Token: 0x04004AF0 RID: 19184
		public const int UnlockItemIdsFieldNumber = 5;

		// Token: 0x04004AF1 RID: 19185
		private static readonly FieldCodec<int> _repeated_unlockItemIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04004AF2 RID: 19186
		private readonly RepeatedField<int> unlockItemIds_ = new RepeatedField<int>();

		// Token: 0x04004AF3 RID: 19187
		public const int GiantItemAccessPbsFieldNumber = 4;

		// Token: 0x04004AF4 RID: 19188
		private static readonly FieldCodec<GiantItemAccessPb> _repeated_giantItemAccessPbs_codec = FieldCodec.ForMessage<GiantItemAccessPb>(34U, GiantItemAccessPb.Parser);

		// Token: 0x04004AF5 RID: 19189
		private readonly RepeatedField<GiantItemAccessPb> giantItemAccessPbs_ = new RepeatedField<GiantItemAccessPb>();
	}
}
