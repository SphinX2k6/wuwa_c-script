using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000501 RID: 1281
	[NetMessage(EMessageId.ExploreSkillActionRequest)]
	public sealed class ExploreSkillActionRequest : IMessage<ExploreSkillActionRequest>, IMessage, IEquatable<ExploreSkillActionRequest>, IDeepCloneable<ExploreSkillActionRequest>, IBufferMessage
	{
		// Token: 0x060078BD RID: 30909 RVA: 0x00125CEC File Offset: 0x00123EEC
		[NullableContext(1)]
		public static ExploreSkillActionRequest Create()
		{
			return new ExploreSkillActionRequest();
		}

		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x060078BE RID: 30910 RVA: 0x00125CF3 File Offset: 0x00123EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x060078BF RID: 30911 RVA: 0x00125CF6 File Offset: 0x00123EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillActionRequest.Descriptor;
			}
		}

		// Token: 0x060078C0 RID: 30912 RVA: 0x00125CFD File Offset: 0x00123EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillActionRequest()
		{
		}

		// Token: 0x060078C1 RID: 30913 RVA: 0x00125D05 File Offset: 0x00123F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillActionRequest(ExploreSkillActionRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060078C2 RID: 30914 RVA: 0x00125D2A File Offset: 0x00123F2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillActionRequest Clone()
		{
			return new ExploreSkillActionRequest(this);
		}

		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x060078C3 RID: 30915 RVA: 0x00125D32 File Offset: 0x00123F32
		// (set) Token: 0x060078C4 RID: 30916 RVA: 0x00125D3A File Offset: 0x00123F3A
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

		// Token: 0x060078C5 RID: 30917 RVA: 0x00125D43 File Offset: 0x00123F43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillActionRequest);
		}

		// Token: 0x060078C6 RID: 30918 RVA: 0x00125D51 File Offset: 0x00123F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillActionRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060078C7 RID: 30919 RVA: 0x00125D80 File Offset: 0x00123F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060078C8 RID: 30920 RVA: 0x00125DBF File Offset: 0x00123FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060078C9 RID: 30921 RVA: 0x00125DCC File Offset: 0x00123FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060078CA RID: 30922 RVA: 0x00125DD5 File Offset: 0x00123FD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060078CB RID: 30923 RVA: 0x00125E08 File Offset: 0x00124008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060078CC RID: 30924 RVA: 0x00125E46 File Offset: 0x00124046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreSkillActionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060078CD RID: 30925 RVA: 0x00125E77 File Offset: 0x00124077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060078CE RID: 30926 RVA: 0x00125E80 File Offset: 0x00124080
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003E7A RID: 15994
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E7B RID: 15995
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003E7C RID: 15996
		private long entityId_;
	}
}
