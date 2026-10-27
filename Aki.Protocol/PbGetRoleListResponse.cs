using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C04 RID: 3076
	[NetMessage(EMessageId.PbGetRoleListResponse)]
	public sealed class PbGetRoleListResponse : IMessage<PbGetRoleListResponse>, IMessage, IEquatable<PbGetRoleListResponse>, IDeepCloneable<PbGetRoleListResponse>, IBufferMessage
	{
		// Token: 0x06010B28 RID: 68392 RVA: 0x00271DBA File Offset: 0x0026FFBA
		[NullableContext(1)]
		public static PbGetRoleListResponse Create()
		{
			return new PbGetRoleListResponse();
		}

		// Token: 0x17003710 RID: 14096
		// (get) Token: 0x06010B29 RID: 68393 RVA: 0x00271DC1 File Offset: 0x0026FFC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003711 RID: 14097
		// (get) Token: 0x06010B2A RID: 68394 RVA: 0x00271DC4 File Offset: 0x0026FFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbGetRoleListResponse.Descriptor;
			}
		}

		// Token: 0x06010B2B RID: 68395 RVA: 0x00271DCB File Offset: 0x0026FFCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbGetRoleListResponse()
		{
		}

		// Token: 0x06010B2C RID: 68396 RVA: 0x00271DDE File Offset: 0x0026FFDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbGetRoleListResponse(PbGetRoleListResponse other) : this()
		{
			this.code_ = other.code_;
			this.roleList_ = other.roleList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010B2D RID: 68397 RVA: 0x00271E14 File Offset: 0x00270014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbGetRoleListResponse Clone()
		{
			return new PbGetRoleListResponse(this);
		}

		// Token: 0x17003712 RID: 14098
		// (get) Token: 0x06010B2E RID: 68398 RVA: 0x00271E1C File Offset: 0x0027001C
		// (set) Token: 0x06010B2F RID: 68399 RVA: 0x00271E24 File Offset: 0x00270024
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

		// Token: 0x17003713 RID: 14099
		// (get) Token: 0x06010B30 RID: 68400 RVA: 0x00271E2D File Offset: 0x0027002D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<roleInfo> RoleList
		{
			get
			{
				return this.roleList_;
			}
		}

		// Token: 0x06010B31 RID: 68401 RVA: 0x00271E35 File Offset: 0x00270035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbGetRoleListResponse);
		}

		// Token: 0x06010B32 RID: 68402 RVA: 0x00271E44 File Offset: 0x00270044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbGetRoleListResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.roleList_.Equals(other.roleList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010B33 RID: 68403 RVA: 0x00271E94 File Offset: 0x00270094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			num ^= this.roleList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010B34 RID: 68404 RVA: 0x00271EE7 File Offset: 0x002700E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010B35 RID: 68405 RVA: 0x00271EF4 File Offset: 0x002700F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010B36 RID: 68406 RVA: 0x00271F00 File Offset: 0x00270100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Code);
			}
			this.roleList_.WriteTo(ref output, PbGetRoleListResponse._repeated_roleList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010B37 RID: 68407 RVA: 0x00271F50 File Offset: 0x00270150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			num += this.roleList_.CalculateSize(PbGetRoleListResponse._repeated_roleList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010B38 RID: 68408 RVA: 0x00271FA4 File Offset: 0x002701A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbGetRoleListResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this.roleList_.Add(other.roleList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010B39 RID: 68409 RVA: 0x00271FF1 File Offset: 0x002701F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010B3A RID: 68410 RVA: 0x00271FFC File Offset: 0x002701FC
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
				if (num != 16U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.roleList_.AddEntriesFrom(ref input, PbGetRoleListResponse._repeated_roleList_codec);
					}
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006A1C RID: 27164
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A1D RID: 27165
		public const int CodeFieldNumber = 2;

		// Token: 0x04006A1E RID: 27166
		private ErrorCode code_;

		// Token: 0x04006A1F RID: 27167
		public const int RoleListFieldNumber = 7;

		// Token: 0x04006A20 RID: 27168
		private static readonly FieldCodec<roleInfo> _repeated_roleList_codec = FieldCodec.ForMessage<roleInfo>(58U, roleInfo.Parser);

		// Token: 0x04006A21 RID: 27169
		private readonly RepeatedField<roleInfo> roleList_ = new RepeatedField<roleInfo>();
	}
}
