using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000674 RID: 1652
	[NetMessage(EMessageId.GachaAccumulateInfoNotify)]
	public sealed class GachaAccumulateInfoNotify : IMessage<GachaAccumulateInfoNotify>, IMessage, IEquatable<GachaAccumulateInfoNotify>, IDeepCloneable<GachaAccumulateInfoNotify>, IBufferMessage
	{
		// Token: 0x060097B9 RID: 38841 RVA: 0x0016E0E2 File Offset: 0x0016C2E2
		[NullableContext(1)]
		public static GachaAccumulateInfoNotify Create()
		{
			return new GachaAccumulateInfoNotify();
		}

		// Token: 0x17001E38 RID: 7736
		// (get) Token: 0x060097BA RID: 38842 RVA: 0x0016E0E9 File Offset: 0x0016C2E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E39 RID: 7737
		// (get) Token: 0x060097BB RID: 38843 RVA: 0x0016E0EC File Offset: 0x0016C2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaAccumulateInfoNotify.Descriptor;
			}
		}

		// Token: 0x060097BC RID: 38844 RVA: 0x0016E0F3 File Offset: 0x0016C2F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfoNotify()
		{
		}

		// Token: 0x060097BD RID: 38845 RVA: 0x0016E0FB File Offset: 0x0016C2FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfoNotify(GachaAccumulateInfoNotify other) : this()
		{
			this.gachaAccumulateInfo_ = ((other.gachaAccumulateInfo_ != null) ? other.gachaAccumulateInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060097BE RID: 38846 RVA: 0x0016E130 File Offset: 0x0016C330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfoNotify Clone()
		{
			return new GachaAccumulateInfoNotify(this);
		}

		// Token: 0x17001E3A RID: 7738
		// (get) Token: 0x060097BF RID: 38847 RVA: 0x0016E138 File Offset: 0x0016C338
		// (set) Token: 0x060097C0 RID: 38848 RVA: 0x0016E140 File Offset: 0x0016C340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfo GachaAccumulateInfo
		{
			get
			{
				return this.gachaAccumulateInfo_;
			}
			set
			{
				this.gachaAccumulateInfo_ = value;
			}
		}

		// Token: 0x060097C1 RID: 38849 RVA: 0x0016E149 File Offset: 0x0016C349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaAccumulateInfoNotify);
		}

		// Token: 0x060097C2 RID: 38850 RVA: 0x0016E157 File Offset: 0x0016C357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaAccumulateInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.GachaAccumulateInfo, other.GachaAccumulateInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060097C3 RID: 38851 RVA: 0x0016E18C File Offset: 0x0016C38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gachaAccumulateInfo_ != null)
			{
				num ^= this.GachaAccumulateInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060097C4 RID: 38852 RVA: 0x0016E1C8 File Offset: 0x0016C3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060097C5 RID: 38853 RVA: 0x0016E1D5 File Offset: 0x0016C3D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060097C6 RID: 38854 RVA: 0x0016E1DE File Offset: 0x0016C3DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gachaAccumulateInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.GachaAccumulateInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060097C7 RID: 38855 RVA: 0x0016E210 File Offset: 0x0016C410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gachaAccumulateInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GachaAccumulateInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060097C8 RID: 38856 RVA: 0x0016E250 File Offset: 0x0016C450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaAccumulateInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gachaAccumulateInfo_ != null)
			{
				if (this.gachaAccumulateInfo_ == null)
				{
					this.GachaAccumulateInfo = new GachaAccumulateInfo();
				}
				this.GachaAccumulateInfo.MergeFrom(other.GachaAccumulateInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060097C9 RID: 38857 RVA: 0x0016E2A4 File Offset: 0x0016C4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060097CA RID: 38858 RVA: 0x0016E2B0 File Offset: 0x0016C4B0
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.gachaAccumulateInfo_ == null)
					{
						this.GachaAccumulateInfo = new GachaAccumulateInfo();
					}
					input.ReadMessage(this.GachaAccumulateInfo);
				}
			}
		}

		// Token: 0x0400486D RID: 18541
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400486E RID: 18542
		public const int GachaAccumulateInfoFieldNumber = 9;

		// Token: 0x0400486F RID: 18543
		private GachaAccumulateInfo gachaAccumulateInfo_;
	}
}
