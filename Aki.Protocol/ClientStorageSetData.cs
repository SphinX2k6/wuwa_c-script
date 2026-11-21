using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002AE RID: 686
	public sealed class ClientStorageSetData : IMessage<ClientStorageSetData>, IMessage, IEquatable<ClientStorageSetData>, IDeepCloneable<ClientStorageSetData>, IBufferMessage
	{
		// Token: 0x06004756 RID: 18262 RVA: 0x000AF8D7 File Offset: 0x000ADAD7
		[NullableContext(1)]
		public static ClientStorageSetData Create()
		{
			return new ClientStorageSetData();
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06004757 RID: 18263 RVA: 0x000AF8DE File Offset: 0x000ADADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x06004758 RID: 18264 RVA: 0x000AF8E1 File Offset: 0x000ADAE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientStorageSetData.Descriptor;
			}
		}

		// Token: 0x06004759 RID: 18265 RVA: 0x000AF8E8 File Offset: 0x000ADAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageSetData()
		{
		}

		// Token: 0x0600475A RID: 18266 RVA: 0x000AF8FB File Offset: 0x000ADAFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageSetData(ClientStorageSetData other) : this()
		{
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600475B RID: 18267 RVA: 0x000AF925 File Offset: 0x000ADB25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageSetData Clone()
		{
			return new ClientStorageSetData(this);
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x0600475C RID: 18268 RVA: 0x000AF92D File Offset: 0x000ADB2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x0600475D RID: 18269 RVA: 0x000AF935 File Offset: 0x000ADB35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientStorageSetData);
		}

		// Token: 0x0600475E RID: 18270 RVA: 0x000AF943 File Offset: 0x000ADB43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientStorageSetData other)
		{
			return other != null && (other == this || (this.data_.Equals(other.data_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600475F RID: 18271 RVA: 0x000AF978 File Offset: 0x000ADB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.data_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004760 RID: 18272 RVA: 0x000AF9AC File Offset: 0x000ADBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004761 RID: 18273 RVA: 0x000AF9B9 File Offset: 0x000ADBB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004762 RID: 18274 RVA: 0x000AF9C2 File Offset: 0x000ADBC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.data_.WriteTo(ref output, ClientStorageSetData._repeated_data_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004763 RID: 18275 RVA: 0x000AF9EC File Offset: 0x000ADBEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.data_.CalculateSize(ClientStorageSetData._repeated_data_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004764 RID: 18276 RVA: 0x000AFA25 File Offset: 0x000ADC25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientStorageSetData other)
		{
			if (other == null)
			{
				return;
			}
			this.data_.Add(other.data_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004765 RID: 18277 RVA: 0x000AFA53 File Offset: 0x000ADC53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004766 RID: 18278 RVA: 0x000AFA5C File Offset: 0x000ADC5C
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.data_.AddEntriesFrom(ref input, ClientStorageSetData._repeated_data_codec);
				}
			}
		}

		// Token: 0x04002FED RID: 12269
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FEE RID: 12270
		public const int DataFieldNumber = 1;

		// Token: 0x04002FEF RID: 12271
		private static readonly FieldCodec<int> _repeated_data_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04002FF0 RID: 12272
		private readonly RepeatedField<int> data_ = new RepeatedField<int>();
	}
}
