using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000DD RID: 221
	[NetMessage(EMessageId.AlertAreaNotify)]
	public sealed class AlertAreaNotify : IMessage<AlertAreaNotify>, IMessage, IEquatable<AlertAreaNotify>, IDeepCloneable<AlertAreaNotify>, IBufferMessage
	{
		// Token: 0x06002105 RID: 8453 RVA: 0x00058BE2 File Offset: 0x00056DE2
		[NullableContext(1)]
		public static AlertAreaNotify Create()
		{
			return new AlertAreaNotify();
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06002106 RID: 8454 RVA: 0x00058BE9 File Offset: 0x00056DE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06002107 RID: 8455 RVA: 0x00058BEC File Offset: 0x00056DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AlertAreaNotify.Descriptor;
			}
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x00058BF3 File Offset: 0x00056DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlertAreaNotify()
		{
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x00058C11 File Offset: 0x00056E11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlertAreaNotify(AlertAreaNotify other) : this()
		{
			this.alertAreas_ = other.alertAreas_.Clone();
			this.removeAreaIds_ = other.removeAreaIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x00058C4C File Offset: 0x00056E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlertAreaNotify Clone()
		{
			return new AlertAreaNotify(this);
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x0600210B RID: 8459 RVA: 0x00058C54 File Offset: 0x00056E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AlertArea> AlertAreas
		{
			get
			{
				return this.alertAreas_;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x0600210C RID: 8460 RVA: 0x00058C5C File Offset: 0x00056E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RemoveAreaIds
		{
			get
			{
				return this.removeAreaIds_;
			}
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x00058C64 File Offset: 0x00056E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AlertAreaNotify);
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x00058C74 File Offset: 0x00056E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AlertAreaNotify other)
		{
			return other != null && (other == this || (this.alertAreas_.Equals(other.alertAreas_) && this.removeAreaIds_.Equals(other.removeAreaIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x00058CC8 File Offset: 0x00056EC8
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

		// Token: 0x06002110 RID: 8464 RVA: 0x00058D0A File Offset: 0x00056F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x00058D17 File Offset: 0x00056F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x00058D20 File Offset: 0x00056F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.removeAreaIds_.WriteTo(ref output, AlertAreaNotify._repeated_removeAreaIds_codec);
			this.alertAreas_.WriteTo(ref output, AlertAreaNotify._repeated_alertAreas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x00058D58 File Offset: 0x00056F58
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

		// Token: 0x06002114 RID: 8468 RVA: 0x00058DA4 File Offset: 0x00056FA4
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

		// Token: 0x06002115 RID: 8469 RVA: 0x00058DE3 File Offset: 0x00056FE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x00058DEC File Offset: 0x00056FEC
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
				if (num != 88U && num != 90U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.alertAreas_.AddEntriesFrom(ref input, AlertAreaNotify._repeated_alertAreas_codec);
					}
				}
				else
				{
					this.removeAreaIds_.AddEntriesFrom(ref input, AlertAreaNotify._repeated_removeAreaIds_codec);
				}
			}
		}

		// Token: 0x04002421 RID: 9249
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002422 RID: 9250
		public const int AlertAreasFieldNumber = 12;

		// Token: 0x04002423 RID: 9251
		private static readonly FieldCodec<AlertArea> _repeated_alertAreas_codec = FieldCodec.ForMessage<AlertArea>(98U, AlertArea.Parser);

		// Token: 0x04002424 RID: 9252
		private readonly RepeatedField<AlertArea> alertAreas_ = new RepeatedField<AlertArea>();

		// Token: 0x04002425 RID: 9253
		public const int RemoveAreaIdsFieldNumber = 11;

		// Token: 0x04002426 RID: 9254
		private static readonly FieldCodec<int> _repeated_removeAreaIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04002427 RID: 9255
		private readonly RepeatedField<int> removeAreaIds_ = new RepeatedField<int>();
	}
}
