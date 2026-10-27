using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000569 RID: 1385
	[NetMessage(EMessageId.FishingInfoUpdateNotify)]
	public sealed class FishingInfoUpdateNotify : IMessage<FishingInfoUpdateNotify>, IMessage, IEquatable<FishingInfoUpdateNotify>, IDeepCloneable<FishingInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06008109 RID: 33033 RVA: 0x00137CD0 File Offset: 0x00135ED0
		[NullableContext(1)]
		public static FishingInfoUpdateNotify Create()
		{
			return new FishingInfoUpdateNotify();
		}

		// Token: 0x17001926 RID: 6438
		// (get) Token: 0x0600810A RID: 33034 RVA: 0x00137CD7 File Offset: 0x00135ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001927 RID: 6439
		// (get) Token: 0x0600810B RID: 33035 RVA: 0x00137CDA File Offset: 0x00135EDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600810C RID: 33036 RVA: 0x00137CE1 File Offset: 0x00135EE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfoUpdateNotify()
		{
		}

		// Token: 0x0600810D RID: 33037 RVA: 0x00137CE9 File Offset: 0x00135EE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfoUpdateNotify(FishingInfoUpdateNotify other) : this()
		{
			this.fishingInfo_ = ((other.fishingInfo_ != null) ? other.fishingInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600810E RID: 33038 RVA: 0x00137D1E File Offset: 0x00135F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfoUpdateNotify Clone()
		{
			return new FishingInfoUpdateNotify(this);
		}

		// Token: 0x17001928 RID: 6440
		// (get) Token: 0x0600810F RID: 33039 RVA: 0x00137D26 File Offset: 0x00135F26
		// (set) Token: 0x06008110 RID: 33040 RVA: 0x00137D2E File Offset: 0x00135F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfo FishingInfo
		{
			get
			{
				return this.fishingInfo_;
			}
			set
			{
				this.fishingInfo_ = value;
			}
		}

		// Token: 0x06008111 RID: 33041 RVA: 0x00137D37 File Offset: 0x00135F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingInfoUpdateNotify);
		}

		// Token: 0x06008112 RID: 33042 RVA: 0x00137D45 File Offset: 0x00135F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.FishingInfo, other.FishingInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008113 RID: 33043 RVA: 0x00137D78 File Offset: 0x00135F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.fishingInfo_ != null)
			{
				num ^= this.FishingInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008114 RID: 33044 RVA: 0x00137DB4 File Offset: 0x00135FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008115 RID: 33045 RVA: 0x00137DC1 File Offset: 0x00135FC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008116 RID: 33046 RVA: 0x00137DCA File Offset: 0x00135FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fishingInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.FishingInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008117 RID: 33047 RVA: 0x00137DFC File Offset: 0x00135FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.fishingInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FishingInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008118 RID: 33048 RVA: 0x00137E3C File Offset: 0x0013603C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.fishingInfo_ != null)
			{
				if (this.fishingInfo_ == null)
				{
					this.FishingInfo = new FishingInfo();
				}
				this.FishingInfo.MergeFrom(other.FishingInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008119 RID: 33049 RVA: 0x00137E90 File Offset: 0x00136090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600811A RID: 33050 RVA: 0x00137E9C File Offset: 0x0013609C
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.fishingInfo_ == null)
					{
						this.FishingInfo = new FishingInfo();
					}
					input.ReadMessage(this.FishingInfo);
				}
			}
		}

		// Token: 0x040040E0 RID: 16608
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040E1 RID: 16609
		public const int FishingInfoFieldNumber = 12;

		// Token: 0x040040E2 RID: 16610
		private FishingInfo fishingInfo_;
	}
}
