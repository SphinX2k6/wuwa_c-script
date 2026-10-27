using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D51 RID: 3409
	public sealed class PinballLevelData : IMessage<PinballLevelData>, IMessage, IEquatable<PinballLevelData>, IDeepCloneable<PinballLevelData>, IBufferMessage
	{
		// Token: 0x06012632 RID: 75314 RVA: 0x002AECCE File Offset: 0x002ACECE
		[NullableContext(1)]
		public static PinballLevelData Create()
		{
			return new PinballLevelData();
		}

		// Token: 0x17003CED RID: 15597
		// (get) Token: 0x06012633 RID: 75315 RVA: 0x002AECD5 File Offset: 0x002ACED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PinballLevelData> Parser
		{
			get
			{
				return PinballLevelData._parser;
			}
		}

		// Token: 0x17003CEE RID: 15598
		// (get) Token: 0x06012634 RID: 75316 RVA: 0x002AECDC File Offset: 0x002ACEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CEF RID: 15599
		// (get) Token: 0x06012635 RID: 75317 RVA: 0x002AECDF File Offset: 0x002ACEDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballLevelData.Descriptor;
			}
		}

		// Token: 0x06012636 RID: 75318 RVA: 0x002AECE6 File Offset: 0x002ACEE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballLevelData()
		{
		}

		// Token: 0x06012637 RID: 75319 RVA: 0x002AECF0 File Offset: 0x002ACEF0
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

		// Token: 0x06012638 RID: 75320 RVA: 0x002AED8B File Offset: 0x002ACF8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballLevelData Clone()
		{
			return new PinballLevelData(this);
		}

		// Token: 0x17003CF0 RID: 15600
		// (get) Token: 0x06012639 RID: 75321 RVA: 0x002AED93 File Offset: 0x002ACF93
		// (set) Token: 0x0601263A RID: 75322 RVA: 0x002AED9B File Offset: 0x002ACF9B
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

		// Token: 0x17003CF1 RID: 15601
		// (get) Token: 0x0601263B RID: 75323 RVA: 0x002AEDA4 File Offset: 0x002ACFA4
		// (set) Token: 0x0601263C RID: 75324 RVA: 0x002AEDBC File Offset: 0x002ACFBC
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

		// Token: 0x17003CF2 RID: 15602
		// (get) Token: 0x0601263D RID: 75325 RVA: 0x002AEDD2 File Offset: 0x002ACFD2
		// (set) Token: 0x0601263E RID: 75326 RVA: 0x002AEDEA File Offset: 0x002ACFEA
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

		// Token: 0x17003CF3 RID: 15603
		// (get) Token: 0x0601263F RID: 75327 RVA: 0x002AEE00 File Offset: 0x002AD000
		// (set) Token: 0x06012640 RID: 75328 RVA: 0x002AEE18 File Offset: 0x002AD018
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

		// Token: 0x17003CF4 RID: 15604
		// (get) Token: 0x06012641 RID: 75329 RVA: 0x002AEE2E File Offset: 0x002AD02E
		// (set) Token: 0x06012642 RID: 75330 RVA: 0x002AEE46 File Offset: 0x002AD046
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

		// Token: 0x17003CF5 RID: 15605
		// (get) Token: 0x06012643 RID: 75331 RVA: 0x002AEE5C File Offset: 0x002AD05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballLevelData.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06012644 RID: 75332 RVA: 0x002AEE64 File Offset: 0x002AD064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = PinballLevelData.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06012645 RID: 75333 RVA: 0x002AEE74 File Offset: 0x002AD074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballLevelData);
		}

		// Token: 0x06012646 RID: 75334 RVA: 0x002AEE84 File Offset: 0x002AD084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballLevelData other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this.NormalLevel, other.NormalLevel) && object.Equals(this.CowLevel, other.CowLevel) && object.Equals(this.TowerLevel, other.TowerLevel) && object.Equals(this.DailyLevel, other.DailyLevel) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012647 RID: 75335 RVA: 0x002AEF24 File Offset: 0x002AD124
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

		// Token: 0x06012648 RID: 75336 RVA: 0x002AEFC8 File Offset: 0x002AD1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012649 RID: 75337 RVA: 0x002AEFD5 File Offset: 0x002AD1D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601264A RID: 75338 RVA: 0x002AEFE0 File Offset: 0x002AD1E0
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

		// Token: 0x0601264B RID: 75339 RVA: 0x002AF090 File Offset: 0x002AD290
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

		// Token: 0x0601264C RID: 75340 RVA: 0x002AF134 File Offset: 0x002AD334
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

		// Token: 0x0601264D RID: 75341 RVA: 0x002AF22A File Offset: 0x002AD42A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601264E RID: 75342 RVA: 0x002AF234 File Offset: 0x002AD434
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

		// Token: 0x0400727E RID: 29310
		private static readonly MessageParser<PinballLevelData> _parser = new MessageParser<PinballLevelData>(() => new PinballLevelData());

		// Token: 0x0400727F RID: 29311
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007280 RID: 29312
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04007281 RID: 29313
		private int configId_;

		// Token: 0x04007282 RID: 29314
		public const int NormalLevelFieldNumber = 2;

		// Token: 0x04007283 RID: 29315
		public const int CowLevelFieldNumber = 3;

		// Token: 0x04007284 RID: 29316
		public const int TowerLevelFieldNumber = 4;

		// Token: 0x04007285 RID: 29317
		public const int DailyLevelFieldNumber = 5;

		// Token: 0x04007286 RID: 29318
		private object data_;

		// Token: 0x04007287 RID: 29319
		private PinballLevelData.DataOneofCase dataCase_;

		// Token: 0x020018D2 RID: 6354
		public enum DataOneofCase
		{
			// Token: 0x0400C8DB RID: 51419
			None,
			// Token: 0x0400C8DC RID: 51420
			NormalLevel = 2,
			// Token: 0x0400C8DD RID: 51421
			CowLevel,
			// Token: 0x0400C8DE RID: 51422
			TowerLevel,
			// Token: 0x0400C8DF RID: 51423
			DailyLevel
		}
	}
}
