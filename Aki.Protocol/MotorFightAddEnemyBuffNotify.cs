using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A27 RID: 2599
	[NetMessage(EMessageId.MotorFightAddEnemyBuffNotify)]
	public sealed class MotorFightAddEnemyBuffNotify : IMessage<MotorFightAddEnemyBuffNotify>, IMessage, IEquatable<MotorFightAddEnemyBuffNotify>, IDeepCloneable<MotorFightAddEnemyBuffNotify>, IBufferMessage
	{
		// Token: 0x0600E355 RID: 58197 RVA: 0x002146A1 File Offset: 0x002128A1
		[NullableContext(1)]
		public static MotorFightAddEnemyBuffNotify Create()
		{
			return new MotorFightAddEnemyBuffNotify();
		}

		// Token: 0x17002E10 RID: 11792
		// (get) Token: 0x0600E356 RID: 58198 RVA: 0x002146A8 File Offset: 0x002128A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E11 RID: 11793
		// (get) Token: 0x0600E357 RID: 58199 RVA: 0x002146AB File Offset: 0x002128AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightAddEnemyBuffNotify.Descriptor;
			}
		}

		// Token: 0x0600E358 RID: 58200 RVA: 0x002146B2 File Offset: 0x002128B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightAddEnemyBuffNotify()
		{
		}

		// Token: 0x0600E359 RID: 58201 RVA: 0x002146C5 File Offset: 0x002128C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightAddEnemyBuffNotify(MotorFightAddEnemyBuffNotify other) : this()
		{
			this.enemyBuffs_ = other.enemyBuffs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E35A RID: 58202 RVA: 0x002146EF File Offset: 0x002128EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightAddEnemyBuffNotify Clone()
		{
			return new MotorFightAddEnemyBuffNotify(this);
		}

		// Token: 0x17002E12 RID: 11794
		// (get) Token: 0x0600E35B RID: 58203 RVA: 0x002146F7 File Offset: 0x002128F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightRoundBuffPb> EnemyBuffs
		{
			get
			{
				return this.enemyBuffs_;
			}
		}

		// Token: 0x0600E35C RID: 58204 RVA: 0x002146FF File Offset: 0x002128FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightAddEnemyBuffNotify);
		}

		// Token: 0x0600E35D RID: 58205 RVA: 0x0021470D File Offset: 0x0021290D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightAddEnemyBuffNotify other)
		{
			return other != null && (other == this || (this.enemyBuffs_.Equals(other.enemyBuffs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E35E RID: 58206 RVA: 0x00214740 File Offset: 0x00212940
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

		// Token: 0x0600E35F RID: 58207 RVA: 0x00214774 File Offset: 0x00212974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E360 RID: 58208 RVA: 0x00214781 File Offset: 0x00212981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E361 RID: 58209 RVA: 0x0021478A File Offset: 0x0021298A
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

		// Token: 0x0600E362 RID: 58210 RVA: 0x002147B4 File Offset: 0x002129B4
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

		// Token: 0x0600E363 RID: 58211 RVA: 0x002147ED File Offset: 0x002129ED
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

		// Token: 0x0600E364 RID: 58212 RVA: 0x0021481B File Offset: 0x00212A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E365 RID: 58213 RVA: 0x00214824 File Offset: 0x00212A24
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.enemyBuffs_.AddEntriesFrom(ref input, MotorFightAddEnemyBuffNotify._repeated_enemyBuffs_codec);
				}
			}
		}

		// Token: 0x04005D81 RID: 23937
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D82 RID: 23938
		public const int EnemyBuffsFieldNumber = 11;

		// Token: 0x04005D83 RID: 23939
		private static readonly FieldCodec<MotorFightRoundBuffPb> _repeated_enemyBuffs_codec = FieldCodec.ForMessage<MotorFightRoundBuffPb>(90U, MotorFightRoundBuffPb.Parser);

		// Token: 0x04005D84 RID: 23940
		private readonly RepeatedField<MotorFightRoundBuffPb> enemyBuffs_ = new RepeatedField<MotorFightRoundBuffPb>();
	}
}
