using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D6E RID: 3438
	[NetMessage(EMessageId.PlayerAoiRangeNotify)]
	public sealed class PlayerAoiRangeNotify : IMessage<PlayerAoiRangeNotify>, IMessage, IEquatable<PlayerAoiRangeNotify>, IDeepCloneable<PlayerAoiRangeNotify>, IBufferMessage
	{
		// Token: 0x060128E8 RID: 76008 RVA: 0x002B57E6 File Offset: 0x002B39E6
		[NullableContext(1)]
		public static PlayerAoiRangeNotify Create()
		{
			return new PlayerAoiRangeNotify();
		}

		// Token: 0x17003D84 RID: 15748
		// (get) Token: 0x060128E9 RID: 76009 RVA: 0x002B57ED File Offset: 0x002B39ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D85 RID: 15749
		// (get) Token: 0x060128EA RID: 76010 RVA: 0x002B57F0 File Offset: 0x002B39F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerAoiRangeNotify.Descriptor;
			}
		}

		// Token: 0x060128EB RID: 76011 RVA: 0x002B57F7 File Offset: 0x002B39F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAoiRangeNotify()
		{
		}

		// Token: 0x060128EC RID: 76012 RVA: 0x002B5800 File Offset: 0x002B3A00
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

		// Token: 0x060128ED RID: 76013 RVA: 0x002B5854 File Offset: 0x002B3A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAoiRangeNotify Clone()
		{
			return new PlayerAoiRangeNotify(this);
		}

		// Token: 0x17003D86 RID: 15750
		// (get) Token: 0x060128EE RID: 76014 RVA: 0x002B585C File Offset: 0x002B3A5C
		// (set) Token: 0x060128EF RID: 76015 RVA: 0x002B5864 File Offset: 0x002B3A64
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

		// Token: 0x17003D87 RID: 15751
		// (get) Token: 0x060128F0 RID: 76016 RVA: 0x002B586D File Offset: 0x002B3A6D
		// (set) Token: 0x060128F1 RID: 76017 RVA: 0x002B5875 File Offset: 0x002B3A75
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

		// Token: 0x17003D88 RID: 15752
		// (get) Token: 0x060128F2 RID: 76018 RVA: 0x002B587E File Offset: 0x002B3A7E
		// (set) Token: 0x060128F3 RID: 76019 RVA: 0x002B5886 File Offset: 0x002B3A86
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

		// Token: 0x17003D89 RID: 15753
		// (get) Token: 0x060128F4 RID: 76020 RVA: 0x002B588F File Offset: 0x002B3A8F
		// (set) Token: 0x060128F5 RID: 76021 RVA: 0x002B5897 File Offset: 0x002B3A97
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

		// Token: 0x060128F6 RID: 76022 RVA: 0x002B58A0 File Offset: 0x002B3AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerAoiRangeNotify);
		}

		// Token: 0x060128F7 RID: 76023 RVA: 0x002B58B0 File Offset: 0x002B3AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerAoiRangeNotify other)
		{
			return other != null && (other == this || (this.MinX == other.MinX && this.MaxX == other.MaxX && this.MinY == other.MinY && this.MaxY == other.MaxY && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060128F8 RID: 76024 RVA: 0x002B591C File Offset: 0x002B3B1C
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

		// Token: 0x060128F9 RID: 76025 RVA: 0x002B59A6 File Offset: 0x002B3BA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060128FA RID: 76026 RVA: 0x002B59B3 File Offset: 0x002B3BB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060128FB RID: 76027 RVA: 0x002B59BC File Offset: 0x002B3BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxY != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MaxY);
			}
			if (this.MinY != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MinY);
			}
			if (this.MinX != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.MinX);
			}
			if (this.MaxX != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.MaxX);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060128FC RID: 76028 RVA: 0x002B5A4C File Offset: 0x002B3C4C
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

		// Token: 0x060128FD RID: 76029 RVA: 0x002B5AD4 File Offset: 0x002B3CD4
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

		// Token: 0x060128FE RID: 76030 RVA: 0x002B5B4C File Offset: 0x002B3D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060128FF RID: 76031 RVA: 0x002B5B58 File Offset: 0x002B3D58
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.MaxY = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.MinY = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.MinX = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.MaxX = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040073A1 RID: 29601
		private UnknownFieldSet _unknownFields;

		// Token: 0x040073A2 RID: 29602
		public const int MinXFieldNumber = 9;

		// Token: 0x040073A3 RID: 29603
		private int minX_;

		// Token: 0x040073A4 RID: 29604
		public const int MaxXFieldNumber = 10;

		// Token: 0x040073A5 RID: 29605
		private int maxX_;

		// Token: 0x040073A6 RID: 29606
		public const int MinYFieldNumber = 3;

		// Token: 0x040073A7 RID: 29607
		private int minY_;

		// Token: 0x040073A8 RID: 29608
		public const int MaxYFieldNumber = 1;

		// Token: 0x040073A9 RID: 29609
		private int maxY_;
	}
}
