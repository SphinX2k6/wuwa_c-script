using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001B4 RID: 436
	[NetMessage(EMessageId.BlockPlayerResponse)]
	public sealed class BlockPlayerResponse : IMessage<BlockPlayerResponse>, IMessage, IEquatable<BlockPlayerResponse>, IDeepCloneable<BlockPlayerResponse>, IBufferMessage
	{
		// Token: 0x060032A7 RID: 12967 RVA: 0x000807AD File Offset: 0x0007E9AD
		[NullableContext(1)]
		public static BlockPlayerResponse Create()
		{
			return new BlockPlayerResponse();
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x060032A8 RID: 12968 RVA: 0x000807B4 File Offset: 0x0007E9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x060032A9 RID: 12969 RVA: 0x000807B7 File Offset: 0x0007E9B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlockPlayerResponse.Descriptor;
			}
		}

		// Token: 0x060032AA RID: 12970 RVA: 0x000807BE File Offset: 0x0007E9BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockPlayerResponse()
		{
		}

		// Token: 0x060032AB RID: 12971 RVA: 0x000807C8 File Offset: 0x0007E9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockPlayerResponse(BlockPlayerResponse other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060032AC RID: 12972 RVA: 0x00080814 File Offset: 0x0007EA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockPlayerResponse Clone()
		{
			return new BlockPlayerResponse(this);
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x060032AD RID: 12973 RVA: 0x0008081C File Offset: 0x0007EA1C
		// (set) Token: 0x060032AE RID: 12974 RVA: 0x00080824 File Offset: 0x0007EA24
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

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x060032AF RID: 12975 RVA: 0x0008082D File Offset: 0x0007EA2D
		// (set) Token: 0x060032B0 RID: 12976 RVA: 0x00080835 File Offset: 0x0007EA35
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

		// Token: 0x060032B1 RID: 12977 RVA: 0x0008083E File Offset: 0x0007EA3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlockPlayerResponse);
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x0008084C File Offset: 0x0007EA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlockPlayerResponse other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x0008089C File Offset: 0x0007EA9C
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

		// Token: 0x060032B4 RID: 12980 RVA: 0x000808F7 File Offset: 0x0007EAF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060032B5 RID: 12981 RVA: 0x00080904 File Offset: 0x0007EB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060032B6 RID: 12982 RVA: 0x00080910 File Offset: 0x0007EB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Info);
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

		// Token: 0x060032B7 RID: 12983 RVA: 0x0008096C File Offset: 0x0007EB6C
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

		// Token: 0x060032B8 RID: 12984 RVA: 0x000809C4 File Offset: 0x0007EBC4
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

		// Token: 0x060032B9 RID: 12985 RVA: 0x00080A2C File Offset: 0x0007EC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060032BA RID: 12986 RVA: 0x00080A38 File Offset: 0x0007EC38
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
				if (num != 34U)
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
					if (this.info_ == null)
					{
						this.Info = new PlayerDetails();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x04002984 RID: 10628
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002985 RID: 10629
		public const int InfoFieldNumber = 4;

		// Token: 0x04002986 RID: 10630
		private PlayerDetails info_;

		// Token: 0x04002987 RID: 10631
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04002988 RID: 10632
		private ErrorCode errorCode_;
	}
}
