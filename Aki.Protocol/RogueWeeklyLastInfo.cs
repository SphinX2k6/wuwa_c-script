using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200102C RID: 4140
	public sealed class RogueWeeklyLastInfo : IMessage<RogueWeeklyLastInfo>, IMessage, IEquatable<RogueWeeklyLastInfo>, IDeepCloneable<RogueWeeklyLastInfo>, IBufferMessage
	{
		// Token: 0x06016277 RID: 90743 RVA: 0x003389CF File Offset: 0x00336BCF
		[NullableContext(1)]
		public static RogueWeeklyLastInfo Create()
		{
			return new RogueWeeklyLastInfo();
		}

		// Token: 0x17004A16 RID: 18966
		// (get) Token: 0x06016278 RID: 90744 RVA: 0x003389D6 File Offset: 0x00336BD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A17 RID: 18967
		// (get) Token: 0x06016279 RID: 90745 RVA: 0x003389D9 File Offset: 0x00336BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyLastInfo.Descriptor;
			}
		}

		// Token: 0x0601627A RID: 90746 RVA: 0x003389E0 File Offset: 0x00336BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyLastInfo()
		{
		}

		// Token: 0x0601627B RID: 90747 RVA: 0x003389E8 File Offset: 0x00336BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyLastInfo(RogueWeeklyLastInfo other) : this()
		{
			this.instId_ = other.instId_;
			this.curLayer_ = other.curLayer_;
			this.maxLayer_ = other.maxLayer_;
			this.worldLevel_ = other.worldLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601627C RID: 90748 RVA: 0x00338A3C File Offset: 0x00336C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyLastInfo Clone()
		{
			return new RogueWeeklyLastInfo(this);
		}

		// Token: 0x17004A18 RID: 18968
		// (get) Token: 0x0601627D RID: 90749 RVA: 0x00338A44 File Offset: 0x00336C44
		// (set) Token: 0x0601627E RID: 90750 RVA: 0x00338A4C File Offset: 0x00336C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17004A19 RID: 18969
		// (get) Token: 0x0601627F RID: 90751 RVA: 0x00338A55 File Offset: 0x00336C55
		// (set) Token: 0x06016280 RID: 90752 RVA: 0x00338A5D File Offset: 0x00336C5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurLayer
		{
			get
			{
				return this.curLayer_;
			}
			set
			{
				this.curLayer_ = value;
			}
		}

		// Token: 0x17004A1A RID: 18970
		// (get) Token: 0x06016281 RID: 90753 RVA: 0x00338A66 File Offset: 0x00336C66
		// (set) Token: 0x06016282 RID: 90754 RVA: 0x00338A6E File Offset: 0x00336C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxLayer
		{
			get
			{
				return this.maxLayer_;
			}
			set
			{
				this.maxLayer_ = value;
			}
		}

		// Token: 0x17004A1B RID: 18971
		// (get) Token: 0x06016283 RID: 90755 RVA: 0x00338A77 File Offset: 0x00336C77
		// (set) Token: 0x06016284 RID: 90756 RVA: 0x00338A7F File Offset: 0x00336C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WorldLevel
		{
			get
			{
				return this.worldLevel_;
			}
			set
			{
				this.worldLevel_ = value;
			}
		}

		// Token: 0x06016285 RID: 90757 RVA: 0x00338A88 File Offset: 0x00336C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyLastInfo);
		}

		// Token: 0x06016286 RID: 90758 RVA: 0x00338A98 File Offset: 0x00336C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyLastInfo other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.CurLayer == other.CurLayer && this.MaxLayer == other.MaxLayer && this.WorldLevel == other.WorldLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016287 RID: 90759 RVA: 0x00338B04 File Offset: 0x00336D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.CurLayer != 0)
			{
				num ^= this.CurLayer.GetHashCode();
			}
			if (this.MaxLayer != 0)
			{
				num ^= this.MaxLayer.GetHashCode();
			}
			if (this.WorldLevel != 0)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016288 RID: 90760 RVA: 0x00338B8E File Offset: 0x00336D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016289 RID: 90761 RVA: 0x00338B9B File Offset: 0x00336D9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601628A RID: 90762 RVA: 0x00338BA4 File Offset: 0x00336DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			if (this.CurLayer != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurLayer);
			}
			if (this.MaxLayer != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MaxLayer);
			}
			if (this.WorldLevel != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.WorldLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601628B RID: 90763 RVA: 0x00338C34 File Offset: 0x00336E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.CurLayer != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurLayer);
			}
			if (this.MaxLayer != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxLayer);
			}
			if (this.WorldLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WorldLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601628C RID: 90764 RVA: 0x00338CBC File Offset: 0x00336EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyLastInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.CurLayer != 0)
			{
				this.CurLayer = other.CurLayer;
			}
			if (other.MaxLayer != 0)
			{
				this.MaxLayer = other.MaxLayer;
			}
			if (other.WorldLevel != 0)
			{
				this.WorldLevel = other.WorldLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601628D RID: 90765 RVA: 0x00338D34 File Offset: 0x00336F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601628E RID: 90766 RVA: 0x00338D40 File Offset: 0x00336F40
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
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.CurLayer = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.MaxLayer = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.WorldLevel = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008514 RID: 34068
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008515 RID: 34069
		public const int InstIdFieldNumber = 1;

		// Token: 0x04008516 RID: 34070
		private int instId_;

		// Token: 0x04008517 RID: 34071
		public const int CurLayerFieldNumber = 2;

		// Token: 0x04008518 RID: 34072
		private int curLayer_;

		// Token: 0x04008519 RID: 34073
		public const int MaxLayerFieldNumber = 3;

		// Token: 0x0400851A RID: 34074
		private int maxLayer_;

		// Token: 0x0400851B RID: 34075
		public const int WorldLevelFieldNumber = 4;

		// Token: 0x0400851C RID: 34076
		private int worldLevel_;
	}
}
