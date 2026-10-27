using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005A7 RID: 1447
	public sealed class FloroRanchActivityData : IMessage<FloroRanchActivityData>, IMessage, IEquatable<FloroRanchActivityData>, IDeepCloneable<FloroRanchActivityData>, IBufferMessage
	{
		// Token: 0x060085CB RID: 34251 RVA: 0x00141954 File Offset: 0x0013FB54
		[NullableContext(1)]
		public static FloroRanchActivityData Create()
		{
			return new FloroRanchActivityData();
		}

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x060085CC RID: 34252 RVA: 0x0014195B File Offset: 0x0013FB5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x060085CD RID: 34253 RVA: 0x0014195E File Offset: 0x0013FB5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchActivityData.Descriptor;
			}
		}

		// Token: 0x060085CE RID: 34254 RVA: 0x00141965 File Offset: 0x0013FB65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchActivityData()
		{
		}

		// Token: 0x060085CF RID: 34255 RVA: 0x00141970 File Offset: 0x0013FB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchActivityData(FloroRanchActivityData other) : this()
		{
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this.unSettleSubInsId_ = other.unSettleSubInsId_;
			this.stage_ = other.stage_;
			this.curWeeklyInsId_ = other.curWeeklyInsId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060085D0 RID: 34256 RVA: 0x001419D4 File Offset: 0x0013FBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchActivityData Clone()
		{
			return new FloroRanchActivityData(this);
		}

		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x060085D1 RID: 34257 RVA: 0x001419DC File Offset: 0x0013FBDC
		// (set) Token: 0x060085D2 RID: 34258 RVA: 0x001419E4 File Offset: 0x0013FBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayerInfo PlayerInfo
		{
			get
			{
				return this.playerInfo_;
			}
			set
			{
				this.playerInfo_ = value;
			}
		}

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x060085D3 RID: 34259 RVA: 0x001419ED File Offset: 0x0013FBED
		// (set) Token: 0x060085D4 RID: 34260 RVA: 0x001419F5 File Offset: 0x0013FBF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnSettleSubInsId
		{
			get
			{
				return this.unSettleSubInsId_;
			}
			set
			{
				this.unSettleSubInsId_ = value;
			}
		}

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x060085D5 RID: 34261 RVA: 0x001419FE File Offset: 0x0013FBFE
		// (set) Token: 0x060085D6 RID: 34262 RVA: 0x00141A06 File Offset: 0x0013FC06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Stage
		{
			get
			{
				return this.stage_;
			}
			set
			{
				this.stage_ = value;
			}
		}

		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x060085D7 RID: 34263 RVA: 0x00141A0F File Offset: 0x0013FC0F
		// (set) Token: 0x060085D8 RID: 34264 RVA: 0x00141A17 File Offset: 0x0013FC17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurWeeklyInsId
		{
			get
			{
				return this.curWeeklyInsId_;
			}
			set
			{
				this.curWeeklyInsId_ = value;
			}
		}

		// Token: 0x060085D9 RID: 34265 RVA: 0x00141A20 File Offset: 0x0013FC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchActivityData);
		}

		// Token: 0x060085DA RID: 34266 RVA: 0x00141A30 File Offset: 0x0013FC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchActivityData other)
		{
			return other != null && (other == this || (object.Equals(this.PlayerInfo, other.PlayerInfo) && this.UnSettleSubInsId == other.UnSettleSubInsId && this.Stage == other.Stage && this.CurWeeklyInsId == other.CurWeeklyInsId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060085DB RID: 34267 RVA: 0x00141AA0 File Offset: 0x0013FCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.playerInfo_ != null)
			{
				num ^= this.PlayerInfo.GetHashCode();
			}
			if (this.UnSettleSubInsId != 0)
			{
				num ^= this.UnSettleSubInsId.GetHashCode();
			}
			if (this.Stage != 0)
			{
				num ^= this.Stage.GetHashCode();
			}
			if (this.CurWeeklyInsId != 0)
			{
				num ^= this.CurWeeklyInsId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060085DC RID: 34268 RVA: 0x00141B27 File Offset: 0x0013FD27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060085DD RID: 34269 RVA: 0x00141B34 File Offset: 0x0013FD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060085DE RID: 34270 RVA: 0x00141B40 File Offset: 0x0013FD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.playerInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.PlayerInfo);
			}
			if (this.UnSettleSubInsId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.UnSettleSubInsId);
			}
			if (this.Stage != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Stage);
			}
			if (this.CurWeeklyInsId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CurWeeklyInsId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060085DF RID: 34271 RVA: 0x00141BD4 File Offset: 0x0013FDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.playerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerInfo);
			}
			if (this.UnSettleSubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnSettleSubInsId);
			}
			if (this.Stage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Stage);
			}
			if (this.CurWeeklyInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurWeeklyInsId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060085E0 RID: 34272 RVA: 0x00141C5C File Offset: 0x0013FE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchActivityData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.playerInfo_ != null)
			{
				if (this.playerInfo_ == null)
				{
					this.PlayerInfo = new FloroRanchPlayerInfo();
				}
				this.PlayerInfo.MergeFrom(other.PlayerInfo);
			}
			if (other.UnSettleSubInsId != 0)
			{
				this.UnSettleSubInsId = other.UnSettleSubInsId;
			}
			if (other.Stage != 0)
			{
				this.Stage = other.Stage;
			}
			if (other.CurWeeklyInsId != 0)
			{
				this.CurWeeklyInsId = other.CurWeeklyInsId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060085E1 RID: 34273 RVA: 0x00141CEC File Offset: 0x0013FEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060085E2 RID: 34274 RVA: 0x00141CF8 File Offset: 0x0013FEF8
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
					if (num == 10U)
					{
						if (this.playerInfo_ == null)
						{
							this.PlayerInfo = new FloroRanchPlayerInfo();
						}
						input.ReadMessage(this.PlayerInfo);
						continue;
					}
					if (num == 16U)
					{
						this.UnSettleSubInsId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Stage = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.CurWeeklyInsId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004218 RID: 16920
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004219 RID: 16921
		public const int PlayerInfoFieldNumber = 1;

		// Token: 0x0400421A RID: 16922
		private FloroRanchPlayerInfo playerInfo_;

		// Token: 0x0400421B RID: 16923
		public const int UnSettleSubInsIdFieldNumber = 2;

		// Token: 0x0400421C RID: 16924
		private int unSettleSubInsId_;

		// Token: 0x0400421D RID: 16925
		public const int StageFieldNumber = 3;

		// Token: 0x0400421E RID: 16926
		private int stage_;

		// Token: 0x0400421F RID: 16927
		public const int CurWeeklyInsIdFieldNumber = 4;

		// Token: 0x04004220 RID: 16928
		private int curWeeklyInsId_;
	}
}
