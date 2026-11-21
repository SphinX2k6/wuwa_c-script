using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001586 RID: 5510
	public sealed class WeeklyPlayData : IMessage<WeeklyPlayData>, IMessage, IEquatable<WeeklyPlayData>, IDeepCloneable<WeeklyPlayData>, IBufferMessage
	{
		// Token: 0x0601D2B4 RID: 119476 RVA: 0x00439291 File Offset: 0x00437491
		[NullableContext(1)]
		public static WeeklyPlayData Create()
		{
			return new WeeklyPlayData();
		}

		// Token: 0x170062AE RID: 25262
		// (get) Token: 0x0601D2B5 RID: 119477 RVA: 0x00439298 File Offset: 0x00437498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WeeklyPlayData> Parser
		{
			get
			{
				return WeeklyPlayData._parser;
			}
		}

		// Token: 0x170062AF RID: 25263
		// (get) Token: 0x0601D2B6 RID: 119478 RVA: 0x0043929F File Offset: 0x0043749F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062B0 RID: 25264
		// (get) Token: 0x0601D2B7 RID: 119479 RVA: 0x004392A2 File Offset: 0x004374A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeeklyPlayData.Descriptor;
			}
		}

		// Token: 0x0601D2B8 RID: 119480 RVA: 0x004392A9 File Offset: 0x004374A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyPlayData()
		{
		}

		// Token: 0x0601D2B9 RID: 119481 RVA: 0x004392B4 File Offset: 0x004374B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyPlayData(WeeklyPlayData other) : this()
		{
			this.id_ = other.id_;
			this.type_ = other.type_;
			WeeklyPlayData.PlayDataOneofCase playDataCase = other.PlayDataCase;
			if (playDataCase != WeeklyPlayData.PlayDataOneofCase.RogueWeeklyPlayData)
			{
				if (playDataCase == WeeklyPlayData.PlayDataOneofCase.FloroFarmPlayData)
				{
					this.FloroFarmPlayData = other.FloroFarmPlayData.Clone();
				}
			}
			else
			{
				this.RogueWeeklyPlayData = other.RogueWeeklyPlayData.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D2BA RID: 119482 RVA: 0x0043932D File Offset: 0x0043752D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyPlayData Clone()
		{
			return new WeeklyPlayData(this);
		}

		// Token: 0x170062B1 RID: 25265
		// (get) Token: 0x0601D2BB RID: 119483 RVA: 0x00439335 File Offset: 0x00437535
		// (set) Token: 0x0601D2BC RID: 119484 RVA: 0x0043933D File Offset: 0x0043753D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170062B2 RID: 25266
		// (get) Token: 0x0601D2BD RID: 119485 RVA: 0x00439346 File Offset: 0x00437546
		// (set) Token: 0x0601D2BE RID: 119486 RVA: 0x0043934E File Offset: 0x0043754E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x170062B3 RID: 25267
		// (get) Token: 0x0601D2BF RID: 119487 RVA: 0x00439357 File Offset: 0x00437557
		// (set) Token: 0x0601D2C0 RID: 119488 RVA: 0x00439373 File Offset: 0x00437573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyPlayData RogueWeeklyPlayData
		{
			get
			{
				if (this.playDataCase_ != WeeklyPlayData.PlayDataOneofCase.RogueWeeklyPlayData)
				{
					return null;
				}
				return (RogueWeeklyPlayData)this.playData_;
			}
			set
			{
				this.playData_ = value;
				this.playDataCase_ = ((value == null) ? WeeklyPlayData.PlayDataOneofCase.None : WeeklyPlayData.PlayDataOneofCase.RogueWeeklyPlayData);
			}
		}

		// Token: 0x170062B4 RID: 25268
		// (get) Token: 0x0601D2C1 RID: 119489 RVA: 0x0043938D File Offset: 0x0043758D
		// (set) Token: 0x0601D2C2 RID: 119490 RVA: 0x004393A9 File Offset: 0x004375A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroFarmPlayData FloroFarmPlayData
		{
			get
			{
				if (this.playDataCase_ != WeeklyPlayData.PlayDataOneofCase.FloroFarmPlayData)
				{
					return null;
				}
				return (FloroFarmPlayData)this.playData_;
			}
			set
			{
				this.playData_ = value;
				this.playDataCase_ = ((value == null) ? WeeklyPlayData.PlayDataOneofCase.None : WeeklyPlayData.PlayDataOneofCase.FloroFarmPlayData);
			}
		}

		// Token: 0x170062B5 RID: 25269
		// (get) Token: 0x0601D2C3 RID: 119491 RVA: 0x004393C3 File Offset: 0x004375C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyPlayData.PlayDataOneofCase PlayDataCase
		{
			get
			{
				return this.playDataCase_;
			}
		}

		// Token: 0x0601D2C4 RID: 119492 RVA: 0x004393CB File Offset: 0x004375CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPlayData()
		{
			this.playDataCase_ = WeeklyPlayData.PlayDataOneofCase.None;
			this.playData_ = null;
		}

		// Token: 0x0601D2C5 RID: 119493 RVA: 0x004393DB File Offset: 0x004375DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeeklyPlayData);
		}

		// Token: 0x0601D2C6 RID: 119494 RVA: 0x004393EC File Offset: 0x004375EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeeklyPlayData other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Type == other.Type && object.Equals(this.RogueWeeklyPlayData, other.RogueWeeklyPlayData) && object.Equals(this.FloroFarmPlayData, other.FloroFarmPlayData) && this.PlayDataCase == other.PlayDataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D2C7 RID: 119495 RVA: 0x00439470 File Offset: 0x00437670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Type != ActivityType.Parkour)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.playDataCase_ == WeeklyPlayData.PlayDataOneofCase.RogueWeeklyPlayData)
			{
				num ^= this.RogueWeeklyPlayData.GetHashCode();
			}
			if (this.playDataCase_ == WeeklyPlayData.PlayDataOneofCase.FloroFarmPlayData)
			{
				num ^= this.FloroFarmPlayData.GetHashCode();
			}
			num ^= (int)this.playDataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D2C8 RID: 119496 RVA: 0x0043950D File Offset: 0x0043770D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D2C9 RID: 119497 RVA: 0x0043951A File Offset: 0x0043771A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D2CA RID: 119498 RVA: 0x00439524 File Offset: 0x00437724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Type != ActivityType.Parkour)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			if (this.playDataCase_ == WeeklyPlayData.PlayDataOneofCase.RogueWeeklyPlayData)
			{
				output.WriteRawTag(130, 241, 4);
				output.WriteMessage(this.RogueWeeklyPlayData);
			}
			if (this.playDataCase_ == WeeklyPlayData.PlayDataOneofCase.FloroFarmPlayData)
			{
				output.WriteRawTag(138, 241, 4);
				output.WriteMessage(this.FloroFarmPlayData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D2CB RID: 119499 RVA: 0x004395D0 File Offset: 0x004377D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Type != ActivityType.Parkour)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.playDataCase_ == WeeklyPlayData.PlayDataOneofCase.RogueWeeklyPlayData)
			{
				num += 3 + CodedOutputStream.ComputeMessageSize(this.RogueWeeklyPlayData);
			}
			if (this.playDataCase_ == WeeklyPlayData.PlayDataOneofCase.FloroFarmPlayData)
			{
				num += 3 + CodedOutputStream.ComputeMessageSize(this.FloroFarmPlayData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D2CC RID: 119500 RVA: 0x00439660 File Offset: 0x00437860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeeklyPlayData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Type != ActivityType.Parkour)
			{
				this.Type = other.Type;
			}
			WeeklyPlayData.PlayDataOneofCase playDataCase = other.PlayDataCase;
			if (playDataCase != WeeklyPlayData.PlayDataOneofCase.RogueWeeklyPlayData)
			{
				if (playDataCase == WeeklyPlayData.PlayDataOneofCase.FloroFarmPlayData)
				{
					if (this.FloroFarmPlayData == null)
					{
						this.FloroFarmPlayData = new FloroFarmPlayData();
					}
					this.FloroFarmPlayData.MergeFrom(other.FloroFarmPlayData);
				}
			}
			else
			{
				if (this.RogueWeeklyPlayData == null)
				{
					this.RogueWeeklyPlayData = new RogueWeeklyPlayData();
				}
				this.RogueWeeklyPlayData.MergeFrom(other.RogueWeeklyPlayData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D2CD RID: 119501 RVA: 0x00439713 File Offset: 0x00437913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D2CE RID: 119502 RVA: 0x0043971C File Offset: 0x0043791C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Type = (ActivityType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 80002U)
					{
						RogueWeeklyPlayData rogueWeeklyPlayData = new RogueWeeklyPlayData();
						if (this.playDataCase_ == WeeklyPlayData.PlayDataOneofCase.RogueWeeklyPlayData)
						{
							rogueWeeklyPlayData.MergeFrom(this.RogueWeeklyPlayData);
						}
						input.ReadMessage(rogueWeeklyPlayData);
						this.RogueWeeklyPlayData = rogueWeeklyPlayData;
						continue;
					}
					if (num == 80010U)
					{
						FloroFarmPlayData floroFarmPlayData = new FloroFarmPlayData();
						if (this.playDataCase_ == WeeklyPlayData.PlayDataOneofCase.FloroFarmPlayData)
						{
							floroFarmPlayData.MergeFrom(this.FloroFarmPlayData);
						}
						input.ReadMessage(floroFarmPlayData);
						this.FloroFarmPlayData = floroFarmPlayData;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A768 RID: 42856
		private static readonly MessageParser<WeeklyPlayData> _parser = new MessageParser<WeeklyPlayData>(() => new WeeklyPlayData());

		// Token: 0x0400A769 RID: 42857
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A76A RID: 42858
		public const int IdFieldNumber = 1;

		// Token: 0x0400A76B RID: 42859
		private int id_;

		// Token: 0x0400A76C RID: 42860
		public const int TypeFieldNumber = 2;

		// Token: 0x0400A76D RID: 42861
		private ActivityType type_;

		// Token: 0x0400A76E RID: 42862
		public const int RogueWeeklyPlayDataFieldNumber = 10000;

		// Token: 0x0400A76F RID: 42863
		public const int FloroFarmPlayDataFieldNumber = 10001;

		// Token: 0x0400A770 RID: 42864
		private object playData_;

		// Token: 0x0400A771 RID: 42865
		private WeeklyPlayData.PlayDataOneofCase playDataCase_;

		// Token: 0x02001A96 RID: 6806
		public enum PlayDataOneofCase
		{
			// Token: 0x0400D04A RID: 53322
			None,
			// Token: 0x0400D04B RID: 53323
			RogueWeeklyPlayData = 10000,
			// Token: 0x0400D04C RID: 53324
			FloroFarmPlayData
		}
	}
}
