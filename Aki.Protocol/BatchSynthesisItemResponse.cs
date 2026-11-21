using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000164 RID: 356
	[NetMessage(EMessageId.BatchSynthesisItemResponse)]
	public sealed class BatchSynthesisItemResponse : IMessage<BatchSynthesisItemResponse>, IMessage, IEquatable<BatchSynthesisItemResponse>, IDeepCloneable<BatchSynthesisItemResponse>, IBufferMessage
	{
		// Token: 0x06002CA6 RID: 11430 RVA: 0x000745D5 File Offset: 0x000727D5
		[NullableContext(1)]
		public static BatchSynthesisItemResponse Create()
		{
			return new BatchSynthesisItemResponse();
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06002CA7 RID: 11431 RVA: 0x000745DC File Offset: 0x000727DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06002CA8 RID: 11432 RVA: 0x000745DF File Offset: 0x000727DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BatchSynthesisItemResponse.Descriptor;
			}
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x000745E6 File Offset: 0x000727E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchSynthesisItemResponse()
		{
		}

		// Token: 0x06002CAA RID: 11434 RVA: 0x000745F9 File Offset: 0x000727F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchSynthesisItemResponse(BatchSynthesisItemResponse other) : this()
		{
			this.code_ = other.code_;
			this.items_ = other.items_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002CAB RID: 11435 RVA: 0x0007462F File Offset: 0x0007282F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchSynthesisItemResponse Clone()
		{
			return new BatchSynthesisItemResponse(this);
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06002CAC RID: 11436 RVA: 0x00074637 File Offset: 0x00072837
		// (set) Token: 0x06002CAD RID: 11437 RVA: 0x0007463F File Offset: 0x0007283F
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

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06002CAE RID: 11438 RVA: 0x00074648 File Offset: 0x00072848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x00074650 File Offset: 0x00072850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BatchSynthesisItemResponse);
		}

		// Token: 0x06002CB0 RID: 11440 RVA: 0x00074660 File Offset: 0x00072860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BatchSynthesisItemResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Items.Equals(other.Items) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002CB1 RID: 11441 RVA: 0x000746B0 File Offset: 0x000728B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			num ^= this.Items.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x00074703 File Offset: 0x00072903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002CB3 RID: 11443 RVA: 0x00074710 File Offset: 0x00072910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x0007471C File Offset: 0x0007291C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.items_.WriteTo(ref output, BatchSynthesisItemResponse._map_items_codec);
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x0007476C File Offset: 0x0007296C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			num += this.items_.CalculateSize(BatchSynthesisItemResponse._map_items_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x000747C0 File Offset: 0x000729C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BatchSynthesisItemResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this.items_.MergeFrom(other.items_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x0007480D File Offset: 0x00072A0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x00074818 File Offset: 0x00072A18
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
				if (num != 10U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Code = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.items_.AddEntriesFrom(ref input, BatchSynthesisItemResponse._map_items_codec);
				}
			}
		}

		// Token: 0x0400285D RID: 10333
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400285E RID: 10334
		public const int CodeFieldNumber = 13;

		// Token: 0x0400285F RID: 10335
		private ErrorCode code_;

		// Token: 0x04002860 RID: 10336
		public const int ItemsFieldNumber = 1;

		// Token: 0x04002861 RID: 10337
		private static readonly MapField<int, int>.Codec _map_items_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x04002862 RID: 10338
		private readonly MapField<int, int> items_ = new MapField<int, int>();
	}
}
