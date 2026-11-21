using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001435 RID: 5173
	public sealed class TowerLevel : IMessage<TowerLevel>, IMessage, IEquatable<TowerLevel>, IDeepCloneable<TowerLevel>, IBufferMessage
	{
		// Token: 0x0601B7D3 RID: 112595 RVA: 0x003FF070 File Offset: 0x003FD270
		[NullableContext(1)]
		public static TowerLevel Create()
		{
			return new TowerLevel();
		}

		// Token: 0x17005D11 RID: 23825
		// (get) Token: 0x0601B7D4 RID: 112596 RVA: 0x003FF077 File Offset: 0x003FD277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D12 RID: 23826
		// (get) Token: 0x0601B7D5 RID: 112597 RVA: 0x003FF07A File Offset: 0x003FD27A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerLevel.Descriptor;
			}
		}

		// Token: 0x0601B7D6 RID: 112598 RVA: 0x003FF081 File Offset: 0x003FD281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerLevel()
		{
		}

		// Token: 0x0601B7D7 RID: 112599 RVA: 0x003FF089 File Offset: 0x003FD289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerLevel(TowerLevel other) : this()
		{
			this.starByte_ = other.starByte_;
			this.costTime_ = other.costTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B7D8 RID: 112600 RVA: 0x003FF0BA File Offset: 0x003FD2BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerLevel Clone()
		{
			return new TowerLevel(this);
		}

		// Token: 0x17005D13 RID: 23827
		// (get) Token: 0x0601B7D9 RID: 112601 RVA: 0x003FF0C2 File Offset: 0x003FD2C2
		// (set) Token: 0x0601B7DA RID: 112602 RVA: 0x003FF0CA File Offset: 0x003FD2CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StarByte
		{
			get
			{
				return this.starByte_;
			}
			set
			{
				this.starByte_ = value;
			}
		}

		// Token: 0x17005D14 RID: 23828
		// (get) Token: 0x0601B7DB RID: 112603 RVA: 0x003FF0D3 File Offset: 0x003FD2D3
		// (set) Token: 0x0601B7DC RID: 112604 RVA: 0x003FF0DB File Offset: 0x003FD2DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CostTime
		{
			get
			{
				return this.costTime_;
			}
			set
			{
				this.costTime_ = value;
			}
		}

		// Token: 0x0601B7DD RID: 112605 RVA: 0x003FF0E4 File Offset: 0x003FD2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerLevel);
		}

		// Token: 0x0601B7DE RID: 112606 RVA: 0x003FF0F2 File Offset: 0x003FD2F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerLevel other)
		{
			return other != null && (other == this || (this.StarByte == other.StarByte && this.CostTime == other.CostTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B7DF RID: 112607 RVA: 0x003FF130 File Offset: 0x003FD330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StarByte != 0)
			{
				num ^= this.StarByte.GetHashCode();
			}
			if (this.CostTime != 0)
			{
				num ^= this.CostTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B7E0 RID: 112608 RVA: 0x003FF188 File Offset: 0x003FD388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B7E1 RID: 112609 RVA: 0x003FF195 File Offset: 0x003FD395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B7E2 RID: 112610 RVA: 0x003FF1A0 File Offset: 0x003FD3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StarByte != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.StarByte);
			}
			if (this.CostTime != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CostTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B7E3 RID: 112611 RVA: 0x003FF1F8 File Offset: 0x003FD3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StarByte != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StarByte);
			}
			if (this.CostTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CostTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B7E4 RID: 112612 RVA: 0x003FF250 File Offset: 0x003FD450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerLevel other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StarByte != 0)
			{
				this.StarByte = other.StarByte;
			}
			if (other.CostTime != 0)
			{
				this.CostTime = other.CostTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B7E5 RID: 112613 RVA: 0x003FF2A0 File Offset: 0x003FD4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B7E6 RID: 112614 RVA: 0x003FF2AC File Offset: 0x003FD4AC
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
						this.CostTime = input.ReadInt32();
					}
				}
				else
				{
					this.StarByte = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009FFD RID: 40957
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FFE RID: 40958
		public const int StarByteFieldNumber = 1;

		// Token: 0x04009FFF RID: 40959
		private int starByte_;

		// Token: 0x0400A000 RID: 40960
		public const int CostTimeFieldNumber = 2;

		// Token: 0x0400A001 RID: 40961
		private int costTime_;
	}
}
