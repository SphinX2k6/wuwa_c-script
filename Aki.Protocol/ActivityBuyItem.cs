using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000081 RID: 129
	public sealed class ActivityBuyItem : IMessage<ActivityBuyItem>, IMessage, IEquatable<ActivityBuyItem>, IDeepCloneable<ActivityBuyItem>, IBufferMessage
	{
		// Token: 0x060018CF RID: 6351 RVA: 0x00040C1E File Offset: 0x0003EE1E
		[NullableContext(1)]
		public static ActivityBuyItem Create()
		{
			return new ActivityBuyItem();
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060018D0 RID: 6352 RVA: 0x00040C25 File Offset: 0x0003EE25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ActivityBuyItem> Parser
		{
			get
			{
				return ActivityBuyItem._parser;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060018D1 RID: 6353 RVA: 0x00040C2C File Offset: 0x0003EE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060018D2 RID: 6354 RVA: 0x00040C2F File Offset: 0x0003EE2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityBuyItem.Descriptor;
			}
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x00040C36 File Offset: 0x0003EE36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityBuyItem()
		{
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x00040C3E File Offset: 0x0003EE3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityBuyItem(ActivityBuyItem other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x00040C6F File Offset: 0x0003EE6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityBuyItem Clone()
		{
			return new ActivityBuyItem(this);
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060018D6 RID: 6358 RVA: 0x00040C77 File Offset: 0x0003EE77
		// (set) Token: 0x060018D7 RID: 6359 RVA: 0x00040C7F File Offset: 0x0003EE7F
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

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060018D8 RID: 6360 RVA: 0x00040C88 File Offset: 0x0003EE88
		// (set) Token: 0x060018D9 RID: 6361 RVA: 0x00040C90 File Offset: 0x0003EE90
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

		// Token: 0x060018DA RID: 6362 RVA: 0x00040C99 File Offset: 0x0003EE99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityBuyItem);
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x00040CA7 File Offset: 0x0003EEA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityBuyItem other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x00040CE8 File Offset: 0x0003EEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
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

		// Token: 0x060018DD RID: 6365 RVA: 0x00040D40 File Offset: 0x0003EF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x00040D4D File Offset: 0x0003EF4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00040D58 File Offset: 0x0003EF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
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

		// Token: 0x060018E0 RID: 6368 RVA: 0x00040DB0 File Offset: 0x0003EFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
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

		// Token: 0x060018E1 RID: 6369 RVA: 0x00040E08 File Offset: 0x0003F008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityBuyItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00040E58 File Offset: 0x0003F058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x00040E64 File Offset: 0x0003F064
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
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002196 RID: 8598
		private static readonly MessageParser<ActivityBuyItem> _parser = new MessageParser<ActivityBuyItem>(() => new ActivityBuyItem());

		// Token: 0x04002197 RID: 8599
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002198 RID: 8600
		public const int IdFieldNumber = 1;

		// Token: 0x04002199 RID: 8601
		private int id_;

		// Token: 0x0400219A RID: 8602
		public const int CountFieldNumber = 2;

		// Token: 0x0400219B RID: 8603
		private int count_;
	}
}
