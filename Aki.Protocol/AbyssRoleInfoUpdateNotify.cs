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
		// Token: 0x06001422 RID: 5154 RVA: 0x0003632B File Offset: 0x0003452B
		[NullableContext(1)]
		public static AbyssRoleInfoUpdateNotify Create()
		{
			return new AbyssRoleInfoUpdateNotify();
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06001423 RID: 5155 RVA: 0x00036332 File Offset: 0x00034532
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
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x00036335 File Offset: 0x00034535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssRoleInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x0003633C File Offset: 0x0003453C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleInfoUpdateNotify()
		{
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x0003634F File Offset: 0x0003454F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleInfoUpdateNotify(AbyssRoleInfoUpdateNotify other) : this()
		{
			this.roleList_ = other.roleList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x00036379 File Offset: 0x00034579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleInfoUpdateNotify Clone()
		{
			return new AbyssRoleInfoUpdateNotify(this);
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x00036381 File Offset: 0x00034581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssRoleInfo> RoleList
		{
			get
			{
				return this.roleList_;
			}
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x00036389 File Offset: 0x00034589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssRoleInfoUpdateNotify);
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x00036397 File Offset: 0x00034597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssRoleInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.roleList_.Equals(other.roleList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x000363CC File Offset: 0x000345CC
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

		// Token: 0x0600142C RID: 5164 RVA: 0x00036400 File Offset: 0x00034600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x0003640D File Offset: 0x0003460D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x00036416 File Offset: 0x00034616
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

		// Token: 0x0600142F RID: 5167 RVA: 0x00036440 File Offset: 0x00034640
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

		// Token: 0x06001430 RID: 5168 RVA: 0x00036479 File Offset: 0x00034679
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

		// Token: 0x06001431 RID: 5169 RVA: 0x000364A7 File Offset: 0x000346A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x000364B0 File Offset: 0x000346B0
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleList_.AddEntriesFrom(ref input, AbyssRoleInfoUpdateNotify._repeated_roleList_codec);
				}
			}
		}

		// Token: 0x0400208E RID: 8334
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400208F RID: 8335
		public const int RoleListFieldNumber = 13;

		// Token: 0x04002090 RID: 8336
		private static readonly FieldCodec<AbyssRoleInfo> _repeated_roleList_codec = FieldCodec.ForMessage<AbyssRoleInfo>(106U, AbyssRoleInfo.Parser);

		// Token: 0x04002091 RID: 8337
		private readonly RepeatedField<AbyssRoleInfo> roleList_ = new RepeatedField<AbyssRoleInfo>();
	}
}
