using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BD4 RID: 3028
	[NetMessage(EMessageId.PassiveSkillRemovePush)]
	public sealed class PassiveSkillRemovePush : IMessage<PassiveSkillRemovePush>, IMessage, IEquatable<PassiveSkillRemovePush>, IDeepCloneable<PassiveSkillRemovePush>, IBufferMessage
	{
		// Token: 0x0601065F RID: 67167 RVA: 0x00264108 File Offset: 0x00262308
		[NullableContext(1)]
		public static PassiveSkillRemovePush Create()
		{
			return new PassiveSkillRemovePush();
		}

		// Token: 0x170035C6 RID: 13766
		// (get) Token: 0x06010660 RID: 67168 RVA: 0x0026410F File Offset: 0x0026230F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035C7 RID: 13767
		// (get) Token: 0x06010661 RID: 67169 RVA: 0x00264112 File Offset: 0x00262312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillRemovePush.Descriptor;
			}
		}

		// Token: 0x06010662 RID: 67170 RVA: 0x00264119 File Offset: 0x00262319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemovePush()
		{
		}

		// Token: 0x06010663 RID: 67171 RVA: 0x00264121 File Offset: 0x00262321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemovePush(PassiveSkillRemovePush other) : this()
		{
			this.passiveSkillId_ = other.passiveSkillId_;
			this.targetEntityId_ = other.targetEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010664 RID: 67172 RVA: 0x00264152 File Offset: 0x00262352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemovePush Clone()
		{
			return new PassiveSkillRemovePush(this);
		}

		// Token: 0x170035C8 RID: 13768
		// (get) Token: 0x06010665 RID: 67173 RVA: 0x0026415A File Offset: 0x0026235A
		// (set) Token: 0x06010666 RID: 67174 RVA: 0x00264162 File Offset: 0x00262362
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

		// Token: 0x170035C9 RID: 13769
		// (get) Token: 0x06010667 RID: 67175 RVA: 0x0026416B File Offset: 0x0026236B
		// (set) Token: 0x06010668 RID: 67176 RVA: 0x00264173 File Offset: 0x00262373
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

		// Token: 0x06010669 RID: 67177 RVA: 0x0026417C File Offset: 0x0026237C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillRemovePush);
		}

		// Token: 0x0601066A RID: 67178 RVA: 0x0026418A File Offset: 0x0026238A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillRemovePush other)
		{
			return other != null && (other == this || (this.PassiveSkillId == other.PassiveSkillId && this.TargetEntityId == other.TargetEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601066B RID: 67179 RVA: 0x002641C8 File Offset: 0x002623C8
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

		// Token: 0x0601066C RID: 67180 RVA: 0x00264220 File Offset: 0x00262420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601066D RID: 67181 RVA: 0x0026422D File Offset: 0x0026242D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601066E RID: 67182 RVA: 0x00264238 File Offset: 0x00262438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(88);
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

		// Token: 0x0601066F RID: 67183 RVA: 0x00264294 File Offset: 0x00262494
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

		// Token: 0x06010670 RID: 67184 RVA: 0x002642EC File Offset: 0x002624EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PassiveSkillRemovePush other)
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

		// Token: 0x06010671 RID: 67185 RVA: 0x0026433C File Offset: 0x0026253C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010672 RID: 67186 RVA: 0x00264348 File Offset: 0x00262548
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
				if (num != 88U)
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

		// Token: 0x0400680B RID: 26635
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400680C RID: 26636
		public const int PassiveSkillIdFieldNumber = 12;

		// Token: 0x0400680D RID: 26637
		private long passiveSkillId_;

		// Token: 0x0400680E RID: 26638
		public const int TargetEntityIdFieldNumber = 11;

		// Token: 0x0400680F RID: 26639
		private long targetEntityId_;
	}
}
