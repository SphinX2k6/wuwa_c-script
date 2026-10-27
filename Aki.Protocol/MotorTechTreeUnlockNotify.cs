using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AB1 RID: 2737
	[NetMessage(EMessageId.MotorTechTreeUnlockNotify)]
	public sealed class MotorTechTreeUnlockNotify : IMessage<MotorTechTreeUnlockNotify>, IMessage, IEquatable<MotorTechTreeUnlockNotify>, IDeepCloneable<MotorTechTreeUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600EE35 RID: 60981 RVA: 0x0022C3D8 File Offset: 0x0022A5D8
		[NullableContext(1)]
		public static MotorTechTreeUnlockNotify Create()
		{
			return new MotorTechTreeUnlockNotify();
		}

		// Token: 0x17003067 RID: 12391
		// (get) Token: 0x0600EE36 RID: 60982 RVA: 0x0022C3DF File Offset: 0x0022A5DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003068 RID: 12392
		// (get) Token: 0x0600EE37 RID: 60983 RVA: 0x0022C3E2 File Offset: 0x0022A5E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTechTreeUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600EE38 RID: 60984 RVA: 0x0022C3E9 File Offset: 0x0022A5E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechTreeUnlockNotify()
		{
		}

		// Token: 0x0600EE39 RID: 60985 RVA: 0x0022C3F1 File Offset: 0x0022A5F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechTreeUnlockNotify(MotorTechTreeUnlockNotify other) : this()
		{
			this.treeId_ = other.treeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EE3A RID: 60986 RVA: 0x0022C416 File Offset: 0x0022A616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechTreeUnlockNotify Clone()
		{
			return new MotorTechTreeUnlockNotify(this);
		}

		// Token: 0x17003069 RID: 12393
		// (get) Token: 0x0600EE3B RID: 60987 RVA: 0x0022C41E File Offset: 0x0022A61E
		// (set) Token: 0x0600EE3C RID: 60988 RVA: 0x0022C426 File Offset: 0x0022A626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeId
		{
			get
			{
				return this.treeId_;
			}
			set
			{
				this.treeId_ = value;
			}
		}

		// Token: 0x0600EE3D RID: 60989 RVA: 0x0022C42F File Offset: 0x0022A62F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTechTreeUnlockNotify);
		}

		// Token: 0x0600EE3E RID: 60990 RVA: 0x0022C43D File Offset: 0x0022A63D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTechTreeUnlockNotify other)
		{
			return other != null && (other == this || (this.TreeId == other.TreeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EE3F RID: 60991 RVA: 0x0022C46C File Offset: 0x0022A66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeId != 0)
			{
				num ^= this.TreeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EE40 RID: 60992 RVA: 0x0022C4AB File Offset: 0x0022A6AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EE41 RID: 60993 RVA: 0x0022C4B8 File Offset: 0x0022A6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EE42 RID: 60994 RVA: 0x0022C4C1 File Offset: 0x0022A6C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TreeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EE43 RID: 60995 RVA: 0x0022C4F4 File Offset: 0x0022A6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EE44 RID: 60996 RVA: 0x0022C532 File Offset: 0x0022A732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorTechTreeUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeId != 0)
			{
				this.TreeId = other.TreeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EE45 RID: 60997 RVA: 0x0022C563 File Offset: 0x0022A763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EE46 RID: 60998 RVA: 0x0022C56C File Offset: 0x0022A76C
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TreeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006064 RID: 24676
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006065 RID: 24677
		public const int TreeIdFieldNumber = 7;

		// Token: 0x04006066 RID: 24678
		private int treeId_;
	}
}
