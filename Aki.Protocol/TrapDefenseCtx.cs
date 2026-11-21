using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001490 RID: 5264
	public sealed class TrapDefenseCtx : IMessage<TrapDefenseCtx>, IMessage, IEquatable<TrapDefenseCtx>, IDeepCloneable<TrapDefenseCtx>, IBufferMessage
	{
		// Token: 0x0601BF3B RID: 114491 RVA: 0x0040FB3D File Offset: 0x0040DD3D
		[NullableContext(1)]
		public static TrapDefenseCtx Create()
		{
			return new TrapDefenseCtx();
		}

		// Token: 0x17005EA7 RID: 24231
		// (get) Token: 0x0601BF3C RID: 114492 RVA: 0x0040FB44 File Offset: 0x0040DD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EA8 RID: 24232
		// (get) Token: 0x0601BF3D RID: 114493 RVA: 0x0040FB47 File Offset: 0x0040DD47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseCtx.Descriptor;
			}
		}

		// Token: 0x0601BF3E RID: 114494 RVA: 0x0040FB4E File Offset: 0x0040DD4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseCtx()
		{
		}

		// Token: 0x0601BF3F RID: 114495 RVA: 0x0040FB56 File Offset: 0x0040DD56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseCtx(TrapDefenseCtx other) : this()
		{
			this.configId_ = other.configId_;
			this.newChallenge_ = other.newChallenge_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BF40 RID: 114496 RVA: 0x0040FB87 File Offset: 0x0040DD87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseCtx Clone()
		{
			return new TrapDefenseCtx(this);
		}

		// Token: 0x17005EA9 RID: 24233
		// (get) Token: 0x0601BF41 RID: 114497 RVA: 0x0040FB8F File Offset: 0x0040DD8F
		// (set) Token: 0x0601BF42 RID: 114498 RVA: 0x0040FB97 File Offset: 0x0040DD97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17005EAA RID: 24234
		// (get) Token: 0x0601BF43 RID: 114499 RVA: 0x0040FBA0 File Offset: 0x0040DDA0
		// (set) Token: 0x0601BF44 RID: 114500 RVA: 0x0040FBA8 File Offset: 0x0040DDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NewChallenge
		{
			get
			{
				return this.newChallenge_;
			}
			set
			{
				this.newChallenge_ = value;
			}
		}

		// Token: 0x0601BF45 RID: 114501 RVA: 0x0040FBB1 File Offset: 0x0040DDB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseCtx);
		}

		// Token: 0x0601BF46 RID: 114502 RVA: 0x0040FBBF File Offset: 0x0040DDBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseCtx other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.NewChallenge == other.NewChallenge && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BF47 RID: 114503 RVA: 0x0040FC00 File Offset: 0x0040DE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.NewChallenge)
			{
				num ^= this.NewChallenge.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BF48 RID: 114504 RVA: 0x0040FC58 File Offset: 0x0040DE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BF49 RID: 114505 RVA: 0x0040FC65 File Offset: 0x0040DE65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BF4A RID: 114506 RVA: 0x0040FC70 File Offset: 0x0040DE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.NewChallenge)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.NewChallenge);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BF4B RID: 114507 RVA: 0x0040FCC8 File Offset: 0x0040DEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.NewChallenge)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BF4C RID: 114508 RVA: 0x0040FD14 File Offset: 0x0040DF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.NewChallenge)
			{
				this.NewChallenge = other.NewChallenge;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BF4D RID: 114509 RVA: 0x0040FD64 File Offset: 0x0040DF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BF4E RID: 114510 RVA: 0x0040FD70 File Offset: 0x0040DF70
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NewChallenge = input.ReadBool();
					}
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A20E RID: 41486
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A20F RID: 41487
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x0400A210 RID: 41488
		private int configId_;

		// Token: 0x0400A211 RID: 41489
		public const int NewChallengeFieldNumber = 2;

		// Token: 0x0400A212 RID: 41490
		private bool newChallenge_;
	}
}
