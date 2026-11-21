using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000783 RID: 1923
	public sealed class HonamiStoryPosInfo : IMessage<HonamiStoryPosInfo>, IMessage, IEquatable<HonamiStoryPosInfo>, IDeepCloneable<HonamiStoryPosInfo>, IBufferMessage
	{
		// Token: 0x0600ADF2 RID: 44530 RVA: 0x001A21F4 File Offset: 0x001A03F4
		[NullableContext(1)]
		public static HonamiStoryPosInfo Create()
		{
			return new HonamiStoryPosInfo();
		}

		// Token: 0x17002311 RID: 8977
		// (get) Token: 0x0600ADF3 RID: 44531 RVA: 0x001A21FB File Offset: 0x001A03FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002312 RID: 8978
		// (get) Token: 0x0600ADF4 RID: 44532 RVA: 0x001A21FE File Offset: 0x001A03FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryPosInfo.Descriptor;
			}
		}

		// Token: 0x0600ADF5 RID: 44533 RVA: 0x001A2205 File Offset: 0x001A0405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPosInfo()
		{
		}

		// Token: 0x0600ADF6 RID: 44534 RVA: 0x001A220D File Offset: 0x001A040D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPosInfo(HonamiStoryPosInfo other) : this()
		{
			this.isCross_ = other.isCross_;
			this.position_ = other.position_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ADF7 RID: 44535 RVA: 0x001A223E File Offset: 0x001A043E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPosInfo Clone()
		{
			return new HonamiStoryPosInfo(this);
		}

		// Token: 0x17002313 RID: 8979
		// (get) Token: 0x0600ADF8 RID: 44536 RVA: 0x001A2246 File Offset: 0x001A0446
		// (set) Token: 0x0600ADF9 RID: 44537 RVA: 0x001A224E File Offset: 0x001A044E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCross
		{
			get
			{
				return this.isCross_;
			}
			set
			{
				this.isCross_ = value;
			}
		}

		// Token: 0x17002314 RID: 8980
		// (get) Token: 0x0600ADFA RID: 44538 RVA: 0x001A2257 File Offset: 0x001A0457
		// (set) Token: 0x0600ADFB RID: 44539 RVA: 0x001A225F File Offset: 0x001A045F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Position
		{
			get
			{
				return this.position_;
			}
			set
			{
				this.position_ = value;
			}
		}

		// Token: 0x0600ADFC RID: 44540 RVA: 0x001A2268 File Offset: 0x001A0468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryPosInfo);
		}

		// Token: 0x0600ADFD RID: 44541 RVA: 0x001A2276 File Offset: 0x001A0476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryPosInfo other)
		{
			return other != null && (other == this || (this.IsCross == other.IsCross && this.Position == other.Position && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ADFE RID: 44542 RVA: 0x001A22B4 File Offset: 0x001A04B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsCross)
			{
				num ^= this.IsCross.GetHashCode();
			}
			if (this.Position != 0)
			{
				num ^= this.Position.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ADFF RID: 44543 RVA: 0x001A230C File Offset: 0x001A050C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AE00 RID: 44544 RVA: 0x001A2319 File Offset: 0x001A0519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE01 RID: 44545 RVA: 0x001A2324 File Offset: 0x001A0524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsCross)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsCross);
			}
			if (this.Position != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Position);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE02 RID: 44546 RVA: 0x001A237C File Offset: 0x001A057C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsCross)
			{
				num += 2;
			}
			if (this.Position != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Position);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AE03 RID: 44547 RVA: 0x001A23C8 File Offset: 0x001A05C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryPosInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsCross)
			{
				this.IsCross = other.IsCross;
			}
			if (other.Position != 0)
			{
				this.Position = other.Position;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AE04 RID: 44548 RVA: 0x001A2418 File Offset: 0x001A0618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE05 RID: 44549 RVA: 0x001A2424 File Offset: 0x001A0624
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Position = input.ReadInt32();
					}
				}
				else
				{
					this.IsCross = input.ReadBool();
				}
			}
		}

		// Token: 0x04004EE6 RID: 20198
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EE7 RID: 20199
		public const int IsCrossFieldNumber = 1;

		// Token: 0x04004EE8 RID: 20200
		private bool isCross_;

		// Token: 0x04004EE9 RID: 20201
		public const int PositionFieldNumber = 2;

		// Token: 0x04004EEA RID: 20202
		private int position_;
	}
}
