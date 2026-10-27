using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010CD RID: 4301
	[NetMessage(EMessageId.RoleTrialSettleNotify)]
	public sealed class RoleTrialSettleNotify : IMessage<RoleTrialSettleNotify>, IMessage, IEquatable<RoleTrialSettleNotify>, IDeepCloneable<RoleTrialSettleNotify>, IBufferMessage
	{
		// Token: 0x06016F2C RID: 93996 RVA: 0x00354D6E File Offset: 0x00352F6E
		[NullableContext(1)]
		public static RoleTrialSettleNotify Create()
		{
			return new RoleTrialSettleNotify();
		}

		// Token: 0x17004CDD RID: 19677
		// (get) Token: 0x06016F2D RID: 93997 RVA: 0x00354D75 File Offset: 0x00352F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CDE RID: 19678
		// (get) Token: 0x06016F2E RID: 93998 RVA: 0x00354D78 File Offset: 0x00352F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTrialSettleNotify.Descriptor;
			}
		}

		// Token: 0x06016F2F RID: 93999 RVA: 0x00354D7F File Offset: 0x00352F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialSettleNotify()
		{
		}

		// Token: 0x06016F30 RID: 94000 RVA: 0x00354D87 File Offset: 0x00352F87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialSettleNotify(RoleTrialSettleNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016F31 RID: 94001 RVA: 0x00354DAC File Offset: 0x00352FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialSettleNotify Clone()
		{
			return new RoleTrialSettleNotify(this);
		}

		// Token: 0x17004CDF RID: 19679
		// (get) Token: 0x06016F32 RID: 94002 RVA: 0x00354DB4 File Offset: 0x00352FB4
		// (set) Token: 0x06016F33 RID: 94003 RVA: 0x00354DBC File Offset: 0x00352FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x06016F34 RID: 94004 RVA: 0x00354DC5 File Offset: 0x00352FC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTrialSettleNotify);
		}

		// Token: 0x06016F35 RID: 94005 RVA: 0x00354DD3 File Offset: 0x00352FD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTrialSettleNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016F36 RID: 94006 RVA: 0x00354E04 File Offset: 0x00353004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016F37 RID: 94007 RVA: 0x00354E49 File Offset: 0x00353049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016F38 RID: 94008 RVA: 0x00354E56 File Offset: 0x00353056
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016F39 RID: 94009 RVA: 0x00354E5F File Offset: 0x0035305F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016F3A RID: 94010 RVA: 0x00354E94 File Offset: 0x00353094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016F3B RID: 94011 RVA: 0x00354ED2 File Offset: 0x003530D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTrialSettleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016F3C RID: 94012 RVA: 0x00354F03 File Offset: 0x00353103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016F3D RID: 94013 RVA: 0x00354F0C File Offset: 0x0035310C
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040088B8 RID: 35000
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088B9 RID: 35001
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x040088BA RID: 35002
		private ErrorCode errorCode_;
	}
}
