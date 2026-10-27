using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BCC RID: 3020
	[NetMessage(EMessageId.PassiveSkillAddPush)]
	public sealed class PassiveSkillAddPush : IMessage<PassiveSkillAddPush>, IMessage, IEquatable<PassiveSkillAddPush>, IDeepCloneable<PassiveSkillAddPush>, IBufferMessage
	{
		// Token: 0x060105C1 RID: 67009 RVA: 0x00262DC3 File Offset: 0x00260FC3
		[NullableContext(1)]
		public static PassiveSkillAddPush Create()
		{
			return new PassiveSkillAddPush();
		}

		// Token: 0x170035A7 RID: 13735
		// (get) Token: 0x060105C2 RID: 67010 RVA: 0x00262DCA File Offset: 0x00260FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035A8 RID: 13736
		// (get) Token: 0x060105C3 RID: 67011 RVA: 0x00262DCD File Offset: 0x00260FCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillAddPush.Descriptor;
			}
		}

		// Token: 0x060105C4 RID: 67012 RVA: 0x00262DD4 File Offset: 0x00260FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddPush()
		{
		}

		// Token: 0x060105C5 RID: 67013 RVA: 0x00262DDC File Offset: 0x00260FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddPush(PassiveSkillAddPush other) : this()
		{
			this.passiveSkillId_ = other.passiveSkillId_;
			this.targetEntityId_ = other.targetEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060105C6 RID: 67014 RVA: 0x00262E0D File Offset: 0x0026100D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddPush Clone()
		{
			return new PassiveSkillAddPush(this);
		}

		// Token: 0x170035A9 RID: 13737
		// (get) Token: 0x060105C7 RID: 67015 RVA: 0x00262E15 File Offset: 0x00261015
		// (set) Token: 0x060105C8 RID: 67016 RVA: 0x00262E1D File Offset: 0x0026101D
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

		// Token: 0x170035AA RID: 13738
		// (get) Token: 0x060105C9 RID: 67017 RVA: 0x00262E26 File Offset: 0x00261026
		// (set) Token: 0x060105CA RID: 67018 RVA: 0x00262E2E File Offset: 0x0026102E
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

		// Token: 0x060105CB RID: 67019 RVA: 0x00262E37 File Offset: 0x00261037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillAddPush);
		}

		// Token: 0x060105CC RID: 67020 RVA: 0x00262E45 File Offset: 0x00261045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillAddPush other)
		{
			return other != null && (other == this || (this.PassiveSkillId == other.PassiveSkillId && this.TargetEntityId == other.TargetEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060105CD RID: 67021 RVA: 0x00262E84 File Offset: 0x00261084
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

		// Token: 0x060105CE RID: 67022 RVA: 0x00262EDC File Offset: 0x002610DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060105CF RID: 67023 RVA: 0x00262EE9 File Offset: 0x002610E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060105D0 RID: 67024 RVA: 0x00262EF4 File Offset: 0x002610F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PassiveSkillId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.PassiveSkillId);
			}
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060105D1 RID: 67025 RVA: 0x00262F50 File Offset: 0x00261150
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

		// Token: 0x060105D2 RID: 67026 RVA: 0x00262FA8 File Offset: 0x002611A8
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

		// Token: 0x060105D3 RID: 67027 RVA: 0x00262FF8 File Offset: 0x002611F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060105D4 RID: 67028 RVA: 0x00263004 File Offset: 0x00261204
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
				if (num != 24U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TargetEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.PassiveSkillId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040067E4 RID: 26596
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067E5 RID: 26597
		public const int PassiveSkillIdFieldNumber = 3;

		// Token: 0x040067E6 RID: 26598
		private long passiveSkillId_;

		// Token: 0x040067E7 RID: 26599
		public const int TargetEntityIdFieldNumber = 13;

		// Token: 0x040067E8 RID: 26600
		private long targetEntityId_;
	}
}
