using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200075F RID: 1887
	public sealed class HonamiStoryDropItemComponentPb : IMessage<HonamiStoryDropItemComponentPb>, IMessage, IEquatable<HonamiStoryDropItemComponentPb>, IDeepCloneable<HonamiStoryDropItemComponentPb>, IBufferMessage
	{
		// Token: 0x0600AB09 RID: 43785 RVA: 0x0019BBD5 File Offset: 0x00199DD5
		[NullableContext(1)]
		public static HonamiStoryDropItemComponentPb Create()
		{
			return new HonamiStoryDropItemComponentPb();
		}

		// Token: 0x17002273 RID: 8819
		// (get) Token: 0x0600AB0A RID: 43786 RVA: 0x0019BBDC File Offset: 0x00199DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002274 RID: 8820
		// (get) Token: 0x0600AB0B RID: 43787 RVA: 0x0019BBDF File Offset: 0x00199DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryDropItemComponentPb.Descriptor;
			}
		}

		// Token: 0x0600AB0C RID: 43788 RVA: 0x0019BBE6 File Offset: 0x00199DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryDropItemComponentPb()
		{
		}

		// Token: 0x0600AB0D RID: 43789 RVA: 0x0019BBEE File Offset: 0x00199DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryDropItemComponentPb(HonamiStoryDropItemComponentPb other) : this()
		{
			this.honamiStoryItemInfo_ = ((other.honamiStoryItemInfo_ != null) ? other.honamiStoryItemInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB0E RID: 43790 RVA: 0x0019BC23 File Offset: 0x00199E23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryDropItemComponentPb Clone()
		{
			return new HonamiStoryDropItemComponentPb(this);
		}

		// Token: 0x17002275 RID: 8821
		// (get) Token: 0x0600AB0F RID: 43791 RVA: 0x0019BC2B File Offset: 0x00199E2B
		// (set) Token: 0x0600AB10 RID: 43792 RVA: 0x0019BC33 File Offset: 0x00199E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemInfo HonamiStoryItemInfo
		{
			get
			{
				return this.honamiStoryItemInfo_;
			}
			set
			{
				this.honamiStoryItemInfo_ = value;
			}
		}

		// Token: 0x0600AB11 RID: 43793 RVA: 0x0019BC3C File Offset: 0x00199E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryDropItemComponentPb);
		}

		// Token: 0x0600AB12 RID: 43794 RVA: 0x0019BC4A File Offset: 0x00199E4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryDropItemComponentPb other)
		{
			return other != null && (other == this || (object.Equals(this.HonamiStoryItemInfo, other.HonamiStoryItemInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AB13 RID: 43795 RVA: 0x0019BC80 File Offset: 0x00199E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.honamiStoryItemInfo_ != null)
			{
				num ^= this.HonamiStoryItemInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AB14 RID: 43796 RVA: 0x0019BCBC File Offset: 0x00199EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AB15 RID: 43797 RVA: 0x0019BCC9 File Offset: 0x00199EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB16 RID: 43798 RVA: 0x0019BCD2 File Offset: 0x00199ED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.honamiStoryItemInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.HonamiStoryItemInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB17 RID: 43799 RVA: 0x0019BD04 File Offset: 0x00199F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.honamiStoryItemInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HonamiStoryItemInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AB18 RID: 43800 RVA: 0x0019BD44 File Offset: 0x00199F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryDropItemComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.honamiStoryItemInfo_ != null)
			{
				if (this.honamiStoryItemInfo_ == null)
				{
					this.HonamiStoryItemInfo = new HonamiStoryItemInfo();
				}
				this.HonamiStoryItemInfo.MergeFrom(other.HonamiStoryItemInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AB19 RID: 43801 RVA: 0x0019BD98 File Offset: 0x00199F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB1A RID: 43802 RVA: 0x0019BDA4 File Offset: 0x00199FA4
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.honamiStoryItemInfo_ == null)
					{
						this.HonamiStoryItemInfo = new HonamiStoryItemInfo();
					}
					input.ReadMessage(this.HonamiStoryItemInfo);
				}
			}
		}

		// Token: 0x04004E0C RID: 19980
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E0D RID: 19981
		public const int HonamiStoryItemInfoFieldNumber = 1;

		// Token: 0x04004E0E RID: 19982
		private HonamiStoryItemInfo honamiStoryItemInfo_;
	}
}
