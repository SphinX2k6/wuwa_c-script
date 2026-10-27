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
		// Token: 0x060013CE RID: 5070 RVA: 0x00035815 File Offset: 0x00033A15
		[NullableContext(1)]
		public static AbyssRoleAddNotify Create()
		{
			return new AbyssRoleAddNotify();
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x0003581C File Offset: 0x00033A1C
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
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x0003581F File Offset: 0x00033A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssRoleAddNotify.Descriptor;
			}
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x00035826 File Offset: 0x00033A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleAddNotify()
		{
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x00035839 File Offset: 0x00033A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleAddNotify(AbyssRoleAddNotify other) : this()
		{
			this.roleList_ = other.roleList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x00035863 File Offset: 0x00033A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleAddNotify Clone()
		{
			return new AbyssRoleAddNotify(this);
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x0003586B File Offset: 0x00033A6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssRoleInfo> RoleList
		{
			get
			{
				return this.roleList_;
			}
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x00035873 File Offset: 0x00033A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssRoleAddNotify);
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x00035881 File Offset: 0x00033A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssRoleAddNotify other)
		{
			return other != null && (other == this || (this.roleList_.Equals(other.roleList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x000358B4 File Offset: 0x00033AB4
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

		// Token: 0x060013D8 RID: 5080 RVA: 0x000358E8 File Offset: 0x00033AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x000358F5 File Offset: 0x00033AF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x000358FE File Offset: 0x00033AFE
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

		// Token: 0x060013DB RID: 5083 RVA: 0x00035928 File Offset: 0x00033B28
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

		// Token: 0x060013DC RID: 5084 RVA: 0x00035961 File Offset: 0x00033B61
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

		// Token: 0x060013DD RID: 5085 RVA: 0x0003598F File Offset: 0x00033B8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x00035998 File Offset: 0x00033B98
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleList_.AddEntriesFrom(ref input, AbyssRoleAddNotify._repeated_roleList_codec);
				}
			}
		}

		// Token: 0x0400202B RID: 8235
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400202C RID: 8236
		public const int RoleListFieldNumber = 1;

		// Token: 0x0400202D RID: 8237
		private static readonly FieldCodec<AbyssRoleInfo> _repeated_roleList_codec = FieldCodec.ForMessage<AbyssRoleInfo>(10U, AbyssRoleInfo.Parser);

		// Token: 0x0400202E RID: 8238
		private readonly RepeatedField<AbyssRoleInfo> roleList_ = new RepeatedField<AbyssRoleInfo>();
	}
}
