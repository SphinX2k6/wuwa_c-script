using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004EF RID: 1263
	[NetMessage(EMessageId.ExploreSkillCustomResponse)]
	public sealed class ExploreSkillCustomResponse : IMessage<ExploreSkillCustomResponse>, IMessage, IEquatable<ExploreSkillCustomResponse>, IDeepCloneable<ExploreSkillCustomResponse>, IBufferMessage
	{
		// Token: 0x0600778B RID: 30603 RVA: 0x001236C9 File Offset: 0x001218C9
		[NullableContext(1)]
		public static ExploreSkillCustomResponse Create()
		{
			return new ExploreSkillCustomResponse();
		}

		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x0600778C RID: 30604 RVA: 0x001236D0 File Offset: 0x001218D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001722 RID: 5922
		// (get) Token: 0x0600778D RID: 30605 RVA: 0x001236D3 File Offset: 0x001218D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillCustomResponse.Descriptor;
			}
		}

		// Token: 0x0600778E RID: 30606 RVA: 0x001236DA File Offset: 0x001218DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillCustomResponse()
		{
		}

		// Token: 0x0600778F RID: 30607 RVA: 0x001236E2 File Offset: 0x001218E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillCustomResponse(ExploreSkillCustomResponse other) : this()
		{
			this.entityId_ = other.entityId_;
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007790 RID: 30608 RVA: 0x00123713 File Offset: 0x00121913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillCustomResponse Clone()
		{
			return new ExploreSkillCustomResponse(this);
		}

		// Token: 0x17001723 RID: 5923
		// (get) Token: 0x06007791 RID: 30609 RVA: 0x0012371B File Offset: 0x0012191B
		// (set) Token: 0x06007792 RID: 30610 RVA: 0x00123723 File Offset: 0x00121923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17001724 RID: 5924
		// (get) Token: 0x06007793 RID: 30611 RVA: 0x0012372C File Offset: 0x0012192C
		// (set) Token: 0x06007794 RID: 30612 RVA: 0x00123734 File Offset: 0x00121934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x06007795 RID: 30613 RVA: 0x0012373D File Offset: 0x0012193D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillCustomResponse);
		}

		// Token: 0x06007796 RID: 30614 RVA: 0x0012374B File Offset: 0x0012194B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillCustomResponse other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007797 RID: 30615 RVA: 0x0012378C File Offset: 0x0012198C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007798 RID: 30616 RVA: 0x001237EA File Offset: 0x001219EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007799 RID: 30617 RVA: 0x001237F7 File Offset: 0x001219F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600779A RID: 30618 RVA: 0x00123800 File Offset: 0x00121A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.EntityId);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600779B RID: 30619 RVA: 0x0012385C File Offset: 0x00121A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600779C RID: 30620 RVA: 0x001238B4 File Offset: 0x00121AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreSkillCustomResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600779D RID: 30621 RVA: 0x00123904 File Offset: 0x00121B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600779E RID: 30622 RVA: 0x00123910 File Offset: 0x00121B10
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
						this.Code = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003E79 RID: 15993
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E7A RID: 15994
		public const int EntityIdFieldNumber = 11;

		// Token: 0x04003E7B RID: 15995
		private long entityId_;

		// Token: 0x04003E7C RID: 15996
		public const int CodeFieldNumber = 12;

		// Token: 0x04003E7D RID: 15997
		private ErrorCode code_;
	}
}
