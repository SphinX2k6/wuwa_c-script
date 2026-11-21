using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200086D RID: 2157
	[NetMessage(EMessageId.KcpConvResponse)]
	public sealed class KcpConvResponse : IMessage<KcpConvResponse>, IMessage, IEquatable<KcpConvResponse>, IDeepCloneable<KcpConvResponse>, IBufferMessage
	{
		// Token: 0x0600C072 RID: 49266 RVA: 0x001C9A33 File Offset: 0x001C7C33
		[NullableContext(1)]
		public static KcpConvResponse Create()
		{
			return new KcpConvResponse();
		}

		// Token: 0x170026E1 RID: 9953
		// (get) Token: 0x0600C073 RID: 49267 RVA: 0x001C9A3A File Offset: 0x001C7C3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026E2 RID: 9954
		// (get) Token: 0x0600C074 RID: 49268 RVA: 0x001C9A3D File Offset: 0x001C7C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KcpConvResponse.Descriptor;
			}
		}

		// Token: 0x0600C075 RID: 49269 RVA: 0x001C9A44 File Offset: 0x001C7C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KcpConvResponse()
		{
		}

		// Token: 0x0600C076 RID: 49270 RVA: 0x001C9A4C File Offset: 0x001C7C4C
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

		// Token: 0x0600C077 RID: 49271 RVA: 0x001C9AA0 File Offset: 0x001C7CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KcpConvResponse Clone()
		{
			return new KcpConvResponse(this);
		}

		// Token: 0x170026E3 RID: 9955
		// (get) Token: 0x0600C078 RID: 49272 RVA: 0x001C9AA8 File Offset: 0x001C7CA8
		// (set) Token: 0x0600C079 RID: 49273 RVA: 0x001C9AB0 File Offset: 0x001C7CB0
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

		// Token: 0x170026E4 RID: 9956
		// (get) Token: 0x0600C07A RID: 49274 RVA: 0x001C9AB9 File Offset: 0x001C7CB9
		// (set) Token: 0x0600C07B RID: 49275 RVA: 0x001C9AC1 File Offset: 0x001C7CC1
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

		// Token: 0x170026E5 RID: 9957
		// (get) Token: 0x0600C07C RID: 49276 RVA: 0x001C9ACA File Offset: 0x001C7CCA
		// (set) Token: 0x0600C07D RID: 49277 RVA: 0x001C9AD2 File Offset: 0x001C7CD2
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

		// Token: 0x170026E6 RID: 9958
		// (get) Token: 0x0600C07E RID: 49278 RVA: 0x001C9ADB File Offset: 0x001C7CDB
		// (set) Token: 0x0600C07F RID: 49279 RVA: 0x001C9AE3 File Offset: 0x001C7CE3
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

		// Token: 0x0600C080 RID: 49280 RVA: 0x001C9AEC File Offset: 0x001C7CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KcpConvResponse);
		}

		// Token: 0x0600C081 RID: 49281 RVA: 0x001C9AFC File Offset: 0x001C7CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KcpConvResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Conv == other.Conv && this.CrcCheck == other.CrcCheck && this.KcpMtu == other.KcpMtu && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C082 RID: 49282 RVA: 0x001C9B68 File Offset: 0x001C7D68
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

		// Token: 0x0600C083 RID: 49283 RVA: 0x001C9BF8 File Offset: 0x001C7DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C084 RID: 49284 RVA: 0x001C9C05 File Offset: 0x001C7E05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C085 RID: 49285 RVA: 0x001C9C10 File Offset: 0x001C7E10
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

		// Token: 0x0600C086 RID: 49286 RVA: 0x001C9CA0 File Offset: 0x001C7EA0
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

		// Token: 0x0600C087 RID: 49287 RVA: 0x001C9D28 File Offset: 0x001C7F28
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

		// Token: 0x0600C088 RID: 49288 RVA: 0x001C9DA0 File Offset: 0x001C7FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C089 RID: 49289 RVA: 0x001C9DAC File Offset: 0x001C7FAC
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

		// Token: 0x040053F8 RID: 21496
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053F9 RID: 21497
		public const int CodeFieldNumber = 1;

		// Token: 0x040053FA RID: 21498
		private ErrorCode code_;

		// Token: 0x040053FB RID: 21499
		public const int ConvFieldNumber = 2;

		// Token: 0x040053FC RID: 21500
		private uint conv_;

		// Token: 0x040053FD RID: 21501
		public const int CrcCheckFieldNumber = 3;

		// Token: 0x040053FE RID: 21502
		private int crcCheck_;

		// Token: 0x040053FF RID: 21503
		public const int KcpMtuFieldNumber = 4;

		// Token: 0x04005400 RID: 21504
		private int kcpMtu_;
	}
}
