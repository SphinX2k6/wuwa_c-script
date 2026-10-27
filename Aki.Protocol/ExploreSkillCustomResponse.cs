using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000505 RID: 1285
	[NetMessage(EMessageId.ExploreSkillCustomResponse)]
	public sealed class ExploreSkillCustomResponse : IMessage<ExploreSkillCustomResponse>, IMessage, IEquatable<ExploreSkillCustomResponse>, IDeepCloneable<ExploreSkillCustomResponse>, IBufferMessage
	{
		// Token: 0x06007907 RID: 30983 RVA: 0x0012655D File Offset: 0x0012475D
		[NullableContext(1)]
		public static ExploreSkillCustomResponse Create()
		{
			return new ExploreSkillCustomResponse();
		}

		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x06007908 RID: 30984 RVA: 0x00126564 File Offset: 0x00124764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001773 RID: 6003
		// (get) Token: 0x06007909 RID: 30985 RVA: 0x00126567 File Offset: 0x00124767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillCustomResponse.Descriptor;
			}
		}

		// Token: 0x0600790A RID: 30986 RVA: 0x0012656E File Offset: 0x0012476E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillCustomResponse()
		{
		}

		// Token: 0x0600790B RID: 30987 RVA: 0x00126576 File Offset: 0x00124776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillCustomResponse(ExploreSkillCustomResponse other) : this()
		{
			this.entityId_ = other.entityId_;
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600790C RID: 30988 RVA: 0x001265A7 File Offset: 0x001247A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillCustomResponse Clone()
		{
			return new ExploreSkillCustomResponse(this);
		}

		// Token: 0x17001774 RID: 6004
		// (get) Token: 0x0600790D RID: 30989 RVA: 0x001265AF File Offset: 0x001247AF
		// (set) Token: 0x0600790E RID: 30990 RVA: 0x001265B7 File Offset: 0x001247B7
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

		// Token: 0x17001775 RID: 6005
		// (get) Token: 0x0600790F RID: 30991 RVA: 0x001265C0 File Offset: 0x001247C0
		// (set) Token: 0x06007910 RID: 30992 RVA: 0x001265C8 File Offset: 0x001247C8
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

		// Token: 0x06007911 RID: 30993 RVA: 0x001265D1 File Offset: 0x001247D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillCustomResponse);
		}

		// Token: 0x06007912 RID: 30994 RVA: 0x001265DF File Offset: 0x001247DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillCustomResponse other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007913 RID: 30995 RVA: 0x00126620 File Offset: 0x00124820
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

		// Token: 0x06007914 RID: 30996 RVA: 0x0012667E File Offset: 0x0012487E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007915 RID: 30997 RVA: 0x0012668B File Offset: 0x0012488B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007916 RID: 30998 RVA: 0x00126694 File Offset: 0x00124894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
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

		// Token: 0x06007917 RID: 30999 RVA: 0x001266F0 File Offset: 0x001248F0
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

		// Token: 0x06007918 RID: 31000 RVA: 0x00126748 File Offset: 0x00124948
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

		// Token: 0x06007919 RID: 31001 RVA: 0x00126798 File Offset: 0x00124998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600791A RID: 31002 RVA: 0x001267A4 File Offset: 0x001249A4
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

		// Token: 0x04003E88 RID: 16008
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E89 RID: 16009
		public const int EntityIdFieldNumber = 6;

		// Token: 0x04003E8A RID: 16010
		private long entityId_;

		// Token: 0x04003E8B RID: 16011
		public const int CodeFieldNumber = 12;

		// Token: 0x04003E8C RID: 16012
		private ErrorCode code_;
	}
}
