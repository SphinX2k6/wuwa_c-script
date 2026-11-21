using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000393 RID: 915
	public sealed class DangoMonopolyPropertyData : IMessage<DangoMonopolyPropertyData>, IMessage, IEquatable<DangoMonopolyPropertyData>, IDeepCloneable<DangoMonopolyPropertyData>, IBufferMessage
	{
		// Token: 0x06005A98 RID: 23192 RVA: 0x000DCC21 File Offset: 0x000DAE21
		[NullableContext(1)]
		public static DangoMonopolyPropertyData Create()
		{
			return new DangoMonopolyPropertyData();
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x06005A99 RID: 23193 RVA: 0x000DCC28 File Offset: 0x000DAE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x06005A9A RID: 23194 RVA: 0x000DCC2B File Offset: 0x000DAE2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyPropertyData.Descriptor;
			}
		}

		// Token: 0x06005A9B RID: 23195 RVA: 0x000DCC32 File Offset: 0x000DAE32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyPropertyData()
		{
		}

		// Token: 0x06005A9C RID: 23196 RVA: 0x000DCC45 File Offset: 0x000DAE45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyPropertyData(DangoMonopolyPropertyData other) : this()
		{
			this.propertyId_ = other.propertyId_;
			this.propertyData_ = other.propertyData_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A9D RID: 23197 RVA: 0x000DCC7B File Offset: 0x000DAE7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyPropertyData Clone()
		{
			return new DangoMonopolyPropertyData(this);
		}

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x06005A9E RID: 23198 RVA: 0x000DCC83 File Offset: 0x000DAE83
		// (set) Token: 0x06005A9F RID: 23199 RVA: 0x000DCC8B File Offset: 0x000DAE8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PropertyId
		{
			get
			{
				return this.propertyId_;
			}
			set
			{
				this.propertyId_ = value;
			}
		}

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x06005AA0 RID: 23200 RVA: 0x000DCC94 File Offset: 0x000DAE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PropertyData
		{
			get
			{
				return this.propertyData_;
			}
		}

		// Token: 0x06005AA1 RID: 23201 RVA: 0x000DCC9C File Offset: 0x000DAE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyPropertyData);
		}

		// Token: 0x06005AA2 RID: 23202 RVA: 0x000DCCAC File Offset: 0x000DAEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyPropertyData other)
		{
			return other != null && (other == this || (this.PropertyId == other.PropertyId && this.propertyData_.Equals(other.propertyData_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005AA3 RID: 23203 RVA: 0x000DCCFC File Offset: 0x000DAEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PropertyId != 0)
			{
				num ^= this.PropertyId.GetHashCode();
			}
			num ^= this.propertyData_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005AA4 RID: 23204 RVA: 0x000DCD49 File Offset: 0x000DAF49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005AA5 RID: 23205 RVA: 0x000DCD56 File Offset: 0x000DAF56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005AA6 RID: 23206 RVA: 0x000DCD60 File Offset: 0x000DAF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PropertyId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PropertyId);
			}
			this.propertyData_.WriteTo(ref output, DangoMonopolyPropertyData._repeated_propertyData_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005AA7 RID: 23207 RVA: 0x000DCDB0 File Offset: 0x000DAFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PropertyId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PropertyId);
			}
			num += this.propertyData_.CalculateSize(DangoMonopolyPropertyData._repeated_propertyData_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005AA8 RID: 23208 RVA: 0x000DCE04 File Offset: 0x000DB004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyPropertyData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PropertyId != 0)
			{
				this.PropertyId = other.PropertyId;
			}
			this.propertyData_.Add(other.propertyData_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005AA9 RID: 23209 RVA: 0x000DCE51 File Offset: 0x000DB051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005AAA RID: 23210 RVA: 0x000DCE5C File Offset: 0x000DB05C
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
				if (num != 8U)
				{
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.propertyData_.AddEntriesFrom(ref input, DangoMonopolyPropertyData._repeated_propertyData_codec);
					}
				}
				else
				{
					this.PropertyId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003612 RID: 13842
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003613 RID: 13843
		public const int PropertyIdFieldNumber = 1;

		// Token: 0x04003614 RID: 13844
		private int propertyId_;

		// Token: 0x04003615 RID: 13845
		public const int PropertyDataFieldNumber = 2;

		// Token: 0x04003616 RID: 13846
		private static readonly FieldCodec<int> _repeated_propertyData_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04003617 RID: 13847
		private readonly RepeatedField<int> propertyData_ = new RepeatedField<int>();
	}
}
