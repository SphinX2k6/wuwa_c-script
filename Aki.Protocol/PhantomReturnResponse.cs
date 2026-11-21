using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CEE RID: 3310
	[NetMessage(EMessageId.PhantomReturnResponse)]
	public sealed class PhantomReturnResponse : IMessage<PhantomReturnResponse>, IMessage, IEquatable<PhantomReturnResponse>, IDeepCloneable<PhantomReturnResponse>, IBufferMessage
	{
		// Token: 0x06011EB4 RID: 73396 RVA: 0x0029F47D File Offset: 0x0029D67D
		[NullableContext(1)]
		public static PhantomReturnResponse Create()
		{
			return new PhantomReturnResponse();
		}

		// Token: 0x17003B60 RID: 15200
		// (get) Token: 0x06011EB5 RID: 73397 RVA: 0x0029F484 File Offset: 0x0029D684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B61 RID: 15201
		// (get) Token: 0x06011EB6 RID: 73398 RVA: 0x0029F487 File Offset: 0x0029D687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomReturnResponse.Descriptor;
			}
		}

		// Token: 0x06011EB7 RID: 73399 RVA: 0x0029F48E File Offset: 0x0029D68E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomReturnResponse()
		{
		}

		// Token: 0x06011EB8 RID: 73400 RVA: 0x0029F4A1 File Offset: 0x0029D6A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomReturnResponse(PhantomReturnResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011EB9 RID: 73401 RVA: 0x0029F4D7 File Offset: 0x0029D6D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomReturnResponse Clone()
		{
			return new PhantomReturnResponse(this);
		}

		// Token: 0x17003B62 RID: 15202
		// (get) Token: 0x06011EBA RID: 73402 RVA: 0x0029F4DF File Offset: 0x0029D6DF
		// (set) Token: 0x06011EBB RID: 73403 RVA: 0x0029F4E7 File Offset: 0x0029D6E7
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

		// Token: 0x17003B63 RID: 15203
		// (get) Token: 0x06011EBC RID: 73404 RVA: 0x0029F4F0 File Offset: 0x0029D6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x06011EBD RID: 73405 RVA: 0x0029F4F8 File Offset: 0x0029D6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomReturnResponse);
		}

		// Token: 0x06011EBE RID: 73406 RVA: 0x0029F508 File Offset: 0x0029D708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomReturnResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011EBF RID: 73407 RVA: 0x0029F558 File Offset: 0x0029D758
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

		// Token: 0x06011EC0 RID: 73408 RVA: 0x0029F5AB File Offset: 0x0029D7AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011EC1 RID: 73409 RVA: 0x0029F5B8 File Offset: 0x0029D7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011EC2 RID: 73410 RVA: 0x0029F5C4 File Offset: 0x0029D7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemMap_.WriteTo(ref output, PhantomReturnResponse._map_itemMap_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011EC3 RID: 73411 RVA: 0x0029F614 File Offset: 0x0029D814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.itemMap_.CalculateSize(PhantomReturnResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011EC4 RID: 73412 RVA: 0x0029F668 File Offset: 0x0029D868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomReturnResponse other)
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

		// Token: 0x06011EC5 RID: 73413 RVA: 0x0029F6B5 File Offset: 0x0029D8B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011EC6 RID: 73414 RVA: 0x0029F6C0 File Offset: 0x0029D8C0
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
					if (num != 56U)
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
					this.itemMap_.AddEntriesFrom(ref input, PhantomReturnResponse._map_itemMap_codec);
				}
			}
		}

		// Token: 0x040070C8 RID: 28872
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070C9 RID: 28873
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040070CA RID: 28874
		private ErrorCode errorCode_;

		// Token: 0x040070CB RID: 28875
		public const int ItemMapFieldNumber = 6;

		// Token: 0x040070CC RID: 28876
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 50U);

		// Token: 0x040070CD RID: 28877
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
