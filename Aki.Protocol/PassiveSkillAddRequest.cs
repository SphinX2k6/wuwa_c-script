using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BCD RID: 3021
	[NetMessage(EMessageId.PassiveSkillAddRequest)]
	public sealed class PassiveSkillAddRequest : IMessage<PassiveSkillAddRequest>, IMessage, IEquatable<PassiveSkillAddRequest>, IDeepCloneable<PassiveSkillAddRequest>, IBufferMessage
	{
		// Token: 0x060105D5 RID: 67029 RVA: 0x0026305C File Offset: 0x0026125C
		[NullableContext(1)]
		public static PassiveSkillAddRequest Create()
		{
			return new PassiveSkillAddRequest();
		}

		// Token: 0x170035AB RID: 13739
		// (get) Token: 0x060105D6 RID: 67030 RVA: 0x00263063 File Offset: 0x00261263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035AC RID: 13740
		// (get) Token: 0x060105D7 RID: 67031 RVA: 0x00263066 File Offset: 0x00261266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillAddRequest.Descriptor;
			}
		}

		// Token: 0x060105D8 RID: 67032 RVA: 0x0026306D File Offset: 0x0026126D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddRequest()
		{
		}

		// Token: 0x060105D9 RID: 67033 RVA: 0x00263075 File Offset: 0x00261275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddRequest(PassiveSkillAddRequest other) : this()
		{
			this.passiveSkillId_ = other.passiveSkillId_;
			this.targetEntityId_ = other.targetEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060105DA RID: 67034 RVA: 0x002630A6 File Offset: 0x002612A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddRequest Clone()
		{
			return new PassiveSkillAddRequest(this);
		}

		// Token: 0x170035AD RID: 13741
		// (get) Token: 0x060105DB RID: 67035 RVA: 0x002630AE File Offset: 0x002612AE
		// (set) Token: 0x060105DC RID: 67036 RVA: 0x002630B6 File Offset: 0x002612B6
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

		// Token: 0x170035AE RID: 13742
		// (get) Token: 0x060105DD RID: 67037 RVA: 0x002630BF File Offset: 0x002612BF
		// (set) Token: 0x060105DE RID: 67038 RVA: 0x002630C7 File Offset: 0x002612C7
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

		// Token: 0x060105DF RID: 67039 RVA: 0x002630D0 File Offset: 0x002612D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillAddRequest);
		}

		// Token: 0x060105E0 RID: 67040 RVA: 0x002630DE File Offset: 0x002612DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillAddRequest other)
		{
			return other != null && (other == this || (this.PassiveSkillId == other.PassiveSkillId && this.TargetEntityId == other.TargetEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060105E1 RID: 67041 RVA: 0x0026311C File Offset: 0x0026131C
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

		// Token: 0x060105E2 RID: 67042 RVA: 0x00263174 File Offset: 0x00261374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060105E3 RID: 67043 RVA: 0x00263181 File Offset: 0x00261381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060105E4 RID: 67044 RVA: 0x0026318C File Offset: 0x0026138C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this.PassiveSkillId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.PassiveSkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060105E5 RID: 67045 RVA: 0x002631E8 File Offset: 0x002613E8
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

		// Token: 0x060105E6 RID: 67046 RVA: 0x00263240 File Offset: 0x00261440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PassiveSkillAddRequest other)
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

		// Token: 0x060105E7 RID: 67047 RVA: 0x00263290 File Offset: 0x00261490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060105E8 RID: 67048 RVA: 0x0026329C File Offset: 0x0026149C
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
				if (num != 16U)
				{
					if (num != 96U)
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

		// Token: 0x040067E9 RID: 26601
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067EA RID: 26602
		public const int PassiveSkillIdFieldNumber = 12;

		// Token: 0x040067EB RID: 26603
		private long passiveSkillId_;

		// Token: 0x040067EC RID: 26604
		public const int TargetEntityIdFieldNumber = 2;

		// Token: 0x040067ED RID: 26605
		private long targetEntityId_;
	}
}
