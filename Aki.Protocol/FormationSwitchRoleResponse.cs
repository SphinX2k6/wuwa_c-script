using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000621 RID: 1569
	[NetMessage(EMessageId.FormationSwitchRoleResponse)]
	public sealed class FormationSwitchRoleResponse : IMessage<FormationSwitchRoleResponse>, IMessage, IEquatable<FormationSwitchRoleResponse>, IDeepCloneable<FormationSwitchRoleResponse>, IBufferMessage
	{
		// Token: 0x0600911A RID: 37146 RVA: 0x0015F98D File Offset: 0x0015DB8D
		[NullableContext(1)]
		public static FormationSwitchRoleResponse Create()
		{
			return new FormationSwitchRoleResponse();
		}

		// Token: 0x17001CD7 RID: 7383
		// (get) Token: 0x0600911B RID: 37147 RVA: 0x0015F994 File Offset: 0x0015DB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CD8 RID: 7384
		// (get) Token: 0x0600911C RID: 37148 RVA: 0x0015F997 File Offset: 0x0015DB97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationSwitchRoleResponse.Descriptor;
			}
		}

		// Token: 0x0600911D RID: 37149 RVA: 0x0015F99E File Offset: 0x0015DB9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationSwitchRoleResponse()
		{
		}

		// Token: 0x0600911E RID: 37150 RVA: 0x0015F9A6 File Offset: 0x0015DBA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationSwitchRoleResponse(FormationSwitchRoleResponse other) : this()
		{
			this.roleIndex_ = other.roleIndex_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600911F RID: 37151 RVA: 0x0015F9D7 File Offset: 0x0015DBD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationSwitchRoleResponse Clone()
		{
			return new FormationSwitchRoleResponse(this);
		}

		// Token: 0x17001CD9 RID: 7385
		// (get) Token: 0x06009120 RID: 37152 RVA: 0x0015F9DF File Offset: 0x0015DBDF
		// (set) Token: 0x06009121 RID: 37153 RVA: 0x0015F9E7 File Offset: 0x0015DBE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleIndex
		{
			get
			{
				return this.roleIndex_;
			}
			set
			{
				this.roleIndex_ = value;
			}
		}

		// Token: 0x17001CDA RID: 7386
		// (get) Token: 0x06009122 RID: 37154 RVA: 0x0015F9F0 File Offset: 0x0015DBF0
		// (set) Token: 0x06009123 RID: 37155 RVA: 0x0015F9F8 File Offset: 0x0015DBF8
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

		// Token: 0x06009124 RID: 37156 RVA: 0x0015FA01 File Offset: 0x0015DC01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationSwitchRoleResponse);
		}

		// Token: 0x06009125 RID: 37157 RVA: 0x0015FA0F File Offset: 0x0015DC0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationSwitchRoleResponse other)
		{
			return other != null && (other == this || (this.RoleIndex == other.RoleIndex && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009126 RID: 37158 RVA: 0x0015FA50 File Offset: 0x0015DC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleIndex != 0)
			{
				num ^= this.RoleIndex.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009127 RID: 37159 RVA: 0x0015FAAE File Offset: 0x0015DCAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009128 RID: 37160 RVA: 0x0015FABB File Offset: 0x0015DCBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009129 RID: 37161 RVA: 0x0015FAC4 File Offset: 0x0015DCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleIndex != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RoleIndex);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600912A RID: 37162 RVA: 0x0015FB20 File Offset: 0x0015DD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleIndex);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600912B RID: 37163 RVA: 0x0015FB78 File Offset: 0x0015DD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationSwitchRoleResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleIndex != 0)
			{
				this.RoleIndex = other.RoleIndex;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600912C RID: 37164 RVA: 0x0015FBC8 File Offset: 0x0015DDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600912D RID: 37165 RVA: 0x0015FBD4 File Offset: 0x0015DDD4
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
					if (num != 112U)
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
					this.RoleIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400468E RID: 18062
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400468F RID: 18063
		public const int RoleIndexFieldNumber = 10;

		// Token: 0x04004690 RID: 18064
		private int roleIndex_;

		// Token: 0x04004691 RID: 18065
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04004692 RID: 18066
		private ErrorCode errorCode_;
	}
}
