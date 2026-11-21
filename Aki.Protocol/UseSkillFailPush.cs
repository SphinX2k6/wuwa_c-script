using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200152B RID: 5419
	[NetMessage(EMessageId.UseSkillFailPush)]
	public sealed class UseSkillFailPush : IMessage<UseSkillFailPush>, IMessage, IEquatable<UseSkillFailPush>, IDeepCloneable<UseSkillFailPush>, IBufferMessage
	{
		// Token: 0x0601CB4C RID: 117580 RVA: 0x00428E84 File Offset: 0x00427084
		[NullableContext(1)]
		public static UseSkillFailPush Create()
		{
			return new UseSkillFailPush();
		}

		// Token: 0x1700611A RID: 24858
		// (get) Token: 0x0601CB4D RID: 117581 RVA: 0x00428E8B File Offset: 0x0042708B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700611B RID: 24859
		// (get) Token: 0x0601CB4E RID: 117582 RVA: 0x00428E8E File Offset: 0x0042708E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseSkillFailPush.Descriptor;
			}
		}

		// Token: 0x0601CB4F RID: 117583 RVA: 0x00428E95 File Offset: 0x00427095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillFailPush()
		{
		}

		// Token: 0x0601CB50 RID: 117584 RVA: 0x00428E9D File Offset: 0x0042709D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillFailPush(UseSkillFailPush other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CB51 RID: 117585 RVA: 0x00428EC2 File Offset: 0x004270C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillFailPush Clone()
		{
			return new UseSkillFailPush(this);
		}

		// Token: 0x1700611C RID: 24860
		// (get) Token: 0x0601CB52 RID: 117586 RVA: 0x00428ECA File Offset: 0x004270CA
		// (set) Token: 0x0601CB53 RID: 117587 RVA: 0x00428ED2 File Offset: 0x004270D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x0601CB54 RID: 117588 RVA: 0x00428EDB File Offset: 0x004270DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseSkillFailPush);
		}

		// Token: 0x0601CB55 RID: 117589 RVA: 0x00428EE9 File Offset: 0x004270E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseSkillFailPush other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CB56 RID: 117590 RVA: 0x00428F18 File Offset: 0x00427118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CB57 RID: 117591 RVA: 0x00428F57 File Offset: 0x00427157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CB58 RID: 117592 RVA: 0x00428F64 File Offset: 0x00427164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CB59 RID: 117593 RVA: 0x00428F6D File Offset: 0x0042716D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CB5A RID: 117594 RVA: 0x00428FA0 File Offset: 0x004271A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CB5B RID: 117595 RVA: 0x00428FDE File Offset: 0x004271DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UseSkillFailPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CB5C RID: 117596 RVA: 0x0042900F File Offset: 0x0042720F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CB5D RID: 117597 RVA: 0x00429018 File Offset: 0x00427218
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkillId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A556 RID: 42326
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A557 RID: 42327
		public const int SkillIdFieldNumber = 15;

		// Token: 0x0400A558 RID: 42328
		private long skillId_;
	}
}
