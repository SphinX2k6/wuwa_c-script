using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001398 RID: 5016
	public sealed class TowerAreaPb : IMessage<TowerAreaPb>, IMessage, IEquatable<TowerAreaPb>, IDeepCloneable<TowerAreaPb>, IBufferMessage
	{
		// Token: 0x0601A9D8 RID: 109016 RVA: 0x003DC4FC File Offset: 0x003DA6FC
		[NullableContext(1)]
		public static TowerAreaPb Create()
		{
			return new TowerAreaPb();
		}

		// Token: 0x170059BB RID: 22971
		// (get) Token: 0x0601A9D9 RID: 109017 RVA: 0x003DC503 File Offset: 0x003DA703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerAreaPb> Parser
		{
			get
			{
				return TowerAreaPb._parser;
			}
		}

		// Token: 0x170059BC RID: 22972
		// (get) Token: 0x0601A9DA RID: 109018 RVA: 0x003DC50A File Offset: 0x003DA70A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059BD RID: 22973
		// (get) Token: 0x0601A9DB RID: 109019 RVA: 0x003DC50D File Offset: 0x003DA70D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerAreaPb.Descriptor;
			}
		}

		// Token: 0x0601A9DC RID: 109020 RVA: 0x003DC514 File Offset: 0x003DA714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerAreaPb()
		{
		}

		// Token: 0x0601A9DD RID: 109021 RVA: 0x003DC527 File Offset: 0x003DA727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerAreaPb(TowerAreaPb other) : this()
		{
			this.areaNum_ = other.areaNum_;
			this.towerFloors_ = other.towerFloors_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A9DE RID: 109022 RVA: 0x003DC55D File Offset: 0x003DA75D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerAreaPb Clone()
		{
			return new TowerAreaPb(this);
		}

		// Token: 0x170059BE RID: 22974
		// (get) Token: 0x0601A9DF RID: 109023 RVA: 0x003DC565 File Offset: 0x003DA765
		// (set) Token: 0x0601A9E0 RID: 109024 RVA: 0x003DC56D File Offset: 0x003DA76D
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

		// Token: 0x170059BF RID: 22975
		// (get) Token: 0x0601A9E1 RID: 109025 RVA: 0x003DC576 File Offset: 0x003DA776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerFloorPb> TowerFloors
		{
			get
			{
				return this.towerFloors_;
			}
		}

		// Token: 0x0601A9E2 RID: 109026 RVA: 0x003DC57E File Offset: 0x003DA77E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerAreaPb);
		}

		// Token: 0x0601A9E3 RID: 109027 RVA: 0x003DC58C File Offset: 0x003DA78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerAreaPb other)
		{
			return other != null && (other == this || (this.AreaNum == other.AreaNum && this.towerFloors_.Equals(other.towerFloors_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A9E4 RID: 109028 RVA: 0x003DC5DC File Offset: 0x003DA7DC
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

		// Token: 0x0601A9E5 RID: 109029 RVA: 0x003DC629 File Offset: 0x003DA829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A9E6 RID: 109030 RVA: 0x003DC636 File Offset: 0x003DA836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A9E7 RID: 109031 RVA: 0x003DC640 File Offset: 0x003DA840
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

		// Token: 0x0601A9E8 RID: 109032 RVA: 0x003DC690 File Offset: 0x003DA890
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

		// Token: 0x0601A9E9 RID: 109033 RVA: 0x003DC6E4 File Offset: 0x003DA8E4
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

		// Token: 0x0601A9EA RID: 109034 RVA: 0x003DC731 File Offset: 0x003DA931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A9EB RID: 109035 RVA: 0x003DC73C File Offset: 0x003DA93C
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

		// Token: 0x04009AA3 RID: 39587
		private static readonly MessageParser<TowerAreaPb> _parser = new MessageParser<TowerAreaPb>(() => new TowerAreaPb());

		// Token: 0x04009AA4 RID: 39588
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009AA5 RID: 39589
		public const int AreaNumFieldNumber = 1;

		// Token: 0x04009AA6 RID: 39590
		private int areaNum_;

		// Token: 0x04009AA7 RID: 39591
		public const int TowerFloorsFieldNumber = 2;

		// Token: 0x04009AA8 RID: 39592
		private static readonly FieldCodec<TowerFloorPb> _repeated_towerFloors_codec = FieldCodec.ForMessage<TowerFloorPb>(18U, TowerFloorPb.Parser);

		// Token: 0x04009AA9 RID: 39593
		private readonly RepeatedField<TowerFloorPb> towerFloors_ = new RepeatedField<TowerFloorPb>();
	}
}
