using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D7E RID: 3454
	[NetMessage(EMessageId.PlayerAoiRangeNotify)]
	public sealed class PlayerAoiRangeNotify : IMessage<PlayerAoiRangeNotify>, IMessage, IEquatable<PlayerAoiRangeNotify>, IDeepCloneable<PlayerAoiRangeNotify>, IBufferMessage
	{
		// Token: 0x060129E4 RID: 76260 RVA: 0x002B7406 File Offset: 0x002B5606
		[NullableContext(1)]
		public static PlayerAoiRangeNotify Create()
		{
			return new PlayerAoiRangeNotify();
		}

		// Token: 0x17003DB9 RID: 15801
		// (get) Token: 0x060129E5 RID: 76261 RVA: 0x002B740D File Offset: 0x002B560D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DBA RID: 15802
		// (get) Token: 0x060129E6 RID: 76262 RVA: 0x002B7410 File Offset: 0x002B5610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerAoiRangeNotify.Descriptor;
			}
		}

		// Token: 0x060129E7 RID: 76263 RVA: 0x002B7417 File Offset: 0x002B5617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAoiRangeNotify()
		{
		}

		// Token: 0x060129E8 RID: 76264 RVA: 0x002B7420 File Offset: 0x002B5620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAoiRangeNotify(PlayerAoiRangeNotify other) : this()
		{
			this.minX_ = other.minX_;
			this.maxX_ = other.maxX_;
			this.minY_ = other.minY_;
			this.maxY_ = other.maxY_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060129E9 RID: 76265 RVA: 0x002B7474 File Offset: 0x002B5674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAoiRangeNotify Clone()
		{
			return new PlayerAoiRangeNotify(this);
		}

		// Token: 0x17003DBB RID: 15803
		// (get) Token: 0x060129EA RID: 76266 RVA: 0x002B747C File Offset: 0x002B567C
		// (set) Token: 0x060129EB RID: 76267 RVA: 0x002B7484 File Offset: 0x002B5684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MinX
		{
			get
			{
				return this.minX_;
			}
			set
			{
				this.minX_ = value;
			}
		}

		// Token: 0x17003DBC RID: 15804
		// (get) Token: 0x060129EC RID: 76268 RVA: 0x002B748D File Offset: 0x002B568D
		// (set) Token: 0x060129ED RID: 76269 RVA: 0x002B7495 File Offset: 0x002B5695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxX
		{
			get
			{
				return this.maxX_;
			}
			set
			{
				this.maxX_ = value;
			}
		}

		// Token: 0x17003DBD RID: 15805
		// (get) Token: 0x060129EE RID: 76270 RVA: 0x002B749E File Offset: 0x002B569E
		// (set) Token: 0x060129EF RID: 76271 RVA: 0x002B74A6 File Offset: 0x002B56A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MinY
		{
			get
			{
				return this.minY_;
			}
			set
			{
				this.minY_ = value;
			}
		}

		// Token: 0x17003DBE RID: 15806
		// (get) Token: 0x060129F0 RID: 76272 RVA: 0x002B74AF File Offset: 0x002B56AF
		// (set) Token: 0x060129F1 RID: 76273 RVA: 0x002B74B7 File Offset: 0x002B56B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxY
		{
			get
			{
				return this.maxY_;
			}
			set
			{
				this.maxY_ = value;
			}
		}

		// Token: 0x060129F2 RID: 76274 RVA: 0x002B74C0 File Offset: 0x002B56C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerAoiRangeNotify);
		}

		// Token: 0x060129F3 RID: 76275 RVA: 0x002B74D0 File Offset: 0x002B56D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerAoiRangeNotify other)
		{
			return other != null && (other == this || (this.MinX == other.MinX && this.MaxX == other.MaxX && this.MinY == other.MinY && this.MaxY == other.MaxY && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060129F4 RID: 76276 RVA: 0x002B753C File Offset: 0x002B573C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MinX != 0)
			{
				num ^= this.MinX.GetHashCode();
			}
			if (this.MaxX != 0)
			{
				num ^= this.MaxX.GetHashCode();
			}
			if (this.MinY != 0)
			{
				num ^= this.MinY.GetHashCode();
			}
			if (this.MaxY != 0)
			{
				num ^= this.MaxY.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060129F5 RID: 76277 RVA: 0x002B75C6 File Offset: 0x002B57C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060129F6 RID: 76278 RVA: 0x002B75D3 File Offset: 0x002B57D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060129F7 RID: 76279 RVA: 0x002B75DC File Offset: 0x002B57DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxX != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MaxX);
			}
			if (this.MaxY != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MaxY);
			}
			if (this.MinX != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.MinX);
			}
			if (this.MinY != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.MinY);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060129F8 RID: 76280 RVA: 0x002B766C File Offset: 0x002B586C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MinX != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MinX);
			}
			if (this.MaxX != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxX);
			}
			if (this.MinY != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MinY);
			}
			if (this.MaxY != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxY);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060129F9 RID: 76281 RVA: 0x002B76F4 File Offset: 0x002B58F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerAoiRangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MinX != 0)
			{
				this.MinX = other.MinX;
			}
			if (other.MaxX != 0)
			{
				this.MaxX = other.MaxX;
			}
			if (other.MinY != 0)
			{
				this.MinY = other.MinY;
			}
			if (other.MaxY != 0)
			{
				this.MaxY = other.MaxY;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060129FA RID: 76282 RVA: 0x002B776C File Offset: 0x002B596C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060129FB RID: 76283 RVA: 0x002B7778 File Offset: 0x002B5978
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
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.MaxX = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.MaxY = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.MinX = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.MinY = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007389 RID: 29577
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400738A RID: 29578
		public const int MinXFieldNumber = 7;

		// Token: 0x0400738B RID: 29579
		private int minX_;

		// Token: 0x0400738C RID: 29580
		public const int MaxXFieldNumber = 1;

		// Token: 0x0400738D RID: 29581
		private int maxX_;

		// Token: 0x0400738E RID: 29582
		public const int MinYFieldNumber = 9;

		// Token: 0x0400738F RID: 29583
		private int minY_;

		// Token: 0x04007390 RID: 29584
		public const int MaxYFieldNumber = 4;

		// Token: 0x04007391 RID: 29585
		private int maxY_;
	}
}
