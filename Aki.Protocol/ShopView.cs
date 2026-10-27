using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011FC RID: 4604
	public sealed class ShopView : IMessage<ShopView>, IMessage, IEquatable<ShopView>, IDeepCloneable<ShopView>, IBufferMessage
	{
		// Token: 0x060188BB RID: 100539 RVA: 0x00391E4B File Offset: 0x0039004B
		[NullableContext(1)]
		public static ShopView Create()
		{
			return new ShopView();
		}

		// Token: 0x170052B0 RID: 21168
		// (get) Token: 0x060188BC RID: 100540 RVA: 0x00391E52 File Offset: 0x00390052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052B1 RID: 21169
		// (get) Token: 0x060188BD RID: 100541 RVA: 0x00391E55 File Offset: 0x00390055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopView.Descriptor;
			}
		}

		// Token: 0x060188BE RID: 100542 RVA: 0x00391E5C File Offset: 0x0039005C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopView()
		{
		}

		// Token: 0x060188BF RID: 100543 RVA: 0x00391E64 File Offset: 0x00390064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopView(ShopView other) : this()
		{
			this.survivorsOption_ = ((other.survivorsOption_ != null) ? other.survivorsOption_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060188C0 RID: 100544 RVA: 0x00391E99 File Offset: 0x00390099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopView Clone()
		{
			return new ShopView(this);
		}

		// Token: 0x170052B2 RID: 21170
		// (get) Token: 0x060188C1 RID: 100545 RVA: 0x00391EA1 File Offset: 0x003900A1
		// (set) Token: 0x060188C2 RID: 100546 RVA: 0x00391EA9 File Offset: 0x003900A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOption SurvivorsOption
		{
			get
			{
				return this.survivorsOption_;
			}
			set
			{
				this.survivorsOption_ = value;
			}
		}

		// Token: 0x060188C3 RID: 100547 RVA: 0x00391EB2 File Offset: 0x003900B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopView);
		}

		// Token: 0x060188C4 RID: 100548 RVA: 0x00391EC0 File Offset: 0x003900C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopView other)
		{
			return other != null && (other == this || (object.Equals(this.SurvivorsOption, other.SurvivorsOption) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060188C5 RID: 100549 RVA: 0x00391EF4 File Offset: 0x003900F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.survivorsOption_ != null)
			{
				num ^= this.SurvivorsOption.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060188C6 RID: 100550 RVA: 0x00391F30 File Offset: 0x00390130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060188C7 RID: 100551 RVA: 0x00391F3D File Offset: 0x0039013D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060188C8 RID: 100552 RVA: 0x00391F46 File Offset: 0x00390146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.survivorsOption_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SurvivorsOption);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060188C9 RID: 100553 RVA: 0x00391F78 File Offset: 0x00390178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.survivorsOption_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorsOption);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060188CA RID: 100554 RVA: 0x00391FB8 File Offset: 0x003901B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShopView other)
		{
			if (other == null)
			{
				return;
			}
			if (other.survivorsOption_ != null)
			{
				if (this.survivorsOption_ == null)
				{
					this.SurvivorsOption = new SurvivorsOption();
				}
				this.SurvivorsOption.MergeFrom(other.SurvivorsOption);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060188CB RID: 100555 RVA: 0x0039200C File Offset: 0x0039020C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060188CC RID: 100556 RVA: 0x00392018 File Offset: 0x00390218
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.survivorsOption_ == null)
					{
						this.SurvivorsOption = new SurvivorsOption();
					}
					input.ReadMessage(this.SurvivorsOption);
				}
			}
		}

		// Token: 0x04009117 RID: 37143
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009118 RID: 37144
		public const int SurvivorsOptionFieldNumber = 1;

		// Token: 0x04009119 RID: 37145
		private SurvivorsOption survivorsOption_;
	}
}
