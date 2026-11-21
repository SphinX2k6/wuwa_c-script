using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012C6 RID: 4806
	public sealed class SolarSchoolShopDataPb : IMessage<SolarSchoolShopDataPb>, IMessage, IEquatable<SolarSchoolShopDataPb>, IDeepCloneable<SolarSchoolShopDataPb>, IBufferMessage
	{
		// Token: 0x06019A73 RID: 105075 RVA: 0x003BE36D File Offset: 0x003BC56D
		[NullableContext(1)]
		public static SolarSchoolShopDataPb Create()
		{
			return new SolarSchoolShopDataPb();
		}

		// Token: 0x170056DC RID: 22236
		// (get) Token: 0x06019A74 RID: 105076 RVA: 0x003BE374 File Offset: 0x003BC574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056DD RID: 22237
		// (get) Token: 0x06019A75 RID: 105077 RVA: 0x003BE377 File Offset: 0x003BC577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolShopDataPb.Descriptor;
			}
		}

		// Token: 0x06019A76 RID: 105078 RVA: 0x003BE37E File Offset: 0x003BC57E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolShopDataPb()
		{
		}

		// Token: 0x06019A77 RID: 105079 RVA: 0x003BE391 File Offset: 0x003BC591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolShopDataPb(SolarSchoolShopDataPb other) : this()
		{
			this.shopData_ = other.shopData_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019A78 RID: 105080 RVA: 0x003BE3BB File Offset: 0x003BC5BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolShopDataPb Clone()
		{
			return new SolarSchoolShopDataPb(this);
		}

		// Token: 0x170056DE RID: 22238
		// (get) Token: 0x06019A79 RID: 105081 RVA: 0x003BE3C3 File Offset: 0x003BC5C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SolarSchoolShopRuntimeDataPb> ShopData
		{
			get
			{
				return this.shopData_;
			}
		}

		// Token: 0x06019A7A RID: 105082 RVA: 0x003BE3CB File Offset: 0x003BC5CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolShopDataPb);
		}

		// Token: 0x06019A7B RID: 105083 RVA: 0x003BE3D9 File Offset: 0x003BC5D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolShopDataPb other)
		{
			return other != null && (other == this || (this.shopData_.Equals(other.shopData_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019A7C RID: 105084 RVA: 0x003BE40C File Offset: 0x003BC60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.shopData_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019A7D RID: 105085 RVA: 0x003BE440 File Offset: 0x003BC640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019A7E RID: 105086 RVA: 0x003BE44D File Offset: 0x003BC64D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019A7F RID: 105087 RVA: 0x003BE456 File Offset: 0x003BC656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.shopData_.WriteTo(ref output, SolarSchoolShopDataPb._repeated_shopData_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019A80 RID: 105088 RVA: 0x003BE480 File Offset: 0x003BC680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.shopData_.CalculateSize(SolarSchoolShopDataPb._repeated_shopData_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019A81 RID: 105089 RVA: 0x003BE4B9 File Offset: 0x003BC6B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolShopDataPb other)
		{
			if (other == null)
			{
				return;
			}
			this.shopData_.Add(other.shopData_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019A82 RID: 105090 RVA: 0x003BE4E7 File Offset: 0x003BC6E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019A83 RID: 105091 RVA: 0x003BE4F0 File Offset: 0x003BC6F0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.shopData_.AddEntriesFrom(ref input, SolarSchoolShopDataPb._repeated_shopData_codec);
				}
			}
		}

		// Token: 0x0400978D RID: 38797
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400978E RID: 38798
		public const int ShopDataFieldNumber = 2;

		// Token: 0x0400978F RID: 38799
		private static readonly FieldCodec<SolarSchoolShopRuntimeDataPb> _repeated_shopData_codec = FieldCodec.ForMessage<SolarSchoolShopRuntimeDataPb>(18U, SolarSchoolShopRuntimeDataPb.Parser);

		// Token: 0x04009790 RID: 38800
		private readonly RepeatedField<SolarSchoolShopRuntimeDataPb> shopData_ = new RepeatedField<SolarSchoolShopRuntimeDataPb>();
	}
}
