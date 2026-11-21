using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002F8 RID: 760
	public sealed class ControlTemporaryTeleportParam : IMessage<ControlTemporaryTeleportParam>, IMessage, IEquatable<ControlTemporaryTeleportParam>, IDeepCloneable<ControlTemporaryTeleportParam>, IBufferMessage
	{
		// Token: 0x06004D38 RID: 19768 RVA: 0x000BC0E6 File Offset: 0x000BA2E6
		[NullableContext(1)]
		public static ControlTemporaryTeleportParam Create()
		{
			return new ControlTemporaryTeleportParam();
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x06004D39 RID: 19769 RVA: 0x000BC0ED File Offset: 0x000BA2ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06004D3A RID: 19770 RVA: 0x000BC0F0 File Offset: 0x000BA2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ControlTemporaryTeleportParam.Descriptor;
			}
		}

		// Token: 0x06004D3B RID: 19771 RVA: 0x000BC0F7 File Offset: 0x000BA2F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlTemporaryTeleportParam()
		{
		}

		// Token: 0x06004D3C RID: 19772 RVA: 0x000BC10A File Offset: 0x000BA30A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlTemporaryTeleportParam(ControlTemporaryTeleportParam other) : this()
		{
			this.temporaryTeleportIds_ = other.temporaryTeleportIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D3D RID: 19773 RVA: 0x000BC134 File Offset: 0x000BA334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlTemporaryTeleportParam Clone()
		{
			return new ControlTemporaryTeleportParam(this);
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06004D3E RID: 19774 RVA: 0x000BC13C File Offset: 0x000BA33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> TemporaryTeleportIds
		{
			get
			{
				return this.temporaryTeleportIds_;
			}
		}

		// Token: 0x06004D3F RID: 19775 RVA: 0x000BC144 File Offset: 0x000BA344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ControlTemporaryTeleportParam);
		}

		// Token: 0x06004D40 RID: 19776 RVA: 0x000BC152 File Offset: 0x000BA352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ControlTemporaryTeleportParam other)
		{
			return other != null && (other == this || (this.temporaryTeleportIds_.Equals(other.temporaryTeleportIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004D41 RID: 19777 RVA: 0x000BC188 File Offset: 0x000BA388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.temporaryTeleportIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004D42 RID: 19778 RVA: 0x000BC1BC File Offset: 0x000BA3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004D43 RID: 19779 RVA: 0x000BC1C9 File Offset: 0x000BA3C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D44 RID: 19780 RVA: 0x000BC1D2 File Offset: 0x000BA3D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.temporaryTeleportIds_.WriteTo(ref output, ControlTemporaryTeleportParam._repeated_temporaryTeleportIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D45 RID: 19781 RVA: 0x000BC1FC File Offset: 0x000BA3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.temporaryTeleportIds_.CalculateSize(ControlTemporaryTeleportParam._repeated_temporaryTeleportIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004D46 RID: 19782 RVA: 0x000BC235 File Offset: 0x000BA435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ControlTemporaryTeleportParam other)
		{
			if (other == null)
			{
				return;
			}
			this.temporaryTeleportIds_.Add(other.temporaryTeleportIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004D47 RID: 19783 RVA: 0x000BC263 File Offset: 0x000BA463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D48 RID: 19784 RVA: 0x000BC26C File Offset: 0x000BA46C
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.temporaryTeleportIds_.AddEntriesFrom(ref input, ControlTemporaryTeleportParam._repeated_temporaryTeleportIds_codec);
				}
			}
		}

		// Token: 0x0400318C RID: 12684
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400318D RID: 12685
		public const int TemporaryTeleportIdsFieldNumber = 1;

		// Token: 0x0400318E RID: 12686
		private static readonly FieldCodec<long> _repeated_temporaryTeleportIds_codec = FieldCodec.ForInt64(10U);

		// Token: 0x0400318F RID: 12687
		private readonly RepeatedField<long> temporaryTeleportIds_ = new RepeatedField<long>();
	}
}
