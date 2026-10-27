using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BB1 RID: 2993
	public sealed class OrnamentInfo : IMessage<OrnamentInfo>, IMessage, IEquatable<OrnamentInfo>, IDeepCloneable<OrnamentInfo>, IBufferMessage
	{
		// Token: 0x060103A7 RID: 66471 RVA: 0x0025E7E9 File Offset: 0x0025C9E9
		[NullableContext(1)]
		public static OrnamentInfo Create()
		{
			return new OrnamentInfo();
		}

		// Token: 0x1700353A RID: 13626
		// (get) Token: 0x060103A8 RID: 66472 RVA: 0x0025E7F0 File Offset: 0x0025C9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700353B RID: 13627
		// (get) Token: 0x060103A9 RID: 66473 RVA: 0x0025E7F3 File Offset: 0x0025C9F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrnamentInfo.Descriptor;
			}
		}

		// Token: 0x060103AA RID: 66474 RVA: 0x0025E7FA File Offset: 0x0025C9FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentInfo()
		{
		}

		// Token: 0x060103AB RID: 66475 RVA: 0x0025E824 File Offset: 0x0025CA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentInfo(OrnamentInfo other) : this()
		{
			this.unlockOrnamentIds_ = other.unlockOrnamentIds_.Clone();
			this.ornamentDressInfos_ = other.ornamentDressInfos_.Clone();
			this.redPointOrnamentIds_ = other.redPointOrnamentIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060103AC RID: 66476 RVA: 0x0025E87B File Offset: 0x0025CA7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentInfo Clone()
		{
			return new OrnamentInfo(this);
		}

		// Token: 0x1700353C RID: 13628
		// (get) Token: 0x060103AD RID: 66477 RVA: 0x0025E883 File Offset: 0x0025CA83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockOrnamentIds
		{
			get
			{
				return this.unlockOrnamentIds_;
			}
		}

		// Token: 0x1700353D RID: 13629
		// (get) Token: 0x060103AE RID: 66478 RVA: 0x0025E88B File Offset: 0x0025CA8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OrnamentDressInfo> OrnamentDressInfos
		{
			get
			{
				return this.ornamentDressInfos_;
			}
		}

		// Token: 0x1700353E RID: 13630
		// (get) Token: 0x060103AF RID: 66479 RVA: 0x0025E893 File Offset: 0x0025CA93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RedPointOrnamentIds
		{
			get
			{
				return this.redPointOrnamentIds_;
			}
		}

		// Token: 0x060103B0 RID: 66480 RVA: 0x0025E89B File Offset: 0x0025CA9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrnamentInfo);
		}

		// Token: 0x060103B1 RID: 66481 RVA: 0x0025E8AC File Offset: 0x0025CAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrnamentInfo other)
		{
			return other != null && (other == this || (this.unlockOrnamentIds_.Equals(other.unlockOrnamentIds_) && this.ornamentDressInfos_.Equals(other.ornamentDressInfos_) && this.redPointOrnamentIds_.Equals(other.redPointOrnamentIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060103B2 RID: 66482 RVA: 0x0025E914 File Offset: 0x0025CB14
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

		// Token: 0x060103B3 RID: 66483 RVA: 0x0025E964 File Offset: 0x0025CB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060103B4 RID: 66484 RVA: 0x0025E971 File Offset: 0x0025CB71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060103B5 RID: 66485 RVA: 0x0025E97C File Offset: 0x0025CB7C
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

		// Token: 0x060103B6 RID: 66486 RVA: 0x0025E9D0 File Offset: 0x0025CBD0
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

		// Token: 0x060103B7 RID: 66487 RVA: 0x0025EA30 File Offset: 0x0025CC30
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

		// Token: 0x060103B8 RID: 66488 RVA: 0x0025EA8B File Offset: 0x0025CC8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060103B9 RID: 66489 RVA: 0x0025EA94 File Offset: 0x0025CC94
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

		// Token: 0x04006750 RID: 26448
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006751 RID: 26449
		public const int UnlockOrnamentIdsFieldNumber = 1;

		// Token: 0x04006752 RID: 26450
		private static readonly FieldCodec<int> _repeated_unlockOrnamentIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04006753 RID: 26451
		private readonly RepeatedField<int> unlockOrnamentIds_ = new RepeatedField<int>();

		// Token: 0x04006754 RID: 26452
		public const int OrnamentDressInfosFieldNumber = 2;

		// Token: 0x04006755 RID: 26453
		private static readonly FieldCodec<OrnamentDressInfo> _repeated_ornamentDressInfos_codec = FieldCodec.ForMessage<OrnamentDressInfo>(18U, OrnamentDressInfo.Parser);

		// Token: 0x04006756 RID: 26454
		private readonly RepeatedField<OrnamentDressInfo> ornamentDressInfos_ = new RepeatedField<OrnamentDressInfo>();

		// Token: 0x04006757 RID: 26455
		public const int RedPointOrnamentIdsFieldNumber = 3;

		// Token: 0x04006758 RID: 26456
		private static readonly FieldCodec<int> _repeated_redPointOrnamentIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04006759 RID: 26457
		private readonly RepeatedField<int> redPointOrnamentIds_ = new RepeatedField<int>();
	}
}
