using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000577 RID: 1399
	[NetMessage(EMessageId.FishingTechInfoUpdateNotify)]
	public sealed class FishingTechInfoUpdateNotify : IMessage<FishingTechInfoUpdateNotify>, IMessage, IEquatable<FishingTechInfoUpdateNotify>, IDeepCloneable<FishingTechInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06008248 RID: 33352 RVA: 0x0013A5A2 File Offset: 0x001387A2
		[NullableContext(1)]
		public static FishingTechInfoUpdateNotify Create()
		{
			return new FishingTechInfoUpdateNotify();
		}

		// Token: 0x1700195C RID: 6492
		// (get) Token: 0x06008249 RID: 33353 RVA: 0x0013A5A9 File Offset: 0x001387A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700195D RID: 6493
		// (get) Token: 0x0600824A RID: 33354 RVA: 0x0013A5AC File Offset: 0x001387AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingTechInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600824B RID: 33355 RVA: 0x0013A5B3 File Offset: 0x001387B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechInfoUpdateNotify()
		{
		}

		// Token: 0x0600824C RID: 33356 RVA: 0x0013A5BB File Offset: 0x001387BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechInfoUpdateNotify(FishingTechInfoUpdateNotify other) : this()
		{
			this.techInfo_ = ((other.techInfo_ != null) ? other.techInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600824D RID: 33357 RVA: 0x0013A5F0 File Offset: 0x001387F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechInfoUpdateNotify Clone()
		{
			return new FishingTechInfoUpdateNotify(this);
		}

		// Token: 0x1700195E RID: 6494
		// (get) Token: 0x0600824E RID: 33358 RVA: 0x0013A5F8 File Offset: 0x001387F8
		// (set) Token: 0x0600824F RID: 33359 RVA: 0x0013A600 File Offset: 0x00138800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechInfo TechInfo
		{
			get
			{
				return this.techInfo_;
			}
			set
			{
				this.techInfo_ = value;
			}
		}

		// Token: 0x06008250 RID: 33360 RVA: 0x0013A609 File Offset: 0x00138809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingTechInfoUpdateNotify);
		}

		// Token: 0x06008251 RID: 33361 RVA: 0x0013A617 File Offset: 0x00138817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingTechInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.TechInfo, other.TechInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008252 RID: 33362 RVA: 0x0013A64C File Offset: 0x0013884C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.techInfo_ != null)
			{
				num ^= this.TechInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008253 RID: 33363 RVA: 0x0013A688 File Offset: 0x00138888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008254 RID: 33364 RVA: 0x0013A695 File Offset: 0x00138895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008255 RID: 33365 RVA: 0x0013A69E File Offset: 0x0013889E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.techInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.TechInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008256 RID: 33366 RVA: 0x0013A6D0 File Offset: 0x001388D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.techInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TechInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008257 RID: 33367 RVA: 0x0013A710 File Offset: 0x00138910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingTechInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.techInfo_ != null)
			{
				if (this.techInfo_ == null)
				{
					this.TechInfo = new FishingTechInfo();
				}
				this.TechInfo.MergeFrom(other.TechInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008258 RID: 33368 RVA: 0x0013A764 File Offset: 0x00138964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008259 RID: 33369 RVA: 0x0013A770 File Offset: 0x00138970
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.techInfo_ == null)
					{
						this.TechInfo = new FishingTechInfo();
					}
					input.ReadMessage(this.TechInfo);
				}
			}
		}

		// Token: 0x0400417E RID: 16766
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400417F RID: 16767
		public const int TechInfoFieldNumber = 6;

		// Token: 0x04004180 RID: 16768
		private FishingTechInfo techInfo_;
	}
}
