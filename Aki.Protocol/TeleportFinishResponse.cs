using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013AD RID: 5037
	[NetMessage(EMessageId.TeleportFinishResponse)]
	public sealed class TeleportFinishResponse : IMessage<TeleportFinishResponse>, IMessage, IEquatable<TeleportFinishResponse>, IDeepCloneable<TeleportFinishResponse>, IBufferMessage
	{
		// Token: 0x0601ACE4 RID: 109796 RVA: 0x003E7362 File Offset: 0x003E5562
		[NullableContext(1)]
		public static TeleportFinishResponse Create()
		{
			return new TeleportFinishResponse();
		}

		// Token: 0x17005AC1 RID: 23233
		// (get) Token: 0x0601ACE5 RID: 109797 RVA: 0x003E7369 File Offset: 0x003E5569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AC2 RID: 23234
		// (get) Token: 0x0601ACE6 RID: 109798 RVA: 0x003E736C File Offset: 0x003E556C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportFinishResponse.Descriptor;
			}
		}

		// Token: 0x0601ACE7 RID: 109799 RVA: 0x003E7373 File Offset: 0x003E5573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFinishResponse()
		{
		}

		// Token: 0x0601ACE8 RID: 109800 RVA: 0x003E737B File Offset: 0x003E557B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFinishResponse(TeleportFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ACE9 RID: 109801 RVA: 0x003E73A0 File Offset: 0x003E55A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFinishResponse Clone()
		{
			return new TeleportFinishResponse(this);
		}

		// Token: 0x17005AC3 RID: 23235
		// (get) Token: 0x0601ACEA RID: 109802 RVA: 0x003E73A8 File Offset: 0x003E55A8
		// (set) Token: 0x0601ACEB RID: 109803 RVA: 0x003E73B0 File Offset: 0x003E55B0
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

		// Token: 0x0601ACEC RID: 109804 RVA: 0x003E73B9 File Offset: 0x003E55B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportFinishResponse);
		}

		// Token: 0x0601ACED RID: 109805 RVA: 0x003E73C7 File Offset: 0x003E55C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ACEE RID: 109806 RVA: 0x003E73F8 File Offset: 0x003E55F8
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

		// Token: 0x0601ACEF RID: 109807 RVA: 0x003E743D File Offset: 0x003E563D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ACF0 RID: 109808 RVA: 0x003E744A File Offset: 0x003E564A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ACF1 RID: 109809 RVA: 0x003E7453 File Offset: 0x003E5653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ACF2 RID: 109810 RVA: 0x003E7488 File Offset: 0x003E5688
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

		// Token: 0x0601ACF3 RID: 109811 RVA: 0x003E74C6 File Offset: 0x003E56C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportFinishResponse other)
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

		// Token: 0x0601ACF4 RID: 109812 RVA: 0x003E74F7 File Offset: 0x003E56F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ACF5 RID: 109813 RVA: 0x003E7500 File Offset: 0x003E5700
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009CD3 RID: 40147
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CD4 RID: 40148
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04009CD5 RID: 40149
		private ErrorCode errorCode_;
	}
}
