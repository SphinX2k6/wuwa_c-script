using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006CE RID: 1742
	[NetMessage(EMessageId.GiantResponseNotify)]
	public sealed class GiantResponseNotify : IMessage<GiantResponseNotify>, IMessage, IEquatable<GiantResponseNotify>, IDeepCloneable<GiantResponseNotify>, IBufferMessage
	{
		// Token: 0x06009F72 RID: 40818 RVA: 0x001829C1 File Offset: 0x00180BC1
		[NullableContext(1)]
		public static GiantResponseNotify Create()
		{
			return new GiantResponseNotify();
		}

		// Token: 0x17002002 RID: 8194
		// (get) Token: 0x06009F73 RID: 40819 RVA: 0x001829C8 File Offset: 0x00180BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002003 RID: 8195
		// (get) Token: 0x06009F74 RID: 40820 RVA: 0x001829CB File Offset: 0x00180BCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantResponseNotify.Descriptor;
			}
		}

		// Token: 0x06009F75 RID: 40821 RVA: 0x001829D2 File Offset: 0x00180BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponseNotify()
		{
		}

		// Token: 0x06009F76 RID: 40822 RVA: 0x001829E5 File Offset: 0x00180BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponseNotify(GiantResponseNotify other) : this()
		{
			this.giantIdleType_ = other.giantIdleType_;
			this.giantResponseInfos_ = other.giantResponseInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F77 RID: 40823 RVA: 0x00182A1B File Offset: 0x00180C1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponseNotify Clone()
		{
			return new GiantResponseNotify(this);
		}

		// Token: 0x17002004 RID: 8196
		// (get) Token: 0x06009F78 RID: 40824 RVA: 0x00182A23 File Offset: 0x00180C23
		// (set) Token: 0x06009F79 RID: 40825 RVA: 0x00182A2B File Offset: 0x00180C2B
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

		// Token: 0x17002005 RID: 8197
		// (get) Token: 0x06009F7A RID: 40826 RVA: 0x00182A34 File Offset: 0x00180C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GiantResponsePb> GiantResponseInfos
		{
			get
			{
				return this.giantResponseInfos_;
			}
		}

		// Token: 0x06009F7B RID: 40827 RVA: 0x00182A3C File Offset: 0x00180C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantResponseNotify);
		}

		// Token: 0x06009F7C RID: 40828 RVA: 0x00182A4C File Offset: 0x00180C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantResponseNotify other)
		{
			return other != null && (other == this || (this.GiantIdleType == other.GiantIdleType && this.giantResponseInfos_.Equals(other.giantResponseInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009F7D RID: 40829 RVA: 0x00182A9C File Offset: 0x00180C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GiantIdleType != GiantIdleNetType.Common)
			{
				num ^= this.GiantIdleType.GetHashCode();
			}
			num ^= this.giantResponseInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009F7E RID: 40830 RVA: 0x00182AEF File Offset: 0x00180CEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009F7F RID: 40831 RVA: 0x00182AFC File Offset: 0x00180CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F80 RID: 40832 RVA: 0x00182B08 File Offset: 0x00180D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GiantIdleType != GiantIdleNetType.Common)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.GiantIdleType);
			}
			this.giantResponseInfos_.WriteTo(ref output, GiantResponseNotify._repeated_giantResponseInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F81 RID: 40833 RVA: 0x00182B58 File Offset: 0x00180D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GiantIdleType != GiantIdleNetType.Common)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.GiantIdleType);
			}
			num += this.giantResponseInfos_.CalculateSize(GiantResponseNotify._repeated_giantResponseInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009F82 RID: 40834 RVA: 0x00182BAC File Offset: 0x00180DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantResponseNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GiantIdleType != GiantIdleNetType.Common)
			{
				this.GiantIdleType = other.GiantIdleType;
			}
			this.giantResponseInfos_.Add(other.giantResponseInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009F83 RID: 40835 RVA: 0x00182BF9 File Offset: 0x00180DF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F84 RID: 40836 RVA: 0x00182C04 File Offset: 0x00180E04
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
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.giantResponseInfos_.AddEntriesFrom(ref input, GiantResponseNotify._repeated_giantResponseInfos_codec);
					}
				}
				else
				{
					this.GiantIdleType = (GiantIdleNetType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004AC3 RID: 19139
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AC4 RID: 19140
		public const int GiantIdleTypeFieldNumber = 6;

		// Token: 0x04004AC5 RID: 19141
		private GiantIdleNetType giantIdleType_;

		// Token: 0x04004AC6 RID: 19142
		public const int GiantResponseInfosFieldNumber = 15;

		// Token: 0x04004AC7 RID: 19143
		private static readonly FieldCodec<GiantResponsePb> _repeated_giantResponseInfos_codec = FieldCodec.ForMessage<GiantResponsePb>(122U, GiantResponsePb.Parser);

		// Token: 0x04004AC8 RID: 19144
		private readonly RepeatedField<GiantResponsePb> giantResponseInfos_ = new RepeatedField<GiantResponsePb>();
	}
}
