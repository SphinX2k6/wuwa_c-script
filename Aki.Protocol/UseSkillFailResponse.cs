using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014B7 RID: 5303
	[NetMessage(EMessageId.UseSkillFailResponse)]
	public sealed class UseSkillFailResponse : IMessage<UseSkillFailResponse>, IMessage, IEquatable<UseSkillFailResponse>, IDeepCloneable<UseSkillFailResponse>, IBufferMessage
	{
		// Token: 0x0601C0A9 RID: 114857 RVA: 0x0040D77D File Offset: 0x0040B97D
		[NullableContext(1)]
		public static UseSkillFailResponse Create()
		{
			return new UseSkillFailResponse();
		}

		// Token: 0x17005E7F RID: 24191
		// (get) Token: 0x0601C0AA RID: 114858 RVA: 0x0040D784 File Offset: 0x0040B984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E80 RID: 24192
		// (get) Token: 0x0601C0AB RID: 114859 RVA: 0x0040D787 File Offset: 0x0040B987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseSkillFailResponse.Descriptor;
			}
		}

		// Token: 0x0601C0AC RID: 114860 RVA: 0x0040D78E File Offset: 0x0040B98E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillFailResponse()
		{
		}

		// Token: 0x0601C0AD RID: 114861 RVA: 0x0040D798 File Offset: 0x0040B998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillFailResponse(UseSkillFailResponse other) : this()
		{
			this.skillId_ = other.skillId_;
			this.error_ = ((other.error_ != null) ? other.error_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C0AE RID: 114862 RVA: 0x0040D7E4 File Offset: 0x0040B9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillFailResponse Clone()
		{
			return new UseSkillFailResponse(this);
		}

		// Token: 0x17005E81 RID: 24193
		// (get) Token: 0x0601C0AF RID: 114863 RVA: 0x0040D7EC File Offset: 0x0040B9EC
		// (set) Token: 0x0601C0B0 RID: 114864 RVA: 0x0040D7F4 File Offset: 0x0040B9F4
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

		// Token: 0x17005E82 RID: 24194
		// (get) Token: 0x0601C0B1 RID: 114865 RVA: 0x0040D7FD File Offset: 0x0040B9FD
		// (set) Token: 0x0601C0B2 RID: 114866 RVA: 0x0040D805 File Offset: 0x0040BA05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DErrorResult Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x0601C0B3 RID: 114867 RVA: 0x0040D80E File Offset: 0x0040BA0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseSkillFailResponse);
		}

		// Token: 0x0601C0B4 RID: 114868 RVA: 0x0040D81C File Offset: 0x0040BA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseSkillFailResponse other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this.Error, other.Error) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C0B5 RID: 114869 RVA: 0x0040D86C File Offset: 0x0040BA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.error_ != null)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C0B6 RID: 114870 RVA: 0x0040D8C1 File Offset: 0x0040BAC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C0B7 RID: 114871 RVA: 0x0040D8CE File Offset: 0x0040BACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C0B8 RID: 114872 RVA: 0x0040D8D8 File Offset: 0x0040BAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.error_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Error);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C0B9 RID: 114873 RVA: 0x0040D934 File Offset: 0x0040BB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this.error_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C0BA RID: 114874 RVA: 0x0040D98C File Offset: 0x0040BB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UseSkillFailResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			if (other.error_ != null)
			{
				if (this.error_ == null)
				{
					this.Error = new DErrorResult();
				}
				this.Error.MergeFrom(other.Error);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C0BB RID: 114875 RVA: 0x0040D9F4 File Offset: 0x0040BBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C0BC RID: 114876 RVA: 0x0040DA00 File Offset: 0x0040BC00
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
				if (num != 50U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkillId = input.ReadInt64();
					}
				}
				else
				{
					if (this.error_ == null)
					{
						this.Error = new DErrorResult();
					}
					input.ReadMessage(this.Error);
				}
			}
		}

		// Token: 0x0400A103 RID: 41219
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A104 RID: 41220
		public const int SkillIdFieldNumber = 14;

		// Token: 0x0400A105 RID: 41221
		private long skillId_;

		// Token: 0x0400A106 RID: 41222
		public const int ErrorFieldNumber = 6;

		// Token: 0x0400A107 RID: 41223
		private DErrorResult error_;
	}
}
