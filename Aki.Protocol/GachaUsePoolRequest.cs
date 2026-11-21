using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200068E RID: 1678
	[NetMessage(EMessageId.GachaUsePoolRequest)]
	public sealed class GachaUsePoolRequest : IMessage<GachaUsePoolRequest>, IMessage, IEquatable<GachaUsePoolRequest>, IDeepCloneable<GachaUsePoolRequest>, IBufferMessage
	{
		// Token: 0x06009A0E RID: 39438 RVA: 0x00174328 File Offset: 0x00172528
		[NullableContext(1)]
		public static GachaUsePoolRequest Create()
		{
			return new GachaUsePoolRequest();
		}

		// Token: 0x17001ECE RID: 7886
		// (get) Token: 0x06009A0F RID: 39439 RVA: 0x0017432F File Offset: 0x0017252F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001ECF RID: 7887
		// (get) Token: 0x06009A10 RID: 39440 RVA: 0x00174332 File Offset: 0x00172532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaUsePoolRequest.Descriptor;
			}
		}

		// Token: 0x06009A11 RID: 39441 RVA: 0x00174339 File Offset: 0x00172539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaUsePoolRequest()
		{
		}

		// Token: 0x06009A12 RID: 39442 RVA: 0x00174341 File Offset: 0x00172541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaUsePoolRequest(GachaUsePoolRequest other) : this()
		{
			this.gachaId_ = other.gachaId_;
			this.poolId_ = other.poolId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009A13 RID: 39443 RVA: 0x00174372 File Offset: 0x00172572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaUsePoolRequest Clone()
		{
			return new GachaUsePoolRequest(this);
		}

		// Token: 0x17001ED0 RID: 7888
		// (get) Token: 0x06009A14 RID: 39444 RVA: 0x0017437A File Offset: 0x0017257A
		// (set) Token: 0x06009A15 RID: 39445 RVA: 0x00174382 File Offset: 0x00172582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GachaId
		{
			get
			{
				return this.gachaId_;
			}
			set
			{
				this.gachaId_ = value;
			}
		}

		// Token: 0x17001ED1 RID: 7889
		// (get) Token: 0x06009A16 RID: 39446 RVA: 0x0017438B File Offset: 0x0017258B
		// (set) Token: 0x06009A17 RID: 39447 RVA: 0x00174393 File Offset: 0x00172593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PoolId
		{
			get
			{
				return this.poolId_;
			}
			set
			{
				this.poolId_ = value;
			}
		}

		// Token: 0x06009A18 RID: 39448 RVA: 0x0017439C File Offset: 0x0017259C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaUsePoolRequest);
		}

		// Token: 0x06009A19 RID: 39449 RVA: 0x001743AA File Offset: 0x001725AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaUsePoolRequest other)
		{
			return other != null && (other == this || (this.GachaId == other.GachaId && this.PoolId == other.PoolId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009A1A RID: 39450 RVA: 0x001743E8 File Offset: 0x001725E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GachaId != 0)
			{
				num ^= this.GachaId.GetHashCode();
			}
			if (this.PoolId != 0)
			{
				num ^= this.PoolId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009A1B RID: 39451 RVA: 0x00174440 File Offset: 0x00172640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009A1C RID: 39452 RVA: 0x0017444D File Offset: 0x0017264D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009A1D RID: 39453 RVA: 0x00174458 File Offset: 0x00172658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PoolId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PoolId);
			}
			if (this.GachaId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.GachaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009A1E RID: 39454 RVA: 0x001744B0 File Offset: 0x001726B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GachaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GachaId);
			}
			if (this.PoolId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PoolId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009A1F RID: 39455 RVA: 0x00174508 File Offset: 0x00172708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaUsePoolRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GachaId != 0)
			{
				this.GachaId = other.GachaId;
			}
			if (other.PoolId != 0)
			{
				this.PoolId = other.PoolId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009A20 RID: 39456 RVA: 0x00174558 File Offset: 0x00172758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009A21 RID: 39457 RVA: 0x00174564 File Offset: 0x00172764
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
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GachaId = input.ReadInt32();
					}
				}
				else
				{
					this.PoolId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004959 RID: 18777
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400495A RID: 18778
		public const int GachaIdFieldNumber = 9;

		// Token: 0x0400495B RID: 18779
		private int gachaId_;

		// Token: 0x0400495C RID: 18780
		public const int PoolIdFieldNumber = 1;

		// Token: 0x0400495D RID: 18781
		private int poolId_;
	}
}
