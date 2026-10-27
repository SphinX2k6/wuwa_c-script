using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EEB RID: 3819
	[NetMessage(EMessageId.RegressTrialRoleUnlockNotify)]
	public sealed class RegressTrialRoleUnlockNotify : IMessage<RegressTrialRoleUnlockNotify>, IMessage, IEquatable<RegressTrialRoleUnlockNotify>, IDeepCloneable<RegressTrialRoleUnlockNotify>, IBufferMessage
	{
		// Token: 0x06014772 RID: 83826 RVA: 0x002F940E File Offset: 0x002F760E
		[NullableContext(1)]
		public static RegressTrialRoleUnlockNotify Create()
		{
			return new RegressTrialRoleUnlockNotify();
		}

		// Token: 0x1700440E RID: 17422
		// (get) Token: 0x06014773 RID: 83827 RVA: 0x002F9415 File Offset: 0x002F7615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700440F RID: 17423
		// (get) Token: 0x06014774 RID: 83828 RVA: 0x002F9418 File Offset: 0x002F7618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressTrialRoleUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06014775 RID: 83829 RVA: 0x002F941F File Offset: 0x002F761F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTrialRoleUnlockNotify()
		{
		}

		// Token: 0x06014776 RID: 83830 RVA: 0x002F9432 File Offset: 0x002F7632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTrialRoleUnlockNotify(RegressTrialRoleUnlockNotify other) : this()
		{
			this.roleId_ = other.roleId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014777 RID: 83831 RVA: 0x002F945C File Offset: 0x002F765C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTrialRoleUnlockNotify Clone()
		{
			return new RegressTrialRoleUnlockNotify(this);
		}

		// Token: 0x17004410 RID: 17424
		// (get) Token: 0x06014778 RID: 83832 RVA: 0x002F9464 File Offset: 0x002F7664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleId
		{
			get
			{
				return this.roleId_;
			}
		}

		// Token: 0x06014779 RID: 83833 RVA: 0x002F946C File Offset: 0x002F766C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressTrialRoleUnlockNotify);
		}

		// Token: 0x0601477A RID: 83834 RVA: 0x002F947A File Offset: 0x002F767A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressTrialRoleUnlockNotify other)
		{
			return other != null && (other == this || (this.roleId_.Equals(other.roleId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601477B RID: 83835 RVA: 0x002F94B0 File Offset: 0x002F76B0
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

		// Token: 0x0601477C RID: 83836 RVA: 0x002F94E4 File Offset: 0x002F76E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601477D RID: 83837 RVA: 0x002F94F1 File Offset: 0x002F76F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601477E RID: 83838 RVA: 0x002F94FA File Offset: 0x002F76FA
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

		// Token: 0x0601477F RID: 83839 RVA: 0x002F9524 File Offset: 0x002F7724
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

		// Token: 0x06014780 RID: 83840 RVA: 0x002F955D File Offset: 0x002F775D
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

		// Token: 0x06014781 RID: 83841 RVA: 0x002F958B File Offset: 0x002F778B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014782 RID: 83842 RVA: 0x002F9594 File Offset: 0x002F7794
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
					this.roleId_.AddEntriesFrom(ref input, RegressTrialRoleUnlockNotify._repeated_roleId_codec);
				}
			}
		}

		// Token: 0x04007C24 RID: 31780
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C25 RID: 31781
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04007C26 RID: 31782
		private static readonly FieldCodec<int> _repeated_roleId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04007C27 RID: 31783
		private readonly RepeatedField<int> roleId_ = new RepeatedField<int>();
	}
}
