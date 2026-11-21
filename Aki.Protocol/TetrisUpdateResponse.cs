using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013CA RID: 5066
	[NetMessage(EMessageId.TetrisUpdateResponse)]
	public sealed class TetrisUpdateResponse : IMessage<TetrisUpdateResponse>, IMessage, IEquatable<TetrisUpdateResponse>, IDeepCloneable<TetrisUpdateResponse>, IBufferMessage
	{
		// Token: 0x0601AF6A RID: 110442 RVA: 0x003ED7D7 File Offset: 0x003EB9D7
		[NullableContext(1)]
		public static TetrisUpdateResponse Create()
		{
			return new TetrisUpdateResponse();
		}

		// Token: 0x17005B57 RID: 23383
		// (get) Token: 0x0601AF6B RID: 110443 RVA: 0x003ED7DE File Offset: 0x003EB9DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B58 RID: 23384
		// (get) Token: 0x0601AF6C RID: 110444 RVA: 0x003ED7E1 File Offset: 0x003EB9E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TetrisUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0601AF6D RID: 110445 RVA: 0x003ED7E8 File Offset: 0x003EB9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisUpdateResponse()
		{
		}

		// Token: 0x0601AF6E RID: 110446 RVA: 0x003ED7FB File Offset: 0x003EB9FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisUpdateResponse(TetrisUpdateResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.items_ = other.items_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AF6F RID: 110447 RVA: 0x003ED831 File Offset: 0x003EBA31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisUpdateResponse Clone()
		{
			return new TetrisUpdateResponse(this);
		}

		// Token: 0x17005B59 RID: 23385
		// (get) Token: 0x0601AF70 RID: 110448 RVA: 0x003ED839 File Offset: 0x003EBA39
		// (set) Token: 0x0601AF71 RID: 110449 RVA: 0x003ED841 File Offset: 0x003EBA41
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

		// Token: 0x17005B5A RID: 23386
		// (get) Token: 0x0601AF72 RID: 110450 RVA: 0x003ED84A File Offset: 0x003EBA4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x0601AF73 RID: 110451 RVA: 0x003ED852 File Offset: 0x003EBA52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TetrisUpdateResponse);
		}

		// Token: 0x0601AF74 RID: 110452 RVA: 0x003ED860 File Offset: 0x003EBA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TetrisUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.Items.Equals(other.Items) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AF75 RID: 110453 RVA: 0x003ED8B0 File Offset: 0x003EBAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			num ^= this.Items.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AF76 RID: 110454 RVA: 0x003ED903 File Offset: 0x003EBB03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AF77 RID: 110455 RVA: 0x003ED910 File Offset: 0x003EBB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AF78 RID: 110456 RVA: 0x003ED91C File Offset: 0x003EBB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.items_.WriteTo(ref output, TetrisUpdateResponse._map_items_codec);
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AF79 RID: 110457 RVA: 0x003ED96C File Offset: 0x003EBB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			num += this.items_.CalculateSize(TetrisUpdateResponse._map_items_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AF7A RID: 110458 RVA: 0x003ED9C0 File Offset: 0x003EBBC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TetrisUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this.items_.MergeFrom(other.items_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AF7B RID: 110459 RVA: 0x003EDA0D File Offset: 0x003EBC0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AF7C RID: 110460 RVA: 0x003EDA18 File Offset: 0x003EBC18
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
				if (num != 18U)
				{
					if (num != 96U)
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
					this.items_.AddEntriesFrom(ref input, TetrisUpdateResponse._map_items_codec);
				}
			}
		}

		// Token: 0x04009DA9 RID: 40361
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DAA RID: 40362
		public const int ErrCodeFieldNumber = 12;

		// Token: 0x04009DAB RID: 40363
		private ErrorCode errCode_;

		// Token: 0x04009DAC RID: 40364
		public const int ItemsFieldNumber = 2;

		// Token: 0x04009DAD RID: 40365
		private static readonly MapField<int, int>.Codec _map_items_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x04009DAE RID: 40366
		private readonly MapField<int, int> items_ = new MapField<int, int>();
	}
}
