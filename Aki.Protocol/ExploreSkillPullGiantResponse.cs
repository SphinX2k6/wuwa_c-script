using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004F2 RID: 1266
	[NetMessage(EMessageId.ExploreSkillPullGiantResponse)]
	public sealed class ExploreSkillPullGiantResponse : IMessage<ExploreSkillPullGiantResponse>, IMessage, IEquatable<ExploreSkillPullGiantResponse>, IDeepCloneable<ExploreSkillPullGiantResponse>, IBufferMessage
	{
		// Token: 0x060077C3 RID: 30659 RVA: 0x00123D65 File Offset: 0x00121F65
		[NullableContext(1)]
		public static ExploreSkillPullGiantResponse Create()
		{
			return new ExploreSkillPullGiantResponse();
		}

		// Token: 0x1700172B RID: 5931
		// (get) Token: 0x060077C4 RID: 30660 RVA: 0x00123D6C File Offset: 0x00121F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700172C RID: 5932
		// (get) Token: 0x060077C5 RID: 30661 RVA: 0x00123D6F File Offset: 0x00121F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillPullGiantResponse.Descriptor;
			}
		}

		// Token: 0x060077C6 RID: 30662 RVA: 0x00123D76 File Offset: 0x00121F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillPullGiantResponse()
		{
		}

		// Token: 0x060077C7 RID: 30663 RVA: 0x00123D7E File Offset: 0x00121F7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillPullGiantResponse(ExploreSkillPullGiantResponse other) : this()
		{
			this.entityId_ = other.entityId_;
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060077C8 RID: 30664 RVA: 0x00123DAF File Offset: 0x00121FAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillPullGiantResponse Clone()
		{
			return new ExploreSkillPullGiantResponse(this);
		}

		// Token: 0x1700172D RID: 5933
		// (get) Token: 0x060077C9 RID: 30665 RVA: 0x00123DB7 File Offset: 0x00121FB7
		// (set) Token: 0x060077CA RID: 30666 RVA: 0x00123DBF File Offset: 0x00121FBF
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

		// Token: 0x1700172E RID: 5934
		// (get) Token: 0x060077CB RID: 30667 RVA: 0x00123DC8 File Offset: 0x00121FC8
		// (set) Token: 0x060077CC RID: 30668 RVA: 0x00123DD0 File Offset: 0x00121FD0
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

		// Token: 0x060077CD RID: 30669 RVA: 0x00123DD9 File Offset: 0x00121FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillPullGiantResponse);
		}

		// Token: 0x060077CE RID: 30670 RVA: 0x00123DE7 File Offset: 0x00121FE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillPullGiantResponse other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060077CF RID: 30671 RVA: 0x00123E28 File Offset: 0x00122028
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

		// Token: 0x060077D0 RID: 30672 RVA: 0x00123E86 File Offset: 0x00122086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060077D1 RID: 30673 RVA: 0x00123E93 File Offset: 0x00122093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060077D2 RID: 30674 RVA: 0x00123E9C File Offset: 0x0012209C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Code);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060077D3 RID: 30675 RVA: 0x00123EF8 File Offset: 0x001220F8
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

		// Token: 0x060077D4 RID: 30676 RVA: 0x00123F50 File Offset: 0x00122150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreSkillPullGiantResponse other)
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

		// Token: 0x060077D5 RID: 30677 RVA: 0x00123FA0 File Offset: 0x001221A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060077D6 RID: 30678 RVA: 0x00123FAC File Offset: 0x001221AC
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003E84 RID: 16004
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E85 RID: 16005
		public const int EntityIdFieldNumber = 12;

		// Token: 0x04003E86 RID: 16006
		private long entityId_;

		// Token: 0x04003E87 RID: 16007
		public const int CodeFieldNumber = 3;

		// Token: 0x04003E88 RID: 16008
		private ErrorCode code_;
	}
}
