using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000045 RID: 69
	[NetMessage(EMessageId.AbyssRoleInfoUpdateNotify)]
	public sealed class AbyssRoleInfoUpdateNotify : IMessage<AbyssRoleInfoUpdateNotify>, IMessage, IEquatable<AbyssRoleInfoUpdateNotify>, IDeepCloneable<AbyssRoleInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x060013F7 RID: 5111 RVA: 0x00035D73 File Offset: 0x00033F73
		[NullableContext(1)]
		public static AbyssRoleInfoUpdateNotify Create()
		{
			return new AbyssRoleInfoUpdateNotify();
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x00035D7A File Offset: 0x00033F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x00035D7D File Offset: 0x00033F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssRoleInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x00035D84 File Offset: 0x00033F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleInfoUpdateNotify()
		{
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x00035D97 File Offset: 0x00033F97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleInfoUpdateNotify(AbyssRoleInfoUpdateNotify other) : this()
		{
			this.roleList_ = other.roleList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x00035DC1 File Offset: 0x00033FC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleInfoUpdateNotify Clone()
		{
			return new AbyssRoleInfoUpdateNotify(this);
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x00035DC9 File Offset: 0x00033FC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssRoleInfo> RoleList
		{
			get
			{
				return this.roleList_;
			}
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00035DD1 File Offset: 0x00033FD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssRoleInfoUpdateNotify);
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00035DDF File Offset: 0x00033FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssRoleInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.roleList_.Equals(other.roleList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00035E14 File Offset: 0x00034014
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

		// Token: 0x06001401 RID: 5121 RVA: 0x00035E48 File Offset: 0x00034048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x00035E55 File Offset: 0x00034055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x00035E5E File Offset: 0x0003405E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleList_.WriteTo(ref output, AbyssRoleInfoUpdateNotify._repeated_roleList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x00035E88 File Offset: 0x00034088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleList_.CalculateSize(AbyssRoleInfoUpdateNotify._repeated_roleList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x00035EC1 File Offset: 0x000340C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssRoleInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.roleList_.Add(other.roleList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x00035EEF File Offset: 0x000340EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x00035EF8 File Offset: 0x000340F8
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleList_.AddEntriesFrom(ref input, AbyssRoleInfoUpdateNotify._repeated_roleList_codec);
				}
			}
		}

		// Token: 0x04002038 RID: 8248
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002039 RID: 8249
		public const int RoleListFieldNumber = 9;

		// Token: 0x0400203A RID: 8250
		private static readonly FieldCodec<AbyssRoleInfo> _repeated_roleList_codec = FieldCodec.ForMessage<AbyssRoleInfo>(74U, AbyssRoleInfo.Parser);

		// Token: 0x0400203B RID: 8251
		private readonly RepeatedField<AbyssRoleInfo> roleList_ = new RepeatedField<AbyssRoleInfo>();
	}
}
