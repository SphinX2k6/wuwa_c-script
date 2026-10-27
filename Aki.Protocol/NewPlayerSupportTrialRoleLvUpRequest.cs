using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B27 RID: 2855
	[NetMessage(EMessageId.NewPlayerSupportTrialRoleLvUpRequest)]
	public sealed class NewPlayerSupportTrialRoleLvUpRequest : IMessage<NewPlayerSupportTrialRoleLvUpRequest>, IMessage, IEquatable<NewPlayerSupportTrialRoleLvUpRequest>, IDeepCloneable<NewPlayerSupportTrialRoleLvUpRequest>, IBufferMessage
	{
		// Token: 0x0600F7DC RID: 63452 RVA: 0x00242599 File Offset: 0x00240799
		[NullableContext(1)]
		public static NewPlayerSupportTrialRoleLvUpRequest Create()
		{
			return new NewPlayerSupportTrialRoleLvUpRequest();
		}

		// Token: 0x17003280 RID: 12928
		// (get) Token: 0x0600F7DD RID: 63453 RVA: 0x002425A0 File Offset: 0x002407A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003281 RID: 12929
		// (get) Token: 0x0600F7DE RID: 63454 RVA: 0x002425A3 File Offset: 0x002407A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportTrialRoleLvUpRequest.Descriptor;
			}
		}

		// Token: 0x0600F7DF RID: 63455 RVA: 0x002425AA File Offset: 0x002407AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportTrialRoleLvUpRequest()
		{
		}

		// Token: 0x0600F7E0 RID: 63456 RVA: 0x002425B2 File Offset: 0x002407B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportTrialRoleLvUpRequest(NewPlayerSupportTrialRoleLvUpRequest other) : this()
		{
			this.trialRoleId_ = other.trialRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F7E1 RID: 63457 RVA: 0x002425D7 File Offset: 0x002407D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportTrialRoleLvUpRequest Clone()
		{
			return new NewPlayerSupportTrialRoleLvUpRequest(this);
		}

		// Token: 0x17003282 RID: 12930
		// (get) Token: 0x0600F7E2 RID: 63458 RVA: 0x002425DF File Offset: 0x002407DF
		// (set) Token: 0x0600F7E3 RID: 63459 RVA: 0x002425E7 File Offset: 0x002407E7
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

		// Token: 0x0600F7E4 RID: 63460 RVA: 0x002425F0 File Offset: 0x002407F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportTrialRoleLvUpRequest);
		}

		// Token: 0x0600F7E5 RID: 63461 RVA: 0x002425FE File Offset: 0x002407FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportTrialRoleLvUpRequest other)
		{
			return other != null && (other == this || (this.TrialRoleId == other.TrialRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F7E6 RID: 63462 RVA: 0x0024262C File Offset: 0x0024082C
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

		// Token: 0x0600F7E7 RID: 63463 RVA: 0x0024266B File Offset: 0x0024086B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F7E8 RID: 63464 RVA: 0x00242678 File Offset: 0x00240878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F7E9 RID: 63465 RVA: 0x00242681 File Offset: 0x00240881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TrialRoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TrialRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F7EA RID: 63466 RVA: 0x002426B4 File Offset: 0x002408B4
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

		// Token: 0x0600F7EB RID: 63467 RVA: 0x002426F2 File Offset: 0x002408F2
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

		// Token: 0x0600F7EC RID: 63468 RVA: 0x00242723 File Offset: 0x00240923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F7ED RID: 63469 RVA: 0x0024272C File Offset: 0x0024092C
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TrialRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400636E RID: 25454
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400636F RID: 25455
		public const int TrialRoleIdFieldNumber = 2;

		// Token: 0x04006370 RID: 25456
		private int trialRoleId_;
	}
}
