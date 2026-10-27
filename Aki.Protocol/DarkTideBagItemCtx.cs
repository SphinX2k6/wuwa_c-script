using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000398 RID: 920
	public sealed class DarkTideBagItemCtx : IMessage<DarkTideBagItemCtx>, IMessage, IEquatable<DarkTideBagItemCtx>, IDeepCloneable<DarkTideBagItemCtx>, IBufferMessage
	{
		// Token: 0x06005ABF RID: 23231 RVA: 0x000DCCA8 File Offset: 0x000DAEA8
		[NullableContext(1)]
		public static DarkTideBagItemCtx Create()
		{
			return new DarkTideBagItemCtx();
		}

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x06005AC0 RID: 23232 RVA: 0x000DCCAF File Offset: 0x000DAEAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x06005AC1 RID: 23233 RVA: 0x000DCCB2 File Offset: 0x000DAEB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideBagItemCtx.Descriptor;
			}
		}

		// Token: 0x06005AC2 RID: 23234 RVA: 0x000DCCB9 File Offset: 0x000DAEB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideBagItemCtx()
		{
		}

		// Token: 0x06005AC3 RID: 23235 RVA: 0x000DCCC1 File Offset: 0x000DAEC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideBagItemCtx(DarkTideBagItemCtx other) : this()
		{
			this.incrId_ = other.incrId_;
			this.slotId_ = other.slotId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005AC4 RID: 23236 RVA: 0x000DCCFE File Offset: 0x000DAEFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideBagItemCtx Clone()
		{
			return new DarkTideBagItemCtx(this);
		}

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x06005AC5 RID: 23237 RVA: 0x000DCD06 File Offset: 0x000DAF06
		// (set) Token: 0x06005AC6 RID: 23238 RVA: 0x000DCD0E File Offset: 0x000DAF0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x06005AC7 RID: 23239 RVA: 0x000DCD17 File Offset: 0x000DAF17
		// (set) Token: 0x06005AC8 RID: 23240 RVA: 0x000DCD1F File Offset: 0x000DAF1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotId
		{
			get
			{
				return this.slotId_;
			}
			set
			{
				this.slotId_ = value;
			}
		}

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x06005AC9 RID: 23241 RVA: 0x000DCD28 File Offset: 0x000DAF28
		// (set) Token: 0x06005ACA RID: 23242 RVA: 0x000DCD30 File Offset: 0x000DAF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x06005ACB RID: 23243 RVA: 0x000DCD39 File Offset: 0x000DAF39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideBagItemCtx);
		}

		// Token: 0x06005ACC RID: 23244 RVA: 0x000DCD48 File Offset: 0x000DAF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideBagItemCtx other)
		{
			return other != null && (other == this || (this.IncrId == other.IncrId && this.SlotId == other.SlotId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005ACD RID: 23245 RVA: 0x000DCDA4 File Offset: 0x000DAFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this.SlotId != 0)
			{
				num ^= this.SlotId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005ACE RID: 23246 RVA: 0x000DCE15 File Offset: 0x000DB015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005ACF RID: 23247 RVA: 0x000DCE22 File Offset: 0x000DB022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005AD0 RID: 23248 RVA: 0x000DCE2C File Offset: 0x000DB02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncrId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.IncrId);
			}
			if (this.SlotId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SlotId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005AD1 RID: 23249 RVA: 0x000DCEA4 File Offset: 0x000DB0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this.SlotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005AD2 RID: 23250 RVA: 0x000DCF14 File Offset: 0x000DB114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideBagItemCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			if (other.SlotId != 0)
			{
				this.SlotId = other.SlotId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005AD3 RID: 23251 RVA: 0x000DCF78 File Offset: 0x000DB178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005AD4 RID: 23252 RVA: 0x000DCF84 File Offset: 0x000DB184
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
				if (num != 16U)
				{
					if (num != 24U)
					{
						if (num != 32U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Count = input.ReadInt32();
						}
					}
					else
					{
						this.SlotId = input.ReadInt32();
					}
				}
				else
				{
					this.IncrId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040035D0 RID: 13776
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035D1 RID: 13777
		public const int IncrIdFieldNumber = 2;

		// Token: 0x040035D2 RID: 13778
		private int incrId_;

		// Token: 0x040035D3 RID: 13779
		public const int SlotIdFieldNumber = 3;

		// Token: 0x040035D4 RID: 13780
		private int slotId_;

		// Token: 0x040035D5 RID: 13781
		public const int CountFieldNumber = 4;

		// Token: 0x040035D6 RID: 13782
		private int count_;
	}
}
