using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006CC RID: 1740
	public sealed class GetItemProgress : IMessage<GetItemProgress>, IMessage, IEquatable<GetItemProgress>, IDeepCloneable<GetItemProgress>, IBufferMessage
	{
		// Token: 0x06009F17 RID: 40727 RVA: 0x00181C73 File Offset: 0x0017FE73
		[NullableContext(1)]
		public static GetItemProgress Create()
		{
			return new GetItemProgress();
		}

		// Token: 0x17001FF6 RID: 8182
		// (get) Token: 0x06009F18 RID: 40728 RVA: 0x00181C7A File Offset: 0x0017FE7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FF7 RID: 8183
		// (get) Token: 0x06009F19 RID: 40729 RVA: 0x00181C7D File Offset: 0x0017FE7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetItemProgress.Descriptor;
			}
		}

		// Token: 0x06009F1A RID: 40730 RVA: 0x00181C84 File Offset: 0x0017FE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetItemProgress()
		{
		}

		// Token: 0x06009F1B RID: 40731 RVA: 0x00181C97 File Offset: 0x0017FE97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetItemProgress(GetItemProgress other) : this()
		{
			this.info_ = other.info_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F1C RID: 40732 RVA: 0x00181CC1 File Offset: 0x0017FEC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetItemProgress Clone()
		{
			return new GetItemProgress(this);
		}

		// Token: 0x17001FF8 RID: 8184
		// (get) Token: 0x06009F1D RID: 40733 RVA: 0x00181CC9 File Offset: 0x0017FEC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GetItemCount> Info
		{
			get
			{
				return this.info_;
			}
		}

		// Token: 0x06009F1E RID: 40734 RVA: 0x00181CD1 File Offset: 0x0017FED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetItemProgress);
		}

		// Token: 0x06009F1F RID: 40735 RVA: 0x00181CDF File Offset: 0x0017FEDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetItemProgress other)
		{
			return other != null && (other == this || (this.info_.Equals(other.info_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009F20 RID: 40736 RVA: 0x00181D14 File Offset: 0x0017FF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.info_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009F21 RID: 40737 RVA: 0x00181D48 File Offset: 0x0017FF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009F22 RID: 40738 RVA: 0x00181D55 File Offset: 0x0017FF55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F23 RID: 40739 RVA: 0x00181D5E File Offset: 0x0017FF5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.info_.WriteTo(ref output, GetItemProgress._repeated_info_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F24 RID: 40740 RVA: 0x00181D88 File Offset: 0x0017FF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.info_.CalculateSize(GetItemProgress._repeated_info_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009F25 RID: 40741 RVA: 0x00181DC1 File Offset: 0x0017FFC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetItemProgress other)
		{
			if (other == null)
			{
				return;
			}
			this.info_.Add(other.info_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009F26 RID: 40742 RVA: 0x00181DEF File Offset: 0x0017FFEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F27 RID: 40743 RVA: 0x00181DF8 File Offset: 0x0017FFF8
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
					this.info_.AddEntriesFrom(ref input, GetItemProgress._repeated_info_codec);
				}
			}
		}

		// Token: 0x04004A57 RID: 19031
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A58 RID: 19032
		public const int InfoFieldNumber = 1;

		// Token: 0x04004A59 RID: 19033
		private static readonly FieldCodec<GetItemCount> _repeated_info_codec = FieldCodec.ForMessage<GetItemCount>(10U, GetItemCount.Parser);

		// Token: 0x04004A5A RID: 19034
		private readonly RepeatedField<GetItemCount> info_ = new RepeatedField<GetItemCount>();
	}
}
