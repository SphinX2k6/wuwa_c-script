using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A0D RID: 2573
	[NetMessage(EMessageId.MotorAnimReplaySampleUdpNotify)]
	public sealed class MotorAnimReplaySampleUdpNotify : IMessage<MotorAnimReplaySampleUdpNotify>, IMessage, IEquatable<MotorAnimReplaySampleUdpNotify>, IDeepCloneable<MotorAnimReplaySampleUdpNotify>, IBufferMessage
	{
		// Token: 0x0600E16D RID: 57709 RVA: 0x00210C38 File Offset: 0x0020EE38
		[NullableContext(1)]
		public static MotorAnimReplaySampleUdpNotify Create()
		{
			return new MotorAnimReplaySampleUdpNotify();
		}

		// Token: 0x17002DB6 RID: 11702
		// (get) Token: 0x0600E16E RID: 57710 RVA: 0x00210C3F File Offset: 0x0020EE3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DB7 RID: 11703
		// (get) Token: 0x0600E16F RID: 57711 RVA: 0x00210C42 File Offset: 0x0020EE42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorAnimReplaySampleUdpNotify.Descriptor;
			}
		}

		// Token: 0x0600E170 RID: 57712 RVA: 0x00210C49 File Offset: 0x0020EE49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorAnimReplaySampleUdpNotify()
		{
		}

		// Token: 0x0600E171 RID: 57713 RVA: 0x00210C5C File Offset: 0x0020EE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorAnimReplaySampleUdpNotify(MotorAnimReplaySampleUdpNotify other) : this()
		{
			this.motorAnimEntities_ = other.motorAnimEntities_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E172 RID: 57714 RVA: 0x00210C86 File Offset: 0x0020EE86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorAnimReplaySampleUdpNotify Clone()
		{
			return new MotorAnimReplaySampleUdpNotify(this);
		}

		// Token: 0x17002DB8 RID: 11704
		// (get) Token: 0x0600E173 RID: 57715 RVA: 0x00210C8E File Offset: 0x0020EE8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorAnimEntity> MotorAnimEntities
		{
			get
			{
				return this.motorAnimEntities_;
			}
		}

		// Token: 0x0600E174 RID: 57716 RVA: 0x00210C96 File Offset: 0x0020EE96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorAnimReplaySampleUdpNotify);
		}

		// Token: 0x0600E175 RID: 57717 RVA: 0x00210CA4 File Offset: 0x0020EEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorAnimReplaySampleUdpNotify other)
		{
			return other != null && (other == this || (this.motorAnimEntities_.Equals(other.motorAnimEntities_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E176 RID: 57718 RVA: 0x00210CD8 File Offset: 0x0020EED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.motorAnimEntities_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E177 RID: 57719 RVA: 0x00210D0C File Offset: 0x0020EF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E178 RID: 57720 RVA: 0x00210D19 File Offset: 0x0020EF19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E179 RID: 57721 RVA: 0x00210D22 File Offset: 0x0020EF22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.motorAnimEntities_.WriteTo(ref output, MotorAnimReplaySampleUdpNotify._repeated_motorAnimEntities_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E17A RID: 57722 RVA: 0x00210D4C File Offset: 0x0020EF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.motorAnimEntities_.CalculateSize(MotorAnimReplaySampleUdpNotify._repeated_motorAnimEntities_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E17B RID: 57723 RVA: 0x00210D85 File Offset: 0x0020EF85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorAnimReplaySampleUdpNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.motorAnimEntities_.Add(other.motorAnimEntities_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E17C RID: 57724 RVA: 0x00210DB3 File Offset: 0x0020EFB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E17D RID: 57725 RVA: 0x00210DBC File Offset: 0x0020EFBC
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.motorAnimEntities_.AddEntriesFrom(ref input, MotorAnimReplaySampleUdpNotify._repeated_motorAnimEntities_codec);
				}
			}
		}

		// Token: 0x04005D0B RID: 23819
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D0C RID: 23820
		public const int MotorAnimEntitiesFieldNumber = 4;

		// Token: 0x04005D0D RID: 23821
		private static readonly FieldCodec<MotorAnimEntity> _repeated_motorAnimEntities_codec = FieldCodec.ForMessage<MotorAnimEntity>(34U, MotorAnimEntity.Parser);

		// Token: 0x04005D0E RID: 23822
		private readonly RepeatedField<MotorAnimEntity> motorAnimEntities_ = new RepeatedField<MotorAnimEntity>();
	}
}
