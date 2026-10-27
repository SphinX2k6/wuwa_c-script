using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000797 RID: 1943
	public sealed class HonamiStoryPosInfo : IMessage<HonamiStoryPosInfo>, IMessage, IEquatable<HonamiStoryPosInfo>, IDeepCloneable<HonamiStoryPosInfo>, IBufferMessage
	{
		// Token: 0x0600AF48 RID: 44872 RVA: 0x001A4C1C File Offset: 0x001A2E1C
		[NullableContext(1)]
		public static HonamiStoryPosInfo Create()
		{
			return new HonamiStoryPosInfo();
		}

		// Token: 0x1700235B RID: 9051
		// (get) Token: 0x0600AF49 RID: 44873 RVA: 0x001A4C23 File Offset: 0x001A2E23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700235C RID: 9052
		// (get) Token: 0x0600AF4A RID: 44874 RVA: 0x001A4C26 File Offset: 0x001A2E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryPosInfo.Descriptor;
			}
		}

		// Token: 0x0600AF4B RID: 44875 RVA: 0x001A4C2D File Offset: 0x001A2E2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPosInfo()
		{
		}

		// Token: 0x0600AF4C RID: 44876 RVA: 0x001A4C35 File Offset: 0x001A2E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPosInfo(HonamiStoryPosInfo other) : this()
		{
			this.isCross_ = other.isCross_;
			this.position_ = other.position_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF4D RID: 44877 RVA: 0x001A4C66 File Offset: 0x001A2E66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPosInfo Clone()
		{
			return new HonamiStoryPosInfo(this);
		}

		// Token: 0x1700235D RID: 9053
		// (get) Token: 0x0600AF4E RID: 44878 RVA: 0x001A4C6E File Offset: 0x001A2E6E
		// (set) Token: 0x0600AF4F RID: 44879 RVA: 0x001A4C76 File Offset: 0x001A2E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCross
		{
			get
			{
				return this.isCross_;
			}
			set
			{
				this.isCross_ = value;
			}
		}

		// Token: 0x1700235E RID: 9054
		// (get) Token: 0x0600AF50 RID: 44880 RVA: 0x001A4C7F File Offset: 0x001A2E7F
		// (set) Token: 0x0600AF51 RID: 44881 RVA: 0x001A4C87 File Offset: 0x001A2E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Position
		{
			get
			{
				return this.position_;
			}
			set
			{
				this.position_ = value;
			}
		}

		// Token: 0x0600AF52 RID: 44882 RVA: 0x001A4C90 File Offset: 0x001A2E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryPosInfo);
		}

		// Token: 0x0600AF53 RID: 44883 RVA: 0x001A4C9E File Offset: 0x001A2E9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryPosInfo other)
		{
			return other != null && (other == this || (this.IsCross == other.IsCross && this.Position == other.Position && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AF54 RID: 44884 RVA: 0x001A4CDC File Offset: 0x001A2EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsCross)
			{
				num ^= this.IsCross.GetHashCode();
			}
			if (this.Position != 0)
			{
				num ^= this.Position.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AF55 RID: 44885 RVA: 0x001A4D34 File Offset: 0x001A2F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AF56 RID: 44886 RVA: 0x001A4D41 File Offset: 0x001A2F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF57 RID: 44887 RVA: 0x001A4D4C File Offset: 0x001A2F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsCross)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsCross);
			}
			if (this.Position != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Position);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF58 RID: 44888 RVA: 0x001A4DA4 File Offset: 0x001A2FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsCross)
			{
				num += 2;
			}
			if (this.Position != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Position);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AF59 RID: 44889 RVA: 0x001A4DF0 File Offset: 0x001A2FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryPosInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsCross)
			{
				this.IsCross = other.IsCross;
			}
			if (other.Position != 0)
			{
				this.Position = other.Position;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AF5A RID: 44890 RVA: 0x001A4E40 File Offset: 0x001A3040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF5B RID: 44891 RVA: 0x001A4E4C File Offset: 0x001A304C
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
						this.Position = input.ReadInt32();
					}
				}
				else
				{
					this.IsCross = input.ReadBool();
				}
			}
		}

		// Token: 0x04004EED RID: 20205
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EEE RID: 20206
		public const int IsCrossFieldNumber = 1;

		// Token: 0x04004EEF RID: 20207
		private bool isCross_;

		// Token: 0x04004EF0 RID: 20208
		public const int PositionFieldNumber = 2;

		// Token: 0x04004EF1 RID: 20209
		private int position_;
	}
}
