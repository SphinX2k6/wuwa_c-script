using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BC5 RID: 3013
	[NetMessage(EMessageId.PassiveSkillRemoveRequest)]
	public sealed class PassiveSkillRemoveRequest : IMessage<PassiveSkillRemoveRequest>, IMessage, IEquatable<PassiveSkillRemoveRequest>, IDeepCloneable<PassiveSkillRemoveRequest>, IBufferMessage
	{
		// Token: 0x0601056F RID: 66927 RVA: 0x002624E4 File Offset: 0x002606E4
		[NullableContext(1)]
		public static PassiveSkillRemoveRequest Create()
		{
			return new PassiveSkillRemoveRequest();
		}

		// Token: 0x17003591 RID: 13713
		// (get) Token: 0x06010570 RID: 66928 RVA: 0x002624EB File Offset: 0x002606EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003592 RID: 13714
		// (get) Token: 0x06010571 RID: 66929 RVA: 0x002624EE File Offset: 0x002606EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillRemoveRequest.Descriptor;
			}
		}

		// Token: 0x06010572 RID: 66930 RVA: 0x002624F5 File Offset: 0x002606F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemoveRequest()
		{
		}

		// Token: 0x06010573 RID: 66931 RVA: 0x002624FD File Offset: 0x002606FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemoveRequest(PassiveSkillRemoveRequest other) : this()
		{
			this.passiveSkillId_ = other.passiveSkillId_;
			this.targetEntityId_ = other.targetEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010574 RID: 66932 RVA: 0x0026252E File Offset: 0x0026072E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemoveRequest Clone()
		{
			return new PassiveSkillRemoveRequest(this);
		}

		// Token: 0x17003593 RID: 13715
		// (get) Token: 0x06010575 RID: 66933 RVA: 0x00262536 File Offset: 0x00260736
		// (set) Token: 0x06010576 RID: 66934 RVA: 0x0026253E File Offset: 0x0026073E
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

		// Token: 0x17003594 RID: 13716
		// (get) Token: 0x06010577 RID: 66935 RVA: 0x00262547 File Offset: 0x00260747
		// (set) Token: 0x06010578 RID: 66936 RVA: 0x0026254F File Offset: 0x0026074F
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

		// Token: 0x06010579 RID: 66937 RVA: 0x00262558 File Offset: 0x00260758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillRemoveRequest);
		}

		// Token: 0x0601057A RID: 66938 RVA: 0x00262566 File Offset: 0x00260766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillRemoveRequest other)
		{
			return other != null && (other == this || (this.PassiveSkillId == other.PassiveSkillId && this.TargetEntityId == other.TargetEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601057B RID: 66939 RVA: 0x002625A4 File Offset: 0x002607A4
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

		// Token: 0x0601057C RID: 66940 RVA: 0x002625FC File Offset: 0x002607FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601057D RID: 66941 RVA: 0x00262609 File Offset: 0x00260809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601057E RID: 66942 RVA: 0x00262614 File Offset: 0x00260814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PassiveSkillId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.PassiveSkillId);
			}
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601057F RID: 66943 RVA: 0x00262670 File Offset: 0x00260870
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

		// Token: 0x06010580 RID: 66944 RVA: 0x002626C8 File Offset: 0x002608C8
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

		// Token: 0x06010581 RID: 66945 RVA: 0x00262718 File Offset: 0x00260918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010582 RID: 66946 RVA: 0x00262724 File Offset: 0x00260924
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
				if (num != 40U)
				{
					if (num != 64U)
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

		// Token: 0x04006820 RID: 26656
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006821 RID: 26657
		public const int PassiveSkillIdFieldNumber = 5;

		// Token: 0x04006822 RID: 26658
		private long passiveSkillId_;

		// Token: 0x04006823 RID: 26659
		public const int TargetEntityIdFieldNumber = 8;

		// Token: 0x04006824 RID: 26660
		private long targetEntityId_;
	}
}
