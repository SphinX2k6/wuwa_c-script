using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EDB RID: 3803
	[NetMessage(EMessageId.RegressTrialRoleUnlockNotify)]
	public sealed class RegressTrialRoleUnlockNotify : IMessage<RegressTrialRoleUnlockNotify>, IMessage, IEquatable<RegressTrialRoleUnlockNotify>, IDeepCloneable<RegressTrialRoleUnlockNotify>, IBufferMessage
	{
		// Token: 0x0601468D RID: 83597 RVA: 0x002F7D5A File Offset: 0x002F5F5A
		[NullableContext(1)]
		public static RegressTrialRoleUnlockNotify Create()
		{
			return new RegressTrialRoleUnlockNotify();
		}

		// Token: 0x170043E4 RID: 17380
		// (get) Token: 0x0601468E RID: 83598 RVA: 0x002F7D61 File Offset: 0x002F5F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043E5 RID: 17381
		// (get) Token: 0x0601468F RID: 83599 RVA: 0x002F7D64 File Offset: 0x002F5F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressTrialRoleUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06014690 RID: 83600 RVA: 0x002F7D6B File Offset: 0x002F5F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTrialRoleUnlockNotify()
		{
		}

		// Token: 0x06014691 RID: 83601 RVA: 0x002F7D7E File Offset: 0x002F5F7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTrialRoleUnlockNotify(RegressTrialRoleUnlockNotify other) : this()
		{
			this.roleId_ = other.roleId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014692 RID: 83602 RVA: 0x002F7DA8 File Offset: 0x002F5FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTrialRoleUnlockNotify Clone()
		{
			return new RegressTrialRoleUnlockNotify(this);
		}

		// Token: 0x170043E6 RID: 17382
		// (get) Token: 0x06014693 RID: 83603 RVA: 0x002F7DB0 File Offset: 0x002F5FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleId
		{
			get
			{
				return this.roleId_;
			}
		}

		// Token: 0x06014694 RID: 83604 RVA: 0x002F7DB8 File Offset: 0x002F5FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressTrialRoleUnlockNotify);
		}

		// Token: 0x06014695 RID: 83605 RVA: 0x002F7DC6 File Offset: 0x002F5FC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressTrialRoleUnlockNotify other)
		{
			return other != null && (other == this || (this.roleId_.Equals(other.roleId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014696 RID: 83606 RVA: 0x002F7DFC File Offset: 0x002F5FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014697 RID: 83607 RVA: 0x002F7E30 File Offset: 0x002F6030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014698 RID: 83608 RVA: 0x002F7E3D File Offset: 0x002F603D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014699 RID: 83609 RVA: 0x002F7E46 File Offset: 0x002F6046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleId_.WriteTo(ref output, RegressTrialRoleUnlockNotify._repeated_roleId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601469A RID: 83610 RVA: 0x002F7E70 File Offset: 0x002F6070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleId_.CalculateSize(RegressTrialRoleUnlockNotify._repeated_roleId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601469B RID: 83611 RVA: 0x002F7EA9 File Offset: 0x002F60A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressTrialRoleUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.roleId_.Add(other.roleId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601469C RID: 83612 RVA: 0x002F7ED7 File Offset: 0x002F60D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601469D RID: 83613 RVA: 0x002F7EE0 File Offset: 0x002F60E0
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
				if (num != 16U && num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleId_.AddEntriesFrom(ref input, RegressTrialRoleUnlockNotify._repeated_roleId_codec);
				}
			}
		}

		// Token: 0x04007C4E RID: 31822
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C4F RID: 31823
		public const int RoleIdFieldNumber = 2;

		// Token: 0x04007C50 RID: 31824
		private static readonly FieldCodec<int> _repeated_roleId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04007C51 RID: 31825
		private readonly RepeatedField<int> roleId_ = new RepeatedField<int>();
	}
}
