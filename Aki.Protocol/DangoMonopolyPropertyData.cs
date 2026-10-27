using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200038B RID: 907
	public sealed class DangoMonopolyPropertyData : IMessage<DangoMonopolyPropertyData>, IMessage, IEquatable<DangoMonopolyPropertyData>, IDeepCloneable<DangoMonopolyPropertyData>, IBufferMessage
	{
		// Token: 0x060059AB RID: 22955 RVA: 0x000DA599 File Offset: 0x000D8799
		[NullableContext(1)]
		public static DangoMonopolyPropertyData Create()
		{
			return new DangoMonopolyPropertyData();
		}

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x060059AC RID: 22956 RVA: 0x000DA5A0 File Offset: 0x000D87A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x060059AD RID: 22957 RVA: 0x000DA5A3 File Offset: 0x000D87A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyPropertyData.Descriptor;
			}
		}

		// Token: 0x060059AE RID: 22958 RVA: 0x000DA5AA File Offset: 0x000D87AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyPropertyData()
		{
		}

		// Token: 0x060059AF RID: 22959 RVA: 0x000DA5BD File Offset: 0x000D87BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyPropertyData(DangoMonopolyPropertyData other) : this()
		{
			this.propertyId_ = other.propertyId_;
			this.propertyData_ = other.propertyData_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060059B0 RID: 22960 RVA: 0x000DA5F3 File Offset: 0x000D87F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyPropertyData Clone()
		{
			return new DangoMonopolyPropertyData(this);
		}

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x060059B1 RID: 22961 RVA: 0x000DA5FB File Offset: 0x000D87FB
		// (set) Token: 0x060059B2 RID: 22962 RVA: 0x000DA603 File Offset: 0x000D8803
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

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x060059B3 RID: 22963 RVA: 0x000DA60C File Offset: 0x000D880C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PropertyData
		{
			get
			{
				return this.propertyData_;
			}
		}

		// Token: 0x060059B4 RID: 22964 RVA: 0x000DA614 File Offset: 0x000D8814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyPropertyData);
		}

		// Token: 0x060059B5 RID: 22965 RVA: 0x000DA624 File Offset: 0x000D8824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyPropertyData other)
		{
			return other != null && (other == this || (this.PropertyId == other.PropertyId && this.propertyData_.Equals(other.propertyData_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060059B6 RID: 22966 RVA: 0x000DA674 File Offset: 0x000D8874
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

		// Token: 0x060059B7 RID: 22967 RVA: 0x000DA6C1 File Offset: 0x000D88C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060059B8 RID: 22968 RVA: 0x000DA6CE File Offset: 0x000D88CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060059B9 RID: 22969 RVA: 0x000DA6D8 File Offset: 0x000D88D8
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

		// Token: 0x060059BA RID: 22970 RVA: 0x000DA728 File Offset: 0x000D8928
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

		// Token: 0x060059BB RID: 22971 RVA: 0x000DA77C File Offset: 0x000D897C
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

		// Token: 0x060059BC RID: 22972 RVA: 0x000DA7C9 File Offset: 0x000D89C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060059BD RID: 22973 RVA: 0x000DA7D4 File Offset: 0x000D89D4
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

		// Token: 0x04003576 RID: 13686
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003577 RID: 13687
		public const int PropertyIdFieldNumber = 1;

		// Token: 0x04003578 RID: 13688
		private int propertyId_;

		// Token: 0x04003579 RID: 13689
		public const int PropertyDataFieldNumber = 2;

		// Token: 0x0400357A RID: 13690
		private static readonly FieldCodec<int> _repeated_propertyData_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400357B RID: 13691
		private readonly RepeatedField<int> propertyData_ = new RepeatedField<int>();
	}
}
