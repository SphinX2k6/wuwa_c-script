using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D07 RID: 3335
	[NetMessage(EMessageId.PhantomSkinChangeRequest)]
	public sealed class PhantomSkinChangeRequest : IMessage<PhantomSkinChangeRequest>, IMessage, IEquatable<PhantomSkinChangeRequest>, IDeepCloneable<PhantomSkinChangeRequest>, IBufferMessage
	{
		// Token: 0x0601205D RID: 73821 RVA: 0x002A2695 File Offset: 0x002A0895
		[NullableContext(1)]
		public static PhantomSkinChangeRequest Create()
		{
			return new PhantomSkinChangeRequest();
		}

		// Token: 0x17003BB6 RID: 15286
		// (get) Token: 0x0601205E RID: 73822 RVA: 0x002A269C File Offset: 0x002A089C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BB7 RID: 15287
		// (get) Token: 0x0601205F RID: 73823 RVA: 0x002A269F File Offset: 0x002A089F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomSkinChangeRequest.Descriptor;
			}
		}

		// Token: 0x06012060 RID: 73824 RVA: 0x002A26A6 File Offset: 0x002A08A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSkinChangeRequest()
		{
		}

		// Token: 0x06012061 RID: 73825 RVA: 0x002A26AE File Offset: 0x002A08AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSkinChangeRequest(PhantomSkinChangeRequest other) : this()
		{
			this.incrId_ = other.incrId_;
			this.skinId_ = other.skinId_;
			this.changeDefault_ = other.changeDefault_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012062 RID: 73826 RVA: 0x002A26EB File Offset: 0x002A08EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSkinChangeRequest Clone()
		{
			return new PhantomSkinChangeRequest(this);
		}

		// Token: 0x17003BB8 RID: 15288
		// (get) Token: 0x06012063 RID: 73827 RVA: 0x002A26F3 File Offset: 0x002A08F3
		// (set) Token: 0x06012064 RID: 73828 RVA: 0x002A26FB File Offset: 0x002A08FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x17003BB9 RID: 15289
		// (get) Token: 0x06012065 RID: 73829 RVA: 0x002A2704 File Offset: 0x002A0904
		// (set) Token: 0x06012066 RID: 73830 RVA: 0x002A270C File Offset: 0x002A090C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x17003BBA RID: 15290
		// (get) Token: 0x06012067 RID: 73831 RVA: 0x002A2715 File Offset: 0x002A0915
		// (set) Token: 0x06012068 RID: 73832 RVA: 0x002A271D File Offset: 0x002A091D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ChangeDefault
		{
			get
			{
				return this.changeDefault_;
			}
			set
			{
				this.changeDefault_ = value;
			}
		}

		// Token: 0x06012069 RID: 73833 RVA: 0x002A2726 File Offset: 0x002A0926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomSkinChangeRequest);
		}

		// Token: 0x0601206A RID: 73834 RVA: 0x002A2734 File Offset: 0x002A0934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomSkinChangeRequest other)
		{
			return other != null && (other == this || (this.IncrId == other.IncrId && this.SkinId == other.SkinId && this.ChangeDefault == other.ChangeDefault && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601206B RID: 73835 RVA: 0x002A2790 File Offset: 0x002A0990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			if (this.ChangeDefault)
			{
				num ^= this.ChangeDefault.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601206C RID: 73836 RVA: 0x002A2801 File Offset: 0x002A0A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601206D RID: 73837 RVA: 0x002A280E File Offset: 0x002A0A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601206E RID: 73838 RVA: 0x002A2818 File Offset: 0x002A0A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkinId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SkinId);
			}
			if (this.IncrId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.IncrId);
			}
			if (this.ChangeDefault)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.ChangeDefault);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601206F RID: 73839 RVA: 0x002A2890 File Offset: 0x002A0A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			if (this.ChangeDefault)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012070 RID: 73840 RVA: 0x002A28F4 File Offset: 0x002A0AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomSkinChangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			if (other.ChangeDefault)
			{
				this.ChangeDefault = other.ChangeDefault;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012071 RID: 73841 RVA: 0x002A2958 File Offset: 0x002A0B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012072 RID: 73842 RVA: 0x002A2964 File Offset: 0x002A0B64
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
				if (num != 16U)
				{
					if (num != 24U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ChangeDefault = input.ReadBool();
						}
					}
					else
					{
						this.IncrId = input.ReadInt32();
					}
				}
				else
				{
					this.SkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040070DC RID: 28892
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070DD RID: 28893
		public const int IncrIdFieldNumber = 3;

		// Token: 0x040070DE RID: 28894
		private int incrId_;

		// Token: 0x040070DF RID: 28895
		public const int SkinIdFieldNumber = 2;

		// Token: 0x040070E0 RID: 28896
		private int skinId_;

		// Token: 0x040070E1 RID: 28897
		public const int ChangeDefaultFieldNumber = 14;

		// Token: 0x040070E2 RID: 28898
		private bool changeDefault_;
	}
}
