using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001AF RID: 431
	[NetMessage(EMessageId.BlackScreenStatePush)]
	public sealed class BlackScreenStatePush : IMessage<BlackScreenStatePush>, IMessage, IEquatable<BlackScreenStatePush>, IDeepCloneable<BlackScreenStatePush>, IBufferMessage
	{
		// Token: 0x06003280 RID: 12928 RVA: 0x00080815 File Offset: 0x0007EA15
		[NullableContext(1)]
		public static BlackScreenStatePush Create()
		{
			return new BlackScreenStatePush();
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06003281 RID: 12929 RVA: 0x0008081C File Offset: 0x0007EA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06003282 RID: 12930 RVA: 0x0008081F File Offset: 0x0007EA1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackScreenStatePush.Descriptor;
			}
		}

		// Token: 0x06003283 RID: 12931 RVA: 0x00080826 File Offset: 0x0007EA26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackScreenStatePush()
		{
		}

		// Token: 0x06003284 RID: 12932 RVA: 0x00080839 File Offset: 0x0007EA39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackScreenStatePush(BlackScreenStatePush other) : this()
		{
			this.isOpen_ = other.isOpen_;
			this.source_ = other.source_;
			this.blackScreenReason_ = other.blackScreenReason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003285 RID: 12933 RVA: 0x00080876 File Offset: 0x0007EA76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackScreenStatePush Clone()
		{
			return new BlackScreenStatePush(this);
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06003286 RID: 12934 RVA: 0x0008087E File Offset: 0x0007EA7E
		// (set) Token: 0x06003287 RID: 12935 RVA: 0x00080886 File Offset: 0x0007EA86
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

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06003288 RID: 12936 RVA: 0x0008088F File Offset: 0x0007EA8F
		// (set) Token: 0x06003289 RID: 12937 RVA: 0x00080897 File Offset: 0x0007EA97
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

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x0600328A RID: 12938 RVA: 0x000808A0 File Offset: 0x0007EAA0
		// (set) Token: 0x0600328B RID: 12939 RVA: 0x000808A8 File Offset: 0x0007EAA8
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

		// Token: 0x0600328C RID: 12940 RVA: 0x000808BB File Offset: 0x0007EABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackScreenStatePush);
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x000808CC File Offset: 0x0007EACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackScreenStatePush other)
		{
			return other != null && (other == this || (this.IsOpen == other.IsOpen && this.Source == other.Source && !(this.BlackScreenReason != other.BlackScreenReason) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600328E RID: 12942 RVA: 0x0008092C File Offset: 0x0007EB2C
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

		// Token: 0x0600328F RID: 12943 RVA: 0x000809A5 File Offset: 0x0007EBA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003290 RID: 12944 RVA: 0x000809B2 File Offset: 0x0007EBB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x000809BC File Offset: 0x0007EBBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsOpen)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsOpen);
			}
			if (this.Source != BlackScreenSourceType.BehaviorTreeNode)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.Source);
			}
			if (this.BlackScreenReason.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.BlackScreenReason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x00080A38 File Offset: 0x0007EC38
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

		// Token: 0x06003293 RID: 12947 RVA: 0x00080AA0 File Offset: 0x0007ECA0
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

		// Token: 0x06003294 RID: 12948 RVA: 0x00080B09 File Offset: 0x0007ED09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003295 RID: 12949 RVA: 0x00080B14 File Offset: 0x0007ED14
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
					if (num != 112U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.IsOpen = input.ReadBool();
				}
			}
		}

		// Token: 0x040029D0 RID: 10704
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029D1 RID: 10705
		public const int IsOpenFieldNumber = 8;

		// Token: 0x040029D2 RID: 10706
		private bool isOpen_;

		// Token: 0x040029D3 RID: 10707
		public const int SourceFieldNumber = 14;

		// Token: 0x040029D4 RID: 10708
		private BlackScreenSourceType source_;

		// Token: 0x040029D5 RID: 10709
		public const int BlackScreenReasonFieldNumber = 15;

		// Token: 0x040029D6 RID: 10710
		private string blackScreenReason_ = "";
	}
}
