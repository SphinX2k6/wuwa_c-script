using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200036C RID: 876
	[NetMessage(EMessageId.DangoBrawlRoleUnlockNotify)]
	public sealed class DangoBrawlRoleUnlockNotify : IMessage<DangoBrawlRoleUnlockNotify>, IMessage, IEquatable<DangoBrawlRoleUnlockNotify>, IDeepCloneable<DangoBrawlRoleUnlockNotify>, IBufferMessage
	{
		// Token: 0x06005777 RID: 22391 RVA: 0x000D5D03 File Offset: 0x000D3F03
		[NullableContext(1)]
		public static DangoBrawlRoleUnlockNotify Create()
		{
			return new DangoBrawlRoleUnlockNotify();
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x06005778 RID: 22392 RVA: 0x000D5D0A File Offset: 0x000D3F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x06005779 RID: 22393 RVA: 0x000D5D0D File Offset: 0x000D3F0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlRoleUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600577A RID: 22394 RVA: 0x000D5D14 File Offset: 0x000D3F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlRoleUnlockNotify()
		{
		}

		// Token: 0x0600577B RID: 22395 RVA: 0x000D5D27 File Offset: 0x000D3F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlRoleUnlockNotify(DangoBrawlRoleUnlockNotify other) : this()
		{
			this.roleIds_ = other.roleIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600577C RID: 22396 RVA: 0x000D5D51 File Offset: 0x000D3F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlRoleUnlockNotify Clone()
		{
			return new DangoBrawlRoleUnlockNotify(this);
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x0600577D RID: 22397 RVA: 0x000D5D59 File Offset: 0x000D3F59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x0600577E RID: 22398 RVA: 0x000D5D61 File Offset: 0x000D3F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlRoleUnlockNotify);
		}

		// Token: 0x0600577F RID: 22399 RVA: 0x000D5D6F File Offset: 0x000D3F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlRoleUnlockNotify other)
		{
			return other != null && (other == this || (this.roleIds_.Equals(other.roleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005780 RID: 22400 RVA: 0x000D5DA4 File Offset: 0x000D3FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005781 RID: 22401 RVA: 0x000D5DD8 File Offset: 0x000D3FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005782 RID: 22402 RVA: 0x000D5DE5 File Offset: 0x000D3FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005783 RID: 22403 RVA: 0x000D5DEE File Offset: 0x000D3FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleIds_.WriteTo(ref output, DangoBrawlRoleUnlockNotify._repeated_roleIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005784 RID: 22404 RVA: 0x000D5E18 File Offset: 0x000D4018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleIds_.CalculateSize(DangoBrawlRoleUnlockNotify._repeated_roleIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005785 RID: 22405 RVA: 0x000D5E51 File Offset: 0x000D4051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlRoleUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.roleIds_.Add(other.roleIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005786 RID: 22406 RVA: 0x000D5E7F File Offset: 0x000D407F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005787 RID: 22407 RVA: 0x000D5E88 File Offset: 0x000D4088
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
				if (num != 104U && num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleIds_.AddEntriesFrom(ref input, DangoBrawlRoleUnlockNotify._repeated_roleIds_codec);
				}
			}
		}

		// Token: 0x04003520 RID: 13600
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003521 RID: 13601
		public const int RoleIdsFieldNumber = 13;

		// Token: 0x04003522 RID: 13602
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04003523 RID: 13603
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();
	}
}
