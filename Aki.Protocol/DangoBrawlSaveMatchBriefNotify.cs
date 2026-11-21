using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200036F RID: 879
	[NetMessage(EMessageId.DangoBrawlSaveMatchBriefNotify)]
	public sealed class DangoBrawlSaveMatchBriefNotify : IMessage<DangoBrawlSaveMatchBriefNotify>, IMessage, IEquatable<DangoBrawlSaveMatchBriefNotify>, IDeepCloneable<DangoBrawlSaveMatchBriefNotify>, IBufferMessage
	{
		// Token: 0x060057C1 RID: 22465 RVA: 0x000D6AA2 File Offset: 0x000D4CA2
		[NullableContext(1)]
		public static DangoBrawlSaveMatchBriefNotify Create()
		{
			return new DangoBrawlSaveMatchBriefNotify();
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x060057C2 RID: 22466 RVA: 0x000D6AA9 File Offset: 0x000D4CA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x060057C3 RID: 22467 RVA: 0x000D6AAC File Offset: 0x000D4CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlSaveMatchBriefNotify.Descriptor;
			}
		}

		// Token: 0x060057C4 RID: 22468 RVA: 0x000D6AB3 File Offset: 0x000D4CB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSaveMatchBriefNotify()
		{
		}

		// Token: 0x060057C5 RID: 22469 RVA: 0x000D6ABB File Offset: 0x000D4CBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSaveMatchBriefNotify(DangoBrawlSaveMatchBriefNotify other) : this()
		{
			this.saveMatchBrief_ = ((other.saveMatchBrief_ != null) ? other.saveMatchBrief_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060057C6 RID: 22470 RVA: 0x000D6AF0 File Offset: 0x000D4CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSaveMatchBriefNotify Clone()
		{
			return new DangoBrawlSaveMatchBriefNotify(this);
		}

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x060057C7 RID: 22471 RVA: 0x000D6AF8 File Offset: 0x000D4CF8
		// (set) Token: 0x060057C8 RID: 22472 RVA: 0x000D6B00 File Offset: 0x000D4D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSaveMatchBrief SaveMatchBrief
		{
			get
			{
				return this.saveMatchBrief_;
			}
			set
			{
				this.saveMatchBrief_ = value;
			}
		}

		// Token: 0x060057C9 RID: 22473 RVA: 0x000D6B09 File Offset: 0x000D4D09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlSaveMatchBriefNotify);
		}

		// Token: 0x060057CA RID: 22474 RVA: 0x000D6B17 File Offset: 0x000D4D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlSaveMatchBriefNotify other)
		{
			return other != null && (other == this || (object.Equals(this.SaveMatchBrief, other.SaveMatchBrief) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060057CB RID: 22475 RVA: 0x000D6B4C File Offset: 0x000D4D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.saveMatchBrief_ != null)
			{
				num ^= this.SaveMatchBrief.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060057CC RID: 22476 RVA: 0x000D6B88 File Offset: 0x000D4D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060057CD RID: 22477 RVA: 0x000D6B95 File Offset: 0x000D4D95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060057CE RID: 22478 RVA: 0x000D6B9E File Offset: 0x000D4D9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.saveMatchBrief_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.SaveMatchBrief);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060057CF RID: 22479 RVA: 0x000D6BD0 File Offset: 0x000D4DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.saveMatchBrief_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SaveMatchBrief);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060057D0 RID: 22480 RVA: 0x000D6C10 File Offset: 0x000D4E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlSaveMatchBriefNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.saveMatchBrief_ != null)
			{
				if (this.saveMatchBrief_ == null)
				{
					this.SaveMatchBrief = new DangoBrawlSaveMatchBrief();
				}
				this.SaveMatchBrief.MergeFrom(other.SaveMatchBrief);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060057D1 RID: 22481 RVA: 0x000D6C64 File Offset: 0x000D4E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060057D2 RID: 22482 RVA: 0x000D6C70 File Offset: 0x000D4E70
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
					if (this.saveMatchBrief_ == null)
					{
						this.SaveMatchBrief = new DangoBrawlSaveMatchBrief();
					}
					input.ReadMessage(this.SaveMatchBrief);
				}
			}
		}

		// Token: 0x04003543 RID: 13635
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003544 RID: 13636
		public const int SaveMatchBriefFieldNumber = 8;

		// Token: 0x04003545 RID: 13637
		private DangoBrawlSaveMatchBrief saveMatchBrief_;
	}
}
