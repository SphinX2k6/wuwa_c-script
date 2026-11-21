using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200152D RID: 5421
	[NetMessage(EMessageId.UseSkillFailResponse)]
	public sealed class UseSkillFailResponse : IMessage<UseSkillFailResponse>, IMessage, IEquatable<UseSkillFailResponse>, IDeepCloneable<UseSkillFailResponse>, IBufferMessage
	{
		// Token: 0x0601CB70 RID: 117616 RVA: 0x00429235 File Offset: 0x00427435
		[NullableContext(1)]
		public static UseSkillFailResponse Create()
		{
			return new UseSkillFailResponse();
		}

		// Token: 0x17006120 RID: 24864
		// (get) Token: 0x0601CB71 RID: 117617 RVA: 0x0042923C File Offset: 0x0042743C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006121 RID: 24865
		// (get) Token: 0x0601CB72 RID: 117618 RVA: 0x0042923F File Offset: 0x0042743F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseSkillFailResponse.Descriptor;
			}
		}

		// Token: 0x0601CB73 RID: 117619 RVA: 0x00429246 File Offset: 0x00427446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillFailResponse()
		{
		}

		// Token: 0x0601CB74 RID: 117620 RVA: 0x00429250 File Offset: 0x00427450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillFailResponse(UseSkillFailResponse other) : this()
		{
			this.skillId_ = other.skillId_;
			this.error_ = ((other.error_ != null) ? other.error_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CB75 RID: 117621 RVA: 0x0042929C File Offset: 0x0042749C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillFailResponse Clone()
		{
			return new UseSkillFailResponse(this);
		}

		// Token: 0x17006122 RID: 24866
		// (get) Token: 0x0601CB76 RID: 117622 RVA: 0x004292A4 File Offset: 0x004274A4
		// (set) Token: 0x0601CB77 RID: 117623 RVA: 0x004292AC File Offset: 0x004274AC
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

		// Token: 0x17006123 RID: 24867
		// (get) Token: 0x0601CB78 RID: 117624 RVA: 0x004292B5 File Offset: 0x004274B5
		// (set) Token: 0x0601CB79 RID: 117625 RVA: 0x004292BD File Offset: 0x004274BD
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

		// Token: 0x0601CB7A RID: 117626 RVA: 0x004292C6 File Offset: 0x004274C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseSkillFailResponse);
		}

		// Token: 0x0601CB7B RID: 117627 RVA: 0x004292D4 File Offset: 0x004274D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseSkillFailResponse other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this.Error, other.Error) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CB7C RID: 117628 RVA: 0x00429324 File Offset: 0x00427524
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

		// Token: 0x0601CB7D RID: 117629 RVA: 0x00429379 File Offset: 0x00427579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CB7E RID: 117630 RVA: 0x00429386 File Offset: 0x00427586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CB7F RID: 117631 RVA: 0x00429390 File Offset: 0x00427590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.error_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Error);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CB80 RID: 117632 RVA: 0x004293EC File Offset: 0x004275EC
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

		// Token: 0x0601CB81 RID: 117633 RVA: 0x00429444 File Offset: 0x00427644
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

		// Token: 0x0601CB82 RID: 117634 RVA: 0x004294AC File Offset: 0x004276AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CB83 RID: 117635 RVA: 0x004294B8 File Offset: 0x004276B8
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
				if (num != 26U)
				{
					if (num != 88U)
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

		// Token: 0x0400A55C RID: 42332
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A55D RID: 42333
		public const int SkillIdFieldNumber = 11;

		// Token: 0x0400A55E RID: 42334
		private long skillId_;

		// Token: 0x0400A55F RID: 42335
		public const int ErrorFieldNumber = 3;

		// Token: 0x0400A560 RID: 42336
		private DErrorResult error_;
	}
}
