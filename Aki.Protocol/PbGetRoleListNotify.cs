using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C02 RID: 3074
	[NetMessage(EMessageId.PbGetRoleListNotify)]
	public sealed class PbGetRoleListNotify : IMessage<PbGetRoleListNotify>, IMessage, IEquatable<PbGetRoleListNotify>, IDeepCloneable<PbGetRoleListNotify>, IBufferMessage
	{
		// Token: 0x06010B06 RID: 68358 RVA: 0x00271AA0 File Offset: 0x0026FCA0
		[NullableContext(1)]
		public static PbGetRoleListNotify Create()
		{
			return new PbGetRoleListNotify();
		}

		// Token: 0x1700370B RID: 14091
		// (get) Token: 0x06010B07 RID: 68359 RVA: 0x00271AA7 File Offset: 0x0026FCA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700370C RID: 14092
		// (get) Token: 0x06010B08 RID: 68360 RVA: 0x00271AAA File Offset: 0x0026FCAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbGetRoleListNotify.Descriptor;
			}
		}

		// Token: 0x06010B09 RID: 68361 RVA: 0x00271AB1 File Offset: 0x0026FCB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbGetRoleListNotify()
		{
		}

		// Token: 0x06010B0A RID: 68362 RVA: 0x00271AC4 File Offset: 0x0026FCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbGetRoleListNotify(PbGetRoleListNotify other) : this()
		{
			this.roleList_ = other.roleList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010B0B RID: 68363 RVA: 0x00271AEE File Offset: 0x0026FCEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbGetRoleListNotify Clone()
		{
			return new PbGetRoleListNotify(this);
		}

		// Token: 0x1700370D RID: 14093
		// (get) Token: 0x06010B0C RID: 68364 RVA: 0x00271AF6 File Offset: 0x0026FCF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<roleInfo> RoleList
		{
			get
			{
				return this.roleList_;
			}
		}

		// Token: 0x06010B0D RID: 68365 RVA: 0x00271AFE File Offset: 0x0026FCFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbGetRoleListNotify);
		}

		// Token: 0x06010B0E RID: 68366 RVA: 0x00271B0C File Offset: 0x0026FD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbGetRoleListNotify other)
		{
			return other != null && (other == this || (this.roleList_.Equals(other.roleList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010B0F RID: 68367 RVA: 0x00271B40 File Offset: 0x0026FD40
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

		// Token: 0x06010B10 RID: 68368 RVA: 0x00271B74 File Offset: 0x0026FD74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010B11 RID: 68369 RVA: 0x00271B81 File Offset: 0x0026FD81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010B12 RID: 68370 RVA: 0x00271B8A File Offset: 0x0026FD8A
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

		// Token: 0x06010B13 RID: 68371 RVA: 0x00271BB4 File Offset: 0x0026FDB4
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

		// Token: 0x06010B14 RID: 68372 RVA: 0x00271BED File Offset: 0x0026FDED
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

		// Token: 0x06010B15 RID: 68373 RVA: 0x00271C1B File Offset: 0x0026FE1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010B16 RID: 68374 RVA: 0x00271C24 File Offset: 0x0026FE24
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleList_.AddEntriesFrom(ref input, PbGetRoleListNotify._repeated_roleList_codec);
				}
			}
		}

		// Token: 0x04006A17 RID: 27159
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A18 RID: 27160
		public const int RoleListFieldNumber = 7;

		// Token: 0x04006A19 RID: 27161
		private static readonly FieldCodec<roleInfo> _repeated_roleList_codec = FieldCodec.ForMessage<roleInfo>(58U, roleInfo.Parser);

		// Token: 0x04006A1A RID: 27162
		private readonly RepeatedField<roleInfo> roleList_ = new RepeatedField<roleInfo>();
	}
}
