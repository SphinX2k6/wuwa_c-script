using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012B4 RID: 4788
	[NetMessage(EMessageId.SolarSchoolOneKeyGalleryRewardRequest)]
	public sealed class SolarSchoolOneKeyGalleryRewardRequest : IMessage<SolarSchoolOneKeyGalleryRewardRequest>, IMessage, IEquatable<SolarSchoolOneKeyGalleryRewardRequest>, IDeepCloneable<SolarSchoolOneKeyGalleryRewardRequest>, IBufferMessage
	{
		// Token: 0x060198EE RID: 104686 RVA: 0x003BA67E File Offset: 0x003B887E
		[NullableContext(1)]
		public static SolarSchoolOneKeyGalleryRewardRequest Create()
		{
			return new SolarSchoolOneKeyGalleryRewardRequest();
		}

		// Token: 0x17005682 RID: 22146
		// (get) Token: 0x060198EF RID: 104687 RVA: 0x003BA685 File Offset: 0x003B8885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005683 RID: 22147
		// (get) Token: 0x060198F0 RID: 104688 RVA: 0x003BA688 File Offset: 0x003B8888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolOneKeyGalleryRewardRequest.Descriptor;
			}
		}

		// Token: 0x060198F1 RID: 104689 RVA: 0x003BA68F File Offset: 0x003B888F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolOneKeyGalleryRewardRequest()
		{
		}

		// Token: 0x060198F2 RID: 104690 RVA: 0x003BA6A2 File Offset: 0x003B88A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolOneKeyGalleryRewardRequest(SolarSchoolOneKeyGalleryRewardRequest other) : this()
		{
			this.id_ = other.id_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060198F3 RID: 104691 RVA: 0x003BA6CC File Offset: 0x003B88CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolOneKeyGalleryRewardRequest Clone()
		{
			return new SolarSchoolOneKeyGalleryRewardRequest(this);
		}

		// Token: 0x17005684 RID: 22148
		// (get) Token: 0x060198F4 RID: 104692 RVA: 0x003BA6D4 File Offset: 0x003B88D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Id
		{
			get
			{
				return this.id_;
			}
		}

		// Token: 0x060198F5 RID: 104693 RVA: 0x003BA6DC File Offset: 0x003B88DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolOneKeyGalleryRewardRequest);
		}

		// Token: 0x060198F6 RID: 104694 RVA: 0x003BA6EA File Offset: 0x003B88EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolOneKeyGalleryRewardRequest other)
		{
			return other != null && (other == this || (this.id_.Equals(other.id_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060198F7 RID: 104695 RVA: 0x003BA720 File Offset: 0x003B8920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.id_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060198F8 RID: 104696 RVA: 0x003BA754 File Offset: 0x003B8954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060198F9 RID: 104697 RVA: 0x003BA761 File Offset: 0x003B8961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060198FA RID: 104698 RVA: 0x003BA76A File Offset: 0x003B896A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.id_.WriteTo(ref output, SolarSchoolOneKeyGalleryRewardRequest._repeated_id_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060198FB RID: 104699 RVA: 0x003BA794 File Offset: 0x003B8994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.id_.CalculateSize(SolarSchoolOneKeyGalleryRewardRequest._repeated_id_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060198FC RID: 104700 RVA: 0x003BA7CD File Offset: 0x003B89CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolOneKeyGalleryRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.id_.Add(other.id_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060198FD RID: 104701 RVA: 0x003BA7FB File Offset: 0x003B89FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060198FE RID: 104702 RVA: 0x003BA804 File Offset: 0x003B8A04
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
				if (num != 24U && num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.id_.AddEntriesFrom(ref input, SolarSchoolOneKeyGalleryRewardRequest._repeated_id_codec);
				}
			}
		}

		// Token: 0x04009703 RID: 38659
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009704 RID: 38660
		public const int IdFieldNumber = 3;

		// Token: 0x04009705 RID: 38661
		private static readonly FieldCodec<int> _repeated_id_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04009706 RID: 38662
		private readonly RepeatedField<int> id_ = new RepeatedField<int>();
	}
}
