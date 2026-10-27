using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002F1 RID: 753
	public sealed class ControlTemporaryTeleportParam : IMessage<ControlTemporaryTeleportParam>, IMessage, IEquatable<ControlTemporaryTeleportParam>, IDeepCloneable<ControlTemporaryTeleportParam>, IBufferMessage
	{
		// Token: 0x06004C5F RID: 19551 RVA: 0x000B9CFE File Offset: 0x000B7EFE
		[NullableContext(1)]
		public static ControlTemporaryTeleportParam Create()
		{
			return new ControlTemporaryTeleportParam();
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x06004C60 RID: 19552 RVA: 0x000B9D05 File Offset: 0x000B7F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x06004C61 RID: 19553 RVA: 0x000B9D08 File Offset: 0x000B7F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ControlTemporaryTeleportParam.Descriptor;
			}
		}

		// Token: 0x06004C62 RID: 19554 RVA: 0x000B9D0F File Offset: 0x000B7F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlTemporaryTeleportParam()
		{
		}

		// Token: 0x06004C63 RID: 19555 RVA: 0x000B9D22 File Offset: 0x000B7F22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlTemporaryTeleportParam(ControlTemporaryTeleportParam other) : this()
		{
			this.temporaryTeleportIds_ = other.temporaryTeleportIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C64 RID: 19556 RVA: 0x000B9D4C File Offset: 0x000B7F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlTemporaryTeleportParam Clone()
		{
			return new ControlTemporaryTeleportParam(this);
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x06004C65 RID: 19557 RVA: 0x000B9D54 File Offset: 0x000B7F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> TemporaryTeleportIds
		{
			get
			{
				return this.temporaryTeleportIds_;
			}
		}

		// Token: 0x06004C66 RID: 19558 RVA: 0x000B9D5C File Offset: 0x000B7F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ControlTemporaryTeleportParam);
		}

		// Token: 0x06004C67 RID: 19559 RVA: 0x000B9D6A File Offset: 0x000B7F6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ControlTemporaryTeleportParam other)
		{
			return other != null && (other == this || (this.temporaryTeleportIds_.Equals(other.temporaryTeleportIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004C68 RID: 19560 RVA: 0x000B9DA0 File Offset: 0x000B7FA0
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

		// Token: 0x06004C69 RID: 19561 RVA: 0x000B9DD4 File Offset: 0x000B7FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004C6A RID: 19562 RVA: 0x000B9DE1 File Offset: 0x000B7FE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C6B RID: 19563 RVA: 0x000B9DEA File Offset: 0x000B7FEA
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

		// Token: 0x06004C6C RID: 19564 RVA: 0x000B9E14 File Offset: 0x000B8014
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

		// Token: 0x06004C6D RID: 19565 RVA: 0x000B9E4D File Offset: 0x000B804D
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

		// Token: 0x06004C6E RID: 19566 RVA: 0x000B9E7B File Offset: 0x000B807B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C6F RID: 19567 RVA: 0x000B9E84 File Offset: 0x000B8084
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

		// Token: 0x040030F5 RID: 12533
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030F6 RID: 12534
		public const int TemporaryTeleportIdsFieldNumber = 1;

		// Token: 0x040030F7 RID: 12535
		private static readonly FieldCodec<long> _repeated_temporaryTeleportIds_codec = FieldCodec.ForInt64(10U);

		// Token: 0x040030F8 RID: 12536
		private readonly RepeatedField<long> temporaryTeleportIds_ = new RepeatedField<long>();
	}
}
