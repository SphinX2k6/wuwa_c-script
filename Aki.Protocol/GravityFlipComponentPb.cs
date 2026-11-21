using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006FA RID: 1786
	public sealed class GravityFlipComponentPb : IMessage<GravityFlipComponentPb>, IMessage, IEquatable<GravityFlipComponentPb>, IDeepCloneable<GravityFlipComponentPb>, IBufferMessage
	{
		// Token: 0x0600A2F4 RID: 41716 RVA: 0x0018A0C8 File Offset: 0x001882C8
		[NullableContext(1)]
		public static GravityFlipComponentPb Create()
		{
			return new GravityFlipComponentPb();
		}

		// Token: 0x170020BF RID: 8383
		// (get) Token: 0x0600A2F5 RID: 41717 RVA: 0x0018A0CF File Offset: 0x001882CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020C0 RID: 8384
		// (get) Token: 0x0600A2F6 RID: 41718 RVA: 0x0018A0D2 File Offset: 0x001882D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GravityFlipComponentPb.Descriptor;
			}
		}

		// Token: 0x0600A2F7 RID: 41719 RVA: 0x0018A0D9 File Offset: 0x001882D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipComponentPb()
		{
		}

		// Token: 0x0600A2F8 RID: 41720 RVA: 0x0018A0E1 File Offset: 0x001882E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipComponentPb(GravityFlipComponentPb other) : this()
		{
			this.curGravityFlipType_ = other.curGravityFlipType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A2F9 RID: 41721 RVA: 0x0018A106 File Offset: 0x00188306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipComponentPb Clone()
		{
			return new GravityFlipComponentPb(this);
		}

		// Token: 0x170020C1 RID: 8385
		// (get) Token: 0x0600A2FA RID: 41722 RVA: 0x0018A10E File Offset: 0x0018830E
		// (set) Token: 0x0600A2FB RID: 41723 RVA: 0x0018A116 File Offset: 0x00188316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipType CurGravityFlipType
		{
			get
			{
				return this.curGravityFlipType_;
			}
			set
			{
				this.curGravityFlipType_ = value;
			}
		}

		// Token: 0x0600A2FC RID: 41724 RVA: 0x0018A11F File Offset: 0x0018831F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GravityFlipComponentPb);
		}

		// Token: 0x0600A2FD RID: 41725 RVA: 0x0018A12D File Offset: 0x0018832D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GravityFlipComponentPb other)
		{
			return other != null && (other == this || (this.CurGravityFlipType == other.CurGravityFlipType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A2FE RID: 41726 RVA: 0x0018A15C File Offset: 0x0018835C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurGravityFlipType != GravityFlipType.GravityUp)
			{
				num ^= this.CurGravityFlipType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A2FF RID: 41727 RVA: 0x0018A1A1 File Offset: 0x001883A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A300 RID: 41728 RVA: 0x0018A1AE File Offset: 0x001883AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A301 RID: 41729 RVA: 0x0018A1B7 File Offset: 0x001883B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurGravityFlipType != GravityFlipType.GravityUp)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.CurGravityFlipType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A302 RID: 41730 RVA: 0x0018A1E8 File Offset: 0x001883E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurGravityFlipType != GravityFlipType.GravityUp)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.CurGravityFlipType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A303 RID: 41731 RVA: 0x0018A226 File Offset: 0x00188426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GravityFlipComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurGravityFlipType != GravityFlipType.GravityUp)
			{
				this.CurGravityFlipType = other.CurGravityFlipType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A304 RID: 41732 RVA: 0x0018A257 File Offset: 0x00188457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A305 RID: 41733 RVA: 0x0018A260 File Offset: 0x00188460
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
					this.CurGravityFlipType = (GravityFlipType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004BBD RID: 19389
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BBE RID: 19390
		public const int CurGravityFlipTypeFieldNumber = 1;

		// Token: 0x04004BBF RID: 19391
		private GravityFlipType curGravityFlipType_;
	}
}
