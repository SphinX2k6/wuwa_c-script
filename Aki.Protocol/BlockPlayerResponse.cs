using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001B8 RID: 440
	[NetMessage(EMessageId.BlockPlayerResponse)]
	public sealed class BlockPlayerResponse : IMessage<BlockPlayerResponse>, IMessage, IEquatable<BlockPlayerResponse>, IDeepCloneable<BlockPlayerResponse>, IBufferMessage
	{
		// Token: 0x06003334 RID: 13108 RVA: 0x00081F19 File Offset: 0x00080119
		[NullableContext(1)]
		public static BlockPlayerResponse Create()
		{
			return new BlockPlayerResponse();
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06003335 RID: 13109 RVA: 0x00081F20 File Offset: 0x00080120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06003336 RID: 13110 RVA: 0x00081F23 File Offset: 0x00080123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlockPlayerResponse.Descriptor;
			}
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x00081F2A File Offset: 0x0008012A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockPlayerResponse()
		{
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x00081F34 File Offset: 0x00080134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockPlayerResponse(BlockPlayerResponse other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x00081F80 File Offset: 0x00080180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockPlayerResponse Clone()
		{
			return new BlockPlayerResponse(this);
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x0600333A RID: 13114 RVA: 0x00081F88 File Offset: 0x00080188
		// (set) Token: 0x0600333B RID: 13115 RVA: 0x00081F90 File Offset: 0x00080190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDetails Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x0600333C RID: 13116 RVA: 0x00081F99 File Offset: 0x00080199
		// (set) Token: 0x0600333D RID: 13117 RVA: 0x00081FA1 File Offset: 0x000801A1
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

		// Token: 0x0600333E RID: 13118 RVA: 0x00081FAA File Offset: 0x000801AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlockPlayerResponse);
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x00081FB8 File Offset: 0x000801B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlockPlayerResponse other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x00082008 File Offset: 0x00080208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
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

		// Token: 0x06003341 RID: 13121 RVA: 0x00082063 File Offset: 0x00080263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x00082070 File Offset: 0x00080270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003343 RID: 13123 RVA: 0x0008207C File Offset: 0x0008027C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.info_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003344 RID: 13124 RVA: 0x000820D8 File Offset: 0x000802D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
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

		// Token: 0x06003345 RID: 13125 RVA: 0x00082130 File Offset: 0x00080330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlockPlayerResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new PlayerDetails();
				}
				this.Info.MergeFrom(other.Info);
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x00082198 File Offset: 0x00080398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x000821A4 File Offset: 0x000803A4
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
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.info_ == null)
						{
							this.Info = new PlayerDetails();
						}
						input.ReadMessage(this.Info);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040029FF RID: 10751
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A00 RID: 10752
		public const int InfoFieldNumber = 14;

		// Token: 0x04002A01 RID: 10753
		private PlayerDetails info_;

		// Token: 0x04002A02 RID: 10754
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04002A03 RID: 10755
		private ErrorCode errorCode_;
	}
}
