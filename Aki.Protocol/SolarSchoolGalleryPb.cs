using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012AB RID: 4779
	public sealed class SolarSchoolGalleryPb : IMessage<SolarSchoolGalleryPb>, IMessage, IEquatable<SolarSchoolGalleryPb>, IDeepCloneable<SolarSchoolGalleryPb>, IBufferMessage
	{
		// Token: 0x06019829 RID: 104489 RVA: 0x003B8B09 File Offset: 0x003B6D09
		[NullableContext(1)]
		public static SolarSchoolGalleryPb Create()
		{
			return new SolarSchoolGalleryPb();
		}

		// Token: 0x17005655 RID: 22101
		// (get) Token: 0x0601982A RID: 104490 RVA: 0x003B8B10 File Offset: 0x003B6D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SolarSchoolGalleryPb> Parser
		{
			get
			{
				return SolarSchoolGalleryPb._parser;
			}
		}

		// Token: 0x17005656 RID: 22102
		// (get) Token: 0x0601982B RID: 104491 RVA: 0x003B8B17 File Offset: 0x003B6D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005657 RID: 22103
		// (get) Token: 0x0601982C RID: 104492 RVA: 0x003B8B1A File Offset: 0x003B6D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolGalleryPb.Descriptor;
			}
		}

		// Token: 0x0601982D RID: 104493 RVA: 0x003B8B21 File Offset: 0x003B6D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolGalleryPb()
		{
		}

		// Token: 0x0601982E RID: 104494 RVA: 0x003B8B29 File Offset: 0x003B6D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolGalleryPb(SolarSchoolGalleryPb other) : this()
		{
			this.id_ = other.id_;
			this.isReward_ = other.isReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601982F RID: 104495 RVA: 0x003B8B5A File Offset: 0x003B6D5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolGalleryPb Clone()
		{
			return new SolarSchoolGalleryPb(this);
		}

		// Token: 0x17005658 RID: 22104
		// (get) Token: 0x06019830 RID: 104496 RVA: 0x003B8B62 File Offset: 0x003B6D62
		// (set) Token: 0x06019831 RID: 104497 RVA: 0x003B8B6A File Offset: 0x003B6D6A
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

		// Token: 0x17005659 RID: 22105
		// (get) Token: 0x06019832 RID: 104498 RVA: 0x003B8B73 File Offset: 0x003B6D73
		// (set) Token: 0x06019833 RID: 104499 RVA: 0x003B8B7B File Offset: 0x003B6D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReward
		{
			get
			{
				return this.isReward_;
			}
			set
			{
				this.isReward_ = value;
			}
		}

		// Token: 0x06019834 RID: 104500 RVA: 0x003B8B84 File Offset: 0x003B6D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolGalleryPb);
		}

		// Token: 0x06019835 RID: 104501 RVA: 0x003B8B92 File Offset: 0x003B6D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolGalleryPb other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsReward == other.IsReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019836 RID: 104502 RVA: 0x003B8BD0 File Offset: 0x003B6DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.IsReward)
			{
				num ^= this.IsReward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019837 RID: 104503 RVA: 0x003B8C28 File Offset: 0x003B6E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019838 RID: 104504 RVA: 0x003B8C35 File Offset: 0x003B6E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019839 RID: 104505 RVA: 0x003B8C40 File Offset: 0x003B6E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.IsReward)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsReward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601983A RID: 104506 RVA: 0x003B8C98 File Offset: 0x003B6E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.IsReward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601983B RID: 104507 RVA: 0x003B8CE4 File Offset: 0x003B6EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolGalleryPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.IsReward)
			{
				this.IsReward = other.IsReward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601983C RID: 104508 RVA: 0x003B8D34 File Offset: 0x003B6F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601983D RID: 104509 RVA: 0x003B8D40 File Offset: 0x003B6F40
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
						this.IsReward = input.ReadBool();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040096C3 RID: 38595
		private static readonly MessageParser<SolarSchoolGalleryPb> _parser = new MessageParser<SolarSchoolGalleryPb>(() => new SolarSchoolGalleryPb());

		// Token: 0x040096C4 RID: 38596
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096C5 RID: 38597
		public const int IdFieldNumber = 1;

		// Token: 0x040096C6 RID: 38598
		private int id_;

		// Token: 0x040096C7 RID: 38599
		public const int IsRewardFieldNumber = 2;

		// Token: 0x040096C8 RID: 38600
		private bool isReward_;
	}
}
