using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200051C RID: 1308
	public sealed class FeiXuePreheatActivityInfo : IMessage<FeiXuePreheatActivityInfo>, IMessage, IEquatable<FeiXuePreheatActivityInfo>, IDeepCloneable<FeiXuePreheatActivityInfo>, IBufferMessage
	{
		// Token: 0x06007B1A RID: 31514 RVA: 0x0012ADEB File Offset: 0x00128FEB
		[NullableContext(1)]
		public static FeiXuePreheatActivityInfo Create()
		{
			return new FeiXuePreheatActivityInfo();
		}

		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x06007B1B RID: 31515 RVA: 0x0012ADF2 File Offset: 0x00128FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x06007B1C RID: 31516 RVA: 0x0012ADF5 File Offset: 0x00128FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FeiXuePreheatActivityInfo.Descriptor;
			}
		}

		// Token: 0x06007B1D RID: 31517 RVA: 0x0012ADFC File Offset: 0x00128FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatActivityInfo()
		{
		}

		// Token: 0x06007B1E RID: 31518 RVA: 0x0012AE0F File Offset: 0x0012900F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatActivityInfo(FeiXuePreheatActivityInfo other) : this()
		{
			this.feiXuePreheatInfos_ = other.feiXuePreheatInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007B1F RID: 31519 RVA: 0x0012AE39 File Offset: 0x00129039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatActivityInfo Clone()
		{
			return new FeiXuePreheatActivityInfo(this);
		}

		// Token: 0x170017DE RID: 6110
		// (get) Token: 0x06007B20 RID: 31520 RVA: 0x0012AE41 File Offset: 0x00129041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FeiXuePreheatInfo> FeiXuePreheatInfos
		{
			get
			{
				return this.feiXuePreheatInfos_;
			}
		}

		// Token: 0x06007B21 RID: 31521 RVA: 0x0012AE49 File Offset: 0x00129049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FeiXuePreheatActivityInfo);
		}

		// Token: 0x06007B22 RID: 31522 RVA: 0x0012AE57 File Offset: 0x00129057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FeiXuePreheatActivityInfo other)
		{
			return other != null && (other == this || (this.feiXuePreheatInfos_.Equals(other.feiXuePreheatInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007B23 RID: 31523 RVA: 0x0012AE8C File Offset: 0x0012908C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.feiXuePreheatInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007B24 RID: 31524 RVA: 0x0012AEC0 File Offset: 0x001290C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007B25 RID: 31525 RVA: 0x0012AECD File Offset: 0x001290CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007B26 RID: 31526 RVA: 0x0012AED6 File Offset: 0x001290D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.feiXuePreheatInfos_.WriteTo(ref output, FeiXuePreheatActivityInfo._repeated_feiXuePreheatInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007B27 RID: 31527 RVA: 0x0012AF00 File Offset: 0x00129100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.feiXuePreheatInfos_.CalculateSize(FeiXuePreheatActivityInfo._repeated_feiXuePreheatInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007B28 RID: 31528 RVA: 0x0012AF39 File Offset: 0x00129139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FeiXuePreheatActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.feiXuePreheatInfos_.Add(other.feiXuePreheatInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007B29 RID: 31529 RVA: 0x0012AF67 File Offset: 0x00129167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007B2A RID: 31530 RVA: 0x0012AF70 File Offset: 0x00129170
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.feiXuePreheatInfos_.AddEntriesFrom(ref input, FeiXuePreheatActivityInfo._repeated_feiXuePreheatInfos_codec);
				}
			}
		}

		// Token: 0x04003F69 RID: 16233
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F6A RID: 16234
		public const int FeiXuePreheatInfosFieldNumber = 1;

		// Token: 0x04003F6B RID: 16235
		private static readonly FieldCodec<FeiXuePreheatInfo> _repeated_feiXuePreheatInfos_codec = FieldCodec.ForMessage<FeiXuePreheatInfo>(10U, FeiXuePreheatInfo.Parser);

		// Token: 0x04003F6C RID: 16236
		private readonly RepeatedField<FeiXuePreheatInfo> feiXuePreheatInfos_ = new RepeatedField<FeiXuePreheatInfo>();
	}
}
