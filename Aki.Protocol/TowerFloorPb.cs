using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200142B RID: 5163
	public sealed class TowerFloorPb : IMessage<TowerFloorPb>, IMessage, IEquatable<TowerFloorPb>, IDeepCloneable<TowerFloorPb>, IBufferMessage
	{
		// Token: 0x0601B707 RID: 112391 RVA: 0x003FD51A File Offset: 0x003FB71A
		[NullableContext(1)]
		public static TowerFloorPb Create()
		{
			return new TowerFloorPb();
		}

		// Token: 0x17005CE6 RID: 23782
		// (get) Token: 0x0601B708 RID: 112392 RVA: 0x003FD521 File Offset: 0x003FB721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerFloorPb> Parser
		{
			get
			{
				return TowerFloorPb._parser;
			}
		}

		// Token: 0x17005CE7 RID: 23783
		// (get) Token: 0x0601B709 RID: 112393 RVA: 0x003FD528 File Offset: 0x003FB728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CE8 RID: 23784
		// (get) Token: 0x0601B70A RID: 112394 RVA: 0x003FD52B File Offset: 0x003FB72B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerFloorPb.Descriptor;
			}
		}

		// Token: 0x0601B70B RID: 112395 RVA: 0x003FD532 File Offset: 0x003FB732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerFloorPb()
		{
		}

		// Token: 0x0601B70C RID: 112396 RVA: 0x003FD550 File Offset: 0x003FB750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerFloorPb(TowerFloorPb other) : this()
		{
			this.towerConfigId_ = other.towerConfigId_;
			this.star_ = other.star_;
			this.formation_ = other.formation_.Clone();
			this.starIndex_ = other.starIndex_.Clone();
			this.isQuickPass_ = other.isQuickPass_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B70D RID: 112397 RVA: 0x003FD5BA File Offset: 0x003FB7BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerFloorPb Clone()
		{
			return new TowerFloorPb(this);
		}

		// Token: 0x17005CE9 RID: 23785
		// (get) Token: 0x0601B70E RID: 112398 RVA: 0x003FD5C2 File Offset: 0x003FB7C2
		// (set) Token: 0x0601B70F RID: 112399 RVA: 0x003FD5CA File Offset: 0x003FB7CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TowerConfigId
		{
			get
			{
				return this.towerConfigId_;
			}
			set
			{
				this.towerConfigId_ = value;
			}
		}

		// Token: 0x17005CEA RID: 23786
		// (get) Token: 0x0601B710 RID: 112400 RVA: 0x003FD5D3 File Offset: 0x003FB7D3
		// (set) Token: 0x0601B711 RID: 112401 RVA: 0x003FD5DB File Offset: 0x003FB7DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Star
		{
			get
			{
				return this.star_;
			}
			set
			{
				this.star_ = value;
			}
		}

		// Token: 0x17005CEB RID: 23787
		// (get) Token: 0x0601B712 RID: 112402 RVA: 0x003FD5E4 File Offset: 0x003FB7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerRolePb> Formation
		{
			get
			{
				return this.formation_;
			}
		}

		// Token: 0x17005CEC RID: 23788
		// (get) Token: 0x0601B713 RID: 112403 RVA: 0x003FD5EC File Offset: 0x003FB7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> StarIndex
		{
			get
			{
				return this.starIndex_;
			}
		}

		// Token: 0x17005CED RID: 23789
		// (get) Token: 0x0601B714 RID: 112404 RVA: 0x003FD5F4 File Offset: 0x003FB7F4
		// (set) Token: 0x0601B715 RID: 112405 RVA: 0x003FD5FC File Offset: 0x003FB7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsQuickPass
		{
			get
			{
				return this.isQuickPass_;
			}
			set
			{
				this.isQuickPass_ = value;
			}
		}

		// Token: 0x0601B716 RID: 112406 RVA: 0x003FD605 File Offset: 0x003FB805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerFloorPb);
		}

		// Token: 0x0601B717 RID: 112407 RVA: 0x003FD614 File Offset: 0x003FB814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerFloorPb other)
		{
			return other != null && (other == this || (this.TowerConfigId == other.TowerConfigId && this.Star == other.Star && this.formation_.Equals(other.formation_) && this.starIndex_.Equals(other.starIndex_) && this.IsQuickPass == other.IsQuickPass && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B718 RID: 112408 RVA: 0x003FD698 File Offset: 0x003FB898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TowerConfigId != 0)
			{
				num ^= this.TowerConfigId.GetHashCode();
			}
			if (this.Star != 0)
			{
				num ^= this.Star.GetHashCode();
			}
			num ^= this.formation_.GetHashCode();
			num ^= this.starIndex_.GetHashCode();
			if (this.IsQuickPass)
			{
				num ^= this.IsQuickPass.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B719 RID: 112409 RVA: 0x003FD725 File Offset: 0x003FB925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B71A RID: 112410 RVA: 0x003FD732 File Offset: 0x003FB932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B71B RID: 112411 RVA: 0x003FD73C File Offset: 0x003FB93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TowerConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TowerConfigId);
			}
			if (this.Star != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Star);
			}
			this.formation_.WriteTo(ref output, TowerFloorPb._repeated_formation_codec);
			this.starIndex_.WriteTo(ref output, TowerFloorPb._repeated_starIndex_codec);
			if (this.IsQuickPass)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsQuickPass);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B71C RID: 112412 RVA: 0x003FD7D4 File Offset: 0x003FB9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TowerConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TowerConfigId);
			}
			if (this.Star != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Star);
			}
			num += this.formation_.CalculateSize(TowerFloorPb._repeated_formation_codec);
			num += this.starIndex_.CalculateSize(TowerFloorPb._repeated_starIndex_codec);
			if (this.IsQuickPass)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B71D RID: 112413 RVA: 0x003FD85C File Offset: 0x003FBA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerFloorPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TowerConfigId != 0)
			{
				this.TowerConfigId = other.TowerConfigId;
			}
			if (other.Star != 0)
			{
				this.Star = other.Star;
			}
			this.formation_.Add(other.formation_);
			this.starIndex_.Add(other.starIndex_);
			if (other.IsQuickPass)
			{
				this.IsQuickPass = other.IsQuickPass;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B71E RID: 112414 RVA: 0x003FD8E2 File Offset: 0x003FBAE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B71F RID: 112415 RVA: 0x003FD8EC File Offset: 0x003FBAEC
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
				if (num <= 34U)
				{
					if (num == 8U)
					{
						this.TowerConfigId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Star = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						this.formation_.AddEntriesFrom(ref input, TowerFloorPb._repeated_formation_codec);
						continue;
					}
				}
				else
				{
					if (num == 40U || num == 42U)
					{
						this.starIndex_.AddEntriesFrom(ref input, TowerFloorPb._repeated_starIndex_codec);
						continue;
					}
					if (num == 48U)
					{
						this.IsQuickPass = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009FC0 RID: 40896
		private static readonly MessageParser<TowerFloorPb> _parser = new MessageParser<TowerFloorPb>(() => new TowerFloorPb());

		// Token: 0x04009FC1 RID: 40897
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FC2 RID: 40898
		public const int TowerConfigIdFieldNumber = 1;

		// Token: 0x04009FC3 RID: 40899
		private int towerConfigId_;

		// Token: 0x04009FC4 RID: 40900
		public const int StarFieldNumber = 2;

		// Token: 0x04009FC5 RID: 40901
		private int star_;

		// Token: 0x04009FC6 RID: 40902
		public const int FormationFieldNumber = 4;

		// Token: 0x04009FC7 RID: 40903
		private static readonly FieldCodec<TowerRolePb> _repeated_formation_codec = FieldCodec.ForMessage<TowerRolePb>(34U, TowerRolePb.Parser);

		// Token: 0x04009FC8 RID: 40904
		private readonly RepeatedField<TowerRolePb> formation_ = new RepeatedField<TowerRolePb>();

		// Token: 0x04009FC9 RID: 40905
		public const int StarIndexFieldNumber = 5;

		// Token: 0x04009FCA RID: 40906
		private static readonly FieldCodec<int> _repeated_starIndex_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04009FCB RID: 40907
		private readonly RepeatedField<int> starIndex_ = new RepeatedField<int>();

		// Token: 0x04009FCC RID: 40908
		public const int IsQuickPassFieldNumber = 6;

		// Token: 0x04009FCD RID: 40909
		private bool isQuickPass_;
	}
}
