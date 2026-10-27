using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000508 RID: 1288
	[NetMessage(EMessageId.ExploreSkillPullGiantResponse)]
	public sealed class ExploreSkillPullGiantResponse : IMessage<ExploreSkillPullGiantResponse>, IMessage, IEquatable<ExploreSkillPullGiantResponse>, IDeepCloneable<ExploreSkillPullGiantResponse>, IBufferMessage
	{
		// Token: 0x0600793F RID: 31039 RVA: 0x00126BF9 File Offset: 0x00124DF9
		[NullableContext(1)]
		public static ExploreSkillPullGiantResponse Create()
		{
			return new ExploreSkillPullGiantResponse();
		}

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x06007940 RID: 31040 RVA: 0x00126C00 File Offset: 0x00124E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700177D RID: 6013
		// (get) Token: 0x06007941 RID: 31041 RVA: 0x00126C03 File Offset: 0x00124E03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillPullGiantResponse.Descriptor;
			}
		}

		// Token: 0x06007942 RID: 31042 RVA: 0x00126C0A File Offset: 0x00124E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillPullGiantResponse()
		{
		}

		// Token: 0x06007943 RID: 31043 RVA: 0x00126C12 File Offset: 0x00124E12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillPullGiantResponse(ExploreSkillPullGiantResponse other) : this()
		{
			this.entityId_ = other.entityId_;
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007944 RID: 31044 RVA: 0x00126C43 File Offset: 0x00124E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillPullGiantResponse Clone()
		{
			return new ExploreSkillPullGiantResponse(this);
		}

		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x06007945 RID: 31045 RVA: 0x00126C4B File Offset: 0x00124E4B
		// (set) Token: 0x06007946 RID: 31046 RVA: 0x00126C53 File Offset: 0x00124E53
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

		// Token: 0x1700177F RID: 6015
		// (get) Token: 0x06007947 RID: 31047 RVA: 0x00126C5C File Offset: 0x00124E5C
		// (set) Token: 0x06007948 RID: 31048 RVA: 0x00126C64 File Offset: 0x00124E64
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

		// Token: 0x06007949 RID: 31049 RVA: 0x00126C6D File Offset: 0x00124E6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillPullGiantResponse);
		}

		// Token: 0x0600794A RID: 31050 RVA: 0x00126C7B File Offset: 0x00124E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillPullGiantResponse other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600794B RID: 31051 RVA: 0x00126CBC File Offset: 0x00124EBC
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

		// Token: 0x0600794C RID: 31052 RVA: 0x00126D1A File Offset: 0x00124F1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600794D RID: 31053 RVA: 0x00126D27 File Offset: 0x00124F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600794E RID: 31054 RVA: 0x00126D30 File Offset: 0x00124F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600794F RID: 31055 RVA: 0x00126D8C File Offset: 0x00124F8C
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

		// Token: 0x06007950 RID: 31056 RVA: 0x00126DE4 File Offset: 0x00124FE4
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

		// Token: 0x06007951 RID: 31057 RVA: 0x00126E34 File Offset: 0x00125034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007952 RID: 31058 RVA: 0x00126E40 File Offset: 0x00125040
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
				if (num != 104U)
				{
					if (num != 120U)
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

		// Token: 0x04003E93 RID: 16019
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E94 RID: 16020
		public const int EntityIdFieldNumber = 13;

		// Token: 0x04003E95 RID: 16021
		private long entityId_;

		// Token: 0x04003E96 RID: 16022
		public const int CodeFieldNumber = 15;

		// Token: 0x04003E97 RID: 16023
		private ErrorCode code_;
	}
}
