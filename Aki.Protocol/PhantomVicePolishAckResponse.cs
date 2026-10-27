using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D0F RID: 3343
	[NetMessage(EMessageId.PhantomVicePolishAckResponse)]
	public sealed class PhantomVicePolishAckResponse : IMessage<PhantomVicePolishAckResponse>, IMessage, IEquatable<PhantomVicePolishAckResponse>, IDeepCloneable<PhantomVicePolishAckResponse>, IBufferMessage
	{
		// Token: 0x06012102 RID: 73986 RVA: 0x002A3C64 File Offset: 0x002A1E64
		[NullableContext(1)]
		public static PhantomVicePolishAckResponse Create()
		{
			return new PhantomVicePolishAckResponse();
		}

		// Token: 0x17003BD9 RID: 15321
		// (get) Token: 0x06012103 RID: 73987 RVA: 0x002A3C6B File Offset: 0x002A1E6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BDA RID: 15322
		// (get) Token: 0x06012104 RID: 73988 RVA: 0x002A3C6E File Offset: 0x002A1E6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomVicePolishAckResponse.Descriptor;
			}
		}

		// Token: 0x06012105 RID: 73989 RVA: 0x002A3C75 File Offset: 0x002A1E75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomVicePolishAckResponse()
		{
		}

		// Token: 0x06012106 RID: 73990 RVA: 0x002A3C80 File Offset: 0x002A1E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomVicePolishAckResponse(PhantomVicePolishAckResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.updateInfo_ = ((other.updateInfo_ != null) ? other.updateInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012107 RID: 73991 RVA: 0x002A3CCC File Offset: 0x002A1ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomVicePolishAckResponse Clone()
		{
			return new PhantomVicePolishAckResponse(this);
		}

		// Token: 0x17003BDB RID: 15323
		// (get) Token: 0x06012108 RID: 73992 RVA: 0x002A3CD4 File Offset: 0x002A1ED4
		// (set) Token: 0x06012109 RID: 73993 RVA: 0x002A3CDC File Offset: 0x002A1EDC
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

		// Token: 0x17003BDC RID: 15324
		// (get) Token: 0x0601210A RID: 73994 RVA: 0x002A3CE5 File Offset: 0x002A1EE5
		// (set) Token: 0x0601210B RID: 73995 RVA: 0x002A3CED File Offset: 0x002A1EED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItem UpdateInfo
		{
			get
			{
				return this.updateInfo_;
			}
			set
			{
				this.updateInfo_ = value;
			}
		}

		// Token: 0x0601210C RID: 73996 RVA: 0x002A3CF6 File Offset: 0x002A1EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomVicePolishAckResponse);
		}

		// Token: 0x0601210D RID: 73997 RVA: 0x002A3D04 File Offset: 0x002A1F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomVicePolishAckResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.UpdateInfo, other.UpdateInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601210E RID: 73998 RVA: 0x002A3D54 File Offset: 0x002A1F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.updateInfo_ != null)
			{
				num ^= this.UpdateInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601210F RID: 73999 RVA: 0x002A3DAF File Offset: 0x002A1FAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012110 RID: 74000 RVA: 0x002A3DBC File Offset: 0x002A1FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012111 RID: 74001 RVA: 0x002A3DC8 File Offset: 0x002A1FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.updateInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.UpdateInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012112 RID: 74002 RVA: 0x002A3E24 File Offset: 0x002A2024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.updateInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UpdateInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012113 RID: 74003 RVA: 0x002A3E7C File Offset: 0x002A207C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomVicePolishAckResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.updateInfo_ != null)
			{
				if (this.updateInfo_ == null)
				{
					this.UpdateInfo = new PhantomItem();
				}
				this.UpdateInfo.MergeFrom(other.UpdateInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012114 RID: 74004 RVA: 0x002A3EE4 File Offset: 0x002A20E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012115 RID: 74005 RVA: 0x002A3EF0 File Offset: 0x002A20F0
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
				if (num != 82U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.updateInfo_ == null)
					{
						this.UpdateInfo = new PhantomItem();
					}
					input.ReadMessage(this.UpdateInfo);
				}
			}
		}

		// Token: 0x04007109 RID: 28937
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400710A RID: 28938
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400710B RID: 28939
		private ErrorCode errorCode_;

		// Token: 0x0400710C RID: 28940
		public const int UpdateInfoFieldNumber = 10;

		// Token: 0x0400710D RID: 28941
		private PhantomItem updateInfo_;
	}
}
