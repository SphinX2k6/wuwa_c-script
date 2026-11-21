using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000DE RID: 222
	[NetMessage(EMessageId.AlertAreaNotify)]
	public sealed class AlertAreaNotify : IMessage<AlertAreaNotify>, IMessage, IEquatable<AlertAreaNotify>, IDeepCloneable<AlertAreaNotify>, IBufferMessage
	{
		// Token: 0x0600214E RID: 8526 RVA: 0x00059896 File Offset: 0x00057A96
		[NullableContext(1)]
		public static AlertAreaNotify Create()
		{
			return new AlertAreaNotify();
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x0600214F RID: 8527 RVA: 0x0005989D File Offset: 0x00057A9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06002150 RID: 8528 RVA: 0x000598A0 File Offset: 0x00057AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AlertAreaNotify.Descriptor;
			}
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x000598A7 File Offset: 0x00057AA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlertAreaNotify()
		{
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x000598C5 File Offset: 0x00057AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlertAreaNotify(AlertAreaNotify other) : this()
		{
			this.alertAreas_ = other.alertAreas_.Clone();
			this.removeAreaIds_ = other.removeAreaIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x00059900 File Offset: 0x00057B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlertAreaNotify Clone()
		{
			return new AlertAreaNotify(this);
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06002154 RID: 8532 RVA: 0x00059908 File Offset: 0x00057B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AlertArea> AlertAreas
		{
			get
			{
				return this.alertAreas_;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06002155 RID: 8533 RVA: 0x00059910 File Offset: 0x00057B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RemoveAreaIds
		{
			get
			{
				return this.removeAreaIds_;
			}
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x00059918 File Offset: 0x00057B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AlertAreaNotify);
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x00059928 File Offset: 0x00057B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AlertAreaNotify other)
		{
			return other != null && (other == this || (this.alertAreas_.Equals(other.alertAreas_) && this.removeAreaIds_.Equals(other.removeAreaIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x0005997C File Offset: 0x00057B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.alertAreas_.GetHashCode();
			num ^= this.removeAreaIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x000599BE File Offset: 0x00057BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x000599CB File Offset: 0x00057BCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x000599D4 File Offset: 0x00057BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.alertAreas_.WriteTo(ref output, AlertAreaNotify._repeated_alertAreas_codec);
			this.removeAreaIds_.WriteTo(ref output, AlertAreaNotify._repeated_removeAreaIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x00059A0C File Offset: 0x00057C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.alertAreas_.CalculateSize(AlertAreaNotify._repeated_alertAreas_codec);
			num += this.removeAreaIds_.CalculateSize(AlertAreaNotify._repeated_removeAreaIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x00059A58 File Offset: 0x00057C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AlertAreaNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.alertAreas_.Add(other.alertAreas_);
			this.removeAreaIds_.Add(other.removeAreaIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x00059A97 File Offset: 0x00057C97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x00059AA0 File Offset: 0x00057CA0
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
				if (num != 98U)
				{
					if (num != 112U && num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.removeAreaIds_.AddEntriesFrom(ref input, AlertAreaNotify._repeated_removeAreaIds_codec);
					}
				}
				else
				{
					this.alertAreas_.AddEntriesFrom(ref input, AlertAreaNotify._repeated_alertAreas_codec);
				}
			}
		}

		// Token: 0x04002484 RID: 9348
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002485 RID: 9349
		public const int AlertAreasFieldNumber = 12;

		// Token: 0x04002486 RID: 9350
		private static readonly FieldCodec<AlertArea> _repeated_alertAreas_codec = FieldCodec.ForMessage<AlertArea>(98U, AlertArea.Parser);

		// Token: 0x04002487 RID: 9351
		private readonly RepeatedField<AlertArea> alertAreas_ = new RepeatedField<AlertArea>();

		// Token: 0x04002488 RID: 9352
		public const int RemoveAreaIdsFieldNumber = 14;

		// Token: 0x04002489 RID: 9353
		private static readonly FieldCodec<int> _repeated_removeAreaIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x0400248A RID: 9354
		private readonly RepeatedField<int> removeAreaIds_ = new RepeatedField<int>();
	}
}
