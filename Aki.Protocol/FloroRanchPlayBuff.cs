using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005A2 RID: 1442
	public sealed class FloroRanchPlayBuff : IMessage<FloroRanchPlayBuff>, IMessage, IEquatable<FloroRanchPlayBuff>, IDeepCloneable<FloroRanchPlayBuff>, IBufferMessage
	{
		// Token: 0x060085B5 RID: 34229 RVA: 0x00141DF9 File Offset: 0x0013FFF9
		[NullableContext(1)]
		public static FloroRanchPlayBuff Create()
		{
			return new FloroRanchPlayBuff();
		}

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x060085B6 RID: 34230 RVA: 0x00141E00 File Offset: 0x00140000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FloroRanchPlayBuff> Parser
		{
			get
			{
				return FloroRanchPlayBuff._parser;
			}
		}

		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x060085B7 RID: 34231 RVA: 0x00141E07 File Offset: 0x00140007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x060085B8 RID: 34232 RVA: 0x00141E0A File Offset: 0x0014000A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayBuff.Descriptor;
			}
		}

		// Token: 0x060085B9 RID: 34233 RVA: 0x00141E11 File Offset: 0x00140011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayBuff()
		{
		}

		// Token: 0x060085BA RID: 34234 RVA: 0x00141E1C File Offset: 0x0014001C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayBuff(FloroRanchPlayBuff other) : this()
		{
			this.playIncId_ = other.playIncId_;
			this.id_ = other.id_;
			this.point_ = other.point_;
			this.day_ = other.day_;
			this.plies_ = other.plies_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060085BB RID: 34235 RVA: 0x00141E7C File Offset: 0x0014007C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayBuff Clone()
		{
			return new FloroRanchPlayBuff(this);
		}

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x060085BC RID: 34236 RVA: 0x00141E84 File Offset: 0x00140084
		// (set) Token: 0x060085BD RID: 34237 RVA: 0x00141E8C File Offset: 0x0014008C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayIncId
		{
			get
			{
				return this.playIncId_;
			}
			set
			{
				this.playIncId_ = value;
			}
		}

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x060085BE RID: 34238 RVA: 0x00141E95 File Offset: 0x00140095
		// (set) Token: 0x060085BF RID: 34239 RVA: 0x00141E9D File Offset: 0x0014009D
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

		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x060085C0 RID: 34240 RVA: 0x00141EA6 File Offset: 0x001400A6
		// (set) Token: 0x060085C1 RID: 34241 RVA: 0x00141EAE File Offset: 0x001400AE
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

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x060085C2 RID: 34242 RVA: 0x00141EB7 File Offset: 0x001400B7
		// (set) Token: 0x060085C3 RID: 34243 RVA: 0x00141EBF File Offset: 0x001400BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Day
		{
			get
			{
				return this.day_;
			}
			set
			{
				this.day_ = value;
			}
		}

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x060085C4 RID: 34244 RVA: 0x00141EC8 File Offset: 0x001400C8
		// (set) Token: 0x060085C5 RID: 34245 RVA: 0x00141ED0 File Offset: 0x001400D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Plies
		{
			get
			{
				return this.plies_;
			}
			set
			{
				this.plies_ = value;
			}
		}

		// Token: 0x060085C6 RID: 34246 RVA: 0x00141ED9 File Offset: 0x001400D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayBuff);
		}

		// Token: 0x060085C7 RID: 34247 RVA: 0x00141EE8 File Offset: 0x001400E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayBuff other)
		{
			return other != null && (other == this || (this.PlayIncId == other.PlayIncId && this.Id == other.Id && this.Point == other.Point && this.Day == other.Day && this.Plies == other.Plies && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060085C8 RID: 34248 RVA: 0x00141F64 File Offset: 0x00140164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayIncId != 0)
			{
				num ^= this.PlayIncId.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Point != 0)
			{
				num ^= this.Point.GetHashCode();
			}
			if (this.Day != 0)
			{
				num ^= this.Day.GetHashCode();
			}
			if (this.Plies != 0)
			{
				num ^= this.Plies.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060085C9 RID: 34249 RVA: 0x00142007 File Offset: 0x00140207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060085CA RID: 34250 RVA: 0x00142014 File Offset: 0x00140214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060085CB RID: 34251 RVA: 0x00142020 File Offset: 0x00140220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayIncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayIncId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this.Point != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Point);
			}
			if (this.Day != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Day);
			}
			if (this.Plies != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Plies);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060085CC RID: 34252 RVA: 0x001420CC File Offset: 0x001402CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayIncId);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Point != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Point);
			}
			if (this.Day != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Day);
			}
			if (this.Plies != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Plies);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060085CD RID: 34253 RVA: 0x0014216C File Offset: 0x0014036C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayBuff other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayIncId != 0)
			{
				this.PlayIncId = other.PlayIncId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Point != 0)
			{
				this.Point = other.Point;
			}
			if (other.Day != 0)
			{
				this.Day = other.Day;
			}
			if (other.Plies != 0)
			{
				this.Plies = other.Plies;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060085CE RID: 34254 RVA: 0x001421F8 File Offset: 0x001403F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060085CF RID: 34255 RVA: 0x00142204 File Offset: 0x00140404
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
						this.PlayIncId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Point = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Day = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Plies = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400427A RID: 17018
		private static readonly MessageParser<FloroRanchPlayBuff> _parser = new MessageParser<FloroRanchPlayBuff>(() => new FloroRanchPlayBuff());

		// Token: 0x0400427B RID: 17019
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400427C RID: 17020
		public const int PlayIncIdFieldNumber = 1;

		// Token: 0x0400427D RID: 17021
		private int playIncId_;

		// Token: 0x0400427E RID: 17022
		public const int IdFieldNumber = 2;

		// Token: 0x0400427F RID: 17023
		private int id_;

		// Token: 0x04004280 RID: 17024
		public const int PointFieldNumber = 3;

		// Token: 0x04004281 RID: 17025
		private int point_;

		// Token: 0x04004282 RID: 17026
		public const int DayFieldNumber = 4;

		// Token: 0x04004283 RID: 17027
		private int day_;

		// Token: 0x04004284 RID: 17028
		public const int PliesFieldNumber = 5;

		// Token: 0x04004285 RID: 17029
		private int plies_;
	}
}
