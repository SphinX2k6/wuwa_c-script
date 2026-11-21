using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BF2 RID: 3058
	[NetMessage(EMessageId.PbGetRoleListNotify)]
	public sealed class PbGetRoleListNotify : IMessage<PbGetRoleListNotify>, IMessage, IEquatable<PbGetRoleListNotify>, IDeepCloneable<PbGetRoleListNotify>, IBufferMessage
	{
		// Token: 0x06010A06 RID: 68102 RVA: 0x0026FD38 File Offset: 0x0026DF38
		[NullableContext(1)]
		public static PbGetRoleListNotify Create()
		{
			return new PbGetRoleListNotify();
		}

		// Token: 0x170036D4 RID: 14036
		// (get) Token: 0x06010A07 RID: 68103 RVA: 0x0026FD3F File Offset: 0x0026DF3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036D5 RID: 14037
		// (get) Token: 0x06010A08 RID: 68104 RVA: 0x0026FD42 File Offset: 0x0026DF42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbGetRoleListNotify.Descriptor;
			}
		}

		// Token: 0x06010A09 RID: 68105 RVA: 0x0026FD49 File Offset: 0x0026DF49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbGetRoleListNotify()
		{
		}

		// Token: 0x06010A0A RID: 68106 RVA: 0x0026FD5C File Offset: 0x0026DF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbGetRoleListNotify(PbGetRoleListNotify other) : this()
		{
			this.roleList_ = other.roleList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010A0B RID: 68107 RVA: 0x0026FD86 File Offset: 0x0026DF86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbGetRoleListNotify Clone()
		{
			return new PbGetRoleListNotify(this);
		}

		// Token: 0x170036D6 RID: 14038
		// (get) Token: 0x06010A0C RID: 68108 RVA: 0x0026FD8E File Offset: 0x0026DF8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<roleInfo> RoleList
		{
			get
			{
				return this.roleList_;
			}
		}

		// Token: 0x06010A0D RID: 68109 RVA: 0x0026FD96 File Offset: 0x0026DF96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbGetRoleListNotify);
		}

		// Token: 0x06010A0E RID: 68110 RVA: 0x0026FDA4 File Offset: 0x0026DFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbGetRoleListNotify other)
		{
			return other != null && (other == this || (this.roleList_.Equals(other.roleList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010A0F RID: 68111 RVA: 0x0026FDD8 File Offset: 0x0026DFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010A10 RID: 68112 RVA: 0x0026FE0C File Offset: 0x0026E00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010A11 RID: 68113 RVA: 0x0026FE19 File Offset: 0x0026E019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010A12 RID: 68114 RVA: 0x0026FE22 File Offset: 0x0026E022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleList_.WriteTo(ref output, PbGetRoleListNotify._repeated_roleList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010A13 RID: 68115 RVA: 0x0026FE4C File Offset: 0x0026E04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleList_.CalculateSize(PbGetRoleListNotify._repeated_roleList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010A14 RID: 68116 RVA: 0x0026FE85 File Offset: 0x0026E085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbGetRoleListNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.roleList_.Add(other.roleList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010A15 RID: 68117 RVA: 0x0026FEB3 File Offset: 0x0026E0B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010A16 RID: 68118 RVA: 0x0026FEBC File Offset: 0x0026E0BC
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleList_.AddEntriesFrom(ref input, PbGetRoleListNotify._repeated_roleList_codec);
				}
			}
		}

		// Token: 0x04006A2B RID: 27179
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A2C RID: 27180
		public const int RoleListFieldNumber = 5;

		// Token: 0x04006A2D RID: 27181
		private static readonly FieldCodec<roleInfo> _repeated_roleList_codec = FieldCodec.ForMessage<roleInfo>(42U, roleInfo.Parser);

		// Token: 0x04006A2E RID: 27182
		private readonly RepeatedField<roleInfo> roleList_ = new RepeatedField<roleInfo>();
	}
}
