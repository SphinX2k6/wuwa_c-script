using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200103C RID: 4156
	public sealed class RogueWeeklyLastInfo : IMessage<RogueWeeklyLastInfo>, IMessage, IEquatable<RogueWeeklyLastInfo>, IDeepCloneable<RogueWeeklyLastInfo>, IBufferMessage
	{
		// Token: 0x0601635C RID: 90972 RVA: 0x0033A09C File Offset: 0x0033829C
		[NullableContext(1)]
		public static RogueWeeklyLastInfo Create()
		{
			return new RogueWeeklyLastInfo();
		}

		// Token: 0x17004A40 RID: 19008
		// (get) Token: 0x0601635D RID: 90973 RVA: 0x0033A0A3 File Offset: 0x003382A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A41 RID: 19009
		// (get) Token: 0x0601635E RID: 90974 RVA: 0x0033A0A6 File Offset: 0x003382A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyLastInfo.Descriptor;
			}
		}

		// Token: 0x0601635F RID: 90975 RVA: 0x0033A0AD File Offset: 0x003382AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyLastInfo()
		{
		}

		// Token: 0x06016360 RID: 90976 RVA: 0x0033A0B8 File Offset: 0x003382B8
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

		// Token: 0x06016361 RID: 90977 RVA: 0x0033A10C File Offset: 0x0033830C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyLastInfo Clone()
		{
			return new RogueWeeklyLastInfo(this);
		}

		// Token: 0x17004A42 RID: 19010
		// (get) Token: 0x06016362 RID: 90978 RVA: 0x0033A114 File Offset: 0x00338314
		// (set) Token: 0x06016363 RID: 90979 RVA: 0x0033A11C File Offset: 0x0033831C
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

		// Token: 0x17004A43 RID: 19011
		// (get) Token: 0x06016364 RID: 90980 RVA: 0x0033A125 File Offset: 0x00338325
		// (set) Token: 0x06016365 RID: 90981 RVA: 0x0033A12D File Offset: 0x0033832D
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

		// Token: 0x17004A44 RID: 19012
		// (get) Token: 0x06016366 RID: 90982 RVA: 0x0033A136 File Offset: 0x00338336
		// (set) Token: 0x06016367 RID: 90983 RVA: 0x0033A13E File Offset: 0x0033833E
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

		// Token: 0x17004A45 RID: 19013
		// (get) Token: 0x06016368 RID: 90984 RVA: 0x0033A147 File Offset: 0x00338347
		// (set) Token: 0x06016369 RID: 90985 RVA: 0x0033A14F File Offset: 0x0033834F
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

		// Token: 0x0601636A RID: 90986 RVA: 0x0033A158 File Offset: 0x00338358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyLastInfo);
		}

		// Token: 0x0601636B RID: 90987 RVA: 0x0033A168 File Offset: 0x00338368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyLastInfo other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.CurLayer == other.CurLayer && this.MaxLayer == other.MaxLayer && this.WorldLevel == other.WorldLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601636C RID: 90988 RVA: 0x0033A1D4 File Offset: 0x003383D4
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

		// Token: 0x0601636D RID: 90989 RVA: 0x0033A25E File Offset: 0x0033845E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601636E RID: 90990 RVA: 0x0033A26B File Offset: 0x0033846B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601636F RID: 90991 RVA: 0x0033A274 File Offset: 0x00338474
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

		// Token: 0x06016370 RID: 90992 RVA: 0x0033A304 File Offset: 0x00338504
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

		// Token: 0x06016371 RID: 90993 RVA: 0x0033A38C File Offset: 0x0033858C
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

		// Token: 0x06016372 RID: 90994 RVA: 0x0033A404 File Offset: 0x00338604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016373 RID: 90995 RVA: 0x0033A410 File Offset: 0x00338610
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

		// Token: 0x040084EA RID: 34026
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084EB RID: 34027
		public const int InstIdFieldNumber = 1;

		// Token: 0x040084EC RID: 34028
		private int instId_;

		// Token: 0x040084ED RID: 34029
		public const int CurLayerFieldNumber = 2;

		// Token: 0x040084EE RID: 34030
		private int curLayer_;

		// Token: 0x040084EF RID: 34031
		public const int MaxLayerFieldNumber = 3;

		// Token: 0x040084F0 RID: 34032
		private int maxLayer_;

		// Token: 0x040084F1 RID: 34033
		public const int WorldLevelFieldNumber = 4;

		// Token: 0x040084F2 RID: 34034
		private int worldLevel_;
	}
}
