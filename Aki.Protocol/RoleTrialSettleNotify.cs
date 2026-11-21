using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001107 RID: 4359
	[NetMessage(EMessageId.RoleTrialSettleNotify)]
	public sealed class RoleTrialSettleNotify : IMessage<RoleTrialSettleNotify>, IMessage, IEquatable<RoleTrialSettleNotify>, IDeepCloneable<RoleTrialSettleNotify>, IBufferMessage
	{
		// Token: 0x060174CB RID: 95435 RVA: 0x0036402A File Offset: 0x0036222A
		[NullableContext(1)]
		public static RoleTrialSettleNotify Create()
		{
			return new RoleTrialSettleNotify();
		}

		// Token: 0x17004E48 RID: 20040
		// (get) Token: 0x060174CC RID: 95436 RVA: 0x00364031 File Offset: 0x00362231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E49 RID: 20041
		// (get) Token: 0x060174CD RID: 95437 RVA: 0x00364034 File Offset: 0x00362234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTrialSettleNotify.Descriptor;
			}
		}

		// Token: 0x060174CE RID: 95438 RVA: 0x0036403B File Offset: 0x0036223B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialSettleNotify()
		{
		}

		// Token: 0x060174CF RID: 95439 RVA: 0x00364043 File Offset: 0x00362243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialSettleNotify(RoleTrialSettleNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060174D0 RID: 95440 RVA: 0x00364068 File Offset: 0x00362268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialSettleNotify Clone()
		{
			return new RoleTrialSettleNotify(this);
		}

		// Token: 0x17004E4A RID: 20042
		// (get) Token: 0x060174D1 RID: 95441 RVA: 0x00364070 File Offset: 0x00362270
		// (set) Token: 0x060174D2 RID: 95442 RVA: 0x00364078 File Offset: 0x00362278
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

		// Token: 0x060174D3 RID: 95443 RVA: 0x00364081 File Offset: 0x00362281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTrialSettleNotify);
		}

		// Token: 0x060174D4 RID: 95444 RVA: 0x0036408F File Offset: 0x0036228F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTrialSettleNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060174D5 RID: 95445 RVA: 0x003640C0 File Offset: 0x003622C0
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

		// Token: 0x060174D6 RID: 95446 RVA: 0x00364105 File Offset: 0x00362305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060174D7 RID: 95447 RVA: 0x00364112 File Offset: 0x00362312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060174D8 RID: 95448 RVA: 0x0036411B File Offset: 0x0036231B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060174D9 RID: 95449 RVA: 0x0036414C File Offset: 0x0036234C
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

		// Token: 0x060174DA RID: 95450 RVA: 0x0036418A File Offset: 0x0036238A
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

		// Token: 0x060174DB RID: 95451 RVA: 0x003641BB File Offset: 0x003623BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060174DC RID: 95452 RVA: 0x003641C4 File Offset: 0x003623C4
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008B49 RID: 35657
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B4A RID: 35658
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04008B4B RID: 35659
		private ErrorCode errorCode_;
	}
}
