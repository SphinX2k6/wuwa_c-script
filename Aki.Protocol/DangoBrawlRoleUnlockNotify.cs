using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000364 RID: 868
	[NetMessage(EMessageId.DangoBrawlRoleUnlockNotify)]
	public sealed class DangoBrawlRoleUnlockNotify : IMessage<DangoBrawlRoleUnlockNotify>, IMessage, IEquatable<DangoBrawlRoleUnlockNotify>, IDeepCloneable<DangoBrawlRoleUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600568A RID: 22154 RVA: 0x000D367B File Offset: 0x000D187B
		[NullableContext(1)]
		public static DangoBrawlRoleUnlockNotify Create()
		{
			return new DangoBrawlRoleUnlockNotify();
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x0600568B RID: 22155 RVA: 0x000D3682 File Offset: 0x000D1882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x0600568C RID: 22156 RVA: 0x000D3685 File Offset: 0x000D1885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlRoleUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600568D RID: 22157 RVA: 0x000D368C File Offset: 0x000D188C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlRoleUnlockNotify()
		{
		}

		// Token: 0x0600568E RID: 22158 RVA: 0x000D369F File Offset: 0x000D189F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlRoleUnlockNotify(DangoBrawlRoleUnlockNotify other) : this()
		{
			this.roleIds_ = other.roleIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600568F RID: 22159 RVA: 0x000D36C9 File Offset: 0x000D18C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlRoleUnlockNotify Clone()
		{
			return new DangoBrawlRoleUnlockNotify(this);
		}

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x06005690 RID: 22160 RVA: 0x000D36D1 File Offset: 0x000D18D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x06005691 RID: 22161 RVA: 0x000D36D9 File Offset: 0x000D18D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlRoleUnlockNotify);
		}

		// Token: 0x06005692 RID: 22162 RVA: 0x000D36E7 File Offset: 0x000D18E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlRoleUnlockNotify other)
		{
			return other != null && (other == this || (this.roleIds_.Equals(other.roleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005693 RID: 22163 RVA: 0x000D371C File Offset: 0x000D191C
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

		// Token: 0x06005694 RID: 22164 RVA: 0x000D3750 File Offset: 0x000D1950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005695 RID: 22165 RVA: 0x000D375D File Offset: 0x000D195D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005696 RID: 22166 RVA: 0x000D3766 File Offset: 0x000D1966
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

		// Token: 0x06005697 RID: 22167 RVA: 0x000D3790 File Offset: 0x000D1990
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

		// Token: 0x06005698 RID: 22168 RVA: 0x000D37C9 File Offset: 0x000D19C9
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

		// Token: 0x06005699 RID: 22169 RVA: 0x000D37F7 File Offset: 0x000D19F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600569A RID: 22170 RVA: 0x000D3800 File Offset: 0x000D1A00
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleIds_.AddEntriesFrom(ref input, DangoBrawlRoleUnlockNotify._repeated_roleIds_codec);
				}
			}
		}

		// Token: 0x04003484 RID: 13444
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003485 RID: 13445
		public const int RoleIdsFieldNumber = 1;

		// Token: 0x04003486 RID: 13446
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04003487 RID: 13447
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();
	}
}
