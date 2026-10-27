using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000769 RID: 1897
	[NetMessage(EMessageId.HonamiStoryBagInfoUpdateNotify)]
	public sealed class HonamiStoryBagInfoUpdateNotify : IMessage<HonamiStoryBagInfoUpdateNotify>, IMessage, IEquatable<HonamiStoryBagInfoUpdateNotify>, IDeepCloneable<HonamiStoryBagInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600AB9A RID: 43930 RVA: 0x0019CD16 File Offset: 0x0019AF16
		[NullableContext(1)]
		public static HonamiStoryBagInfoUpdateNotify Create()
		{
			return new HonamiStoryBagInfoUpdateNotify();
		}

		// Token: 0x17002296 RID: 8854
		// (get) Token: 0x0600AB9B RID: 43931 RVA: 0x0019CD1D File Offset: 0x0019AF1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002297 RID: 8855
		// (get) Token: 0x0600AB9C RID: 43932 RVA: 0x0019CD20 File Offset: 0x0019AF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryBagInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600AB9D RID: 43933 RVA: 0x0019CD27 File Offset: 0x0019AF27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagInfoUpdateNotify()
		{
		}

		// Token: 0x0600AB9E RID: 43934 RVA: 0x0019CD3A File Offset: 0x0019AF3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagInfoUpdateNotify(HonamiStoryBagInfoUpdateNotify other) : this()
		{
			this.honamiStoryBagInfos_ = other.honamiStoryBagInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB9F RID: 43935 RVA: 0x0019CD64 File Offset: 0x0019AF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagInfoUpdateNotify Clone()
		{
			return new HonamiStoryBagInfoUpdateNotify(this);
		}

		// Token: 0x17002298 RID: 8856
		// (get) Token: 0x0600ABA0 RID: 43936 RVA: 0x0019CD6C File Offset: 0x0019AF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryBagInfo> HonamiStoryBagInfos
		{
			get
			{
				return this.honamiStoryBagInfos_;
			}
		}

		// Token: 0x0600ABA1 RID: 43937 RVA: 0x0019CD74 File Offset: 0x0019AF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryBagInfoUpdateNotify);
		}

		// Token: 0x0600ABA2 RID: 43938 RVA: 0x0019CD82 File Offset: 0x0019AF82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryBagInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.honamiStoryBagInfos_.Equals(other.honamiStoryBagInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ABA3 RID: 43939 RVA: 0x0019CDB8 File Offset: 0x0019AFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.honamiStoryBagInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ABA4 RID: 43940 RVA: 0x0019CDEC File Offset: 0x0019AFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ABA5 RID: 43941 RVA: 0x0019CDF9 File Offset: 0x0019AFF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ABA6 RID: 43942 RVA: 0x0019CE02 File Offset: 0x0019B002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.honamiStoryBagInfos_.WriteTo(ref output, HonamiStoryBagInfoUpdateNotify._repeated_honamiStoryBagInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ABA7 RID: 43943 RVA: 0x0019CE2C File Offset: 0x0019B02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.honamiStoryBagInfos_.CalculateSize(HonamiStoryBagInfoUpdateNotify._repeated_honamiStoryBagInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ABA8 RID: 43944 RVA: 0x0019CE65 File Offset: 0x0019B065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryBagInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.honamiStoryBagInfos_.Add(other.honamiStoryBagInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ABA9 RID: 43945 RVA: 0x0019CE93 File Offset: 0x0019B093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ABAA RID: 43946 RVA: 0x0019CE9C File Offset: 0x0019B09C
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.honamiStoryBagInfos_.AddEntriesFrom(ref input, HonamiStoryBagInfoUpdateNotify._repeated_honamiStoryBagInfos_codec);
				}
			}
		}

		// Token: 0x04004DE2 RID: 19938
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DE3 RID: 19939
		public const int HonamiStoryBagInfosFieldNumber = 7;

		// Token: 0x04004DE4 RID: 19940
		private static readonly FieldCodec<HonamiStoryBagInfo> _repeated_honamiStoryBagInfos_codec = FieldCodec.ForMessage<HonamiStoryBagInfo>(58U, HonamiStoryBagInfo.Parser);

		// Token: 0x04004DE5 RID: 19941
		private readonly RepeatedField<HonamiStoryBagInfo> honamiStoryBagInfos_ = new RepeatedField<HonamiStoryBagInfo>();
	}
}
