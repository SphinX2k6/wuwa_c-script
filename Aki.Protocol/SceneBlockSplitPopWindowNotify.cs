using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001149 RID: 4425
	[NetMessage(EMessageId.SceneBlockSplitPopWindowNotify)]
	public sealed class SceneBlockSplitPopWindowNotify : IMessage<SceneBlockSplitPopWindowNotify>, IMessage, IEquatable<SceneBlockSplitPopWindowNotify>, IDeepCloneable<SceneBlockSplitPopWindowNotify>, IBufferMessage
	{
		// Token: 0x06017972 RID: 96626 RVA: 0x0036CB01 File Offset: 0x0036AD01
		[NullableContext(1)]
		public static SceneBlockSplitPopWindowNotify Create()
		{
			return new SceneBlockSplitPopWindowNotify();
		}

		// Token: 0x17004F29 RID: 20265
		// (get) Token: 0x06017973 RID: 96627 RVA: 0x0036CB08 File Offset: 0x0036AD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F2A RID: 20266
		// (get) Token: 0x06017974 RID: 96628 RVA: 0x0036CB0B File Offset: 0x0036AD0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneBlockSplitPopWindowNotify.Descriptor;
			}
		}

		// Token: 0x06017975 RID: 96629 RVA: 0x0036CB12 File Offset: 0x0036AD12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitPopWindowNotify()
		{
		}

		// Token: 0x06017976 RID: 96630 RVA: 0x0036CB1A File Offset: 0x0036AD1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitPopWindowNotify(SceneBlockSplitPopWindowNotify other) : this()
		{
			this.windowType_ = other.windowType_;
			this.blockId_ = other.blockId_;
			this.param1_ = other.param1_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017977 RID: 96631 RVA: 0x0036CB57 File Offset: 0x0036AD57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitPopWindowNotify Clone()
		{
			return new SceneBlockSplitPopWindowNotify(this);
		}

		// Token: 0x17004F2B RID: 20267
		// (get) Token: 0x06017978 RID: 96632 RVA: 0x0036CB5F File Offset: 0x0036AD5F
		// (set) Token: 0x06017979 RID: 96633 RVA: 0x0036CB67 File Offset: 0x0036AD67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ESceneBlockSplitPopWindowType WindowType
		{
			get
			{
				return this.windowType_;
			}
			set
			{
				this.windowType_ = value;
			}
		}

		// Token: 0x17004F2C RID: 20268
		// (get) Token: 0x0601797A RID: 96634 RVA: 0x0036CB70 File Offset: 0x0036AD70
		// (set) Token: 0x0601797B RID: 96635 RVA: 0x0036CB78 File Offset: 0x0036AD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BlockId
		{
			get
			{
				return this.blockId_;
			}
			set
			{
				this.blockId_ = value;
			}
		}

		// Token: 0x17004F2D RID: 20269
		// (get) Token: 0x0601797C RID: 96636 RVA: 0x0036CB81 File Offset: 0x0036AD81
		// (set) Token: 0x0601797D RID: 96637 RVA: 0x0036CB89 File Offset: 0x0036AD89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Param1
		{
			get
			{
				return this.param1_;
			}
			set
			{
				this.param1_ = value;
			}
		}

		// Token: 0x0601797E RID: 96638 RVA: 0x0036CB92 File Offset: 0x0036AD92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneBlockSplitPopWindowNotify);
		}

		// Token: 0x0601797F RID: 96639 RVA: 0x0036CBA0 File Offset: 0x0036ADA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneBlockSplitPopWindowNotify other)
		{
			return other != null && (other == this || (this.WindowType == other.WindowType && this.BlockId == other.BlockId && this.Param1 == other.Param1 && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017980 RID: 96640 RVA: 0x0036CBFC File Offset: 0x0036ADFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WindowType != ESceneBlockSplitPopWindowType.Map)
			{
				num ^= this.WindowType.GetHashCode();
			}
			if (this.BlockId != 0)
			{
				num ^= this.BlockId.GetHashCode();
			}
			if (this.Param1 != 0)
			{
				num ^= this.Param1.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017981 RID: 96641 RVA: 0x0036CC73 File Offset: 0x0036AE73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017982 RID: 96642 RVA: 0x0036CC80 File Offset: 0x0036AE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017983 RID: 96643 RVA: 0x0036CC8C File Offset: 0x0036AE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BlockId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.BlockId);
			}
			if (this.Param1 != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Param1);
			}
			if (this.WindowType != ESceneBlockSplitPopWindowType.Map)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.WindowType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017984 RID: 96644 RVA: 0x0036CD04 File Offset: 0x0036AF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WindowType != ESceneBlockSplitPopWindowType.Map)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.WindowType);
			}
			if (this.BlockId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BlockId);
			}
			if (this.Param1 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Param1);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017985 RID: 96645 RVA: 0x0036CD74 File Offset: 0x0036AF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneBlockSplitPopWindowNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WindowType != ESceneBlockSplitPopWindowType.Map)
			{
				this.WindowType = other.WindowType;
			}
			if (other.BlockId != 0)
			{
				this.BlockId = other.BlockId;
			}
			if (other.Param1 != 0)
			{
				this.Param1 = other.Param1;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017986 RID: 96646 RVA: 0x0036CDD8 File Offset: 0x0036AFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017987 RID: 96647 RVA: 0x0036CDE4 File Offset: 0x0036AFE4
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
				if (num != 40U)
				{
					if (num != 48U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.WindowType = (ESceneBlockSplitPopWindowType)input.ReadEnum();
						}
					}
					else
					{
						this.Param1 = input.ReadInt32();
					}
				}
				else
				{
					this.BlockId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008C0E RID: 35854
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C0F RID: 35855
		public const int WindowTypeFieldNumber = 14;

		// Token: 0x04008C10 RID: 35856
		private ESceneBlockSplitPopWindowType windowType_;

		// Token: 0x04008C11 RID: 35857
		public const int BlockIdFieldNumber = 5;

		// Token: 0x04008C12 RID: 35858
		private int blockId_;

		// Token: 0x04008C13 RID: 35859
		public const int Param1FieldNumber = 6;

		// Token: 0x04008C14 RID: 35860
		private int param1_;
	}
}
