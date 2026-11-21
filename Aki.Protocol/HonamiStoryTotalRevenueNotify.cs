using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000796 RID: 1942
	[NetMessage(EMessageId.HonamiStoryTotalRevenueNotify)]
	public sealed class HonamiStoryTotalRevenueNotify : IMessage<HonamiStoryTotalRevenueNotify>, IMessage, IEquatable<HonamiStoryTotalRevenueNotify>, IDeepCloneable<HonamiStoryTotalRevenueNotify>, IBufferMessage
	{
		// Token: 0x0600AF75 RID: 44917 RVA: 0x001A53FC File Offset: 0x001A35FC
		[NullableContext(1)]
		public static HonamiStoryTotalRevenueNotify Create()
		{
			return new HonamiStoryTotalRevenueNotify();
		}

		// Token: 0x17002361 RID: 9057
		// (get) Token: 0x0600AF76 RID: 44918 RVA: 0x001A5403 File Offset: 0x001A3603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002362 RID: 9058
		// (get) Token: 0x0600AF77 RID: 44919 RVA: 0x001A5406 File Offset: 0x001A3606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryTotalRevenueNotify.Descriptor;
			}
		}

		// Token: 0x0600AF78 RID: 44920 RVA: 0x001A540D File Offset: 0x001A360D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTotalRevenueNotify()
		{
		}

		// Token: 0x0600AF79 RID: 44921 RVA: 0x001A5415 File Offset: 0x001A3615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTotalRevenueNotify(HonamiStoryTotalRevenueNotify other) : this()
		{
			this.totalRevenue_ = other.totalRevenue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF7A RID: 44922 RVA: 0x001A543A File Offset: 0x001A363A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTotalRevenueNotify Clone()
		{
			return new HonamiStoryTotalRevenueNotify(this);
		}

		// Token: 0x17002363 RID: 9059
		// (get) Token: 0x0600AF7B RID: 44923 RVA: 0x001A5442 File Offset: 0x001A3642
		// (set) Token: 0x0600AF7C RID: 44924 RVA: 0x001A544A File Offset: 0x001A364A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalRevenue
		{
			get
			{
				return this.totalRevenue_;
			}
			set
			{
				this.totalRevenue_ = value;
			}
		}

		// Token: 0x0600AF7D RID: 44925 RVA: 0x001A5453 File Offset: 0x001A3653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryTotalRevenueNotify);
		}

		// Token: 0x0600AF7E RID: 44926 RVA: 0x001A5461 File Offset: 0x001A3661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryTotalRevenueNotify other)
		{
			return other != null && (other == this || (this.TotalRevenue == other.TotalRevenue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AF7F RID: 44927 RVA: 0x001A5490 File Offset: 0x001A3690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TotalRevenue != 0)
			{
				num ^= this.TotalRevenue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AF80 RID: 44928 RVA: 0x001A54CF File Offset: 0x001A36CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AF81 RID: 44929 RVA: 0x001A54DC File Offset: 0x001A36DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF82 RID: 44930 RVA: 0x001A54E5 File Offset: 0x001A36E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TotalRevenue != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TotalRevenue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF83 RID: 44931 RVA: 0x001A5518 File Offset: 0x001A3718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TotalRevenue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalRevenue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AF84 RID: 44932 RVA: 0x001A5556 File Offset: 0x001A3756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryTotalRevenueNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TotalRevenue != 0)
			{
				this.TotalRevenue = other.TotalRevenue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AF85 RID: 44933 RVA: 0x001A5587 File Offset: 0x001A3787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF86 RID: 44934 RVA: 0x001A5590 File Offset: 0x001A3790
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TotalRevenue = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004F54 RID: 20308
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F55 RID: 20309
		public const int TotalRevenueFieldNumber = 7;

		// Token: 0x04004F56 RID: 20310
		private int totalRevenue_;
	}
}
