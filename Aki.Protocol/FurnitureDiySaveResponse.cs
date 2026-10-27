using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000683 RID: 1667
	[NetMessage(EMessageId.FurnitureDiySaveResponse)]
	public sealed class FurnitureDiySaveResponse : IMessage<FurnitureDiySaveResponse>, IMessage, IEquatable<FurnitureDiySaveResponse>, IDeepCloneable<FurnitureDiySaveResponse>, IBufferMessage
	{
		// Token: 0x060098A6 RID: 39078 RVA: 0x0016FC11 File Offset: 0x0016DE11
		[NullableContext(1)]
		public static FurnitureDiySaveResponse Create()
		{
			return new FurnitureDiySaveResponse();
		}

		// Token: 0x17001E6B RID: 7787
		// (get) Token: 0x060098A7 RID: 39079 RVA: 0x0016FC18 File Offset: 0x0016DE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E6C RID: 7788
		// (get) Token: 0x060098A8 RID: 39080 RVA: 0x0016FC1B File Offset: 0x0016DE1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FurnitureDiySaveResponse.Descriptor;
			}
		}

		// Token: 0x060098A9 RID: 39081 RVA: 0x0016FC22 File Offset: 0x0016DE22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureDiySaveResponse()
		{
		}

		// Token: 0x060098AA RID: 39082 RVA: 0x0016FC2A File Offset: 0x0016DE2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureDiySaveResponse(FurnitureDiySaveResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.atmosphere_ = other.atmosphere_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060098AB RID: 39083 RVA: 0x0016FC5B File Offset: 0x0016DE5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureDiySaveResponse Clone()
		{
			return new FurnitureDiySaveResponse(this);
		}

		// Token: 0x17001E6D RID: 7789
		// (get) Token: 0x060098AC RID: 39084 RVA: 0x0016FC63 File Offset: 0x0016DE63
		// (set) Token: 0x060098AD RID: 39085 RVA: 0x0016FC6B File Offset: 0x0016DE6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x17001E6E RID: 7790
		// (get) Token: 0x060098AE RID: 39086 RVA: 0x0016FC74 File Offset: 0x0016DE74
		// (set) Token: 0x060098AF RID: 39087 RVA: 0x0016FC7C File Offset: 0x0016DE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Atmosphere
		{
			get
			{
				return this.atmosphere_;
			}
			set
			{
				this.atmosphere_ = value;
			}
		}

		// Token: 0x060098B0 RID: 39088 RVA: 0x0016FC85 File Offset: 0x0016DE85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FurnitureDiySaveResponse);
		}

		// Token: 0x060098B1 RID: 39089 RVA: 0x0016FC93 File Offset: 0x0016DE93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FurnitureDiySaveResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.Atmosphere == other.Atmosphere && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060098B2 RID: 39090 RVA: 0x0016FCD4 File Offset: 0x0016DED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this.Atmosphere != 0)
			{
				num ^= this.Atmosphere.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060098B3 RID: 39091 RVA: 0x0016FD32 File Offset: 0x0016DF32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060098B4 RID: 39092 RVA: 0x0016FD3F File Offset: 0x0016DF3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060098B5 RID: 39093 RVA: 0x0016FD48 File Offset: 0x0016DF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Atmosphere != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Atmosphere);
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060098B6 RID: 39094 RVA: 0x0016FDA4 File Offset: 0x0016DFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this.Atmosphere != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Atmosphere);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060098B7 RID: 39095 RVA: 0x0016FDFC File Offset: 0x0016DFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FurnitureDiySaveResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			if (other.Atmosphere != 0)
			{
				this.Atmosphere = other.Atmosphere;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060098B8 RID: 39096 RVA: 0x0016FE4C File Offset: 0x0016E04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060098B9 RID: 39097 RVA: 0x0016FE58 File Offset: 0x0016E058
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
				if (num != 56U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.Atmosphere = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004853 RID: 18515
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004854 RID: 18516
		public const int ErrCodeFieldNumber = 11;

		// Token: 0x04004855 RID: 18517
		private ErrorCode errCode_;

		// Token: 0x04004856 RID: 18518
		public const int AtmosphereFieldNumber = 7;

		// Token: 0x04004857 RID: 18519
		private int atmosphere_;
	}
}
