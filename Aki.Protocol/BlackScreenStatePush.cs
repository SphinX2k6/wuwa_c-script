using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001AB RID: 427
	[NetMessage(EMessageId.BlackScreenStatePush)]
	public sealed class BlackScreenStatePush : IMessage<BlackScreenStatePush>, IMessage, IEquatable<BlackScreenStatePush>, IDeepCloneable<BlackScreenStatePush>, IBufferMessage
	{
		// Token: 0x060031F3 RID: 12787 RVA: 0x0007F0A9 File Offset: 0x0007D2A9
		[NullableContext(1)]
		public static BlackScreenStatePush Create()
		{
			return new BlackScreenStatePush();
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x060031F4 RID: 12788 RVA: 0x0007F0B0 File Offset: 0x0007D2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x060031F5 RID: 12789 RVA: 0x0007F0B3 File Offset: 0x0007D2B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackScreenStatePush.Descriptor;
			}
		}

		// Token: 0x060031F6 RID: 12790 RVA: 0x0007F0BA File Offset: 0x0007D2BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackScreenStatePush()
		{
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x0007F0CD File Offset: 0x0007D2CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackScreenStatePush(BlackScreenStatePush other) : this()
		{
			this.isOpen_ = other.isOpen_;
			this.source_ = other.source_;
			this.blackScreenReason_ = other.blackScreenReason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x0007F10A File Offset: 0x0007D30A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackScreenStatePush Clone()
		{
			return new BlackScreenStatePush(this);
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x060031F9 RID: 12793 RVA: 0x0007F112 File Offset: 0x0007D312
		// (set) Token: 0x060031FA RID: 12794 RVA: 0x0007F11A File Offset: 0x0007D31A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOpen
		{
			get
			{
				return this.isOpen_;
			}
			set
			{
				this.isOpen_ = value;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x060031FB RID: 12795 RVA: 0x0007F123 File Offset: 0x0007D323
		// (set) Token: 0x060031FC RID: 12796 RVA: 0x0007F12B File Offset: 0x0007D32B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackScreenSourceType Source
		{
			get
			{
				return this.source_;
			}
			set
			{
				this.source_ = value;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x060031FD RID: 12797 RVA: 0x0007F134 File Offset: 0x0007D334
		// (set) Token: 0x060031FE RID: 12798 RVA: 0x0007F13C File Offset: 0x0007D33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string BlackScreenReason
		{
			get
			{
				return this.blackScreenReason_;
			}
			set
			{
				this.blackScreenReason_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x0007F14F File Offset: 0x0007D34F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackScreenStatePush);
		}

		// Token: 0x06003200 RID: 12800 RVA: 0x0007F160 File Offset: 0x0007D360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackScreenStatePush other)
		{
			return other != null && (other == this || (this.IsOpen == other.IsOpen && this.Source == other.Source && !(this.BlackScreenReason != other.BlackScreenReason) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003201 RID: 12801 RVA: 0x0007F1C0 File Offset: 0x0007D3C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsOpen)
			{
				num ^= this.IsOpen.GetHashCode();
			}
			if (this.Source != BlackScreenSourceType.BehaviorTreeNode)
			{
				num ^= this.Source.GetHashCode();
			}
			if (this.BlackScreenReason.Length != 0)
			{
				num ^= this.BlackScreenReason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x0007F239 File Offset: 0x0007D439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x0007F246 File Offset: 0x0007D446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x0007F250 File Offset: 0x0007D450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Source != BlackScreenSourceType.BehaviorTreeNode)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Source);
			}
			if (this.BlackScreenReason.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.BlackScreenReason);
			}
			if (this.IsOpen)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsOpen);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x0007F2CC File Offset: 0x0007D4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsOpen)
			{
				num += 2;
			}
			if (this.Source != BlackScreenSourceType.BehaviorTreeNode)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Source);
			}
			if (this.BlackScreenReason.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BlackScreenReason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003206 RID: 12806 RVA: 0x0007F334 File Offset: 0x0007D534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlackScreenStatePush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsOpen)
			{
				this.IsOpen = other.IsOpen;
			}
			if (other.Source != BlackScreenSourceType.BehaviorTreeNode)
			{
				this.Source = other.Source;
			}
			if (other.BlackScreenReason.Length != 0)
			{
				this.BlackScreenReason = other.BlackScreenReason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003207 RID: 12807 RVA: 0x0007F39D File Offset: 0x0007D59D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x0007F3A8 File Offset: 0x0007D5A8
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
				if (num != 80U)
				{
					if (num != 98U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsOpen = input.ReadBool();
						}
					}
					else
					{
						this.BlackScreenReason = input.ReadString();
					}
				}
				else
				{
					this.Source = (BlackScreenSourceType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002955 RID: 10581
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002956 RID: 10582
		public const int IsOpenFieldNumber = 15;

		// Token: 0x04002957 RID: 10583
		private bool isOpen_;

		// Token: 0x04002958 RID: 10584
		public const int SourceFieldNumber = 10;

		// Token: 0x04002959 RID: 10585
		private BlackScreenSourceType source_;

		// Token: 0x0400295A RID: 10586
		public const int BlackScreenReasonFieldNumber = 12;

		// Token: 0x0400295B RID: 10587
		private string blackScreenReason_ = "";
	}
}
