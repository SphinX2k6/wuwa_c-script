using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000933 RID: 2355
	[NetMessage(EMessageId.LivenessTakeRequest)]
	public sealed class LivenessTakeRequest : IMessage<LivenessTakeRequest>, IMessage, IEquatable<LivenessTakeRequest>, IDeepCloneable<LivenessTakeRequest>, IBufferMessage
	{
		// Token: 0x0600CF98 RID: 53144 RVA: 0x001E9038 File Offset: 0x001E7238
		[NullableContext(1)]
		public static LivenessTakeRequest Create()
		{
			return new LivenessTakeRequest();
		}

		// Token: 0x170029F0 RID: 10736
		// (get) Token: 0x0600CF99 RID: 53145 RVA: 0x001E903F File Offset: 0x001E723F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029F1 RID: 10737
		// (get) Token: 0x0600CF9A RID: 53146 RVA: 0x001E9042 File Offset: 0x001E7242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LivenessTakeRequest.Descriptor;
			}
		}

		// Token: 0x0600CF9B RID: 53147 RVA: 0x001E9049 File Offset: 0x001E7249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTakeRequest()
		{
		}

		// Token: 0x0600CF9C RID: 53148 RVA: 0x001E905C File Offset: 0x001E725C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTakeRequest(LivenessTakeRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CF9D RID: 53149 RVA: 0x001E9086 File Offset: 0x001E7286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTakeRequest Clone()
		{
			return new LivenessTakeRequest(this);
		}

		// Token: 0x170029F2 RID: 10738
		// (get) Token: 0x0600CF9E RID: 53150 RVA: 0x001E908E File Offset: 0x001E728E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0600CF9F RID: 53151 RVA: 0x001E9096 File Offset: 0x001E7296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LivenessTakeRequest);
		}

		// Token: 0x0600CFA0 RID: 53152 RVA: 0x001E90A4 File Offset: 0x001E72A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LivenessTakeRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CFA1 RID: 53153 RVA: 0x001E90D8 File Offset: 0x001E72D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CFA2 RID: 53154 RVA: 0x001E910C File Offset: 0x001E730C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CFA3 RID: 53155 RVA: 0x001E9119 File Offset: 0x001E7319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CFA4 RID: 53156 RVA: 0x001E9122 File Offset: 0x001E7322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, LivenessTakeRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CFA5 RID: 53157 RVA: 0x001E914C File Offset: 0x001E734C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(LivenessTakeRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CFA6 RID: 53158 RVA: 0x001E9185 File Offset: 0x001E7385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LivenessTakeRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CFA7 RID: 53159 RVA: 0x001E91B3 File Offset: 0x001E73B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CFA8 RID: 53160 RVA: 0x001E91BC File Offset: 0x001E73BC
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
				if (num != 16U && num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, LivenessTakeRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x0400578F RID: 22415
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005790 RID: 22416
		public const int IdsFieldNumber = 2;

		// Token: 0x04005791 RID: 22417
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04005792 RID: 22418
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
