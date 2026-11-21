using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BBC RID: 3004
	[NetMessage(EMessageId.PassiveSkillAddPush)]
	public sealed class PassiveSkillAddPush : IMessage<PassiveSkillAddPush>, IMessage, IEquatable<PassiveSkillAddPush>, IDeepCloneable<PassiveSkillAddPush>, IBufferMessage
	{
		// Token: 0x060104BD RID: 66749 RVA: 0x00260F0C File Offset: 0x0025F10C
		[NullableContext(1)]
		public static PassiveSkillAddPush Create()
		{
			return new PassiveSkillAddPush();
		}

		// Token: 0x1700356E RID: 13678
		// (get) Token: 0x060104BE RID: 66750 RVA: 0x00260F13 File Offset: 0x0025F113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700356F RID: 13679
		// (get) Token: 0x060104BF RID: 66751 RVA: 0x00260F16 File Offset: 0x0025F116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillAddPush.Descriptor;
			}
		}

		// Token: 0x060104C0 RID: 66752 RVA: 0x00260F1D File Offset: 0x0025F11D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddPush()
		{
		}

		// Token: 0x060104C1 RID: 66753 RVA: 0x00260F25 File Offset: 0x0025F125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddPush(PassiveSkillAddPush other) : this()
		{
			this.passiveSkillId_ = other.passiveSkillId_;
			this.targetEntityId_ = other.targetEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060104C2 RID: 66754 RVA: 0x00260F56 File Offset: 0x0025F156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddPush Clone()
		{
			return new PassiveSkillAddPush(this);
		}

		// Token: 0x17003570 RID: 13680
		// (get) Token: 0x060104C3 RID: 66755 RVA: 0x00260F5E File Offset: 0x0025F15E
		// (set) Token: 0x060104C4 RID: 66756 RVA: 0x00260F66 File Offset: 0x0025F166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PassiveSkillId
		{
			get
			{
				return this.passiveSkillId_;
			}
			set
			{
				this.passiveSkillId_ = value;
			}
		}

		// Token: 0x17003571 RID: 13681
		// (get) Token: 0x060104C5 RID: 66757 RVA: 0x00260F6F File Offset: 0x0025F16F
		// (set) Token: 0x060104C6 RID: 66758 RVA: 0x00260F77 File Offset: 0x0025F177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetEntityId
		{
			get
			{
				return this.targetEntityId_;
			}
			set
			{
				this.targetEntityId_ = value;
			}
		}

		// Token: 0x060104C7 RID: 66759 RVA: 0x00260F80 File Offset: 0x0025F180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillAddPush);
		}

		// Token: 0x060104C8 RID: 66760 RVA: 0x00260F8E File Offset: 0x0025F18E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillAddPush other)
		{
			return other != null && (other == this || (this.PassiveSkillId == other.PassiveSkillId && this.TargetEntityId == other.TargetEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060104C9 RID: 66761 RVA: 0x00260FCC File Offset: 0x0025F1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PassiveSkillId != 0L)
			{
				num ^= this.PassiveSkillId.GetHashCode();
			}
			if (this.TargetEntityId != 0L)
			{
				num ^= this.TargetEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060104CA RID: 66762 RVA: 0x00261024 File Offset: 0x0025F224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060104CB RID: 66763 RVA: 0x00261031 File Offset: 0x0025F231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060104CC RID: 66764 RVA: 0x0026103C File Offset: 0x0025F23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this.PassiveSkillId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.PassiveSkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060104CD RID: 66765 RVA: 0x00261098 File Offset: 0x0025F298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PassiveSkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PassiveSkillId);
			}
			if (this.TargetEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060104CE RID: 66766 RVA: 0x002610F0 File Offset: 0x0025F2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PassiveSkillAddPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PassiveSkillId != 0L)
			{
				this.PassiveSkillId = other.PassiveSkillId;
			}
			if (other.TargetEntityId != 0L)
			{
				this.TargetEntityId = other.TargetEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060104CF RID: 66767 RVA: 0x00261140 File Offset: 0x0025F340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060104D0 RID: 66768 RVA: 0x0026114C File Offset: 0x0025F34C
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
				if (num != 64U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PassiveSkillId = input.ReadInt64();
					}
				}
				else
				{
					this.TargetEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040067F4 RID: 26612
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067F5 RID: 26613
		public const int PassiveSkillIdFieldNumber = 13;

		// Token: 0x040067F6 RID: 26614
		private long passiveSkillId_;

		// Token: 0x040067F7 RID: 26615
		public const int TargetEntityIdFieldNumber = 8;

		// Token: 0x040067F8 RID: 26616
		private long targetEntityId_;
	}
}
