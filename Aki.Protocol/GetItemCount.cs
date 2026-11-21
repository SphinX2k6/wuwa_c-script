using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006B7 RID: 1719
	public sealed class GetItemCount : IMessage<GetItemCount>, IMessage, IEquatable<GetItemCount>, IDeepCloneable<GetItemCount>, IBufferMessage
	{
		// Token: 0x06009DAB RID: 40363 RVA: 0x0017EF89 File Offset: 0x0017D189
		[NullableContext(1)]
		public static GetItemCount Create()
		{
			return new GetItemCount();
		}

		// Token: 0x17001FA7 RID: 8103
		// (get) Token: 0x06009DAC RID: 40364 RVA: 0x0017EF90 File Offset: 0x0017D190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetItemCount> Parser
		{
			get
			{
				return GetItemCount._parser;
			}
		}

		// Token: 0x17001FA8 RID: 8104
		// (get) Token: 0x06009DAD RID: 40365 RVA: 0x0017EF97 File Offset: 0x0017D197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FA9 RID: 8105
		// (get) Token: 0x06009DAE RID: 40366 RVA: 0x0017EF9A File Offset: 0x0017D19A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetItemCount.Descriptor;
			}
		}

		// Token: 0x06009DAF RID: 40367 RVA: 0x0017EFA1 File Offset: 0x0017D1A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetItemCount()
		{
		}

		// Token: 0x06009DB0 RID: 40368 RVA: 0x0017EFA9 File Offset: 0x0017D1A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetItemCount(GetItemCount other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009DB1 RID: 40369 RVA: 0x0017EFDA File Offset: 0x0017D1DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetItemCount Clone()
		{
			return new GetItemCount(this);
		}

		// Token: 0x17001FAA RID: 8106
		// (get) Token: 0x06009DB2 RID: 40370 RVA: 0x0017EFE2 File Offset: 0x0017D1E2
		// (set) Token: 0x06009DB3 RID: 40371 RVA: 0x0017EFEA File Offset: 0x0017D1EA
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

		// Token: 0x17001FAB RID: 8107
		// (get) Token: 0x06009DB4 RID: 40372 RVA: 0x0017EFF3 File Offset: 0x0017D1F3
		// (set) Token: 0x06009DB5 RID: 40373 RVA: 0x0017EFFB File Offset: 0x0017D1FB
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

		// Token: 0x06009DB6 RID: 40374 RVA: 0x0017F004 File Offset: 0x0017D204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetItemCount);
		}

		// Token: 0x06009DB7 RID: 40375 RVA: 0x0017F012 File Offset: 0x0017D212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetItemCount other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009DB8 RID: 40376 RVA: 0x0017F050 File Offset: 0x0017D250
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

		// Token: 0x06009DB9 RID: 40377 RVA: 0x0017F0A8 File Offset: 0x0017D2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009DBA RID: 40378 RVA: 0x0017F0B5 File Offset: 0x0017D2B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009DBB RID: 40379 RVA: 0x0017F0C0 File Offset: 0x0017D2C0
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

		// Token: 0x06009DBC RID: 40380 RVA: 0x0017F118 File Offset: 0x0017D318
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

		// Token: 0x06009DBD RID: 40381 RVA: 0x0017F170 File Offset: 0x0017D370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetItemCount other)
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

		// Token: 0x06009DBE RID: 40382 RVA: 0x0017F1C0 File Offset: 0x0017D3C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009DBF RID: 40383 RVA: 0x0017F1CC File Offset: 0x0017D3CC
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

		// Token: 0x04004A4A RID: 19018
		private static readonly MessageParser<GetItemCount> _parser = new MessageParser<GetItemCount>(() => new GetItemCount());

		// Token: 0x04004A4B RID: 19019
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A4C RID: 19020
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04004A4D RID: 19021
		private int itemId_;

		// Token: 0x04004A4E RID: 19022
		public const int CountFieldNumber = 2;

		// Token: 0x04004A4F RID: 19023
		private int count_;
	}
}
