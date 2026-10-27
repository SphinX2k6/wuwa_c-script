using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000792 RID: 1938
	[NetMessage(EMessageId.HonamiStoryPickUpItemRequest)]
	public sealed class HonamiStoryPickUpItemRequest : IMessage<HonamiStoryPickUpItemRequest>, IMessage, IEquatable<HonamiStoryPickUpItemRequest>, IDeepCloneable<HonamiStoryPickUpItemRequest>, IBufferMessage
	{
		// Token: 0x0600AEE9 RID: 44777 RVA: 0x001A3FC2 File Offset: 0x001A21C2
		[NullableContext(1)]
		public static HonamiStoryPickUpItemRequest Create()
		{
			return new HonamiStoryPickUpItemRequest();
		}

		// Token: 0x17002349 RID: 9033
		// (get) Token: 0x0600AEEA RID: 44778 RVA: 0x001A3FC9 File Offset: 0x001A21C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700234A RID: 9034
		// (get) Token: 0x0600AEEB RID: 44779 RVA: 0x001A3FCC File Offset: 0x001A21CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryPickUpItemRequest.Descriptor;
			}
		}

		// Token: 0x0600AEEC RID: 44780 RVA: 0x001A3FD3 File Offset: 0x001A21D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPickUpItemRequest()
		{
		}

		// Token: 0x0600AEED RID: 44781 RVA: 0x001A3FDB File Offset: 0x001A21DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPickUpItemRequest(HonamiStoryPickUpItemRequest other) : this()
		{
			this.honamiStoryBagUpdateInfo_ = ((other.honamiStoryBagUpdateInfo_ != null) ? other.honamiStoryBagUpdateInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AEEE RID: 44782 RVA: 0x001A4010 File Offset: 0x001A2210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPickUpItemRequest Clone()
		{
			return new HonamiStoryPickUpItemRequest(this);
		}

		// Token: 0x1700234B RID: 9035
		// (get) Token: 0x0600AEEF RID: 44783 RVA: 0x001A4018 File Offset: 0x001A2218
		// (set) Token: 0x0600AEF0 RID: 44784 RVA: 0x001A4020 File Offset: 0x001A2220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagUpdateInfo HonamiStoryBagUpdateInfo
		{
			get
			{
				return this.honamiStoryBagUpdateInfo_;
			}
			set
			{
				this.honamiStoryBagUpdateInfo_ = value;
			}
		}

		// Token: 0x0600AEF1 RID: 44785 RVA: 0x001A4029 File Offset: 0x001A2229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryPickUpItemRequest);
		}

		// Token: 0x0600AEF2 RID: 44786 RVA: 0x001A4037 File Offset: 0x001A2237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryPickUpItemRequest other)
		{
			return other != null && (other == this || (object.Equals(this.HonamiStoryBagUpdateInfo, other.HonamiStoryBagUpdateInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AEF3 RID: 44787 RVA: 0x001A406C File Offset: 0x001A226C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.honamiStoryBagUpdateInfo_ != null)
			{
				num ^= this.HonamiStoryBagUpdateInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AEF4 RID: 44788 RVA: 0x001A40A8 File Offset: 0x001A22A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AEF5 RID: 44789 RVA: 0x001A40B5 File Offset: 0x001A22B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AEF6 RID: 44790 RVA: 0x001A40BE File Offset: 0x001A22BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.honamiStoryBagUpdateInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.HonamiStoryBagUpdateInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AEF7 RID: 44791 RVA: 0x001A40F0 File Offset: 0x001A22F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.honamiStoryBagUpdateInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HonamiStoryBagUpdateInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AEF8 RID: 44792 RVA: 0x001A4130 File Offset: 0x001A2330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryPickUpItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.honamiStoryBagUpdateInfo_ != null)
			{
				if (this.honamiStoryBagUpdateInfo_ == null)
				{
					this.HonamiStoryBagUpdateInfo = new HonamiStoryBagUpdateInfo();
				}
				this.HonamiStoryBagUpdateInfo.MergeFrom(other.HonamiStoryBagUpdateInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AEF9 RID: 44793 RVA: 0x001A4184 File Offset: 0x001A2384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AEFA RID: 44794 RVA: 0x001A4190 File Offset: 0x001A2390
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.honamiStoryBagUpdateInfo_ == null)
					{
						this.HonamiStoryBagUpdateInfo = new HonamiStoryBagUpdateInfo();
					}
					input.ReadMessage(this.HonamiStoryBagUpdateInfo);
				}
			}
		}

		// Token: 0x04004ED6 RID: 20182
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004ED7 RID: 20183
		public const int HonamiStoryBagUpdateInfoFieldNumber = 10;

		// Token: 0x04004ED8 RID: 20184
		private HonamiStoryBagUpdateInfo honamiStoryBagUpdateInfo_;
	}
}
