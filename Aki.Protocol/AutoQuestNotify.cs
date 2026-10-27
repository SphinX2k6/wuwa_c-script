using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200012D RID: 301
	[NetMessage(EMessageId.AutoQuestNotify)]
	public sealed class AutoQuestNotify : IMessage<AutoQuestNotify>, IMessage, IEquatable<AutoQuestNotify>, IDeepCloneable<AutoQuestNotify>, IBufferMessage
	{
		// Token: 0x060027ED RID: 10221 RVA: 0x00069641 File Offset: 0x00067841
		[NullableContext(1)]
		public static AutoQuestNotify Create()
		{
			return new AutoQuestNotify();
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060027EE RID: 10222 RVA: 0x00069648 File Offset: 0x00067848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060027EF RID: 10223 RVA: 0x0006964B File Offset: 0x0006784B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AutoQuestNotify.Descriptor;
			}
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x00069652 File Offset: 0x00067852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AutoQuestNotify()
		{
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x0006965A File Offset: 0x0006785A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AutoQuestNotify(AutoQuestNotify other) : this()
		{
			this.isAuto_ = other.isAuto_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x0006967F File Offset: 0x0006787F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AutoQuestNotify Clone()
		{
			return new AutoQuestNotify(this);
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060027F3 RID: 10227 RVA: 0x00069687 File Offset: 0x00067887
		// (set) Token: 0x060027F4 RID: 10228 RVA: 0x0006968F File Offset: 0x0006788F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAuto
		{
			get
			{
				return this.isAuto_;
			}
			set
			{
				this.isAuto_ = value;
			}
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x00069698 File Offset: 0x00067898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AutoQuestNotify);
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x000696A6 File Offset: 0x000678A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AutoQuestNotify other)
		{
			return other != null && (other == this || (this.IsAuto == other.IsAuto && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x000696D4 File Offset: 0x000678D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsAuto)
			{
				num ^= this.IsAuto.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x00069713 File Offset: 0x00067913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x00069720 File Offset: 0x00067920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x00069729 File Offset: 0x00067929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsAuto)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsAuto);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x0006975C File Offset: 0x0006795C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsAuto)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x0006978E File Offset: 0x0006798E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AutoQuestNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsAuto)
			{
				this.IsAuto = other.IsAuto;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x000697BF File Offset: 0x000679BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x000697C8 File Offset: 0x000679C8
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsAuto = input.ReadBool();
				}
			}
		}

		// Token: 0x04002684 RID: 9860
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002685 RID: 9861
		public const int IsAutoFieldNumber = 8;

		// Token: 0x04002686 RID: 9862
		private bool isAuto_;
	}
}
