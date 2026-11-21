using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000157 RID: 343
	[NetMessage(EMessageId.BabelTowerShowNameResponse)]
	public sealed class BabelTowerShowNameResponse : IMessage<BabelTowerShowNameResponse>, IMessage, IEquatable<BabelTowerShowNameResponse>, IDeepCloneable<BabelTowerShowNameResponse>, IBufferMessage
	{
		// Token: 0x06002B92 RID: 11154 RVA: 0x00071D93 File Offset: 0x0006FF93
		[NullableContext(1)]
		public static BabelTowerShowNameResponse Create()
		{
			return new BabelTowerShowNameResponse();
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06002B93 RID: 11155 RVA: 0x00071D9A File Offset: 0x0006FF9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06002B94 RID: 11156 RVA: 0x00071D9D File Offset: 0x0006FF9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerShowNameResponse.Descriptor;
			}
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x00071DA4 File Offset: 0x0006FFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerShowNameResponse()
		{
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x00071DAC File Offset: 0x0006FFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerShowNameResponse(BabelTowerShowNameResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B97 RID: 11159 RVA: 0x00071DD1 File Offset: 0x0006FFD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerShowNameResponse Clone()
		{
			return new BabelTowerShowNameResponse(this);
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06002B98 RID: 11160 RVA: 0x00071DD9 File Offset: 0x0006FFD9
		// (set) Token: 0x06002B99 RID: 11161 RVA: 0x00071DE1 File Offset: 0x0006FFE1
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

		// Token: 0x06002B9A RID: 11162 RVA: 0x00071DEA File Offset: 0x0006FFEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerShowNameResponse);
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x00071DF8 File Offset: 0x0006FFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerShowNameResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x00071E28 File Offset: 0x00070028
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

		// Token: 0x06002B9D RID: 11165 RVA: 0x00071E6D File Offset: 0x0007006D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002B9E RID: 11166 RVA: 0x00071E7A File Offset: 0x0007007A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x00071E83 File Offset: 0x00070083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x00071EB8 File Offset: 0x000700B8
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

		// Token: 0x06002BA1 RID: 11169 RVA: 0x00071EF6 File Offset: 0x000700F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelTowerShowNameResponse other)
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

		// Token: 0x06002BA2 RID: 11170 RVA: 0x00071F27 File Offset: 0x00070127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002BA3 RID: 11171 RVA: 0x00071F30 File Offset: 0x00070130
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040027FE RID: 10238
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027FF RID: 10239
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04002800 RID: 10240
		private ErrorCode errorCode_;
	}
}
