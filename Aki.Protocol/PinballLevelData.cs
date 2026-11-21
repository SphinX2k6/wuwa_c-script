using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D41 RID: 3393
	public sealed class PinballLevelData : IMessage<PinballLevelData>, IMessage, IEquatable<PinballLevelData>, IDeepCloneable<PinballLevelData>, IBufferMessage
	{
		// Token: 0x06012536 RID: 75062 RVA: 0x002AD0AE File Offset: 0x002AB2AE
		[NullableContext(1)]
		public static PinballLevelData Create()
		{
			return new PinballLevelData();
		}

		// Token: 0x17003CB8 RID: 15544
		// (get) Token: 0x06012537 RID: 75063 RVA: 0x002AD0B5 File Offset: 0x002AB2B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PinballLevelData> Parser
		{
			get
			{
				return PinballLevelData._parser;
			}
		}

		// Token: 0x17003CB9 RID: 15545
		// (get) Token: 0x06012538 RID: 75064 RVA: 0x002AD0BC File Offset: 0x002AB2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CBA RID: 15546
		// (get) Token: 0x06012539 RID: 75065 RVA: 0x002AD0BF File Offset: 0x002AB2BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballLevelData.Descriptor;
			}
		}

		// Token: 0x0601253A RID: 75066 RVA: 0x002AD0C6 File Offset: 0x002AB2C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballLevelData()
		{
		}

		// Token: 0x0601253B RID: 75067 RVA: 0x002AD0D0 File Offset: 0x002AB2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballLevelData(PinballLevelData other) : this()
		{
			this.configId_ = other.configId_;
			switch (other.DataCase)
			{
			case PinballLevelData.DataOneofCase.NormalLevel:
				this.NormalLevel = other.NormalLevel.Clone();
				break;
			case PinballLevelData.DataOneofCase.CowLevel:
				this.CowLevel = other.CowLevel.Clone();
				break;
			case PinballLevelData.DataOneofCase.TowerLevel:
				this.TowerLevel = other.TowerLevel.Clone();
				break;
			case PinballLevelData.DataOneofCase.DailyLevel:
				this.DailyLevel = other.DailyLevel.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601253C RID: 75068 RVA: 0x002AD16B File Offset: 0x002AB36B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballLevelData Clone()
		{
			return new PinballLevelData(this);
		}

		// Token: 0x17003CBB RID: 15547
		// (get) Token: 0x0601253D RID: 75069 RVA: 0x002AD173 File Offset: 0x002AB373
		// (set) Token: 0x0601253E RID: 75070 RVA: 0x002AD17B File Offset: 0x002AB37B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17003CBC RID: 15548
		// (get) Token: 0x0601253F RID: 75071 RVA: 0x002AD184 File Offset: 0x002AB384
		// (set) Token: 0x06012540 RID: 75072 RVA: 0x002AD19C File Offset: 0x002AB39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalLevel NormalLevel
		{
			get
			{
				if (this.dataCase_ != PinballLevelData.DataOneofCase.NormalLevel)
				{
					return null;
				}
				return (NormalLevel)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? PinballLevelData.DataOneofCase.None : PinballLevelData.DataOneofCase.NormalLevel);
			}
		}

		// Token: 0x17003CBD RID: 15549
		// (get) Token: 0x06012541 RID: 75073 RVA: 0x002AD1B2 File Offset: 0x002AB3B2
		// (set) Token: 0x06012542 RID: 75074 RVA: 0x002AD1CA File Offset: 0x002AB3CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CowLevel CowLevel
		{
			get
			{
				if (this.dataCase_ != PinballLevelData.DataOneofCase.CowLevel)
				{
					return null;
				}
				return (CowLevel)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? PinballLevelData.DataOneofCase.None : PinballLevelData.DataOneofCase.CowLevel);
			}
		}

		// Token: 0x17003CBE RID: 15550
		// (get) Token: 0x06012543 RID: 75075 RVA: 0x002AD1E0 File Offset: 0x002AB3E0
		// (set) Token: 0x06012544 RID: 75076 RVA: 0x002AD1F8 File Offset: 0x002AB3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerLevel TowerLevel
		{
			get
			{
				if (this.dataCase_ != PinballLevelData.DataOneofCase.TowerLevel)
				{
					return null;
				}
				return (TowerLevel)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? PinballLevelData.DataOneofCase.None : PinballLevelData.DataOneofCase.TowerLevel);
			}
		}

		// Token: 0x17003CBF RID: 15551
		// (get) Token: 0x06012545 RID: 75077 RVA: 0x002AD20E File Offset: 0x002AB40E
		// (set) Token: 0x06012546 RID: 75078 RVA: 0x002AD226 File Offset: 0x002AB426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyLevel DailyLevel
		{
			get
			{
				if (this.dataCase_ != PinballLevelData.DataOneofCase.DailyLevel)
				{
					return null;
				}
				return (DailyLevel)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? PinballLevelData.DataOneofCase.None : PinballLevelData.DataOneofCase.DailyLevel);
			}
		}

		// Token: 0x17003CC0 RID: 15552
		// (get) Token: 0x06012547 RID: 75079 RVA: 0x002AD23C File Offset: 0x002AB43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballLevelData.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06012548 RID: 75080 RVA: 0x002AD244 File Offset: 0x002AB444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = PinballLevelData.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06012549 RID: 75081 RVA: 0x002AD254 File Offset: 0x002AB454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballLevelData);
		}

		// Token: 0x0601254A RID: 75082 RVA: 0x002AD264 File Offset: 0x002AB464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballLevelData other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this.NormalLevel, other.NormalLevel) && object.Equals(this.CowLevel, other.CowLevel) && object.Equals(this.TowerLevel, other.TowerLevel) && object.Equals(this.DailyLevel, other.DailyLevel) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601254B RID: 75083 RVA: 0x002AD304 File Offset: 0x002AB504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.dataCase_ == PinballLevelData.DataOneofCase.NormalLevel)
			{
				num ^= this.NormalLevel.GetHashCode();
			}
			if (this.dataCase_ == PinballLevelData.DataOneofCase.CowLevel)
			{
				num ^= this.CowLevel.GetHashCode();
			}
			if (this.dataCase_ == PinballLevelData.DataOneofCase.TowerLevel)
			{
				num ^= this.TowerLevel.GetHashCode();
			}
			if (this.dataCase_ == PinballLevelData.DataOneofCase.DailyLevel)
			{
				num ^= this.DailyLevel.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601254C RID: 75084 RVA: 0x002AD3A8 File Offset: 0x002AB5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601254D RID: 75085 RVA: 0x002AD3B5 File Offset: 0x002AB5B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601254E RID: 75086 RVA: 0x002AD3C0 File Offset: 0x002AB5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.dataCase_ == PinballLevelData.DataOneofCase.NormalLevel)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.NormalLevel);
			}
			if (this.dataCase_ == PinballLevelData.DataOneofCase.CowLevel)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.CowLevel);
			}
			if (this.dataCase_ == PinballLevelData.DataOneofCase.TowerLevel)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.TowerLevel);
			}
			if (this.dataCase_ == PinballLevelData.DataOneofCase.DailyLevel)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.DailyLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601254F RID: 75087 RVA: 0x002AD470 File Offset: 0x002AB670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.dataCase_ == PinballLevelData.DataOneofCase.NormalLevel)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NormalLevel);
			}
			if (this.dataCase_ == PinballLevelData.DataOneofCase.CowLevel)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CowLevel);
			}
			if (this.dataCase_ == PinballLevelData.DataOneofCase.TowerLevel)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TowerLevel);
			}
			if (this.dataCase_ == PinballLevelData.DataOneofCase.DailyLevel)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DailyLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012550 RID: 75088 RVA: 0x002AD514 File Offset: 0x002AB714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballLevelData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			switch (other.DataCase)
			{
			case PinballLevelData.DataOneofCase.NormalLevel:
				if (this.NormalLevel == null)
				{
					this.NormalLevel = new NormalLevel();
				}
				this.NormalLevel.MergeFrom(other.NormalLevel);
				break;
			case PinballLevelData.DataOneofCase.CowLevel:
				if (this.CowLevel == null)
				{
					this.CowLevel = new CowLevel();
				}
				this.CowLevel.MergeFrom(other.CowLevel);
				break;
			case PinballLevelData.DataOneofCase.TowerLevel:
				if (this.TowerLevel == null)
				{
					this.TowerLevel = new TowerLevel();
				}
				this.TowerLevel.MergeFrom(other.TowerLevel);
				break;
			case PinballLevelData.DataOneofCase.DailyLevel:
				if (this.DailyLevel == null)
				{
					this.DailyLevel = new DailyLevel();
				}
				this.DailyLevel.MergeFrom(other.DailyLevel);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012551 RID: 75089 RVA: 0x002AD60A File Offset: 0x002AB80A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012552 RID: 75090 RVA: 0x002AD614 File Offset: 0x002AB814
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.ConfigId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						NormalLevel normalLevel = new NormalLevel();
						if (this.dataCase_ == PinballLevelData.DataOneofCase.NormalLevel)
						{
							normalLevel.MergeFrom(this.NormalLevel);
						}
						input.ReadMessage(normalLevel);
						this.NormalLevel = normalLevel;
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						CowLevel cowLevel = new CowLevel();
						if (this.dataCase_ == PinballLevelData.DataOneofCase.CowLevel)
						{
							cowLevel.MergeFrom(this.CowLevel);
						}
						input.ReadMessage(cowLevel);
						this.CowLevel = cowLevel;
						continue;
					}
					if (num == 34U)
					{
						TowerLevel towerLevel = new TowerLevel();
						if (this.dataCase_ == PinballLevelData.DataOneofCase.TowerLevel)
						{
							towerLevel.MergeFrom(this.TowerLevel);
						}
						input.ReadMessage(towerLevel);
						this.TowerLevel = towerLevel;
						continue;
					}
					if (num == 42U)
					{
						DailyLevel dailyLevel = new DailyLevel();
						if (this.dataCase_ == PinballLevelData.DataOneofCase.DailyLevel)
						{
							dailyLevel.MergeFrom(this.DailyLevel);
						}
						input.ReadMessage(dailyLevel);
						this.DailyLevel = dailyLevel;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007296 RID: 29334
		private static readonly MessageParser<PinballLevelData> _parser = new MessageParser<PinballLevelData>(() => new PinballLevelData());

		// Token: 0x04007297 RID: 29335
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007298 RID: 29336
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04007299 RID: 29337
		private int configId_;

		// Token: 0x0400729A RID: 29338
		public const int NormalLevelFieldNumber = 2;

		// Token: 0x0400729B RID: 29339
		public const int CowLevelFieldNumber = 3;

		// Token: 0x0400729C RID: 29340
		public const int TowerLevelFieldNumber = 4;

		// Token: 0x0400729D RID: 29341
		public const int DailyLevelFieldNumber = 5;

		// Token: 0x0400729E RID: 29342
		private object data_;

		// Token: 0x0400729F RID: 29343
		private PinballLevelData.DataOneofCase dataCase_;

		// Token: 0x0200194A RID: 6474
		public enum DataOneofCase
		{
			// Token: 0x0400CE06 RID: 52742
			None,
			// Token: 0x0400CE07 RID: 52743
			NormalLevel = 2,
			// Token: 0x0400CE08 RID: 52744
			CowLevel,
			// Token: 0x0400CE09 RID: 52745
			TowerLevel,
			// Token: 0x0400CE0A RID: 52746
			DailyLevel
		}
	}
}
