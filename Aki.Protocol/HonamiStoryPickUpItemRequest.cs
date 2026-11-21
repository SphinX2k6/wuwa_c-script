using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200077E RID: 1918
	[NetMessage(EMessageId.HonamiStoryPickUpItemRequest)]
	public sealed class HonamiStoryPickUpItemRequest : IMessage<HonamiStoryPickUpItemRequest>, IMessage, IEquatable<HonamiStoryPickUpItemRequest>, IDeepCloneable<HonamiStoryPickUpItemRequest>, IBufferMessage
	{
		// Token: 0x0600AD93 RID: 44435 RVA: 0x001A159A File Offset: 0x0019F79A
		[NullableContext(1)]
		public static HonamiStoryPickUpItemRequest Create()
		{
			return new HonamiStoryPickUpItemRequest();
		}

		// Token: 0x170022FF RID: 8959
		// (get) Token: 0x0600AD94 RID: 44436 RVA: 0x001A15A1 File Offset: 0x0019F7A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002300 RID: 8960
		// (get) Token: 0x0600AD95 RID: 44437 RVA: 0x001A15A4 File Offset: 0x0019F7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryPickUpItemRequest.Descriptor;
			}
		}

		// Token: 0x0600AD96 RID: 44438 RVA: 0x001A15AB File Offset: 0x0019F7AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPickUpItemRequest()
		{
		}

		// Token: 0x0600AD97 RID: 44439 RVA: 0x001A15B3 File Offset: 0x0019F7B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPickUpItemRequest(HonamiStoryPickUpItemRequest other) : this()
		{
			this.honamiStoryBagUpdateInfo_ = ((other.honamiStoryBagUpdateInfo_ != null) ? other.honamiStoryBagUpdateInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD98 RID: 44440 RVA: 0x001A15E8 File Offset: 0x0019F7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPickUpItemRequest Clone()
		{
			return new HonamiStoryPickUpItemRequest(this);
		}

		// Token: 0x17002301 RID: 8961
		// (get) Token: 0x0600AD99 RID: 44441 RVA: 0x001A15F0 File Offset: 0x0019F7F0
		// (set) Token: 0x0600AD9A RID: 44442 RVA: 0x001A15F8 File Offset: 0x0019F7F8
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

		// Token: 0x0600AD9B RID: 44443 RVA: 0x001A1601 File Offset: 0x0019F801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryPickUpItemRequest);
		}

		// Token: 0x0600AD9C RID: 44444 RVA: 0x001A160F File Offset: 0x0019F80F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryPickUpItemRequest other)
		{
			return other != null && (other == this || (object.Equals(this.HonamiStoryBagUpdateInfo, other.HonamiStoryBagUpdateInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AD9D RID: 44445 RVA: 0x001A1644 File Offset: 0x0019F844
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

		// Token: 0x0600AD9E RID: 44446 RVA: 0x001A1680 File Offset: 0x0019F880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AD9F RID: 44447 RVA: 0x001A168D File Offset: 0x0019F88D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ADA0 RID: 44448 RVA: 0x001A1696 File Offset: 0x0019F896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.honamiStoryBagUpdateInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.HonamiStoryBagUpdateInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ADA1 RID: 44449 RVA: 0x001A16C8 File Offset: 0x0019F8C8
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

		// Token: 0x0600ADA2 RID: 44450 RVA: 0x001A1708 File Offset: 0x0019F908
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

		// Token: 0x0600ADA3 RID: 44451 RVA: 0x001A175C File Offset: 0x0019F95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ADA4 RID: 44452 RVA: 0x001A1768 File Offset: 0x0019F968
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
				if (num != 66U)
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

		// Token: 0x04004ECF RID: 20175
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004ED0 RID: 20176
		public const int HonamiStoryBagUpdateInfoFieldNumber = 8;

		// Token: 0x04004ED1 RID: 20177
		private HonamiStoryBagUpdateInfo honamiStoryBagUpdateInfo_;
	}
}
