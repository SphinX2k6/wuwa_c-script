using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200058C RID: 1420
	[NetMessage(EMessageId.FishingTechInfoUpdateNotify)]
	public sealed class FishingTechInfoUpdateNotify : IMessage<FishingTechInfoUpdateNotify>, IMessage, IEquatable<FishingTechInfoUpdateNotify>, IDeepCloneable<FishingTechInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x060083B0 RID: 33712 RVA: 0x0013D1AE File Offset: 0x0013B3AE
		[NullableContext(1)]
		public static FishingTechInfoUpdateNotify Create()
		{
			return new FishingTechInfoUpdateNotify();
		}

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x060083B1 RID: 33713 RVA: 0x0013D1B5 File Offset: 0x0013B3B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x060083B2 RID: 33714 RVA: 0x0013D1B8 File Offset: 0x0013B3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingTechInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060083B3 RID: 33715 RVA: 0x0013D1BF File Offset: 0x0013B3BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechInfoUpdateNotify()
		{
		}

		// Token: 0x060083B4 RID: 33716 RVA: 0x0013D1C7 File Offset: 0x0013B3C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechInfoUpdateNotify(FishingTechInfoUpdateNotify other) : this()
		{
			this.techInfo_ = ((other.techInfo_ != null) ? other.techInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060083B5 RID: 33717 RVA: 0x0013D1FC File Offset: 0x0013B3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechInfoUpdateNotify Clone()
		{
			return new FishingTechInfoUpdateNotify(this);
		}

		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x060083B6 RID: 33718 RVA: 0x0013D204 File Offset: 0x0013B404
		// (set) Token: 0x060083B7 RID: 33719 RVA: 0x0013D20C File Offset: 0x0013B40C
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

		// Token: 0x060083B8 RID: 33720 RVA: 0x0013D215 File Offset: 0x0013B415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingTechInfoUpdateNotify);
		}

		// Token: 0x060083B9 RID: 33721 RVA: 0x0013D223 File Offset: 0x0013B423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingTechInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.TechInfo, other.TechInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060083BA RID: 33722 RVA: 0x0013D258 File Offset: 0x0013B458
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

		// Token: 0x060083BB RID: 33723 RVA: 0x0013D294 File Offset: 0x0013B494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060083BC RID: 33724 RVA: 0x0013D2A1 File Offset: 0x0013B4A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060083BD RID: 33725 RVA: 0x0013D2AA File Offset: 0x0013B4AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.techInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.TechInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060083BE RID: 33726 RVA: 0x0013D2DC File Offset: 0x0013B4DC
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

		// Token: 0x060083BF RID: 33727 RVA: 0x0013D31C File Offset: 0x0013B51C
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

		// Token: 0x060083C0 RID: 33728 RVA: 0x0013D370 File Offset: 0x0013B570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060083C1 RID: 33729 RVA: 0x0013D37C File Offset: 0x0013B57C
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
				if (num != 66U)
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

		// Token: 0x04004188 RID: 16776
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004189 RID: 16777
		public const int TechInfoFieldNumber = 8;

		// Token: 0x0400418A RID: 16778
		private FishingTechInfo techInfo_;
	}
}
