using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001495 RID: 5269
	[NetMessage(EMessageId.UpdateFightRoleRequest)]
	public sealed class UpdateFightRoleRequest : IMessage<UpdateFightRoleRequest>, IMessage, IEquatable<UpdateFightRoleRequest>, IDeepCloneable<UpdateFightRoleRequest>, IBufferMessage
	{
		// Token: 0x0601BDFD RID: 114173 RVA: 0x00407A91 File Offset: 0x00405C91
		[NullableContext(1)]
		public static UpdateFightRoleRequest Create()
		{
			return new UpdateFightRoleRequest();
		}

		// Token: 0x17005DF4 RID: 24052
		// (get) Token: 0x0601BDFE RID: 114174 RVA: 0x00407A98 File Offset: 0x00405C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DF5 RID: 24053
		// (get) Token: 0x0601BDFF RID: 114175 RVA: 0x00407A9B File Offset: 0x00405C9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateFightRoleRequest.Descriptor;
			}
		}

		// Token: 0x0601BE00 RID: 114176 RVA: 0x00407AA2 File Offset: 0x00405CA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFightRoleRequest()
		{
		}

		// Token: 0x0601BE01 RID: 114177 RVA: 0x00407AB5 File Offset: 0x00405CB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFightRoleRequest(UpdateFightRoleRequest other) : this()
		{
			this.curRoleId_ = other.curRoleId_;
			this.roleIds_ = other.roleIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BE02 RID: 114178 RVA: 0x00407AEB File Offset: 0x00405CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFightRoleRequest Clone()
		{
			return new UpdateFightRoleRequest(this);
		}

		// Token: 0x17005DF6 RID: 24054
		// (get) Token: 0x0601BE03 RID: 114179 RVA: 0x00407AF3 File Offset: 0x00405CF3
		// (set) Token: 0x0601BE04 RID: 114180 RVA: 0x00407AFB File Offset: 0x00405CFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurRoleId
		{
			get
			{
				return this.curRoleId_;
			}
			set
			{
				this.curRoleId_ = value;
			}
		}

		// Token: 0x17005DF7 RID: 24055
		// (get) Token: 0x0601BE05 RID: 114181 RVA: 0x00407B04 File Offset: 0x00405D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x0601BE06 RID: 114182 RVA: 0x00407B0C File Offset: 0x00405D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateFightRoleRequest);
		}

		// Token: 0x0601BE07 RID: 114183 RVA: 0x00407B1C File Offset: 0x00405D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateFightRoleRequest other)
		{
			return other != null && (other == this || (this.CurRoleId == other.CurRoleId && this.roleIds_.Equals(other.roleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BE08 RID: 114184 RVA: 0x00407B6C File Offset: 0x00405D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurRoleId != 0)
			{
				num ^= this.CurRoleId.GetHashCode();
			}
			num ^= this.roleIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BE09 RID: 114185 RVA: 0x00407BB9 File Offset: 0x00405DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BE0A RID: 114186 RVA: 0x00407BC6 File Offset: 0x00405DC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BE0B RID: 114187 RVA: 0x00407BD0 File Offset: 0x00405DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurRoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurRoleId);
			}
			this.roleIds_.WriteTo(ref output, UpdateFightRoleRequest._repeated_roleIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BE0C RID: 114188 RVA: 0x00407C20 File Offset: 0x00405E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurRoleId);
			}
			num += this.roleIds_.CalculateSize(UpdateFightRoleRequest._repeated_roleIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BE0D RID: 114189 RVA: 0x00407C74 File Offset: 0x00405E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateFightRoleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurRoleId != 0)
			{
				this.CurRoleId = other.CurRoleId;
			}
			this.roleIds_.Add(other.roleIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BE0E RID: 114190 RVA: 0x00407CC1 File Offset: 0x00405EC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BE0F RID: 114191 RVA: 0x00407CCC File Offset: 0x00405ECC
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
					if (num != 72U && num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.roleIds_.AddEntriesFrom(ref input, UpdateFightRoleRequest._repeated_roleIds_codec);
					}
				}
				else
				{
					this.CurRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A044 RID: 41028
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A045 RID: 41029
		public const int CurRoleIdFieldNumber = 1;

		// Token: 0x0400A046 RID: 41030
		private int curRoleId_;

		// Token: 0x0400A047 RID: 41031
		public const int RoleIdsFieldNumber = 9;

		// Token: 0x0400A048 RID: 41032
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x0400A049 RID: 41033
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();
	}
}
