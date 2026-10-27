using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000367 RID: 871
	[NetMessage(EMessageId.DangoBrawlSaveMatchBriefNotify)]
	public sealed class DangoBrawlSaveMatchBriefNotify : IMessage<DangoBrawlSaveMatchBriefNotify>, IMessage, IEquatable<DangoBrawlSaveMatchBriefNotify>, IDeepCloneable<DangoBrawlSaveMatchBriefNotify>, IBufferMessage
	{
		// Token: 0x060056D4 RID: 22228 RVA: 0x000D441A File Offset: 0x000D261A
		[NullableContext(1)]
		public static DangoBrawlSaveMatchBriefNotify Create()
		{
			return new DangoBrawlSaveMatchBriefNotify();
		}

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x060056D5 RID: 22229 RVA: 0x000D4421 File Offset: 0x000D2621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x060056D6 RID: 22230 RVA: 0x000D4424 File Offset: 0x000D2624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlSaveMatchBriefNotify.Descriptor;
			}
		}

		// Token: 0x060056D7 RID: 22231 RVA: 0x000D442B File Offset: 0x000D262B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSaveMatchBriefNotify()
		{
		}

		// Token: 0x060056D8 RID: 22232 RVA: 0x000D4433 File Offset: 0x000D2633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSaveMatchBriefNotify(DangoBrawlSaveMatchBriefNotify other) : this()
		{
			this.saveMatchBrief_ = ((other.saveMatchBrief_ != null) ? other.saveMatchBrief_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060056D9 RID: 22233 RVA: 0x000D4468 File Offset: 0x000D2668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSaveMatchBriefNotify Clone()
		{
			return new DangoBrawlSaveMatchBriefNotify(this);
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x060056DA RID: 22234 RVA: 0x000D4470 File Offset: 0x000D2670
		// (set) Token: 0x060056DB RID: 22235 RVA: 0x000D4478 File Offset: 0x000D2678
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

		// Token: 0x060056DC RID: 22236 RVA: 0x000D4481 File Offset: 0x000D2681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlSaveMatchBriefNotify);
		}

		// Token: 0x060056DD RID: 22237 RVA: 0x000D448F File Offset: 0x000D268F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlSaveMatchBriefNotify other)
		{
			return other != null && (other == this || (object.Equals(this.SaveMatchBrief, other.SaveMatchBrief) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060056DE RID: 22238 RVA: 0x000D44C4 File Offset: 0x000D26C4
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

		// Token: 0x060056DF RID: 22239 RVA: 0x000D4500 File Offset: 0x000D2700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060056E0 RID: 22240 RVA: 0x000D450D File Offset: 0x000D270D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060056E1 RID: 22241 RVA: 0x000D4516 File Offset: 0x000D2716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.saveMatchBrief_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.SaveMatchBrief);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060056E2 RID: 22242 RVA: 0x000D4548 File Offset: 0x000D2748
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

		// Token: 0x060056E3 RID: 22243 RVA: 0x000D4588 File Offset: 0x000D2788
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

		// Token: 0x060056E4 RID: 22244 RVA: 0x000D45DC File Offset: 0x000D27DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060056E5 RID: 22245 RVA: 0x000D45E8 File Offset: 0x000D27E8
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
				if (num != 26U)
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

		// Token: 0x040034A7 RID: 13479
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034A8 RID: 13480
		public const int SaveMatchBriefFieldNumber = 3;

		// Token: 0x040034A9 RID: 13481
		private DangoBrawlSaveMatchBrief saveMatchBrief_;
	}
}
