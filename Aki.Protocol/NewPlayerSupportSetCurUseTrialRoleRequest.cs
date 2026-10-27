using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B23 RID: 2851
	[NetMessage(EMessageId.NewPlayerSupportSetCurUseTrialRoleRequest)]
	public sealed class NewPlayerSupportSetCurUseTrialRoleRequest : IMessage<NewPlayerSupportSetCurUseTrialRoleRequest>, IMessage, IEquatable<NewPlayerSupportSetCurUseTrialRoleRequest>, IDeepCloneable<NewPlayerSupportSetCurUseTrialRoleRequest>, IBufferMessage
	{
		// Token: 0x0600F784 RID: 63364 RVA: 0x00241838 File Offset: 0x0023FA38
		[NullableContext(1)]
		public static NewPlayerSupportSetCurUseTrialRoleRequest Create()
		{
			return new NewPlayerSupportSetCurUseTrialRoleRequest();
		}

		// Token: 0x1700326C RID: 12908
		// (get) Token: 0x0600F785 RID: 63365 RVA: 0x0024183F File Offset: 0x0023FA3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700326D RID: 12909
		// (get) Token: 0x0600F786 RID: 63366 RVA: 0x00241842 File Offset: 0x0023FA42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportSetCurUseTrialRoleRequest.Descriptor;
			}
		}

		// Token: 0x0600F787 RID: 63367 RVA: 0x00241849 File Offset: 0x0023FA49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportSetCurUseTrialRoleRequest()
		{
		}

		// Token: 0x0600F788 RID: 63368 RVA: 0x00241851 File Offset: 0x0023FA51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportSetCurUseTrialRoleRequest(NewPlayerSupportSetCurUseTrialRoleRequest other) : this()
		{
			this.trialRoleId_ = other.trialRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F789 RID: 63369 RVA: 0x00241876 File Offset: 0x0023FA76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportSetCurUseTrialRoleRequest Clone()
		{
			return new NewPlayerSupportSetCurUseTrialRoleRequest(this);
		}

		// Token: 0x1700326E RID: 12910
		// (get) Token: 0x0600F78A RID: 63370 RVA: 0x0024187E File Offset: 0x0023FA7E
		// (set) Token: 0x0600F78B RID: 63371 RVA: 0x00241886 File Offset: 0x0023FA86
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

		// Token: 0x0600F78C RID: 63372 RVA: 0x0024188F File Offset: 0x0023FA8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportSetCurUseTrialRoleRequest);
		}

		// Token: 0x0600F78D RID: 63373 RVA: 0x0024189D File Offset: 0x0023FA9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportSetCurUseTrialRoleRequest other)
		{
			return other != null && (other == this || (this.TrialRoleId == other.TrialRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F78E RID: 63374 RVA: 0x002418CC File Offset: 0x0023FACC
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

		// Token: 0x0600F78F RID: 63375 RVA: 0x0024190B File Offset: 0x0023FB0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F790 RID: 63376 RVA: 0x00241918 File Offset: 0x0023FB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F791 RID: 63377 RVA: 0x00241921 File Offset: 0x0023FB21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TrialRoleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TrialRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F792 RID: 63378 RVA: 0x00241954 File Offset: 0x0023FB54
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

		// Token: 0x0600F793 RID: 63379 RVA: 0x00241992 File Offset: 0x0023FB92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewPlayerSupportSetCurUseTrialRoleRequest other)
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

		// Token: 0x0600F794 RID: 63380 RVA: 0x002419C3 File Offset: 0x0023FBC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F795 RID: 63381 RVA: 0x002419CC File Offset: 0x0023FBCC
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TrialRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006352 RID: 25426
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006353 RID: 25427
		public const int TrialRoleIdFieldNumber = 3;

		// Token: 0x04006354 RID: 25428
		private int trialRoleId_;
	}
}
