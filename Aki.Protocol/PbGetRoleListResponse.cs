using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BF4 RID: 3060
	[NetMessage(EMessageId.PbGetRoleListResponse)]
	public sealed class PbGetRoleListResponse : IMessage<PbGetRoleListResponse>, IMessage, IEquatable<PbGetRoleListResponse>, IDeepCloneable<PbGetRoleListResponse>, IBufferMessage
	{
		// Token: 0x06010A28 RID: 68136 RVA: 0x00270052 File Offset: 0x0026E252
		[NullableContext(1)]
		public static PbGetRoleListResponse Create()
		{
			return new PbGetRoleListResponse();
		}

		// Token: 0x170036D9 RID: 14041
		// (get) Token: 0x06010A29 RID: 68137 RVA: 0x00270059 File Offset: 0x0026E259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036DA RID: 14042
		// (get) Token: 0x06010A2A RID: 68138 RVA: 0x0027005C File Offset: 0x0026E25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbGetRoleListResponse.Descriptor;
			}
		}

		// Token: 0x06010A2B RID: 68139 RVA: 0x00270063 File Offset: 0x0026E263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbGetRoleListResponse()
		{
		}

		// Token: 0x06010A2C RID: 68140 RVA: 0x00270076 File Offset: 0x0026E276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbGetRoleListResponse(PbGetRoleListResponse other) : this()
		{
			this.code_ = other.code_;
			this.roleList_ = other.roleList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010A2D RID: 68141 RVA: 0x002700AC File Offset: 0x0026E2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbGetRoleListResponse Clone()
		{
			return new PbGetRoleListResponse(this);
		}

		// Token: 0x170036DB RID: 14043
		// (get) Token: 0x06010A2E RID: 68142 RVA: 0x002700B4 File Offset: 0x0026E2B4
		// (set) Token: 0x06010A2F RID: 68143 RVA: 0x002700BC File Offset: 0x0026E2BC
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

		// Token: 0x170036DC RID: 14044
		// (get) Token: 0x06010A30 RID: 68144 RVA: 0x002700C5 File Offset: 0x0026E2C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<roleInfo> RoleList
		{
			get
			{
				return this.roleList_;
			}
		}

		// Token: 0x06010A31 RID: 68145 RVA: 0x002700CD File Offset: 0x0026E2CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbGetRoleListResponse);
		}

		// Token: 0x06010A32 RID: 68146 RVA: 0x002700DC File Offset: 0x0026E2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbGetRoleListResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.roleList_.Equals(other.roleList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010A33 RID: 68147 RVA: 0x0027012C File Offset: 0x0026E32C
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

		// Token: 0x06010A34 RID: 68148 RVA: 0x0027017F File Offset: 0x0026E37F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010A35 RID: 68149 RVA: 0x0027018C File Offset: 0x0026E38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010A36 RID: 68150 RVA: 0x00270198 File Offset: 0x0026E398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleList_.WriteTo(ref output, PbGetRoleListResponse._repeated_roleList_codec);
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010A37 RID: 68151 RVA: 0x002701E8 File Offset: 0x0026E3E8
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

		// Token: 0x06010A38 RID: 68152 RVA: 0x0027023C File Offset: 0x0026E43C
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

		// Token: 0x06010A39 RID: 68153 RVA: 0x00270289 File Offset: 0x0026E489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010A3A RID: 68154 RVA: 0x00270294 File Offset: 0x0026E494
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
				if (num != 58U)
				{
					if (num != 72U)
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
					this.roleList_.AddEntriesFrom(ref input, PbGetRoleListResponse._repeated_roleList_codec);
				}
			}
		}

		// Token: 0x04006A30 RID: 27184
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A31 RID: 27185
		public const int CodeFieldNumber = 9;

		// Token: 0x04006A32 RID: 27186
		private ErrorCode code_;

		// Token: 0x04006A33 RID: 27187
		public const int RoleListFieldNumber = 7;

		// Token: 0x04006A34 RID: 27188
		private static readonly FieldCodec<roleInfo> _repeated_roleList_codec = FieldCodec.ForMessage<roleInfo>(58U, roleInfo.Parser);

		// Token: 0x04006A35 RID: 27189
		private readonly RepeatedField<roleInfo> roleList_ = new RepeatedField<roleInfo>();
	}
}
