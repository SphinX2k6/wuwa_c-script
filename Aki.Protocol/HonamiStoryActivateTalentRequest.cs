using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200075C RID: 1884
	[NetMessage(EMessageId.HonamiStoryActivateTalentRequest)]
	public sealed class HonamiStoryActivateTalentRequest : IMessage<HonamiStoryActivateTalentRequest>, IMessage, IEquatable<HonamiStoryActivateTalentRequest>, IDeepCloneable<HonamiStoryActivateTalentRequest>, IBufferMessage
	{
		// Token: 0x0600AA8E RID: 43662 RVA: 0x0019A5DF File Offset: 0x001987DF
		[NullableContext(1)]
		public static HonamiStoryActivateTalentRequest Create()
		{
			return new HonamiStoryActivateTalentRequest();
		}

		// Token: 0x17002259 RID: 8793
		// (get) Token: 0x0600AA8F RID: 43663 RVA: 0x0019A5E6 File Offset: 0x001987E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700225A RID: 8794
		// (get) Token: 0x0600AA90 RID: 43664 RVA: 0x0019A5E9 File Offset: 0x001987E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryActivateTalentRequest.Descriptor;
			}
		}

		// Token: 0x0600AA91 RID: 43665 RVA: 0x0019A5F0 File Offset: 0x001987F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivateTalentRequest()
		{
		}

		// Token: 0x0600AA92 RID: 43666 RVA: 0x0019A5F8 File Offset: 0x001987F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivateTalentRequest(HonamiStoryActivateTalentRequest other) : this()
		{
			this.talentId_ = other.talentId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AA93 RID: 43667 RVA: 0x0019A61D File Offset: 0x0019881D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivateTalentRequest Clone()
		{
			return new HonamiStoryActivateTalentRequest(this);
		}

		// Token: 0x1700225B RID: 8795
		// (get) Token: 0x0600AA94 RID: 43668 RVA: 0x0019A625 File Offset: 0x00198825
		// (set) Token: 0x0600AA95 RID: 43669 RVA: 0x0019A62D File Offset: 0x0019882D
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

		// Token: 0x0600AA96 RID: 43670 RVA: 0x0019A636 File Offset: 0x00198836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryActivateTalentRequest);
		}

		// Token: 0x0600AA97 RID: 43671 RVA: 0x0019A644 File Offset: 0x00198844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryActivateTalentRequest other)
		{
			return other != null && (other == this || (this.TalentId == other.TalentId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AA98 RID: 43672 RVA: 0x0019A674 File Offset: 0x00198874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TalentId != 0)
			{
				num ^= this.TalentId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AA99 RID: 43673 RVA: 0x0019A6B3 File Offset: 0x001988B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AA9A RID: 43674 RVA: 0x0019A6C0 File Offset: 0x001988C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA9B RID: 43675 RVA: 0x0019A6C9 File Offset: 0x001988C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TalentId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TalentId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA9C RID: 43676 RVA: 0x0019A6FC File Offset: 0x001988FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TalentId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TalentId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AA9D RID: 43677 RVA: 0x0019A73A File Offset: 0x0019893A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryActivateTalentRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TalentId != 0)
			{
				this.TalentId = other.TalentId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AA9E RID: 43678 RVA: 0x0019A76B File Offset: 0x0019896B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA9F RID: 43679 RVA: 0x0019A774 File Offset: 0x00198974
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
					this.TalentId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004D82 RID: 19842
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D83 RID: 19843
		public const int TalentIdFieldNumber = 7;

		// Token: 0x04004D84 RID: 19844
		private int talentId_;
	}
}
