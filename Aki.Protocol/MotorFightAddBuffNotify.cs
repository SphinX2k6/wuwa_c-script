using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A36 RID: 2614
	[NetMessage(EMessageId.MotorFightAddBuffNotify)]
	public sealed class MotorFightAddBuffNotify : IMessage<MotorFightAddBuffNotify>, IMessage, IEquatable<MotorFightAddBuffNotify>, IDeepCloneable<MotorFightAddBuffNotify>, IBufferMessage
	{
		// Token: 0x0600E44B RID: 58443 RVA: 0x002164CE File Offset: 0x002146CE
		[NullableContext(1)]
		public static MotorFightAddBuffNotify Create()
		{
			return new MotorFightAddBuffNotify();
		}

		// Token: 0x17002E48 RID: 11848
		// (get) Token: 0x0600E44C RID: 58444 RVA: 0x002164D5 File Offset: 0x002146D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E49 RID: 11849
		// (get) Token: 0x0600E44D RID: 58445 RVA: 0x002164D8 File Offset: 0x002146D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightAddBuffNotify.Descriptor;
			}
		}

		// Token: 0x0600E44E RID: 58446 RVA: 0x002164DF File Offset: 0x002146DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightAddBuffNotify()
		{
		}

		// Token: 0x0600E44F RID: 58447 RVA: 0x002164F2 File Offset: 0x002146F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightAddBuffNotify(MotorFightAddBuffNotify other) : this()
		{
			this.buffs_ = other.buffs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E450 RID: 58448 RVA: 0x0021651C File Offset: 0x0021471C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightAddBuffNotify Clone()
		{
			return new MotorFightAddBuffNotify(this);
		}

		// Token: 0x17002E4A RID: 11850
		// (get) Token: 0x0600E451 RID: 58449 RVA: 0x00216524 File Offset: 0x00214724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightRoundBuffPb> Buffs
		{
			get
			{
				return this.buffs_;
			}
		}

		// Token: 0x0600E452 RID: 58450 RVA: 0x0021652C File Offset: 0x0021472C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightAddBuffNotify);
		}

		// Token: 0x0600E453 RID: 58451 RVA: 0x0021653A File Offset: 0x0021473A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightAddBuffNotify other)
		{
			return other != null && (other == this || (this.buffs_.Equals(other.buffs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E454 RID: 58452 RVA: 0x00216570 File Offset: 0x00214770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.buffs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E455 RID: 58453 RVA: 0x002165A4 File Offset: 0x002147A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E456 RID: 58454 RVA: 0x002165B1 File Offset: 0x002147B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E457 RID: 58455 RVA: 0x002165BA File Offset: 0x002147BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.buffs_.WriteTo(ref output, MotorFightAddBuffNotify._repeated_buffs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E458 RID: 58456 RVA: 0x002165E4 File Offset: 0x002147E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.buffs_.CalculateSize(MotorFightAddBuffNotify._repeated_buffs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E459 RID: 58457 RVA: 0x0021661D File Offset: 0x0021481D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightAddBuffNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.buffs_.Add(other.buffs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E45A RID: 58458 RVA: 0x0021664B File Offset: 0x0021484B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E45B RID: 58459 RVA: 0x00216654 File Offset: 0x00214854
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.buffs_.AddEntriesFrom(ref input, MotorFightAddBuffNotify._repeated_buffs_codec);
				}
			}
		}

		// Token: 0x04005D70 RID: 23920
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D71 RID: 23921
		public const int BuffsFieldNumber = 13;

		// Token: 0x04005D72 RID: 23922
		private static readonly FieldCodec<MotorFightRoundBuffPb> _repeated_buffs_codec = FieldCodec.ForMessage<MotorFightRoundBuffPb>(106U, MotorFightRoundBuffPb.Parser);

		// Token: 0x04005D73 RID: 23923
		private readonly RepeatedField<MotorFightRoundBuffPb> buffs_ = new RepeatedField<MotorFightRoundBuffPb>();
	}
}
