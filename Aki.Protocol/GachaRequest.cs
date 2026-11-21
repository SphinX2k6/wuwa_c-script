using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000688 RID: 1672
	[NetMessage(EMessageId.GachaRequest)]
	public sealed class GachaRequest : IMessage<GachaRequest>, IMessage, IEquatable<GachaRequest>, IDeepCloneable<GachaRequest>, IBufferMessage
	{
		// Token: 0x06009994 RID: 39316 RVA: 0x001732CB File Offset: 0x001714CB
		[NullableContext(1)]
		public static GachaRequest Create()
		{
			return new GachaRequest();
		}

		// Token: 0x17001EB4 RID: 7860
		// (get) Token: 0x06009995 RID: 39317 RVA: 0x001732D2 File Offset: 0x001714D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001EB5 RID: 7861
		// (get) Token: 0x06009996 RID: 39318 RVA: 0x001732D5 File Offset: 0x001714D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaRequest.Descriptor;
			}
		}

		// Token: 0x06009997 RID: 39319 RVA: 0x001732DC File Offset: 0x001714DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRequest()
		{
		}

		// Token: 0x06009998 RID: 39320 RVA: 0x001732E4 File Offset: 0x001714E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRequest(GachaRequest other) : this()
		{
			this.gachaId_ = other.gachaId_;
			this.gachaTimes_ = other.gachaTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009999 RID: 39321 RVA: 0x00173315 File Offset: 0x00171515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRequest Clone()
		{
			return new GachaRequest(this);
		}

		// Token: 0x17001EB6 RID: 7862
		// (get) Token: 0x0600999A RID: 39322 RVA: 0x0017331D File Offset: 0x0017151D
		// (set) Token: 0x0600999B RID: 39323 RVA: 0x00173325 File Offset: 0x00171525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GachaId
		{
			get
			{
				return this.gachaId_;
			}
			set
			{
				this.gachaId_ = value;
			}
		}

		// Token: 0x17001EB7 RID: 7863
		// (get) Token: 0x0600999C RID: 39324 RVA: 0x0017332E File Offset: 0x0017152E
		// (set) Token: 0x0600999D RID: 39325 RVA: 0x00173336 File Offset: 0x00171536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GachaTimes
		{
			get
			{
				return this.gachaTimes_;
			}
			set
			{
				this.gachaTimes_ = value;
			}
		}

		// Token: 0x0600999E RID: 39326 RVA: 0x0017333F File Offset: 0x0017153F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaRequest);
		}

		// Token: 0x0600999F RID: 39327 RVA: 0x0017334D File Offset: 0x0017154D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaRequest other)
		{
			return other != null && (other == this || (this.GachaId == other.GachaId && this.GachaTimes == other.GachaTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060099A0 RID: 39328 RVA: 0x0017338C File Offset: 0x0017158C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GachaId != 0)
			{
				num ^= this.GachaId.GetHashCode();
			}
			if (this.GachaTimes != 0)
			{
				num ^= this.GachaTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060099A1 RID: 39329 RVA: 0x001733E4 File Offset: 0x001715E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060099A2 RID: 39330 RVA: 0x001733F1 File Offset: 0x001715F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060099A3 RID: 39331 RVA: 0x001733FC File Offset: 0x001715FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GachaId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.GachaId);
			}
			if (this.GachaTimes != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.GachaTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060099A4 RID: 39332 RVA: 0x00173458 File Offset: 0x00171658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GachaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GachaId);
			}
			if (this.GachaTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GachaTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060099A5 RID: 39333 RVA: 0x001734B0 File Offset: 0x001716B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GachaId != 0)
			{
				this.GachaId = other.GachaId;
			}
			if (other.GachaTimes != 0)
			{
				this.GachaTimes = other.GachaTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060099A6 RID: 39334 RVA: 0x00173500 File Offset: 0x00171700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060099A7 RID: 39335 RVA: 0x0017350C File Offset: 0x0017170C
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
				if (num != 96U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GachaTimes = input.ReadInt32();
					}
				}
				else
				{
					this.GachaId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004935 RID: 18741
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004936 RID: 18742
		public const int GachaIdFieldNumber = 12;

		// Token: 0x04004937 RID: 18743
		private int gachaId_;

		// Token: 0x04004938 RID: 18744
		public const int GachaTimesFieldNumber = 14;

		// Token: 0x04004939 RID: 18745
		private int gachaTimes_;
	}
}
