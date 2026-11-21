using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000760 RID: 1888
	public sealed class HonamiStoryEnhanceLevelComponentPb : IMessage<HonamiStoryEnhanceLevelComponentPb>, IMessage, IEquatable<HonamiStoryEnhanceLevelComponentPb>, IDeepCloneable<HonamiStoryEnhanceLevelComponentPb>, IBufferMessage
	{
		// Token: 0x0600AB1B RID: 43803 RVA: 0x0019BDFC File Offset: 0x00199FFC
		[NullableContext(1)]
		public static HonamiStoryEnhanceLevelComponentPb Create()
		{
			return new HonamiStoryEnhanceLevelComponentPb();
		}

		// Token: 0x17002276 RID: 8822
		// (get) Token: 0x0600AB1C RID: 43804 RVA: 0x0019BE03 File Offset: 0x0019A003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002277 RID: 8823
		// (get) Token: 0x0600AB1D RID: 43805 RVA: 0x0019BE06 File Offset: 0x0019A006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryEnhanceLevelComponentPb.Descriptor;
			}
		}

		// Token: 0x0600AB1E RID: 43806 RVA: 0x0019BE0D File Offset: 0x0019A00D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEnhanceLevelComponentPb()
		{
		}

		// Token: 0x0600AB1F RID: 43807 RVA: 0x0019BE15 File Offset: 0x0019A015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEnhanceLevelComponentPb(HonamiStoryEnhanceLevelComponentPb other) : this()
		{
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB20 RID: 43808 RVA: 0x0019BE3A File Offset: 0x0019A03A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEnhanceLevelComponentPb Clone()
		{
			return new HonamiStoryEnhanceLevelComponentPb(this);
		}

		// Token: 0x17002278 RID: 8824
		// (get) Token: 0x0600AB21 RID: 43809 RVA: 0x0019BE42 File Offset: 0x0019A042
		// (set) Token: 0x0600AB22 RID: 43810 RVA: 0x0019BE4A File Offset: 0x0019A04A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x0600AB23 RID: 43811 RVA: 0x0019BE53 File Offset: 0x0019A053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryEnhanceLevelComponentPb);
		}

		// Token: 0x0600AB24 RID: 43812 RVA: 0x0019BE61 File Offset: 0x0019A061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryEnhanceLevelComponentPb other)
		{
			return other != null && (other == this || (this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AB25 RID: 43813 RVA: 0x0019BE90 File Offset: 0x0019A090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AB26 RID: 43814 RVA: 0x0019BECF File Offset: 0x0019A0CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AB27 RID: 43815 RVA: 0x0019BEDC File Offset: 0x0019A0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB28 RID: 43816 RVA: 0x0019BEE5 File Offset: 0x0019A0E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB29 RID: 43817 RVA: 0x0019BF18 File Offset: 0x0019A118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AB2A RID: 43818 RVA: 0x0019BF56 File Offset: 0x0019A156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryEnhanceLevelComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AB2B RID: 43819 RVA: 0x0019BF87 File Offset: 0x0019A187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB2C RID: 43820 RVA: 0x0019BF90 File Offset: 0x0019A190
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Level = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004E0F RID: 19983
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E10 RID: 19984
		public const int LevelFieldNumber = 1;

		// Token: 0x04004E11 RID: 19985
		private int level_;
	}
}
