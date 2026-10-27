using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200110B RID: 4363
	public sealed class RoverRogueItemCurrencyData : IMessage<RoverRogueItemCurrencyData>, IMessage, IEquatable<RoverRogueItemCurrencyData>, IDeepCloneable<RoverRogueItemCurrencyData>, IBufferMessage
	{
		// Token: 0x06017456 RID: 95318 RVA: 0x00361158 File Offset: 0x0035F358
		[NullableContext(1)]
		public static RoverRogueItemCurrencyData Create()
		{
			return new RoverRogueItemCurrencyData();
		}

		// Token: 0x17004E0A RID: 19978
		// (get) Token: 0x06017457 RID: 95319 RVA: 0x0036115F File Offset: 0x0035F35F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoverRogueItemCurrencyData> Parser
		{
			get
			{
				return RoverRogueItemCurrencyData._parser;
			}
		}

		// Token: 0x17004E0B RID: 19979
		// (get) Token: 0x06017458 RID: 95320 RVA: 0x00361166 File Offset: 0x0035F366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E0C RID: 19980
		// (get) Token: 0x06017459 RID: 95321 RVA: 0x00361169 File Offset: 0x0035F369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueItemCurrencyData.Descriptor;
			}
		}

		// Token: 0x0601745A RID: 95322 RVA: 0x00361170 File Offset: 0x0035F370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueItemCurrencyData()
		{
		}

		// Token: 0x0601745B RID: 95323 RVA: 0x00361178 File Offset: 0x0035F378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueItemCurrencyData(RoverRogueItemCurrencyData other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601745C RID: 95324 RVA: 0x003611A9 File Offset: 0x0035F3A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueItemCurrencyData Clone()
		{
			return new RoverRogueItemCurrencyData(this);
		}

		// Token: 0x17004E0D RID: 19981
		// (get) Token: 0x0601745D RID: 95325 RVA: 0x003611B1 File Offset: 0x0035F3B1
		// (set) Token: 0x0601745E RID: 95326 RVA: 0x003611B9 File Offset: 0x0035F3B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17004E0E RID: 19982
		// (get) Token: 0x0601745F RID: 95327 RVA: 0x003611C2 File Offset: 0x0035F3C2
		// (set) Token: 0x06017460 RID: 95328 RVA: 0x003611CA File Offset: 0x0035F3CA
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

		// Token: 0x06017461 RID: 95329 RVA: 0x003611D3 File Offset: 0x0035F3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueItemCurrencyData);
		}

		// Token: 0x06017462 RID: 95330 RVA: 0x003611E1 File Offset: 0x0035F3E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueItemCurrencyData other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017463 RID: 95331 RVA: 0x00361220 File Offset: 0x0035F420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
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

		// Token: 0x06017464 RID: 95332 RVA: 0x00361278 File Offset: 0x0035F478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017465 RID: 95333 RVA: 0x00361285 File Offset: 0x0035F485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017466 RID: 95334 RVA: 0x00361290 File Offset: 0x0035F490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017467 RID: 95335 RVA: 0x003612E8 File Offset: 0x0035F4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
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

		// Token: 0x06017468 RID: 95336 RVA: 0x00361340 File Offset: 0x0035F540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueItemCurrencyData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017469 RID: 95337 RVA: 0x00361390 File Offset: 0x0035F590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601746A RID: 95338 RVA: 0x0036139C File Offset: 0x0035F59C
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
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008A75 RID: 35445
		private static readonly MessageParser<RoverRogueItemCurrencyData> _parser = new MessageParser<RoverRogueItemCurrencyData>(() => new RoverRogueItemCurrencyData());

		// Token: 0x04008A76 RID: 35446
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A77 RID: 35447
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04008A78 RID: 35448
		private int itemId_;

		// Token: 0x04008A79 RID: 35449
		public const int CountFieldNumber = 2;

		// Token: 0x04008A7A RID: 35450
		private int count_;
	}
}
