using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200087E RID: 2174
	[NetMessage(EMessageId.KcpConvResponse)]
	public sealed class KcpConvResponse : IMessage<KcpConvResponse>, IMessage, IEquatable<KcpConvResponse>, IDeepCloneable<KcpConvResponse>, IBufferMessage
	{
		// Token: 0x0600C18E RID: 49550 RVA: 0x001CBD1B File Offset: 0x001C9F1B
		[NullableContext(1)]
		public static KcpConvResponse Create()
		{
			return new KcpConvResponse();
		}

		// Token: 0x17002720 RID: 10016
		// (get) Token: 0x0600C18F RID: 49551 RVA: 0x001CBD22 File Offset: 0x001C9F22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002721 RID: 10017
		// (get) Token: 0x0600C190 RID: 49552 RVA: 0x001CBD25 File Offset: 0x001C9F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KcpConvResponse.Descriptor;
			}
		}

		// Token: 0x0600C191 RID: 49553 RVA: 0x001CBD2C File Offset: 0x001C9F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KcpConvResponse()
		{
		}

		// Token: 0x0600C192 RID: 49554 RVA: 0x001CBD34 File Offset: 0x001C9F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KcpConvResponse(KcpConvResponse other) : this()
		{
			this.code_ = other.code_;
			this.conv_ = other.conv_;
			this.crcCheck_ = other.crcCheck_;
			this.kcpMtu_ = other.kcpMtu_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C193 RID: 49555 RVA: 0x001CBD88 File Offset: 0x001C9F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KcpConvResponse Clone()
		{
			return new KcpConvResponse(this);
		}

		// Token: 0x17002722 RID: 10018
		// (get) Token: 0x0600C194 RID: 49556 RVA: 0x001CBD90 File Offset: 0x001C9F90
		// (set) Token: 0x0600C195 RID: 49557 RVA: 0x001CBD98 File Offset: 0x001C9F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17002723 RID: 10019
		// (get) Token: 0x0600C196 RID: 49558 RVA: 0x001CBDA1 File Offset: 0x001C9FA1
		// (set) Token: 0x0600C197 RID: 49559 RVA: 0x001CBDA9 File Offset: 0x001C9FA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Conv
		{
			get
			{
				return this.conv_;
			}
			set
			{
				this.conv_ = value;
			}
		}

		// Token: 0x17002724 RID: 10020
		// (get) Token: 0x0600C198 RID: 49560 RVA: 0x001CBDB2 File Offset: 0x001C9FB2
		// (set) Token: 0x0600C199 RID: 49561 RVA: 0x001CBDBA File Offset: 0x001C9FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CrcCheck
		{
			get
			{
				return this.crcCheck_;
			}
			set
			{
				this.crcCheck_ = value;
			}
		}

		// Token: 0x17002725 RID: 10021
		// (get) Token: 0x0600C19A RID: 49562 RVA: 0x001CBDC3 File Offset: 0x001C9FC3
		// (set) Token: 0x0600C19B RID: 49563 RVA: 0x001CBDCB File Offset: 0x001C9FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int KcpMtu
		{
			get
			{
				return this.kcpMtu_;
			}
			set
			{
				this.kcpMtu_ = value;
			}
		}

		// Token: 0x0600C19C RID: 49564 RVA: 0x001CBDD4 File Offset: 0x001C9FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KcpConvResponse);
		}

		// Token: 0x0600C19D RID: 49565 RVA: 0x001CBDE4 File Offset: 0x001C9FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KcpConvResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Conv == other.Conv && this.CrcCheck == other.CrcCheck && this.KcpMtu == other.KcpMtu && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C19E RID: 49566 RVA: 0x001CBE50 File Offset: 0x001CA050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.Conv != 0U)
			{
				num ^= this.Conv.GetHashCode();
			}
			if (this.CrcCheck != 0)
			{
				num ^= this.CrcCheck.GetHashCode();
			}
			if (this.KcpMtu != 0)
			{
				num ^= this.KcpMtu.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C19F RID: 49567 RVA: 0x001CBEE0 File Offset: 0x001CA0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C1A0 RID: 49568 RVA: 0x001CBEED File Offset: 0x001CA0ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C1A1 RID: 49569 RVA: 0x001CBEF8 File Offset: 0x001CA0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Code);
			}
			if (this.Conv != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Conv);
			}
			if (this.CrcCheck != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CrcCheck);
			}
			if (this.KcpMtu != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.KcpMtu);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C1A2 RID: 49570 RVA: 0x001CBF88 File Offset: 0x001CA188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.Conv != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Conv);
			}
			if (this.CrcCheck != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CrcCheck);
			}
			if (this.KcpMtu != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.KcpMtu);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C1A3 RID: 49571 RVA: 0x001CC010 File Offset: 0x001CA210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KcpConvResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.Conv != 0U)
			{
				this.Conv = other.Conv;
			}
			if (other.CrcCheck != 0)
			{
				this.CrcCheck = other.CrcCheck;
			}
			if (other.KcpMtu != 0)
			{
				this.KcpMtu = other.KcpMtu;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C1A4 RID: 49572 RVA: 0x001CC088 File Offset: 0x001CA288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C1A5 RID: 49573 RVA: 0x001CC094 File Offset: 0x001CA294
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 16U)
					{
						this.Conv = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.CrcCheck = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.KcpMtu = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040053F1 RID: 21489
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053F2 RID: 21490
		public const int CodeFieldNumber = 1;

		// Token: 0x040053F3 RID: 21491
		private ErrorCode code_;

		// Token: 0x040053F4 RID: 21492
		public const int ConvFieldNumber = 2;

		// Token: 0x040053F5 RID: 21493
		private uint conv_;

		// Token: 0x040053F6 RID: 21494
		public const int CrcCheckFieldNumber = 3;

		// Token: 0x040053F7 RID: 21495
		private int crcCheck_;

		// Token: 0x040053F8 RID: 21496
		public const int KcpMtuFieldNumber = 4;

		// Token: 0x040053F9 RID: 21497
		private int kcpMtu_;
	}
}
