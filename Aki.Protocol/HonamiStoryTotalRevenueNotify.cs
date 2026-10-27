using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007AA RID: 1962
	[NetMessage(EMessageId.HonamiStoryTotalRevenueNotify)]
	public sealed class HonamiStoryTotalRevenueNotify : IMessage<HonamiStoryTotalRevenueNotify>, IMessage, IEquatable<HonamiStoryTotalRevenueNotify>, IDeepCloneable<HonamiStoryTotalRevenueNotify>, IBufferMessage
	{
		// Token: 0x0600B0CB RID: 45259 RVA: 0x001A7E28 File Offset: 0x001A6028
		[NullableContext(1)]
		public static HonamiStoryTotalRevenueNotify Create()
		{
			return new HonamiStoryTotalRevenueNotify();
		}

		// Token: 0x170023AB RID: 9131
		// (get) Token: 0x0600B0CC RID: 45260 RVA: 0x001A7E2F File Offset: 0x001A602F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023AC RID: 9132
		// (get) Token: 0x0600B0CD RID: 45261 RVA: 0x001A7E32 File Offset: 0x001A6032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryTotalRevenueNotify.Descriptor;
			}
		}

		// Token: 0x0600B0CE RID: 45262 RVA: 0x001A7E39 File Offset: 0x001A6039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTotalRevenueNotify()
		{
		}

		// Token: 0x0600B0CF RID: 45263 RVA: 0x001A7E41 File Offset: 0x001A6041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTotalRevenueNotify(HonamiStoryTotalRevenueNotify other) : this()
		{
			this.totalRevenue_ = other.totalRevenue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B0D0 RID: 45264 RVA: 0x001A7E66 File Offset: 0x001A6066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTotalRevenueNotify Clone()
		{
			return new HonamiStoryTotalRevenueNotify(this);
		}

		// Token: 0x170023AD RID: 9133
		// (get) Token: 0x0600B0D1 RID: 45265 RVA: 0x001A7E6E File Offset: 0x001A606E
		// (set) Token: 0x0600B0D2 RID: 45266 RVA: 0x001A7E76 File Offset: 0x001A6076
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

		// Token: 0x0600B0D3 RID: 45267 RVA: 0x001A7E7F File Offset: 0x001A607F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryTotalRevenueNotify);
		}

		// Token: 0x0600B0D4 RID: 45268 RVA: 0x001A7E8D File Offset: 0x001A608D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryTotalRevenueNotify other)
		{
			return other != null && (other == this || (this.TotalRevenue == other.TotalRevenue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B0D5 RID: 45269 RVA: 0x001A7EBC File Offset: 0x001A60BC
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

		// Token: 0x0600B0D6 RID: 45270 RVA: 0x001A7EFB File Offset: 0x001A60FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B0D7 RID: 45271 RVA: 0x001A7F08 File Offset: 0x001A6108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B0D8 RID: 45272 RVA: 0x001A7F11 File Offset: 0x001A6111
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

		// Token: 0x0600B0D9 RID: 45273 RVA: 0x001A7F44 File Offset: 0x001A6144
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

		// Token: 0x0600B0DA RID: 45274 RVA: 0x001A7F82 File Offset: 0x001A6182
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

		// Token: 0x0600B0DB RID: 45275 RVA: 0x001A7FB3 File Offset: 0x001A61B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B0DC RID: 45276 RVA: 0x001A7FBC File Offset: 0x001A61BC
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

		// Token: 0x04004F5B RID: 20315
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F5C RID: 20316
		public const int TotalRevenueFieldNumber = 7;

		// Token: 0x04004F5D RID: 20317
		private int totalRevenue_;
	}
}
