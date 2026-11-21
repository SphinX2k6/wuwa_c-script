using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001183 RID: 4483
	[NetMessage(EMessageId.SceneBlockSplitPopWindowNotify)]
	public sealed class SceneBlockSplitPopWindowNotify : IMessage<SceneBlockSplitPopWindowNotify>, IMessage, IEquatable<SceneBlockSplitPopWindowNotify>, IDeepCloneable<SceneBlockSplitPopWindowNotify>, IBufferMessage
	{
		// Token: 0x06017F13 RID: 98067 RVA: 0x0037BE4D File Offset: 0x0037A04D
		[NullableContext(1)]
		public static SceneBlockSplitPopWindowNotify Create()
		{
			return new SceneBlockSplitPopWindowNotify();
		}

		// Token: 0x17005095 RID: 20629
		// (get) Token: 0x06017F14 RID: 98068 RVA: 0x0037BE54 File Offset: 0x0037A054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005096 RID: 20630
		// (get) Token: 0x06017F15 RID: 98069 RVA: 0x0037BE57 File Offset: 0x0037A057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneBlockSplitPopWindowNotify.Descriptor;
			}
		}

		// Token: 0x06017F16 RID: 98070 RVA: 0x0037BE5E File Offset: 0x0037A05E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitPopWindowNotify()
		{
		}

		// Token: 0x06017F17 RID: 98071 RVA: 0x0037BE66 File Offset: 0x0037A066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitPopWindowNotify(SceneBlockSplitPopWindowNotify other) : this()
		{
			this.windowType_ = other.windowType_;
			this.blockId_ = other.blockId_;
			this.param1_ = other.param1_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017F18 RID: 98072 RVA: 0x0037BEA3 File Offset: 0x0037A0A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitPopWindowNotify Clone()
		{
			return new SceneBlockSplitPopWindowNotify(this);
		}

		// Token: 0x17005097 RID: 20631
		// (get) Token: 0x06017F19 RID: 98073 RVA: 0x0037BEAB File Offset: 0x0037A0AB
		// (set) Token: 0x06017F1A RID: 98074 RVA: 0x0037BEB3 File Offset: 0x0037A0B3
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

		// Token: 0x17005098 RID: 20632
		// (get) Token: 0x06017F1B RID: 98075 RVA: 0x0037BEBC File Offset: 0x0037A0BC
		// (set) Token: 0x06017F1C RID: 98076 RVA: 0x0037BEC4 File Offset: 0x0037A0C4
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

		// Token: 0x17005099 RID: 20633
		// (get) Token: 0x06017F1D RID: 98077 RVA: 0x0037BECD File Offset: 0x0037A0CD
		// (set) Token: 0x06017F1E RID: 98078 RVA: 0x0037BED5 File Offset: 0x0037A0D5
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

		// Token: 0x06017F1F RID: 98079 RVA: 0x0037BEDE File Offset: 0x0037A0DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneBlockSplitPopWindowNotify);
		}

		// Token: 0x06017F20 RID: 98080 RVA: 0x0037BEEC File Offset: 0x0037A0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneBlockSplitPopWindowNotify other)
		{
			return other != null && (other == this || (this.WindowType == other.WindowType && this.BlockId == other.BlockId && this.Param1 == other.Param1 && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017F21 RID: 98081 RVA: 0x0037BF48 File Offset: 0x0037A148
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

		// Token: 0x06017F22 RID: 98082 RVA: 0x0037BFBF File Offset: 0x0037A1BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017F23 RID: 98083 RVA: 0x0037BFCC File Offset: 0x0037A1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017F24 RID: 98084 RVA: 0x0037BFD8 File Offset: 0x0037A1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BlockId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BlockId);
			}
			if (this.WindowType != ESceneBlockSplitPopWindowType.Map)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.WindowType);
			}
			if (this.Param1 != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Param1);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017F25 RID: 98085 RVA: 0x0037C050 File Offset: 0x0037A250
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

		// Token: 0x06017F26 RID: 98086 RVA: 0x0037C0C0 File Offset: 0x0037A2C0
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

		// Token: 0x06017F27 RID: 98087 RVA: 0x0037C124 File Offset: 0x0037A324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017F28 RID: 98088 RVA: 0x0037C130 File Offset: 0x0037A330
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
				if (num != 32U)
				{
					if (num != 64U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Param1 = input.ReadInt32();
						}
					}
					else
					{
						this.WindowType = (ESceneBlockSplitPopWindowType)input.ReadEnum();
					}
				}
				else
				{
					this.BlockId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008EA1 RID: 36513
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008EA2 RID: 36514
		public const int WindowTypeFieldNumber = 8;

		// Token: 0x04008EA3 RID: 36515
		private ESceneBlockSplitPopWindowType windowType_;

		// Token: 0x04008EA4 RID: 36516
		public const int BlockIdFieldNumber = 4;

		// Token: 0x04008EA5 RID: 36517
		private int blockId_;

		// Token: 0x04008EA6 RID: 36518
		public const int Param1FieldNumber = 14;

		// Token: 0x04008EA7 RID: 36519
		private int param1_;
	}
}
