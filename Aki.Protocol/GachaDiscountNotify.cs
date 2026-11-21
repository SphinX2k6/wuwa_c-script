using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200067C RID: 1660
	[NetMessage(EMessageId.GachaDiscountNotify)]
	public sealed class GachaDiscountNotify : IMessage<GachaDiscountNotify>, IMessage, IEquatable<GachaDiscountNotify>, IDeepCloneable<GachaDiscountNotify>, IBufferMessage
	{
		// Token: 0x0600986B RID: 39019 RVA: 0x0016FB40 File Offset: 0x0016DD40
		[NullableContext(1)]
		public static GachaDiscountNotify Create()
		{
			return new GachaDiscountNotify();
		}

		// Token: 0x17001E62 RID: 7778
		// (get) Token: 0x0600986C RID: 39020 RVA: 0x0016FB47 File Offset: 0x0016DD47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E63 RID: 7779
		// (get) Token: 0x0600986D RID: 39021 RVA: 0x0016FB4A File Offset: 0x0016DD4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaDiscountNotify.Descriptor;
			}
		}

		// Token: 0x0600986E RID: 39022 RVA: 0x0016FB51 File Offset: 0x0016DD51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaDiscountNotify()
		{
		}

		// Token: 0x0600986F RID: 39023 RVA: 0x0016FB64 File Offset: 0x0016DD64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaDiscountNotify(GachaDiscountNotify other) : this()
		{
			this.gachaId_ = other.gachaId_;
			this.gachaDiscountInfos_ = other.gachaDiscountInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009870 RID: 39024 RVA: 0x0016FB9A File Offset: 0x0016DD9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaDiscountNotify Clone()
		{
			return new GachaDiscountNotify(this);
		}

		// Token: 0x17001E64 RID: 7780
		// (get) Token: 0x06009871 RID: 39025 RVA: 0x0016FBA2 File Offset: 0x0016DDA2
		// (set) Token: 0x06009872 RID: 39026 RVA: 0x0016FBAA File Offset: 0x0016DDAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GachaId
		{
			get
			{
				return this.gachaId_;
			}
			set
			{
				this.gachaId_ = value;
			}
		}

		// Token: 0x17001E65 RID: 7781
		// (get) Token: 0x06009873 RID: 39027 RVA: 0x0016FBB3 File Offset: 0x0016DDB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaDiscountInfo> GachaDiscountInfos
		{
			get
			{
				return this.gachaDiscountInfos_;
			}
		}

		// Token: 0x06009874 RID: 39028 RVA: 0x0016FBBB File Offset: 0x0016DDBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaDiscountNotify);
		}

		// Token: 0x06009875 RID: 39029 RVA: 0x0016FBCC File Offset: 0x0016DDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaDiscountNotify other)
		{
			return other != null && (other == this || (this.GachaId == other.GachaId && this.gachaDiscountInfos_.Equals(other.gachaDiscountInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009876 RID: 39030 RVA: 0x0016FC1C File Offset: 0x0016DE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GachaId != 0)
			{
				num ^= this.GachaId.GetHashCode();
			}
			num ^= this.gachaDiscountInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009877 RID: 39031 RVA: 0x0016FC69 File Offset: 0x0016DE69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009878 RID: 39032 RVA: 0x0016FC76 File Offset: 0x0016DE76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009879 RID: 39033 RVA: 0x0016FC80 File Offset: 0x0016DE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GachaId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.GachaId);
			}
			this.gachaDiscountInfos_.WriteTo(ref output, GachaDiscountNotify._repeated_gachaDiscountInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600987A RID: 39034 RVA: 0x0016FCD0 File Offset: 0x0016DED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GachaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GachaId);
			}
			num += this.gachaDiscountInfos_.CalculateSize(GachaDiscountNotify._repeated_gachaDiscountInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600987B RID: 39035 RVA: 0x0016FD24 File Offset: 0x0016DF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaDiscountNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GachaId != 0)
			{
				this.GachaId = other.GachaId;
			}
			this.gachaDiscountInfos_.Add(other.gachaDiscountInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600987C RID: 39036 RVA: 0x0016FD71 File Offset: 0x0016DF71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600987D RID: 39037 RVA: 0x0016FD7C File Offset: 0x0016DF7C
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
				if (num != 48U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.gachaDiscountInfos_.AddEntriesFrom(ref input, GachaDiscountNotify._repeated_gachaDiscountInfos_codec);
					}
				}
				else
				{
					this.GachaId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040048A9 RID: 18601
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048AA RID: 18602
		public const int GachaIdFieldNumber = 6;

		// Token: 0x040048AB RID: 18603
		private int gachaId_;

		// Token: 0x040048AC RID: 18604
		public const int GachaDiscountInfosFieldNumber = 13;

		// Token: 0x040048AD RID: 18605
		private static readonly FieldCodec<GachaDiscountInfo> _repeated_gachaDiscountInfos_codec = FieldCodec.ForMessage<GachaDiscountInfo>(106U, GachaDiscountInfo.Parser);

		// Token: 0x040048AE RID: 18606
		private readonly RepeatedField<GachaDiscountInfo> gachaDiscountInfos_ = new RepeatedField<GachaDiscountInfo>();
	}
}
