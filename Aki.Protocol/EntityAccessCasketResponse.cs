using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000448 RID: 1096
	[NetMessage(EMessageId.EntityAccessCasketResponse)]
	public sealed class EntityAccessCasketResponse : IMessage<EntityAccessCasketResponse>, IMessage, IEquatable<EntityAccessCasketResponse>, IDeepCloneable<EntityAccessCasketResponse>, IBufferMessage
	{
		// Token: 0x0600694E RID: 26958 RVA: 0x000FEBFD File Offset: 0x000FCDFD
		[NullableContext(1)]
		public static EntityAccessCasketResponse Create()
		{
			return new EntityAccessCasketResponse();
		}

		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x0600694F RID: 26959 RVA: 0x000FEC04 File Offset: 0x000FCE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x06006950 RID: 26960 RVA: 0x000FEC07 File Offset: 0x000FCE07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityAccessCasketResponse.Descriptor;
			}
		}

		// Token: 0x06006951 RID: 26961 RVA: 0x000FEC0E File Offset: 0x000FCE0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessCasketResponse()
		{
		}

		// Token: 0x06006952 RID: 26962 RVA: 0x000FEC16 File Offset: 0x000FCE16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessCasketResponse(EntityAccessCasketResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.casketEntityIncId_ = other.casketEntityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006953 RID: 26963 RVA: 0x000FEC47 File Offset: 0x000FCE47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessCasketResponse Clone()
		{
			return new EntityAccessCasketResponse(this);
		}

		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x06006954 RID: 26964 RVA: 0x000FEC4F File Offset: 0x000FCE4F
		// (set) Token: 0x06006955 RID: 26965 RVA: 0x000FEC57 File Offset: 0x000FCE57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x06006956 RID: 26966 RVA: 0x000FEC60 File Offset: 0x000FCE60
		// (set) Token: 0x06006957 RID: 26967 RVA: 0x000FEC68 File Offset: 0x000FCE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CasketEntityIncId
		{
			get
			{
				return this.casketEntityIncId_;
			}
			set
			{
				this.casketEntityIncId_ = value;
			}
		}

		// Token: 0x06006958 RID: 26968 RVA: 0x000FEC71 File Offset: 0x000FCE71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityAccessCasketResponse);
		}

		// Token: 0x06006959 RID: 26969 RVA: 0x000FEC7F File Offset: 0x000FCE7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityAccessCasketResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.CasketEntityIncId == other.CasketEntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600695A RID: 26970 RVA: 0x000FECC0 File Offset: 0x000FCEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.CasketEntityIncId != 0L)
			{
				num ^= this.CasketEntityIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600695B RID: 26971 RVA: 0x000FED1E File Offset: 0x000FCF1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600695C RID: 26972 RVA: 0x000FED2B File Offset: 0x000FCF2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600695D RID: 26973 RVA: 0x000FED34 File Offset: 0x000FCF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CasketEntityIncId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.CasketEntityIncId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600695E RID: 26974 RVA: 0x000FED90 File Offset: 0x000FCF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.CasketEntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CasketEntityIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600695F RID: 26975 RVA: 0x000FEDE8 File Offset: 0x000FCFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityAccessCasketResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.CasketEntityIncId != 0L)
			{
				this.CasketEntityIncId = other.CasketEntityIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006960 RID: 26976 RVA: 0x000FEE38 File Offset: 0x000FD038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006961 RID: 26977 RVA: 0x000FEE44 File Offset: 0x000FD044
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
				if (num != 56U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.CasketEntityIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003A52 RID: 14930
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A53 RID: 14931
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04003A54 RID: 14932
		private ErrorCode errorCode_;

		// Token: 0x04003A55 RID: 14933
		public const int CasketEntityIncIdFieldNumber = 7;

		// Token: 0x04003A56 RID: 14934
		private long casketEntityIncId_;
	}
}
