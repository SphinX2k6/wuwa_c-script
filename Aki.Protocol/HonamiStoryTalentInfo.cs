using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000792 RID: 1938
	public sealed class HonamiStoryTalentInfo : IMessage<HonamiStoryTalentInfo>, IMessage, IEquatable<HonamiStoryTalentInfo>, IDeepCloneable<HonamiStoryTalentInfo>, IBufferMessage
	{
		// Token: 0x0600AF23 RID: 44835 RVA: 0x001A4A03 File Offset: 0x001A2C03
		[NullableContext(1)]
		public static HonamiStoryTalentInfo Create()
		{
			return new HonamiStoryTalentInfo();
		}

		// Token: 0x17002350 RID: 9040
		// (get) Token: 0x0600AF24 RID: 44836 RVA: 0x001A4A0A File Offset: 0x001A2C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStoryTalentInfo> Parser
		{
			get
			{
				return HonamiStoryTalentInfo._parser;
			}
		}

		// Token: 0x17002351 RID: 9041
		// (get) Token: 0x0600AF25 RID: 44837 RVA: 0x001A4A11 File Offset: 0x001A2C11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002352 RID: 9042
		// (get) Token: 0x0600AF26 RID: 44838 RVA: 0x001A4A14 File Offset: 0x001A2C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryTalentInfo.Descriptor;
			}
		}

		// Token: 0x0600AF27 RID: 44839 RVA: 0x001A4A1B File Offset: 0x001A2C1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTalentInfo()
		{
		}

		// Token: 0x0600AF28 RID: 44840 RVA: 0x001A4A23 File Offset: 0x001A2C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTalentInfo(HonamiStoryTalentInfo other) : this()
		{
			this.talentId_ = other.talentId_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF29 RID: 44841 RVA: 0x001A4A54 File Offset: 0x001A2C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTalentInfo Clone()
		{
			return new HonamiStoryTalentInfo(this);
		}

		// Token: 0x17002353 RID: 9043
		// (get) Token: 0x0600AF2A RID: 44842 RVA: 0x001A4A5C File Offset: 0x001A2C5C
		// (set) Token: 0x0600AF2B RID: 44843 RVA: 0x001A4A64 File Offset: 0x001A2C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TalentId
		{
			get
			{
				return this.talentId_;
			}
			set
			{
				this.talentId_ = value;
			}
		}

		// Token: 0x17002354 RID: 9044
		// (get) Token: 0x0600AF2C RID: 44844 RVA: 0x001A4A6D File Offset: 0x001A2C6D
		// (set) Token: 0x0600AF2D RID: 44845 RVA: 0x001A4A75 File Offset: 0x001A2C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x0600AF2E RID: 44846 RVA: 0x001A4A7E File Offset: 0x001A2C7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryTalentInfo);
		}

		// Token: 0x0600AF2F RID: 44847 RVA: 0x001A4A8C File Offset: 0x001A2C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryTalentInfo other)
		{
			return other != null && (other == this || (this.TalentId == other.TalentId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AF30 RID: 44848 RVA: 0x001A4ACC File Offset: 0x001A2CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TalentId != 0)
			{
				num ^= this.TalentId.GetHashCode();
			}
			if (this.Status != 0)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AF31 RID: 44849 RVA: 0x001A4B24 File Offset: 0x001A2D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AF32 RID: 44850 RVA: 0x001A4B31 File Offset: 0x001A2D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF33 RID: 44851 RVA: 0x001A4B3C File Offset: 0x001A2D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TalentId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TalentId);
			}
			if (this.Status != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF34 RID: 44852 RVA: 0x001A4B94 File Offset: 0x001A2D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TalentId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TalentId);
			}
			if (this.Status != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AF35 RID: 44853 RVA: 0x001A4BEC File Offset: 0x001A2DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryTalentInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TalentId != 0)
			{
				this.TalentId = other.TalentId;
			}
			if (other.Status != 0)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AF36 RID: 44854 RVA: 0x001A4C3C File Offset: 0x001A2E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF37 RID: 44855 RVA: 0x001A4C48 File Offset: 0x001A2E48
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
						this.Status = input.ReadInt32();
					}
				}
				else
				{
					this.TalentId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004F3E RID: 20286
		private static readonly MessageParser<HonamiStoryTalentInfo> _parser = new MessageParser<HonamiStoryTalentInfo>(() => new HonamiStoryTalentInfo());

		// Token: 0x04004F3F RID: 20287
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F40 RID: 20288
		public const int TalentIdFieldNumber = 1;

		// Token: 0x04004F41 RID: 20289
		private int talentId_;

		// Token: 0x04004F42 RID: 20290
		public const int StatusFieldNumber = 2;

		// Token: 0x04004F43 RID: 20291
		private int status_;
	}
}
