using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012B6 RID: 4790
	[NetMessage(EMessageId.SunSpiritActionOperationEndPush)]
	public sealed class SunSpiritActionOperationEndPush : IMessage<SunSpiritActionOperationEndPush>, IMessage, IEquatable<SunSpiritActionOperationEndPush>, IDeepCloneable<SunSpiritActionOperationEndPush>, IBufferMessage
	{
		// Token: 0x060197D0 RID: 104400 RVA: 0x003B44A9 File Offset: 0x003B26A9
		[NullableContext(1)]
		public static SunSpiritActionOperationEndPush Create()
		{
			return new SunSpiritActionOperationEndPush();
		}

		// Token: 0x170055F3 RID: 22003
		// (get) Token: 0x060197D1 RID: 104401 RVA: 0x003B44B0 File Offset: 0x003B26B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055F4 RID: 22004
		// (get) Token: 0x060197D2 RID: 104402 RVA: 0x003B44B3 File Offset: 0x003B26B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SunSpiritActionOperationEndPush.Descriptor;
			}
		}

		// Token: 0x060197D3 RID: 104403 RVA: 0x003B44BA File Offset: 0x003B26BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritActionOperationEndPush()
		{
		}

		// Token: 0x060197D4 RID: 104404 RVA: 0x003B44C2 File Offset: 0x003B26C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritActionOperationEndPush(SunSpiritActionOperationEndPush other) : this()
		{
			this.playerId_ = other.playerId_;
			this.incId_ = other.incId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060197D5 RID: 104405 RVA: 0x003B44FF File Offset: 0x003B26FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritActionOperationEndPush Clone()
		{
			return new SunSpiritActionOperationEndPush(this);
		}

		// Token: 0x170055F5 RID: 22005
		// (get) Token: 0x060197D6 RID: 104406 RVA: 0x003B4507 File Offset: 0x003B2707
		// (set) Token: 0x060197D7 RID: 104407 RVA: 0x003B450F File Offset: 0x003B270F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x170055F6 RID: 22006
		// (get) Token: 0x060197D8 RID: 104408 RVA: 0x003B4518 File Offset: 0x003B2718
		// (set) Token: 0x060197D9 RID: 104409 RVA: 0x003B4520 File Offset: 0x003B2720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x170055F7 RID: 22007
		// (get) Token: 0x060197DA RID: 104410 RVA: 0x003B4529 File Offset: 0x003B2729
		// (set) Token: 0x060197DB RID: 104411 RVA: 0x003B4531 File Offset: 0x003B2731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x060197DC RID: 104412 RVA: 0x003B453A File Offset: 0x003B273A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SunSpiritActionOperationEndPush);
		}

		// Token: 0x060197DD RID: 104413 RVA: 0x003B4548 File Offset: 0x003B2748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SunSpiritActionOperationEndPush other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IncId == other.IncId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060197DE RID: 104414 RVA: 0x003B45A4 File Offset: 0x003B27A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060197DF RID: 104415 RVA: 0x003B4615 File Offset: 0x003B2815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060197E0 RID: 104416 RVA: 0x003B4622 File Offset: 0x003B2822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060197E1 RID: 104417 RVA: 0x003B462C File Offset: 0x003B282C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Index);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060197E2 RID: 104418 RVA: 0x003B46A4 File Offset: 0x003B28A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060197E3 RID: 104419 RVA: 0x003B4714 File Offset: 0x003B2914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SunSpiritActionOperationEndPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060197E4 RID: 104420 RVA: 0x003B4778 File Offset: 0x003B2978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060197E5 RID: 104421 RVA: 0x003B4784 File Offset: 0x003B2984
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
				if (num != 56U)
				{
					if (num != 72U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IncId = input.ReadInt32();
						}
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400958B RID: 38283
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400958C RID: 38284
		public const int PlayerIdFieldNumber = 7;

		// Token: 0x0400958D RID: 38285
		private int playerId_;

		// Token: 0x0400958E RID: 38286
		public const int IncIdFieldNumber = 15;

		// Token: 0x0400958F RID: 38287
		private int incId_;

		// Token: 0x04009590 RID: 38288
		public const int IndexFieldNumber = 9;

		// Token: 0x04009591 RID: 38289
		private int index_;
	}
}
