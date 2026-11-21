using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200149B RID: 5275
	[NetMessage(EMessageId.TrapDefenseGetRewardResponse)]
	public sealed class TrapDefenseGetRewardResponse : IMessage<TrapDefenseGetRewardResponse>, IMessage, IEquatable<TrapDefenseGetRewardResponse>, IDeepCloneable<TrapDefenseGetRewardResponse>, IBufferMessage
	{
		// Token: 0x0601C00E RID: 114702 RVA: 0x0041149D File Offset: 0x0040F69D
		[NullableContext(1)]
		public static TrapDefenseGetRewardResponse Create()
		{
			return new TrapDefenseGetRewardResponse();
		}

		// Token: 0x17005ECF RID: 24271
		// (get) Token: 0x0601C00F RID: 114703 RVA: 0x004114A4 File Offset: 0x0040F6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005ED0 RID: 24272
		// (get) Token: 0x0601C010 RID: 114704 RVA: 0x004114A7 File Offset: 0x0040F6A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseGetRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601C011 RID: 114705 RVA: 0x004114AE File Offset: 0x0040F6AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGetRewardResponse()
		{
		}

		// Token: 0x0601C012 RID: 114706 RVA: 0x004114B6 File Offset: 0x0040F6B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGetRewardResponse(TrapDefenseGetRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C013 RID: 114707 RVA: 0x004114DB File Offset: 0x0040F6DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGetRewardResponse Clone()
		{
			return new TrapDefenseGetRewardResponse(this);
		}

		// Token: 0x17005ED1 RID: 24273
		// (get) Token: 0x0601C014 RID: 114708 RVA: 0x004114E3 File Offset: 0x0040F6E3
		// (set) Token: 0x0601C015 RID: 114709 RVA: 0x004114EB File Offset: 0x0040F6EB
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

		// Token: 0x0601C016 RID: 114710 RVA: 0x004114F4 File Offset: 0x0040F6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseGetRewardResponse);
		}

		// Token: 0x0601C017 RID: 114711 RVA: 0x00411502 File Offset: 0x0040F702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseGetRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C018 RID: 114712 RVA: 0x00411530 File Offset: 0x0040F730
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

		// Token: 0x0601C019 RID: 114713 RVA: 0x00411575 File Offset: 0x0040F775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C01A RID: 114714 RVA: 0x00411582 File Offset: 0x0040F782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C01B RID: 114715 RVA: 0x0041158B File Offset: 0x0040F78B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C01C RID: 114716 RVA: 0x004115C0 File Offset: 0x0040F7C0
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

		// Token: 0x0601C01D RID: 114717 RVA: 0x004115FE File Offset: 0x0040F7FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseGetRewardResponse other)
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

		// Token: 0x0601C01E RID: 114718 RVA: 0x0041162F File Offset: 0x0040F82F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C01F RID: 114719 RVA: 0x00411638 File Offset: 0x0040F838
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A240 RID: 41536
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A241 RID: 41537
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400A242 RID: 41538
		private ErrorCode errorCode_;
	}
}
