using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006E9 RID: 1769
	[NetMessage(EMessageId.GiantSystemInfoNotify)]
	public sealed class GiantSystemInfoNotify : IMessage<GiantSystemInfoNotify>, IMessage, IEquatable<GiantSystemInfoNotify>, IDeepCloneable<GiantSystemInfoNotify>, IBufferMessage
	{
		// Token: 0x0600A156 RID: 41302 RVA: 0x001866D4 File Offset: 0x001848D4
		[NullableContext(1)]
		public static GiantSystemInfoNotify Create()
		{
			return new GiantSystemInfoNotify();
		}

		// Token: 0x17002069 RID: 8297
		// (get) Token: 0x0600A157 RID: 41303 RVA: 0x001866DB File Offset: 0x001848DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700206A RID: 8298
		// (get) Token: 0x0600A158 RID: 41304 RVA: 0x001866DE File Offset: 0x001848DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantSystemInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600A159 RID: 41305 RVA: 0x001866E5 File Offset: 0x001848E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantSystemInfoNotify()
		{
		}

		// Token: 0x0600A15A RID: 41306 RVA: 0x00186710 File Offset: 0x00184910
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

		// Token: 0x0600A15B RID: 41307 RVA: 0x0018677F File Offset: 0x0018497F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantSystemInfoNotify Clone()
		{
			return new GiantSystemInfoNotify(this);
		}

		// Token: 0x1700206B RID: 8299
		// (get) Token: 0x0600A15C RID: 41308 RVA: 0x00186787 File Offset: 0x00184987
		// (set) Token: 0x0600A15D RID: 41309 RVA: 0x0018678F File Offset: 0x0018498F
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

		// Token: 0x1700206C RID: 8300
		// (get) Token: 0x0600A15E RID: 41310 RVA: 0x00186798 File Offset: 0x00184998
		// (set) Token: 0x0600A15F RID: 41311 RVA: 0x001867A0 File Offset: 0x001849A0
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

		// Token: 0x1700206D RID: 8301
		// (get) Token: 0x0600A160 RID: 41312 RVA: 0x001867A9 File Offset: 0x001849A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GiantEcoInfoPb> GiantEcoInfos
		{
			get
			{
				return this.giantEcoInfos_;
			}
		}

		// Token: 0x1700206E RID: 8302
		// (get) Token: 0x0600A161 RID: 41313 RVA: 0x001867B1 File Offset: 0x001849B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockItemIds
		{
			get
			{
				return this.unlockItemIds_;
			}
		}

		// Token: 0x1700206F RID: 8303
		// (get) Token: 0x0600A162 RID: 41314 RVA: 0x001867B9 File Offset: 0x001849B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GiantItemAccessPb> GiantItemAccessPbs
		{
			get
			{
				return this.giantItemAccessPbs_;
			}
		}

		// Token: 0x0600A163 RID: 41315 RVA: 0x001867C1 File Offset: 0x001849C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantSystemInfoNotify);
		}

		// Token: 0x0600A164 RID: 41316 RVA: 0x001867D0 File Offset: 0x001849D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantSystemInfoNotify other)
		{
			return other != null && (other == this || (this.DisableGiantModel == other.DisableGiantModel && this.GiantIdleType == other.GiantIdleType && this.giantEcoInfos_.Equals(other.giantEcoInfos_) && this.unlockItemIds_.Equals(other.unlockItemIds_) && this.giantItemAccessPbs_.Equals(other.giantItemAccessPbs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A165 RID: 41317 RVA: 0x00186858 File Offset: 0x00184A58
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

		// Token: 0x0600A166 RID: 41318 RVA: 0x001868E0 File Offset: 0x00184AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A167 RID: 41319 RVA: 0x001868ED File Offset: 0x00184AED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A168 RID: 41320 RVA: 0x001868F8 File Offset: 0x00184AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.giantItemAccessPbs_.WriteTo(ref output, GiantSystemInfoNotify._repeated_giantItemAccessPbs_codec);
			if (this.DisableGiantModel)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.DisableGiantModel);
			}
			this.unlockItemIds_.WriteTo(ref output, GiantSystemInfoNotify._repeated_unlockItemIds_codec);
			this.giantEcoInfos_.WriteTo(ref output, GiantSystemInfoNotify._repeated_giantEcoInfos_codec);
			if (this.GiantIdleType != GiantIdleNetType.Common)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.GiantIdleType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A169 RID: 41321 RVA: 0x00186984 File Offset: 0x00184B84
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

		// Token: 0x0600A16A RID: 41322 RVA: 0x00186A08 File Offset: 0x00184C08
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

		// Token: 0x0600A16B RID: 41323 RVA: 0x00186A8B File Offset: 0x00184C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A16C RID: 41324 RVA: 0x00186A94 File Offset: 0x00184C94
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
				if (num <= 56U)
				{
					if (num == 18U)
					{
						this.giantItemAccessPbs_.AddEntriesFrom(ref input, GiantSystemInfoNotify._repeated_giantItemAccessPbs_codec);
						continue;
					}
					if (num == 32U)
					{
						this.DisableGiantModel = input.ReadBool();
						continue;
					}
					if (num == 56U)
					{
						goto IL_66;
					}
				}
				else
				{
					if (num == 58U)
					{
						goto IL_66;
					}
					if (num == 106U)
					{
						this.giantEcoInfos_.AddEntriesFrom(ref input, GiantSystemInfoNotify._repeated_giantEcoInfos_codec);
						continue;
					}
					if (num == 112U)
					{
						this.GiantIdleType = (GiantIdleNetType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_66:
				this.unlockItemIds_.AddEntriesFrom(ref input, GiantSystemInfoNotify._repeated_unlockItemIds_codec);
			}
		}

		// Token: 0x04004AEF RID: 19183
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AF0 RID: 19184
		public const int DisableGiantModelFieldNumber = 4;

		// Token: 0x04004AF1 RID: 19185
		private bool disableGiantModel_;

		// Token: 0x04004AF2 RID: 19186
		public const int GiantIdleTypeFieldNumber = 14;

		// Token: 0x04004AF3 RID: 19187
		private GiantIdleNetType giantIdleType_;

		// Token: 0x04004AF4 RID: 19188
		public const int GiantEcoInfosFieldNumber = 13;

		// Token: 0x04004AF5 RID: 19189
		private static readonly FieldCodec<GiantEcoInfoPb> _repeated_giantEcoInfos_codec = FieldCodec.ForMessage<GiantEcoInfoPb>(106U, GiantEcoInfoPb.Parser);

		// Token: 0x04004AF6 RID: 19190
		private readonly RepeatedField<GiantEcoInfoPb> giantEcoInfos_ = new RepeatedField<GiantEcoInfoPb>();

		// Token: 0x04004AF7 RID: 19191
		public const int UnlockItemIdsFieldNumber = 7;

		// Token: 0x04004AF8 RID: 19192
		private static readonly FieldCodec<int> _repeated_unlockItemIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04004AF9 RID: 19193
		private readonly RepeatedField<int> unlockItemIds_ = new RepeatedField<int>();

		// Token: 0x04004AFA RID: 19194
		public const int GiantItemAccessPbsFieldNumber = 2;

		// Token: 0x04004AFB RID: 19195
		private static readonly FieldCodec<GiantItemAccessPb> _repeated_giantItemAccessPbs_codec = FieldCodec.ForMessage<GiantItemAccessPb>(18U, GiantItemAccessPb.Parser);

		// Token: 0x04004AFC RID: 19196
		private readonly RepeatedField<GiantItemAccessPb> giantItemAccessPbs_ = new RepeatedField<GiantItemAccessPb>();
	}
}
