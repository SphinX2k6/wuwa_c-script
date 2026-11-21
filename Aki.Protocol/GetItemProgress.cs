using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006B8 RID: 1720
	public sealed class GetItemProgress : IMessage<GetItemProgress>, IMessage, IEquatable<GetItemProgress>, IDeepCloneable<GetItemProgress>, IBufferMessage
	{
		// Token: 0x06009DC1 RID: 40385 RVA: 0x0017F23F File Offset: 0x0017D43F
		[NullableContext(1)]
		public static GetItemProgress Create()
		{
			return new GetItemProgress();
		}

		// Token: 0x17001FAC RID: 8108
		// (get) Token: 0x06009DC2 RID: 40386 RVA: 0x0017F246 File Offset: 0x0017D446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FAD RID: 8109
		// (get) Token: 0x06009DC3 RID: 40387 RVA: 0x0017F249 File Offset: 0x0017D449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetItemProgress.Descriptor;
			}
		}

		// Token: 0x06009DC4 RID: 40388 RVA: 0x0017F250 File Offset: 0x0017D450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetItemProgress()
		{
		}

		// Token: 0x06009DC5 RID: 40389 RVA: 0x0017F263 File Offset: 0x0017D463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetItemProgress(GetItemProgress other) : this()
		{
			this.info_ = other.info_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009DC6 RID: 40390 RVA: 0x0017F28D File Offset: 0x0017D48D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetItemProgress Clone()
		{
			return new GetItemProgress(this);
		}

		// Token: 0x17001FAE RID: 8110
		// (get) Token: 0x06009DC7 RID: 40391 RVA: 0x0017F295 File Offset: 0x0017D495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GetItemCount> Info
		{
			get
			{
				return this.info_;
			}
		}

		// Token: 0x06009DC8 RID: 40392 RVA: 0x0017F29D File Offset: 0x0017D49D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetItemProgress);
		}

		// Token: 0x06009DC9 RID: 40393 RVA: 0x0017F2AB File Offset: 0x0017D4AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetItemProgress other)
		{
			return other != null && (other == this || (this.info_.Equals(other.info_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009DCA RID: 40394 RVA: 0x0017F2E0 File Offset: 0x0017D4E0
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

		// Token: 0x06009DCB RID: 40395 RVA: 0x0017F314 File Offset: 0x0017D514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009DCC RID: 40396 RVA: 0x0017F321 File Offset: 0x0017D521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009DCD RID: 40397 RVA: 0x0017F32A File Offset: 0x0017D52A
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

		// Token: 0x06009DCE RID: 40398 RVA: 0x0017F354 File Offset: 0x0017D554
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

		// Token: 0x06009DCF RID: 40399 RVA: 0x0017F38D File Offset: 0x0017D58D
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

		// Token: 0x06009DD0 RID: 40400 RVA: 0x0017F3BB File Offset: 0x0017D5BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009DD1 RID: 40401 RVA: 0x0017F3C4 File Offset: 0x0017D5C4
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

		// Token: 0x04004A50 RID: 19024
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A51 RID: 19025
		public const int InfoFieldNumber = 1;

		// Token: 0x04004A52 RID: 19026
		private static readonly FieldCodec<GetItemCount> _repeated_info_codec = FieldCodec.ForMessage<GetItemCount>(10U, GetItemCount.Parser);

		// Token: 0x04004A53 RID: 19027
		private readonly RepeatedField<GetItemCount> info_ = new RepeatedField<GetItemCount>();
	}
}
