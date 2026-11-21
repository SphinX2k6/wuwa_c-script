using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B14 RID: 2836
	[NetMessage(EMessageId.NewPlayerSupportSetCurUseTrialRoleV2Request)]
	public sealed class NewPlayerSupportSetCurUseTrialRoleV2Request : IMessage<NewPlayerSupportSetCurUseTrialRoleV2Request>, IMessage, IEquatable<NewPlayerSupportSetCurUseTrialRoleV2Request>, IDeepCloneable<NewPlayerSupportSetCurUseTrialRoleV2Request>, IBufferMessage
	{
		// Token: 0x0600F696 RID: 63126 RVA: 0x0023FCCC File Offset: 0x0023DECC
		[NullableContext(1)]
		public static NewPlayerSupportSetCurUseTrialRoleV2Request Create()
		{
			return new NewPlayerSupportSetCurUseTrialRoleV2Request();
		}

		// Token: 0x17003238 RID: 12856
		// (get) Token: 0x0600F697 RID: 63127 RVA: 0x0023FCD3 File Offset: 0x0023DED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003239 RID: 12857
		// (get) Token: 0x0600F698 RID: 63128 RVA: 0x0023FCD6 File Offset: 0x0023DED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportSetCurUseTrialRoleV2Request.Descriptor;
			}
		}

		// Token: 0x0600F699 RID: 63129 RVA: 0x0023FCDD File Offset: 0x0023DEDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportSetCurUseTrialRoleV2Request()
		{
		}

		// Token: 0x0600F69A RID: 63130 RVA: 0x0023FCE5 File Offset: 0x0023DEE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportSetCurUseTrialRoleV2Request(NewPlayerSupportSetCurUseTrialRoleV2Request other) : this()
		{
			this.trialRoleId_ = other.trialRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F69B RID: 63131 RVA: 0x0023FD0A File Offset: 0x0023DF0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportSetCurUseTrialRoleV2Request Clone()
		{
			return new NewPlayerSupportSetCurUseTrialRoleV2Request(this);
		}

		// Token: 0x1700323A RID: 12858
		// (get) Token: 0x0600F69C RID: 63132 RVA: 0x0023FD12 File Offset: 0x0023DF12
		// (set) Token: 0x0600F69D RID: 63133 RVA: 0x0023FD1A File Offset: 0x0023DF1A
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

		// Token: 0x0600F69E RID: 63134 RVA: 0x0023FD23 File Offset: 0x0023DF23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportSetCurUseTrialRoleV2Request);
		}

		// Token: 0x0600F69F RID: 63135 RVA: 0x0023FD31 File Offset: 0x0023DF31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportSetCurUseTrialRoleV2Request other)
		{
			return other != null && (other == this || (this.TrialRoleId == other.TrialRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F6A0 RID: 63136 RVA: 0x0023FD60 File Offset: 0x0023DF60
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

		// Token: 0x0600F6A1 RID: 63137 RVA: 0x0023FD9F File Offset: 0x0023DF9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F6A2 RID: 63138 RVA: 0x0023FDAC File Offset: 0x0023DFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F6A3 RID: 63139 RVA: 0x0023FDB5 File Offset: 0x0023DFB5
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

		// Token: 0x0600F6A4 RID: 63140 RVA: 0x0023FDE8 File Offset: 0x0023DFE8
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

		// Token: 0x0600F6A5 RID: 63141 RVA: 0x0023FE26 File Offset: 0x0023E026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewPlayerSupportSetCurUseTrialRoleV2Request other)
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

		// Token: 0x0600F6A6 RID: 63142 RVA: 0x0023FE57 File Offset: 0x0023E057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F6A7 RID: 63143 RVA: 0x0023FE60 File Offset: 0x0023E060
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

		// Token: 0x04006369 RID: 25449
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400636A RID: 25450
		public const int TrialRoleIdFieldNumber = 3;

		// Token: 0x0400636B RID: 25451
		private int trialRoleId_;
	}
}
