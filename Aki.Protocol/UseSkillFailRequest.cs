using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200152C RID: 5420
	[NetMessage(EMessageId.UseSkillFailRequest)]
	public sealed class UseSkillFailRequest : IMessage<UseSkillFailRequest>, IMessage, IEquatable<UseSkillFailRequest>, IDeepCloneable<UseSkillFailRequest>, IBufferMessage
	{
		// Token: 0x0601CB5E RID: 117598 RVA: 0x0042905D File Offset: 0x0042725D
		[NullableContext(1)]
		public static UseSkillFailRequest Create()
		{
			return new UseSkillFailRequest();
		}

		// Token: 0x1700611D RID: 24861
		// (get) Token: 0x0601CB5F RID: 117599 RVA: 0x00429064 File Offset: 0x00427264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700611E RID: 24862
		// (get) Token: 0x0601CB60 RID: 117600 RVA: 0x00429067 File Offset: 0x00427267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseSkillFailRequest.Descriptor;
			}
		}

		// Token: 0x0601CB61 RID: 117601 RVA: 0x0042906E File Offset: 0x0042726E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillFailRequest()
		{
		}

		// Token: 0x0601CB62 RID: 117602 RVA: 0x00429076 File Offset: 0x00427276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillFailRequest(UseSkillFailRequest other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CB63 RID: 117603 RVA: 0x0042909B File Offset: 0x0042729B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillFailRequest Clone()
		{
			return new UseSkillFailRequest(this);
		}

		// Token: 0x1700611F RID: 24863
		// (get) Token: 0x0601CB64 RID: 117604 RVA: 0x004290A3 File Offset: 0x004272A3
		// (set) Token: 0x0601CB65 RID: 117605 RVA: 0x004290AB File Offset: 0x004272AB
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

		// Token: 0x0601CB66 RID: 117606 RVA: 0x004290B4 File Offset: 0x004272B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseSkillFailRequest);
		}

		// Token: 0x0601CB67 RID: 117607 RVA: 0x004290C2 File Offset: 0x004272C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseSkillFailRequest other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CB68 RID: 117608 RVA: 0x004290F0 File Offset: 0x004272F0
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

		// Token: 0x0601CB69 RID: 117609 RVA: 0x0042912F File Offset: 0x0042732F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CB6A RID: 117610 RVA: 0x0042913C File Offset: 0x0042733C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CB6B RID: 117611 RVA: 0x00429145 File Offset: 0x00427345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CB6C RID: 117612 RVA: 0x00429178 File Offset: 0x00427378
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

		// Token: 0x0601CB6D RID: 117613 RVA: 0x004291B6 File Offset: 0x004273B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UseSkillFailRequest other)
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

		// Token: 0x0601CB6E RID: 117614 RVA: 0x004291E7 File Offset: 0x004273E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CB6F RID: 117615 RVA: 0x004291F0 File Offset: 0x004273F0
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkillId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A559 RID: 42329
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A55A RID: 42330
		public const int SkillIdFieldNumber = 6;

		// Token: 0x0400A55B RID: 42331
		private long skillId_;
	}
}
