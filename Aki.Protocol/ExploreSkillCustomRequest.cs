using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000504 RID: 1284
	[NetMessage(EMessageId.ExploreSkillCustomRequest)]
	public sealed class ExploreSkillCustomRequest : IMessage<ExploreSkillCustomRequest>, IMessage, IEquatable<ExploreSkillCustomRequest>, IDeepCloneable<ExploreSkillCustomRequest>, IBufferMessage
	{
		// Token: 0x060078F5 RID: 30965 RVA: 0x00126384 File Offset: 0x00124584
		[NullableContext(1)]
		public static ExploreSkillCustomRequest Create()
		{
			return new ExploreSkillCustomRequest();
		}

		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x060078F6 RID: 30966 RVA: 0x0012638B File Offset: 0x0012458B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001770 RID: 6000
		// (get) Token: 0x060078F7 RID: 30967 RVA: 0x0012638E File Offset: 0x0012458E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillCustomRequest.Descriptor;
			}
		}

		// Token: 0x060078F8 RID: 30968 RVA: 0x00126395 File Offset: 0x00124595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillCustomRequest()
		{
		}

		// Token: 0x060078F9 RID: 30969 RVA: 0x0012639D File Offset: 0x0012459D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillCustomRequest(ExploreSkillCustomRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060078FA RID: 30970 RVA: 0x001263C2 File Offset: 0x001245C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillCustomRequest Clone()
		{
			return new ExploreSkillCustomRequest(this);
		}

		// Token: 0x17001771 RID: 6001
		// (get) Token: 0x060078FB RID: 30971 RVA: 0x001263CA File Offset: 0x001245CA
		// (set) Token: 0x060078FC RID: 30972 RVA: 0x001263D2 File Offset: 0x001245D2
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

		// Token: 0x060078FD RID: 30973 RVA: 0x001263DB File Offset: 0x001245DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillCustomRequest);
		}

		// Token: 0x060078FE RID: 30974 RVA: 0x001263E9 File Offset: 0x001245E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillCustomRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060078FF RID: 30975 RVA: 0x00126418 File Offset: 0x00124618
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

		// Token: 0x06007900 RID: 30976 RVA: 0x00126457 File Offset: 0x00124657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007901 RID: 30977 RVA: 0x00126464 File Offset: 0x00124664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007902 RID: 30978 RVA: 0x0012646D File Offset: 0x0012466D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007903 RID: 30979 RVA: 0x001264A0 File Offset: 0x001246A0
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

		// Token: 0x06007904 RID: 30980 RVA: 0x001264DE File Offset: 0x001246DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreSkillCustomRequest other)
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

		// Token: 0x06007905 RID: 30981 RVA: 0x0012650F File Offset: 0x0012470F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007906 RID: 30982 RVA: 0x00126518 File Offset: 0x00124718
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003E85 RID: 16005
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E86 RID: 16006
		public const int EntityIdFieldNumber = 10;

		// Token: 0x04003E87 RID: 16007
		private long entityId_;
	}
}
