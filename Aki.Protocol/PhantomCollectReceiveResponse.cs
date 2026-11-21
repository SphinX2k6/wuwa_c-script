using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CB6 RID: 3254
	[NetMessage(EMessageId.PhantomCollectReceiveResponse)]
	public sealed class PhantomCollectReceiveResponse : IMessage<PhantomCollectReceiveResponse>, IMessage, IEquatable<PhantomCollectReceiveResponse>, IDeepCloneable<PhantomCollectReceiveResponse>, IBufferMessage
	{
		// Token: 0x06011A45 RID: 72261 RVA: 0x00295960 File Offset: 0x00293B60
		[NullableContext(1)]
		public static PhantomCollectReceiveResponse Create()
		{
			return new PhantomCollectReceiveResponse();
		}

		// Token: 0x17003A70 RID: 14960
		// (get) Token: 0x06011A46 RID: 72262 RVA: 0x00295967 File Offset: 0x00293B67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A71 RID: 14961
		// (get) Token: 0x06011A47 RID: 72263 RVA: 0x0029596A File Offset: 0x00293B6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomCollectReceiveResponse.Descriptor;
			}
		}

		// Token: 0x06011A48 RID: 72264 RVA: 0x00295971 File Offset: 0x00293B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectReceiveResponse()
		{
		}

		// Token: 0x06011A49 RID: 72265 RVA: 0x00295984 File Offset: 0x00293B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectReceiveResponse(PhantomCollectReceiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011A4A RID: 72266 RVA: 0x002959BA File Offset: 0x00293BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectReceiveResponse Clone()
		{
			return new PhantomCollectReceiveResponse(this);
		}

		// Token: 0x17003A72 RID: 14962
		// (get) Token: 0x06011A4B RID: 72267 RVA: 0x002959C2 File Offset: 0x00293BC2
		// (set) Token: 0x06011A4C RID: 72268 RVA: 0x002959CA File Offset: 0x00293BCA
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

		// Token: 0x17003A73 RID: 14963
		// (get) Token: 0x06011A4D RID: 72269 RVA: 0x002959D3 File Offset: 0x00293BD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x06011A4E RID: 72270 RVA: 0x002959DB File Offset: 0x00293BDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomCollectReceiveResponse);
		}

		// Token: 0x06011A4F RID: 72271 RVA: 0x002959EC File Offset: 0x00293BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomCollectReceiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011A50 RID: 72272 RVA: 0x00295A3C File Offset: 0x00293C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.ItemMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011A51 RID: 72273 RVA: 0x00295A8F File Offset: 0x00293C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011A52 RID: 72274 RVA: 0x00295A9C File Offset: 0x00293C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011A53 RID: 72275 RVA: 0x00295AA8 File Offset: 0x00293CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemMap_.WriteTo(ref output, PhantomCollectReceiveResponse._map_itemMap_codec);
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

		// Token: 0x06011A54 RID: 72276 RVA: 0x00295AF8 File Offset: 0x00293CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.itemMap_.CalculateSize(PhantomCollectReceiveResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011A55 RID: 72277 RVA: 0x00295B4C File Offset: 0x00293D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomCollectReceiveResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.itemMap_.MergeFrom(other.itemMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011A56 RID: 72278 RVA: 0x00295B99 File Offset: 0x00293D99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011A57 RID: 72279 RVA: 0x00295BA4 File Offset: 0x00293DA4
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
				if (num != 50U)
				{
					if (num != 64U)
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
					this.itemMap_.AddEntriesFrom(ref input, PhantomCollectReceiveResponse._map_itemMap_codec);
				}
			}
		}

		// Token: 0x04006F6B RID: 28523
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F6C RID: 28524
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04006F6D RID: 28525
		private ErrorCode errorCode_;

		// Token: 0x04006F6E RID: 28526
		public const int ItemMapFieldNumber = 6;

		// Token: 0x04006F6F RID: 28527
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 50U);

		// Token: 0x04006F70 RID: 28528
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
