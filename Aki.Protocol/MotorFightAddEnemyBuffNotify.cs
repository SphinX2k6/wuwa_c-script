using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A38 RID: 2616
	[NetMessage(EMessageId.MotorFightAddEnemyBuffNotify)]
	public sealed class MotorFightAddEnemyBuffNotify : IMessage<MotorFightAddEnemyBuffNotify>, IMessage, IEquatable<MotorFightAddEnemyBuffNotify>, IDeepCloneable<MotorFightAddEnemyBuffNotify>, IBufferMessage
	{
		// Token: 0x0600E46F RID: 58479 RVA: 0x00216891 File Offset: 0x00214A91
		[NullableContext(1)]
		public static MotorFightAddEnemyBuffNotify Create()
		{
			return new MotorFightAddEnemyBuffNotify();
		}

		// Token: 0x17002E4E RID: 11854
		// (get) Token: 0x0600E470 RID: 58480 RVA: 0x00216898 File Offset: 0x00214A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E4F RID: 11855
		// (get) Token: 0x0600E471 RID: 58481 RVA: 0x0021689B File Offset: 0x00214A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightAddEnemyBuffNotify.Descriptor;
			}
		}

		// Token: 0x0600E472 RID: 58482 RVA: 0x002168A2 File Offset: 0x00214AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightAddEnemyBuffNotify()
		{
		}

		// Token: 0x0600E473 RID: 58483 RVA: 0x002168B5 File Offset: 0x00214AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightAddEnemyBuffNotify(MotorFightAddEnemyBuffNotify other) : this()
		{
			this.enemyBuffs_ = other.enemyBuffs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E474 RID: 58484 RVA: 0x002168DF File Offset: 0x00214ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightAddEnemyBuffNotify Clone()
		{
			return new MotorFightAddEnemyBuffNotify(this);
		}

		// Token: 0x17002E50 RID: 11856
		// (get) Token: 0x0600E475 RID: 58485 RVA: 0x002168E7 File Offset: 0x00214AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightRoundBuffPb> EnemyBuffs
		{
			get
			{
				return this.enemyBuffs_;
			}
		}

		// Token: 0x0600E476 RID: 58486 RVA: 0x002168EF File Offset: 0x00214AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightAddEnemyBuffNotify);
		}

		// Token: 0x0600E477 RID: 58487 RVA: 0x002168FD File Offset: 0x00214AFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightAddEnemyBuffNotify other)
		{
			return other != null && (other == this || (this.enemyBuffs_.Equals(other.enemyBuffs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E478 RID: 58488 RVA: 0x00216930 File Offset: 0x00214B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.enemyBuffs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E479 RID: 58489 RVA: 0x00216964 File Offset: 0x00214B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E47A RID: 58490 RVA: 0x00216971 File Offset: 0x00214B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E47B RID: 58491 RVA: 0x0021697A File Offset: 0x00214B7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.enemyBuffs_.WriteTo(ref output, MotorFightAddEnemyBuffNotify._repeated_enemyBuffs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E47C RID: 58492 RVA: 0x002169A4 File Offset: 0x00214BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.enemyBuffs_.CalculateSize(MotorFightAddEnemyBuffNotify._repeated_enemyBuffs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E47D RID: 58493 RVA: 0x002169DD File Offset: 0x00214BDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightAddEnemyBuffNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.enemyBuffs_.Add(other.enemyBuffs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E47E RID: 58494 RVA: 0x00216A0B File Offset: 0x00214C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E47F RID: 58495 RVA: 0x00216A14 File Offset: 0x00214C14
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.enemyBuffs_.AddEntriesFrom(ref input, MotorFightAddEnemyBuffNotify._repeated_enemyBuffs_codec);
				}
			}
		}

		// Token: 0x04005D78 RID: 23928
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D79 RID: 23929
		public const int EnemyBuffsFieldNumber = 9;

		// Token: 0x04005D7A RID: 23930
		private static readonly FieldCodec<MotorFightRoundBuffPb> _repeated_enemyBuffs_codec = FieldCodec.ForMessage<MotorFightRoundBuffPb>(74U, MotorFightRoundBuffPb.Parser);

		// Token: 0x04005D7B RID: 23931
		private readonly RepeatedField<MotorFightRoundBuffPb> enemyBuffs_ = new RepeatedField<MotorFightRoundBuffPb>();
	}
}
