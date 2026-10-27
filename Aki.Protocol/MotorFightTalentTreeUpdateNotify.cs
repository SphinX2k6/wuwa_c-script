using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A6C RID: 2668
	[NetMessage(EMessageId.MotorFightTalentTreeUpdateNotify)]
	public sealed class MotorFightTalentTreeUpdateNotify : IMessage<MotorFightTalentTreeUpdateNotify>, IMessage, IEquatable<MotorFightTalentTreeUpdateNotify>, IDeepCloneable<MotorFightTalentTreeUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600E8B6 RID: 59574 RVA: 0x0021FF3D File Offset: 0x0021E13D
		[NullableContext(1)]
		public static MotorFightTalentTreeUpdateNotify Create()
		{
			return new MotorFightTalentTreeUpdateNotify();
		}

		// Token: 0x17002F3B RID: 12091
		// (get) Token: 0x0600E8B7 RID: 59575 RVA: 0x0021FF44 File Offset: 0x0021E144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F3C RID: 12092
		// (get) Token: 0x0600E8B8 RID: 59576 RVA: 0x0021FF47 File Offset: 0x0021E147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightTalentTreeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600E8B9 RID: 59577 RVA: 0x0021FF4E File Offset: 0x0021E14E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentTreeUpdateNotify()
		{
		}

		// Token: 0x0600E8BA RID: 59578 RVA: 0x0021FF61 File Offset: 0x0021E161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentTreeUpdateNotify(MotorFightTalentTreeUpdateNotify other) : this()
		{
			this.talent_ = other.talent_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E8BB RID: 59579 RVA: 0x0021FF8B File Offset: 0x0021E18B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentTreeUpdateNotify Clone()
		{
			return new MotorFightTalentTreeUpdateNotify(this);
		}

		// Token: 0x17002F3D RID: 12093
		// (get) Token: 0x0600E8BC RID: 59580 RVA: 0x0021FF93 File Offset: 0x0021E193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightTalentPb> Talent
		{
			get
			{
				return this.talent_;
			}
		}

		// Token: 0x0600E8BD RID: 59581 RVA: 0x0021FF9B File Offset: 0x0021E19B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightTalentTreeUpdateNotify);
		}

		// Token: 0x0600E8BE RID: 59582 RVA: 0x0021FFA9 File Offset: 0x0021E1A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightTalentTreeUpdateNotify other)
		{
			return other != null && (other == this || (this.talent_.Equals(other.talent_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E8BF RID: 59583 RVA: 0x0021FFDC File Offset: 0x0021E1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.talent_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E8C0 RID: 59584 RVA: 0x00220010 File Offset: 0x0021E210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E8C1 RID: 59585 RVA: 0x0022001D File Offset: 0x0021E21D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E8C2 RID: 59586 RVA: 0x00220026 File Offset: 0x0021E226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.talent_.WriteTo(ref output, MotorFightTalentTreeUpdateNotify._repeated_talent_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E8C3 RID: 59587 RVA: 0x00220050 File Offset: 0x0021E250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.talent_.CalculateSize(MotorFightTalentTreeUpdateNotify._repeated_talent_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E8C4 RID: 59588 RVA: 0x00220089 File Offset: 0x0021E289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightTalentTreeUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.talent_.Add(other.talent_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E8C5 RID: 59589 RVA: 0x002200B7 File Offset: 0x0021E2B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E8C6 RID: 59590 RVA: 0x002200C0 File Offset: 0x0021E2C0
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
					this.talent_.AddEntriesFrom(ref input, MotorFightTalentTreeUpdateNotify._repeated_talent_codec);
				}
			}
		}

		// Token: 0x04005EBD RID: 24253
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EBE RID: 24254
		public const int TalentFieldNumber = 4;

		// Token: 0x04005EBF RID: 24255
		private static readonly FieldCodec<MotorFightTalentPb> _repeated_talent_codec = FieldCodec.ForMessage<MotorFightTalentPb>(34U, MotorFightTalentPb.Parser);

		// Token: 0x04005EC0 RID: 24256
		private readonly RepeatedField<MotorFightTalentPb> talent_ = new RepeatedField<MotorFightTalentPb>();
	}
}
