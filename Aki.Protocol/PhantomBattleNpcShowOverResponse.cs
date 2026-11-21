using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C8C RID: 3212
	[NetMessage(EMessageId.PhantomBattleNpcShowOverResponse)]
	public sealed class PhantomBattleNpcShowOverResponse : IMessage<PhantomBattleNpcShowOverResponse>, IMessage, IEquatable<PhantomBattleNpcShowOverResponse>, IDeepCloneable<PhantomBattleNpcShowOverResponse>, IBufferMessage
	{
		// Token: 0x060116E5 RID: 71397 RVA: 0x0028E476 File Offset: 0x0028C676
		[NullableContext(1)]
		public static PhantomBattleNpcShowOverResponse Create()
		{
			return new PhantomBattleNpcShowOverResponse();
		}

		// Token: 0x170039BB RID: 14779
		// (get) Token: 0x060116E6 RID: 71398 RVA: 0x0028E47D File Offset: 0x0028C67D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039BC RID: 14780
		// (get) Token: 0x060116E7 RID: 71399 RVA: 0x0028E480 File Offset: 0x0028C680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleNpcShowOverResponse.Descriptor;
			}
		}

		// Token: 0x060116E8 RID: 71400 RVA: 0x0028E487 File Offset: 0x0028C687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleNpcShowOverResponse()
		{
		}

		// Token: 0x060116E9 RID: 71401 RVA: 0x0028E48F File Offset: 0x0028C68F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleNpcShowOverResponse(PhantomBattleNpcShowOverResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060116EA RID: 71402 RVA: 0x0028E4B4 File Offset: 0x0028C6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleNpcShowOverResponse Clone()
		{
			return new PhantomBattleNpcShowOverResponse(this);
		}

		// Token: 0x170039BD RID: 14781
		// (get) Token: 0x060116EB RID: 71403 RVA: 0x0028E4BC File Offset: 0x0028C6BC
		// (set) Token: 0x060116EC RID: 71404 RVA: 0x0028E4C4 File Offset: 0x0028C6C4
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

		// Token: 0x060116ED RID: 71405 RVA: 0x0028E4CD File Offset: 0x0028C6CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleNpcShowOverResponse);
		}

		// Token: 0x060116EE RID: 71406 RVA: 0x0028E4DB File Offset: 0x0028C6DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleNpcShowOverResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060116EF RID: 71407 RVA: 0x0028E50C File Offset: 0x0028C70C
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

		// Token: 0x060116F0 RID: 71408 RVA: 0x0028E551 File Offset: 0x0028C751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060116F1 RID: 71409 RVA: 0x0028E55E File Offset: 0x0028C75E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060116F2 RID: 71410 RVA: 0x0028E567 File Offset: 0x0028C767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060116F3 RID: 71411 RVA: 0x0028E59C File Offset: 0x0028C79C
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

		// Token: 0x060116F4 RID: 71412 RVA: 0x0028E5DA File Offset: 0x0028C7DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleNpcShowOverResponse other)
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

		// Token: 0x060116F5 RID: 71413 RVA: 0x0028E60B File Offset: 0x0028C80B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060116F6 RID: 71414 RVA: 0x0028E614 File Offset: 0x0028C814
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006E6D RID: 28269
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E6E RID: 28270
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04006E6F RID: 28271
		private ErrorCode errorCode_;
	}
}
