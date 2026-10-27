using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B29 RID: 2857
	[NetMessage(EMessageId.NewPlayerSupportTrialRoleLvUpV2Request)]
	public sealed class NewPlayerSupportTrialRoleLvUpV2Request : IMessage<NewPlayerSupportTrialRoleLvUpV2Request>, IMessage, IEquatable<NewPlayerSupportTrialRoleLvUpV2Request>, IDeepCloneable<NewPlayerSupportTrialRoleLvUpV2Request>, IBufferMessage
	{
		// Token: 0x0600F804 RID: 63492 RVA: 0x00242B0A File Offset: 0x00240D0A
		[NullableContext(1)]
		public static NewPlayerSupportTrialRoleLvUpV2Request Create()
		{
			return new NewPlayerSupportTrialRoleLvUpV2Request();
		}

		// Token: 0x17003288 RID: 12936
		// (get) Token: 0x0600F805 RID: 63493 RVA: 0x00242B11 File Offset: 0x00240D11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003289 RID: 12937
		// (get) Token: 0x0600F806 RID: 63494 RVA: 0x00242B14 File Offset: 0x00240D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportTrialRoleLvUpV2Request.Descriptor;
			}
		}

		// Token: 0x0600F807 RID: 63495 RVA: 0x00242B1B File Offset: 0x00240D1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportTrialRoleLvUpV2Request()
		{
		}

		// Token: 0x0600F808 RID: 63496 RVA: 0x00242B23 File Offset: 0x00240D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportTrialRoleLvUpV2Request(NewPlayerSupportTrialRoleLvUpV2Request other) : this()
		{
			this.trialRoleId_ = other.trialRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F809 RID: 63497 RVA: 0x00242B48 File Offset: 0x00240D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportTrialRoleLvUpV2Request Clone()
		{
			return new NewPlayerSupportTrialRoleLvUpV2Request(this);
		}

		// Token: 0x1700328A RID: 12938
		// (get) Token: 0x0600F80A RID: 63498 RVA: 0x00242B50 File Offset: 0x00240D50
		// (set) Token: 0x0600F80B RID: 63499 RVA: 0x00242B58 File Offset: 0x00240D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TrialRoleId
		{
			get
			{
				return this.trialRoleId_;
			}
			set
			{
				this.trialRoleId_ = value;
			}
		}

		// Token: 0x0600F80C RID: 63500 RVA: 0x00242B61 File Offset: 0x00240D61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportTrialRoleLvUpV2Request);
		}

		// Token: 0x0600F80D RID: 63501 RVA: 0x00242B6F File Offset: 0x00240D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportTrialRoleLvUpV2Request other)
		{
			return other != null && (other == this || (this.TrialRoleId == other.TrialRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F80E RID: 63502 RVA: 0x00242BA0 File Offset: 0x00240DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TrialRoleId != 0)
			{
				num ^= this.TrialRoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F80F RID: 63503 RVA: 0x00242BDF File Offset: 0x00240DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F810 RID: 63504 RVA: 0x00242BEC File Offset: 0x00240DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F811 RID: 63505 RVA: 0x00242BF5 File Offset: 0x00240DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TrialRoleId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.TrialRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F812 RID: 63506 RVA: 0x00242C28 File Offset: 0x00240E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TrialRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TrialRoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F813 RID: 63507 RVA: 0x00242C66 File Offset: 0x00240E66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewPlayerSupportTrialRoleLvUpV2Request other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TrialRoleId != 0)
			{
				this.TrialRoleId = other.TrialRoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F814 RID: 63508 RVA: 0x00242C97 File Offset: 0x00240E97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F815 RID: 63509 RVA: 0x00242CA0 File Offset: 0x00240EA0
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TrialRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006378 RID: 25464
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006379 RID: 25465
		public const int TrialRoleIdFieldNumber = 13;

		// Token: 0x0400637A RID: 25466
		private int trialRoleId_;
	}
}
