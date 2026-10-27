using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200100F RID: 4111
	[NetMessage(EMessageId.RogueResTaskUpdateNotify)]
	public sealed class RogueResTaskUpdateNotify : IMessage<RogueResTaskUpdateNotify>, IMessage, IEquatable<RogueResTaskUpdateNotify>, IDeepCloneable<RogueResTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015FB1 RID: 90033 RVA: 0x003320A9 File Offset: 0x003302A9
		[NullableContext(1)]
		public static RogueResTaskUpdateNotify Create()
		{
			return new RogueResTaskUpdateNotify();
		}

		// Token: 0x17004977 RID: 18807
		// (get) Token: 0x06015FB2 RID: 90034 RVA: 0x003320B0 File Offset: 0x003302B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004978 RID: 18808
		// (get) Token: 0x06015FB3 RID: 90035 RVA: 0x003320B3 File Offset: 0x003302B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015FB4 RID: 90036 RVA: 0x003320BA File Offset: 0x003302BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTaskUpdateNotify()
		{
		}

		// Token: 0x06015FB5 RID: 90037 RVA: 0x003320C2 File Offset: 0x003302C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTaskUpdateNotify(RogueResTaskUpdateNotify other) : this()
		{
			this.rogueResBranchTaskTheme_ = ((other.rogueResBranchTaskTheme_ != null) ? other.rogueResBranchTaskTheme_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015FB6 RID: 90038 RVA: 0x003320F7 File Offset: 0x003302F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTaskUpdateNotify Clone()
		{
			return new RogueResTaskUpdateNotify(this);
		}

		// Token: 0x17004979 RID: 18809
		// (get) Token: 0x06015FB7 RID: 90039 RVA: 0x003320FF File Offset: 0x003302FF
		// (set) Token: 0x06015FB8 RID: 90040 RVA: 0x00332107 File Offset: 0x00330307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResBranchTaskTheme RogueResBranchTaskTheme
		{
			get
			{
				return this.rogueResBranchTaskTheme_;
			}
			set
			{
				this.rogueResBranchTaskTheme_ = value;
			}
		}

		// Token: 0x06015FB9 RID: 90041 RVA: 0x00332110 File Offset: 0x00330310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResTaskUpdateNotify);
		}

		// Token: 0x06015FBA RID: 90042 RVA: 0x0033211E File Offset: 0x0033031E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResTaskUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RogueResBranchTaskTheme, other.RogueResBranchTaskTheme) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015FBB RID: 90043 RVA: 0x00332154 File Offset: 0x00330354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueResBranchTaskTheme_ != null)
			{
				num ^= this.RogueResBranchTaskTheme.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015FBC RID: 90044 RVA: 0x00332190 File Offset: 0x00330390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015FBD RID: 90045 RVA: 0x0033219D File Offset: 0x0033039D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015FBE RID: 90046 RVA: 0x003321A6 File Offset: 0x003303A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueResBranchTaskTheme_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.RogueResBranchTaskTheme);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015FBF RID: 90047 RVA: 0x003321D8 File Offset: 0x003303D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueResBranchTaskTheme_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueResBranchTaskTheme);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015FC0 RID: 90048 RVA: 0x00332218 File Offset: 0x00330418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueResBranchTaskTheme_ != null)
			{
				if (this.rogueResBranchTaskTheme_ == null)
				{
					this.RogueResBranchTaskTheme = new RogueResBranchTaskTheme();
				}
				this.RogueResBranchTaskTheme.MergeFrom(other.RogueResBranchTaskTheme);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015FC1 RID: 90049 RVA: 0x0033226C File Offset: 0x0033046C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015FC2 RID: 90050 RVA: 0x00332278 File Offset: 0x00330478
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.rogueResBranchTaskTheme_ == null)
					{
						this.RogueResBranchTaskTheme = new RogueResBranchTaskTheme();
					}
					input.ReadMessage(this.RogueResBranchTaskTheme);
				}
			}
		}

		// Token: 0x040083DC RID: 33756
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083DD RID: 33757
		public const int RogueResBranchTaskThemeFieldNumber = 5;

		// Token: 0x040083DE RID: 33758
		private RogueResBranchTaskTheme rogueResBranchTaskTheme_;
	}
}
