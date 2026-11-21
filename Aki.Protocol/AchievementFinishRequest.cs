using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200005C RID: 92
	[NetMessage(EMessageId.AchievementFinishRequest)]
	public sealed class AchievementFinishRequest : IMessage<AchievementFinishRequest>, IMessage, IEquatable<AchievementFinishRequest>, IDeepCloneable<AchievementFinishRequest>, IBufferMessage
	{
		// Token: 0x060015F9 RID: 5625 RVA: 0x0003A1FE File Offset: 0x000383FE
		[NullableContext(1)]
		public static AchievementFinishRequest Create()
		{
			return new AchievementFinishRequest();
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060015FA RID: 5626 RVA: 0x0003A205 File Offset: 0x00038405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060015FB RID: 5627 RVA: 0x0003A208 File Offset: 0x00038408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementFinishRequest.Descriptor;
			}
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x0003A20F File Offset: 0x0003840F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementFinishRequest()
		{
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x0003A217 File Offset: 0x00038417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementFinishRequest(AchievementFinishRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x0003A23C File Offset: 0x0003843C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementFinishRequest Clone()
		{
			return new AchievementFinishRequest(this);
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060015FF RID: 5631 RVA: 0x0003A244 File Offset: 0x00038444
		// (set) Token: 0x06001600 RID: 5632 RVA: 0x0003A24C File Offset: 0x0003844C
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

		// Token: 0x06001601 RID: 5633 RVA: 0x0003A255 File Offset: 0x00038455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementFinishRequest);
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x0003A263 File Offset: 0x00038463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementFinishRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x0003A294 File Offset: 0x00038494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x0003A2D3 File Offset: 0x000384D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x0003A2E0 File Offset: 0x000384E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x0003A2E9 File Offset: 0x000384E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x0003A31C File Offset: 0x0003851C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x0003A35A File Offset: 0x0003855A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AchievementFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x0003A38B File Offset: 0x0003858B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x0003A394 File Offset: 0x00038594
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002114 RID: 8468
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002115 RID: 8469
		public const int IdFieldNumber = 13;

		// Token: 0x04002116 RID: 8470
		private int id_;
	}
}
