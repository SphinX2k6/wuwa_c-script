using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000043 RID: 67
	[NetMessage(EMessageId.AbyssRoleAddNotify)]
	public sealed class AbyssRoleAddNotify : IMessage<AbyssRoleAddNotify>, IMessage, IEquatable<AbyssRoleAddNotify>, IDeepCloneable<AbyssRoleAddNotify>, IBufferMessage
	{
		// Token: 0x060013F9 RID: 5113 RVA: 0x00035DCD File Offset: 0x00033FCD
		[NullableContext(1)]
		public static AbyssRoleAddNotify Create()
		{
			return new AbyssRoleAddNotify();
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x00035DD4 File Offset: 0x00033FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x00035DD7 File Offset: 0x00033FD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssRoleAddNotify.Descriptor;
			}
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x00035DDE File Offset: 0x00033FDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleAddNotify()
		{
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00035DF1 File Offset: 0x00033FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleAddNotify(AbyssRoleAddNotify other) : this()
		{
			this.roleList_ = other.roleList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00035E1B File Offset: 0x0003401B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleAddNotify Clone()
		{
			return new AbyssRoleAddNotify(this);
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x00035E23 File Offset: 0x00034023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssRoleInfo> RoleList
		{
			get
			{
				return this.roleList_;
			}
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00035E2B File Offset: 0x0003402B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssRoleAddNotify);
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x00035E39 File Offset: 0x00034039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssRoleAddNotify other)
		{
			return other != null && (other == this || (this.roleList_.Equals(other.roleList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x00035E6C File Offset: 0x0003406C
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

		// Token: 0x06001403 RID: 5123 RVA: 0x00035EA0 File Offset: 0x000340A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x00035EAD File Offset: 0x000340AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x00035EB6 File Offset: 0x000340B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleList_.WriteTo(ref output, AbyssRoleAddNotify._repeated_roleList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x00035EE0 File Offset: 0x000340E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleList_.CalculateSize(AbyssRoleAddNotify._repeated_roleList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x00035F19 File Offset: 0x00034119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssRoleAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.roleList_.Add(other.roleList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x00035F47 File Offset: 0x00034147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x00035F50 File Offset: 0x00034150
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleList_.AddEntriesFrom(ref input, AbyssRoleAddNotify._repeated_roleList_codec);
				}
			}
		}

		// Token: 0x04002081 RID: 8321
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002082 RID: 8322
		public const int RoleListFieldNumber = 2;

		// Token: 0x04002083 RID: 8323
		private static readonly FieldCodec<AbyssRoleInfo> _repeated_roleList_codec = FieldCodec.ForMessage<AbyssRoleInfo>(18U, AbyssRoleInfo.Parser);

		// Token: 0x04002084 RID: 8324
		private readonly RepeatedField<AbyssRoleInfo> roleList_ = new RepeatedField<AbyssRoleInfo>();
	}
}
