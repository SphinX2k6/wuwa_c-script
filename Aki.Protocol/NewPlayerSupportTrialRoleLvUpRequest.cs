using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B16 RID: 2838
	[NetMessage(EMessageId.NewPlayerSupportTrialRoleLvUpRequest)]
	public sealed class NewPlayerSupportTrialRoleLvUpRequest : IMessage<NewPlayerSupportTrialRoleLvUpRequest>, IMessage, IEquatable<NewPlayerSupportTrialRoleLvUpRequest>, IDeepCloneable<NewPlayerSupportTrialRoleLvUpRequest>, IBufferMessage
	{
		// Token: 0x0600F6C2 RID: 63170 RVA: 0x0024037D File Offset: 0x0023E57D
		[NullableContext(1)]
		public static NewPlayerSupportTrialRoleLvUpRequest Create()
		{
			return new NewPlayerSupportTrialRoleLvUpRequest();
		}

		// Token: 0x17003242 RID: 12866
		// (get) Token: 0x0600F6C3 RID: 63171 RVA: 0x00240384 File Offset: 0x0023E584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003243 RID: 12867
		// (get) Token: 0x0600F6C4 RID: 63172 RVA: 0x00240387 File Offset: 0x0023E587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportTrialRoleLvUpRequest.Descriptor;
			}
		}

		// Token: 0x0600F6C5 RID: 63173 RVA: 0x0024038E File Offset: 0x0023E58E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportTrialRoleLvUpRequest()
		{
		}

		// Token: 0x0600F6C6 RID: 63174 RVA: 0x00240396 File Offset: 0x0023E596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportTrialRoleLvUpRequest(NewPlayerSupportTrialRoleLvUpRequest other) : this()
		{
			this.trialRoleId_ = other.trialRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F6C7 RID: 63175 RVA: 0x002403BB File Offset: 0x0023E5BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportTrialRoleLvUpRequest Clone()
		{
			return new NewPlayerSupportTrialRoleLvUpRequest(this);
		}

		// Token: 0x17003244 RID: 12868
		// (get) Token: 0x0600F6C8 RID: 63176 RVA: 0x002403C3 File Offset: 0x0023E5C3
		// (set) Token: 0x0600F6C9 RID: 63177 RVA: 0x002403CB File Offset: 0x0023E5CB
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

		// Token: 0x0600F6CA RID: 63178 RVA: 0x002403D4 File Offset: 0x0023E5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportTrialRoleLvUpRequest);
		}

		// Token: 0x0600F6CB RID: 63179 RVA: 0x002403E2 File Offset: 0x0023E5E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportTrialRoleLvUpRequest other)
		{
			return other != null && (other == this || (this.TrialRoleId == other.TrialRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F6CC RID: 63180 RVA: 0x00240410 File Offset: 0x0023E610
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

		// Token: 0x0600F6CD RID: 63181 RVA: 0x0024044F File Offset: 0x0023E64F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F6CE RID: 63182 RVA: 0x0024045C File Offset: 0x0023E65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F6CF RID: 63183 RVA: 0x00240465 File Offset: 0x0023E665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TrialRoleId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.TrialRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F6D0 RID: 63184 RVA: 0x00240498 File Offset: 0x0023E698
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

		// Token: 0x0600F6D1 RID: 63185 RVA: 0x002404D6 File Offset: 0x0023E6D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewPlayerSupportTrialRoleLvUpRequest other)
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

		// Token: 0x0600F6D2 RID: 63186 RVA: 0x00240507 File Offset: 0x0023E707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F6D3 RID: 63187 RVA: 0x00240510 File Offset: 0x0023E710
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TrialRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006377 RID: 25463
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006378 RID: 25464
		public const int TrialRoleIdFieldNumber = 12;

		// Token: 0x04006379 RID: 25465
		private int trialRoleId_;
	}
}
