using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000502 RID: 1282
	[NetMessage(EMessageId.ExploreSkillActionResponse)]
	public sealed class ExploreSkillActionResponse : IMessage<ExploreSkillActionResponse>, IMessage, IEquatable<ExploreSkillActionResponse>, IDeepCloneable<ExploreSkillActionResponse>, IBufferMessage
	{
		// Token: 0x060078CF RID: 30927 RVA: 0x00125EC4 File Offset: 0x001240C4
		[NullableContext(1)]
		public static ExploreSkillActionResponse Create()
		{
			return new ExploreSkillActionResponse();
		}

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x060078D0 RID: 30928 RVA: 0x00125ECB File Offset: 0x001240CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x060078D1 RID: 30929 RVA: 0x00125ECE File Offset: 0x001240CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillActionResponse.Descriptor;
			}
		}

		// Token: 0x060078D2 RID: 30930 RVA: 0x00125ED5 File Offset: 0x001240D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillActionResponse()
		{
		}

		// Token: 0x060078D3 RID: 30931 RVA: 0x00125EDD File Offset: 0x001240DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillActionResponse(ExploreSkillActionResponse other) : this()
		{
			this.entityId_ = other.entityId_;
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060078D4 RID: 30932 RVA: 0x00125F0E File Offset: 0x0012410E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillActionResponse Clone()
		{
			return new ExploreSkillActionResponse(this);
		}

		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x060078D5 RID: 30933 RVA: 0x00125F16 File Offset: 0x00124116
		// (set) Token: 0x060078D6 RID: 30934 RVA: 0x00125F1E File Offset: 0x0012411E
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

		// Token: 0x1700176B RID: 5995
		// (get) Token: 0x060078D7 RID: 30935 RVA: 0x00125F27 File Offset: 0x00124127
		// (set) Token: 0x060078D8 RID: 30936 RVA: 0x00125F2F File Offset: 0x0012412F
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

		// Token: 0x060078D9 RID: 30937 RVA: 0x00125F38 File Offset: 0x00124138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillActionResponse);
		}

		// Token: 0x060078DA RID: 30938 RVA: 0x00125F46 File Offset: 0x00124146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillActionResponse other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060078DB RID: 30939 RVA: 0x00125F84 File Offset: 0x00124184
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

		// Token: 0x060078DC RID: 30940 RVA: 0x00125FE2 File Offset: 0x001241E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060078DD RID: 30941 RVA: 0x00125FEF File Offset: 0x001241EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060078DE RID: 30942 RVA: 0x00125FF8 File Offset: 0x001241F8
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
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060078DF RID: 30943 RVA: 0x00126054 File Offset: 0x00124254
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

		// Token: 0x060078E0 RID: 30944 RVA: 0x001260AC File Offset: 0x001242AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreSkillActionResponse other)
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

		// Token: 0x060078E1 RID: 30945 RVA: 0x001260FC File Offset: 0x001242FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060078E2 RID: 30946 RVA: 0x00126108 File Offset: 0x00124308
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
					if (num != 112U)
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

		// Token: 0x04003E7D RID: 15997
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E7E RID: 15998
		public const int EntityIdFieldNumber = 14;

		// Token: 0x04003E7F RID: 15999
		private long entityId_;

		// Token: 0x04003E80 RID: 16000
		public const int CodeFieldNumber = 3;

		// Token: 0x04003E81 RID: 16001
		private ErrorCode code_;
	}
}
