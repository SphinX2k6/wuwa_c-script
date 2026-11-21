using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001509 RID: 5385
	[NetMessage(EMessageId.UpdateFightRoleRequest)]
	public sealed class UpdateFightRoleRequest : IMessage<UpdateFightRoleRequest>, IMessage, IEquatable<UpdateFightRoleRequest>, IDeepCloneable<UpdateFightRoleRequest>, IBufferMessage
	{
		// Token: 0x0601C89A RID: 116890 RVA: 0x00422F35 File Offset: 0x00421135
		[NullableContext(1)]
		public static UpdateFightRoleRequest Create()
		{
			return new UpdateFightRoleRequest();
		}

		// Token: 0x1700608C RID: 24716
		// (get) Token: 0x0601C89B RID: 116891 RVA: 0x00422F3C File Offset: 0x0042113C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700608D RID: 24717
		// (get) Token: 0x0601C89C RID: 116892 RVA: 0x00422F3F File Offset: 0x0042113F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateFightRoleRequest.Descriptor;
			}
		}

		// Token: 0x0601C89D RID: 116893 RVA: 0x00422F46 File Offset: 0x00421146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFightRoleRequest()
		{
		}

		// Token: 0x0601C89E RID: 116894 RVA: 0x00422F59 File Offset: 0x00421159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFightRoleRequest(UpdateFightRoleRequest other) : this()
		{
			this.curRoleId_ = other.curRoleId_;
			this.roleIds_ = other.roleIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C89F RID: 116895 RVA: 0x00422F8F File Offset: 0x0042118F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFightRoleRequest Clone()
		{
			return new UpdateFightRoleRequest(this);
		}

		// Token: 0x1700608E RID: 24718
		// (get) Token: 0x0601C8A0 RID: 116896 RVA: 0x00422F97 File Offset: 0x00421197
		// (set) Token: 0x0601C8A1 RID: 116897 RVA: 0x00422F9F File Offset: 0x0042119F
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

		// Token: 0x1700608F RID: 24719
		// (get) Token: 0x0601C8A2 RID: 116898 RVA: 0x00422FA8 File Offset: 0x004211A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x0601C8A3 RID: 116899 RVA: 0x00422FB0 File Offset: 0x004211B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateFightRoleRequest);
		}

		// Token: 0x0601C8A4 RID: 116900 RVA: 0x00422FC0 File Offset: 0x004211C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateFightRoleRequest other)
		{
			return other != null && (other == this || (this.CurRoleId == other.CurRoleId && this.roleIds_.Equals(other.roleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C8A5 RID: 116901 RVA: 0x00423010 File Offset: 0x00421210
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

		// Token: 0x0601C8A6 RID: 116902 RVA: 0x0042305D File Offset: 0x0042125D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C8A7 RID: 116903 RVA: 0x0042306A File Offset: 0x0042126A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C8A8 RID: 116904 RVA: 0x00423074 File Offset: 0x00421274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurRoleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CurRoleId);
			}
			this.roleIds_.WriteTo(ref output, UpdateFightRoleRequest._repeated_roleIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C8A9 RID: 116905 RVA: 0x004230C4 File Offset: 0x004212C4
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

		// Token: 0x0601C8AA RID: 116906 RVA: 0x00423118 File Offset: 0x00421318
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

		// Token: 0x0601C8AB RID: 116907 RVA: 0x00423165 File Offset: 0x00421365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C8AC RID: 116908 RVA: 0x00423170 File Offset: 0x00421370
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
					if (num != 120U && num != 122U)
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

		// Token: 0x0400A48F RID: 42127
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A490 RID: 42128
		public const int CurRoleIdFieldNumber = 6;

		// Token: 0x0400A491 RID: 42129
		private int curRoleId_;

		// Token: 0x0400A492 RID: 42130
		public const int RoleIdsFieldNumber = 15;

		// Token: 0x0400A493 RID: 42131
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x0400A494 RID: 42132
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();
	}
}
