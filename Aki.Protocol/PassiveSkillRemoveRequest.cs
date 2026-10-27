using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BD5 RID: 3029
	[NetMessage(EMessageId.PassiveSkillRemoveRequest)]
	public sealed class PassiveSkillRemoveRequest : IMessage<PassiveSkillRemoveRequest>, IMessage, IEquatable<PassiveSkillRemoveRequest>, IDeepCloneable<PassiveSkillRemoveRequest>, IBufferMessage
	{
		// Token: 0x06010673 RID: 67187 RVA: 0x002643A0 File Offset: 0x002625A0
		[NullableContext(1)]
		public static PassiveSkillRemoveRequest Create()
		{
			return new PassiveSkillRemoveRequest();
		}

		// Token: 0x170035CA RID: 13770
		// (get) Token: 0x06010674 RID: 67188 RVA: 0x002643A7 File Offset: 0x002625A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035CB RID: 13771
		// (get) Token: 0x06010675 RID: 67189 RVA: 0x002643AA File Offset: 0x002625AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillRemoveRequest.Descriptor;
			}
		}

		// Token: 0x06010676 RID: 67190 RVA: 0x002643B1 File Offset: 0x002625B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemoveRequest()
		{
		}

		// Token: 0x06010677 RID: 67191 RVA: 0x002643B9 File Offset: 0x002625B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemoveRequest(PassiveSkillRemoveRequest other) : this()
		{
			this.passiveSkillId_ = other.passiveSkillId_;
			this.targetEntityId_ = other.targetEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010678 RID: 67192 RVA: 0x002643EA File Offset: 0x002625EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemoveRequest Clone()
		{
			return new PassiveSkillRemoveRequest(this);
		}

		// Token: 0x170035CC RID: 13772
		// (get) Token: 0x06010679 RID: 67193 RVA: 0x002643F2 File Offset: 0x002625F2
		// (set) Token: 0x0601067A RID: 67194 RVA: 0x002643FA File Offset: 0x002625FA
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

		// Token: 0x170035CD RID: 13773
		// (get) Token: 0x0601067B RID: 67195 RVA: 0x00264403 File Offset: 0x00262603
		// (set) Token: 0x0601067C RID: 67196 RVA: 0x0026440B File Offset: 0x0026260B
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

		// Token: 0x0601067D RID: 67197 RVA: 0x00264414 File Offset: 0x00262614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillRemoveRequest);
		}

		// Token: 0x0601067E RID: 67198 RVA: 0x00264422 File Offset: 0x00262622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillRemoveRequest other)
		{
			return other != null && (other == this || (this.PassiveSkillId == other.PassiveSkillId && this.TargetEntityId == other.TargetEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601067F RID: 67199 RVA: 0x00264460 File Offset: 0x00262660
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

		// Token: 0x06010680 RID: 67200 RVA: 0x002644B8 File Offset: 0x002626B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010681 RID: 67201 RVA: 0x002644C5 File Offset: 0x002626C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010682 RID: 67202 RVA: 0x002644D0 File Offset: 0x002626D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PassiveSkillId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.PassiveSkillId);
			}
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010683 RID: 67203 RVA: 0x0026452C File Offset: 0x0026272C
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

		// Token: 0x06010684 RID: 67204 RVA: 0x00264584 File Offset: 0x00262784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PassiveSkillRemoveRequest other)
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

		// Token: 0x06010685 RID: 67205 RVA: 0x002645D4 File Offset: 0x002627D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010686 RID: 67206 RVA: 0x002645E0 File Offset: 0x002627E0
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
					if (num != 88U)
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

		// Token: 0x04006810 RID: 26640
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006811 RID: 26641
		public const int PassiveSkillIdFieldNumber = 2;

		// Token: 0x04006812 RID: 26642
		private long passiveSkillId_;

		// Token: 0x04006813 RID: 26643
		public const int TargetEntityIdFieldNumber = 11;

		// Token: 0x04006814 RID: 26644
		private long targetEntityId_;
	}
}
