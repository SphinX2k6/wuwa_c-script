using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000775 RID: 1909
	public sealed class HonamiStoryEnterCtx : IMessage<HonamiStoryEnterCtx>, IMessage, IEquatable<HonamiStoryEnterCtx>, IDeepCloneable<HonamiStoryEnterCtx>, IBufferMessage
	{
		// Token: 0x0600AC83 RID: 44163 RVA: 0x0019E9FC File Offset: 0x0019CBFC
		[NullableContext(1)]
		public static HonamiStoryEnterCtx Create()
		{
			return new HonamiStoryEnterCtx();
		}

		// Token: 0x170022C3 RID: 8899
		// (get) Token: 0x0600AC84 RID: 44164 RVA: 0x0019EA03 File Offset: 0x0019CC03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022C4 RID: 8900
		// (get) Token: 0x0600AC85 RID: 44165 RVA: 0x0019EA06 File Offset: 0x0019CC06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryEnterCtx.Descriptor;
			}
		}

		// Token: 0x0600AC86 RID: 44166 RVA: 0x0019EA0D File Offset: 0x0019CC0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEnterCtx()
		{
		}

		// Token: 0x0600AC87 RID: 44167 RVA: 0x0019EA18 File Offset: 0x0019CC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEnterCtx(HonamiStoryEnterCtx other) : this()
		{
			this.isUpTower_ = other.isUpTower_;
			this.dangerLevel_ = other.dangerLevel_;
			this.activityId_ = other.activityId_;
			this.buySafeLeave_ = other.buySafeLeave_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC88 RID: 44168 RVA: 0x0019EA6C File Offset: 0x0019CC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEnterCtx Clone()
		{
			return new HonamiStoryEnterCtx(this);
		}

		// Token: 0x170022C5 RID: 8901
		// (get) Token: 0x0600AC89 RID: 44169 RVA: 0x0019EA74 File Offset: 0x0019CC74
		// (set) Token: 0x0600AC8A RID: 44170 RVA: 0x0019EA7C File Offset: 0x0019CC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUpTower
		{
			get
			{
				return this.isUpTower_;
			}
			set
			{
				this.isUpTower_ = value;
			}
		}

		// Token: 0x170022C6 RID: 8902
		// (get) Token: 0x0600AC8B RID: 44171 RVA: 0x0019EA85 File Offset: 0x0019CC85
		// (set) Token: 0x0600AC8C RID: 44172 RVA: 0x0019EA8D File Offset: 0x0019CC8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DangerLevel
		{
			get
			{
				return this.dangerLevel_;
			}
			set
			{
				this.dangerLevel_ = value;
			}
		}

		// Token: 0x170022C7 RID: 8903
		// (get) Token: 0x0600AC8D RID: 44173 RVA: 0x0019EA96 File Offset: 0x0019CC96
		// (set) Token: 0x0600AC8E RID: 44174 RVA: 0x0019EA9E File Offset: 0x0019CC9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170022C8 RID: 8904
		// (get) Token: 0x0600AC8F RID: 44175 RVA: 0x0019EAA7 File Offset: 0x0019CCA7
		// (set) Token: 0x0600AC90 RID: 44176 RVA: 0x0019EAAF File Offset: 0x0019CCAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool BuySafeLeave
		{
			get
			{
				return this.buySafeLeave_;
			}
			set
			{
				this.buySafeLeave_ = value;
			}
		}

		// Token: 0x0600AC91 RID: 44177 RVA: 0x0019EAB8 File Offset: 0x0019CCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryEnterCtx);
		}

		// Token: 0x0600AC92 RID: 44178 RVA: 0x0019EAC8 File Offset: 0x0019CCC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryEnterCtx other)
		{
			return other != null && (other == this || (this.IsUpTower == other.IsUpTower && this.DangerLevel == other.DangerLevel && this.ActivityId == other.ActivityId && this.BuySafeLeave == other.BuySafeLeave && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AC93 RID: 44179 RVA: 0x0019EB34 File Offset: 0x0019CD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsUpTower)
			{
				num ^= this.IsUpTower.GetHashCode();
			}
			if (this.DangerLevel != 0)
			{
				num ^= this.DangerLevel.GetHashCode();
			}
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.BuySafeLeave)
			{
				num ^= this.BuySafeLeave.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AC94 RID: 44180 RVA: 0x0019EBBE File Offset: 0x0019CDBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AC95 RID: 44181 RVA: 0x0019EBCB File Offset: 0x0019CDCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC96 RID: 44182 RVA: 0x0019EBD4 File Offset: 0x0019CDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsUpTower)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsUpTower);
			}
			if (this.DangerLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DangerLevel);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this.BuySafeLeave)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.BuySafeLeave);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AC97 RID: 44183 RVA: 0x0019EC64 File Offset: 0x0019CE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsUpTower)
			{
				num += 2;
			}
			if (this.DangerLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DangerLevel);
			}
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.BuySafeLeave)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AC98 RID: 44184 RVA: 0x0019ECD4 File Offset: 0x0019CED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryEnterCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsUpTower)
			{
				this.IsUpTower = other.IsUpTower;
			}
			if (other.DangerLevel != 0)
			{
				this.DangerLevel = other.DangerLevel;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.BuySafeLeave)
			{
				this.BuySafeLeave = other.BuySafeLeave;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AC99 RID: 44185 RVA: 0x0019ED4C File Offset: 0x0019CF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC9A RID: 44186 RVA: 0x0019ED58 File Offset: 0x0019CF58
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
						this.IsUpTower = input.ReadBool();
						continue;
					}
					if (num == 16U)
					{
						this.DangerLevel = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.BuySafeLeave = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004E19 RID: 19993
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E1A RID: 19994
		public const int IsUpTowerFieldNumber = 1;

		// Token: 0x04004E1B RID: 19995
		private bool isUpTower_;

		// Token: 0x04004E1C RID: 19996
		public const int DangerLevelFieldNumber = 2;

		// Token: 0x04004E1D RID: 19997
		private int dangerLevel_;

		// Token: 0x04004E1E RID: 19998
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04004E1F RID: 19999
		private int activityId_;

		// Token: 0x04004E20 RID: 20000
		public const int BuySafeLeaveFieldNumber = 4;

		// Token: 0x04004E21 RID: 20001
		private bool buySafeLeave_;
	}
}
