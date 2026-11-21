using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E6E RID: 3694
	public sealed class RacingBetsTransmitData : IMessage<RacingBetsTransmitData>, IMessage, IEquatable<RacingBetsTransmitData>, IDeepCloneable<RacingBetsTransmitData>, IBufferMessage
	{
		// Token: 0x06013DE2 RID: 81378 RVA: 0x002E51A7 File Offset: 0x002E33A7
		[NullableContext(1)]
		public static RacingBetsTransmitData Create()
		{
			return new RacingBetsTransmitData();
		}

		// Token: 0x17004215 RID: 16917
		// (get) Token: 0x06013DE3 RID: 81379 RVA: 0x002E51AE File Offset: 0x002E33AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsTransmitData> Parser
		{
			get
			{
				return RacingBetsTransmitData._parser;
			}
		}

		// Token: 0x17004216 RID: 16918
		// (get) Token: 0x06013DE4 RID: 81380 RVA: 0x002E51B5 File Offset: 0x002E33B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004217 RID: 16919
		// (get) Token: 0x06013DE5 RID: 81381 RVA: 0x002E51B8 File Offset: 0x002E33B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsTransmitData.Descriptor;
			}
		}

		// Token: 0x06013DE6 RID: 81382 RVA: 0x002E51BF File Offset: 0x002E33BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTransmitData()
		{
		}

		// Token: 0x06013DE7 RID: 81383 RVA: 0x002E51C7 File Offset: 0x002E33C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTransmitData(RacingBetsTransmitData other) : this()
		{
			this.dangoId_ = other.dangoId_;
			this.point_ = other.point_;
			this.high_ = other.high_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013DE8 RID: 81384 RVA: 0x002E5204 File Offset: 0x002E3404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTransmitData Clone()
		{
			return new RacingBetsTransmitData(this);
		}

		// Token: 0x17004218 RID: 16920
		// (get) Token: 0x06013DE9 RID: 81385 RVA: 0x002E520C File Offset: 0x002E340C
		// (set) Token: 0x06013DEA RID: 81386 RVA: 0x002E5214 File Offset: 0x002E3414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DangoId
		{
			get
			{
				return this.dangoId_;
			}
			set
			{
				this.dangoId_ = value;
			}
		}

		// Token: 0x17004219 RID: 16921
		// (get) Token: 0x06013DEB RID: 81387 RVA: 0x002E521D File Offset: 0x002E341D
		// (set) Token: 0x06013DEC RID: 81388 RVA: 0x002E5225 File Offset: 0x002E3425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Point
		{
			get
			{
				return this.point_;
			}
			set
			{
				this.point_ = value;
			}
		}

		// Token: 0x1700421A RID: 16922
		// (get) Token: 0x06013DED RID: 81389 RVA: 0x002E522E File Offset: 0x002E342E
		// (set) Token: 0x06013DEE RID: 81390 RVA: 0x002E5236 File Offset: 0x002E3436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int High
		{
			get
			{
				return this.high_;
			}
			set
			{
				this.high_ = value;
			}
		}

		// Token: 0x06013DEF RID: 81391 RVA: 0x002E523F File Offset: 0x002E343F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsTransmitData);
		}

		// Token: 0x06013DF0 RID: 81392 RVA: 0x002E5250 File Offset: 0x002E3450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsTransmitData other)
		{
			return other != null && (other == this || (this.DangoId == other.DangoId && this.Point == other.Point && this.High == other.High && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013DF1 RID: 81393 RVA: 0x002E52AC File Offset: 0x002E34AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DangoId != 0)
			{
				num ^= this.DangoId.GetHashCode();
			}
			if (this.Point != 0)
			{
				num ^= this.Point.GetHashCode();
			}
			if (this.High != 0)
			{
				num ^= this.High.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013DF2 RID: 81394 RVA: 0x002E531D File Offset: 0x002E351D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013DF3 RID: 81395 RVA: 0x002E532A File Offset: 0x002E352A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013DF4 RID: 81396 RVA: 0x002E5334 File Offset: 0x002E3534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DangoId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DangoId);
			}
			if (this.Point != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Point);
			}
			if (this.High != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.High);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013DF5 RID: 81397 RVA: 0x002E53A8 File Offset: 0x002E35A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DangoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DangoId);
			}
			if (this.Point != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Point);
			}
			if (this.High != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.High);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013DF6 RID: 81398 RVA: 0x002E5418 File Offset: 0x002E3618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsTransmitData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DangoId != 0)
			{
				this.DangoId = other.DangoId;
			}
			if (other.Point != 0)
			{
				this.Point = other.Point;
			}
			if (other.High != 0)
			{
				this.High = other.High;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013DF7 RID: 81399 RVA: 0x002E547C File Offset: 0x002E367C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013DF8 RID: 81400 RVA: 0x002E5488 File Offset: 0x002E3688
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.High = input.ReadInt32();
						}
					}
					else
					{
						this.Point = input.ReadInt32();
					}
				}
				else
				{
					this.DangoId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040079E5 RID: 31205
		private static readonly MessageParser<RacingBetsTransmitData> _parser = new MessageParser<RacingBetsTransmitData>(() => new RacingBetsTransmitData());

		// Token: 0x040079E6 RID: 31206
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079E7 RID: 31207
		public const int DangoIdFieldNumber = 1;

		// Token: 0x040079E8 RID: 31208
		private int dangoId_;

		// Token: 0x040079E9 RID: 31209
		public const int PointFieldNumber = 2;

		// Token: 0x040079EA RID: 31210
		private int point_;

		// Token: 0x040079EB RID: 31211
		public const int HighFieldNumber = 3;

		// Token: 0x040079EC RID: 31212
		private int high_;
	}
}
