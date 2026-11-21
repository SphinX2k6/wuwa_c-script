using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000675 RID: 1653
	[NetMessage(EMessageId.GachaAccumulateInfoRequest)]
	public sealed class GachaAccumulateInfoRequest : IMessage<GachaAccumulateInfoRequest>, IMessage, IEquatable<GachaAccumulateInfoRequest>, IDeepCloneable<GachaAccumulateInfoRequest>, IBufferMessage
	{
		// Token: 0x060097CB RID: 38859 RVA: 0x0016E308 File Offset: 0x0016C508
		[NullableContext(1)]
		public static GachaAccumulateInfoRequest Create()
		{
			return new GachaAccumulateInfoRequest();
		}

		// Token: 0x17001E3B RID: 7739
		// (get) Token: 0x060097CC RID: 38860 RVA: 0x0016E30F File Offset: 0x0016C50F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E3C RID: 7740
		// (get) Token: 0x060097CD RID: 38861 RVA: 0x0016E312 File Offset: 0x0016C512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaAccumulateInfoRequest.Descriptor;
			}
		}

		// Token: 0x060097CE RID: 38862 RVA: 0x0016E319 File Offset: 0x0016C519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfoRequest()
		{
		}

		// Token: 0x060097CF RID: 38863 RVA: 0x0016E321 File Offset: 0x0016C521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfoRequest(GachaAccumulateInfoRequest other) : this()
		{
			this.gachaAccumulateId_ = other.gachaAccumulateId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060097D0 RID: 38864 RVA: 0x0016E346 File Offset: 0x0016C546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfoRequest Clone()
		{
			return new GachaAccumulateInfoRequest(this);
		}

		// Token: 0x17001E3D RID: 7741
		// (get) Token: 0x060097D1 RID: 38865 RVA: 0x0016E34E File Offset: 0x0016C54E
		// (set) Token: 0x060097D2 RID: 38866 RVA: 0x0016E356 File Offset: 0x0016C556
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

		// Token: 0x060097D3 RID: 38867 RVA: 0x0016E35F File Offset: 0x0016C55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaAccumulateInfoRequest);
		}

		// Token: 0x060097D4 RID: 38868 RVA: 0x0016E36D File Offset: 0x0016C56D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaAccumulateInfoRequest other)
		{
			return other != null && (other == this || (this.GachaAccumulateId == other.GachaAccumulateId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060097D5 RID: 38869 RVA: 0x0016E39C File Offset: 0x0016C59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GachaAccumulateId != 0)
			{
				num ^= this.GachaAccumulateId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060097D6 RID: 38870 RVA: 0x0016E3DB File Offset: 0x0016C5DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060097D7 RID: 38871 RVA: 0x0016E3E8 File Offset: 0x0016C5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060097D8 RID: 38872 RVA: 0x0016E3F1 File Offset: 0x0016C5F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GachaAccumulateId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.GachaAccumulateId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060097D9 RID: 38873 RVA: 0x0016E424 File Offset: 0x0016C624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GachaAccumulateId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GachaAccumulateId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060097DA RID: 38874 RVA: 0x0016E462 File Offset: 0x0016C662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaAccumulateInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GachaAccumulateId != 0)
			{
				this.GachaAccumulateId = other.GachaAccumulateId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060097DB RID: 38875 RVA: 0x0016E493 File Offset: 0x0016C693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060097DC RID: 38876 RVA: 0x0016E49C File Offset: 0x0016C69C
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
					this.GachaAccumulateId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004870 RID: 18544
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004871 RID: 18545
		public const int GachaAccumulateIdFieldNumber = 7;

		// Token: 0x04004872 RID: 18546
		private int gachaAccumulateId_;
	}
}
