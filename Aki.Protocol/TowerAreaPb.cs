using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200140B RID: 5131
	public sealed class TowerAreaPb : IMessage<TowerAreaPb>, IMessage, IEquatable<TowerAreaPb>, IDeepCloneable<TowerAreaPb>, IBufferMessage
	{
		// Token: 0x0601B463 RID: 111715 RVA: 0x003F77C3 File Offset: 0x003F59C3
		[NullableContext(1)]
		public static TowerAreaPb Create()
		{
			return new TowerAreaPb();
		}

		// Token: 0x17005C50 RID: 23632
		// (get) Token: 0x0601B464 RID: 111716 RVA: 0x003F77CA File Offset: 0x003F59CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerAreaPb> Parser
		{
			get
			{
				return TowerAreaPb._parser;
			}
		}

		// Token: 0x17005C51 RID: 23633
		// (get) Token: 0x0601B465 RID: 111717 RVA: 0x003F77D1 File Offset: 0x003F59D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C52 RID: 23634
		// (get) Token: 0x0601B466 RID: 111718 RVA: 0x003F77D4 File Offset: 0x003F59D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerAreaPb.Descriptor;
			}
		}

		// Token: 0x0601B467 RID: 111719 RVA: 0x003F77DB File Offset: 0x003F59DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerAreaPb()
		{
		}

		// Token: 0x0601B468 RID: 111720 RVA: 0x003F77EE File Offset: 0x003F59EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerAreaPb(TowerAreaPb other) : this()
		{
			this.areaNum_ = other.areaNum_;
			this.towerFloors_ = other.towerFloors_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B469 RID: 111721 RVA: 0x003F7824 File Offset: 0x003F5A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerAreaPb Clone()
		{
			return new TowerAreaPb(this);
		}

		// Token: 0x17005C53 RID: 23635
		// (get) Token: 0x0601B46A RID: 111722 RVA: 0x003F782C File Offset: 0x003F5A2C
		// (set) Token: 0x0601B46B RID: 111723 RVA: 0x003F7834 File Offset: 0x003F5A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaNum
		{
			get
			{
				return this.areaNum_;
			}
			set
			{
				this.areaNum_ = value;
			}
		}

		// Token: 0x17005C54 RID: 23636
		// (get) Token: 0x0601B46C RID: 111724 RVA: 0x003F783D File Offset: 0x003F5A3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerFloorPb> TowerFloors
		{
			get
			{
				return this.towerFloors_;
			}
		}

		// Token: 0x0601B46D RID: 111725 RVA: 0x003F7845 File Offset: 0x003F5A45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerAreaPb);
		}

		// Token: 0x0601B46E RID: 111726 RVA: 0x003F7854 File Offset: 0x003F5A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerAreaPb other)
		{
			return other != null && (other == this || (this.AreaNum == other.AreaNum && this.towerFloors_.Equals(other.towerFloors_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B46F RID: 111727 RVA: 0x003F78A4 File Offset: 0x003F5AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaNum != 0)
			{
				num ^= this.AreaNum.GetHashCode();
			}
			num ^= this.towerFloors_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B470 RID: 111728 RVA: 0x003F78F1 File Offset: 0x003F5AF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B471 RID: 111729 RVA: 0x003F78FE File Offset: 0x003F5AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B472 RID: 111730 RVA: 0x003F7908 File Offset: 0x003F5B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaNum != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AreaNum);
			}
			this.towerFloors_.WriteTo(ref output, TowerAreaPb._repeated_towerFloors_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B473 RID: 111731 RVA: 0x003F7958 File Offset: 0x003F5B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaNum);
			}
			num += this.towerFloors_.CalculateSize(TowerAreaPb._repeated_towerFloors_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B474 RID: 111732 RVA: 0x003F79AC File Offset: 0x003F5BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerAreaPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaNum != 0)
			{
				this.AreaNum = other.AreaNum;
			}
			this.towerFloors_.Add(other.towerFloors_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B475 RID: 111733 RVA: 0x003F79F9 File Offset: 0x003F5BF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B476 RID: 111734 RVA: 0x003F7A04 File Offset: 0x003F5C04
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.towerFloors_.AddEntriesFrom(ref input, TowerAreaPb._repeated_towerFloors_codec);
					}
				}
				else
				{
					this.AreaNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009EEA RID: 40682
		private static readonly MessageParser<TowerAreaPb> _parser = new MessageParser<TowerAreaPb>(() => new TowerAreaPb());

		// Token: 0x04009EEB RID: 40683
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009EEC RID: 40684
		public const int AreaNumFieldNumber = 1;

		// Token: 0x04009EED RID: 40685
		private int areaNum_;

		// Token: 0x04009EEE RID: 40686
		public const int TowerFloorsFieldNumber = 2;

		// Token: 0x04009EEF RID: 40687
		private static readonly FieldCodec<TowerFloorPb> _repeated_towerFloors_codec = FieldCodec.ForMessage<TowerFloorPb>(18U, TowerFloorPb.Parser);

		// Token: 0x04009EF0 RID: 40688
		private readonly RepeatedField<TowerFloorPb> towerFloors_ = new RepeatedField<TowerFloorPb>();
	}
}
