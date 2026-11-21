using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000673 RID: 1651
	public sealed class GachaAccumulateInfo : IMessage<GachaAccumulateInfo>, IMessage, IEquatable<GachaAccumulateInfo>, IDeepCloneable<GachaAccumulateInfo>, IBufferMessage
	{
		// Token: 0x060097A5 RID: 38821 RVA: 0x0016DDFA File Offset: 0x0016BFFA
		[NullableContext(1)]
		public static GachaAccumulateInfo Create()
		{
			return new GachaAccumulateInfo();
		}

		// Token: 0x17001E34 RID: 7732
		// (get) Token: 0x060097A6 RID: 38822 RVA: 0x0016DE01 File Offset: 0x0016C001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E35 RID: 7733
		// (get) Token: 0x060097A7 RID: 38823 RVA: 0x0016DE04 File Offset: 0x0016C004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaAccumulateInfo.Descriptor;
			}
		}

		// Token: 0x060097A8 RID: 38824 RVA: 0x0016DE0B File Offset: 0x0016C00B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfo()
		{
		}

		// Token: 0x060097A9 RID: 38825 RVA: 0x0016DE14 File Offset: 0x0016C014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfo(GachaAccumulateInfo other) : this()
		{
			this.gachaAccumulateId_ = other.gachaAccumulateId_;
			this.gachaAccumulateGroupInfo_ = ((other.gachaAccumulateGroupInfo_ != null) ? other.gachaAccumulateGroupInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060097AA RID: 38826 RVA: 0x0016DE60 File Offset: 0x0016C060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfo Clone()
		{
			return new GachaAccumulateInfo(this);
		}

		// Token: 0x17001E36 RID: 7734
		// (get) Token: 0x060097AB RID: 38827 RVA: 0x0016DE68 File Offset: 0x0016C068
		// (set) Token: 0x060097AC RID: 38828 RVA: 0x0016DE70 File Offset: 0x0016C070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GachaAccumulateId
		{
			get
			{
				return this.gachaAccumulateId_;
			}
			set
			{
				this.gachaAccumulateId_ = value;
			}
		}

		// Token: 0x17001E37 RID: 7735
		// (get) Token: 0x060097AD RID: 38829 RVA: 0x0016DE79 File Offset: 0x0016C079
		// (set) Token: 0x060097AE RID: 38830 RVA: 0x0016DE81 File Offset: 0x0016C081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateGroupInfo GachaAccumulateGroupInfo
		{
			get
			{
				return this.gachaAccumulateGroupInfo_;
			}
			set
			{
				this.gachaAccumulateGroupInfo_ = value;
			}
		}

		// Token: 0x060097AF RID: 38831 RVA: 0x0016DE8A File Offset: 0x0016C08A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaAccumulateInfo);
		}

		// Token: 0x060097B0 RID: 38832 RVA: 0x0016DE98 File Offset: 0x0016C098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaAccumulateInfo other)
		{
			return other != null && (other == this || (this.GachaAccumulateId == other.GachaAccumulateId && object.Equals(this.GachaAccumulateGroupInfo, other.GachaAccumulateGroupInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060097B1 RID: 38833 RVA: 0x0016DEE8 File Offset: 0x0016C0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GachaAccumulateId != 0)
			{
				num ^= this.GachaAccumulateId.GetHashCode();
			}
			if (this.gachaAccumulateGroupInfo_ != null)
			{
				num ^= this.GachaAccumulateGroupInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060097B2 RID: 38834 RVA: 0x0016DF3D File Offset: 0x0016C13D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060097B3 RID: 38835 RVA: 0x0016DF4A File Offset: 0x0016C14A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060097B4 RID: 38836 RVA: 0x0016DF54 File Offset: 0x0016C154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GachaAccumulateId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GachaAccumulateId);
			}
			if (this.gachaAccumulateGroupInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GachaAccumulateGroupInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060097B5 RID: 38837 RVA: 0x0016DFAC File Offset: 0x0016C1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GachaAccumulateId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GachaAccumulateId);
			}
			if (this.gachaAccumulateGroupInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GachaAccumulateGroupInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060097B6 RID: 38838 RVA: 0x0016E004 File Offset: 0x0016C204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaAccumulateInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GachaAccumulateId != 0)
			{
				this.GachaAccumulateId = other.GachaAccumulateId;
			}
			if (other.gachaAccumulateGroupInfo_ != null)
			{
				if (this.gachaAccumulateGroupInfo_ == null)
				{
					this.GachaAccumulateGroupInfo = new GachaAccumulateGroupInfo();
				}
				this.GachaAccumulateGroupInfo.MergeFrom(other.GachaAccumulateGroupInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060097B7 RID: 38839 RVA: 0x0016E06C File Offset: 0x0016C26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060097B8 RID: 38840 RVA: 0x0016E078 File Offset: 0x0016C278
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.gachaAccumulateGroupInfo_ == null)
						{
							this.GachaAccumulateGroupInfo = new GachaAccumulateGroupInfo();
						}
						input.ReadMessage(this.GachaAccumulateGroupInfo);
					}
				}
				else
				{
					this.GachaAccumulateId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004868 RID: 18536
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004869 RID: 18537
		public const int GachaAccumulateIdFieldNumber = 1;

		// Token: 0x0400486A RID: 18538
		private int gachaAccumulateId_;

		// Token: 0x0400486B RID: 18539
		public const int GachaAccumulateGroupInfoFieldNumber = 2;

		// Token: 0x0400486C RID: 18540
		private GachaAccumulateGroupInfo gachaAccumulateGroupInfo_;
	}
}
