using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CC6 RID: 3270
	[NetMessage(EMessageId.PhantomCollectReceiveResponse)]
	public sealed class PhantomCollectReceiveResponse : IMessage<PhantomCollectReceiveResponse>, IMessage, IEquatable<PhantomCollectReceiveResponse>, IDeepCloneable<PhantomCollectReceiveResponse>, IBufferMessage
	{
		// Token: 0x06011B45 RID: 72517 RVA: 0x002976C0 File Offset: 0x002958C0
		[NullableContext(1)]
		public static PhantomCollectReceiveResponse Create()
		{
			return new PhantomCollectReceiveResponse();
		}

		// Token: 0x17003AA7 RID: 15015
		// (get) Token: 0x06011B46 RID: 72518 RVA: 0x002976C7 File Offset: 0x002958C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AA8 RID: 15016
		// (get) Token: 0x06011B47 RID: 72519 RVA: 0x002976CA File Offset: 0x002958CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomCollectReceiveResponse.Descriptor;
			}
		}

		// Token: 0x06011B48 RID: 72520 RVA: 0x002976D1 File Offset: 0x002958D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectReceiveResponse()
		{
		}

		// Token: 0x06011B49 RID: 72521 RVA: 0x002976E4 File Offset: 0x002958E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectReceiveResponse(PhantomCollectReceiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011B4A RID: 72522 RVA: 0x0029771A File Offset: 0x0029591A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectReceiveResponse Clone()
		{
			return new PhantomCollectReceiveResponse(this);
		}

		// Token: 0x17003AA9 RID: 15017
		// (get) Token: 0x06011B4B RID: 72523 RVA: 0x00297722 File Offset: 0x00295922
		// (set) Token: 0x06011B4C RID: 72524 RVA: 0x0029772A File Offset: 0x0029592A
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

		// Token: 0x17003AAA RID: 15018
		// (get) Token: 0x06011B4D RID: 72525 RVA: 0x00297733 File Offset: 0x00295933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x06011B4E RID: 72526 RVA: 0x0029773B File Offset: 0x0029593B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomCollectReceiveResponse);
		}

		// Token: 0x06011B4F RID: 72527 RVA: 0x0029774C File Offset: 0x0029594C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomCollectReceiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011B50 RID: 72528 RVA: 0x0029779C File Offset: 0x0029599C
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

		// Token: 0x06011B51 RID: 72529 RVA: 0x002977EF File Offset: 0x002959EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011B52 RID: 72530 RVA: 0x002977FC File Offset: 0x002959FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011B53 RID: 72531 RVA: 0x00297808 File Offset: 0x00295A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemMap_.WriteTo(ref output, PhantomCollectReceiveResponse._map_itemMap_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011B54 RID: 72532 RVA: 0x00297858 File Offset: 0x00295A58
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

		// Token: 0x06011B55 RID: 72533 RVA: 0x002978AC File Offset: 0x00295AAC
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

		// Token: 0x06011B56 RID: 72534 RVA: 0x002978F9 File Offset: 0x00295AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011B57 RID: 72535 RVA: 0x00297904 File Offset: 0x00295B04
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
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.itemMap_.AddEntriesFrom(ref input, PhantomCollectReceiveResponse._map_itemMap_codec);
				}
			}
		}

		// Token: 0x04006F57 RID: 28503
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F58 RID: 28504
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04006F59 RID: 28505
		private ErrorCode errorCode_;

		// Token: 0x04006F5A RID: 28506
		public const int ItemMapFieldNumber = 2;

		// Token: 0x04006F5B RID: 28507
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x04006F5C RID: 28508
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
