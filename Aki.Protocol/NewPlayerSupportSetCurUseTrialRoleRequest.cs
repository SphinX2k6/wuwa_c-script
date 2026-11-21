using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B12 RID: 2834
	[NetMessage(EMessageId.NewPlayerSupportSetCurUseTrialRoleRequest)]
	public sealed class NewPlayerSupportSetCurUseTrialRoleRequest : IMessage<NewPlayerSupportSetCurUseTrialRoleRequest>, IMessage, IEquatable<NewPlayerSupportSetCurUseTrialRoleRequest>, IDeepCloneable<NewPlayerSupportSetCurUseTrialRoleRequest>, IBufferMessage
	{
		// Token: 0x0600F66A RID: 63082 RVA: 0x0023F620 File Offset: 0x0023D820
		[NullableContext(1)]
		public static NewPlayerSupportSetCurUseTrialRoleRequest Create()
		{
			return new NewPlayerSupportSetCurUseTrialRoleRequest();
		}

		// Token: 0x1700322E RID: 12846
		// (get) Token: 0x0600F66B RID: 63083 RVA: 0x0023F627 File Offset: 0x0023D827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700322F RID: 12847
		// (get) Token: 0x0600F66C RID: 63084 RVA: 0x0023F62A File Offset: 0x0023D82A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportSetCurUseTrialRoleRequest.Descriptor;
			}
		}

		// Token: 0x0600F66D RID: 63085 RVA: 0x0023F631 File Offset: 0x0023D831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportSetCurUseTrialRoleRequest()
		{
		}

		// Token: 0x0600F66E RID: 63086 RVA: 0x0023F639 File Offset: 0x0023D839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportSetCurUseTrialRoleRequest(NewPlayerSupportSetCurUseTrialRoleRequest other) : this()
		{
			this.trialRoleId_ = other.trialRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F66F RID: 63087 RVA: 0x0023F65E File Offset: 0x0023D85E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportSetCurUseTrialRoleRequest Clone()
		{
			return new NewPlayerSupportSetCurUseTrialRoleRequest(this);
		}

		// Token: 0x17003230 RID: 12848
		// (get) Token: 0x0600F670 RID: 63088 RVA: 0x0023F666 File Offset: 0x0023D866
		// (set) Token: 0x0600F671 RID: 63089 RVA: 0x0023F66E File Offset: 0x0023D86E
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

		// Token: 0x0600F672 RID: 63090 RVA: 0x0023F677 File Offset: 0x0023D877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportSetCurUseTrialRoleRequest);
		}

		// Token: 0x0600F673 RID: 63091 RVA: 0x0023F685 File Offset: 0x0023D885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportSetCurUseTrialRoleRequest other)
		{
			return other != null && (other == this || (this.TrialRoleId == other.TrialRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F674 RID: 63092 RVA: 0x0023F6B4 File Offset: 0x0023D8B4
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

		// Token: 0x0600F675 RID: 63093 RVA: 0x0023F6F3 File Offset: 0x0023D8F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F676 RID: 63094 RVA: 0x0023F700 File Offset: 0x0023D900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F677 RID: 63095 RVA: 0x0023F709 File Offset: 0x0023D909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TrialRoleId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TrialRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F678 RID: 63096 RVA: 0x0023F73C File Offset: 0x0023D93C
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

		// Token: 0x0600F679 RID: 63097 RVA: 0x0023F77A File Offset: 0x0023D97A
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

		// Token: 0x0600F67A RID: 63098 RVA: 0x0023F7AB File Offset: 0x0023D9AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F67B RID: 63099 RVA: 0x0023F7B4 File Offset: 0x0023D9B4
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TrialRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400635B RID: 25435
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400635C RID: 25436
		public const int TrialRoleIdFieldNumber = 4;

		// Token: 0x0400635D RID: 25437
		private int trialRoleId_;
	}
}
