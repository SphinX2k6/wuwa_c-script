using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014B6 RID: 5302
	[NetMessage(EMessageId.UseSkillFailRequest)]
	public sealed class UseSkillFailRequest : IMessage<UseSkillFailRequest>, IMessage, IEquatable<UseSkillFailRequest>, IDeepCloneable<UseSkillFailRequest>, IBufferMessage
	{
		// Token: 0x0601C097 RID: 114839 RVA: 0x0040D5A5 File Offset: 0x0040B7A5
		[NullableContext(1)]
		public static UseSkillFailRequest Create()
		{
			return new UseSkillFailRequest();
		}

		// Token: 0x17005E7C RID: 24188
		// (get) Token: 0x0601C098 RID: 114840 RVA: 0x0040D5AC File Offset: 0x0040B7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E7D RID: 24189
		// (get) Token: 0x0601C099 RID: 114841 RVA: 0x0040D5AF File Offset: 0x0040B7AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseSkillFailRequest.Descriptor;
			}
		}

		// Token: 0x0601C09A RID: 114842 RVA: 0x0040D5B6 File Offset: 0x0040B7B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillFailRequest()
		{
		}

		// Token: 0x0601C09B RID: 114843 RVA: 0x0040D5BE File Offset: 0x0040B7BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillFailRequest(UseSkillFailRequest other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C09C RID: 114844 RVA: 0x0040D5E3 File Offset: 0x0040B7E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillFailRequest Clone()
		{
			return new UseSkillFailRequest(this);
		}

		// Token: 0x17005E7E RID: 24190
		// (get) Token: 0x0601C09D RID: 114845 RVA: 0x0040D5EB File Offset: 0x0040B7EB
		// (set) Token: 0x0601C09E RID: 114846 RVA: 0x0040D5F3 File Offset: 0x0040B7F3
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

		// Token: 0x0601C09F RID: 114847 RVA: 0x0040D5FC File Offset: 0x0040B7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseSkillFailRequest);
		}

		// Token: 0x0601C0A0 RID: 114848 RVA: 0x0040D60A File Offset: 0x0040B80A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseSkillFailRequest other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C0A1 RID: 114849 RVA: 0x0040D638 File Offset: 0x0040B838
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

		// Token: 0x0601C0A2 RID: 114850 RVA: 0x0040D677 File Offset: 0x0040B877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C0A3 RID: 114851 RVA: 0x0040D684 File Offset: 0x0040B884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C0A4 RID: 114852 RVA: 0x0040D68D File Offset: 0x0040B88D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C0A5 RID: 114853 RVA: 0x0040D6C0 File Offset: 0x0040B8C0
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

		// Token: 0x0601C0A6 RID: 114854 RVA: 0x0040D6FE File Offset: 0x0040B8FE
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

		// Token: 0x0601C0A7 RID: 114855 RVA: 0x0040D72F File Offset: 0x0040B92F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C0A8 RID: 114856 RVA: 0x0040D738 File Offset: 0x0040B938
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkillId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A100 RID: 41216
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A101 RID: 41217
		public const int SkillIdFieldNumber = 3;

		// Token: 0x0400A102 RID: 41218
		private long skillId_;
	}
}
